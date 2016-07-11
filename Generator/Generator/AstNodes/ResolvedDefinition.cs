using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes
{
    public class ResolvedDefinition
    {
        private ResolvedDefinition() { }

        public class InterfaceData
        {
            public string Name { get; private set; }
            public string Base { get; private set; }
            public IReadOnlyList<string> Implements { get; private set; }
            public IReadOnlyList<InterfaceMember> Members { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public InterfaceData(string name, string @base, IReadOnlyList<string> implements, IReadOnlyList<InterfaceMember> members, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Base = @base;
                Implements = implements;
                Members = members;
                ExtendedAttributes = extendedAttributes;
            }
        }

        public class CallbackInterfaceData
        {
            public string Name { get; private set; }
            public string Base { get; private set; }
            public IReadOnlyList<InterfaceMember> Members { get; private set; }
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

            public CallbackInterfaceData(string name, string @base, IReadOnlyList<InterfaceMember> members, IReadOnlyList<ExtendedAttribute> extendedAttributes)
            {
                Name = name;
                Base = @base;
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

        public class DeclaredInterfaceData
        {
            public string Name { get; private set; }

            public DeclaredInterfaceData(string name)
            {
                Name = name;
            }
        }

        private InterfaceData _interface;
        private CallbackInterfaceData _callbackInterface;
        private DictionaryData _dictionary;
        private CallbackData _callback;
        private ExceptionData _exception;
        private EnumData _enum;
        private DeclaredInterfaceData _declaredInterface;

        public static ResolvedDefinition Interface(string name, string @base, IEnumerable<string> implements, IEnumerable<InterfaceMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new ResolvedDefinition { _interface = new InterfaceData(name, @base, implements.AsReadOnlySafe(), members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static ResolvedDefinition CallbackInterface(string name, string @base, IEnumerable<InterfaceMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new ResolvedDefinition { _callbackInterface = new CallbackInterfaceData(name, @base, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static ResolvedDefinition Dictionary(string name, string @base, IEnumerable<DictionaryMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new ResolvedDefinition { _dictionary = new DictionaryData(name, @base, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static ResolvedDefinition Callback(string name, WebIDLType returnType, IEnumerable<Argument> arguments, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new ResolvedDefinition { _callback = new CallbackData(name, returnType, arguments.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static ResolvedDefinition Exception(string name, string @base, IEnumerable<ExceptionMember> members, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new ResolvedDefinition { _exception = new ExceptionData(name, @base, members.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static ResolvedDefinition Enum(string name, IEnumerable<string> values, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new ResolvedDefinition { _enum = new EnumData(name, values.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
        }

        public static ResolvedDefinition DeclaredInterface(string name)
        {
            return new ResolvedDefinition { _declaredInterface = new DeclaredInterfaceData(name) };
        }

        public void Decompose(Action<InterfaceData> @interface, Action<CallbackInterfaceData> callbackInterface, Action<DictionaryData> dictionary, Action<CallbackData> callback, Action<ExceptionData> exception, Action<EnumData> @enum, Action<DeclaredInterfaceData> declaredInterface)
        {
            if (_interface != null)
            {
                if (@interface != null) @interface(_interface);
            }
            else if (_callbackInterface != null)
            {
                if (callbackInterface != null) callbackInterface(_callbackInterface);
            }
            else if (_dictionary != null)
            {
                if (dictionary != null) dictionary(_dictionary);
            }
            else if (_callback != null)
            {
                if (callback != null) callback(_callback);
            }
            else if (_exception != null)
            {
                if (exception != null) exception(_exception);
            }
            else if (_enum != null)
            {
                if (@enum != null) @enum(_enum);
            }
            else if (_declaredInterface != null)
            {
                if (declaredInterface != null) declaredInterface(_declaredInterface);
            }
            else
            {
                throw new InvalidOperationException("Invalid state");
            }
        }

        public T DecomposeWithResult<T>(Func<InterfaceData, T> @interface, Func<CallbackInterfaceData, T> callbackInterface, Func<DictionaryData, T> dictionary, Func<CallbackData, T> callback, Func<ExceptionData, T> exception, Func<EnumData, T> @enum, Func<DeclaredInterfaceData, T> declaredInterface)
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
                    return callbackInterface(_callbackInterface);
                else
                    throw new InvalidOperationException("Case 'CallbackInterface' not handled");
            }
            else if (_dictionary != null)
            {
                if (dictionary != null)
                    return dictionary(_dictionary);
                else
                    throw new InvalidOperationException("Case 'Dictionary' not handled");
            }
            else if (_callback != null)
            {
                if (callback != null)
                    return callback(_callback);
                else
                    throw new InvalidOperationException("Case 'Callback' not handled");
            }
            else if (_exception != null)
            {
                if (exception != null)
                    return exception(_exception);
                else
                    throw new InvalidOperationException("Case 'Exception' not handled");
            }
            else if (_enum != null)
            {
                if (@enum != null)
                    return @enum(_enum);
                else
                    throw new InvalidOperationException("Case 'Enum' not handled");
            }
            else if (_declaredInterface != null)
            {
                if (declaredInterface != null)
                    return declaredInterface(_declaredInterface);
                else
                    throw new InvalidOperationException("Case 'UndefinedSymbol' not handled");
            }
            else
            {
                throw new InvalidOperationException("Invalid state");
            }
        }
    }
}
