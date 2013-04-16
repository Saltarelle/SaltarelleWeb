// AudioElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {
    [IgnoreNamespace]
    [ScriptName("Element")]
    [Imported(ObeysTypeSystem = true)]
    public class MediaElement : Element {
        internal MediaElement() {}

        [IntrinsicProperty]
        public bool Autoplay { get; set; }

        [IntrinsicProperty]
        public bool Buffered { get { return false; } }

        [IntrinsicProperty]
        public bool Controls { get; set; }

        [IntrinsicProperty]
        public MediaCrossOriginPolicy CrossOrigin { get; set; }

        [IntrinsicProperty]
        public string CurrentSrc { get { return null; } }

        [IntrinsicProperty]
        public double CurrentTime { get; set; }

        [IntrinsicProperty]
        public bool DefaultMuted { get; set; }

        [IntrinsicProperty]
        public double DefaultPlaybackRate { get; set; }

        [IntrinsicProperty]
        public double Duration { get { return 0; } }

        [IntrinsicProperty]
        public bool Ended { get { return false; } }

        [IntrinsicProperty]
        public bool Error { get { return false; } }

        [IntrinsicProperty]
        public double InitialTime { get { return 0; } }

        [IntrinsicProperty]
        public bool Loop { get; set; }

        [IntrinsicProperty]
        public bool Muted { get; set; }

        [IntrinsicProperty]
        public MediaElementNetworkState NetworkState { get { return MediaElementNetworkState.Empty; } }

        [IntrinsicProperty]
        public bool Paused { get { return false; } }

        [IntrinsicProperty]
        public double PlaybackRate { get; set; }

        [IntrinsicProperty]
        public TimeRanges Played { get { return null; } }

        [IntrinsicProperty]
        public MediaPreload Preload { get; set; }

        [IntrinsicProperty]
        public MediaElementReadyState ReadyState { get { return MediaElementReadyState.HaveNothing; } }

        [IntrinsicProperty]
        public TimeRanges Seekable { get { return null; } }

        [IntrinsicProperty]
        public string Src { get; set; }

        [IntrinsicProperty]
        public DateTime StartOffsetTime { get; set; }

        [IntrinsicProperty]
        public float Volume { get; set; }

        public MediaPlayability CanPlayType(string type) { return MediaPlayability.No; }

        public void Load() {}

        public void Pause() {}

        public void Play() {}
    }
}
