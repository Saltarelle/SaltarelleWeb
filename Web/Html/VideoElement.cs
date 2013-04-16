using System.Runtime.CompilerServices;

namespace System.Html {
    [IgnoreNamespace]
    [ScriptName("Element")]
    [Imported(ObeysTypeSystem = true)]
    public sealed class VideoElement : MediaElement {
        private VideoElement() {}

        [IntrinsicProperty]
        public string Height { get; set; }

        [IntrinsicProperty]
        public string Poster { get; set; }

        [IntrinsicProperty]
        public int VideoHeight { get { return 0; } }

        [IntrinsicProperty]
        public int VideoWidth { get { return 0; } }

        [IntrinsicProperty]
        public int Width { get; set; }
    }
}
