// OscillatorNodePlaybackState.cs
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
    [NumericValues]
    public enum OscillatorNodePlaybackState : ushort
    {
        UnscheduledState = 0,
        ScheduledState = 1,
        PlayingState = 2,
        FinishedState = 3
    }
}
