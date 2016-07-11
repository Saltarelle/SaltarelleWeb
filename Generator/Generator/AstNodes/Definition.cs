using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes
{
    public class Definition
    {
        private Definition() { }

        public class InterfaceData
        {
            public string Name { get; private set; }
            public string Base { get; private set; }
            public IReadOnlyList<InterfaceMember> Members { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public InterfaceData(string name, string @base, IReadOnlyList<InterfaceMember> members, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Base = @base;
                Members = members;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class PartialInterfaceData
        {
            public string Name { get; private set; }
            public IReadOnlyList<InterfaceMember> Members { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public PartialInterfaceData(string name, IReadOnlyList<InterfaceMember> members, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Members = members;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class DictionaryData
        {
            public string Name { get; private set; }
            public string Base { get; private set; }
            public IReadOnlyList<DictionaryMember> Members { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public DictionaryData(string name, string @base, IReadOnlyList<DictionaryMember> members, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Base = @base;
                Members = members;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class PartialDictionaryData
        {
            public string Name { get; private set; }
            public IReadOnlyList<DictionaryMember> Members { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public PartialDictionaryData(string name, IReadOnlyList<DictionaryMember> members, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Members = members;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class CallbackData
        {
            public string Name { get; private set; }
            public WebIDLType ReturnType { get; private set; }
            public IReadOnlyList<Argument> Arguments { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public CallbackData(string name, WebIDLType returnType, IReadOnlyList<Argument> arguments, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                ReturnType = returnType;
                Arguments = arguments;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class ImplementsData
        {
            public string ImplementingType { get; set; }
            public string ImplementedType { get; set; }

            public ImplementsData(string implementingType, string implementedType)
            {
                ImplementingType = implementingType;
                ImplementedType = implementedType;
            }
        }

        public class ExceptionData
        {
            public string Name { get; private set; }
            public string Base { get; private set; }
            public IReadOnlyList<ExceptionMember> Members { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public ExceptionData(string name, string @base, IReadOnlyList<ExceptionMember> members, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Base = @base;
                Members = members;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class TypedefData
        {
            public string Name { get; private set; }
            public WebIDLType ReferencedType { get; private set; }
            public IReadOnlyList<ExtendedAttribute> TypeExtendedAttributes { get; private set; }

            public TypedefData(string name, WebIDLType referencedType, IReadOnlyList<ExtendedAttribute> typeExtendedAttributes)
            {
                Name = name;
                ReferencedType = referencedType;
                TypeExtendedAttributes = typeExtendedAttributes;
            }
        }

        public class EnumData
        {
            public string Name { get; private set; }
            public IReadOnlyList<string> Values { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public EnumData(string name, IReadOnlyList<string> values, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Values = values;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class InterfaceDeclarationData
        {
            public string Name { get; private set; }

            public InterfaceDeclarationData(string name)
            {
                Name = name;
            }
        }

        private InterfaceData _interface;
        private InterfaceData _callbackInterface;
        private PartialInterfaceData _partialInterface;
        private DictionaryData _dictionary;
        private PartialDictionaryData _partialDictionary;
        private CallbackData _callback;
        private ImplementsData _implements;
        private ExceptionData _exception;
        private TypedefData _typedef;
        private EnumData _enum;
        private InterfaceDeclarationData _interfaceDeclaration;

        public static Definition Interface(string name, string @base, IEnumerable<InterfaceMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _interface = new InterfaceData(name, @base, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition CallbackInterface(string name, string @base, IEnumerable<InterfaceMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _callbackInterface = new InterfaceData(name, @base, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition PartialInterface(string name, IEnumerable<InterfaceMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _partialInterface = new PartialInterfaceData(name, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition Dictionary(string name, string @base, IEnumerable<DictionaryMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _dictionary = new DictionaryData(name, @base, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition PartialDictionary(string name, IEnumerable<DictionaryMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _partialDictionary = new PartialDictionaryData(name, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition Callback(string name, WebIDLType returnType, IEnumerable<Argument> arguments, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _callback = new CallbackData(name, returnType, arguments.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition Implements(string implementingType, string implementedType)
        {
            return new Definition { _implements = new ImplementsData(implementingType, implementedType) };
        }

        public static Definition Exception(string name, string @base, IEnumerable<ExceptionMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _exception = new ExceptionData(name, @base, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition Typedef(string name, WebIDLType referencedType, IEnumerable<ExtendedAttribute> typeExtendedAttributes)
        {
            return new Definition { _typedef = new TypedefData(name, referencedType, typeExtendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition Enum(string name, IEnumerable<string> values, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new Definition { _enum = new EnumData(name, values.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static Definition InterfaceDeclaration(string name)
        {
            return new Definition { _interfaceDeclaration = new InterfaceDeclarationData(name) };
        }

        public void Decompose(Action<InterfaceData> @interface, Action<InterfaceData> callbackInterface, Action<PartialInterfaceData> partialInterface, Action<DictionaryData> dictionary, Action<PartialDictionaryData> partialDictionary, Action<CallbackData> callback, Action<ImplementsData> implements, Action<ExceptionData> exception, Action<TypedefData> typedef, Action<EnumData> @enum, Action<InterfaceDeclarationData> interfaceDeclaration)
        {
            if (_interface != null)
            {
                if (@interface != null) @interface(_interface);
            }
            else if (_callbackInterface != null)
            {
                if (callbackInterface != null) callbackInterface(_callbackInterface);
            }
            else if (_partialInterface != null)
            {
                if (partialInterface != null) partialInterface(_partialInterface);
            }
            else if (_dictionary != null)
            {
                if (dictionary != null) dictionary(_dictionary);
            }
            else if (_partialDictionary != null)
            {
                if (partialDictionary != null) partialDictionary(_partialDictionary);
            }
            else if (_callback != null)
            {
                if (callback != null) callback(_callback);
            }
            else if (_implements != null)
            {
                if (implements != null) implements(_implements);
            }
            else if (_exception != null)
            {
                if (exception != null) exception(_exception);
            }
            else if (_typedef != null)
            {
                if (typedef != null) typedef(_typedef);
            }
            else if (_enum != null)
            {
                if (@enum != null) @enum(_enum);
            }
            else if (_interfaceDeclaration != null)
            {
                if (interfaceDeclaration != null) interfaceDeclaration(_interfaceDeclaration);
            }
            else
            {
                throw new InvalidOperationException("Invalid state");
            }
        }

        public T DecomposeWithResult<T>(Func<InterfaceData, T> @interface, Func<InterfaceData, T> callbackInterface, Func<PartialInterfaceData, T> partialInterface, Func<DictionaryData, T> dictionary, Func<PartialDictionaryData, T> partialDictionary, Func<CallbackData, T> callback, Func<ImplementsData, T> implements, Func<ExceptionData, T> exception, Func<TypedefData, T> typedef, Func<EnumData, T> @enum, Func<InterfaceDeclarationData, T> interfaceDeclaration)
        {
            if (_interface != null)
            {
                if (@interface != null)
                    return @interface(_interface);
                else
                    throw new InvalidOperationException("Case 'Interface' not handled");
            }
            else if (_callbackInterface != null)
            {
                if (callbackInterface != null)
                    return callbackInterface(_interface);
                else
                    throw new InvalidOperationException("Case 'CallbackInterface' not handled");
            }
            else if (_partialInterface != null)
            {
                if (partialInterface != null)
                    return partialInterface(_partialInterface);
                else
                    throw new InvalidOperationException("Case 'PartialInterface' not handled");
            }
            else if (_dictionary != null)
            {
                if (dictionary != null)
                    return dictionary(_dictionary);
                else
                    throw new InvalidOperationException("Case 'Dictionary' not handled");
            }
            else if (_partialDictionary != null)
            {
                if (partialDictionary != null)
                    return partialDictionary(_partialDictionary);
                else
                    throw new InvalidOperationException("Case 'PartialDictionary' not handled");
            }
            else if (_callback != null)
            {
                if (callback != null)
                    return callback(_callback);
                else
                    throw new InvalidOperationException("Case 'Callback' not handled");
            }
            else if (_implements != null)
            {
                if (implements != null)
                    return implements(_implements);
                else
                    throw new InvalidOperationException("Case 'Implements' not handled");
            }
            else if (_exception != null)
            {
                if (exception != null)
                    return exception(_exception);
                else
                    throw new InvalidOperationException("Case 'Exception' not handled");
            }
            else if (_typedef != null)
            {
                if (typedef != null)
                    return typedef(_typedef);
                else
                    throw new InvalidOperationException("Case 'Typedef' not handled");
            }
            else if (_enum != null)
            {
                if (@enum != null)
                    return @enum(_enum);
                else
                    throw new InvalidOperationException("Case 'Enum' not handled");
            }
            else if (_interfaceDeclaration != null)
            {
                if (interfaceDeclaration != null)
                    return interfaceDeclaration(_interfaceDeclaration);
                else
                    throw new InvalidOperationException("Case 'InterfaceDeclaration' not handled");
            }
            else
            {
                throw new InvalidOperationException("Invalid state");
            }
        }
    }
}
