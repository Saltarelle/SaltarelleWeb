using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Generator.AstNodes;
using NUnit.Framework;

namespace Generator.Tests {
	public class WebIDLResolverTests {
		private string Format(Dictionary<string, ResolvedDefinition> types) {
			var sb = new StringBuilder();
			foreach (var t in types.OrderBy(x => x.Key).Select(x => x.Value)) {
				t.Decompose(
					@interface => {
						if (@interface.ExtendedAttributes.Count > 0)
							sb.Append("[" + string.Join(", ", @interface.ExtendedAttributes.Select(WebIDLFormatter.Format)) + "] ");
						sb.Append("interface " + @interface.Name + " ");
						if (@interface.Base != null)
							sb.Append(": " + @interface.Base + " ");
						sb.AppendLine("{");
						foreach (var imp in @interface.Implements.OrderBy(x => x))
							sb.AppendLine("\timplements " + imp + ";");
						sb.Append(string.Join("", @interface.Members.Select(m => "\t" + WebIDLFormatter.Format(m))));
						sb.Append("}");
					},
					callbackInterface => {
						if (callbackInterface.ExtendedAttributes.Count > 0)
							sb.Append("[" + string.Join(", ", callbackInterface.ExtendedAttributes.Select(WebIDLFormatter.Format)) + "] ");
						sb.Append("callback interface " + callbackInterface.Name + " ");
						if (callbackInterface.Base != null)
							sb.Append(": " + callbackInterface.Base + " ");
						sb.AppendLine("{");
						sb.Append(string.Join("", callbackInterface.Members.Select(m => "\t" + WebIDLFormatter.Format(m))));
						sb.Append("}");
					},
					dictionary => {
						if (dictionary.ExtendedAttributes.Count > 0)
							sb.Append("[" + string.Join(", ", dictionary.ExtendedAttributes.Select(WebIDLFormatter.Format)) + "] ");
						sb.Append("dictionary " + dictionary.Name + " ");
						if (dictionary.Base != null)
							sb.Append(": " + dictionary.Base + " ");
						sb.AppendLine("{");
						sb.Append(string.Join("", dictionary.Members.Select(m => "\t" + WebIDLFormatter.Format(m))));
						sb.Append("}");
					},
					callback => {
						if (callback.ExtendedAttributes.Count > 0)
							sb.Append("[" + string.Join(", ", callback.ExtendedAttributes.Select(WebIDLFormatter.Format)) + "] ");
						sb.Append("callback " + callback.Name + " = " + WebIDLFormatter.Format(callback.ReturnType) + " ");
						sb.Append("(" + string.Join(", ", callback.Arguments.Select(WebIDLFormatter.Format)) + ")");
					},
					exception => {
						if (exception.ExtendedAttributes.Count > 0)
							sb.Append("[" + string.Join(", ", exception.ExtendedAttributes.Select(WebIDLFormatter.Format)) + "] ");
						sb.Append("exception " + exception.Name + " ");
						if (exception.Base != null)
							sb.Append(": " + exception.Base + " ");
						sb.AppendLine("{");
						sb.Append(string.Join("", exception.Members.Select(m => "\t" + WebIDLFormatter.Format(m))));
						sb.Append("}");
					},
					@enum => {
						if (@enum.ExtendedAttributes.Count > 0)
							sb.Append("[" + string.Join(", ", @enum.ExtendedAttributes.Select(WebIDLFormatter.Format)) + "] ");
						sb.Append("enum " + @enum.Name + " { " + string.Join(", ", @enum.Values.Select(v => "\"" + v + "\"")) + " }");
					},
					declaredInterface => {
						sb.Append("interface " + declaredInterface.Name);
					}
				);
				sb.AppendLine(";");
			}

			return sb.ToString();
		}

		private void AssertCorrect(string webidl, string expected) {
			var ast = WebIDLParser.Parse(new StringReader(webidl));
			var resolved = WebIDLResolver.Resolve(new[] { ast });
			string actual = (resolved.Item2.Count > 0 ? string.Join("\n", resolved.Item2.Select(s => "error: " + s)) + "\n\n": "") + Format(resolved.Item1);

			Assert.That(actual.Trim().Replace("\r\n", "\n"), Is.EqualTo(expected.Trim().Replace("\r\n", "\n")), "Expected:\n" + expected + "\n\nActual:\n" + actual);
		}

		[Test]
		public void PartialInterfaceMergesBothExtendedAttributesAndMembers() {
			AssertCorrect(@"
interface IBase {};
[Attr1] partial interface I1 {  void method1(); };
[Attr2] interface I1 : IBase { readonly attribute long a1; };
[Attr3] partial interface I1 { readonly attribute Object a2; };
[Attr2] interface I2 : IBase { readonly attribute long long a1; };
[Attr1] partial interface I2 { void method1(); };
[Attr3] partial interface I2 { readonly attribute any a2; };
",
@"[Attr1, Attr2, Attr3] interface I1 : IBase {
	void method1();
	readonly attribute long a1;
	readonly attribute Object a2;
};
[Attr2, Attr1, Attr3] interface I2 : IBase {
	readonly attribute long long a1;
	void method1();
	readonly attribute any a2;
};
interface IBase {
};");
		}

		[Test]
		public void PartialInterfaceWithoutFullInterfaceWorksButShowsErrors() {
			AssertCorrect(@"
[Attr1] partial interface I1 {  void method1(); };
[Attr3] partial interface I1 { readonly attribute Object a2; };
",
@"error: There was no non-partial definition of the interface `I1'

[Attr1, Attr3] interface I1 {
	void method1();
	readonly attribute Object a2;
};");
		}

		[Test]
		public void DuplicateInterfaceDefinitionIsError() {
			AssertCorrect(@"
[Attr1] interface I1 {  void method1(); };
[Attr3] interface I1 { readonly attribute Object a2; };
",
@"error: Duplicate definition of interface `I1'

[Attr1, Attr3] interface I1 {
	void method1();
	readonly attribute Object a2;
};");
		}

		[Test]
		public void InheritingInterfaceFromNonExistentOrNonInterfaceTypeIsAnError() {
			AssertCorrect(@"
dictionary D1 {};
interface I1 : D1 {};
interface I2 : NonExistent {};
",
@"error: The interface `I1' cannot inherit from the dictionary `D1'
error: The base type `NonExistent' for the interface `I2' does not exist

dictionary D1 {
};
interface I1 {
};
interface I2 {
};
");
		}

		[Test]
		public void PartialDictionaryCombinesBothExtendedAttributesAndMembers() {
			AssertCorrect(@"
dictionary DBase {};
[Attr1] partial dictionary D1 { long f1; };
[Attr2] dictionary D1 : DBase { Object f2 = 0; };
[Attr3] partial dictionary D1 { DOMString f3; };
[Attr2] dictionary D2 : DBase { long f1; };
[Attr1] partial dictionary D2 { Object f2 = 0; };
[Attr3] partial dictionary D2 { DOMString f3; };
",
@"[Attr1, Attr2, Attr3] dictionary D1 : DBase {
	long f1;
	Object f2 = 0;
	DOMString f3;
};
[Attr2, Attr1, Attr3] dictionary D2 : DBase {
	long f1;
	Object f2 = 0;
	DOMString f3;
};
dictionary DBase {
};
");
		}

		[Test]
		public void PartialDictionaryWithoutFullInterfaceWorksButShowsErrors() {
			AssertCorrect(@"
[Attr1] partial dictionary D1 { long a; };
[Attr2] partial dictionary D1 { long b; };
",
@"error: There was no non-partial definition of the dictionary `D1'

[Attr1, Attr2] dictionary D1 {
	long a;
	long b;
};");
		}

		[Test]
		public void DuplicateDictionaryDefinitionIsError() {
			AssertCorrect(@"
[Attr1] dictionary D1 { long a; };
[Attr2] dictionary D1 { long b; };
",
@"error: Duplicate definition of dictionary `D1'

[Attr1, Attr2] dictionary D1 {
	long a;
	long b;
};");
		}

		[Test]
		public void InheritingDictionaryFromNonExistentOrNonDictionaryTypeIsAnError() {
			AssertCorrect(@"
interface I1 {};
dictionary D1 : I1 {};
dictionary D2 : NonExistent {};
",
@"error: The dictionary `D1' cannot inherit from the interface `I1'
error: The base type `NonExistent' for the dictionary `D2' does not exist

dictionary D1 {
};
dictionary D2 {
};
interface I1 {
};");
		}

		[Test]
		public void CallbackInterfaceWorks() {
			AssertCorrect(@"
callback interface IBase {};
[Attr1] callback interface I1 : IBase { void method1(); };
",
@"[Attr1] callback interface I1 : IBase {
	void method1();
};
callback interface IBase {
};");
		}

		[Test]
		public void DuplicateCallbackInterfaceIsAnError() {
			AssertCorrect(@"
callback interface IBase {};
[Attr1] callback interface I1 : IBase { void method1(); };
[Attr2] callback interface I1 : IBase { void method2(); };
",
@"error: Redefinition of callback interface `I1'

[Attr1] callback interface I1 : IBase {
	void method1();
};
callback interface IBase {
};
");
		}

		[Test]
		public void InheritingCallbackInterfaceFromNonExistentOrNonCallbackInterfaceTypeIsAnError() {
			AssertCorrect(@"
interface I1 {};
callback interface CI1 : I1 {};
callback interface CI2 : NonExistent {};
",
@"error: The callback interface `CI1' cannot inherit from the interface `I1'
error: The base type `NonExistent' for the callback interface `CI2' does not exist

callback interface CI1 {
};
callback interface CI2 {
};
interface I1 {
};");
		}

		[Test]
		public void CallbackWorks() {
			AssertCorrect(@"
[Attr1] callback MyCallback = void (DOMString a, long b);
",
@"[Attr1] callback MyCallback = void (DOMString a, long b);
");
		}

		[Test]
		public void RedefinitionOfCallbackIsAnError() {
			AssertCorrect(@"
[Attr1] callback MyCallback = void (DOMString a, long b);
[Attr1] callback MyCallback = void (DOMString a, long b);
",
@"error: Redefinition of callback `MyCallback'

[Attr1] callback MyCallback = void (DOMString a, long b);
");
		}

		[Test]
		public void ExceptionWorks() {
			AssertCorrect(
@"exception Ex {
	const long member1 = 10;
	short member2;
};
",
@"exception Ex {
	const long member1 = 10;
	short member2;
};
");
		}

		[Test]
		public void RedefinitionOfExceptionIsAnError() {
			AssertCorrect(
@"exception Ex { const long member1 = 10; };
exception Ex { const long member1 = 10; };
",
@"error: Redefinition of exception `Ex'

exception Ex {
	const long member1 = 10;
};
");
		}

		[Test]
		public void InheritingExceptionFromNonExistentOrNonExceptionTypeIsAnError() {
			AssertCorrect(@"
interface I1 {};
exception E1 : I1 {};
exception E2 : NonExistent {};
",
@"error: The exception `E1' cannot inherit from the interface `I1'
error: The base type `NonExistent' for the exception `E2' does not exist

exception E1 {
};
exception E2 {
};
interface I1 {
};");
		}

		[Test]
		public void RedefinitionOfTypedefIsAnError() {
			AssertCorrect(
@"typedef long MyType;
typedef long MyType;
",
@"error: Redefinition of typedef `MyType'
");
		}

		[Test]
		public void InterfaceDeclarationDoesNothing() {
			AssertCorrect(
@"interface I1;
interface I2;
interface I2 {};
interface I3 {};
interface I3;
",
@"interface I2 {
};
interface I3 {
};
");
		}

		[Test]
		public void InterfaceDeclarationGivesAnErrorIfTypeIsRedefinedAsAnotherType() {
			AssertCorrect(
@"interface T1;
dictionary T1 {};
dictionary T2 {};
interface T2;
",
@"error: Type `T1' was defined as interface but redefined as dictionary
error: Type `T2' was defined as dictionary but redefined as interface

dictionary T2 {
};
");
		}

		[Test]
		public void EnumWorks() {
			AssertCorrect(
@"enum E1 { ""value1"", ""value2"", ""value3"" };",
@"enum E1 { ""value1"", ""value2"", ""value3"" };
");
		}

		[Test]
		public void RedefinitionOfEnumIsAnError() {
			AssertCorrect(
@"enum E1 { ""value1"", ""value2"", ""value3"" };
enum E1 { ""value1"", ""value2"", ""value3"" };",
@"error: Redefinition of enum `E1'

enum E1 { ""value1"", ""value2"", ""value3"" };
");
		}

		[Test]
		public void RedefinitionOfInterfaceAsDictionaryIsAnError() {
			AssertCorrect(
@"interface T {};
dictionary T {};
",
@"error: Type `T' was defined as interface but redefined as dictionary

interface T {
};");
		}

		[Test]
		public void ImplementsStatementWorks() {
			AssertCorrect(
@"interface I1 {};
interface I2 {};
interface I4 {};
I1 implements I2;
I1 implements I3;
I4 implements I3;
interface I3 {};
",
@"interface I1 {
	implements I2;
	implements I3;
};
interface I2 {
};
interface I3 {
};
interface I4 {
	implements I3;
};
");
		}

		[Test]
		public void TransitiveImplementsStatementsWork() {
			AssertCorrect(@"
interface I1 {};
interface I2 {};
interface I3 {};
interface I4 {};
interface I5 {};
interface I6 {};
I1 implements I2;
I2 implements I3;
I3 implements I4;
I3 implements I5;
I2 implements I6;
I6 implements I4;
",
@"interface I1 {
	implements I2;
	implements I3;
	implements I4;
	implements I5;
	implements I6;
};
interface I2 {
	implements I3;
	implements I4;
	implements I5;
	implements I6;
};
interface I3 {
	implements I4;
	implements I5;
};
interface I4 {
};
interface I5 {
};
interface I6 {
	implements I4;
};
");
		}

		[Test]
		public void ImplementsStatementsSpecifyingNonInterfacesGiveErrors() {
			AssertCorrect(
@"dictionary D1 {};
dictionary D2 {};
interface I1 {};
interface I2 {};

D1 implements D2;
I1 implements D1;
D1 implements I1;
I1 implements INonExistent;
INonExistent2 implements I1;
",
@"error: The type `D1' cannot implement `D2' because the type `D1' is a dictionary, not an interface
error: The interface `I1' cannot implement `D1' because the type `D1' is a dictionary, not an interface
error: The type `D1' cannot implement `I1' because the type `D1' is a dictionary, not an interface
error: The interface `INonExistent', supposed to be implemented by `I1', does not exist
error: The interface `INonExistent2', supposed to implement `I1', does not exist

dictionary D1 {
};
dictionary D2 {
};
interface I1 {
};
interface I2 {
};

");
		}

		[Test]
		public void CycleInImplementsGivesAnError() {
			AssertCorrect(@"
interface I1 {};
interface I2 {};
interface I3 {};
interface I4 {};
I1 implements I2;
I2 implements I3;
I3 implements I1;
I4 implements I2;
",
@"error: Circular implementation involving the interfaces `I3', `I2', `I1'

interface I1 {
	implements I2;
};
interface I2 {
	implements I3;
};
interface I3 {
	implements I1;
};
interface I4 {
	implements I2;
	implements I3;
};

");
		}

		[Test]
		public void UnionMembersAreFlattened() {
			AssertCorrect(@"
dictionary D {
	(long or short or (Date or float)? or (DOMString or (long long or unsigned long long) or Object)) m1;
	(long or (double or float)[] or short) m2;
};
",
@"dictionary D {
	(long or short or Date or float or DOMString or long long or unsigned long long or Object) m1;
	(long or (double or float)[] or short) m2;
};");
		}

		[Test]
		public void TypedefsAreExpandedInCallbackInterfaces() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
typedef [Attr2] long Type2;
typedef [Attr3] long Type3;
typedef [Attr4] long Type4;
[Constructor([Attr5] Type1 t)] interface I1 {
	[Attr6([Attr7] Type2 a)] const Type2 c = 0;
	[Attr7([Attr8] Type3 a)] Type2 m([Attr9] Type3 a, Type4 b);
	[Attr8([Attr9] Type4 a)] Type3 ([Attr8] Type4 a);
	[Attr9([Attr5] Type1 a)] attribute Type4 attr;
};",
@"[Constructor([Attr5, Attr1] long t)] interface I1 {
	[Attr6([Attr7, Attr2] long a), Attr2]
	const long c = 0;
	[Attr7([Attr8, Attr3] long a), Attr2]
	long m([Attr9, Attr3] long a, [Attr4] long b);
	[Attr8([Attr9, Attr4] long a), Attr3]
	long([Attr8, Attr4] long a);
	[Attr9([Attr5, Attr1] long a), Attr4]
	attribute long attr;
};
");
		}

		[Test]
		public void TypedefsAreExpandedInInterfaces() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
typedef [Attr2] long Type2;
typedef [Attr3] long Type3;
typedef [Attr4] long Type4;
[Constructor([Attr5] Type1 t)] interface I1 {
	[Attr6([Attr7] Type2 a)] const Type2 c = 0;
	[Attr7([Attr8] Type3 a)] Type2 m([Attr9] Type3 a, Type4 b);
	[Attr8([Attr9] Type4 a)] Type3 ([Attr8] Type4 a);
	[Attr9([Attr5] Type1 a)] attribute Type4 attr;
};",
@"[Constructor([Attr5, Attr1] long t)] interface I1 {
	[Attr6([Attr7, Attr2] long a), Attr2]
	const long c = 0;
	[Attr7([Attr8, Attr3] long a), Attr2]
	long m([Attr9, Attr3] long a, [Attr4] long b);
	[Attr8([Attr9, Attr4] long a), Attr3]
	long([Attr8, Attr4] long a);
	[Attr9([Attr5, Attr1] long a), Attr4]
	attribute long attr;
};
");
		}

		[Test]
		public void TypedefsAreExpandedInDictionaries() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
typedef [Attr2] long Type2;
typedef [Attr3] long Type3;
[Constructor([Attr5] Type1 t)] dictionary D1 {
	[Attr6([Attr7] Type2 a)] Type3 c = 0;
};",
@"[Constructor([Attr5, Attr1] long t)] dictionary D1 {
	[Attr6([Attr7, Attr2] long a), Attr3]
	long c = 0;
};");
		}

		[Test]
		public void TypedefsAreExpandedInExceptions() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
typedef [Attr2] long Type2;
typedef [Attr3] long Type3;
typedef [Attr4] long Type4;
[Constructor([Attr5] Type1 t)] exception E1 {
	[Attr6([Attr7] Type2 a)] const Type3 c = 0;
	[Attr9([Attr5] Type3 a)] Type4 attr;
};",
@"[Constructor([Attr5, Attr1] long t)] exception E1 {
	[Attr6([Attr7, Attr2] long a), Attr3]
	const long c = 0;
	[Attr9([Attr5, Attr3] long a), Attr4]
	long attr;
};
");
		}

		[Test]
		public void TypedefsAreExpandedInCallbacks() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
typedef [Attr2] long Type2;
typedef [Attr3] long Type3;
typedef [Attr4] long Type4;
[Constructor([Attr5] Type1 t)] callback MyCallback = Type2 ([Attr6([Attr7] Type3 a)] Type4 x, [Attr8] Type2 y);",
@"[Constructor([Attr5, Attr1] long t), Attr2] callback MyCallback = long ([Attr6([Attr7, Attr3] long a), Attr4] long x, [Attr8, Attr2] long y);
");
		}

		[Test]
		public void TypedefsAreExpandedInEnums() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
[Constructor([Attr5] Type1 t)] enum MyEnum { ""X"", ""Y"" };
",
@"[Constructor([Attr5, Attr1] long t)] enum MyEnum { ""X"", ""Y"" };
");
		}

		[Test]
		public void TypedefsAreExpandedInAllTypesOfExtendedAttributes() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
typedef [Attr2] long Type2;
[C1, C2([Attr5] Type1 x, [Attr6] Type2 y), C2=Ident([Attr5] Type1 x, [Attr6] Type2 y), C3=AB, C4=""XY""] interface I1 {};
",
@"[C1, C2([Attr5, Attr1] long x, [Attr6, Attr2] long y), C2=Ident([Attr5, Attr1] long x, [Attr6, Attr2] long y), C3=AB, C4=""XY""] interface I1 {
};
");
		}

		[Test]
		public void TypedefsAreExpandedInAllTypesOfArguments() {
			AssertCorrect(
@"typedef [Attr1] long Type1;
typedef [Attr2] long Type2;
interface I1 {
	void m1([Attr5] Type1 a, [Attr6] Type2 b);
	void m2([Attr5] optional Type1 a, [Attr6] optional Type2 b = 10);
	void m1([Attr5] Type1 a, [Attr6] Type2... b);
};
",
@"interface I1 {
	void m1([Attr5, Attr1] long a, [Attr6, Attr2] long b);
	void m2([Attr5, Attr1] optional long a, [Attr6, Attr2] optional long b = 10);
	void m1([Attr5, Attr1] long a, [Attr6, Attr2] long... b);
};");
		}

		[Test]
		public void UseOfUndeclaredTypeIsAnErrorAndDeclaresTheSymbolAsAnInterface() {
			AssertCorrect(
@"interface I1 {
	void m1(SomeType a);
};
",
@"error: The type `SomeType' does not exist.

interface I1 {
	void m1(SomeType a);
};
interface SomeType;");
		}

		[Test]
		public void NestedTypedefsWork() {
			AssertCorrect(@"
typedef [Attr1] long Type1;
typedef [Attr2] Type1 Type2;
typedef [Attr3] Type2 Type3;
interface I1 {
	[Attr4] attribute Type3 x;
};
",
@"interface I1 {
	[Attr4, Attr3, Attr2, Attr1]
	attribute long x;
};");
		}

		[Test]
		public void AttributesArePreservedThroughNullables() {
			AssertCorrect(@"
typedef [Attr1] long Type1;
typedef [Attr2] Type1 Type2;
interface I1 {
	[Attr3] attribute Type2? x;
};
",
@"interface I1 {
	[Attr3, Attr2, Attr1]
	attribute long? x;
};");
		}

		[Test]
		public void NestedNullableIsOnlyNullableOnce() {
			AssertCorrect(@"
typedef [Attr1] long? Type1;
typedef [Attr2] Type1? Type2;
typedef [Attr3] Type1 Type3;
typedef [Attr4] long Type4;
typedef [Attr5] Type3? Type5;
interface I1 {
	[AttrA] attribute Type1  x1;
	[AttrB] attribute Type1? x2;
	[AttrC] attribute Type2  x3;
	[AttrD] attribute Type2? x4;
	[AttrE] attribute Type3  x5;
	[AttrF] attribute Type3? x6;
	[AttrG] attribute Type4  x7;
	[AttrH] attribute Type4? x8;
	[AttrI] attribute Type5  x9;
	[AttrJ] attribute Type5? x10;
};
",
@"interface I1 {
	[AttrA, Attr1]
	attribute long? x1;
	[AttrB, Attr1]
	attribute long? x2;
	[AttrC, Attr2, Attr1]
	attribute long? x3;
	[AttrD, Attr2, Attr1]
	attribute long? x4;
	[AttrE, Attr3, Attr1]
	attribute long? x5;
	[AttrF, Attr3, Attr1]
	attribute long? x6;
	[AttrG, Attr4]
	attribute long x7;
	[AttrH, Attr4]
	attribute long? x8;
	[AttrI, Attr5, Attr3, Attr1]
	attribute long? x9;
	[AttrJ, Attr5, Attr3, Attr1]
	attribute long? x10;
};
");
		}

		[Test]
		public void UnionTypeWorks() {
			AssertCorrect(@"
typedef [Attr1] long Type1;
typedef [Attr2] short Type2;
typedef [Attr3] Object Type3;
interface I1 {
	[Attr5] attribute (Type1 or Type2 or Type3) a1;
};
",
@"interface I1 {
	[Attr5]
	attribute (long or short or Object) a1;
};");
		}

		[Test]
		public void BuiltinTypeResolveWorks() {
			AssertCorrect(@"
interface I1 {
	[Attr5] attribute long a1;
	[Attr6] attribute short a2;
};
",
@"interface I1 {
	[Attr5]
	attribute long a1;
	[Attr6]
	attribute short a2;
};");
		}

		[Test]
		public void VoidTypeResolveWorks() {
			AssertCorrect(@"
interface I1 {
	[Attr5] void m();
};
",
@"interface I1 {
	[Attr5]
	void m();
};");
		}

		[Test]
		public void ArrayTypeResolveWorks() {
			AssertCorrect(@"
typedef [Attr1] long[] Type1;
typedef [Attr2] Type1[] Type2;
interface I1 {
	[AttrA] attribute long[] a1;
	[AttrB] attribute Type1 a2;
	[AttrC] attribute Type1[] a3;
	[AttrD] attribute Type2 a4;
	[AttrE] attribute Type2[] a5;
};
",
@"interface I1 {
	[AttrA]
	attribute long[] a1;
	[AttrB, Attr1]
	attribute long[] a2;
	[AttrC]
	attribute long[][] a3;
	[AttrD, Attr2]
	attribute long[][] a4;
	[AttrE]
	attribute long[][][] a5;
};");
		}

		[Test]
		public void SequenceTypeResolveWorks() {
			AssertCorrect(@"
typedef [Attr1] sequence<long> Type1;
typedef [Attr2] sequence<Type1> Type2;
interface I1 {
	[AttrA] attribute sequence<long> a1;
	[AttrB] attribute Type1 a2;
	[AttrC] attribute sequence<Type1> a3;
	[AttrD] attribute Type2 a4;
	[AttrE] attribute sequence<Type2> a5;
};
",
@"interface I1 {
	[AttrA]
	attribute sequence<long> a1;
	[AttrB, Attr1]
	attribute sequence<long> a2;
	[AttrC]
	attribute sequence<sequence<long>> a3;
	[AttrD, Attr2]
	attribute sequence<sequence<long>> a4;
	[AttrE]
	attribute sequence<sequence<sequence<long>>> a5;
};");
		}

		[Test]
		public void DeclaredInterfaceAppearsInModelIfAndOnlyIfItIsUsed() {
			AssertCorrect(@"
interface I1;
interface I2;
interface I3 {
	attribute I1 a;
};
",
@"interface I1;
interface I3 {
	attribute I1 a;
};");
		}
	}
}
