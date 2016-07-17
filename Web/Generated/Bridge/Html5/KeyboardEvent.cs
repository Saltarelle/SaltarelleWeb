namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class KeyboardEvent : UIEvent
	{
		internal extern KeyboardEvent();

		public readonly bool AltKey;

		public readonly int CharCode;

		public readonly bool CtrlKey;

		[Name("DOM_KEY_LOCATION_JOYSTICK")]
		public const int DOM_KEY_LOCATION_JOYSTICK = 5;

		[Name("DOM_KEY_LOCATION_LEFT")]
		public const int DOM_KEY_LOCATION_LEFT = 1;

		[Name("DOM_KEY_LOCATION_MOBILE")]
		public const int DOM_KEY_LOCATION_MOBILE = 4;

		[Name("DOM_KEY_LOCATION_NUMPAD")]
		public const int DOM_KEY_LOCATION_NUMPAD = 3;

		[Name("DOM_KEY_LOCATION_RIGHT")]
		public const int DOM_KEY_LOCATION_RIGHT = 2;

		[Name("DOM_KEY_LOCATION_STANDARD")]
		public const int DOM_KEY_LOCATION_STANDARD = 0;

		[Name("DOM_VK_0")]
		public const int DOM_VK_0 = 48;

		[Name("DOM_VK_1")]
		public const int DOM_VK_1 = 49;

		[Name("DOM_VK_2")]
		public const int DOM_VK_2 = 50;

		[Name("DOM_VK_3")]
		public const int DOM_VK_3 = 51;

		[Name("DOM_VK_4")]
		public const int DOM_VK_4 = 52;

		[Name("DOM_VK_5")]
		public const int DOM_VK_5 = 53;

		[Name("DOM_VK_6")]
		public const int DOM_VK_6 = 54;

		[Name("DOM_VK_7")]
		public const int DOM_VK_7 = 55;

		[Name("DOM_VK_8")]
		public const int DOM_VK_8 = 56;

		[Name("DOM_VK_9")]
		public const int DOM_VK_9 = 57;

		[Name("DOM_VK_A")]
		public const int DOM_VK_A = 65;

		[Name("DOM_VK_ACCEPT")]
		public const int DOM_VK_ACCEPT = 30;

		[Name("DOM_VK_ADD")]
		public const int DOM_VK_ADD = 107;

		[Name("DOM_VK_ALT")]
		public const int DOM_VK_ALT = 18;

		[Name("DOM_VK_ALTGR")]
		public const int DOM_VK_ALTGR = 225;

		[Name("DOM_VK_AMPERSAND")]
		public const int DOM_VK_AMPERSAND = 166;

		[Name("DOM_VK_ASTERISK")]
		public const int DOM_VK_ASTERISK = 170;

		[Name("DOM_VK_AT")]
		public const int DOM_VK_AT = 64;

		[Name("DOM_VK_ATTN")]
		public const int DOM_VK_ATTN = 246;

		[Name("DOM_VK_B")]
		public const int DOM_VK_B = 66;

		[Name("DOM_VK_BACK_QUOTE")]
		public const int DOM_VK_BACK_QUOTE = 192;

		[Name("DOM_VK_BACK_SLASH")]
		public const int DOM_VK_BACK_SLASH = 220;

		[Name("DOM_VK_BACK_SPACE")]
		public const int DOM_VK_BACK_SPACE = 8;

		[Name("DOM_VK_C")]
		public const int DOM_VK_C = 67;

		[Name("DOM_VK_CANCEL")]
		public const int DOM_VK_CANCEL = 3;

		[Name("DOM_VK_CAPS_LOCK")]
		public const int DOM_VK_CAPS_LOCK = 20;

		[Name("DOM_VK_CIRCUMFLEX")]
		public const int DOM_VK_CIRCUMFLEX = 160;

		[Name("DOM_VK_CLEAR")]
		public const int DOM_VK_CLEAR = 12;

		[Name("DOM_VK_CLOSE_BRACKET")]
		public const int DOM_VK_CLOSE_BRACKET = 221;

		[Name("DOM_VK_CLOSE_CURLY_BRACKET")]
		public const int DOM_VK_CLOSE_CURLY_BRACKET = 175;

		[Name("DOM_VK_CLOSE_PAREN")]
		public const int DOM_VK_CLOSE_PAREN = 169;

		[Name("DOM_VK_COLON")]
		public const int DOM_VK_COLON = 58;

		[Name("DOM_VK_COMMA")]
		public const int DOM_VK_COMMA = 188;

		[Name("DOM_VK_CONTEXT_MENU")]
		public const int DOM_VK_CONTEXT_MENU = 93;

		[Name("DOM_VK_CONTROL")]
		public const int DOM_VK_CONTROL = 17;

		[Name("DOM_VK_CONVERT")]
		public const int DOM_VK_CONVERT = 28;

		[Name("DOM_VK_CRSEL")]
		public const int DOM_VK_CRSEL = 247;

		[Name("DOM_VK_D")]
		public const int DOM_VK_D = 68;

		[Name("DOM_VK_DECIMAL")]
		public const int DOM_VK_DECIMAL = 110;

		[Name("DOM_VK_DELETE")]
		public const int DOM_VK_DELETE = 46;

		[Name("DOM_VK_DIVIDE")]
		public const int DOM_VK_DIVIDE = 111;

		[Name("DOM_VK_DOLLAR")]
		public const int DOM_VK_DOLLAR = 164;

		[Name("DOM_VK_DOUBLE_QUOTE")]
		public const int DOM_VK_DOUBLE_QUOTE = 162;

		[Name("DOM_VK_DOWN")]
		public const int DOM_VK_DOWN = 40;

		[Name("DOM_VK_E")]
		public const int DOM_VK_E = 69;

		[Name("DOM_VK_EISU")]
		public const int DOM_VK_EISU = 22;

		[Name("DOM_VK_END")]
		public const int DOM_VK_END = 35;

		[Name("DOM_VK_EQUALS")]
		public const int DOM_VK_EQUALS = 61;

		[Name("DOM_VK_EREOF")]
		public const int DOM_VK_EREOF = 249;

		[Name("DOM_VK_ESCAPE")]
		public const int DOM_VK_ESCAPE = 27;

		[Name("DOM_VK_EXCLAMATION")]
		public const int DOM_VK_EXCLAMATION = 161;

		[Name("DOM_VK_EXECUTE")]
		public const int DOM_VK_EXECUTE = 43;

		[Name("DOM_VK_EXSEL")]
		public const int DOM_VK_EXSEL = 248;

		[Name("DOM_VK_F")]
		public const int DOM_VK_F = 70;

		[Name("DOM_VK_F1")]
		public const int DOM_VK_F1 = 112;

		[Name("DOM_VK_F10")]
		public const int DOM_VK_F10 = 121;

		[Name("DOM_VK_F11")]
		public const int DOM_VK_F11 = 122;

		[Name("DOM_VK_F12")]
		public const int DOM_VK_F12 = 123;

		[Name("DOM_VK_F13")]
		public const int DOM_VK_F13 = 124;

		[Name("DOM_VK_F14")]
		public const int DOM_VK_F14 = 125;

		[Name("DOM_VK_F15")]
		public const int DOM_VK_F15 = 126;

		[Name("DOM_VK_F16")]
		public const int DOM_VK_F16 = 127;

		[Name("DOM_VK_F17")]
		public const int DOM_VK_F17 = 128;

		[Name("DOM_VK_F18")]
		public const int DOM_VK_F18 = 129;

		[Name("DOM_VK_F19")]
		public const int DOM_VK_F19 = 130;

		[Name("DOM_VK_F2")]
		public const int DOM_VK_F2 = 113;

		[Name("DOM_VK_F20")]
		public const int DOM_VK_F20 = 131;

		[Name("DOM_VK_F21")]
		public const int DOM_VK_F21 = 132;

		[Name("DOM_VK_F22")]
		public const int DOM_VK_F22 = 133;

		[Name("DOM_VK_F23")]
		public const int DOM_VK_F23 = 134;

		[Name("DOM_VK_F24")]
		public const int DOM_VK_F24 = 135;

		[Name("DOM_VK_F3")]
		public const int DOM_VK_F3 = 114;

		[Name("DOM_VK_F4")]
		public const int DOM_VK_F4 = 115;

		[Name("DOM_VK_F5")]
		public const int DOM_VK_F5 = 116;

		[Name("DOM_VK_F6")]
		public const int DOM_VK_F6 = 117;

		[Name("DOM_VK_F7")]
		public const int DOM_VK_F7 = 118;

		[Name("DOM_VK_F8")]
		public const int DOM_VK_F8 = 119;

		[Name("DOM_VK_F9")]
		public const int DOM_VK_F9 = 120;

		[Name("DOM_VK_FINAL")]
		public const int DOM_VK_FINAL = 24;

		[Name("DOM_VK_G")]
		public const int DOM_VK_G = 71;

		[Name("DOM_VK_GREATER_THAN")]
		public const int DOM_VK_GREATER_THAN = 62;

		[Name("DOM_VK_H")]
		public const int DOM_VK_H = 72;

		[Name("DOM_VK_HANGUL")]
		public const int DOM_VK_HANGUL = 21;

		[Name("DOM_VK_HANJA")]
		public const int DOM_VK_HANJA = 25;

		[Name("DOM_VK_HASH")]
		public const int DOM_VK_HASH = 163;

		[Name("DOM_VK_HELP")]
		public const int DOM_VK_HELP = 6;

		[Name("DOM_VK_HOME")]
		public const int DOM_VK_HOME = 36;

		[Name("DOM_VK_HYPHEN_MINUS")]
		public const int DOM_VK_HYPHEN_MINUS = 173;

		[Name("DOM_VK_I")]
		public const int DOM_VK_I = 73;

		[Name("DOM_VK_INSERT")]
		public const int DOM_VK_INSERT = 45;

		[Name("DOM_VK_J")]
		public const int DOM_VK_J = 74;

		[Name("DOM_VK_JUNJA")]
		public const int DOM_VK_JUNJA = 23;

		[Name("DOM_VK_K")]
		public const int DOM_VK_K = 75;

		[Name("DOM_VK_KANA")]
		public const int DOM_VK_KANA = 21;

		[Name("DOM_VK_KANJI")]
		public const int DOM_VK_KANJI = 25;

		[Name("DOM_VK_L")]
		public const int DOM_VK_L = 76;

		[Name("DOM_VK_LEFT")]
		public const int DOM_VK_LEFT = 37;

		[Name("DOM_VK_LESS_THAN")]
		public const int DOM_VK_LESS_THAN = 60;

		[Name("DOM_VK_M")]
		public const int DOM_VK_M = 77;

		[Name("DOM_VK_META")]
		public const int DOM_VK_META = 224;

		[Name("DOM_VK_MODECHANGE")]
		public const int DOM_VK_MODECHANGE = 31;

		[Name("DOM_VK_MULTIPLY")]
		public const int DOM_VK_MULTIPLY = 106;

		[Name("DOM_VK_N")]
		public const int DOM_VK_N = 78;

		[Name("DOM_VK_NONCONVERT")]
		public const int DOM_VK_NONCONVERT = 29;

		[Name("DOM_VK_NUM_LOCK")]
		public const int DOM_VK_NUM_LOCK = 144;

		[Name("DOM_VK_NUMPAD0")]
		public const int DOM_VK_NUMPAD0 = 96;

		[Name("DOM_VK_NUMPAD1")]
		public const int DOM_VK_NUMPAD1 = 97;

		[Name("DOM_VK_NUMPAD2")]
		public const int DOM_VK_NUMPAD2 = 98;

		[Name("DOM_VK_NUMPAD3")]
		public const int DOM_VK_NUMPAD3 = 99;

		[Name("DOM_VK_NUMPAD4")]
		public const int DOM_VK_NUMPAD4 = 100;

		[Name("DOM_VK_NUMPAD5")]
		public const int DOM_VK_NUMPAD5 = 101;

		[Name("DOM_VK_NUMPAD6")]
		public const int DOM_VK_NUMPAD6 = 102;

		[Name("DOM_VK_NUMPAD7")]
		public const int DOM_VK_NUMPAD7 = 103;

		[Name("DOM_VK_NUMPAD8")]
		public const int DOM_VK_NUMPAD8 = 104;

		[Name("DOM_VK_NUMPAD9")]
		public const int DOM_VK_NUMPAD9 = 105;

		[Name("DOM_VK_O")]
		public const int DOM_VK_O = 79;

		[Name("DOM_VK_OPEN_BRACKET")]
		public const int DOM_VK_OPEN_BRACKET = 219;

		[Name("DOM_VK_OPEN_CURLY_BRACKET")]
		public const int DOM_VK_OPEN_CURLY_BRACKET = 174;

		[Name("DOM_VK_OPEN_PAREN")]
		public const int DOM_VK_OPEN_PAREN = 168;

		[Name("DOM_VK_P")]
		public const int DOM_VK_P = 80;

		[Name("DOM_VK_PA1")]
		public const int DOM_VK_PA1 = 253;

		[Name("DOM_VK_PAGE_DOWN")]
		public const int DOM_VK_PAGE_DOWN = 34;

		[Name("DOM_VK_PAGE_UP")]
		public const int DOM_VK_PAGE_UP = 33;

		[Name("DOM_VK_PAUSE")]
		public const int DOM_VK_PAUSE = 19;

		[Name("DOM_VK_PERCENT")]
		public const int DOM_VK_PERCENT = 165;

		[Name("DOM_VK_PERIOD")]
		public const int DOM_VK_PERIOD = 190;

		[Name("DOM_VK_PIPE")]
		public const int DOM_VK_PIPE = 172;

		[Name("DOM_VK_PLAY")]
		public const int DOM_VK_PLAY = 250;

		[Name("DOM_VK_PLUS")]
		public const int DOM_VK_PLUS = 171;

		[Name("DOM_VK_PRINT")]
		public const int DOM_VK_PRINT = 42;

		[Name("DOM_VK_PRINTSCREEN")]
		public const int DOM_VK_PRINTSCREEN = 44;

		[Name("DOM_VK_Q")]
		public const int DOM_VK_Q = 81;

		[Name("DOM_VK_QUESTION_MARK")]
		public const int DOM_VK_QUESTION_MARK = 63;

		[Name("DOM_VK_QUOTE")]
		public const int DOM_VK_QUOTE = 222;

		[Name("DOM_VK_R")]
		public const int DOM_VK_R = 82;

		[Name("DOM_VK_RETURN")]
		public const int DOM_VK_RETURN = 13;

		[Name("DOM_VK_RIGHT")]
		public const int DOM_VK_RIGHT = 39;

		[Name("DOM_VK_S")]
		public const int DOM_VK_S = 83;

		[Name("DOM_VK_SCROLL_LOCK")]
		public const int DOM_VK_SCROLL_LOCK = 145;

		[Name("DOM_VK_SELECT")]
		public const int DOM_VK_SELECT = 41;

		[Name("DOM_VK_SEMICOLON")]
		public const int DOM_VK_SEMICOLON = 59;

		[Name("DOM_VK_SEPARATOR")]
		public const int DOM_VK_SEPARATOR = 108;

		[Name("DOM_VK_SHIFT")]
		public const int DOM_VK_SHIFT = 16;

		[Name("DOM_VK_SLASH")]
		public const int DOM_VK_SLASH = 191;

		[Name("DOM_VK_SLEEP")]
		public const int DOM_VK_SLEEP = 95;

		[Name("DOM_VK_SPACE")]
		public const int DOM_VK_SPACE = 32;

		[Name("DOM_VK_SUBTRACT")]
		public const int DOM_VK_SUBTRACT = 109;

		[Name("DOM_VK_T")]
		public const int DOM_VK_T = 84;

		[Name("DOM_VK_TAB")]
		public const int DOM_VK_TAB = 9;

		[Name("DOM_VK_TILDE")]
		public const int DOM_VK_TILDE = 176;

		[Name("DOM_VK_U")]
		public const int DOM_VK_U = 85;

		[Name("DOM_VK_UNDERSCORE")]
		public const int DOM_VK_UNDERSCORE = 167;

		[Name("DOM_VK_UP")]
		public const int DOM_VK_UP = 38;

		[Name("DOM_VK_V")]
		public const int DOM_VK_V = 86;

		[Name("DOM_VK_VOLUME_DOWN")]
		public const int DOM_VK_VOLUME_DOWN = 182;

		[Name("DOM_VK_VOLUME_MUTE")]
		public const int DOM_VK_VOLUME_MUTE = 181;

		[Name("DOM_VK_VOLUME_UP")]
		public const int DOM_VK_VOLUME_UP = 183;

		[Name("DOM_VK_W")]
		public const int DOM_VK_W = 87;

		[Name("DOM_VK_WIN")]
		public const int DOM_VK_WIN = 91;

		[Name("DOM_VK_WIN_ICO_00")]
		public const int DOM_VK_WIN_ICO_00 = 228;

		[Name("DOM_VK_WIN_ICO_CLEAR")]
		public const int DOM_VK_WIN_ICO_CLEAR = 230;

		[Name("DOM_VK_WIN_ICO_HELP")]
		public const int DOM_VK_WIN_ICO_HELP = 227;

		[Name("DOM_VK_WIN_OEM_ATTN")]
		public const int DOM_VK_WIN_OEM_ATTN = 240;

		[Name("DOM_VK_WIN_OEM_AUTO")]
		public const int DOM_VK_WIN_OEM_AUTO = 243;

		[Name("DOM_VK_WIN_OEM_BACKTAB")]
		public const int DOM_VK_WIN_OEM_BACKTAB = 245;

		[Name("DOM_VK_WIN_OEM_CLEAR")]
		public const int DOM_VK_WIN_OEM_CLEAR = 254;

		[Name("DOM_VK_WIN_OEM_COPY")]
		public const int DOM_VK_WIN_OEM_COPY = 242;

		[Name("DOM_VK_WIN_OEM_CUSEL")]
		public const int DOM_VK_WIN_OEM_CUSEL = 239;

		[Name("DOM_VK_WIN_OEM_ENLW")]
		public const int DOM_VK_WIN_OEM_ENLW = 244;

		[Name("DOM_VK_WIN_OEM_FINISH")]
		public const int DOM_VK_WIN_OEM_FINISH = 241;

		[Name("DOM_VK_WIN_OEM_FJ_JISHO")]
		public const int DOM_VK_WIN_OEM_FJ_JISHO = 146;

		[Name("DOM_VK_WIN_OEM_FJ_LOYA")]
		public const int DOM_VK_WIN_OEM_FJ_LOYA = 149;

		[Name("DOM_VK_WIN_OEM_FJ_MASSHOU")]
		public const int DOM_VK_WIN_OEM_FJ_MASSHOU = 147;

		[Name("DOM_VK_WIN_OEM_FJ_ROYA")]
		public const int DOM_VK_WIN_OEM_FJ_ROYA = 150;

		[Name("DOM_VK_WIN_OEM_FJ_TOUROKU")]
		public const int DOM_VK_WIN_OEM_FJ_TOUROKU = 148;

		[Name("DOM_VK_WIN_OEM_JUMP")]
		public const int DOM_VK_WIN_OEM_JUMP = 234;

		[Name("DOM_VK_WIN_OEM_PA1")]
		public const int DOM_VK_WIN_OEM_PA1 = 235;

		[Name("DOM_VK_WIN_OEM_PA2")]
		public const int DOM_VK_WIN_OEM_PA2 = 236;

		[Name("DOM_VK_WIN_OEM_PA3")]
		public const int DOM_VK_WIN_OEM_PA3 = 237;

		[Name("DOM_VK_WIN_OEM_RESET")]
		public const int DOM_VK_WIN_OEM_RESET = 233;

		[Name("DOM_VK_WIN_OEM_WSCTRL")]
		public const int DOM_VK_WIN_OEM_WSCTRL = 238;

		[Name("DOM_VK_X")]
		public const int DOM_VK_X = 88;

		[Name("DOM_VK_Y")]
		public const int DOM_VK_Y = 89;

		[Name("DOM_VK_Z")]
		public const int DOM_VK_Z = 90;

		[Name("DOM_VK_ZOOM")]
		public const int DOM_VK_ZOOM = 251;

		public extern bool GetModifierState(string key);

		public extern void InitKeyEvent(string type, bool canBubble, bool cancelable, WindowInstance view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int keyCode, int charCode);

		public readonly string Key;

		public readonly int KeyCode;

		public readonly int Location;

		public readonly bool MetaKey;

		public readonly bool Repeat;

		public readonly bool ShiftKey;
	}
}
