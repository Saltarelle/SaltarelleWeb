// ChannelMergerNode.cs
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
    /// This interface represents an AudioNode for combining channels from multiple audio 
    /// streams into a single audio stream.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#ChannelMergerNode</reference>
    [IgnoreNamespace, Imported]
    public class ChannelMergerNode : AudioNode
    {
        private ChannelMergerNode()
        {
        }
    }
}
