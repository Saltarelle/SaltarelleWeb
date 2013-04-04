// BiquadFilterType.cs
// SaltarelleWeb/Html/Media/Audio
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Timothy Fries - drysart@gmail.com

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html.Media.Audio
{
    [NamedValues]
    [IgnoreNamespace, Imported]
    public enum BiquadFilterType
    {
        [ScriptName("lowpass")]
        LowPass,

        [ScriptName("highpass")]
        HighPass,

        [ScriptName("bandpass")]
        BandPass,

        [ScriptName("lowshelf")]
        LowShelf,

        [ScriptName("highshelf")]
        HighShelf,

        [ScriptName("peaking")]
        Peaking,

        [ScriptName("notch")]
        Notch,

        [ScriptName("allpass")]
        AllPass
    }
}
