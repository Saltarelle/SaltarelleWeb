using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class KeyboardEvent : UIEvent {
		internal KeyboardEvent() {
		}

		[IntrinsicProperty]
		public bool AltKey {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public int CharCode {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public bool CtrlKey {
			get {
				return false;
			}
		}

		[ScriptName("DOM_KEY_LOCATION_JOYSTICK")]
		public const int DOM_KEY_LOCATION_JOYSTICK = 5;

		[ScriptName("DOM_KEY_LOCATION_LEFT")]
		public const int DOM_KEY_LOCATION_LEFT = 1;

		[ScriptName("DOM_KEY_LOCATION_MOBILE")]
		public const int DOM_KEY_LOCATION_MOBILE = 4;

		[ScriptName("DOM_KEY_LOCATION_NUMPAD")]
		public const int DOM_KEY_LOCATION_NUMPAD = 3;

		[ScriptName("DOM_KEY_LOCATION_RIGHT")]
		public const int DOM_KEY_LOCATION_RIGHT = 2;

		[ScriptName("DOM_KEY_LOCATION_STANDARD")]
		public const int DOM_KEY_LOCATION_STANDARD = 0;

		[ScriptName("DOM_VK_0")]
		public const int DOM_VK_0 = 48;

		[ScriptName("DOM_VK_1")]
		public const int DOM_VK_1 = 49;

		[ScriptName("DOM_VK_2")]
		public const int DOM_VK_2 = 50;

		[ScriptName("DOM_VK_3")]
		public const int DOM_VK_3 = 51;

		[ScriptName("DOM_VK_4")]
		public const int DOM_VK_4 = 52;

		[ScriptName("DOM_VK_5")]
		public const int DOM_VK_5 = 53;

		[ScriptName("DOM_VK_6")]
		public const int DOM_VK_6 = 54;

		[ScriptName("DOM_VK_7")]
		public const int DOM_VK_7 = 55;

		[ScriptName("DOM_VK_8")]
		public const int DOM_VK_8 = 56;

		[ScriptName("DOM_VK_9")]
		public const int DOM_VK_9 = 57;

		[ScriptName("DOM_VK_A")]
		public const int DOM_VK_A = 65;

		[ScriptName("DOM_VK_ACCEPT")]
		public const int DOM_VK_ACCEPT = 30;

		[ScriptName("DOM_VK_ADD")]
		public const int DOM_VK_ADD = 107;

		[ScriptName("DOM_VK_ALT")]
		public const int DOM_VK_ALT = 18;

		[ScriptName("DOM_VK_ALTGR")]
		public const int DOM_VK_ALTGR = 225;

		[ScriptName("DOM_VK_AMPERSAND")]
		public const int DOM_VK_AMPERSAND = 166;

		[ScriptName("DOM_VK_ASTERISK")]
		public const int DOM_VK_ASTERISK = 170;

		[ScriptName("DOM_VK_AT")]
		public const int DOM_VK_AT = 64;

		[ScriptName("DOM_VK_ATTN")]
		public const int DOM_VK_ATTN = 246;

		[ScriptName("DOM_VK_B")]
		public const int DOM_VK_B = 66;

		[ScriptName("DOM_VK_BACK_QUOTE")]
		public const int DOM_VK_BACK_QUOTE = 192;

		[ScriptName("DOM_VK_BACK_SLASH")]
		public const int DOM_VK_BACK_SLASH = 220;

		[ScriptName("DOM_VK_BACK_SPACE")]
		public const int DOM_VK_BACK_SPACE = 8;

		[ScriptName("DOM_VK_C")]
		public const int DOM_VK_C = 67;

		[ScriptName("DOM_VK_CANCEL")]
		public const int DOM_VK_CANCEL = 3;

		[ScriptName("DOM_VK_CAPS_LOCK")]
		public const int DOM_VK_CAPS_LOCK = 20;

		[ScriptName("DOM_VK_CIRCUMFLEX")]
		public const int DOM_VK_CIRCUMFLEX = 160;

		[ScriptName("DOM_VK_CLEAR")]
		public const int DOM_VK_CLEAR = 12;

		[ScriptName("DOM_VK_CLOSE_BRACKET")]
		public const int DOM_VK_CLOSE_BRACKET = 221;

		[ScriptName("DOM_VK_CLOSE_CURLY_BRACKET")]
		public const int DOM_VK_CLOSE_CURLY_BRACKET = 175;

		[ScriptName("DOM_VK_CLOSE_PAREN")]
		public const int DOM_VK_CLOSE_PAREN = 169;

		[ScriptName("DOM_VK_COLON")]
		public const int DOM_VK_COLON = 58;

		[ScriptName("DOM_VK_COMMA")]
		public const int DOM_VK_COMMA = 188;

		[ScriptName("DOM_VK_CONTEXT_MENU")]
		public const int DOM_VK_CONTEXT_MENU = 93;

		[ScriptName("DOM_VK_CONTROL")]
		public const int DOM_VK_CONTROL = 17;

		[ScriptName("DOM_VK_CONVERT")]
		public const int DOM_VK_CONVERT = 28;

		[ScriptName("DOM_VK_CRSEL")]
		public const int DOM_VK_CRSEL = 247;

		[ScriptName("DOM_VK_D")]
		public const int DOM_VK_D = 68;

		[ScriptName("DOM_VK_DECIMAL")]
		public const int DOM_VK_DECIMAL = 110;

		[ScriptName("DOM_VK_DELETE")]
		public const int DOM_VK_DELETE = 46;

		[ScriptName("DOM_VK_DIVIDE")]
		public const int DOM_VK_DIVIDE = 111;

		[ScriptName("DOM_VK_DOLLAR")]
		public const int DOM_VK_DOLLAR = 164;

		[ScriptName("DOM_VK_DOUBLE_QUOTE")]
		public const int DOM_VK_DOUBLE_QUOTE = 162;

		[ScriptName("DOM_VK_DOWN")]
		public const int DOM_VK_DOWN = 40;

		[ScriptName("DOM_VK_E")]
		public const int DOM_VK_E = 69;

		[ScriptName("DOM_VK_EISU")]
		public const int DOM_VK_EISU = 22;

		[ScriptName("DOM_VK_END")]
		public const int DOM_VK_END = 35;

		[ScriptName("DOM_VK_EQUALS")]
		public const int DOM_VK_EQUALS = 61;

		[ScriptName("DOM_VK_EREOF")]
		public const int DOM_VK_EREOF = 249;

		[ScriptName("DOM_VK_ESCAPE")]
		public const int DOM_VK_ESCAPE = 27;

		[ScriptName("DOM_VK_EXCLAMATION")]
		public const int DOM_VK_EXCLAMATION = 161;

		[ScriptName("DOM_VK_EXECUTE")]
		public const int DOM_VK_EXECUTE = 43;

		[ScriptName("DOM_VK_EXSEL")]
		public const int DOM_VK_EXSEL = 248;

		[ScriptName("DOM_VK_F")]
		public const int DOM_VK_F = 70;

		[ScriptName("DOM_VK_F1")]
		public const int DOM_VK_F1 = 112;

		[ScriptName("DOM_VK_F10")]
		public const int DOM_VK_F10 = 121;

		[ScriptName("DOM_VK_F11")]
		public const int DOM_VK_F11 = 122;

		[ScriptName("DOM_VK_F12")]
		public const int DOM_VK_F12 = 123;

		[ScriptName("DOM_VK_F13")]
		public const int DOM_VK_F13 = 124;

		[ScriptName("DOM_VK_F14")]
		public const int DOM_VK_F14 = 125;

		[ScriptName("DOM_VK_F15")]
		public const int DOM_VK_F15 = 126;

		[ScriptName("DOM_VK_F16")]
		public const int DOM_VK_F16 = 127;

		[ScriptName("DOM_VK_F17")]
		public const int DOM_VK_F17 = 128;

		[ScriptName("DOM_VK_F18")]
		public const int DOM_VK_F18 = 129;

		[ScriptName("DOM_VK_F19")]
		public const int DOM_VK_F19 = 130;

		[ScriptName("DOM_VK_F2")]
		public const int DOM_VK_F2 = 113;

		[ScriptName("DOM_VK_F20")]
		public const int DOM_VK_F20 = 131;

		[ScriptName("DOM_VK_F21")]
		public const int DOM_VK_F21 = 132;

		[ScriptName("DOM_VK_F22")]
		public const int DOM_VK_F22 = 133;

		[ScriptName("DOM_VK_F23")]
		public const int DOM_VK_F23 = 134;

		[ScriptName("DOM_VK_F24")]
		public const int DOM_VK_F24 = 135;

		[ScriptName("DOM_VK_F3")]
		public const int DOM_VK_F3 = 114;

		[ScriptName("DOM_VK_F4")]
		public const int DOM_VK_F4 = 115;

		[ScriptName("DOM_VK_F5")]
		public const int DOM_VK_F5 = 116;

		[ScriptName("DOM_VK_F6")]
		public const int DOM_VK_F6 = 117;

		[ScriptName("DOM_VK_F7")]
		public const int DOM_VK_F7 = 118;

		[ScriptName("DOM_VK_F8")]
		public const int DOM_VK_F8 = 119;

		[ScriptName("DOM_VK_F9")]
		public const int DOM_VK_F9 = 120;

		[ScriptName("DOM_VK_FINAL")]
		public const int DOM_VK_FINAL = 24;

		[ScriptName("DOM_VK_G")]
		public const int DOM_VK_G = 71;

		[ScriptName("DOM_VK_GREATER_THAN")]
		public const int DOM_VK_GREATER_THAN = 62;

		[ScriptName("DOM_VK_H")]
		public const int DOM_VK_H = 72;

		[ScriptName("DOM_VK_HANGUL")]
		public const int DOM_VK_HANGUL = 21;

		[ScriptName("DOM_VK_HANJA")]
		public const int DOM_VK_HANJA = 25;

		[ScriptName("DOM_VK_HASH")]
		public const int DOM_VK_HASH = 163;

		[ScriptName("DOM_VK_HELP")]
		public const int DOM_VK_HELP = 6;

		[ScriptName("DOM_VK_HOME")]
		public const int DOM_VK_HOME = 36;

		[ScriptName("DOM_VK_HYPHEN_MINUS")]
		public const int DOM_VK_HYPHEN_MINUS = 173;

		[ScriptName("DOM_VK_I")]
		public const int DOM_VK_I = 73;

		[ScriptName("DOM_VK_INSERT")]
		public const int DOM_VK_INSERT = 45;

		[ScriptName("DOM_VK_J")]
		public const int DOM_VK_J = 74;

		[ScriptName("DOM_VK_JUNJA")]
		public const int DOM_VK_JUNJA = 23;

		[ScriptName("DOM_VK_K")]
		public const int DOM_VK_K = 75;

		[ScriptName("DOM_VK_KANA")]
		public const int DOM_VK_KANA = 21;

		[ScriptName("DOM_VK_KANJI")]
		public const int DOM_VK_KANJI = 25;

		[ScriptName("DOM_VK_L")]
		public const int DOM_VK_L = 76;

		[ScriptName("DOM_VK_LEFT")]
		public const int DOM_VK_LEFT = 37;

		[ScriptName("DOM_VK_LESS_THAN")]
		public const int DOM_VK_LESS_THAN = 60;

		[ScriptName("DOM_VK_M")]
		public const int DOM_VK_M = 77;

		[ScriptName("DOM_VK_META")]
		public const int DOM_VK_META = 224;

		[ScriptName("DOM_VK_MODECHANGE")]
		public const int DOM_VK_MODECHANGE = 31;

		[ScriptName("DOM_VK_MULTIPLY")]
		public const int DOM_VK_MULTIPLY = 106;

		[ScriptName("DOM_VK_N")]
		public const int DOM_VK_N = 78;

		[ScriptName("DOM_VK_NONCONVERT")]
		public const int DOM_VK_NONCONVERT = 29;

		[ScriptName("DOM_VK_NUM_LOCK")]
		public const int DOM_VK_NUM_LOCK = 144;

		[ScriptName("DOM_VK_NUMPAD0")]
		public const int DOM_VK_NUMPAD0 = 96;

		[ScriptName("DOM_VK_NUMPAD1")]
		public const int DOM_VK_NUMPAD1 = 97;

		[ScriptName("DOM_VK_NUMPAD2")]
		public const int DOM_VK_NUMPAD2 = 98;

		[ScriptName("DOM_VK_NUMPAD3")]
		public const int DOM_VK_NUMPAD3 = 99;

		[ScriptName("DOM_VK_NUMPAD4")]
		public const int DOM_VK_NUMPAD4 = 100;

		[ScriptName("DOM_VK_NUMPAD5")]
		public const int DOM_VK_NUMPAD5 = 101;

		[ScriptName("DOM_VK_NUMPAD6")]
		public const int DOM_VK_NUMPAD6 = 102;

		[ScriptName("DOM_VK_NUMPAD7")]
		public const int DOM_VK_NUMPAD7 = 103;

		[ScriptName("DOM_VK_NUMPAD8")]
		public const int DOM_VK_NUMPAD8 = 104;

		[ScriptName("DOM_VK_NUMPAD9")]
		public const int DOM_VK_NUMPAD9 = 105;

		[ScriptName("DOM_VK_O")]
		public const int DOM_VK_O = 79;

		[ScriptName("DOM_VK_OPEN_BRACKET")]
		public const int DOM_VK_OPEN_BRACKET = 219;

		[ScriptName("DOM_VK_OPEN_CURLY_BRACKET")]
		public const int DOM_VK_OPEN_CURLY_BRACKET = 174;

		[ScriptName("DOM_VK_OPEN_PAREN")]
		public const int DOM_VK_OPEN_PAREN = 168;

		[ScriptName("DOM_VK_P")]
		public const int DOM_VK_P = 80;

		[ScriptName("DOM_VK_PA1")]
		public const int DOM_VK_PA1 = 253;

		[ScriptName("DOM_VK_PAGE_DOWN")]
		public const int DOM_VK_PAGE_DOWN = 34;

		[ScriptName("DOM_VK_PAGE_UP")]
		public const int DOM_VK_PAGE_UP = 33;

		[ScriptName("DOM_VK_PAUSE")]
		public const int DOM_VK_PAUSE = 19;

		[ScriptName("DOM_VK_PERCENT")]
		public const int DOM_VK_PERCENT = 165;

		[ScriptName("DOM_VK_PERIOD")]
		public const int DOM_VK_PERIOD = 190;

		[ScriptName("DOM_VK_PIPE")]
		public const int DOM_VK_PIPE = 172;

		[ScriptName("DOM_VK_PLAY")]
		public const int DOM_VK_PLAY = 250;

		[ScriptName("DOM_VK_PLUS")]
		public const int DOM_VK_PLUS = 171;

		[ScriptName("DOM_VK_PRINT")]
		public const int DOM_VK_PRINT = 42;

		[ScriptName("DOM_VK_PRINTSCREEN")]
		public const int DOM_VK_PRINTSCREEN = 44;

		[ScriptName("DOM_VK_Q")]
		public const int DOM_VK_Q = 81;

		[ScriptName("DOM_VK_QUESTION_MARK")]
		public const int DOM_VK_QUESTION_MARK = 63;

		[ScriptName("DOM_VK_QUOTE")]
		public const int DOM_VK_QUOTE = 222;

		[ScriptName("DOM_VK_R")]
		public const int DOM_VK_R = 82;

		[ScriptName("DOM_VK_RETURN")]
		public const int DOM_VK_RETURN = 13;

		[ScriptName("DOM_VK_RIGHT")]
		public const int DOM_VK_RIGHT = 39;

		[ScriptName("DOM_VK_S")]
		public const int DOM_VK_S = 83;

		[ScriptName("DOM_VK_SCROLL_LOCK")]
		public const int DOM_VK_SCROLL_LOCK = 145;

		[ScriptName("DOM_VK_SELECT")]
		public const int DOM_VK_SELECT = 41;

		[ScriptName("DOM_VK_SEMICOLON")]
		public const int DOM_VK_SEMICOLON = 59;

		[ScriptName("DOM_VK_SEPARATOR")]
		public const int DOM_VK_SEPARATOR = 108;

		[ScriptName("DOM_VK_SHIFT")]
		public const int DOM_VK_SHIFT = 16;

		[ScriptName("DOM_VK_SLASH")]
		public const int DOM_VK_SLASH = 191;

		[ScriptName("DOM_VK_SLEEP")]
		public const int DOM_VK_SLEEP = 95;

		[ScriptName("DOM_VK_SPACE")]
		public const int DOM_VK_SPACE = 32;

		[ScriptName("DOM_VK_SUBTRACT")]
		public const int DOM_VK_SUBTRACT = 109;

		[ScriptName("DOM_VK_T")]
		public const int DOM_VK_T = 84;

		[ScriptName("DOM_VK_TAB")]
		public const int DOM_VK_TAB = 9;

		[ScriptName("DOM_VK_TILDE")]
		public const int DOM_VK_TILDE = 176;

		[ScriptName("DOM_VK_U")]
		public const int DOM_VK_U = 85;

		[ScriptName("DOM_VK_UNDERSCORE")]
		public const int DOM_VK_UNDERSCORE = 167;

		[ScriptName("DOM_VK_UP")]
		public const int DOM_VK_UP = 38;

		[ScriptName("DOM_VK_V")]
		public const int DOM_VK_V = 86;

		[ScriptName("DOM_VK_VOLUME_DOWN")]
		public const int DOM_VK_VOLUME_DOWN = 182;

		[ScriptName("DOM_VK_VOLUME_MUTE")]
		public const int DOM_VK_VOLUME_MUTE = 181;

		[ScriptName("DOM_VK_VOLUME_UP")]
		public const int DOM_VK_VOLUME_UP = 183;

		[ScriptName("DOM_VK_W")]
		public const int DOM_VK_W = 87;

		[ScriptName("DOM_VK_WIN")]
		public const int DOM_VK_WIN = 91;

		[ScriptName("DOM_VK_WIN_ICO_00")]
		public const int DOM_VK_WIN_ICO_00 = 228;

		[ScriptName("DOM_VK_WIN_ICO_CLEAR")]
		public const int DOM_VK_WIN_ICO_CLEAR = 230;

		[ScriptName("DOM_VK_WIN_ICO_HELP")]
		public const int DOM_VK_WIN_ICO_HELP = 227;

		[ScriptName("DOM_VK_WIN_OEM_ATTN")]
		public const int DOM_VK_WIN_OEM_ATTN = 240;

		[ScriptName("DOM_VK_WIN_OEM_AUTO")]
		public const int DOM_VK_WIN_OEM_AUTO = 243;

		[ScriptName("DOM_VK_WIN_OEM_BACKTAB")]
		public const int DOM_VK_WIN_OEM_BACKTAB = 245;

		[ScriptName("DOM_VK_WIN_OEM_CLEAR")]
		public const int DOM_VK_WIN_OEM_CLEAR = 254;

		[ScriptName("DOM_VK_WIN_OEM_COPY")]
		public const int DOM_VK_WIN_OEM_COPY = 242;

		[ScriptName("DOM_VK_WIN_OEM_CUSEL")]
		public const int DOM_VK_WIN_OEM_CUSEL = 239;

		[ScriptName("DOM_VK_WIN_OEM_ENLW")]
		public const int DOM_VK_WIN_OEM_ENLW = 244;

		[ScriptName("DOM_VK_WIN_OEM_FINISH")]
		public const int DOM_VK_WIN_OEM_FINISH = 241;

		[ScriptName("DOM_VK_WIN_OEM_FJ_JISHO")]
		public const int DOM_VK_WIN_OEM_FJ_JISHO = 146;

		[ScriptName("DOM_VK_WIN_OEM_FJ_LOYA")]
		public const int DOM_VK_WIN_OEM_FJ_LOYA = 149;

		[ScriptName("DOM_VK_WIN_OEM_FJ_MASSHOU")]
		public const int DOM_VK_WIN_OEM_FJ_MASSHOU = 147;

		[ScriptName("DOM_VK_WIN_OEM_FJ_ROYA")]
		public const int DOM_VK_WIN_OEM_FJ_ROYA = 150;

		[ScriptName("DOM_VK_WIN_OEM_FJ_TOUROKU")]
		public const int DOM_VK_WIN_OEM_FJ_TOUROKU = 148;

		[ScriptName("DOM_VK_WIN_OEM_JUMP")]
		public const int DOM_VK_WIN_OEM_JUMP = 234;

		[ScriptName("DOM_VK_WIN_OEM_PA1")]
		public const int DOM_VK_WIN_OEM_PA1 = 235;

		[ScriptName("DOM_VK_WIN_OEM_PA2")]
		public const int DOM_VK_WIN_OEM_PA2 = 236;

		[ScriptName("DOM_VK_WIN_OEM_PA3")]
		public const int DOM_VK_WIN_OEM_PA3 = 237;

		[ScriptName("DOM_VK_WIN_OEM_RESET")]
		public const int DOM_VK_WIN_OEM_RESET = 233;

		[ScriptName("DOM_VK_WIN_OEM_WSCTRL")]
		public const int DOM_VK_WIN_OEM_WSCTRL = 238;

		[ScriptName("DOM_VK_X")]
		public const int DOM_VK_X = 88;

		[ScriptName("DOM_VK_Y")]
		public const int DOM_VK_Y = 89;

		[ScriptName("DOM_VK_Z")]
		public const int DOM_VK_Z = 90;

		[ScriptName("DOM_VK_ZOOM")]
		public const int DOM_VK_ZOOM = 251;

		public bool GetModifierState(string key) {
			return false;
		}

		public void InitKeyEvent(string type, bool canBubble, bool cancelable, WindowInstance view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int keyCode, int charCode) {
		}

		[IntrinsicProperty]
		public string Key {
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
		public int Location {
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
		public bool Repeat {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool ShiftKey {
			get {
				return false;
			}
		}
	}
}
