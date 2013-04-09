// ChannelSplitterNode.cs
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
    /// This interface represents an AudioNode for accessing the individual channels of an audio 
    /// stream in the routing graph.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#ChannelSplitterNode</reference>
    [IgnoreNamespace, Imported]
    public class ChannelSplitterNode : AudioNode
    {
        private ChannelSplitterNode()
        {
        }
    }
}
