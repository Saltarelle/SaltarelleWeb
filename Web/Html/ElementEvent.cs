// ElementEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public class ElementEvent {

        internal ElementEvent() {
        }

        [IntrinsicProperty]
        public bool AltKey {
            get {
                return false;
            }
        }

        [IntrinsicProperty]
        public int Button {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public bool CancelBubble {
            get {
                return false;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public bool CtrlKey {
            get {
                return false;
            }
        }

        [IntrinsicProperty]
        public Element CurrentTarget {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public DataTransfer DataTransfer {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public int Detail {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public Element FromElement {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public int KeyCode {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public bool MetaKey {
            get {
                return false;
            }
        }

        [IntrinsicProperty]
        public int ClientX {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public int ClientY {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public int OffsetX {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public int OffsetY {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        public bool ReturnValue {
            get {
                return false;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public bool ShiftKey {
            get {
                return false;
            }
        }

        [IntrinsicProperty]
        public Element SrcElement {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public Element Target {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public DateTime TimeStamp {
            get {
                return default(DateTime);
            }
        }

        [IntrinsicProperty]
        public Element ToElement {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public string Type {
            get {
                return null;
            }
        }

        public void PreventDefault() {
        }

        public void StopImmediatePropagation() {
        }

        public void StopPropagation() {
        }
    }
}
