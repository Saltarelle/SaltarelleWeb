// AudioSourceNode.cs
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
    /// <summary>
    /// This is an abstract interface representing an audio source, an AudioNode which has no
    /// inputs and a single output:
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioSourceNode</reference>
    [IgnoreNamespace, Imported]
    public abstract class AudioSourceNode : AudioNode
    {
        protected AudioSourceNode()
        {
        }
    }
}
