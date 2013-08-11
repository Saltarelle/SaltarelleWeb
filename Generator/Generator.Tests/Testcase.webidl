interface Float32Array;
interface Uint8Array;
interface ArrayBuffer;
interface ArrayBufferView;
interface DOMTimeStamp;
interface ByteString;
interface Uint8ClampedArray;
interface Int32Array;


[PrefControlled]
interface AnalyserNode : AudioNode {


    void getFloatFrequencyData(Float32Array array);
    void getByteFrequencyData(Uint8Array array);


    void getByteTimeDomainData(Uint8Array array);

    [SetterThrows, Pure]
    attribute unsigned long fftSize;
    [Pure]
    readonly attribute unsigned long frequencyBinCount;

    [SetterThrows, Pure]
    attribute double minDecibels;
    [SetterThrows, Pure]
    attribute double maxDecibels;

    [SetterThrows, Pure]
    attribute double smoothingTimeConstant;

};
[Constructor(DOMString type, optional AnimationEventInit eventInitDict)]
interface AnimationEvent : Event {
  readonly attribute DOMString animationName;
  readonly attribute float elapsedTime;
  readonly attribute DOMString pseudoElement;
};

dictionary AnimationEventInit : EventInit {
  DOMString animationName = "";
  float elapsedTime = 0;
  DOMString pseudoElement = "";
};
[PrefControlled, Constructor(Blob blob, optional ArchiveReaderOptions options)]
interface ArchiveReader {
  ArchiveRequest getFilenames();
  ArchiveRequest getFile(DOMString filename);
  ArchiveRequest getFiles();
};

dictionary ArchiveReaderOptions {
  DOMString encoding = "windows-1252";
};
interface ArchiveRequest : DOMRequest {
  readonly attribute ArchiveReader reader;
};
interface Attr : Node {
  readonly attribute DOMString localName;
           [SetterThrows]
           attribute DOMString value;

  readonly attribute DOMString name;
  readonly attribute DOMString? namespaceURI;
  readonly attribute DOMString? prefix;
};



partial interface Attr {
  readonly attribute boolean specified;


           [GetterThrows]
  readonly attribute Element? ownerElement;
};
[PrefControlled]
interface AudioBuffer {

    readonly attribute float sampleRate;
    readonly attribute long length;


    readonly attribute double duration;

    readonly attribute long numberOfChannels;

    [Throws]
    Float32Array getChannelData(unsigned long channel);

};
[PrefControlled]
interface AudioBufferSourceNode : AudioNode {

    attribute AudioBuffer? buffer;

    readonly attribute AudioParam playbackRate;

    attribute boolean loop;
    attribute double loopStart;
    attribute double loopEnd;

    [Throws]
    void start(optional double when = 0, optional double grainOffset = 0, optional double grainDuration);
    [Throws]
    void stop(optional double when = 0);

    [SetterThrows]
    attribute EventHandler onended;
};
[PrefControlled]
partial interface AudioBufferSourceNode {

    [Throws,Pref="media.webaudio.legacy.AudioBufferSourceNode"]
    void noteOn(double when);
    [Throws,Pref="media.webaudio.legacy.AudioBufferSourceNode"]
    void noteGrainOn(double when, double grainOffset, double grainDuration);

    [Throws,Pref="media.webaudio.legacy.AudioBufferSourceNode"]

    void noteOff(double when);
};
interface AudioChannelManager : EventTarget {
  readonly attribute boolean headphones;
  [SetterThrows]
  attribute EventHandler onheadphoneschange;
};
callback DecodeSuccessCallback = void (AudioBuffer decodedData);
callback DecodeErrorCallback = void ();

[Constructor, PrefControlled]
interface AudioContext : EventTarget {

    readonly attribute AudioDestinationNode destination;
    readonly attribute float sampleRate;
    readonly attribute double currentTime;
    readonly attribute AudioListener listener;

    [Creator, Throws]
    AudioBuffer createBuffer(unsigned long numberOfChannels, unsigned long length, float sampleRate);

    void decodeAudioData(ArrayBuffer audioData, DecodeSuccessCallback successCallback, optional DecodeErrorCallback errorCallback);


    [Creator]
    AudioBufferSourceNode createBufferSource();

    [Creator, Throws]
    MediaStreamAudioDestinationNode createMediaStreamDestination();

    [Creator, Throws]
    ScriptProcessorNode createScriptProcessor(optional unsigned long bufferSize = 0, optional unsigned long numberOfInputChannels = 2, optional unsigned long numberOfOutputChannels = 2);

    [Creator]
    AnalyserNode createAnalyser();
    [Creator]
    GainNode createGain();
    [Creator, Throws]
    DelayNode createDelay(optional double maxDelayTime = 1);
    [Creator]
    BiquadFilterNode createBiquadFilter();
    [Creator]
    WaveShaperNode createWaveShaper();
    [Creator]
    PannerNode createPanner();
    [Creator]
    ConvolverNode createConvolver();

    [Creator, Throws]
    ChannelSplitterNode createChannelSplitter(optional unsigned long numberOfOutputs = 6);
    [Creator, Throws]
    ChannelMergerNode createChannelMerger(optional unsigned long numberOfInputs = 6);

    [Creator]
    DynamicsCompressorNode createDynamicsCompressor();

    [Creator, Throws]
    PeriodicWave createPeriodicWave(Float32Array real, Float32Array imag);

};
[PrefControlled]
partial interface AudioContext {
    [Creator, Throws]
    AudioBuffer? createBuffer(ArrayBuffer buffer, boolean mixToMono);


    [Creator,Pref="media.webaudio.legacy.AudioContext"]
    GainNode createGainNode();


    [Creator, Throws, Pref="media.webaudio.legacy.AudioContext"]
    DelayNode createDelayNode(optional double maxDelayTime = 1);


    [Creator, Throws, Pref="media.webaudio.legacy.AudioContext"]
    ScriptProcessorNode createJavaScriptNode(optional unsigned long bufferSize = 0, optional unsigned long numberOfInputChannels = 2, optional unsigned long numberOfOutputChannels = 2);
};
[PrefControlled]
interface AudioDestinationNode : AudioNode {

    readonly attribute unsigned long maxChannelCount;

};
[PrefControlled]
interface AudioListener {


    attribute double dopplerFactor;


    attribute double speedOfSound;


    void setPosition(double x, double y, double z);
    void setOrientation(double x, double y, double z, double xUp, double yUp, double zUp);
    void setVelocity(double x, double y, double z);

};
enum ChannelCountMode {
    "max",
    "clamped-max",
    "explicit"
};

enum ChannelInterpretation {
    "speakers",
    "discrete"
};

[PrefControlled]
interface AudioNode : EventTarget {

    [Throws]
    void connect(AudioNode destination, optional unsigned long output = 0, optional unsigned long input = 0);
    [Throws]
    void connect(AudioParam destination, optional unsigned long output = 0);
    [Throws]
    void disconnect(optional unsigned long output = 0);

    readonly attribute AudioContext context;
    readonly attribute unsigned long numberOfInputs;
    readonly attribute unsigned long numberOfOutputs;


    [SetterThrows]
    attribute unsigned long channelCount;
    attribute ChannelCountMode channelCountMode;
    attribute ChannelInterpretation channelInterpretation;

};
[PrefControlled]
interface AudioParam {

    attribute float value;
    readonly attribute float defaultValue;


    [Throws]
    void setValueAtTime(float value, double startTime);
    [Throws]
    void linearRampToValueAtTime(float value, double endTime);
    [Throws]
    void exponentialRampToValueAtTime(float value, double endTime);


    [Throws]
    void setTargetAtTime(float target, double startTime, double timeConstant);



    [Throws]
    void setValueCurveAtTime(Float32Array values, double startTime, double duration);


    [Throws]
    void cancelScheduledValues(double startTime);

};
[PrefControlled]
partial interface AudioParam {

    [Throws,Pref="media.webaudio.legacy.AudioParam"]
    void setTargetValueAtTime(float target, double startTime, double timeConstant);
};
[PrefControlled]
interface AudioProcessingEvent : Event {

    readonly attribute double playbackTime;
    readonly attribute AudioBuffer inputBuffer;
    readonly attribute AudioBuffer outputBuffer;

};
interface AudioStreamTrack : MediaStreamTrack {

};
interface BarProp {
  [Throws]
           attribute boolean visible;
};
interface BatteryManager : EventTarget {
    readonly attribute boolean charging;
    readonly attribute unrestricted double chargingTime;
    readonly attribute unrestricted double dischargingTime;
    readonly attribute double level;

    [SetterThrows]
             attribute EventHandler onchargingchange;
    [SetterThrows]
             attribute EventHandler onchargingtimechange;
    [SetterThrows]
             attribute EventHandler ondischargingtimechange;
    [SetterThrows]
             attribute EventHandler onlevelchange;
};
interface BeforeUnloadEvent : Event {
  attribute DOMString returnValue;
};
enum BiquadFilterType {

  "0",
  "1",
  "2",
  "3",
  "4",
  "5",
  "6",
  "7",

  "lowpass",
  "highpass",
  "bandpass",
  "lowshelf",
  "highshelf",
  "peaking",
  "notch",
  "allpass"
};

[PrefControlled]
interface BiquadFilterNode : AudioNode {

    attribute BiquadFilterType type;
    readonly attribute AudioParam frequency;
    readonly attribute AudioParam detune;
    readonly attribute AudioParam Q;
    readonly attribute AudioParam gain;

    void getFrequencyResponse(Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse);

};
[PrefControlled]
partial interface BiquadFilterNode {
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short LOWPASS = 0;
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short HIGHPASS = 1;
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short BANDPASS = 2;
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short LOWSHELF = 3;
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short HIGHSHELF = 4;
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short PEAKING = 5;
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short NOTCH = 6;
    [Pref="media.webaudio.legacy.BiquadFilterNode"]
    const unsigned short ALLPASS = 7;
};
enum EndingTypes {
	"transparent",
	"native"
};

dictionary BlobPropertyBag {

  DOMString type = "";
  EndingTypes endings = "transparent";

};
interface Blob;

[Constructor(DOMString type, optional BlobEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface BlobEvent : Event {
  readonly attribute Blob? data;
};

dictionary BlobEventInit : EventInit {
  Blob? data = null;
};
interface BluetoothDevice;

[Constructor(DOMString type, optional BluetoothDeviceEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface BluetoothDeviceEvent : Event {
  readonly attribute BluetoothDevice? device;
};

dictionary BluetoothDeviceEventInit : EventInit {
  BluetoothDevice? device = null;
};
interface TelephonyCall;

[Constructor(DOMString type, optional CallEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface CallEvent : Event {
  readonly attribute TelephonyCall? call;
};

dictionary CallEventInit : EventInit {
  TelephonyCall? call = null;
};
dictionary CameraPictureOptions {
  any pictureSize = null;
  DOMString fileFormat = "";
  long rotation = 0;
  any position = null;
  long long dateTime = 0;
};



interface GetCameraCallback;
interface CameraErrorCallback;


dictionary CameraSelector {
    DOMString camera = "back";
};

interface CameraManager {
  [Throws]
  void getCamera(CameraSelector options, GetCameraCallback callback, optional CameraErrorCallback errorCallback);
  [Throws]
  sequence<DOMString> getListOfCameras();
};
interface HitRegionOptions;
interface Window;

enum CanvasWindingRule {
	"nonzero",
	"evenodd"
};

interface CanvasRenderingContext2D {



  readonly attribute HTMLCanvasElement? canvas;


  void save();
  void restore();



  [Throws, LenientFloat]
  void scale(double x, double y);
  [Throws, LenientFloat]
  void rotate(double angle);
  [Throws, LenientFloat]
  void translate(double x, double y);
  [Throws, LenientFloat]
  void transform(double a, double b, double c, double d, double e, double f);
  [Throws, LenientFloat]
  void setTransform(double a, double b, double c, double d, double e, double f);



           attribute unrestricted double globalAlpha;
           [Throws]
           attribute DOMString globalCompositeOperation;


           attribute (DOMString or CanvasGradient or CanvasPattern) strokeStyle;
           attribute (DOMString or CanvasGradient or CanvasPattern) fillStyle;
  [Creator]
  CanvasGradient createLinearGradient(double x0, double y0, double x1, double y1);
  [Creator, Throws]
  CanvasGradient createRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1);
  [Creator, Throws]
  CanvasPattern createPattern((HTMLImageElement or HTMLCanvasElement or HTMLVideoElement) image, [TreatNullAs=EmptyString] DOMString repetition);


           [LenientFloat]
           attribute double shadowOffsetX;
           [LenientFloat]
           attribute double shadowOffsetY;
           [LenientFloat]
           attribute double shadowBlur;
           attribute DOMString shadowColor;


  [LenientFloat]
  void clearRect(double x, double y, double w, double h);
  [LenientFloat]
  void fillRect(double x, double y, double w, double h);
  [LenientFloat]
  void strokeRect(double x, double y, double w, double h);


  void beginPath();
  void fill([TreatUndefinedAs=Missing] optional CanvasWindingRule winding = "nonzero");

  void stroke();







  void clip([TreatUndefinedAs=Missing] optional CanvasWindingRule winding = "nonzero");


  boolean isPointInPath(unrestricted double x, unrestricted double y, [TreatUndefinedAs=Missing] optional CanvasWindingRule winding = "nonzero");

  boolean isPointInStroke(double x, double y);


  [Throws, LenientFloat]
  void fillText(DOMString text, double x, double y, optional double maxWidth);
  [Throws, LenientFloat]
  void strokeText(DOMString text, double x, double y, optional double maxWidth);
  [Creator, Throws]
  TextMetrics measureText(DOMString text);



  [Throws, LenientFloat]
  void drawImage((HTMLImageElement or HTMLCanvasElement or HTMLVideoElement) image, double dx, double dy);
  [Throws, LenientFloat]
  void drawImage((HTMLImageElement or HTMLCanvasElement or HTMLVideoElement) image, double dx, double dy, double dw, double dh);
  [Throws, LenientFloat]
  void drawImage((HTMLImageElement or HTMLCanvasElement or HTMLVideoElement) image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh);





  [Creator, Throws]
  ImageData createImageData(double sw, double sh);
  [Creator, Throws]
  ImageData createImageData(ImageData imagedata);
  [Creator, Throws]
  ImageData getImageData(double sx, double sy, double sw, double sh);
  [Throws]
  void putImageData(ImageData imagedata, double dx, double dy);
  [Throws]
  void putImageData(ImageData imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight);



  [Throws]
  attribute object mozCurrentTransform;
  [Throws]
  attribute object mozCurrentTransformInverse;

  attribute DOMString mozFillRule;

  [Throws]
  attribute any mozDash;

  [LenientFloat]
  attribute double mozDashOffset;

  [SetterThrows]
  attribute DOMString mozTextStyle;



  attribute boolean mozImageSmoothingEnabled;


  [ChromeOnly]
  const unsigned long DRAWWINDOW_DRAW_CARET = 0x01;


  [ChromeOnly]
  const unsigned long DRAWWINDOW_DO_NOT_FLUSH = 0x02;

  [ChromeOnly]
  const unsigned long DRAWWINDOW_DRAW_VIEW = 0x04;




  [ChromeOnly]
  const unsigned long DRAWWINDOW_USE_WIDGET_LAYERS = 0x08;

  [ChromeOnly]
  const unsigned long DRAWWINDOW_ASYNC_DECODE_IMAGES = 0x10;
  [Throws, ChromeOnly]
  void drawWindow(Window window, double x, double y, double w, double h, DOMString bgColor, optional unsigned long flags = 0);
  [Throws, ChromeOnly]
  void asyncDrawXULElement(XULElement elem, double x, double y, double w, double h, DOMString bgColor, optional unsigned long flags = 0);
};
CanvasRenderingContext2D implements CanvasDrawingStyles;
CanvasRenderingContext2D implements CanvasPathMethods;

[NoInterfaceObject]
interface CanvasDrawingStyles {

           [LenientFloat]
           attribute double lineWidth;
           attribute DOMString lineCap;
           [GetterThrows]
           attribute DOMString lineJoin;
           [LenientFloat]
           attribute double miterLimit;







           [SetterThrows]
           attribute DOMString font;
           attribute DOMString textAlign;
           attribute DOMString textBaseline;
};

[NoInterfaceObject]
interface CanvasPathMethods {

  void closePath();
  [LenientFloat]
  void moveTo(double x, double y);
  [LenientFloat]
  void lineTo(double x, double y);
  [LenientFloat]
  void quadraticCurveTo(double cpx, double cpy, double x, double y);

  [LenientFloat]
  void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

  [Throws, LenientFloat]
  void arcTo(double x1, double y1, double x2, double y2, double radius);


  [LenientFloat]
  void rect(double x, double y, double w, double h);

  [Throws, LenientFloat]
  void arc(double x, double y, double radius, double startAngle, double endAngle, optional boolean anticlockwise = false);

};

interface CanvasGradient {

  [Throws]

  void addColorStop(float offset, DOMString color);
};

interface CanvasPattern {


};

interface TextMetrics {


  readonly attribute double width;
};
interface CaretPosition {
  readonly attribute Node? offsetNode;
  readonly attribute unsigned long offset;

};
partial interface CaretPosition {
  ClientRect? getClientRect();
};
interface CDATASection : Text {
};
[Constructor(DOMString type, optional CFStateChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface CFStateChangeEvent : Event {
  readonly attribute boolean success;
  readonly attribute unsigned short action;
  readonly attribute unsigned short reason;
  readonly attribute DOMString? number;
  readonly attribute unsigned short timeSeconds;
  readonly attribute unsigned short serviceClass;
};

dictionary CFStateChangeEventInit : EventInit {
  boolean success = false;
  unsigned short action = 0;
  unsigned short reason = 0;
  DOMString number = "";
  unsigned short timeSeconds = 0;
  unsigned short serviceClass = 0;
};
[PrefControlled]
interface ChannelMergerNode : AudioNode {

};
[PrefControlled]
interface ChannelSplitterNode : AudioNode {

};
interface CharacterData : Node {
  [TreatNullAs=EmptyString,SetterThrows]
  attribute DOMString data;
  readonly attribute unsigned long length;
  [Throws]
  DOMString substringData(unsigned long offset, unsigned long count);
  [Throws]
  void appendData(DOMString data);
  [Throws]
  void insertData(unsigned long offset, DOMString data);
  [Throws]
  void deleteData(unsigned long offset, unsigned long count);
  [Throws]
  void replaceData(unsigned long offset, unsigned long count, DOMString data);
};

CharacterData implements ChildNode;
[NoInterfaceObject]
interface ChildNode {
  [Pure]
  readonly attribute Element? previousElementSibling;
  [Pure]
  readonly attribute Element? nextElementSibling;





  void remove();
};
interface ClientRect {
  readonly attribute float left;
  readonly attribute float top;
  readonly attribute float right;
  readonly attribute float bottom;
  readonly attribute float width;
  readonly attribute float height;
};
interface ClientRectList {
  readonly attribute unsigned long length;
  getter ClientRect? item(unsigned long index);
};
interface DataTransfer;

[Constructor(DOMString type, optional ClipboardEventInit eventInitDict)]
interface ClipboardEvent : Event {
  readonly attribute DataTransfer? clipboardData;
};

dictionary ClipboardEventInit : EventInit {
  DOMString data = "";
  DOMString dataType = "";
};
[Constructor(DOMString type, optional CloseEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface CloseEvent : Event {
  readonly attribute boolean wasClean;
  readonly attribute unsigned short code;
  readonly attribute DOMString? reason;


  [Throws]
  void initCloseEvent(DOMString type, boolean canBubble, boolean cancelable, boolean wasClean, unsigned short code, DOMString? reason);
};

dictionary CloseEventInit : EventInit {
  boolean wasClean = false;
  unsigned short code = 0;
  DOMString reason = "";
};
interface CommandEvent : Event {
  readonly attribute DOMString? command;

  void initCommandEvent(DOMString type, boolean canBubble, boolean cancelable, DOMString? command);
};
[Constructor(optional DOMString data = "")]
interface Comment : CharacterData {
};
interface WindowProxy;

interface CompositionEvent : UIEvent {
  readonly attribute DOMString? data;
  readonly attribute DOMString locale;
};

partial interface CompositionEvent {
  [Throws]
  void initCompositionEvent(DOMString typeArg, boolean canBubbleArg, boolean cancelableArg, WindowProxy? viewArg, DOMString? dataArg, DOMString localeArg);
};
[PrefControlled]
interface ConvolverNode : AudioNode {

      [SetterThrows]
      attribute AudioBuffer? buffer;
      attribute boolean normalize;

};
[NoInterfaceObject]
interface Coordinates {
  readonly attribute double latitude;
  readonly attribute double longitude;
  readonly attribute double? altitude;
  readonly attribute double accuracy;
  readonly attribute double? altitudeAccuracy;
  readonly attribute double? heading;
  readonly attribute double? speed;
};
[PrefControlled]
interface CSS {
  [Throws, Pref="layout.css.supports-rule.enabled"]
  static boolean supports(DOMString property, DOMString value);

  [Throws, Pref="layout.css.supports-rule.enabled"]
  static boolean supports(DOMString conditionText);
};



interface CSS2Properties : CSSStyleDeclaration {
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozAppearance;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozOutlineRadius;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozOutlineRadiusTopleft;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozOutlineRadiusTopright;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozOutlineRadiusBottomright;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozOutlineRadiusBottomleft;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozTabSize;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animation;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationDelay;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationDirection;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationDuration;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationFillMode;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationIterationCount;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationName;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationPlayState;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString animationTimingFunction;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString background;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundAttachment;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundClip;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundImage;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBackgroundInlinePolicy;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundOrigin;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundPosition;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundRepeat;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backgroundSize;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBinding;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString border;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderBottom;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderBottomColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderBottomColors;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderBottomStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderBottomWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderCollapse;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderEnd;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderEndColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderEndStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderEndWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderImage;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderImageSource;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderImageSlice;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderImageWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderImageOutset;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderImageRepeat;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderLeft;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderLeftColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderLeftColors;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderLeftStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderLeftWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderRight;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderRightColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderRightColors;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderRightStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderRightWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderSpacing;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderStart;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderStartColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderStartStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderStartWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderTop;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderTopColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBorderTopColors;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderTopStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderTopWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderRadius;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderTopLeftRadius;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderTopRightRadius;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderBottomRightRadius;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString borderBottomLeftRadius;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString bottom;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString boxShadow;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBoxSizing;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString captionSide;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString clear;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString clip;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString color;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumns;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnCount;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnFill;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnGap;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnRule;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnRuleColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnRuleStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozColumnRuleWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString content;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString counterIncrement;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString counterReset;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString cursor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString direction;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString display;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString emptyCells;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString alignItems;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString alignSelf;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString flex;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString flexBasis;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString flexDirection;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString flexGrow;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString flexShrink;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString order;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.flexbox.enabled"]
  attribute DOMString justifyContent;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString cssFloat;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozFloatEdge;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString font;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fontFamily;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozFontFeatureSettings;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontKerning;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozFontLanguageOverride;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fontSize;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fontSizeAdjust;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fontStretch;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fontStyle;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontSynthesis;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fontVariant;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontVariantAlternates;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontVariantCaps;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontVariantEastAsian;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontVariantLigatures;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontVariantNumeric;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontVariantPosition;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fontWeight;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozForceBrokenImageIcon;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString height;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozImageRegion;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString imeMode;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString left;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString letterSpacing;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString lineHeight;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString listStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString listStyleImage;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString listStylePosition;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString listStyleType;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString margin;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString marginBottom;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozMarginEnd;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString marginLeft;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString marginRight;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozMarginStart;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString marginTop;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString markerOffset;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString marks;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString maxHeight;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString maxWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString minHeight;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString minWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString opacity;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozOrient;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString orphans;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString outline;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString outlineColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString outlineStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString outlineWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString outlineOffset;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString overflow;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString overflowX;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString overflowY;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString padding;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString paddingBottom;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozPaddingEnd;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString paddingLeft;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString paddingRight;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozPaddingStart;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString paddingTop;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString page;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString pageBreakAfter;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString pageBreakBefore;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString pageBreakInside;
  [Throws, TreatNullAs=EmptyString, Pref="svg.paint-order.enabled"]
  attribute DOMString paintOrder;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString pointerEvents;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.vertical-text.enabled"]
  attribute DOMString writingMode;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString position;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString quotes;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString resize;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString right;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString size;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString tableLayout;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textAlign;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozTextAlignLast;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textDecoration;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozTextBlink;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozTextDecorationColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozTextDecorationLine;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozTextDecorationStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textIndent;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textOverflow;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textShadow;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozTextSizeAdjust;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textTransform;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transform;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transformOrigin;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString perspectiveOrigin;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString perspective;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transformStyle;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString backfaceVisibility;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString top;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transition;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transitionDelay;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transitionDuration;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transitionProperty;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString transitionTimingFunction;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString unicodeBidi;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozUserFocus;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozUserInput;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozUserModify;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozUserSelect;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString verticalAlign;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString visibility;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString whiteSpace;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString widows;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString width;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozWindowShadow;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString wordBreak;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString wordSpacing;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString wordWrap;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozHyphens;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString zIndex;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBoxAlign;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBoxDirection;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBoxFlex;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBoxOrient;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBoxPack;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozBoxOrdinalGroup;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString MozStackSizing;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString clipPath;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString clipRule;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString colorInterpolation;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString colorInterpolationFilters;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString dominantBaseline;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fill;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fillOpacity;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString fillRule;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString filter;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString floodColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString floodOpacity;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString imageRendering;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString lightingColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString marker;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString markerEnd;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString markerMid;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString markerStart;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString mask;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.masking.enabled"]
  attribute DOMString maskType;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString shapeRendering;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString stopColor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString stopOpacity;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString stroke;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString strokeDasharray;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString strokeDashoffset;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString strokeLinecap;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString strokeLinejoin;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString strokeMiterlimit;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString strokeOpacity;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString strokeWidth;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textAnchor;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString textRendering;
  [Throws, TreatNullAs=EmptyString]
  attribute DOMString vectorEffect;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transforms"]
  attribute DOMString MozTransform;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transforms"]
  attribute DOMString MozTransformOrigin;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transforms"]
  attribute DOMString MozPerspectiveOrigin;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transforms"]
  attribute DOMString MozPerspective;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transforms"]
  attribute DOMString MozTransformStyle;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transforms"]
  attribute DOMString MozBackfaceVisibility;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.border-image"]
  attribute DOMString MozBorderImage;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transitions"]
  attribute DOMString MozTransition;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transitions"]
  attribute DOMString MozTransitionDelay;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transitions"]
  attribute DOMString MozTransitionDuration;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transitions"]
  attribute DOMString MozTransitionProperty;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.transitions"]
  attribute DOMString MozTransitionTimingFunction;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimation;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationDelay;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationDirection;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationDuration;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationFillMode;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationIterationCount;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationName;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationPlayState;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.prefixes.animations"]
  attribute DOMString MozAnimationTimingFunction;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontFeatureSettings;
  [Throws, TreatNullAs=EmptyString, Pref="layout.css.font-features.enabled"]
  attribute DOMString fontLanguageOverride;

};
interface Counter;

interface CSSPrimitiveValue : CSSValue {


  const unsigned short CSS_UNKNOWN = 0;
  const unsigned short CSS_NUMBER = 1;
  const unsigned short CSS_PERCENTAGE = 2;
  const unsigned short CSS_EMS = 3;
  const unsigned short CSS_EXS = 4;
  const unsigned short CSS_PX = 5;
  const unsigned short CSS_CM = 6;
  const unsigned short CSS_MM = 7;
  const unsigned short CSS_IN = 8;
  const unsigned short CSS_PT = 9;
  const unsigned short CSS_PC = 10;
  const unsigned short CSS_DEG = 11;
  const unsigned short CSS_RAD = 12;
  const unsigned short CSS_GRAD = 13;
  const unsigned short CSS_MS = 14;
  const unsigned short CSS_S = 15;
  const unsigned short CSS_HZ = 16;
  const unsigned short CSS_KHZ = 17;
  const unsigned short CSS_DIMENSION = 18;
  const unsigned short CSS_STRING = 19;
  const unsigned short CSS_URI = 20;
  const unsigned short CSS_IDENT = 21;
  const unsigned short CSS_ATTR = 22;
  const unsigned short CSS_COUNTER = 23;
  const unsigned short CSS_RECT = 24;
  const unsigned short CSS_RGBCOLOR = 25;

  readonly attribute unsigned short primitiveType;
  [Throws]
  void setFloatValue(unsigned short unitType, float floatValue);
  [Throws]
  float getFloatValue(unsigned short unitType);
  [Throws]
  void setStringValue(unsigned short stringType, DOMString stringValue);
  [Throws]
  DOMString getStringValue();
  [Throws]
  Counter getCounterValue();
  [Throws]
  Rect getRectValue();
  [Throws]
  RGBColor getRGBColorValue();
};
interface CSSRule;

interface CSSStyleDeclaration {
  [SetterThrows]
  attribute DOMString cssText;

  readonly attribute unsigned long length;
  getter DOMString item(unsigned long index);

  [Throws]
  DOMString getPropertyValue(DOMString property);

  [Throws]
  CSSValue? getPropertyCSSValue(DOMString property);
  DOMString getPropertyPriority(DOMString property);
  [Throws]
  void setProperty(DOMString property, DOMString value, [TreatNullAs=EmptyString] optional DOMString priority = "");
  [Throws]
  DOMString removeProperty(DOMString property);

  readonly attribute CSSRule? parentRule;
};
interface CSSRuleList;
interface CSSRule;

interface CSSStyleSheet : StyleSheet {
  [Pure]
  readonly attribute CSSRule? ownerRule;
  [Throws]
  readonly attribute CSSRuleList cssRules;
  [Throws]
  unsigned long insertRule(DOMString rule, unsigned long index);
  [Throws]
  void deleteRule(unsigned long index);
};
interface CSSValue {


  const unsigned short CSS_INHERIT = 0;
  const unsigned short CSS_PRIMITIVE_VALUE = 1;
  const unsigned short CSS_VALUE_LIST = 2;
  const unsigned short CSS_CUSTOM = 3;

           [Throws]
           attribute DOMString cssText;

  readonly attribute unsigned short cssValueType;
};
interface CSSValueList : CSSValue {
         readonly attribute unsigned long length;
  getter CSSValue? item(unsigned long index);
};
[Constructor(DOMString type, optional CustomEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface CustomEvent : Event {
  [Throws]
  readonly attribute any detail;


  [Throws]
  void initCustomEvent(DOMString type, boolean canBubble, boolean cancelable, any detail);
};

dictionary CustomEventInit : EventInit {
  any detail = null;
};
enum RTCDataChannelState {
  "connecting",
  "open",
  "closing",
  "closed"
};

enum RTCDataChannelType {
  "arraybuffer",
  "blob"
};


interface DataChannel : EventTarget {
  readonly attribute DOMString label;
  readonly attribute boolean reliable;
  readonly attribute RTCDataChannelState readyState;
  readonly attribute unsigned long bufferedAmount;
  [SetterThrows]
  attribute EventHandler onopen;
  [SetterThrows]
  attribute EventHandler onerror;
  [SetterThrows]
  attribute EventHandler onclose;
  void close();
  [SetterThrows]
  attribute EventHandler onmessage;
  attribute RTCDataChannelType binaryType;
  [Throws]
  void send(DOMString data);
  [Throws]
  void send(Blob data);
  [Throws]
  void send(ArrayBuffer data);
  [Throws]
  void send(ArrayBufferView data);
};


partial interface DataChannel {
  readonly attribute DOMString protocol;
  readonly attribute boolean ordered;
  readonly attribute unsigned short id;

  readonly attribute unsigned short stream;
};
interface nsIVariant;

interface DataContainerEvent : Event {
  nsIVariant? getData(DOMString? key);
  [Throws]
  void setData(DOMString? key, any data);
};
[Constructor(DOMString type, optional DataErrorEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface DataErrorEvent : Event {
  readonly attribute DOMString? message;
};

dictionary DataErrorEventInit : EventInit {
  DOMString message = "";
};
[PrefControlled]
interface DelayNode : AudioNode {

    readonly attribute AudioParam delayTime;

};
interface MozObserver;

[HeaderFile="mozilla/dom/DesktopNotification.h"]
interface DesktopNotificationCenter {
  [Creator]
  DesktopNotification createNotification(DOMString title, DOMString description, optional DOMString iconURL = "");
};

interface DesktopNotification : EventTarget {
  [Throws]
  void show();

  [SetterThrows]
  attribute EventHandler onclick;

  [SetterThrows]
  attribute EventHandler onclose;
};
[Constructor(DOMString type, optional DeviceLightEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface DeviceLightEvent : Event {
  readonly attribute double value;
};

dictionary DeviceLightEventInit : EventInit {
  unrestricted double value = Infinity;
};
interface DeviceAcceleration;
interface DeviceRotationRate;

interface DeviceMotionEvent : Event {
  [Throws]
  void initDeviceMotionEvent(DOMString type, boolean canBubble, boolean cancelable, DeviceAcceleration? acceleration, DeviceAcceleration? accelerationIncludingGravity, DeviceRotationRate? rotationRate, double interval);

  readonly attribute DeviceAcceleration? acceleration;
  readonly attribute DeviceAcceleration? accelerationIncludingGravity;
  readonly attribute DeviceRotationRate? rotationRate;
  readonly attribute double interval;
};
[Constructor(DOMString type, optional DeviceOrientationEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface DeviceOrientationEvent : Event {
  readonly attribute double alpha;
  readonly attribute double beta;
  readonly attribute double gamma;
  readonly attribute boolean absolute;


  [Throws]
  void initDeviceOrientationEvent(DOMString type, boolean canBubble, boolean cancelable, double alpha, double beta, double gamma, boolean absolute);
};

dictionary DeviceOrientationEventInit : EventInit {
  double alpha = 0;
  double beta = 0;
  double gamma = 0;
  boolean absolute = false;
};
[Constructor(DOMString type, optional DeviceProximityEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface DeviceProximityEvent : Event {
  readonly attribute double value;
  readonly attribute double min;
  readonly attribute double max;
};

dictionary DeviceProximityEventInit : EventInit {
  unrestricted double value = Infinity;
  unrestricted double min = -Infinity;
  unrestricted double max = Infinity;
};
dictionary DeviceStorageEnumerationParameters {
  Date since;
};

interface DeviceStorage : EventTarget {
  [SetterThrows]
  attribute EventHandler onchange;

  [Throws]
  DOMRequest? add(Blob? aBlob);
  [Throws]
  DOMRequest? addNamed(Blob? aBlob, DOMString aName);

  [Throws]
  DOMRequest get(DOMString aName);
  [Throws]
  DOMRequest getEditable(DOMString aName);
  [Throws]
  DOMRequest delete(DOMString aName);

  [Throws]
  DOMCursor enumerate(optional DeviceStorageEnumerationParameters options);
  [Throws]
  DOMCursor enumerate(DOMString path, optional DeviceStorageEnumerationParameters options);
  [Throws]
  DOMCursor enumerateEditable(optional DeviceStorageEnumerationParameters options);
  [Throws]
  DOMCursor enumerateEditable(DOMString path, optional DeviceStorageEnumerationParameters options);

  [Throws]
  DOMRequest freeSpace();
  [Throws]
  DOMRequest usedSpace();
  [Throws]
  DOMRequest available();



  readonly attribute DOMString storageName;



  readonly attribute boolean default;
};
[Constructor(DOMString type, optional DeviceStorageChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface DeviceStorageChangeEvent : Event {
  readonly attribute DOMString? path;
  readonly attribute DOMString? reason;
};

dictionary DeviceStorageChangeEventInit : EventInit {
  DOMString path = "";
  DOMString reason = "";
};
interface StyleSheetList;
interface WindowProxy;
interface nsISupports;
interface URI;

enum VisibilityState {
	"hidden",
	"visible"
};


[Constructor]
interface Document : Node {
  [Throws]
  readonly attribute DOMImplementation implementation;
  readonly attribute DOMString URL;
  readonly attribute DOMString documentURI;
  readonly attribute DOMString compatMode;
  readonly attribute DOMString characterSet;
  readonly attribute DOMString contentType;

  readonly attribute DocumentType? doctype;
  readonly attribute Element? documentElement;
  HTMLCollection getElementsByTagName(DOMString localName);
  HTMLCollection getElementsByTagNameNS(DOMString? namespace, DOMString localName);
  HTMLCollection getElementsByClassName(DOMString classNames);
  Element? getElementById(DOMString elementId);

  [Creator, Throws]
  Element createElement(DOMString localName);
  [Creator, Throws]
  Element createElementNS(DOMString? namespace, DOMString qualifiedName);
  [Creator]
  DocumentFragment createDocumentFragment();
  [Creator]
  Text createTextNode(DOMString data);
  [Creator]
  Comment createComment(DOMString data);
  [Creator, Throws]
  ProcessingInstruction createProcessingInstruction(DOMString target, DOMString data);

  [Throws]
  Node importNode(Node node, optional boolean deep = true);
  [Throws]
  Node adoptNode(Node node);

  [Creator, Throws]
  Event createEvent(DOMString interface);

  [Creator, Throws]
  Range createRange();


  [Creator, Throws]
  NodeIterator createNodeIterator(Node root, optional unsigned long whatToShow = 0xFFFFFFFF, optional NodeFilter? filter = null);
  [Creator, Throws]
  TreeWalker createTreeWalker(Node root, optional unsigned long whatToShow = 0xFFFFFFFF, optional NodeFilter? filter = null);








  [Creator, Throws]
  CDATASection createCDATASection(DOMString data);
  [Creator, Throws]
  Attr createAttribute(DOMString name);
  [Creator, Throws]
  Attr createAttributeNS(DOMString? namespace, DOMString name);
  readonly attribute DOMString? inputEncoding;
};


partial interface Document {
  [PutForwards=href, Unforgeable]
  readonly attribute Location? location;

  readonly attribute DOMString referrer;

  readonly attribute DOMString lastModified;
  readonly attribute DOMString readyState;



           [SetterThrows]
           attribute DOMString title;
           attribute DOMString dir;
  readonly attribute WindowProxy? defaultView;
  readonly attribute Element? activeElement;
  [Throws]
  boolean hasFocus();
  [LenientThis, SetterThrows]
  attribute EventHandler onreadystatechange;


  [LenientThis, SetterThrows]
  attribute EventHandler onmouseenter;
  [LenientThis, SetterThrows]
  attribute EventHandler onmouseleave;
  [SetterThrows] 
  attribute EventHandler onwheel;
  [SetterThrows]
  attribute EventHandler oncopy;
  [SetterThrows]
  attribute EventHandler oncut;
  [SetterThrows]
  attribute EventHandler onpaste;
  [SetterThrows]
  attribute EventHandler onbeforescriptexecute;
  [SetterThrows]
  attribute EventHandler onafterscriptexecute;
  [ChromeOnly]
  readonly attribute boolean mozSyntheticDocument;
  readonly attribute Element? currentScript;
  void releaseCapture();
  void mozSetImageElement(DOMString aImageElementId, Element? aImageElement);

  [ChromeOnly]
  readonly attribute URI? documentURIObject;

};


partial interface Document {


  readonly attribute boolean mozFullScreenEnabled;
  [Throws]
  readonly attribute Element? mozFullScreenElement;




  readonly attribute boolean mozFullScreen;
  void mozCancelFullScreen();
};


partial interface Document {
    readonly attribute Element? mozPointerLockElement;
    void mozExitPointerLock ();
};


partial interface Document {
    [Throws, Pref="dom.webcomponents.enabled"]
    object register(DOMString name, optional ElementRegistrationOptions options);
};


partial interface Document {
  readonly attribute boolean hidden;
  readonly attribute boolean mozHidden;
  readonly attribute VisibilityState visibilityState;
  readonly attribute VisibilityState mozVisibilityState;
};


partial interface Document {
    [Constant]
    readonly attribute StyleSheetList styleSheets;
    attribute DOMString? selectedStyleSheetSet;
    readonly attribute DOMString? lastStyleSheetSet;
    readonly attribute DOMString? preferredStyleSheetSet;
    [Constant]
    readonly attribute DOMStringList styleSheetSets;
    void enableStyleSheetsForSet (DOMString? name);
};


partial interface Document {
    Element? elementFromPoint (float x, float y);

    CaretPosition? caretPositionFromPoint (float x, float y);
};


partial interface Document {
    [Pref="dom.undo_manager.enabled"]
    readonly attribute UndoManager? undoManager;
};


partial interface Document {
  [Throws]
  Element? querySelector(DOMString selectors);
  [Throws]
  NodeList querySelectorAll(DOMString selectors);



};


partial interface Document {


  NodeList? getAnonymousNodes(Element elt);
  Element? getAnonymousElementByAttribute(Element elt, DOMString attrName, DOMString attrValue);
  Element? getBindingParent(Node node);
  [Throws]
  void loadBindingDocument(DOMString documentURL);




  [Creator, Func="nsGenericHTMLElement::TouchEventsEnabled"]
  Touch createTouch(optional Window? view = null, optional EventTarget? target = null, optional long identifier = 0, optional long pageX = 0, optional long pageY = 0, optional long screenX = 0, optional long screenY = 0, optional long clientX = 0, optional long clientY = 0, optional long radiusX = 0, optional long radiusY = 0, optional float rotationAngle = 0, optional float force = 0);




  [Creator, Func="nsGenericHTMLElement::TouchEventsEnabled"]
  TouchList createTouchList(Touch touch, Touch... touches);



  [Creator, Func="nsGenericHTMLElement::TouchEventsEnabled"]
  TouchList createTouchList();
  [Creator, Func="nsGenericHTMLElement::TouchEventsEnabled"]
  TouchList createTouchList(sequence<Touch> touches);

  [ChromeOnly]
  attribute boolean styleSheetChangeEventsEnabled;

  [ChromeOnly, Throws]
  void obsoleteSheet(URI sheetURI);
  [ChromeOnly, Throws]
  void obsoleteSheet(DOMString sheetURI);
};



partial interface Document {
  [ChromeOnly]
  readonly attribute boolean isSrcdocDocument;
};

Document implements XPathEvaluator;
Document implements GlobalEventHandlers;
Document implements NodeEventHandlers;
Document implements TouchEventHandlers;
Document implements ParentNode;
[Constructor]
interface DocumentFragment : Node {
};


partial interface DocumentFragment {
  [Throws]
  Element? querySelector(DOMString selectors);
  [Throws]
  NodeList querySelectorAll(DOMString selectors);
};

DocumentFragment implements ParentNode;
interface DocumentType : Node {
  readonly attribute DOMString name;
  readonly attribute DOMString publicId;
  readonly attribute DOMString systemId;


  readonly attribute DOMString? internalSubset;
};

DocumentType implements ChildNode;
interface DOMCursor : DOMRequest {
  readonly attribute boolean done;
  [Throws]
  void continue();
};
[Constructor(DOMString name, optional DOMString message = "")]
interface DOMError {
  [Constant]
  readonly attribute DOMString name;

  [Constant]
  readonly attribute DOMString message;

  [ChromeOnly]
  void init(DOMString name, optional DOMString message = "");
};
interface DOMImplementation {
  boolean hasFeature(DOMString feature, [TreatNullAs=EmptyString] DOMString version);

  [Throws]
  DocumentType createDocumentType(DOMString qualifiedName, DOMString publicId, DOMString systemId);
  [Throws]
  Document createDocument(DOMString? namespace, [TreatNullAs=EmptyString] DOMString qualifiedName, DocumentType? doctype);
  [Throws]
  Document createHTMLDocument(optional DOMString title);
};
[JSImplementation="@mozilla.org/dom/mmi-error;1", Constructor(DOMString serviceCode, DOMString name, optional DOMString message = "", optional DOMString additionalInformation = "")]
interface DOMMMIError : DOMError {
  readonly attribute DOMString serviceCode;

  readonly attribute any additionalInformation;
};
interface Principal;
interface URI;
interface InputStream;

enum SupportedType {
  "text/html",
  "text/xml",
  "application/xml",
  "application/xhtml+xml",
  "image/svg+xml"
};


[Constructor, Constructor(Principal? prin, optional URI? documentURI = null, optional URI? baseURI = null)]
interface DOMParser {
  [Creator, Throws]
  Document parseFromString(DOMString str, SupportedType type);



  [Creator, Throws, ChromeOnly]
  Document parseFromBuffer(sequence<octet> buf, unsigned long bufLen, SupportedType type);

  [Creator, Throws, ChromeOnly]
  Document parseFromBuffer(Uint8Array buf, unsigned long bufLen, SupportedType type);
  [Creator, Throws, ChromeOnly]
  Document parseFromStream(InputStream stream, DOMString? charset, long contentLength, SupportedType type);
  [Throws, ChromeOnly]
  void init(optional Principal? principal = null, optional URI? documentURI = null, optional URI? baseURI = null);
};
interface Window;
interface nsISupports;

enum DOMRequestReadyState {
	"pending",
	"done"
};

interface DOMRequest : EventTarget {
  readonly attribute DOMRequestReadyState readyState;

  readonly attribute any result;
  readonly attribute nsISupports? error;

  [SetterThrows]
  attribute EventHandler onsuccess;
  [SetterThrows]
  attribute EventHandler onerror;
};
interface DOMSettableTokenList : DOMTokenList {
            [SetterThrows]
            attribute DOMString value;
};
[OverrideBuiltins]
interface DOMStringMap {
  getter DOMString (DOMString name);
  [Throws]
  setter creator void (DOMString name, DOMString value);
  deleter void (DOMString name);
};
interface DOMTokenList {
  readonly attribute unsigned long length;
  getter DOMString? item(unsigned long index);
  [Throws]
  boolean contains(DOMString token);
  [Throws]
  void add(DOMString token);
  [Throws]
  void remove(DOMString token);
  [Throws]
  boolean toggle(DOMString token, optional boolean force);
  stringifier DOMString ();
};
callback DOMTransactionCallback = void();

callback interface DOMTransaction {
  readonly attribute DOMString? label;
  readonly attribute DOMTransactionCallback? executeAutomatic;
  readonly attribute DOMTransactionCallback? execute;
  readonly attribute DOMTransactionCallback? undo;
  readonly attribute DOMTransactionCallback? redo;
};
[Constructor(DOMString type, optional DOMTransactionEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface DOMTransactionEvent : Event {
  [Throws]
  readonly attribute any transactions;

  [Throws]
  void initDOMTransactionEvent(DOMString type, boolean canBubble, boolean cancelable, any transactions);
};

dictionary DOMTransactionEventInit : EventInit {
  any transactions = null;
};
interface WindowProxy;
interface DataTransfer;

interface DragEvent : MouseEvent {
  readonly attribute DataTransfer? dataTransfer;

  [Throws]
  void initDragEvent(DOMString type, boolean canBubble, boolean cancelable, WindowProxy? aView, long aDetail, long aScreenX, long aScreenY, long aClientX, long aClientY, boolean aCtrlKey, boolean aAltKey, boolean aShiftKey, boolean aMetaKey, unsigned short aButton, EventTarget? aRelatedTarget, DataTransfer? aDataTransfer);
};
interface DummyInterface {
  readonly attribute OnErrorEventHandlerNonNull onErrorEventHandler;
  FilePropertyBag fileBag();
  InspectorRGBTriple rgbTriple();
  Function getFunction();
  void funcSocketsDict(optional SocketsDict arg);
  void funcHttpConnDict(optional HttpConnDict arg);
  void funcWebSocketDict(optional WebSocketDict arg);
  void funcDNSCacheDict(optional DNSCacheDict arg);
  void frameRequestCallback(FrameRequestCallback arg);
  void idbObjectStoreParams(optional IDBObjectStoreParameters arg);
  void CameraPictureOptions(optional CameraPictureOptions arg);
  void MmsParameters(optional MmsParameters arg);
  void MmsAttachment(optional MmsAttachment arg);
};

interface DummyInterfaceWorkers {
  BlobPropertyBag blobBag();
};
[PrefControlled]
interface DynamicsCompressorNode : AudioNode {

    readonly attribute AudioParam threshold;
    readonly attribute AudioParam knee;
    readonly attribute AudioParam ratio;
    readonly attribute AudioParam reduction;
    readonly attribute AudioParam attack;
    readonly attribute AudioParam release;

};
interface Element : Node {
  [Pure]
  readonly attribute DOMString tagName;

  [Pure]
           attribute DOMString id;
  [Constant]
  readonly attribute DOMTokenList? classList;

  [Constant]
  readonly attribute MozNamedAttrMap attributes;
  DOMString? getAttribute(DOMString name);
  DOMString? getAttributeNS(DOMString? namespace, DOMString localName);
  [Throws]
  void setAttribute(DOMString name, DOMString value);
  [Throws]
  void setAttributeNS(DOMString? namespace, DOMString name, DOMString value);
  [Throws]
  void removeAttribute(DOMString name);
  [Throws]
  void removeAttributeNS(DOMString? namespace, DOMString localName);
  boolean hasAttribute(DOMString name);
  boolean hasAttributeNS(DOMString? namespace, DOMString localName);

  HTMLCollection getElementsByTagName(DOMString localName);
  [Throws]
  HTMLCollection getElementsByTagNameNS(DOMString? namespace, DOMString localName);
  HTMLCollection getElementsByClassName(DOMString classNames);
  [ChromeOnly]
  readonly attribute float fontSizeInflation;



  [SetterThrows,LenientThis]
           attribute EventHandler onmouseenter;
  [SetterThrows,LenientThis]
           attribute EventHandler onmouseleave;
  [SetterThrows]
           attribute EventHandler onwheel;
  [Throws]
  boolean mozMatchesSelector(DOMString selector);
  void setCapture(optional boolean retargetToElement = false);
  void releaseCapture();
  void mozRequestFullScreen();
  void mozRequestPointerLock();


  Attr? getAttributeNode(DOMString name);
  [Throws]
  Attr? setAttributeNode(Attr newAttr);
  [Throws]
  Attr? removeAttributeNode(Attr oldAttr);
  Attr? getAttributeNodeNS(DOMString? namespaceURI, DOMString localName);
  [Throws]
  Attr? setAttributeNodeNS(Attr newAttr);
};


partial interface Element {
  ClientRectList getClientRects();
  ClientRect getBoundingClientRect();


  void scrollIntoView(optional boolean top = true);

           attribute long scrollTop;
           attribute long scrollLeft;
  readonly attribute long scrollWidth;
  readonly attribute long scrollHeight;

  readonly attribute long clientTop;
  readonly attribute long clientLeft;
  readonly attribute long clientWidth;
  readonly attribute long clientHeight;
  readonly attribute long scrollTopMax;
  readonly attribute long scrollLeftMax;
};


partial interface Element {
  [Pref="dom.undo_manager.enabled"]
  readonly attribute UndoManager? undoManager;
  [SetterThrows,Pref="dom.undo_manager.enabled"]
  attribute boolean undoScope;
};


partial interface Element {
  [Throws,TreatNullAs=EmptyString]
  attribute DOMString innerHTML;
  [Throws,TreatNullAs=EmptyString]
  attribute DOMString outerHTML;
  [Throws]
  void insertAdjacentHTML(DOMString position, DOMString text);
};


partial interface Element {
  [Throws]
  Element? querySelector(DOMString selectors);
  [Throws]
  NodeList querySelectorAll(DOMString selectors);
};

Element implements ChildNode;
Element implements ParentNode;
[Constructor(DOMString type, optional ElementReplaceEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface ElementReplaceEvent : Event {
  readonly attribute Element? upgrade;


  [Throws]
  void initElementReplaceEvent(DOMString type, boolean canBubble, boolean cancelable, Element? upgrade);
};

dictionary ElementReplaceEventInit : EventInit {
  Element? upgrade = null;
};
[Constructor(DOMString type, optional EventInit eventInitDict)]
interface Event {
  readonly attribute DOMString type;
  readonly attribute EventTarget? target;
  readonly attribute EventTarget? currentTarget;

  const unsigned short NONE = 0;
  const unsigned short CAPTURING_PHASE = 1;
  const unsigned short AT_TARGET = 2;
  const unsigned short BUBBLING_PHASE = 3;
  readonly attribute unsigned short eventPhase;

  void stopPropagation();
  void stopImmediatePropagation();

  readonly attribute boolean bubbles;
  readonly attribute boolean cancelable;
  void preventDefault();
  readonly attribute boolean defaultPrevented;

  readonly attribute boolean isTrusted;
  readonly attribute DOMTimeStamp timeStamp;

  [Throws]
  void initEvent(DOMString type, boolean bubbles, boolean cancelable);
};


partial interface Event {
  const long ALT_MASK = 0x00000001;
  const long CONTROL_MASK = 0x00000002;
  const long SHIFT_MASK = 0x00000004;
  const long META_MASK = 0x00000008;

  readonly attribute EventTarget? originalTarget;
  readonly attribute EventTarget? explicitOriginalTarget;
  [ChromeOnly]
  readonly attribute boolean multipleActionsPrevented;

  boolean getPreventDefault();
};

dictionary EventInit {
  boolean bubbles = false;
  boolean cancelable = false;
};
[TreatNonCallableAsNull]
callback EventHandlerNonNull = any (Event event);
typedef EventHandlerNonNull? EventHandler;

[TreatNonCallableAsNull]
callback BeforeUnloadEventHandlerNonNull = DOMString? (Event event);
typedef BeforeUnloadEventHandlerNonNull? BeforeUnloadEventHandler;

[TreatNonCallableAsNull]
callback OnErrorEventHandlerNonNull = boolean ((Event or DOMString) event, optional DOMString source, optional unsigned long lineno, optional unsigned long column);
typedef OnErrorEventHandlerNonNull? OnErrorEventHandler;

[NoInterfaceObject]
interface GlobalEventHandlers {
           [SetterThrows]
           attribute EventHandler onabort;


           [SetterThrows]
           attribute EventHandler oncanplay;
           [SetterThrows]
           attribute EventHandler oncanplaythrough;
           [SetterThrows]
           attribute EventHandler onchange;
           [SetterThrows]
           attribute EventHandler onclick;


           [SetterThrows]
           attribute EventHandler oncontextmenu;


           [SetterThrows]
           attribute EventHandler ondblclick;
           [SetterThrows]
           attribute EventHandler ondrag;
           [SetterThrows]
           attribute EventHandler ondragend;
           [SetterThrows]
           attribute EventHandler ondragenter;
           [SetterThrows]
           attribute EventHandler ondragleave;
           [SetterThrows]
           attribute EventHandler ondragover;
           [SetterThrows]
           attribute EventHandler ondragstart;
           [SetterThrows]
           attribute EventHandler ondrop;
           [SetterThrows]
           attribute EventHandler ondurationchange;
           [SetterThrows]
           attribute EventHandler onemptied;
           [SetterThrows]
           attribute EventHandler onended;
           [SetterThrows]
           attribute EventHandler oninput;
           [SetterThrows]
           attribute EventHandler oninvalid;
           [SetterThrows]
           attribute EventHandler onkeydown;
           [SetterThrows]
           attribute EventHandler onkeypress;
           [SetterThrows]
           attribute EventHandler onkeyup;
           [SetterThrows]
           attribute EventHandler onloadeddata;
           [SetterThrows]
           attribute EventHandler onloadedmetadata;
           [SetterThrows]
           attribute EventHandler onloadstart;
           [SetterThrows]
           attribute EventHandler onmousedown;
           [SetterThrows]
           attribute EventHandler onmousemove;
           [SetterThrows]
           attribute EventHandler onmouseout;
           [SetterThrows]
           attribute EventHandler onmouseover;
           [SetterThrows]
           attribute EventHandler onmouseup;


           [SetterThrows]
           attribute EventHandler onpause;
           [SetterThrows]
           attribute EventHandler onplay;
           [SetterThrows]
           attribute EventHandler onplaying;
           [SetterThrows]
           attribute EventHandler onprogress;
           [SetterThrows]
           attribute EventHandler onratechange;
           [SetterThrows]
           attribute EventHandler onreset;
           [SetterThrows]
           attribute EventHandler onseeked;
           [SetterThrows]
           attribute EventHandler onseeking;
           [SetterThrows]
           attribute EventHandler onselect;
           [SetterThrows]
           attribute EventHandler onshow;


           [SetterThrows]
           attribute EventHandler onstalled;
           [SetterThrows]
           attribute EventHandler onsubmit;
           [SetterThrows]
           attribute EventHandler onsuspend;
           [SetterThrows]
           attribute EventHandler ontimeupdate;
           [SetterThrows]
           attribute EventHandler onvolumechange;
           [SetterThrows]
           attribute EventHandler onwaiting;


           [SetterThrows]
           attribute EventHandler onmozfullscreenchange;
           [SetterThrows]
           attribute EventHandler onmozfullscreenerror;
           [SetterThrows]
           attribute EventHandler onmozpointerlockchange;
           [SetterThrows]
           attribute EventHandler onmozpointerlockerror;
};

[NoInterfaceObject]
interface NodeEventHandlers {
           [SetterThrows]
           attribute EventHandler onblur;


           [SetterThrows]
           attribute EventHandler onerror;
           [SetterThrows]
           attribute EventHandler onfocus;
           [SetterThrows]
           attribute EventHandler onload;
           [SetterThrows]
           attribute EventHandler onscroll;
};

[NoInterfaceObject]
interface WindowEventHandlers {
           [SetterThrows]
           attribute EventHandler onafterprint;
           [SetterThrows]
           attribute EventHandler onbeforeprint;
           [SetterThrows]
           attribute BeforeUnloadEventHandler onbeforeunload;








           [SetterThrows]
           attribute EventHandler onhashchange;
           [SetterThrows]
           attribute EventHandler onmessage;
           [SetterThrows]
           attribute EventHandler onoffline;
           [SetterThrows]
           attribute EventHandler ononline;
           [SetterThrows]
           attribute EventHandler onpagehide;
           [SetterThrows]
           attribute EventHandler onpageshow;
           [SetterThrows]
           attribute EventHandler onpopstate;
           [SetterThrows]
           attribute EventHandler onresize;


           [SetterThrows]
           attribute EventHandler onunload;
};
callback interface EventListener {
  void handleEvent(Event event);
};
[Constructor(DOMString url, optional EventSourceInit eventSourceInitDict), PrefControlled]
interface EventSource : EventTarget {
  [Constant]
  readonly attribute DOMString url;
  [Constant]
  readonly attribute boolean withCredentials;


  const unsigned short CONNECTING = 0;
  const unsigned short OPEN = 1;
  const unsigned short CLOSED = 2;
  readonly attribute unsigned short readyState;


  [SetterThrows]
           attribute EventHandler onopen;
  [SetterThrows]
           attribute EventHandler onmessage;
  [SetterThrows]
           attribute EventHandler onerror;
  void close();
};

dictionary EventSourceInit {
  boolean withCredentials = false;
};
interface EventTarget {
  [Throws]
  void addEventListener(DOMString type, EventListener? listener, optional boolean capture = false, optional boolean? wantsUntrusted = null);
  [Throws]
  void removeEventListener(DOMString type, EventListener? listener, optional boolean capture = false);
  [Throws]
  boolean dispatchEvent(Event event);
};



partial interface EventTarget {
  [ChromeOnly, Throws]
  void setEventHandler(DOMString type, EventHandler handler);

  [ChromeOnly]
  EventHandler getEventHandler(DOMString type);
};




partial interface EventTarget {
  [ChromeOnly]
  readonly attribute WindowProxy? ownerGlobal;
};
dictionary FilePropertyBag : BlobPropertyBag {
  DOMString name = "";
};
interface LockedFile;

interface FileHandle : EventTarget {
  readonly attribute DOMString name;
  readonly attribute DOMString type;

  [Throws]
  LockedFile open(optional FileMode mode = "readonly");

  [Throws]
  DOMRequest getFile();

  [SetterThrows]
  attribute EventHandler onabort;
  [SetterThrows]
  attribute EventHandler onerror;
};
interface File;

interface FileList {
  getter File? item(unsigned long index);
  readonly attribute unsigned long length;
};
enum FileMode {
	"readonly",
	"readwrite"
};
[Constructor]
interface FileReader : EventTarget {

  [Throws]
  void readAsArrayBuffer(Blob blob);
  [Throws]
  void readAsText(Blob blob, optional DOMString label = "");
  [Throws]
  void readAsDataURL(Blob blob);

  [Throws]
  void abort();


  const unsigned short EMPTY = 0;
  const unsigned short LOADING = 1;
  const unsigned short DONE = 2;


  readonly attribute unsigned short readyState;



  [Throws]
  readonly attribute any result;

  readonly attribute DOMError? error;


  [SetterThrows]
  attribute EventHandler onloadstart;
  [SetterThrows]
  attribute EventHandler onprogress;
  [SetterThrows]
  attribute EventHandler onload;
  [SetterThrows]
  attribute EventHandler onabort;
  [SetterThrows]
  attribute EventHandler onerror;
  [SetterThrows]
  attribute EventHandler onloadend;
};


partial interface FileReader {
  [Throws]
  void readAsBinaryString(Blob filedata);
};
interface Blob;

[Constructor]
interface FileReaderSync {



  [Throws]
  ArrayBuffer readAsArrayBuffer(Blob blob);
  [Throws]
  DOMString readAsBinaryString(Blob blob);
  [Throws]
  DOMString readAsText(Blob blob, optional DOMString encoding);
  [Throws]
  DOMString readAsDataURL(Blob blob);
};
interface LockedFile;

interface FileRequest : DOMRequest {
  readonly attribute LockedFile? lockedFile;

  [SetterThrows]
  attribute EventHandler onprogress;
};
[Constructor(DOMString typeArg, optional FocusEventInit focusEventInitDict)]
interface FocusEvent : UIEvent {

  readonly attribute EventTarget? relatedTarget;
};

dictionary FocusEventInit : UIEventInit {
    EventTarget? relatedTarget = null;
};
[Constructor(optional HTMLFormElement form)]
interface FormData {
  void append(DOMString name, Blob value, optional DOMString filename);
  void append(DOMString name, DOMString value);
};
callback Function = any(any... arguments);
[PrefControlled]
interface GainNode : AudioNode {

    readonly attribute AudioParam gain;

};
interface nsIVariant;

[Pref="dom.gamepad.enabled"]
interface Gamepad {
  readonly attribute DOMString id;
  readonly attribute unsigned long index;
  readonly attribute DOMString mapping;
  readonly attribute boolean connected;
  [Throws]
  readonly attribute nsIVariant buttons;
  [Throws]
  readonly attribute nsIVariant axes;
};
[Pref="dom.gamepad.non_standard_events.enabled", Constructor(DOMString type, optional GamepadAxisMoveEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface GamepadAxisMoveEvent : GamepadEvent {
  readonly attribute unsigned long axis;
  readonly attribute double value;
};

dictionary GamepadAxisMoveEventInit : GamepadEventInit {
  unsigned long axis = 0;
  double value = 0;
};
[Pref="dom.gamepad.non_standard_events.enabled", Constructor(DOMString type, optional GamepadButtonEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface GamepadButtonEvent : GamepadEvent {
  readonly attribute unsigned long button;
};

dictionary GamepadButtonEventInit : GamepadEventInit {
  unsigned long button = 0;
};
[Pref="dom.gamepad.enabled", Constructor(DOMString type, optional GamepadEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface GamepadEvent : Event {
  readonly attribute Gamepad? gamepad;
};

dictionary GamepadEventInit : EventInit {
  Gamepad? gamepad = null;
};
dictionary PositionOptions {
  boolean enableHighAccuracy = false;
  long timeout = 0x7fffffff;
  long maximumAge = 30000;
};

[NoInterfaceObject]
interface Geolocation {
  [Throws]
  void getCurrentPosition(PositionCallback successCallback, optional PositionErrorCallback? errorCallback = null, optional PositionOptions options);

  [Throws]
  long watchPosition(PositionCallback successCallback, optional PositionErrorCallback? errorCallback = null, optional PositionOptions options);

  void clearWatch(long watchId);
};

callback PositionCallback = void (Position position);

callback PositionErrorCallback = void (PositionError positionError);
[Constructor(DOMString type, optional HashChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface HashChangeEvent : Event {
  readonly attribute DOMString? oldURL;
  readonly attribute DOMString? newURL;


  [Throws]
  void initHashChangeEvent(DOMString type, boolean canBubble, boolean cancelable, DOMString? oldURL, DOMString? newURL);
};

dictionary HashChangeEventInit : EventInit {
  DOMString oldURL = "";
  DOMString newURL = "";
};
interface HTMLAnchorElement : HTMLElement {



  stringifier;
           [SetterThrows]
           attribute DOMString href;
           [SetterThrows]
           attribute DOMString target;
           [SetterThrows]
           attribute DOMString download;
           [SetterThrows]
           attribute DOMString ping;
           [SetterThrows]
           attribute DOMString rel;


           [SetterThrows]
           attribute DOMString hreflang;
           [SetterThrows]
           attribute DOMString type;

           [SetterThrows]
           attribute DOMString text;
};
HTMLAnchorElement implements URLUtils;


partial interface HTMLAnchorElement {
           [SetterThrows]
           attribute DOMString coords;
           [SetterThrows]
           attribute DOMString charset;
           [SetterThrows]
           attribute DOMString name;
           [SetterThrows]
           attribute DOMString rev;
           [SetterThrows]
           attribute DOMString shape;
};
[NeedNewResolve]
interface HTMLAppletElement : HTMLElement {
  [Pure, SetterThrows]
           attribute DOMString align;
  [Pure, SetterThrows]
           attribute DOMString alt;
  [Pure, SetterThrows]
           attribute DOMString archive;
  [Pure, SetterThrows]
           attribute DOMString code;
  [Pure, SetterThrows]
           attribute DOMString codeBase;
  [Pure, SetterThrows]
           attribute DOMString height;
  [Pure, SetterThrows]
           attribute unsigned long hspace;
  [Pure, SetterThrows]
           attribute DOMString name;
  [Pure, SetterThrows]
           attribute DOMString _object;
  [Pure, SetterThrows]
           attribute unsigned long vspace;
  [Pure, SetterThrows]
           attribute DOMString width;
};

HTMLAppletElement implements MozImageLoadingContent;
HTMLAppletElement implements MozFrameLoaderOwner;
HTMLAppletElement implements MozObjectLoadingContent;
interface HTMLAreaElement : HTMLElement {
           [SetterThrows]
           attribute DOMString alt;
           [SetterThrows]
           attribute DOMString coords;
           [SetterThrows]
           attribute DOMString shape;



  stringifier;
           [SetterThrows]
           attribute DOMString href;
           [SetterThrows]
           attribute DOMString target;
           [SetterThrows]
           attribute DOMString download;
           [SetterThrows]
           attribute DOMString ping;










};
HTMLAreaElement implements URLUtils;


partial interface HTMLAreaElement {
           [SetterThrows]
           attribute boolean noHref;
};
[NamedConstructor=Audio(optional DOMString src)]
interface HTMLAudioElement : HTMLMediaElement {
};

partial interface HTMLAudioElement {

  [Pref="media.audio_data.enabled", Throws]
  void mozSetup(unsigned long channels, unsigned long rate);


  [Pref="media.audio_data.enabled", Throws]
  unsigned long mozWriteAudio(Float32Array data);
  [Pref="media.audio_data.enabled", Throws]
  unsigned long mozWriteAudio(sequence<unrestricted float> data);



  [Pref="media.audio_data.enabled", Throws]
  unsigned long long mozCurrentSampleOffset();
};
interface HTMLBaseElement : HTMLElement {
           [SetterThrows, Pure]
           attribute DOMString href;
           [SetterThrows, Pure]
           attribute DOMString target;
};
interface HTMLBodyElement : HTMLElement {
};

partial interface HTMLBodyElement {
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString text;
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString link;
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString vLink;
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString aLink;
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString bgColor;
  [SetterThrows]
  attribute DOMString background;
};

HTMLBodyElement implements WindowEventHandlers;
interface HTMLBRElement : HTMLElement {
};


partial interface HTMLBRElement {
             [SetterThrows]
             attribute DOMString clear;
};
interface HTMLButtonElement : HTMLElement {
  [SetterThrows, Pure]
           attribute boolean autofocus;
  [SetterThrows, Pure]
           attribute boolean disabled;
  [Pure]
  readonly attribute HTMLFormElement? form;
  [SetterThrows, Pure]
           attribute DOMString formAction;
  [SetterThrows, Pure]
           attribute DOMString formEnctype;
  [SetterThrows, Pure]
           attribute DOMString formMethod;
  [SetterThrows, Pure]
           attribute boolean formNoValidate;
  [SetterThrows, Pure]
           attribute DOMString formTarget;
  [SetterThrows, Pure]
           attribute DOMString name;
  [SetterThrows, Pure]
           attribute DOMString type;
  [SetterThrows, Pure]
           attribute DOMString value;



  readonly attribute boolean willValidate;
  readonly attribute ValidityState validity;
  readonly attribute DOMString validationMessage;
  boolean checkValidity();
  void setCustomValidity(DOMString error);



};
interface Blob;
interface FileCallback;
interface nsIInputStreamCallback;
interface nsISupports;
interface PrintCallback;
interface Variant;

interface HTMLCanvasElement : HTMLElement {
  [Pure, SetterThrows]
           attribute unsigned long width;
  [Pure, SetterThrows]
           attribute unsigned long height;

  [Throws]
  nsISupports? getContext(DOMString contextId, optional any contextOptions = null);

  [Throws]
  DOMString toDataURL(optional DOMString type = "", optional any encoderOptions);
  [Throws]
  void toBlob(FileCallback _callback, optional DOMString type = "", optional any encoderOptions);
};


partial interface HTMLCanvasElement {
  [Pure, SetterThrows]
           attribute boolean mozOpaque;
  [Throws]
  File mozGetAsFile(DOMString name, optional DOMString? type = null);
  [ChromeOnly, Throws]
  nsISupports? MozGetIPCContext(DOMString contextId);
  [ChromeOnly]
  void mozFetchAsStream(nsIInputStreamCallback callback, optional DOMString? type = null);
           attribute PrintCallback? mozPrintCallback;
};
interface HTMLCollection {
  readonly attribute unsigned long length;
  getter Element? item(unsigned long index);
  [Throws]
  getter object? namedItem(DOMString name);
};
interface HTMLDataElement : HTMLElement {
           [SetterThrows]
           attribute DOMString value;
};
interface HTMLDataListElement : HTMLElement {
  readonly attribute HTMLCollection options;
};
interface HTMLDirectoryElement : HTMLElement {
           [SetterThrows, Pure]
           attribute boolean compact;
};
interface HTMLDivElement : HTMLElement {
};

partial interface HTMLDivElement {
  [SetterThrows]
           attribute DOMString align;
};
interface HTMLDListElement : HTMLElement {
};


partial interface HTMLDListElement {
           [SetterThrows]
           attribute boolean compact;
};
interface Selection;

[OverrideBuiltins]
interface HTMLDocument : Document {
           [Throws]
           attribute DOMString? domain;
           [Throws]
           attribute DOMString cookie;

  [Throws]
  getter object (DOMString name);
           [SetterThrows]
           attribute HTMLElement? body;
  readonly attribute HTMLHeadElement? head;
  readonly attribute HTMLCollection images;
  readonly attribute HTMLCollection embeds;
  readonly attribute HTMLCollection plugins;
  readonly attribute HTMLCollection links;
  readonly attribute HTMLCollection forms;
  readonly attribute HTMLCollection scripts;
  NodeList getElementsByName(DOMString elementName);
  NodeList getItems(optional DOMString typeNames = "");


  [Throws]
  Document open(optional DOMString type = "text/html", optional DOMString replace = "");
  [Throws]
  WindowProxy open(DOMString url, DOMString name, DOMString features, optional boolean replace = false);
  [Throws]
  void close();
  [Throws]
  void write(DOMString... text);
  [Throws]
  void writeln(DOMString... text);

           [SetterThrows]
           attribute DOMString designMode;
  [Throws]
  boolean execCommand(DOMString commandId, optional boolean showUI = false, optional DOMString value = "");
  [Throws]
  boolean queryCommandEnabled(DOMString commandId);
  [Throws]
  boolean queryCommandIndeterm(DOMString commandId);
  [Throws]
  boolean queryCommandState(DOMString commandId);
  boolean queryCommandSupported(DOMString commandId);
  [Throws]
  DOMString queryCommandValue(DOMString commandId);

  [TreatNullAs=EmptyString]
  attribute DOMString fgColor;
  [TreatNullAs=EmptyString]
  attribute DOMString linkColor;
  [TreatNullAs=EmptyString]
  attribute DOMString vlinkColor;
  [TreatNullAs=EmptyString]
  attribute DOMString alinkColor;
  [TreatNullAs=EmptyString]
  attribute DOMString bgColor;

  readonly attribute HTMLCollection anchors;
  readonly attribute HTMLCollection applets;

  void clear();

  [Throws]
  readonly attribute object all;


  [Throws]
  Selection getSelection();
};
interface HTMLElement : Element {

           attribute DOMString title;
           attribute DOMString lang;

  [SetterThrows, Pure]
           attribute DOMString dir;
  [Constant]
  readonly attribute DOMStringMap dataset;


  [SetterThrows, Pure]
           attribute boolean itemScope;
  [PutForwards=value,Constant]
  readonly attribute DOMSettableTokenList itemType;
  [SetterThrows, Pure]
           attribute DOMString itemId;
  [PutForwards=value,Constant]
  readonly attribute DOMSettableTokenList itemRef;
  [PutForwards=value,Constant]
  readonly attribute DOMSettableTokenList itemProp;
  [Constant]
  readonly attribute HTMLPropertiesCollection properties;
  [Throws]
           attribute any itemValue;


  [SetterThrows, Pure]
           attribute boolean hidden;
  void click();
  [SetterThrows, Pure]
           attribute long tabIndex;
  [Throws]
  void focus();
  [Throws]
  void blur();
  [SetterThrows, Pure]
           attribute DOMString accessKey;
  [Pure]
  readonly attribute DOMString accessKeyLabel;
  [SetterThrows, Pure]
           attribute boolean draggable;

  [SetterThrows, Pure]
           attribute DOMString contentEditable;
  [Pure]
  readonly attribute boolean isContentEditable;
  [Pure]
  readonly attribute HTMLMenuElement? contextMenu;


  [SetterThrows, Pure]
           attribute boolean spellcheck;










  [PutForwards=cssText, Constant]
  readonly attribute CSSStyleDeclaration style;



           attribute DOMString className;

  [SetterThrows]
           attribute EventHandler oncopy;
  [SetterThrows]
           attribute EventHandler oncut;
  [SetterThrows]
           attribute EventHandler onpaste;
};


partial interface HTMLElement {

  readonly attribute Element? offsetParent;
  readonly attribute long offsetTop;
  readonly attribute long offsetLeft;
  readonly attribute long offsetWidth;
  readonly attribute long offsetHeight;
};

[NoInterfaceObject]
interface TouchEventHandlers {
  [SetterThrows,Func="nsGenericHTMLElement::TouchEventsEnabled"]
           attribute EventHandler ontouchstart;
  [SetterThrows,Func="nsGenericHTMLElement::TouchEventsEnabled"]
           attribute EventHandler ontouchend;
  [SetterThrows,Func="nsGenericHTMLElement::TouchEventsEnabled"]
           attribute EventHandler ontouchmove;
  [SetterThrows,Func="nsGenericHTMLElement::TouchEventsEnabled"]
           attribute EventHandler ontouchenter;
  [SetterThrows,Func="nsGenericHTMLElement::TouchEventsEnabled"]
           attribute EventHandler ontouchleave;
  [SetterThrows,Func="nsGenericHTMLElement::TouchEventsEnabled"]
           attribute EventHandler ontouchcancel;
};

HTMLElement implements GlobalEventHandlers;
HTMLElement implements NodeEventHandlers;
HTMLElement implements TouchEventHandlers;

interface HTMLUnknownElement : HTMLElement {
};
[NeedNewResolve]
interface HTMLEmbedElement : HTMLElement {
  [Pure, SetterThrows]
           attribute DOMString src;
  [Pure, SetterThrows]
           attribute DOMString type;
  [Pure, SetterThrows]
           attribute DOMString width;
  [Pure, SetterThrows]
           attribute DOMString height;
  [Throws]
  legacycaller any (any... arguments);
};


partial interface HTMLEmbedElement {
  [Pure, SetterThrows]
           attribute DOMString align;
  [Pure, SetterThrows]
           attribute DOMString name;
};

partial interface HTMLEmbedElement {

  Document? getSVGDocument();
};

HTMLEmbedElement implements MozImageLoadingContent;
HTMLEmbedElement implements MozFrameLoaderOwner;
HTMLEmbedElement implements MozObjectLoadingContent;
interface HTMLFieldSetElement : HTMLElement {
  [SetterThrows]
           attribute boolean disabled;
  readonly attribute HTMLFormElement? form;
  [SetterThrows]
           attribute DOMString name;

  readonly attribute DOMString type;

  readonly attribute HTMLCollection elements;

  readonly attribute boolean willValidate;
  readonly attribute ValidityState validity;
  readonly attribute DOMString validationMessage;

  boolean checkValidity();

  void setCustomValidity(DOMString error);
};
interface HTMLFontElement : HTMLElement {
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString color;
  [SetterThrows]
  attribute DOMString face;
  [SetterThrows]
  attribute DOMString size;
};
[OverrideBuiltins]
interface HTMLFormElement : HTMLElement {
           [Pure, SetterThrows]
           attribute DOMString acceptCharset;
           [Pure, SetterThrows]
           attribute DOMString action;
           [Pure, SetterThrows]
           attribute DOMString autocomplete;
           [Pure, SetterThrows]
           attribute DOMString enctype;
           [Pure, SetterThrows]
           attribute DOMString encoding;
           [Pure, SetterThrows]
           attribute DOMString method;
           [Pure, SetterThrows]
           attribute DOMString name;
           [Pure, SetterThrows]
           attribute boolean noValidate;
           [Pure, SetterThrows]
           attribute DOMString target;

  [Constant]
  readonly attribute HTMLCollection elements;
  [Pure]
  readonly attribute long length;

  getter Element (unsigned long index);

  getter nsISupports (DOMString name);

  [Throws]
  void submit();
  void reset();
  boolean checkValidity();
};
interface HTMLFrameElement : HTMLElement {
           [SetterThrows]
           attribute DOMString name;
           [SetterThrows]
           attribute DOMString scrolling;
           [SetterThrows]
           attribute DOMString src;
           [SetterThrows]
           attribute DOMString frameBorder;
           [SetterThrows]
           attribute DOMString longDesc;
           [SetterThrows]
           attribute boolean noResize;
  readonly attribute Document? contentDocument;
  readonly attribute WindowProxy? contentWindow;

  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString marginHeight;
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString marginWidth;
};

HTMLFrameElement implements MozFrameLoaderOwner;
interface HTMLFrameSetElement : HTMLElement {
  [SetterThrows]
  attribute DOMString cols;
  [SetterThrows]
  attribute DOMString rows;
};

HTMLFrameSetElement implements WindowEventHandlers;
interface HTMLHeadElement : HTMLElement {
};
interface HTMLHeadingElement : HTMLElement {
};


partial interface HTMLHeadingElement {
           attribute DOMString align;
};
interface HTMLHRElement : HTMLElement {
};


partial interface HTMLHRElement {
           [SetterThrows]
           attribute DOMString align;
           [SetterThrows]
           attribute DOMString color;
           [SetterThrows]
           attribute boolean noShade;
           [SetterThrows]
           attribute DOMString size;
           [SetterThrows]
           attribute DOMString width;
};
interface HTMLHtmlElement : HTMLElement {
};


partial interface HTMLHtmlElement {
           [SetterThrows, Pure]
           attribute DOMString version;
};
interface HTMLIFrameElement : HTMLElement {
  [SetterThrows, Pure]
           attribute DOMString src;
  [SetterThrows, Pure]
           attribute DOMString srcdoc;
  [SetterThrows, Pure]
           attribute DOMString name;


  attribute DOMString sandbox;

  [SetterThrows, Pure]
           attribute boolean allowFullscreen;
  [SetterThrows, Pure]
           attribute DOMString width;
  [SetterThrows, Pure]
           attribute DOMString height;
  readonly attribute Document? contentDocument;
  readonly attribute WindowProxy? contentWindow;
};


partial interface HTMLIFrameElement {
  [SetterThrows, Pure]
           attribute DOMString align;
  [SetterThrows, Pure]
           attribute DOMString scrolling;
  [SetterThrows, Pure]
           attribute DOMString frameBorder;
  [SetterThrows, Pure]
           attribute DOMString longDesc;

  [TreatNullAs=EmptyString,SetterThrows,Pure]
  attribute DOMString marginHeight;
  [TreatNullAs=EmptyString,SetterThrows,Pure]
  attribute DOMString marginWidth;
};

partial interface HTMLIFrameElement {

  Document? getSVGDocument();
};

partial interface HTMLIFrameElement {

  [ChromeOnly,SetterThrows]
           attribute boolean mozbrowser;
};

partial interface HTMLIFrameElement {

  [ChromeOnly]
  readonly attribute DOMString appManifestURL;
};

HTMLIFrameElement implements MozFrameLoaderOwner;
interface imgINotificationObserver;
interface imgIRequest;
interface URI;
interface MozChannel;
interface nsIStreamListener;

[NamedConstructor=Image(optional unsigned long width, optional unsigned long height)]
interface HTMLImageElement : HTMLElement {
           [SetterThrows]
           attribute DOMString alt;
           [SetterThrows]
           attribute DOMString src;

           [SetterThrows]
           attribute DOMString crossOrigin;
           [SetterThrows]
           attribute DOMString useMap;
           [SetterThrows]
           attribute boolean isMap;
           [SetterThrows]
           attribute unsigned long width;
           [SetterThrows]
           attribute unsigned long height;
  readonly attribute unsigned long naturalWidth;
  readonly attribute unsigned long naturalHeight;
  readonly attribute boolean complete;
};


partial interface HTMLImageElement {
           [SetterThrows]
           attribute DOMString name;
           [SetterThrows]
           attribute DOMString align;
           [SetterThrows]
           attribute unsigned long hspace;
           [SetterThrows]
           attribute unsigned long vspace;
           [SetterThrows]
           attribute DOMString longDesc;

  [TreatNullAs=EmptyString,SetterThrows]
  attribute DOMString border;
};


partial interface HTMLImageElement {
           attribute DOMString lowsrc;



  readonly attribute long x;
  readonly attribute long y;
};

[NoInterfaceObject]
interface MozImageLoadingContent {


  [ChromeOnly]
  const long UNKNOWN_REQUEST = -1;
  [ChromeOnly]
  const long CURRENT_REQUEST = 0;
  [ChromeOnly]
  const long PENDING_REQUEST = 1;

  [ChromeOnly]
  attribute boolean loadingEnabled;
  [ChromeOnly]
  readonly attribute short imageBlockingStatus;
  [ChromeOnly]
  void addObserver(imgINotificationObserver aObserver);
  [ChromeOnly]
  void removeObserver(imgINotificationObserver aObserver);
  [ChromeOnly,Throws]
  imgIRequest? getRequest(long aRequestType);
  [ChromeOnly,Throws]
  long getRequestType(imgIRequest aRequest);
  [ChromeOnly,Throws]
  readonly attribute URI? currentURI;
  [ChromeOnly,Throws]
  nsIStreamListener? loadImageWithChannel(MozChannel aChannel);
  [ChromeOnly,Throws]
  void forceReload();
  [ChromeOnly]
  void forceImageState(boolean aForce, unsigned long long aState);
};

HTMLImageElement implements MozImageLoadingContent;
interface nsIControllers;

interface HTMLInputElement : HTMLElement {
  [Pure, SetterThrows]
           attribute DOMString accept;
  [Pure, SetterThrows]
           attribute DOMString alt;
  [Pure, SetterThrows]
           attribute DOMString autocomplete;
  [Pure, SetterThrows]
           attribute boolean autofocus;
  [Pure, SetterThrows]
           attribute boolean defaultChecked;
  [Pure]
           attribute boolean checked;

  [Pure, SetterThrows]
           attribute boolean disabled;
  readonly attribute HTMLFormElement? form;
  [Pure]
  readonly attribute FileList? files;
  [Pure, SetterThrows]
           attribute DOMString formAction;
  [Pure, SetterThrows]
           attribute DOMString formEnctype;
  [Pure, SetterThrows]
           attribute DOMString formMethod;
  [Pure, SetterThrows]
           attribute boolean formNoValidate;
  [Pure, SetterThrows]
           attribute DOMString formTarget;
  [Pure, SetterThrows]
           attribute unsigned long height;
  [Pure]
           attribute boolean indeterminate;
  [Pure, SetterThrows, Pref="dom.forms.inputmode"]
           attribute DOMString inputMode;
  [Pure]
  readonly attribute HTMLElement? list;
  [Pure, SetterThrows]
           attribute DOMString max;
  [Pure, SetterThrows]
           attribute long maxLength;
  [Pure, SetterThrows]
           attribute DOMString min;
  [Pure, SetterThrows]
           attribute boolean multiple;
  [Pure, SetterThrows]
           attribute DOMString name;
  [Pure, SetterThrows]
           attribute DOMString pattern;
  [Pure, SetterThrows]
           attribute DOMString placeholder;
  [Pure, SetterThrows]
           attribute boolean readOnly;
  [Pure, SetterThrows]
           attribute boolean required;
  [Pure, SetterThrows]
           attribute unsigned long size;
  [Pure, SetterThrows]
           attribute DOMString src;
  [Pure, SetterThrows]
           attribute DOMString step;
  [Pure, SetterThrows]
           attribute DOMString type;
  [Pure, SetterThrows]
           attribute DOMString defaultValue;
  [Pure, TreatNullAs=EmptyString, SetterThrows]
           attribute DOMString value;
  [Throws, Pref="dom.experimental_forms"]
           attribute Date? valueAsDate;
  [Pure, SetterThrows]
           attribute unrestricted double valueAsNumber;
           attribute unsigned long width;

  [Throws]
  void stepUp(optional long n = 1);
  [Throws]
  void stepDown(optional long n = 1);

  [Pure]
  readonly attribute boolean willValidate;
  [Pure]
  readonly attribute ValidityState validity;
  [GetterThrows]
  readonly attribute DOMString validationMessage;
  boolean checkValidity();
  void setCustomValidity(DOMString error);



  void select();

  [Throws]

           attribute long selectionStart;
  [Throws]
           attribute long selectionEnd;
  [Throws]
           attribute DOMString selectionDirection;




};

partial interface HTMLInputElement {
  [Pure, SetterThrows]
           attribute DOMString align;
  [Pure, SetterThrows]
           attribute DOMString useMap;
};



partial interface HTMLInputElement {
  [Throws]
  void setSelectionRange(long start, long end, optional DOMString direction);

  [GetterThrows]
  readonly attribute nsIControllers controllers;
  [GetterThrows]
  readonly attribute long textLength;

  [ChromeOnly]
  sequence<DOMString> mozGetFileNameArray();

  [ChromeOnly]
  void mozSetFileNameArray(sequence<DOMString> fileNames);

  boolean mozIsTextField(boolean aExcludePassword);
};

partial interface HTMLInputElement {



  [Pure, ChromeOnly]
  readonly attribute nsIEditor? editor;




  [ChromeOnly]
  void setUserInput(DOMString input);
};

[NoInterfaceObject]
interface MozPhonetic {
  [Pure, ChromeOnly]
  readonly attribute DOMString phonetic;
};

HTMLInputElement implements MozImageLoadingContent;
HTMLInputElement implements MozPhonetic;
interface HTMLLabelElement : HTMLElement {
  readonly attribute HTMLFormElement? form;
           attribute DOMString htmlFor;
  readonly attribute HTMLElement? control;
};
interface HTMLLegendElement : HTMLElement {
  readonly attribute HTMLFormElement? form;
};


partial interface HTMLLegendElement {
           attribute DOMString align;
};
interface HTMLLIElement : HTMLElement {
           [SetterThrows, Pure]
           attribute long value;
};


partial interface HTMLLIElement {
           [SetterThrows, Pure]
           attribute DOMString type;
};
interface HTMLLinkElement : HTMLElement {
  [Pure]
           attribute boolean disabled;
  [SetterThrows, Pure]
           attribute DOMString href;
  [SetterThrows, Pure]
           attribute DOMString crossOrigin;
  [SetterThrows, Pure]
           attribute DOMString rel;


  [SetterThrows, Pure]
           attribute DOMString media;
  [SetterThrows, Pure]
           attribute DOMString hreflang;
  [SetterThrows, Pure]
           attribute DOMString type;


};
HTMLLinkElement implements LinkStyle;


partial interface HTMLLinkElement {
  [SetterThrows, Pure]
           attribute DOMString charset;
  [SetterThrows, Pure]
           attribute DOMString rev;
  [SetterThrows, Pure]
           attribute DOMString target;
};
interface HTMLMapElement : HTMLElement {
  [SetterThrows, Pure]
           attribute DOMString name;
  [Constant]
  readonly attribute HTMLCollection areas;


};
interface HTMLMediaElement : HTMLElement {


  readonly attribute MediaError? error;


  [SetterThrows]
           attribute DOMString src;
  readonly attribute DOMString currentSrc;

  [SetterThrows]
           attribute DOMString crossOrigin;
  const unsigned short NETWORK_EMPTY = 0;
  const unsigned short NETWORK_IDLE = 1;
  const unsigned short NETWORK_LOADING = 2;
  const unsigned short NETWORK_NO_SOURCE = 3;
  readonly attribute unsigned short networkState;
  [SetterThrows]
           attribute DOMString preload;
  [Creator]
  readonly attribute TimeRanges buffered;
  void load();
  DOMString canPlayType(DOMString type);


  const unsigned short HAVE_NOTHING = 0;
  const unsigned short HAVE_METADATA = 1;
  const unsigned short HAVE_CURRENT_DATA = 2;
  const unsigned short HAVE_FUTURE_DATA = 3;
  const unsigned short HAVE_ENOUGH_DATA = 4;
  readonly attribute unsigned short readyState;
  readonly attribute boolean seeking;


  [SetterThrows]
           attribute double currentTime;

  readonly attribute unrestricted double duration;

  readonly attribute boolean paused;
  [SetterThrows]
           attribute double defaultPlaybackRate;
  [SetterThrows]
           attribute double playbackRate;
  [Creator]
  readonly attribute TimeRanges played;
  [Creator]
  readonly attribute TimeRanges seekable;
  readonly attribute boolean ended;
  [SetterThrows]
           attribute boolean autoplay;
  [SetterThrows]
           attribute boolean loop;
  [Throws]
  void play();
  [Throws]
  void pause();







  [SetterThrows]
           attribute boolean controls;
  [SetterThrows]
           attribute double volume;
           attribute boolean muted;
  [SetterThrows]
           attribute boolean defaultMuted;





  [Pref="media.webvtt.enabled"]
  readonly attribute TextTrackList textTracks;
  [Pref="media.webvtt.enabled"]
  TextTrack addTextTrack(TextTrackKind kind, optional DOMString label = "", optional DOMString language = "");
};


partial interface HTMLMediaElement {
  attribute MediaStream? mozSrcObject;
  attribute boolean mozPreservesPitch;
  readonly attribute boolean mozAutoplayEnabled;


  [Throws]
  MediaStream mozCaptureStream();
  [Throws]
  MediaStream mozCaptureStreamUntilEnded();
  readonly attribute boolean mozAudioCaptured;







  [GetterThrows]
  readonly attribute unsigned long mozChannels;
  [GetterThrows]
  readonly attribute unsigned long mozSampleRate;
  [Throws]
           attribute unsigned long mozFrameBufferLength;




  [Throws]
  object? mozGetMetadata();




  readonly attribute double mozFragmentEnd;
  [SetterThrows]
  attribute DOMString mozAudioChannelType;





};
interface MenuBuilder;


interface HTMLMenuElement : HTMLElement {
           [SetterThrows]
           attribute DOMString type;
           [SetterThrows]
           attribute DOMString label;
};


partial interface HTMLMenuElement {
           [SetterThrows]
           attribute boolean compact;
};


partial interface HTMLMenuElement {
  [ChromeOnly]
  void sendShowEvent();
  [ChromeOnly]
  MenuBuilder createBuilder();
  [ChromeOnly]
  void build(MenuBuilder aBuilder);
};
interface HTMLMenuItemElement : HTMLElement {
           [SetterThrows]
           attribute DOMString type;
           [SetterThrows]
           attribute DOMString label;
           [SetterThrows]
           attribute DOMString icon;
           [SetterThrows]
           attribute boolean disabled;
           [SetterThrows]
           attribute boolean checked;
           [SetterThrows]
           attribute DOMString radiogroup;



           [SetterThrows]
           attribute boolean defaultChecked;



};
interface HTMLMetaElement : HTMLElement {
  [SetterThrows, Pure]
           attribute DOMString name;
  [SetterThrows, Pure]
           attribute DOMString httpEquiv;
  [SetterThrows, Pure]
           attribute DOMString content;
};


partial interface HTMLMetaElement {
  [SetterThrows, Pure]
           attribute DOMString scheme;
};
interface HTMLMeterElement : HTMLElement {
           [SetterThrows]
           attribute double value;
           [SetterThrows]
           attribute double min;
           [SetterThrows]
           attribute double max;
           [SetterThrows]
           attribute double low;
           [SetterThrows]
           attribute double high;
           [SetterThrows]
           attribute double optimum;
};
interface HTMLModElement : HTMLElement {
  [SetterThrows, Pure]
           attribute DOMString cite;
  [SetterThrows, Pure]
           attribute DOMString dateTime;
};
[NeedNewResolve]
interface HTMLObjectElement : HTMLElement {
  [Pure, SetterThrows]
           attribute DOMString data;
  [Pure, SetterThrows]
           attribute DOMString type;

  [Pure, SetterThrows]
           attribute DOMString name;
  [Pure, SetterThrows]
           attribute DOMString useMap;
  [Pure]
  readonly attribute HTMLFormElement? form;
  [Pure, SetterThrows]
           attribute DOMString width;
  [Pure, SetterThrows]
           attribute DOMString height;

  readonly attribute Document? contentDocument;

  readonly attribute WindowProxy? contentWindow;

  readonly attribute boolean willValidate;
  readonly attribute ValidityState validity;
  readonly attribute DOMString validationMessage;
  boolean checkValidity();
  void setCustomValidity(DOMString error);

  [Throws]
  legacycaller any (any... arguments);
};


partial interface HTMLObjectElement {
  [Pure, SetterThrows]
           attribute DOMString align;
  [Pure, SetterThrows]
           attribute DOMString archive;
  [Pure, SetterThrows]
           attribute DOMString code;
  [Pure, SetterThrows]
           attribute boolean declare;
  [Pure, SetterThrows]
           attribute unsigned long hspace;
  [Pure, SetterThrows]
           attribute DOMString standby;
  [Pure, SetterThrows]
           attribute unsigned long vspace;
  [Pure, SetterThrows]
           attribute DOMString codeBase;
  [Pure, SetterThrows]
           attribute DOMString codeType;

  [TreatNullAs=EmptyString, Pure, SetterThrows]
           attribute DOMString border;
};

partial interface HTMLObjectElement {

  Document? getSVGDocument();
};

[NoInterfaceObject]
interface MozObjectLoadingContent {



  [ChromeOnly]
  const unsigned long TYPE_LOADING = 0;
  [ChromeOnly]
  const unsigned long TYPE_IMAGE = 1;
  [ChromeOnly]
  const unsigned long TYPE_PLUGIN = 2;
  [ChromeOnly]
  const unsigned long TYPE_DOCUMENT = 3;
  [ChromeOnly]
  const unsigned long TYPE_NULL = 4;


  [ChromeOnly]
  const unsigned long PLUGIN_UNSUPPORTED = 0;

  [ChromeOnly]
  const unsigned long PLUGIN_ALTERNATE = 1;

  [ChromeOnly]
  const unsigned long PLUGIN_DISABLED = 2;

  [ChromeOnly]
  const unsigned long PLUGIN_BLOCKLISTED = 3;

  [ChromeOnly]
  const unsigned long PLUGIN_OUTDATED = 4;

  [ChromeOnly]
  const unsigned long PLUGIN_CRASHED = 5;

  [ChromeOnly]
  const unsigned long PLUGIN_SUPPRESSED = 6;

  [ChromeOnly]
  const unsigned long PLUGIN_USER_DISABLED = 7;





  [ChromeOnly]
  const unsigned long PLUGIN_CLICK_TO_PLAY = 8;

  [ChromeOnly]
  const unsigned long PLUGIN_VULNERABLE_UPDATABLE = 9;

  [ChromeOnly]
  const unsigned long PLUGIN_VULNERABLE_NO_UPDATE = 10;

  [ChromeOnly]
  const unsigned long PLUGIN_PLAY_PREVIEW = 11;
  [ChromeOnly]
  readonly attribute DOMString actualType;
  [ChromeOnly]
  readonly attribute unsigned long displayedType;
  [ChromeOnly]
  unsigned long getContentTypeForMIMEType(DOMString aMimeType);
  [ChromeOnly, Throws]
  void playPlugin();
  [ChromeOnly]
  readonly attribute boolean activated;
  [ChromeOnly]
  readonly attribute URI? srcURI;

  [ChromeOnly]
  readonly attribute unsigned long defaultFallbackType;

  [ChromeOnly]
  readonly attribute unsigned long pluginFallbackType;
  [ChromeOnly]
  readonly attribute boolean hasRunningPlugin;
  [ChromeOnly, Throws]
  void cancelPlayPreview();
};

HTMLObjectElement implements MozImageLoadingContent;
HTMLObjectElement implements MozFrameLoaderOwner;
HTMLObjectElement implements MozObjectLoadingContent;
interface HTMLOListElement : HTMLElement {
           [SetterThrows]
           attribute boolean reversed;
           [SetterThrows]
           attribute long start;
           [SetterThrows]
           attribute DOMString type;
};


partial interface HTMLOListElement {
           [SetterThrows]
           attribute boolean compact;
};
interface HTMLOptGroupElement : HTMLElement {
           [SetterThrows]
           attribute boolean disabled;
           [SetterThrows]
           attribute DOMString label;
};
[NamedConstructor=Option(optional DOMString text, optional DOMString value, optional boolean defaultSelected, optional boolean selected)]
interface HTMLOptionElement : HTMLElement {
           [SetterThrows]
           attribute boolean disabled;
  readonly attribute HTMLFormElement? form;
           [SetterThrows]
           attribute DOMString label;
           [SetterThrows]
           attribute boolean defaultSelected;
           [SetterThrows]
           attribute boolean selected;
           [SetterThrows]
           attribute DOMString value;

           [SetterThrows]
           attribute DOMString text;
           [GetterThrows]
  readonly attribute long index;
};
interface HTMLOptionsCollection : HTMLCollection {
           attribute unsigned long length;
  [Throws]
  getter object? namedItem(DOMString name);
  [Throws]
  setter creator void (unsigned long index, HTMLOptionElement? option);
  [Throws]
  void add((HTMLOptionElement or HTMLOptGroupElement) element, optional (HTMLElement or long)? before = null);
  [Throws]
  void remove(long index);
  [Throws]
           attribute long selectedIndex;
};
interface HTMLOutputElement : HTMLElement {
  [PutForwards=value, Constant]
  readonly attribute DOMSettableTokenList htmlFor;
  readonly attribute HTMLFormElement? form;
  [SetterThrows, Pure]
           attribute DOMString name;

  [Constant]
  readonly attribute DOMString type;
  [SetterThrows, Pure]
           attribute DOMString defaultValue;
  [SetterThrows, Pure]
           attribute DOMString value;

  readonly attribute boolean willValidate;
  readonly attribute ValidityState validity;
  readonly attribute DOMString validationMessage;
  boolean checkValidity();
  void setCustomValidity(DOMString error);



};
interface HTMLParagraphElement : HTMLElement {
};


partial interface HTMLParagraphElement {
           [SetterThrows]
           attribute DOMString align;
};
interface HTMLParamElement : HTMLElement {
           [SetterThrows, Pure]
           attribute DOMString name;
           [SetterThrows, Pure]
           attribute DOMString value;
};


partial interface HTMLParamElement {
           [SetterThrows, Pure]
           attribute DOMString type;
           [SetterThrows, Pure]
           attribute DOMString valueType;
};
interface HTMLPreElement : HTMLElement {
};


partial interface HTMLPreElement {
           [SetterThrows]
           attribute long width;
};
interface HTMLProgressElement : HTMLElement {
           [SetterThrows]
           attribute double value;
           [SetterThrows]
           attribute double max;
  readonly attribute double position;
};
interface DOMStringList;

interface HTMLPropertiesCollection : HTMLCollection {

  getter PropertyNodeList? namedItem(DOMString name);
  readonly attribute DOMStringList names;
};

typedef sequence<any> PropertyValueArray;

interface PropertyNodeList : NodeList {
  [Throws]
  PropertyValueArray getValues();
};
interface HTMLQuoteElement : HTMLElement {
           [SetterThrows, Pure]
           attribute DOMString cite;
};
interface HTMLScriptElement : HTMLElement {
  [SetterThrows]
  attribute DOMString src;
  [SetterThrows]
  attribute DOMString type;
  [SetterThrows]
  attribute DOMString charset;
  [SetterThrows]
  attribute boolean async;
  [SetterThrows]
  attribute boolean defer;
  [SetterThrows]
  attribute DOMString crossOrigin;
  [SetterThrows]
  attribute DOMString text;
};


partial interface HTMLScriptElement {
  [SetterThrows]
  attribute DOMString event;
  [SetterThrows]
  attribute DOMString htmlFor;
};
interface HTMLSelectElement : HTMLElement {
  [SetterThrows, Pure]
           attribute boolean autofocus;
  [SetterThrows, Pure]
           attribute boolean disabled;
  [Pure]
  readonly attribute HTMLFormElement? form;
  [SetterThrows, Pure]
           attribute boolean multiple;
  [SetterThrows, Pure]
           attribute DOMString name;
  [SetterThrows, Pure]
           attribute boolean required;
  [SetterThrows, Pure]
           attribute unsigned long size;

  [Pure]
  readonly attribute DOMString type;

  [Constant]
  readonly attribute HTMLOptionsCollection options;
  [SetterThrows, Pure]
           attribute unsigned long length;
  getter Element? item(unsigned long index);
  HTMLOptionElement? namedItem(DOMString name);
  [Throws]
  void add((HTMLOptionElement or HTMLOptGroupElement) element, optional (HTMLElement or long)? before = null);
  void remove(long index);
  [Throws]
  setter creator void (unsigned long index, HTMLOptionElement? option);


  [SetterThrows, Pure]
           attribute long selectedIndex;
  [Pure]
           attribute DOMString value;

  readonly attribute boolean willValidate;
  readonly attribute ValidityState validity;
  readonly attribute DOMString validationMessage;
  boolean checkValidity();
  void setCustomValidity(DOMString error);




  void remove();
};
interface HTMLSourceElement : HTMLElement {
           [SetterThrows]
           attribute DOMString src;
           [SetterThrows]
           attribute DOMString type;
           [SetterThrows]
           attribute DOMString media;
};
interface HTMLSpanElement : HTMLElement {
};
interface HTMLStyleElement : HTMLElement {
           [Pure]
           attribute boolean disabled;
           [SetterThrows, Pure]
           attribute DOMString media;
           [SetterThrows, Pure]
           attribute DOMString type;
           [SetterThrows, Pure]
           attribute boolean scoped;
};
HTMLStyleElement implements LinkStyle;
interface HTMLTableCaptionElement : HTMLElement {
};

partial interface HTMLTableCaptionElement {
           [SetterThrows]
           attribute DOMString align;
};
interface HTMLTableCellElement : HTMLElement {
           [SetterThrows]
           attribute unsigned long colSpan;
           [SetterThrows]
           attribute unsigned long rowSpan;

           [SetterThrows]
           attribute DOMString headers;
  readonly attribute long cellIndex;


           [SetterThrows]
           attribute DOMString abbr;
           [SetterThrows]
           attribute DOMString scope;
};

partial interface HTMLTableCellElement {
           [SetterThrows]
           attribute DOMString align;
           [SetterThrows]
           attribute DOMString axis;
           [SetterThrows]
           attribute DOMString height;
           [SetterThrows]
           attribute DOMString width;

           [SetterThrows]
           attribute DOMString ch;
           [SetterThrows]
           attribute DOMString chOff;
           [SetterThrows]
           attribute boolean noWrap;
           [SetterThrows]
           attribute DOMString vAlign;

  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString bgColor;
};
interface HTMLTableColElement : HTMLElement {
           attribute unsigned long span;
};

partial interface HTMLTableColElement {
           attribute DOMString align;
           attribute DOMString ch;
           attribute DOMString chOff;
           attribute DOMString vAlign;
           attribute DOMString width;
};
interface HTMLTableElement : HTMLElement {
           attribute HTMLTableCaptionElement? caption;
  HTMLElement createCaption();
  void deleteCaption();
           [SetterThrows]
           attribute HTMLTableSectionElement? tHead;
  HTMLElement createTHead();
  void deleteTHead();
           [SetterThrows]
           attribute HTMLTableSectionElement? tFoot;
  HTMLElement createTFoot();
  void deleteTFoot();
  readonly attribute HTMLCollection tBodies;
  HTMLElement createTBody();
  readonly attribute HTMLCollection rows;
  [Throws]
  HTMLElement insertRow(optional long index = -1);
  [Throws]
  void deleteRow(long index);


};

partial interface HTMLTableElement {
           [SetterThrows]
           attribute DOMString align;
           [SetterThrows]
           attribute DOMString border;
           [SetterThrows]
           attribute DOMString frame;
           [SetterThrows]
           attribute DOMString rules;
           [SetterThrows]
           attribute DOMString summary;
           [SetterThrows]
           attribute DOMString width;

  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString bgColor;
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString cellPadding;
  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString cellSpacing;
};
interface HTMLTableRowElement : HTMLElement {
  readonly attribute long rowIndex;
  readonly attribute long sectionRowIndex;
  readonly attribute HTMLCollection cells;
  [Throws]
  HTMLElement insertCell(optional long index = -1);
  [Throws]
  void deleteCell(long index);
};

partial interface HTMLTableRowElement {
           [SetterThrows]
           attribute DOMString align;
           [SetterThrows]
           attribute DOMString ch;
           [SetterThrows]
           attribute DOMString chOff;
           [SetterThrows]
           attribute DOMString vAlign;

  [TreatNullAs=EmptyString, SetterThrows]
  attribute DOMString bgColor;
};
interface HTMLTableSectionElement : HTMLElement {
  readonly attribute HTMLCollection rows;
  [Throws]
  HTMLElement insertRow(optional long index = -1);
  [Throws]
  void deleteRow(long index);
};

partial interface HTMLTableSectionElement {
           [SetterThrows]
           attribute DOMString align;
           [SetterThrows]
           attribute DOMString ch;
           [SetterThrows]
           attribute DOMString chOff;
           [SetterThrows]
           attribute DOMString vAlign;
};
interface HTMLTemplateElement : HTMLElement {
    readonly attribute DocumentFragment content;
};
interface nsIEditor;
interface MozControllers;

interface HTMLTextAreaElement : HTMLElement {

  [SetterThrows, Pure]
           attribute boolean autofocus;
  [SetterThrows, Pure]
           attribute unsigned long cols;

  [SetterThrows, Pure]
           attribute boolean disabled;
  [Pure]
  readonly attribute HTMLFormElement? form;

  [SetterThrows, Pure]
           attribute long maxLength;
  [SetterThrows, Pure]
           attribute DOMString name;
  [SetterThrows, Pure]
           attribute DOMString placeholder;
  [SetterThrows, Pure]
           attribute boolean readOnly;
  [SetterThrows, Pure]
           attribute boolean required;
  [SetterThrows, Pure]
           attribute unsigned long rows;
  [SetterThrows, Pure]
           attribute DOMString wrap;

  [Constant]
  readonly attribute DOMString type;
  [SetterThrows, Pure]
           attribute DOMString defaultValue;
  [TreatNullAs=EmptyString]
  attribute DOMString value;
  readonly attribute unsigned long textLength;

  readonly attribute boolean willValidate;
  readonly attribute ValidityState validity;
  readonly attribute DOMString validationMessage;
  boolean checkValidity();
  void setCustomValidity(DOMString error);



  void select();
  [Throws]
           attribute unsigned long selectionStart;
  [Throws]
           attribute unsigned long selectionEnd;
  [Throws]
           attribute DOMString selectionDirection;


  [Throws]
  void setSelectionRange(unsigned long start, unsigned long end, optional DOMString direction);
};

partial interface HTMLTextAreaElement {



  [Throws, ChromeOnly]
  readonly attribute MozControllers controllers;
};

partial interface HTMLTextAreaElement {



  [ChromeOnly]
  readonly attribute nsIEditor? editor;





  [ChromeOnly]
  void setUserInput(DOMString input);
};
interface HTMLTimeElement : HTMLElement {
           [SetterThrows]
           attribute DOMString dateTime;
};
interface HTMLTitleElement : HTMLElement {
           [SetterThrows]
           attribute DOMString text;
};
[Pref="media.webvtt.enabled"]
interface HTMLTrackElement : HTMLElement {
  [SetterThrows, Pure]
  attribute TextTrackKind kind;
  [SetterThrows, Pure]
  attribute DOMString src;
  [SetterThrows, Pure]
  attribute DOMString srclang;
  [SetterThrows, Pure]
  attribute DOMString label;
  [SetterThrows, Pure]
  attribute boolean default;

  const unsigned short NONE = 0;
  const unsigned short LOADING = 1;
  const unsigned short LOADED = 2;
  const unsigned short ERROR = 3;
  readonly attribute unsigned short readyState;

  readonly attribute TextTrack track;
};
interface HTMLUListElement : HTMLElement {
};


partial interface HTMLUListElement {
           [SetterThrows]
           attribute boolean compact;
           [SetterThrows]
           attribute DOMString type;
};
interface HTMLVideoElement : HTMLMediaElement {
  [SetterThrows]
           attribute unsigned long width;
  [SetterThrows]
           attribute unsigned long height;
  readonly attribute unsigned long videoWidth;
  readonly attribute unsigned long videoHeight;
  [SetterThrows]
           attribute DOMString poster;
};

partial interface HTMLVideoElement {



  readonly attribute unsigned long mozParsedFrames;



  readonly attribute unsigned long mozDecodedFrames;



  readonly attribute unsigned long mozPresentedFrames;


  readonly attribute unsigned long mozPaintedFrames;


  readonly attribute double mozFrameDelay;


  readonly attribute boolean mozHasAudio;
};


partial interface HTMLVideoElement {
  [Pref="media.mediasource.enabled", Creator]
  VideoPlaybackQuality getVideoPlaybackQuality();
};
[Constructor(DOMString type, optional IccCardLockErrorEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface IccCardLockErrorEvent : Event {
  readonly attribute DOMString? lockType;
  readonly attribute long retryCount;
};

dictionary IccCardLockErrorEventInit : EventInit {
  DOMString lockType = "";
  long retryCount = 0;
};
dictionary IDBObjectStoreParameters {


  any keyPath = null;
  boolean autoIncrement = false;
};
interface IDBOpenDBRequest;
interface Principal;
interface IDBFactory {
  [Throws]
  IDBOpenDBRequest open(DOMString name, [EnforceRange] optional unsigned long long version);

  [Throws]
  IDBOpenDBRequest deleteDatabase(DOMString name);

  [Throws]
  short cmp(any first, any second);

  [Throws, ChromeOnly]
  IDBOpenDBRequest openForPrincipal(Principal principal, DOMString name, [EnforceRange] optional unsigned long long version);

  [Throws, ChromeOnly]
  IDBOpenDBRequest deleteForPrincipal(Principal principal, DOMString name);
};
interface IDBDatabase;

interface IDBFileHandle : FileHandle {
  readonly attribute IDBDatabase database;
};
dictionary IDBVersionChangeEventInit : EventInit {
    unsigned long long oldVersion = 0;
    unsigned long long? newVersion = null;
};

[Constructor(DOMString type, optional IDBVersionChangeEventInit eventInitDict)]
interface IDBVersionChangeEvent : Event {
    readonly attribute unsigned long long oldVersion;
    readonly attribute unsigned long long? newVersion;
};
interface ImageData {
 [Constant]
 readonly attribute unsigned long width;
 [Constant]
 readonly attribute unsigned long height;
 [Constant]
 readonly attribute Uint8ClampedArray data;
};
interface imgIRequest;

[ChromeOnly]
interface ImageDocument : HTMLDocument {

  readonly attribute boolean imageResizingEnabled;


  readonly attribute boolean imageIsOverflowing;


  readonly attribute boolean imageIsResized;


  [Throws]
  readonly attribute imgIRequest? imageRequest;


  void shrinkToFit();


  void restoreImage();
  void restoreImageTo(long x, long y);
  void toggleImageSize();
};
dictionary InspectorRGBTriple {
  octet r = 0;
  octet g = 0;
  octet b = 0;
};
interface WindowProxy;

interface KeyboardEvent : UIEvent {
  readonly attribute unsigned long charCode;
  readonly attribute unsigned long keyCode;

  readonly attribute boolean altKey;
  readonly attribute boolean ctrlKey;
  readonly attribute boolean shiftKey;
  readonly attribute boolean metaKey;

  boolean getModifierState(DOMString key);

  const unsigned long DOM_KEY_LOCATION_STANDARD = 0x00;
  const unsigned long DOM_KEY_LOCATION_LEFT = 0x01;
  const unsigned long DOM_KEY_LOCATION_RIGHT = 0x02;
  const unsigned long DOM_KEY_LOCATION_NUMPAD = 0x03;
  const unsigned long DOM_KEY_LOCATION_MOBILE = 0x04;
  const unsigned long DOM_KEY_LOCATION_JOYSTICK = 0x05;

  readonly attribute unsigned long location;

  readonly attribute DOMString key;
};


KeyboardEvent implements KeyEvent;
interface WindowProxy;


interface KeyEvent {
  const unsigned long DOM_VK_CANCEL = 0x03;
  const unsigned long DOM_VK_HELP = 0x06;
  const unsigned long DOM_VK_BACK_SPACE = 0x08;
  const unsigned long DOM_VK_TAB = 0x09;
  const unsigned long DOM_VK_CLEAR = 0x0C;
  const unsigned long DOM_VK_RETURN = 0x0D;
  const unsigned long DOM_VK_ENTER = 0x0E;
  const unsigned long DOM_VK_SHIFT = 0x10;
  const unsigned long DOM_VK_CONTROL = 0x11;
  const unsigned long DOM_VK_ALT = 0x12;
  const unsigned long DOM_VK_PAUSE = 0x13;
  const unsigned long DOM_VK_CAPS_LOCK = 0x14;
  const unsigned long DOM_VK_KANA = 0x15;
  const unsigned long DOM_VK_HANGUL = 0x15;
  const unsigned long DOM_VK_EISU = 0x16;
  const unsigned long DOM_VK_JUNJA = 0x17;
  const unsigned long DOM_VK_FINAL = 0x18;
  const unsigned long DOM_VK_HANJA = 0x19;
  const unsigned long DOM_VK_KANJI = 0x19;
  const unsigned long DOM_VK_ESCAPE = 0x1B;
  const unsigned long DOM_VK_CONVERT = 0x1C;
  const unsigned long DOM_VK_NONCONVERT = 0x1D;
  const unsigned long DOM_VK_ACCEPT = 0x1E;
  const unsigned long DOM_VK_MODECHANGE = 0x1F;
  const unsigned long DOM_VK_SPACE = 0x20;
  const unsigned long DOM_VK_PAGE_UP = 0x21;
  const unsigned long DOM_VK_PAGE_DOWN = 0x22;
  const unsigned long DOM_VK_END = 0x23;
  const unsigned long DOM_VK_HOME = 0x24;
  const unsigned long DOM_VK_LEFT = 0x25;
  const unsigned long DOM_VK_UP = 0x26;
  const unsigned long DOM_VK_RIGHT = 0x27;
  const unsigned long DOM_VK_DOWN = 0x28;
  const unsigned long DOM_VK_SELECT = 0x29;
  const unsigned long DOM_VK_PRINT = 0x2A;
  const unsigned long DOM_VK_EXECUTE = 0x2B;
  const unsigned long DOM_VK_PRINTSCREEN = 0x2C;
  const unsigned long DOM_VK_INSERT = 0x2D;
  const unsigned long DOM_VK_DELETE = 0x2E;


  const unsigned long DOM_VK_0 = 0x30;
  const unsigned long DOM_VK_1 = 0x31;
  const unsigned long DOM_VK_2 = 0x32;
  const unsigned long DOM_VK_3 = 0x33;
  const unsigned long DOM_VK_4 = 0x34;
  const unsigned long DOM_VK_5 = 0x35;
  const unsigned long DOM_VK_6 = 0x36;
  const unsigned long DOM_VK_7 = 0x37;
  const unsigned long DOM_VK_8 = 0x38;
  const unsigned long DOM_VK_9 = 0x39;

  const unsigned long DOM_VK_COLON = 0x3A;
  const unsigned long DOM_VK_SEMICOLON = 0x3B;
  const unsigned long DOM_VK_LESS_THAN = 0x3C;
  const unsigned long DOM_VK_EQUALS = 0x3D;
  const unsigned long DOM_VK_GREATER_THAN = 0x3E;
  const unsigned long DOM_VK_QUESTION_MARK = 0x3F;
  const unsigned long DOM_VK_AT = 0x40;


  const unsigned long DOM_VK_A = 0x41;
  const unsigned long DOM_VK_B = 0x42;
  const unsigned long DOM_VK_C = 0x43;
  const unsigned long DOM_VK_D = 0x44;
  const unsigned long DOM_VK_E = 0x45;
  const unsigned long DOM_VK_F = 0x46;
  const unsigned long DOM_VK_G = 0x47;
  const unsigned long DOM_VK_H = 0x48;
  const unsigned long DOM_VK_I = 0x49;
  const unsigned long DOM_VK_J = 0x4A;
  const unsigned long DOM_VK_K = 0x4B;
  const unsigned long DOM_VK_L = 0x4C;
  const unsigned long DOM_VK_M = 0x4D;
  const unsigned long DOM_VK_N = 0x4E;
  const unsigned long DOM_VK_O = 0x4F;
  const unsigned long DOM_VK_P = 0x50;
  const unsigned long DOM_VK_Q = 0x51;
  const unsigned long DOM_VK_R = 0x52;
  const unsigned long DOM_VK_S = 0x53;
  const unsigned long DOM_VK_T = 0x54;
  const unsigned long DOM_VK_U = 0x55;
  const unsigned long DOM_VK_V = 0x56;
  const unsigned long DOM_VK_W = 0x57;
  const unsigned long DOM_VK_X = 0x58;
  const unsigned long DOM_VK_Y = 0x59;
  const unsigned long DOM_VK_Z = 0x5A;

  const unsigned long DOM_VK_WIN = 0x5B;
  const unsigned long DOM_VK_CONTEXT_MENU = 0x5D;
  const unsigned long DOM_VK_SLEEP = 0x5F;


  const unsigned long DOM_VK_NUMPAD0 = 0x60;
  const unsigned long DOM_VK_NUMPAD1 = 0x61;
  const unsigned long DOM_VK_NUMPAD2 = 0x62;
  const unsigned long DOM_VK_NUMPAD3 = 0x63;
  const unsigned long DOM_VK_NUMPAD4 = 0x64;
  const unsigned long DOM_VK_NUMPAD5 = 0x65;
  const unsigned long DOM_VK_NUMPAD6 = 0x66;
  const unsigned long DOM_VK_NUMPAD7 = 0x67;
  const unsigned long DOM_VK_NUMPAD8 = 0x68;
  const unsigned long DOM_VK_NUMPAD9 = 0x69;
  const unsigned long DOM_VK_MULTIPLY = 0x6A;
  const unsigned long DOM_VK_ADD = 0x6B;
  const unsigned long DOM_VK_SEPARATOR = 0x6C;
  const unsigned long DOM_VK_SUBTRACT = 0x6D;
  const unsigned long DOM_VK_DECIMAL = 0x6E;
  const unsigned long DOM_VK_DIVIDE = 0x6F;

  const unsigned long DOM_VK_F1 = 0x70;
  const unsigned long DOM_VK_F2 = 0x71;
  const unsigned long DOM_VK_F3 = 0x72;
  const unsigned long DOM_VK_F4 = 0x73;
  const unsigned long DOM_VK_F5 = 0x74;
  const unsigned long DOM_VK_F6 = 0x75;
  const unsigned long DOM_VK_F7 = 0x76;
  const unsigned long DOM_VK_F8 = 0x77;
  const unsigned long DOM_VK_F9 = 0x78;
  const unsigned long DOM_VK_F10 = 0x79;
  const unsigned long DOM_VK_F11 = 0x7A;
  const unsigned long DOM_VK_F12 = 0x7B;
  const unsigned long DOM_VK_F13 = 0x7C;
  const unsigned long DOM_VK_F14 = 0x7D;
  const unsigned long DOM_VK_F15 = 0x7E;
  const unsigned long DOM_VK_F16 = 0x7F;
  const unsigned long DOM_VK_F17 = 0x80;
  const unsigned long DOM_VK_F18 = 0x81;
  const unsigned long DOM_VK_F19 = 0x82;
  const unsigned long DOM_VK_F20 = 0x83;
  const unsigned long DOM_VK_F21 = 0x84;
  const unsigned long DOM_VK_F22 = 0x85;
  const unsigned long DOM_VK_F23 = 0x86;
  const unsigned long DOM_VK_F24 = 0x87;

  const unsigned long DOM_VK_NUM_LOCK = 0x90;
  const unsigned long DOM_VK_SCROLL_LOCK = 0x91;



  const unsigned long DOM_VK_WIN_OEM_FJ_JISHO = 0x92;
  const unsigned long DOM_VK_WIN_OEM_FJ_MASSHOU = 0x93;
  const unsigned long DOM_VK_WIN_OEM_FJ_TOUROKU = 0x94;
  const unsigned long DOM_VK_WIN_OEM_FJ_LOYA = 0x95;
  const unsigned long DOM_VK_WIN_OEM_FJ_ROYA = 0x96;

  const unsigned long DOM_VK_CIRCUMFLEX = 0xA0;
  const unsigned long DOM_VK_EXCLAMATION = 0xA1;
  const unsigned long DOM_VK_DOUBLE_QUOTE = 0xA2;
  const unsigned long DOM_VK_HASH = 0xA3;
  const unsigned long DOM_VK_DOLLAR = 0xA4;
  const unsigned long DOM_VK_PERCENT = 0xA5;
  const unsigned long DOM_VK_AMPERSAND = 0xA6;
  const unsigned long DOM_VK_UNDERSCORE = 0xA7;
  const unsigned long DOM_VK_OPEN_PAREN = 0xA8;
  const unsigned long DOM_VK_CLOSE_PAREN = 0xA9;
  const unsigned long DOM_VK_ASTERISK = 0xAA;
  const unsigned long DOM_VK_PLUS = 0xAB;
  const unsigned long DOM_VK_PIPE = 0xAC;
  const unsigned long DOM_VK_HYPHEN_MINUS = 0xAD;

  const unsigned long DOM_VK_OPEN_CURLY_BRACKET = 0xAE;
  const unsigned long DOM_VK_CLOSE_CURLY_BRACKET = 0xAF;

  const unsigned long DOM_VK_TILDE = 0xB0;

  const unsigned long DOM_VK_VOLUME_MUTE = 0xB5;
  const unsigned long DOM_VK_VOLUME_DOWN = 0xB6;
  const unsigned long DOM_VK_VOLUME_UP = 0xB7;

  const unsigned long DOM_VK_COMMA = 0xBC;
  const unsigned long DOM_VK_PERIOD = 0xBE;
  const unsigned long DOM_VK_SLASH = 0xBF;
  const unsigned long DOM_VK_BACK_QUOTE = 0xC0;
  const unsigned long DOM_VK_OPEN_BRACKET = 0xDB;
  const unsigned long DOM_VK_BACK_SLASH = 0xDC;
  const unsigned long DOM_VK_CLOSE_BRACKET = 0xDD;
  const unsigned long DOM_VK_QUOTE = 0xDE;

  const unsigned long DOM_VK_META = 0xE0;
  const unsigned long DOM_VK_ALTGR = 0xE1;



  const unsigned long DOM_VK_WIN_ICO_HELP = 0xE3;
  const unsigned long DOM_VK_WIN_ICO_00 = 0xE4;
  const unsigned long DOM_VK_WIN_ICO_CLEAR = 0xE6;
  const unsigned long DOM_VK_WIN_OEM_RESET = 0xE9;
  const unsigned long DOM_VK_WIN_OEM_JUMP = 0xEA;
  const unsigned long DOM_VK_WIN_OEM_PA1 = 0xEB;
  const unsigned long DOM_VK_WIN_OEM_PA2 = 0xEC;
  const unsigned long DOM_VK_WIN_OEM_PA3 = 0xED;
  const unsigned long DOM_VK_WIN_OEM_WSCTRL = 0xEE;
  const unsigned long DOM_VK_WIN_OEM_CUSEL = 0xEF;
  const unsigned long DOM_VK_WIN_OEM_ATTN = 0xF0;
  const unsigned long DOM_VK_WIN_OEM_FINISH = 0xF1;
  const unsigned long DOM_VK_WIN_OEM_COPY = 0xF2;
  const unsigned long DOM_VK_WIN_OEM_AUTO = 0xF3;
  const unsigned long DOM_VK_WIN_OEM_ENLW = 0xF4;
  const unsigned long DOM_VK_WIN_OEM_BACKTAB = 0xF5;



  const unsigned long DOM_VK_ATTN = 0xF6;
  const unsigned long DOM_VK_CRSEL = 0xF7;
  const unsigned long DOM_VK_EXSEL = 0xF8;
  const unsigned long DOM_VK_EREOF = 0xF9;
  const unsigned long DOM_VK_PLAY = 0xFA;
  const unsigned long DOM_VK_ZOOM = 0xFB;
  const unsigned long DOM_VK_PA1 = 0xFD;



  const unsigned long DOM_VK_WIN_OEM_CLEAR = 0xFE;

  [Throws]
  void initKeyEvent(DOMString type, boolean canBubble, boolean cancelable, WindowProxy? view, boolean ctrlKey, boolean altKey, boolean shiftKey, boolean metaKey, unsigned long keyCode, unsigned long charCode);
};
[NoInterfaceObject]
interface LinkStyle {
      readonly attribute StyleSheet? sheet;
};
interface LocalMediaStream : MediaStream {
    void stop();
};
interface Location {
  stringifier attribute DOMString href;
  void assign(DOMString url);
  void replace(DOMString url);
  void reload();
};
Location implements URLUtils;
interface MediaError {
  const unsigned short MEDIA_ERR_ABORTED = 1;
  const unsigned short MEDIA_ERR_NETWORK = 2;
  const unsigned short MEDIA_ERR_DECODE = 3;
  const unsigned short MEDIA_ERR_SRC_NOT_SUPPORTED = 4;

  [Constant]
  readonly attribute unsigned short code;
};
enum RecordingState {
	"inactive",
	"recording",
	"paused"
};

[Constructor(MediaStream stream)]
interface MediaRecorder : EventTarget {

  readonly attribute MediaStream stream;

  readonly attribute RecordingState state;

  readonly attribute DOMString mimeType;

  [SetterThrows]
  attribute EventHandler ondataavailable;

  [SetterThrows]
  attribute EventHandler onerror;

  [SetterThrows]
  attribute EventHandler onstop;

  [SetterThrows]
  attribute EventHandler onwarning;

  [Throws]
  void start(optional long timeSlice);

  [Throws]
  void stop();

  [Throws]
  void pause();

  [Throws]
  void resume();

  [Throws]
  void requestData();
};
enum MediaSourceReadyState {
  "closed",
  "open",
  "ended"
};

enum MediaSourceEndOfStreamError {
  "network",
  "decode"
};

[Constructor, Pref="media.mediasource.enabled"]
interface MediaSource : EventTarget {
  readonly attribute SourceBufferList sourceBuffers;
  readonly attribute SourceBufferList activeSourceBuffers;
  readonly attribute MediaSourceReadyState readyState;
  [SetterThrows]
  attribute unrestricted double duration;
  [Creator, Throws]
  SourceBuffer addSourceBuffer(DOMString type);
  [Throws]
  void removeSourceBuffer(SourceBuffer sourceBuffer);
  [Throws]
  void endOfStream(optional MediaSourceEndOfStreamError error);
  static boolean isTypeSupported(DOMString type);
};
interface MediaStream {

    sequence<AudioStreamTrack> getAudioTracks ();
    sequence<VideoStreamTrack> getVideoTracks ();







	readonly attribute double currentTime;
};
[PrefControlled]
interface MediaStreamAudioDestinationNode : AudioNode {

    readonly attribute MediaStream stream;

};
dictionary MediaStreamEventInit : EventInit {
    MediaStream? stream = null;
};

[Pref="media.peerconnection.enabled", JSImplementation="@mozilla.org/dom/mediastreamevent;1", Constructor(DOMString type, optional MediaStreamEventInit eventInitDict)]
interface MediaStreamEvent : Event {
  readonly attribute MediaStream? stream;
};
[NoInterfaceObject]
interface MediaStreamList {
  getter MediaStream? (unsigned long index);
  readonly attribute unsigned long length;
};
interface MediaStreamTrack {
    readonly attribute DOMString kind;
    readonly attribute DOMString id;
    readonly attribute DOMString label;
                attribute boolean enabled;
};
interface WindowProxy;

interface MessageEvent : Event {
  [GetterThrows]
  readonly attribute any data;
  readonly attribute DOMString origin;
  readonly attribute DOMString lastEventId;
  readonly attribute WindowProxy? source;
  [Throws]
  void initMessageEvent(DOMString aType, boolean aCanBubble, boolean aCancelable, any aData, DOMString aOrigin, DOMString aLastEventId, WindowProxy? aSource);
};
interface MimeType {
  readonly attribute DOMString description;
  readonly attribute Plugin? enabledPlugin;
  readonly attribute DOMString suffixes;
  readonly attribute DOMString type;
};
interface MimeTypeArray {
  readonly attribute unsigned long length;

  getter MimeType? item(unsigned long index);
  getter MimeType? namedItem(DOMString name);
};
dictionary MmsParameters {
  sequence<DOMString> receivers;
  DOMString? subject = null;
  DOMString? smil = null;
  sequence<MmsAttachment> attachments;
};
interface MouseEvent : UIEvent {
  readonly attribute long screenX;
  readonly attribute long screenY;
  readonly attribute long clientX;
  readonly attribute long clientY;
  readonly attribute boolean ctrlKey;
  readonly attribute boolean shiftKey;
  readonly attribute boolean altKey;
  readonly attribute boolean metaKey;
  readonly attribute unsigned short button;
  readonly attribute unsigned short buttons;
  readonly attribute EventTarget? relatedTarget;

  [Throws]
  void initMouseEvent(DOMString typeArg, boolean canBubbleArg, boolean cancelableArg, WindowProxy? viewArg, long detailArg, long screenXArg, long screenYArg, long clientXArg, long clientYArg, boolean ctrlKeyArg, boolean altKeyArg, boolean shiftKeyArg, boolean metaKeyArg, unsigned short buttonArg, EventTarget? relatedTargetArg);

  boolean getModifierState(DOMString keyArg);
};



[Constructor(DOMString typeArg, optional MouseEventInit mouseEventInitDict)]
partial interface MouseEvent {
};


dictionary MouseEventInit {

  boolean bubbles = false;
  boolean cancelable = false;


  WindowProxy? view = null;
  long detail = 0;


  long screenX = 0;
  long screenY = 0;
  long clientX = 0;
  long clientY = 0;
  boolean ctrlKey = false;
  boolean shiftKey = false;
  boolean altKey = false;
  boolean metaKey = false;
  unsigned short button = 0;

  unsigned short buttons = 0;
  EventTarget? relatedTarget = null;
};


partial interface MouseEvent {
  readonly attribute long mozMovementX;
  readonly attribute long mozMovementY;



  readonly attribute float mozPressure;

  const unsigned short MOZ_SOURCE_UNKNOWN = 0;
  const unsigned short MOZ_SOURCE_MOUSE = 1;
  const unsigned short MOZ_SOURCE_PEN = 2;
  const unsigned short MOZ_SOURCE_ERASER = 3;
  const unsigned short MOZ_SOURCE_CURSOR = 4;
  const unsigned short MOZ_SOURCE_TOUCH = 5;
  const unsigned short MOZ_SOURCE_KEYBOARD = 6;

  readonly attribute unsigned short mozInputSource;

  [Throws]
  void initNSMouseEvent(DOMString typeArg, boolean canBubbleArg, boolean cancelableArg, WindowProxy? viewArg, long detailArg, long screenXArg, long screenYArg, long clientXArg, long clientYArg, boolean ctrlKeyArg, boolean altKeyArg, boolean shiftKeyArg, boolean metaKeyArg, unsigned short buttonArg, EventTarget? relatedTargetArg, float pressure, unsigned short inputSourceArg);

};
interface WindowProxy;

interface MouseScrollEvent : MouseEvent {
  const long HORIZONTAL_AXIS = 1;
  const long VERTICAL_AXIS = 2;

  readonly attribute long axis;

  [Throws]
  void initMouseScrollEvent(DOMString type, boolean canBubble, boolean cancelable, WindowProxy? view, long detail, long screenX, long screenY, long clientX, long clientY, boolean ctrlKey, boolean altKey, boolean shiftKey, boolean metaKey, unsigned short button, EventTarget? relatedTarget, long axis);
};
interface ActivityOptions;

[PrefControlled, Constructor(ActivityOptions options)]
interface MozActivity : DOMRequest {
};
interface mozIDOMApplication;

[Constructor(DOMString type, optional MozApplicationEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozApplicationEvent : Event {
  readonly attribute mozIDOMApplication? application;
};

dictionary MozApplicationEventInit : EventInit {
  mozIDOMApplication? application = null;
};
interface MozCellBroadcastMessage;

[Constructor(DOMString type, optional MozCellBroadcastEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozCellBroadcastEvent : Event {
  readonly attribute MozCellBroadcastMessage? message;
};

dictionary MozCellBroadcastEventInit : EventInit {
  MozCellBroadcastMessage? message = null;
};
[Constructor(DOMString type, optional MozContactChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozContactChangeEvent : Event {
  readonly attribute DOMString? contactID;
  readonly attribute DOMString? reason;
};

dictionary MozContactChangeEventInit : EventInit {
  DOMString contactID = "";
  DOMString reason = "";
};
interface MozMmsMessage;

[Constructor(DOMString type, optional MozMmsEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozMmsEvent : Event {
  readonly attribute MozMmsMessage? message;
};

dictionary MozMmsEventInit : EventInit {
  MozMmsMessage? message = null;
};
dictionary MmsAttachment {
  DOMString? id = null;
  DOMString? location = null;
  Blob? content = null;
};
interface MozNamedAttrMap {
  getter Attr? getNamedItem(DOMString name);
  [Throws]
  Attr? setNamedItem(Attr arg);
  [Throws]
  Attr removeNamedItem(DOMString name);

  getter Attr? item(unsigned long index);
  readonly attribute unsigned long length;

  Attr? getNamedItemNS(DOMString? namespaceURI, DOMString localName);
  [Throws]
  Attr? setNamedItemNS(Attr arg);
  [Throws]
  Attr removeNamedItemNS(DOMString? namespaceURI, DOMString localName);
};
[Constructor(DOMString type, optional MozSettingsEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozSettingsEvent : Event {
  readonly attribute DOMString? settingName;
  [Throws]
  readonly attribute any settingValue;
};

dictionary MozSettingsEventInit : EventInit {
  DOMString settingName = "";
  any settingValue = null;
};
interface MozSmsMessage;

[Constructor(DOMString type, optional MozSmsEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozSmsEvent : Event {
  readonly attribute MozSmsMessage? message;
};

dictionary MozSmsEventInit : EventInit {
  MozSmsMessage? message = null;
};
interface MozStkCommandEvent : Event {
  [Throws]
  readonly attribute any command;
};
[PrefControlled]
interface MozTimeManager {
  void set(Date time);
  void set(double time);
};
interface MozVoicemailStatus;

[Constructor(DOMString type, optional MozVoicemailEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozVoicemailEvent : Event {
  readonly attribute MozVoicemailStatus? status;
};

dictionary MozVoicemailEventInit : EventInit {
  MozVoicemailStatus? status = null;
};
[Constructor(DOMString type, optional MozWifiConnectionInfoEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozWifiConnectionInfoEvent : Event {
  [Throws]
  readonly attribute any network;
  readonly attribute short signalStrength;
  readonly attribute short relSignalStrength;
  readonly attribute long linkSpeed;
  readonly attribute DOMString? ipAddress;
};

dictionary MozWifiConnectionInfoEventInit : EventInit {
  any network = null;
  short signalStrength = 0;
  short relSignalStrength = 0;
  long linkSpeed = 0;
  DOMString ipAddress = "";
};
[Constructor(DOMString type, optional MozWifiStatusChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface MozWifiStatusChangeEvent : Event {
  [Throws]
  readonly attribute any network;
  readonly attribute DOMString? status;
};

dictionary MozWifiStatusChangeEventInit : EventInit {
  any network = null;
  DOMString status = "";
};
interface MutationEvent : Event {
  const unsigned short MODIFICATION = 1;
  const unsigned short ADDITION = 2;
  const unsigned short REMOVAL = 3;

  readonly attribute Node? relatedNode;
  readonly attribute DOMString prevValue;
  readonly attribute DOMString newValue;
  readonly attribute DOMString attrName;
  readonly attribute unsigned short attrChange;

  [Throws]
  void initMutationEvent(DOMString type, boolean canBubble, boolean cancelable, Node? relatedNode, DOMString prevValue, DOMString newValue, DOMString attrName, unsigned short attrChange);
};
interface MutationRecord {
  readonly attribute DOMString type;


  readonly attribute Node? target;
  readonly attribute NodeList addedNodes;
  readonly attribute NodeList removedNodes;
  readonly attribute Node? previousSibling;
  readonly attribute Node? nextSibling;
  readonly attribute DOMString? attributeName;
  readonly attribute DOMString? attributeNamespace;
  readonly attribute DOMString? oldValue;
};

[Constructor(MutationCallback mutationCallback)]
interface MutationObserver {
  [Throws]
  void observe(Node target, optional MutationObserverInit options);
  void disconnect();
  sequence<MutationRecord> takeRecords();
};

callback MutationCallback = void (sequence<MutationRecord> mutations, MutationObserver observer);

dictionary MutationObserverInit {
  boolean childList = false;
  boolean attributes = false;
  boolean characterData = false;
  boolean subtree = false;
  boolean attributeOldValue = false;
  boolean characterDataOldValue = false;
  sequence<DOMString> attributeFilter;
};


interface MozPowerManager;
interface MozWakeLock;


[HeaderFile="Navigator.h", NeedNewResolve]
interface Navigator {

};
Navigator implements NavigatorID;
Navigator implements NavigatorLanguage;
Navigator implements NavigatorOnLine;
Navigator implements NavigatorContentUtils;
Navigator implements NavigatorStorageUtils;

[NoInterfaceObject]
interface NavigatorID {
  readonly attribute DOMString appName;
  [Throws]
  readonly attribute DOMString appVersion;
  [Throws]
  readonly attribute DOMString platform;
  [Throws]
  readonly attribute DOMString userAgent;




  readonly attribute DOMString product;
};

[NoInterfaceObject]
interface NavigatorLanguage {
  readonly attribute DOMString? language;
};

[NoInterfaceObject]
interface NavigatorOnLine {
  readonly attribute boolean onLine;
};

[NoInterfaceObject]
interface NavigatorContentUtils {

  [Throws]
  void registerProtocolHandler(DOMString scheme, DOMString url, DOMString title);
  [Throws]
  void registerContentHandler(DOMString mimeType, DOMString url, DOMString title);





};

[NoInterfaceObject]
interface NavigatorStorageUtils {


};



partial interface Navigator {
  [Throws]
  readonly attribute MimeTypeArray mimeTypes;
  [Throws]
  readonly attribute PluginArray plugins;
};


partial interface Navigator {
  readonly attribute DOMString doNotTrack;
};


[NoInterfaceObject]
interface NavigatorGeolocation {
  [Throws, Pref="geo.enabled"]
  readonly attribute Geolocation geolocation;
};
Navigator implements NavigatorGeolocation;


[NoInterfaceObject]
interface NavigatorBattery {


    [Throws, Func="Navigator::HasBatterySupport"]
    readonly attribute BatteryManager? battery;
};
Navigator implements NavigatorBattery;


partial interface Navigator {




    [Throws]
    void vibrate(unsigned long duration);
    [Throws]
    void vibrate(sequence<unsigned long> pattern);
};



callback interface MozIdleObserver {


  readonly attribute unsigned long time;
  void onidle();
  void onactive();
};


partial interface Navigator {

  [Throws]
  readonly attribute DOMString appCodeName;
  [Throws]
  readonly attribute DOMString oscpu;

  readonly attribute DOMString vendor;

  readonly attribute DOMString vendorSub;

  readonly attribute DOMString productSub;

  readonly attribute boolean cookieEnabled;
  [Throws]
  readonly attribute DOMString buildID;
  [Throws, Func="Navigator::HasPowerSupport"]
  readonly attribute MozPowerManager mozPower;


  [Throws]
  boolean javaEnabled();

  boolean taintEnabled();
  [Throws, Func="Navigator::HasIdleSupport"]
  void addIdleObserver(MozIdleObserver aIdleObserver);
  [Throws, Func="Navigator::HasIdleSupport"]
  void removeIdleObserver(MozIdleObserver aIdleObserver);
  [Throws, Func="Navigator::HasWakeLockSupport"]
  MozWakeLock requestWakeLock(DOMString aTopic);
};


partial interface Navigator {
  [Throws, Pref="device.storage.enabled"]
  DeviceStorage? getDeviceStorage(DOMString type);
  [Throws, Pref="device.storage.enabled"]
  sequence<DeviceStorage> getDeviceStorages(DOMString type);
};


partial interface Navigator {
  [Throws, Func="Navigator::HasDesktopNotificationSupport"]
  readonly attribute DesktopNotificationCenter mozNotification;
};


partial interface Navigator {
  [Throws]
  boolean mozIsLocallyAvailable(DOMString uri, boolean whenOffline);
};


interface MozMobileMessageManager;
partial interface Navigator {
  [Func="Navigator::HasMobileMessageSupport"]
  readonly attribute MozMobileMessageManager? mozMobileMessage;
};


interface MozConnection;
partial interface Navigator {
  [Pref="dom.network.enabled"]
  readonly attribute MozConnection? mozConnection;
};


partial interface Navigator {
  [Throws, Func="Navigator::HasCameraSupport"]
  readonly attribute CameraManager mozCameras;
};



callback systemMessageCallback = void (optional object message);
partial interface Navigator {
  [Throws, Pref="dom.sysmsg.enabled"]
  void mozSetMessageHandler (DOMString type, systemMessageCallback? callback);
  [Throws, Pref="dom.sysmsg.enabled"]
  boolean mozHasPendingMessage (DOMString type);
};


interface MozTelephony;

partial interface Navigator {
  [Throws, Func="Navigator::HasTelephonySupport"]
  readonly attribute MozTelephony? mozTelephony;
};


interface MozMobileConnection;
partial interface Navigator {
  [Throws, Func="Navigator::HasMobileConnectionSupport"]
  readonly attribute MozMobileConnection mozMobileConnection;
};


interface MozCellBroadcast;
partial interface Navigator {
  [Throws, Func="Navigator::HasCellBroadcastSupport"]
  readonly attribute MozCellBroadcast mozCellBroadcast;
};


interface MozVoicemail;
partial interface Navigator {
  [Throws, Func="Navigator::HasVoicemailSupport"]
  readonly attribute MozVoicemail mozVoicemail;
};


interface MozIccManager;
partial interface Navigator {
  [Throws, Func="Navigator::HasIccManagerSupport"]
  readonly attribute MozIccManager? mozIccManager;
};




partial interface Navigator {
  [Throws, Pref="dom.gamepad.enabled"]
  sequence<Gamepad?> getGamepads();
};




interface MozBluetoothManager;
partial interface Navigator {
  [Throws, Func="Navigator::HasBluetoothSupport"]
  readonly attribute MozBluetoothManager mozBluetooth;
};




partial interface Navigator {
  [Throws, Func="Navigator::HasTimeSupport"]
  readonly attribute MozTimeManager mozTime;
};




partial interface Navigator {
  [Throws]
  readonly attribute AudioChannelManager mozAudioChannelManager;
};




callback MozDOMGetUserMediaSuccessCallback = void (nsISupports? value);
callback MozDOMGetUserMediaErrorCallback = void (DOMString error);
interface MozMediaStreamOptions;
partial interface Navigator {
  [Throws, Func="Navigator::HasUserMediaSupport"]
  void mozGetUserMedia(MozMediaStreamOptions? params, MozDOMGetUserMediaSuccessCallback? onsuccess, MozDOMGetUserMediaErrorCallback? onerror);
};


callback MozGetUserMediaDevicesSuccessCallback = void (nsIVariant? devices);
partial interface Navigator {
  [Throws, ChromeOnly]
  void mozGetUserMediaDevices(MozGetUserMediaDevicesSuccessCallback? onsuccess, MozDOMGetUserMediaErrorCallback? onerror);
};
dictionary SocketsDict {
  sequence<DOMString> host;
  sequence<unsigned long> port;
  sequence<boolean> active;
  sequence<unsigned long> tcp;
  sequence<double> socksent;
  sequence<double> sockreceived;
  double sent = 0;
  double received = 0;
};

dictionary HttpConnInfoDict {
  sequence<unsigned long> rtt;
  sequence<unsigned long> ttl;
  sequence<DOMString> protocolVersion;
};

dictionary HalfOpenInfoDict {
  sequence<boolean> speculative;
};

dictionary HttpConnDict {
  sequence<DOMString> host;
  sequence<unsigned long> port;
  sequence<HttpConnInfoDict> active;
  sequence<HttpConnInfoDict> idle;
  sequence<HalfOpenInfoDict> halfOpens;
  sequence<boolean> spdy;
  sequence<boolean> ssl;
};

dictionary WebSocketDict {
  sequence<DOMString> hostport;
  sequence<unsigned long> msgsent;
  sequence<unsigned long> msgreceived;
  sequence<double> sentsize;
  sequence<double> receivedsize;
  sequence<boolean> encrypted;
};

dictionary DNSCacheDict {
  sequence<DOMString> hostname;
  sequence<sequence<DOMString>> hostaddr;
  sequence<DOMString> family;
  sequence<double> expiration;
};
interface Principal;
interface URI;
interface UserDataHandler;

interface Node : EventTarget {
  const unsigned short ELEMENT_NODE = 1;
  const unsigned short ATTRIBUTE_NODE = 2;
  const unsigned short TEXT_NODE = 3;
  const unsigned short CDATA_SECTION_NODE = 4;
  const unsigned short ENTITY_REFERENCE_NODE = 5;
  const unsigned short ENTITY_NODE = 6;
  const unsigned short PROCESSING_INSTRUCTION_NODE = 7;
  const unsigned short COMMENT_NODE = 8;
  const unsigned short DOCUMENT_NODE = 9;
  const unsigned short DOCUMENT_TYPE_NODE = 10;
  const unsigned short DOCUMENT_FRAGMENT_NODE = 11;
  const unsigned short NOTATION_NODE = 12;
  [Constant]
  readonly attribute unsigned short nodeType;
  [Pure]
  readonly attribute DOMString nodeName;

  [Pure]
  readonly attribute DOMString? baseURI;

  [Pure]
  readonly attribute Document? ownerDocument;
  [Pure]
  readonly attribute Node? parentNode;
  [Pure]
  readonly attribute Element? parentElement;
  boolean hasChildNodes();
  [Constant]
  readonly attribute NodeList childNodes;
  [Pure]
  readonly attribute Node? firstChild;
  [Pure]
  readonly attribute Node? lastChild;
  [Pure]
  readonly attribute Node? previousSibling;
  [Pure]
  readonly attribute Node? nextSibling;

  [SetterThrows, Pure]
           attribute DOMString? nodeValue;
  [SetterThrows, Pure]
           attribute DOMString? textContent;
  [Throws]
  Node insertBefore(Node node, Node? child);
  [Throws]
  Node appendChild(Node node);
  [Throws]
  Node replaceChild(Node node, Node child);
  [Throws]
  Node removeChild(Node child);
  void normalize();

  [Throws]
  Node cloneNode(optional boolean deep = true);
  boolean isEqualNode(Node? node);

  const unsigned short DOCUMENT_POSITION_DISCONNECTED = 0x01;
  const unsigned short DOCUMENT_POSITION_PRECEDING = 0x02;
  const unsigned short DOCUMENT_POSITION_FOLLOWING = 0x04;
  const unsigned short DOCUMENT_POSITION_CONTAINS = 0x08;
  const unsigned short DOCUMENT_POSITION_CONTAINED_BY = 0x10;
  const unsigned short DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
  unsigned short compareDocumentPosition(Node other);
  boolean contains(Node? other);

  DOMString? lookupPrefix(DOMString? namespace);
  DOMString? lookupNamespaceURI(DOMString? prefix);
  boolean isDefaultNamespace(DOMString? namespace);





  [Constant]
  readonly attribute DOMString? namespaceURI;
  [Constant]
  readonly attribute DOMString? prefix;
  [Constant]
  readonly attribute DOMString? localName;

  boolean hasAttributes();
  [Throws, Func="IsChromeOrXBL"]
  any setUserData(DOMString key, any data, UserDataHandler? handler);
  [Throws, Func="IsChromeOrXBL"]
  any getUserData(DOMString key);
  [ChromeOnly]
  readonly attribute Principal nodePrincipal;
  [ChromeOnly]
  readonly attribute URI? baseURIObject;
};
callback interface NodeFilter {

  const unsigned short FILTER_ACCEPT = 1;
  const unsigned short FILTER_REJECT = 2;
  const unsigned short FILTER_SKIP = 3;


  const unsigned long SHOW_ALL = 0xFFFFFFFF;
  const unsigned long SHOW_ELEMENT = 0x1;
  const unsigned long SHOW_ATTRIBUTE = 0x2;
  const unsigned long SHOW_TEXT = 0x4;
  const unsigned long SHOW_CDATA_SECTION = 0x8;
  const unsigned long SHOW_ENTITY_REFERENCE = 0x10;
  const unsigned long SHOW_ENTITY = 0x20;
  const unsigned long SHOW_PROCESSING_INSTRUCTION = 0x40;
  const unsigned long SHOW_COMMENT = 0x80;
  const unsigned long SHOW_DOCUMENT = 0x100;
  const unsigned long SHOW_DOCUMENT_TYPE = 0x200;
  const unsigned long SHOW_DOCUMENT_FRAGMENT = 0x400;
  const unsigned long SHOW_NOTATION = 0x800;

  unsigned short acceptNode(Node node);
};
interface NodeIterator {
  [Constant]
  readonly attribute Node root;
  [Pure]
  readonly attribute Node? referenceNode;
  [Pure]
  readonly attribute boolean pointerBeforeReferenceNode;
  [Constant]
  readonly attribute unsigned long whatToShow;
  [Constant]
  readonly attribute NodeFilter? filter;

  [Throws]
  Node? nextNode();
  [Throws]
  Node? previousNode();

  void detach();
};
interface NodeList {
  getter Node? item(unsigned long index);
  readonly attribute unsigned long length;
};
[PrefControlled, Constructor(DOMString title, optional NotificationOptions options)]
interface Notification : EventTarget {
  [GetterThrows]
  static readonly attribute NotificationPermission permission;

  [Throws]
  static void requestPermission(optional NotificationPermissionCallback permissionCallback);

  [SetterThrows]
  attribute EventHandler onclick;

  [SetterThrows]
  attribute EventHandler onshow;

  [SetterThrows]
  attribute EventHandler onerror;

  [SetterThrows]
  attribute EventHandler onclose;

  void close();
};

dictionary NotificationOptions {
  NotificationDirection dir = "auto";
  DOMString lang = "";
  DOMString body = "";
  DOMString tag;
  DOMString icon = "";
};

enum NotificationPermission {
  "default",
  "denied",
  "granted"
};

callback NotificationPermissionCallback = void (NotificationPermission permission);

enum NotificationDirection {
  "auto",
  "ltr",
  "rtl"
};
interface NotifyAudioAvailableEvent : Event {
  [Throws]
  readonly attribute Float32Array frameBuffer;

  readonly attribute float time;

  [Throws]
  void initAudioAvailableEvent(DOMString type, boolean canBubble, boolean cancelable, sequence<float>? frameBuffer, unsigned long frameBufferLength, float time, boolean allowAudioData);
};
interface NotifyPaintEvent : Event {
  readonly attribute ClientRectList clientRects;

  readonly attribute ClientRect boundingClientRect;

  readonly attribute PaintRequestList paintRequests;
};
[PrefControlled]
interface OfflineAudioCompletionEvent : Event {

    readonly attribute AudioBuffer renderedBuffer;

};
callback OfflineRenderSuccessCallback = void (AudioBuffer renderedData);

[Constructor(unsigned long numberOfChannels, unsigned long length, float sampleRate), PrefControlled]
interface OfflineAudioContext : AudioContext {

    void startRendering();

    [SetterThrows]
    attribute EventHandler oncomplete;

};
interface OfflineResourceList : EventTarget {
  const unsigned short UNCACHED = 0;


  const unsigned short IDLE = 1;


  const unsigned short CHECKING = 2;


  const unsigned short DOWNLOADING = 3;


  const unsigned short UPDATEREADY = 4;


  const unsigned short OBSOLETE = 5;

  [Throws]
  readonly attribute unsigned short status;
  [Throws]
  void update();
  [Throws]
  void swapCache();


  [SetterThrows]
  attribute EventHandler onchecking;
  [SetterThrows]
  attribute EventHandler onerror;
  [SetterThrows]
  attribute EventHandler onnoupdate;
  [SetterThrows]
  attribute EventHandler ondownloading;
  [SetterThrows]
  attribute EventHandler onprogress;
  [SetterThrows]
  attribute EventHandler onupdateready;
  [SetterThrows]
  attribute EventHandler oncached;
  [SetterThrows]
  attribute EventHandler onobsolete;
};


partial interface OfflineResourceList {
  [Throws]
  readonly attribute DOMStringList mozItems;
  [Throws]
  boolean mozHasItem(DOMString uri);
  [Throws]
  readonly attribute unsigned long mozLength;
  [Throws]
  getter DOMString mozItem(unsigned long index);
  [Throws]
  void mozAdd(DOMString uri);
  [Throws]
  void mozRemove(DOMString uri);
};
[Constructor(DOMString type, optional PageTransitionEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface PageTransitionEvent : Event {
  readonly attribute boolean persisted;


  [Throws]
  void initPageTransitionEvent(DOMString type, boolean canBubble, boolean cancelable, boolean persisted);
};

dictionary PageTransitionEventInit : EventInit {
  boolean persisted = false;
};
interface PaintRequest {
  readonly attribute ClientRect clientRect;
  readonly attribute DOMString reason;
};
interface PaintRequestList {
  readonly attribute unsigned long length;
  getter PaintRequest? item(unsigned long index);
};
enum PanningModelType {

  "0",
  "1",
  "equalpower",
  "HRTF"
};

enum DistanceModelType {

  "0",
  "1",
  "2",
  "linear",
  "inverse",
  "exponential"
};

[PrefControlled]
interface PannerNode : AudioNode {


    attribute PanningModelType panningModel;


    void setPosition(double x, double y, double z);
    void setOrientation(double x, double y, double z);
    void setVelocity(double x, double y, double z);


    attribute DistanceModelType distanceModel;
    attribute double refDistance;
    attribute double maxDistance;
    attribute double rolloffFactor;


    attribute double coneInnerAngle;
    attribute double coneOuterAngle;
    attribute double coneOuterGain;

};
[PrefControlled]
partial interface PannerNode {
    [Pref="media.webaudio.legacy.PannerNode"]
    const unsigned short EQUALPOWER = 0;
    [Pref="media.webaudio.legacy.PannerNode"]
    const unsigned short HRTF = 1;

    [Pref="media.webaudio.legacy.PannerNode"]
    const unsigned short LINEAR_DISTANCE = 0;
    [Pref="media.webaudio.legacy.PannerNode"]
    const unsigned short INVERSE_DISTANCE = 1;
    [Pref="media.webaudio.legacy.PannerNode"]
    const unsigned short EXPONENTIAL_DISTANCE = 2;
};
[NoInterfaceObject]
interface ParentNode {
  [Constant]
  readonly attribute HTMLCollection children;
  [Pure]
  readonly attribute Element? firstElementChild;
  [Pure]
  readonly attribute Element? lastElementChild;
  [Pure]
  readonly attribute unsigned long childElementCount;




};
typedef double DOMHighResTimeStamp;

interface Performance {
  DOMHighResTimeStamp now();

  [Constant]
  readonly attribute PerformanceTiming timing;
  [Constant]
  readonly attribute PerformanceNavigation navigation;

  jsonifier;
};
interface PerformanceNavigation {
  const unsigned short TYPE_NAVIGATE = 0;
  const unsigned short TYPE_RELOAD = 1;
  const unsigned short TYPE_BACK_FORWARD = 2;
  const unsigned short TYPE_RESERVED = 255;

  readonly attribute unsigned short type;
  readonly attribute unsigned short redirectCount;

  jsonifier;
};
interface PerformanceTiming {
  readonly attribute unsigned long long navigationStart;
  readonly attribute unsigned long long unloadEventStart;
  readonly attribute unsigned long long unloadEventEnd;
  readonly attribute unsigned long long redirectStart;
  readonly attribute unsigned long long redirectEnd;
  readonly attribute unsigned long long fetchStart;
  readonly attribute unsigned long long domainLookupStart;
  readonly attribute unsigned long long domainLookupEnd;
  readonly attribute unsigned long long connectStart;
  readonly attribute unsigned long long connectEnd;


  readonly attribute unsigned long long requestStart;
  readonly attribute unsigned long long responseStart;
  readonly attribute unsigned long long responseEnd;
  readonly attribute unsigned long long domLoading;
  readonly attribute unsigned long long domInteractive;
  readonly attribute unsigned long long domContentLoadedEventStart;
  readonly attribute unsigned long long domContentLoadedEventEnd;
  readonly attribute unsigned long long domComplete;
  readonly attribute unsigned long long loadEventStart;
  readonly attribute unsigned long long loadEventEnd;

  jsonifier;
};
[PrefControlled]
interface PeriodicWave {

};
interface Plugin {
  readonly attribute DOMString description;
  readonly attribute DOMString filename;
  readonly attribute DOMString version;
  readonly attribute DOMString name;

  readonly attribute unsigned long length;
  getter MimeType? item(unsigned long index);
  getter MimeType? namedItem(DOMString name);
};
interface PluginArray {
  readonly attribute unsigned long length;

  getter Plugin? item(unsigned long index);
  getter Plugin? namedItem(DOMString name);

  void refresh(optional boolean reloadDocuments = false);
};
[Constructor(DOMString type, optional PopStateEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface PopStateEvent : Event {
  [Throws]
  readonly attribute any state;


  [Throws]
  void initPopStateEvent(DOMString type, boolean canBubble, boolean cancelable, any state);
};

dictionary PopStateEventInit : EventInit {
  any state = null;
};
interface Window;
interface URI;

[Constructor(DOMString type, optional PopupBlockedEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface PopupBlockedEvent : Event {
  readonly attribute Window? requestingWindow;
  readonly attribute URI? popupWindowURI;
  readonly attribute DOMString? popupWindowName;
  readonly attribute DOMString? popupWindowFeatures;

  [Throws]
  void initPopupBlockedEvent(DOMString type, boolean canBubble, boolean cancelable, Window? requestingWindow, URI? popupWindowURI, DOMString? popupWindowName, DOMString? popupWindowFeatures);
};

dictionary PopupBlockedEventInit : EventInit {
  Window? requestingWindow = null;
  URI? popupWindowURI = null;
  DOMString popupWindowName = "";
  DOMString popupWindowFeatures = "";
};
[NoInterfaceObject]
interface Position {
  readonly attribute Coordinates coords;
  readonly attribute DOMTimeStamp timestamp;
};
[NoInterfaceObject]
interface PositionError {
  const unsigned short PERMISSION_DENIED = 1;
  const unsigned short POSITION_UNAVAILABLE = 2;
  const unsigned short TIMEOUT = 3;
  readonly attribute unsigned short code;
  readonly attribute DOMString message;
};
interface ProcessingInstruction : CharacterData {
  readonly attribute DOMString target;
};
[Constructor(DOMString type, optional ProgressEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface ProgressEvent : Event {
  readonly attribute boolean lengthComputable;
  readonly attribute unsigned long long loaded;
  readonly attribute unsigned long long total;
};

dictionary ProgressEventInit : EventInit {
  boolean lengthComputable = false;
  unsigned long long loaded = 0;
  unsigned long long total = 0;
};
interface PromiseResolver {

  void resolve(optional any value);
  void reject(optional any value);
};

callback PromiseInit = void (PromiseResolver resolver);
callback AnyCallback = any (optional any value);

[PrefControlled, Constructor(PromiseInit init)]
interface Promise {

  [Creator, Throws]
  static Promise resolve(any value);
  [Creator, Throws]
  static Promise reject(any value);

  [Creator]
  Promise then([TreatUndefinedAs=Missing] optional AnyCallback fulfillCallback, [TreatUndefinedAs=Missing] optional AnyCallback rejectCallback);

  [Creator]
  Promise catch([TreatUndefinedAs=Missing] optional AnyCallback rejectCallback);
};
[Constructor]
interface Range {
  [Throws]
  readonly attribute Node startContainer;
  [Throws]
  readonly attribute unsigned long startOffset;
  [Throws]
  readonly attribute Node endContainer;
  [Throws]
  readonly attribute unsigned long endOffset;
  readonly attribute boolean collapsed;
  [Throws]
  readonly attribute Node commonAncestorContainer;

  [Throws]
  void setStart(Node refNode, unsigned long offset);
  [Throws]
  void setEnd(Node refNode, unsigned long offset);
  [Throws]
  void setStartBefore(Node refNode);
  [Throws]
  void setStartAfter(Node refNode);
  [Throws]
  void setEndBefore(Node refNode);
  [Throws]
  void setEndAfter(Node refNode);
  void collapse(optional boolean toStart = false);
  [Throws]
  void selectNode(Node refNode);
  [Throws]
  void selectNodeContents(Node refNode);

  const unsigned short START_TO_START = 0;
  const unsigned short START_TO_END = 1;
  const unsigned short END_TO_END = 2;
  const unsigned short END_TO_START = 3;
  [Throws]
  short compareBoundaryPoints(unsigned short how, Range sourceRange);
  [Throws]
  void deleteContents();
  [Throws]
  DocumentFragment extractContents();
  [Throws]
  DocumentFragment cloneContents();
  [Throws]
  void insertNode(Node node);
  [Throws]
  void surroundContents(Node newParent);

  Range cloneRange();
  void detach();

  [Throws]
  boolean isPointInRange(Node node, unsigned long offset);
  [Throws]
  short comparePoint(Node node, unsigned long offset);

  [Throws]
  boolean intersectsNode(Node node);

  stringifier;
};


partial interface Range {
  [Throws]
  DocumentFragment createContextualFragment(DOMString fragment);
};


partial interface Range {
  ClientRectList? getClientRects();
  ClientRect getBoundingClientRect();
};
[Constructor(DOMString type, optional RecordErrorEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface RecordErrorEvent : Event {
  readonly attribute DOMString name;
};

dictionary RecordErrorEventInit : EventInit {
  DOMString name = "";
};
interface Rect {
  readonly attribute CSSPrimitiveValue top;
  readonly attribute CSSPrimitiveValue right;
  readonly attribute CSSPrimitiveValue bottom;
  readonly attribute CSSPrimitiveValue left;
};
interface RGBColor {
  readonly attribute CSSPrimitiveValue red;
  readonly attribute CSSPrimitiveValue green;
  readonly attribute CSSPrimitiveValue blue;


  readonly attribute CSSPrimitiveValue alpha;
};
dictionary RTCIceServer {
    DOMString url;
    DOMString? credential = null;
    DOMString? username = null;
};

dictionary RTCConfiguration {
    sequence<RTCIceServer> iceServers;
};
interface RTCDataChannel;

dictionary RTCDataChannelEventInit : EventInit {
    RTCDataChannel? channel = null;
};

[Pref="media.peerconnection.enabled", JSImplementation="@mozilla.org/dom/datachannelevent;1", Constructor(DOMString type, optional RTCDataChannelEventInit eventInitDict)]
interface RTCDataChannelEvent : Event {
  readonly attribute RTCDataChannel? channel;
};
dictionary RTCIceCandidateInit {
  DOMString? candidate = null;
  DOMString? sdpMid = null;
  unsigned short sdpMLineIndex;
};

[Pref="media.peerconnection.enabled", JSImplementation="@mozilla.org/dom/rtcicecandidate;1", Constructor(optional RTCIceCandidateInit candidateInitDict)]
interface mozRTCIceCandidate {
  attribute DOMString? candidate;
  attribute DOMString? sdpMid;
  attribute unsigned short? sdpMLineIndex;




};
callback RTCSessionDescriptionCallback = void (mozRTCSessionDescription sdp);
callback RTCPeerConnectionErrorCallback = void (DOMString errorInformation);
callback VoidFunction = void ();

enum RTCSignalingState {
    "stable",
	"have-local-offer",
	"have-remote-offer",
	"have-local-pranswer",
	"have-remote-pranswer",
	"closed"
};

enum RTCIceGatheringState {
    "new",
	"gathering",
	"complete"
};

enum RTCIceConnectionState {
    "new",
	"checking",
	"connected",
	"completed",
	"failed",
	"disconnected",
	"closed"
};

dictionary RTCDataChannelInit {
  boolean ordered = true;
  unsigned short? maxRetransmitTime = null;
  unsigned short? maxRetransmits = null;
  DOMString protocol = "";
  boolean negotiated = false;
  unsigned short? id = null;


  boolean outOfOrderAllowed;
  unsigned short maxRetransmitNum;
  boolean preset;
  unsigned short stream;
};

interface RTCDataChannel;

[Pref="media.peerconnection.enabled", JSImplementation="@mozilla.org/dom/peerconnection;1", Constructor (optional RTCConfiguration configuration, optional object? constraints)]

interface mozRTCPeerConnection : EventTarget {
  void createOffer (RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback? failureCallback, optional object? constraints);
  void createAnswer (RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback? failureCallback, optional object? constraints);
  void setLocalDescription (mozRTCSessionDescription description, optional VoidFunction successCallback, optional RTCPeerConnectionErrorCallback failureCallback);
  void setRemoteDescription (mozRTCSessionDescription description, optional VoidFunction successCallback, optional RTCPeerConnectionErrorCallback failureCallback);
  readonly attribute mozRTCSessionDescription? localDescription;
  readonly attribute mozRTCSessionDescription? remoteDescription;
  readonly attribute RTCSignalingState signalingState;
  void updateIce (optional RTCConfiguration configuration, optional object? constraints);
  void addIceCandidate (mozRTCIceCandidate candidate, optional VoidFunction successCallback, optional RTCPeerConnectionErrorCallback failureCallback);
  readonly attribute RTCIceGatheringState iceGatheringState;
  readonly attribute RTCIceConnectionState iceConnectionState;
  sequence<MediaStream> getLocalStreams ();
  sequence<MediaStream> getRemoteStreams ();
  MediaStream? getStreamById (DOMString streamId);
  void addStream (MediaStream stream, optional object? constraints);
  void removeStream (MediaStream stream);
  void close ();
  attribute EventHandler onnegotiationneeded;
  attribute EventHandler onicecandidate;
  attribute EventHandler onsignalingstatechange;
  attribute EventHandler onaddstream;
  attribute EventHandler onremovestream;
  attribute EventHandler oniceconnectionstatechange;
};


partial interface mozRTCPeerConnection {

  attribute RTCPeerConnectionErrorCallback onicechange;
  attribute RTCPeerConnectionErrorCallback ongatheringchange;


  readonly attribute object localStreams;
  readonly attribute object remoteStreams;
  readonly attribute DOMString readyState;


  RTCDataChannel createDataChannel (DOMString label, optional RTCDataChannelInit dataChannelDict);
  attribute EventHandler ondatachannel;
  attribute EventHandler onconnection;
  attribute EventHandler onclosedconnection;
};
dictionary RTCPeerConnectionIceEventInit : EventInit {
  mozRTCIceCandidate? candidate = null;
};

[Pref="media.peerconnection.enabled", JSImplementation="@mozilla.org/dom/rtcpeerconnectioniceevent;1", Constructor(DOMString type, optional RTCPeerConnectionIceEventInit eventInitDict)]
interface RTCPeerConnectionIceEvent : Event {
  readonly attribute mozRTCIceCandidate? candidate;
};
enum RTCSdpType {
  "offer",
  "pranswer",
  "answer"
};

dictionary RTCSessionDescriptionInit {
  RTCSdpType? type = null;
  DOMString? sdp = null;
};

[Pref="media.peerconnection.enabled", JSImplementation="@mozilla.org/dom/rtcsessiondescription;1", Constructor(optional RTCSessionDescriptionInit descriptionInitDict)]
interface mozRTCSessionDescription {
  attribute RTCSdpType? type;
  attribute DOMString? sdp;



  object toJSON();
};
interface Screen : EventTarget {


  [Throws]
  readonly attribute long availWidth;
  [Throws]
  readonly attribute long availHeight;
  [Throws]
  readonly attribute long width;
  [Throws]
  readonly attribute long height;
  [Throws]
  readonly attribute long colorDepth;
  [Throws]
  readonly attribute long pixelDepth;

  [Throws]
  readonly attribute long top;
  [Throws]
  readonly attribute long left;
  [Throws]
  readonly attribute long availTop;
  [Throws]
  readonly attribute long availLeft;
  readonly attribute DOMString mozOrientation;

  [SetterThrows]
  attribute EventHandler onmozorientationchange;
  [Throws]
  boolean mozLockOrientation(DOMString orientation);
  [Throws]
  boolean mozLockOrientation(sequence<DOMString> orientation);
  void mozUnlockOrientation();
};
[PrefControlled]
interface ScriptProcessorNode : AudioNode {

    [SetterThrows]
    attribute EventHandler onaudioprocess;

    readonly attribute long bufferSize;

};
interface WindowProxy;

interface ScrollAreaEvent : UIEvent {
  readonly attribute float x;
  readonly attribute float y;
  readonly attribute float width;
  readonly attribute float height;

  [Throws]
  void initScrollAreaEvent(DOMString type, boolean canBubble, boolean cancelable, WindowProxy? view, long detail, float x, float y, float width, float height);
};
[JSImplementation="@mozilla.org/settingsLock;1", Pref="dom.mozSettings.enabled"]
interface SettingsLock {

  readonly attribute boolean closed;


  DOMRequest set(object settings);


  DOMRequest get(DOMString name);

  DOMRequest clear();
};

dictionary SettingChange {
  DOMString settingName;
  DOMString settingValue;
};

callback SettingChangeCallback = void (SettingChange setting);

[JSImplementation="@mozilla.org/settingsManager;1", NavigatorProperty="mozSettings", Pref="dom.mozSettings.enabled"]
interface SettingsManager : EventTarget {
  SettingsLock createLock();

  void addObserver(DOMString name, SettingChangeCallback callback);
  void removeObserver(DOMString name, SettingChangeCallback callback);

  attribute EventHandler onsettingchange;
};
interface WindowProxy;

interface SimpleGestureEvent : MouseEvent {
  const unsigned long DIRECTION_UP = 1;
  const unsigned long DIRECTION_DOWN = 2;
  const unsigned long DIRECTION_LEFT = 4;
  const unsigned long DIRECTION_RIGHT = 8;

  const unsigned long ROTATION_COUNTERCLOCKWISE = 1;
  const unsigned long ROTATION_CLOCKWISE = 2;

  attribute unsigned long allowedDirections;

  readonly attribute unsigned long direction;

  readonly attribute double delta;

  readonly attribute unsigned long clickCount;

  [Throws]
  void initSimpleGestureEvent(DOMString typeArg, boolean canBubbleArg, boolean cancelableArg, WindowProxy? viewArg, long detailArg, long screenXArg, long screenYArg, long clientXArg, long clientYArg, boolean ctrlKeyArg, boolean altKeyArg, boolean shiftKeyArg, boolean metaKeyArg, unsigned short buttonArg, EventTarget? relatedTargetArg, unsigned long allowedDirectionsArg, unsigned long directionArg, double deltaArg, unsigned long clickCount);
};
[Constructor(DOMString type, optional SmartCardEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface SmartCardEvent : Event {
  readonly attribute DOMString? tokenName;
};

dictionary SmartCardEventInit : EventInit {
  DOMString tokenName = "";
};
enum SourceBufferAppendMode {
    "segments",
	"sequence"
};

[Pref="media.mediasource.enabled"]
interface SourceBuffer : EventTarget {
  [SetterThrows]
  attribute SourceBufferAppendMode mode;
  readonly attribute boolean updating;
  [Creator, Throws]
  readonly attribute TimeRanges buffered;
  [SetterThrows]
  attribute double timestampOffset;



  [SetterThrows]
  attribute double appendWindowStart;
  [SetterThrows]
  attribute unrestricted double appendWindowEnd;
  [Throws]
  void appendBuffer(ArrayBuffer data);
  [Throws]
  void appendBuffer(ArrayBufferView data);


  [Throws]
  void abort();
  [Throws]
  void remove(double start, double end);
};
[Pref="media.mediasource.enabled"]
interface SourceBufferList : EventTarget {
  readonly attribute unsigned long length;
  getter SourceBuffer (unsigned long index);
};
[Constructor, PrefControlled]
interface SpeechGrammar {
    [Throws]
    attribute DOMString src;
    [Throws]
    attribute float weight;
};
[PrefControlled]
interface SpeechGrammarList {
    readonly attribute unsigned long length;
    [Throws]
    getter SpeechGrammar item(unsigned long index);
    [Throws]
    void addFromURI(DOMString src, optional float weight);
    [Throws]
    void addFromString(DOMString string, optional float weight);
};
[Constructor, PrefControlled]
interface SpeechRecognition : EventTarget {

    [Throws]
    attribute SpeechGrammarList grammars;
    [Throws]
    attribute DOMString lang;
    [Throws]
    attribute boolean continuous;
    [Throws]
    attribute boolean interimResults;
    [Throws]
    attribute unsigned long maxAlternatives;
    [Throws]
    attribute DOMString serviceURI;


    [Throws]
    void start();
    void stop();
    void abort();


    [SetterThrows]
    attribute EventHandler onaudiostart;
    [SetterThrows]
    attribute EventHandler onsoundstart;
    [SetterThrows]
    attribute EventHandler onspeechstart;
    [SetterThrows]
    attribute EventHandler onspeechend;
    [SetterThrows]
    attribute EventHandler onsoundend;
    [SetterThrows]
    attribute EventHandler onaudioend;
    [SetterThrows]
    attribute EventHandler onresult;
    [SetterThrows]
    attribute EventHandler onnomatch;
    [SetterThrows]
    attribute EventHandler onerror;
    [SetterThrows]
    attribute EventHandler onstart;
    [SetterThrows]
    attribute EventHandler onend;
};
[PrefControlled]
interface SpeechRecognitionAlternative {
    readonly attribute DOMString transcript;
    readonly attribute float confidence;
};
enum SpeechRecognitionErrorCode {
  "no-speech",
  "aborted",
  "audio-capture",
  "network",
  "not-allowed",
  "service-not-allowed",
  "bad-grammar",
  "language-not-supported"
};

[Constructor(DOMString type, optional SpeechRecognitionErrorInit eventInitDict)]
interface SpeechRecognitionError : Event {
  readonly attribute SpeechRecognitionErrorCode error;
  readonly attribute DOMString? message;
};

dictionary SpeechRecognitionErrorInit : EventInit {
  SpeechRecognitionErrorCode error = "no-speech";
  DOMString message = "";
};
interface nsISupports;

[Constructor(DOMString type, optional SpeechRecognitionEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface SpeechRecognitionEvent : Event {
  readonly attribute unsigned long resultIndex;
  readonly attribute nsISupports? results;
  readonly attribute DOMString? interpretation;
  readonly attribute Document? emma;
};

dictionary SpeechRecognitionEventInit : EventInit {
  unsigned long resultIndex = 0;
  nsISupports? results = null;
  DOMString interpretation = "";
  Document? emma = null;
};
[PrefControlled]
interface SpeechRecognitionResult {
    readonly attribute unsigned long length;
    getter SpeechRecognitionAlternative item(unsigned long index);
    readonly attribute boolean final;
};
[PrefControlled]
interface SpeechRecognitionResultList {
    readonly attribute unsigned long length;
    getter SpeechRecognitionResult item(unsigned long index);
};
[PrefControlled]
interface SpeechSynthesis {
  readonly attribute boolean pending;
  readonly attribute boolean speaking;
  readonly attribute boolean paused;

  void speak(SpeechSynthesisUtterance utterance);
  void cancel();
  void pause();
  void resume();
  sequence<SpeechSynthesisVoice> getVoices();
};
[Constructor(DOMString type, optional SpeechSynthesisEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface SpeechSynthesisEvent : Event {
  readonly attribute unsigned long charIndex;
  readonly attribute float elapsedTime;
  readonly attribute DOMString? name;
};

dictionary SpeechSynthesisEventInit : EventInit {
  unsigned long charIndex = 0;
  float elapsedTime = 0;
  DOMString name = "";
};
[PrefControlled, Constructor, Constructor(DOMString text)]
interface SpeechSynthesisUtterance : EventTarget {
  attribute DOMString text;
  attribute DOMString lang;
  attribute SpeechSynthesisVoice? voice;
  attribute float volume;
  attribute float rate;
  attribute float pitch;

  [SetterThrows]
  attribute EventHandler onstart;
  [SetterThrows]
  attribute EventHandler onend;
  [SetterThrows]
  attribute EventHandler onerror;
  [SetterThrows]
  attribute EventHandler onpause;
  [SetterThrows]
  attribute EventHandler onresume;
  [SetterThrows]
  attribute EventHandler onmark;
  [SetterThrows]
  attribute EventHandler onboundary;
};
[PrefControlled]
interface SpeechSynthesisVoice {
  readonly attribute DOMString voiceURI;
  readonly attribute DOMString name;
  readonly attribute DOMString lang;
  readonly attribute boolean localService;
  readonly attribute boolean default;
};
interface Storage;

[Constructor(DOMString type, optional StorageEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface StorageEvent : Event {
  readonly attribute DOMString? key;
  readonly attribute DOMString? oldValue;
  readonly attribute DOMString? newValue;
  readonly attribute DOMString? url;
  readonly attribute Storage? storageArea;


  [Throws]
  void initStorageEvent(DOMString type, boolean canBubble, boolean cancelable, DOMString? key, DOMString? oldValue, DOMString? newValue, DOMString? url, Storage? storageArea);
};

dictionary StorageEventInit : EventInit {
  DOMString? key = null;
  DOMString? oldValue = null;
  DOMString? newValue = null;
  DOMString url = "";
  Storage? storageArea = null;
};
interface CSSRule;

[Constructor(DOMString type, optional StyleRuleChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface StyleRuleChangeEvent : Event {
  readonly attribute CSSStyleSheet? stylesheet;
  readonly attribute CSSRule? rule;
};

dictionary StyleRuleChangeEventInit : EventInit {
  CSSStyleSheet? stylesheet = null;
  CSSRule? rule = null;
};
interface CSSRule;
interface MediaList;

interface StyleSheet {
  [Constant]
  readonly attribute DOMString type;
  [Constant]
  readonly attribute DOMString? href;


  [Pure]
  readonly attribute Node? ownerNode;
  [Pure]
  readonly attribute StyleSheet? parentStyleSheet;
  [Pure]
  readonly attribute DOMString? title;
  [Constant]
  readonly attribute MediaList media;
  [Pure]
  attribute boolean disabled;
};
[Constructor(DOMString type, optional StyleSheetApplicableStateChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface StyleSheetApplicableStateChangeEvent : Event {
  readonly attribute CSSStyleSheet? stylesheet;
  readonly attribute boolean applicable;
};

dictionary StyleSheetApplicableStateChangeEventInit : EventInit {
  CSSStyleSheet? stylesheet = null;
  boolean applicable = false;
};
[Constructor(DOMString type, optional StyleSheetChangeEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface StyleSheetChangeEvent : Event {
  readonly attribute CSSStyleSheet? stylesheet;
  readonly attribute boolean documentSheet;
};

dictionary StyleSheetChangeEventInit : EventInit {
  CSSStyleSheet? stylesheet = null;
  boolean documentSheet = false;
};
interface SVGAElement : SVGGraphicsElement {
  readonly attribute SVGAnimatedString target;

  [SetterThrows]
  attribute DOMString download;
};

SVGAElement implements SVGURIReference;
interface SVGAltGlyphElement : SVGTextPositioningElement {
  [SetterThrows]
  attribute DOMString glyphRef;
  [SetterThrows]
  attribute DOMString format;
};

SVGAltGlyphElement implements SVGURIReference;
interface SVGAngle {


  const unsigned short SVG_ANGLETYPE_UNKNOWN = 0;
  const unsigned short SVG_ANGLETYPE_UNSPECIFIED = 1;
  const unsigned short SVG_ANGLETYPE_DEG = 2;
  const unsigned short SVG_ANGLETYPE_RAD = 3;
  const unsigned short SVG_ANGLETYPE_GRAD = 4;

  readonly attribute unsigned short unitType;
           [SetterThrows]
           attribute float value;
           [SetterThrows]
           attribute float valueInSpecifiedUnits;
           [SetterThrows]
           attribute DOMString valueAsString;

  [Throws]
  void newValueSpecifiedUnits(unsigned short unitType, float valueInSpecifiedUnits);
  [Throws]
  void convertToSpecifiedUnits(unsigned short unitType);
};
interface SVGAnimatedAngle {
  [Constant]
  readonly attribute SVGAngle baseVal;
  [Constant]
  readonly attribute SVGAngle animVal;
};
interface SVGAnimatedBoolean {
           attribute boolean baseVal;
  readonly attribute boolean animVal;
};
interface SVGAnimatedEnumeration {
  [SetterThrows]
           attribute unsigned short baseVal;
  readonly attribute unsigned short animVal;
};
interface SVGAnimatedInteger {
           attribute long baseVal;
  readonly attribute long animVal;
};
interface SVGLength;

interface SVGAnimatedLength {
  [Constant]
  readonly attribute SVGLength baseVal;
  [Constant]
  readonly attribute SVGLength animVal;
};
interface SVGAnimatedLengthList {
  [Constant]
  readonly attribute SVGLengthList baseVal;
  [Constant]
  readonly attribute SVGLengthList animVal;
};
interface SVGAnimatedNumber {
           attribute float baseVal;
  readonly attribute float animVal;
};
interface SVGAnimatedNumberList {
  [Constant]
  readonly attribute SVGNumberList baseVal;
  [Constant]
  readonly attribute SVGNumberList animVal;
};
[NoInterfaceObject]
interface SVGAnimatedPathData {
  readonly attribute SVGPathSegList pathSegList;

  readonly attribute SVGPathSegList animatedPathSegList;

};
[NoInterfaceObject]
interface SVGAnimatedPoints {
  [Constant]
  readonly attribute SVGPointList points;
  [Constant]
  readonly attribute SVGPointList animatedPoints;
};
interface SVGAnimatedPreserveAspectRatio {
  [Constant]
  readonly attribute SVGPreserveAspectRatio baseVal;
  [Constant]
  readonly attribute SVGPreserveAspectRatio animVal;
};
interface SVGAnimatedRect {
  readonly attribute SVGRect? baseVal;
  readonly attribute SVGRect? animVal;
};
interface SVGAnimatedString {
           attribute DOMString baseVal;
  readonly attribute DOMString animVal;
};
interface SVGAnimatedTransformList {
  [Constant]
  readonly attribute SVGTransformList baseVal;
  [Constant]
  readonly attribute SVGTransformList animVal;
};
interface SVGAnimateElement : SVGAnimationElement {
};
interface SVGAnimateMotionElement : SVGAnimationElement {
};
interface SVGAnimateTransformElement : SVGAnimationElement {
};
interface SVGAnimationElement : SVGElement {

  readonly attribute SVGElement? targetElement;

  [Throws]
  float getStartTime();
  float getCurrentTime();
  [Throws]
  float getSimpleDuration();

  [Throws]
  void beginElement();
  [Throws]
  void beginElementAt(float offset);
  [Throws]
  void endElement();
  [Throws]
  void endElementAt(float offset);
};

SVGAnimationElement implements SVGTests;
interface SVGCircleElement : SVGGraphicsElement {
  [Constant]
  readonly attribute SVGAnimatedLength cx;
  [Constant]
  readonly attribute SVGAnimatedLength cy;
  [Constant]
  readonly attribute SVGAnimatedLength r;
};
interface SVGClipPathElement : SVGElement {
  readonly attribute SVGAnimatedEnumeration clipPathUnits;
  readonly attribute SVGAnimatedTransformList transform;
};

SVGClipPathElement implements SVGUnitTypes;
interface SVGComponentTransferFunctionElement : SVGElement {

  const unsigned short SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0;
  const unsigned short SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1;
  const unsigned short SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2;
  const unsigned short SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3;
  const unsigned short SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4;
  const unsigned short SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5;

  readonly attribute SVGAnimatedEnumeration type;
  readonly attribute SVGAnimatedNumberList tableValues;
  readonly attribute SVGAnimatedNumber slope;
  readonly attribute SVGAnimatedNumber intercept;
  readonly attribute SVGAnimatedNumber amplitude;
  readonly attribute SVGAnimatedNumber exponent;
  readonly attribute SVGAnimatedNumber offset;
};
interface SVGDefsElement : SVGGraphicsElement {
};
interface SVGDescElement : SVGElement {
};
interface SVGDocument : Document {
  [Throws]
  readonly attribute DOMString domain;
  [Throws]
  readonly attribute SVGElement? rootElement;
};
interface SVGElement : Element {
           attribute DOMString id;
  readonly attribute SVGAnimatedString className;
  [PutForwards=cssText, Constant]
  readonly attribute CSSStyleDeclaration style;
  [Throws]
  readonly attribute SVGSVGElement? ownerSVGElement;
  readonly attribute SVGElement? viewportElement;

  [SetterThrows]
           attribute EventHandler oncopy;
  [SetterThrows]
           attribute EventHandler oncut;
  [SetterThrows]
           attribute EventHandler onpaste;
};

SVGElement implements GlobalEventHandlers;
SVGElement implements NodeEventHandlers;
SVGElement implements TouchEventHandlers;
interface SVGEllipseElement : SVGGraphicsElement {
  [Constant]
  readonly attribute SVGAnimatedLength cx;
  [Constant]
  readonly attribute SVGAnimatedLength cy;
  [Constant]
  readonly attribute SVGAnimatedLength rx;
  [Constant]
  readonly attribute SVGAnimatedLength ry;
};
interface SVGFEBlendElement : SVGElement {


  const unsigned short SVG_FEBLEND_MODE_UNKNOWN = 0;
  const unsigned short SVG_FEBLEND_MODE_NORMAL = 1;
  const unsigned short SVG_FEBLEND_MODE_MULTIPLY = 2;
  const unsigned short SVG_FEBLEND_MODE_SCREEN = 3;
  const unsigned short SVG_FEBLEND_MODE_DARKEN = 4;
  const unsigned short SVG_FEBLEND_MODE_LIGHTEN = 5;

  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedString in2;
  readonly attribute SVGAnimatedEnumeration mode;
};

SVGFEBlendElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEColorMatrixElement : SVGElement {


  const unsigned short SVG_FECOLORMATRIX_TYPE_UNKNOWN = 0;
  const unsigned short SVG_FECOLORMATRIX_TYPE_MATRIX = 1;
  const unsigned short SVG_FECOLORMATRIX_TYPE_SATURATE = 2;
  const unsigned short SVG_FECOLORMATRIX_TYPE_HUEROTATE = 3;
  const unsigned short SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA = 4;

  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedEnumeration type;
  readonly attribute SVGAnimatedNumberList values;
};

SVGFEColorMatrixElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEComponentTransferElement : SVGElement {
  readonly attribute SVGAnimatedString in1;
};
interface SVGFECompositeElement : SVGElement {


  const unsigned short SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;
  const unsigned short SVG_FECOMPOSITE_OPERATOR_OVER = 1;
  const unsigned short SVG_FECOMPOSITE_OPERATOR_IN = 2;
  const unsigned short SVG_FECOMPOSITE_OPERATOR_OUT = 3;
  const unsigned short SVG_FECOMPOSITE_OPERATOR_ATOP = 4;
  const unsigned short SVG_FECOMPOSITE_OPERATOR_XOR = 5;
  const unsigned short SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;

  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedString in2;
  readonly attribute SVGAnimatedEnumeration operator;
  readonly attribute SVGAnimatedNumber k1;
  readonly attribute SVGAnimatedNumber k2;
  readonly attribute SVGAnimatedNumber k3;
  readonly attribute SVGAnimatedNumber k4;
};

SVGFECompositeElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEConvolveMatrixElement : SVGElement {


  const unsigned short SVG_EDGEMODE_UNKNOWN = 0;
  const unsigned short SVG_EDGEMODE_DUPLICATE = 1;
  const unsigned short SVG_EDGEMODE_WRAP = 2;
  const unsigned short SVG_EDGEMODE_NONE = 3;

  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedInteger orderX;
  readonly attribute SVGAnimatedInteger orderY;
  readonly attribute SVGAnimatedNumberList kernelMatrix;
  readonly attribute SVGAnimatedNumber divisor;
  readonly attribute SVGAnimatedNumber bias;
  readonly attribute SVGAnimatedInteger targetX;
  readonly attribute SVGAnimatedInteger targetY;
  readonly attribute SVGAnimatedEnumeration edgeMode;
  readonly attribute SVGAnimatedNumber kernelUnitLengthX;
  readonly attribute SVGAnimatedNumber kernelUnitLengthY;
  readonly attribute SVGAnimatedBoolean preserveAlpha;
};

SVGFEConvolveMatrixElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEDiffuseLightingElement : SVGElement {
  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedNumber surfaceScale;
  readonly attribute SVGAnimatedNumber diffuseConstant;
  readonly attribute SVGAnimatedNumber kernelUnitLengthX;
  readonly attribute SVGAnimatedNumber kernelUnitLengthY;
};

SVGFEDiffuseLightingElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEDisplacementMapElement : SVGElement {


  const unsigned short SVG_CHANNEL_UNKNOWN = 0;
  const unsigned short SVG_CHANNEL_R = 1;
  const unsigned short SVG_CHANNEL_G = 2;
  const unsigned short SVG_CHANNEL_B = 3;
  const unsigned short SVG_CHANNEL_A = 4;

  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedString in2;
  readonly attribute SVGAnimatedNumber scale;
  readonly attribute SVGAnimatedEnumeration xChannelSelector;
  readonly attribute SVGAnimatedEnumeration yChannelSelector;
};

SVGFEDisplacementMapElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEDistantLightElement : SVGElement {
  readonly attribute SVGAnimatedNumber azimuth;
  readonly attribute SVGAnimatedNumber elevation;
};
interface SVGFEFloodElement : SVGElement {
};

SVGFEMergeElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEFuncAElement : SVGComponentTransferFunctionElement {
};
interface SVGFEFuncBElement : SVGComponentTransferFunctionElement {
};
interface SVGFEFuncGElement : SVGComponentTransferFunctionElement {
};
interface SVGFEFuncRElement : SVGComponentTransferFunctionElement {
};
interface SVGFEGaussianBlurElement : SVGElement {
  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedNumber stdDeviationX;
  readonly attribute SVGAnimatedNumber stdDeviationY;

  void setStdDeviation(float stdDeviationX, float stdDeviationY);
};
interface SVGFEImageElement : SVGElement {
  readonly attribute SVGAnimatedPreserveAspectRatio preserveAspectRatio;
};

SVGFEImageElement implements SVGFilterPrimitiveStandardAttributes;
SVGFEImageElement implements SVGURIReference;
interface SVGFEMergeElement : SVGElement {
};

SVGFEMergeElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEMergeNodeElement : SVGElement {
  readonly attribute SVGAnimatedString in1;
};
interface SVGFEMorphologyElement : SVGElement {


  const unsigned short SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0;
  const unsigned short SVG_MORPHOLOGY_OPERATOR_ERODE = 1;
  const unsigned short SVG_MORPHOLOGY_OPERATOR_DILATE = 2;

  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedEnumeration operator;
  readonly attribute SVGAnimatedNumber radiusX;
  readonly attribute SVGAnimatedNumber radiusY;
};

SVGFEMorphologyElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEOffsetElement : SVGElement {
  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedNumber dx;
  readonly attribute SVGAnimatedNumber dy;
};

SVGFEOffsetElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFEPointLightElement : SVGElement {
  readonly attribute SVGAnimatedNumber x;
  readonly attribute SVGAnimatedNumber y;
  readonly attribute SVGAnimatedNumber z;
};
interface SVGFESpecularLightingElement : SVGElement {
  readonly attribute SVGAnimatedString in1;
  readonly attribute SVGAnimatedNumber surfaceScale;
  readonly attribute SVGAnimatedNumber specularConstant;
  readonly attribute SVGAnimatedNumber specularExponent;
  readonly attribute SVGAnimatedNumber kernelUnitLengthX;
  readonly attribute SVGAnimatedNumber kernelUnitLengthY;
};

SVGFESpecularLightingElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFESpotLightElement : SVGElement {
  readonly attribute SVGAnimatedNumber x;
  readonly attribute SVGAnimatedNumber y;
  readonly attribute SVGAnimatedNumber z;
  readonly attribute SVGAnimatedNumber pointsAtX;
  readonly attribute SVGAnimatedNumber pointsAtY;
  readonly attribute SVGAnimatedNumber pointsAtZ;
  readonly attribute SVGAnimatedNumber specularExponent;
  readonly attribute SVGAnimatedNumber limitingConeAngle;
};
interface SVGFETileElement : SVGElement {
  readonly attribute SVGAnimatedString in1;
};

SVGFETileElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFETurbulenceElement : SVGElement {


  const unsigned short SVG_TURBULENCE_TYPE_UNKNOWN = 0;
  const unsigned short SVG_TURBULENCE_TYPE_FRACTALNOISE = 1;
  const unsigned short SVG_TURBULENCE_TYPE_TURBULENCE = 2;


  const unsigned short SVG_STITCHTYPE_UNKNOWN = 0;
  const unsigned short SVG_STITCHTYPE_STITCH = 1;
  const unsigned short SVG_STITCHTYPE_NOSTITCH = 2;

  readonly attribute SVGAnimatedNumber baseFrequencyX;
  readonly attribute SVGAnimatedNumber baseFrequencyY;
  readonly attribute SVGAnimatedInteger numOctaves;
  readonly attribute SVGAnimatedNumber seed;
  readonly attribute SVGAnimatedEnumeration stitchTiles;
  readonly attribute SVGAnimatedEnumeration type;
};

SVGFETurbulenceElement implements SVGFilterPrimitiveStandardAttributes;
interface SVGFilterElement : SVGElement {
  readonly attribute SVGAnimatedEnumeration filterUnits;
  readonly attribute SVGAnimatedEnumeration primitiveUnits;
  readonly attribute SVGAnimatedLength x;
  readonly attribute SVGAnimatedLength y;
  readonly attribute SVGAnimatedLength width;
  readonly attribute SVGAnimatedLength height;
  readonly attribute SVGAnimatedInteger filterResX;
  readonly attribute SVGAnimatedInteger filterResY;

  void setFilterRes(unsigned long filterResX, unsigned long filterResY);

};

SVGFilterElement implements SVGURIReference;
SVGFilterElement implements SVGUnitTypes;
[NoInterfaceObject]
interface SVGFilterPrimitiveStandardAttributes {
  readonly attribute SVGAnimatedLength x;
  readonly attribute SVGAnimatedLength y;
  readonly attribute SVGAnimatedLength width;
  readonly attribute SVGAnimatedLength height;
  readonly attribute SVGAnimatedString result;
};
[NoInterfaceObject]
interface SVGFitToViewBox {
  [Constant]
  readonly attribute SVGAnimatedRect viewBox;
  [Constant]
  readonly attribute SVGAnimatedPreserveAspectRatio preserveAspectRatio;
};
interface SVGForeignObjectElement : SVGGraphicsElement {
  [Constant]
  readonly attribute SVGAnimatedLength x;
  [Constant]
  readonly attribute SVGAnimatedLength y;
  [Constant]
  readonly attribute SVGAnimatedLength width;
  [Constant]
  readonly attribute SVGAnimatedLength height;
};
interface SVGGElement : SVGGraphicsElement {
};
interface SVGGradientElement : SVGElement {


  const unsigned short SVG_SPREADMETHOD_UNKNOWN = 0;
  const unsigned short SVG_SPREADMETHOD_PAD = 1;
  const unsigned short SVG_SPREADMETHOD_REFLECT = 2;
  const unsigned short SVG_SPREADMETHOD_REPEAT = 3;

  readonly attribute SVGAnimatedEnumeration gradientUnits;
  readonly attribute SVGAnimatedTransformList gradientTransform;
  readonly attribute SVGAnimatedEnumeration spreadMethod;
};

SVGGradientElement implements SVGURIReference;
SVGGradientElement implements SVGUnitTypes;
interface SVGGraphicsElement : SVGElement {
  readonly attribute SVGAnimatedTransformList transform;

  readonly attribute SVGElement? nearestViewportElement;
  readonly attribute SVGElement? farthestViewportElement;

  [Creator, Throws]
  SVGRect getBBox();


  SVGMatrix? getCTM();
  SVGMatrix? getScreenCTM();
  [Throws]
  SVGMatrix getTransformToElement(SVGGraphicsElement element);
};

SVGGraphicsElement implements SVGTests;
interface SVGImageElement : SVGGraphicsElement {
  [Constant]
  readonly attribute SVGAnimatedLength x;
  [Constant]
  readonly attribute SVGAnimatedLength y;
  [Constant]
  readonly attribute SVGAnimatedLength width;
  [Constant]
  readonly attribute SVGAnimatedLength height;
  [Constant]
  readonly attribute SVGAnimatedPreserveAspectRatio preserveAspectRatio;
};

SVGImageElement implements MozImageLoadingContent;
SVGImageElement implements SVGURIReference;
interface SVGLength;

interface SVGLengthList {
  readonly attribute unsigned long numberOfItems;
  [Throws]
  void clear();
  [Throws]
  SVGLength initialize(SVGLength newItem);
  [Throws]
  getter SVGLength getItem(unsigned long index);
  [Throws]
  SVGLength insertItemBefore(SVGLength newItem, unsigned long index);
  [Throws]
  SVGLength replaceItem(SVGLength newItem, unsigned long index);
  [Throws]
  SVGLength removeItem(unsigned long index);
  [Throws]
  SVGLength appendItem(SVGLength newItem);


  readonly attribute unsigned long length;
};
interface SVGLinearGradientElement : SVGGradientElement {
  readonly attribute SVGAnimatedLength x1;
  readonly attribute SVGAnimatedLength y1;
  readonly attribute SVGAnimatedLength x2;
  readonly attribute SVGAnimatedLength y2;
};
interface SVGLineElement : SVGGraphicsElement {
  [Constant]
  readonly attribute SVGAnimatedLength x1;
  [Constant]
  readonly attribute SVGAnimatedLength y1;
  [Constant]
  readonly attribute SVGAnimatedLength x2;
  [Constant]
  readonly attribute SVGAnimatedLength y2;
};
interface SVGMarkerElement : SVGElement {


  const unsigned short SVG_MARKERUNITS_UNKNOWN = 0;
  const unsigned short SVG_MARKERUNITS_USERSPACEONUSE = 1;
  const unsigned short SVG_MARKERUNITS_STROKEWIDTH = 2;


  const unsigned short SVG_MARKER_ORIENT_UNKNOWN = 0;
  const unsigned short SVG_MARKER_ORIENT_AUTO = 1;
  const unsigned short SVG_MARKER_ORIENT_ANGLE = 2;

  readonly attribute SVGAnimatedLength refX;
  readonly attribute SVGAnimatedLength refY;
  readonly attribute SVGAnimatedEnumeration markerUnits;
  readonly attribute SVGAnimatedLength markerWidth;
  readonly attribute SVGAnimatedLength markerHeight;
  readonly attribute SVGAnimatedEnumeration orientType;
  readonly attribute SVGAnimatedAngle orientAngle;

  void setOrientToAuto();
  [Throws]
  void setOrientToAngle(SVGAngle angle);
};

SVGMarkerElement implements SVGFitToViewBox;
interface SVGMaskElement : SVGElement {


  const unsigned short SVG_MASKTYPE_LUMINANCE = 0;
  const unsigned short SVG_MASKTYPE_ALPHA = 1;

  readonly attribute SVGAnimatedEnumeration maskUnits;
  readonly attribute SVGAnimatedEnumeration maskContentUnits;
  readonly attribute SVGAnimatedLength x;
  readonly attribute SVGAnimatedLength y;
  readonly attribute SVGAnimatedLength width;
  readonly attribute SVGAnimatedLength height;
};

SVGMaskElement implements SVGUnitTypes;
interface SVGMatrix {

  [SetterThrows]
  attribute float a;
  [SetterThrows]
  attribute float b;
  [SetterThrows]
  attribute float c;
  [SetterThrows]
  attribute float d;
  [SetterThrows]
  attribute float e;
  [SetterThrows]
  attribute float f;

  [Creator]
  SVGMatrix multiply(SVGMatrix secondMatrix);
  [Creator, Throws]
  SVGMatrix inverse();
  [Creator]
  SVGMatrix translate(float x, float y);
  [Creator]
  SVGMatrix scale(float scaleFactor);
  [Creator]
  SVGMatrix scaleNonUniform(float scaleFactorX, float scaleFactorY);
  [Creator]
  SVGMatrix rotate(float angle);
  [Creator, Throws]
  SVGMatrix rotateFromVector(float x, float y);
  [Creator]
  SVGMatrix flipX();
  [Creator]
  SVGMatrix flipY();
  [Creator, Throws]
  SVGMatrix skewX(float angle);
  [Creator, Throws]
  SVGMatrix skewY(float angle);
};
interface SVGMetadataElement : SVGElement {
};
interface SVGMPathElement : SVGElement {
};

SVGMPathElement implements SVGURIReference;
interface SVGNumber;

interface SVGNumberList {
  readonly attribute unsigned long numberOfItems;
  [Throws]
  void clear();
  [Throws]
  SVGNumber initialize(SVGNumber newItem);
  [Throws]
  getter SVGNumber getItem(unsigned long index);
  [Throws]
  SVGNumber insertItemBefore(SVGNumber newItem, unsigned long index);
  [Throws]
  SVGNumber replaceItem(SVGNumber newItem, unsigned long index);
  [Throws]
  SVGNumber removeItem(unsigned long index);
  [Throws]
  SVGNumber appendItem(SVGNumber newItem);


  readonly attribute unsigned long length;
};
interface SVGPathElement : SVGGraphicsElement {

  readonly attribute SVGAnimatedNumber pathLength;

  [Throws]
  float getTotalLength();
  [Creator, Throws]
  SVGPoint getPointAtLength(float distance);
  unsigned long getPathSegAtLength(float distance);
  [Creator]
  SVGPathSegClosePath createSVGPathSegClosePath();
  [Creator]
  SVGPathSegMovetoAbs createSVGPathSegMovetoAbs(float x, float y);
  [Creator]
  SVGPathSegMovetoRel createSVGPathSegMovetoRel(float x, float y);
  [Creator]
  SVGPathSegLinetoAbs createSVGPathSegLinetoAbs(float x, float y);
  [Creator]
  SVGPathSegLinetoRel createSVGPathSegLinetoRel(float x, float y);
  [Creator]
  SVGPathSegCurvetoCubicAbs createSVGPathSegCurvetoCubicAbs(float x, float y, float x1, float y1, float x2, float y2);
  [Creator]
  SVGPathSegCurvetoCubicRel createSVGPathSegCurvetoCubicRel(float x, float y, float x1, float y1, float x2, float y2);
  [Creator]
  SVGPathSegCurvetoQuadraticAbs createSVGPathSegCurvetoQuadraticAbs(float x, float y, float x1, float y1);
  [Creator]
  SVGPathSegCurvetoQuadraticRel createSVGPathSegCurvetoQuadraticRel(float x, float y, float x1, float y1);
  [Creator]
  SVGPathSegArcAbs createSVGPathSegArcAbs(float x, float y, float r1, float r2, float angle, boolean largeArcFlag, boolean sweepFlag);
  [Creator]
  SVGPathSegArcRel createSVGPathSegArcRel(float x, float y, float r1, float r2, float angle, boolean largeArcFlag, boolean sweepFlag);
  [Creator]
  SVGPathSegLinetoHorizontalAbs createSVGPathSegLinetoHorizontalAbs(float x);
  [Creator]
  SVGPathSegLinetoHorizontalRel createSVGPathSegLinetoHorizontalRel(float x);
  [Creator]
  SVGPathSegLinetoVerticalAbs createSVGPathSegLinetoVerticalAbs(float y);
  [Creator]
  SVGPathSegLinetoVerticalRel createSVGPathSegLinetoVerticalRel(float y);
  [Creator]
  SVGPathSegCurvetoCubicSmoothAbs createSVGPathSegCurvetoCubicSmoothAbs(float x, float y, float x2, float y2);
  [Creator]
  SVGPathSegCurvetoCubicSmoothRel createSVGPathSegCurvetoCubicSmoothRel(float x, float y, float x2, float y2);
  [Creator]
  SVGPathSegCurvetoQuadraticSmoothAbs createSVGPathSegCurvetoQuadraticSmoothAbs(float x, float y);
  [Creator]
  SVGPathSegCurvetoQuadraticSmoothRel createSVGPathSegCurvetoQuadraticSmoothRel(float x, float y);
};

SVGPathElement implements SVGAnimatedPathData;
interface SVGPathSeg {


  const unsigned short PATHSEG_UNKNOWN = 0;
  const unsigned short PATHSEG_CLOSEPATH = 1;
  const unsigned short PATHSEG_MOVETO_ABS = 2;
  const unsigned short PATHSEG_MOVETO_REL = 3;
  const unsigned short PATHSEG_LINETO_ABS = 4;
  const unsigned short PATHSEG_LINETO_REL = 5;
  const unsigned short PATHSEG_CURVETO_CUBIC_ABS = 6;
  const unsigned short PATHSEG_CURVETO_CUBIC_REL = 7;
  const unsigned short PATHSEG_CURVETO_QUADRATIC_ABS = 8;
  const unsigned short PATHSEG_CURVETO_QUADRATIC_REL = 9;
  const unsigned short PATHSEG_ARC_ABS = 10;
  const unsigned short PATHSEG_ARC_REL = 11;
  const unsigned short PATHSEG_LINETO_HORIZONTAL_ABS = 12;
  const unsigned short PATHSEG_LINETO_HORIZONTAL_REL = 13;
  const unsigned short PATHSEG_LINETO_VERTICAL_ABS = 14;
  const unsigned short PATHSEG_LINETO_VERTICAL_REL = 15;
  const unsigned short PATHSEG_CURVETO_CUBIC_SMOOTH_ABS = 16;
  const unsigned short PATHSEG_CURVETO_CUBIC_SMOOTH_REL = 17;
  const unsigned short PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS = 18;
  const unsigned short PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL = 19;

  readonly attribute unsigned short pathSegType;
  readonly attribute DOMString pathSegTypeAsLetter;
};

interface SVGPathSegClosePath : SVGPathSeg {
};

interface SVGPathSegMovetoAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
};

interface SVGPathSegMovetoRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
};

interface SVGPathSegLinetoAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
};

interface SVGPathSegLinetoRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
};

interface SVGPathSegCurvetoCubicAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float x1;
  [SetterThrows]
  attribute float y1;
  [SetterThrows]
  attribute float x2;
  [SetterThrows]
  attribute float y2;
};

interface SVGPathSegCurvetoCubicRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float x1;
  [SetterThrows]
  attribute float y1;
  [SetterThrows]
  attribute float x2;
  [SetterThrows]
  attribute float y2;
};

interface SVGPathSegCurvetoQuadraticAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float x1;
  [SetterThrows]
  attribute float y1;
};

interface SVGPathSegCurvetoQuadraticRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float x1;
  [SetterThrows]
  attribute float y1;
};

interface SVGPathSegArcAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float r1;
  [SetterThrows]
  attribute float r2;
  [SetterThrows]
  attribute float angle;
  [SetterThrows]
  attribute boolean largeArcFlag;
  [SetterThrows]
  attribute boolean sweepFlag;
};

interface SVGPathSegArcRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float r1;
  [SetterThrows]
  attribute float r2;
  [SetterThrows]
  attribute float angle;
  [SetterThrows]
  attribute boolean largeArcFlag;
  [SetterThrows]
  attribute boolean sweepFlag;
};

interface SVGPathSegLinetoHorizontalAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
};

interface SVGPathSegLinetoHorizontalRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
};

interface SVGPathSegLinetoVerticalAbs : SVGPathSeg {
  [SetterThrows]
  attribute float y;
};

interface SVGPathSegLinetoVerticalRel : SVGPathSeg {
  [SetterThrows]
  attribute float y;
};

interface SVGPathSegCurvetoCubicSmoothAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float x2;
  [SetterThrows]
  attribute float y2;
};

interface SVGPathSegCurvetoCubicSmoothRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float x2;
  [SetterThrows]
  attribute float y2;
};

interface SVGPathSegCurvetoQuadraticSmoothAbs : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
};

interface SVGPathSegCurvetoQuadraticSmoothRel : SVGPathSeg {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
};
interface SVGPathSegList {
  readonly attribute unsigned long numberOfItems;
  [Throws]
  void clear();
  [Throws]
  SVGPathSeg initialize(SVGPathSeg newItem);
  [Throws]
  getter SVGPathSeg getItem(unsigned long index);
  [Throws]
  SVGPathSeg insertItemBefore(SVGPathSeg newItem, unsigned long index);
  [Throws]
  SVGPathSeg replaceItem(SVGPathSeg newItem, unsigned long index);
  [Throws]
  SVGPathSeg removeItem(unsigned long index);
  [Throws]
  SVGPathSeg appendItem(SVGPathSeg newItem);


  readonly attribute unsigned long length;
};
interface SVGPatternElement : SVGElement {
  [Constant]
  readonly attribute SVGAnimatedEnumeration patternUnits;
  [Constant]
  readonly attribute SVGAnimatedEnumeration patternContentUnits;
  [Constant]
  readonly attribute SVGAnimatedTransformList patternTransform;
  [Constant]
  readonly attribute SVGAnimatedLength x;
  [Constant]
  readonly attribute SVGAnimatedLength y;
  [Constant]
  readonly attribute SVGAnimatedLength width;
  [Constant]
  readonly attribute SVGAnimatedLength height;
};

SVGPatternElement implements SVGFitToViewBox;
SVGPatternElement implements SVGURIReference;
SVGPatternElement implements SVGUnitTypes;
interface SVGPoint {

  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;

  [Creator]
  SVGPoint matrixTransform(SVGMatrix matrix);
};
interface SVGPointList {
  readonly attribute unsigned long numberOfItems;
  [Throws]
  void clear();
  [Throws]
  SVGPoint initialize(SVGPoint newItem);
  [Throws]
  getter SVGPoint getItem(unsigned long index);
  [Throws]
  SVGPoint insertItemBefore(SVGPoint newItem, unsigned long index);
  [Throws]
  SVGPoint replaceItem(SVGPoint newItem, unsigned long index);
  [Throws]
  SVGPoint removeItem(unsigned long index);
  [Throws]
  SVGPoint appendItem(SVGPoint newItem);


  readonly attribute unsigned long length;
};
interface SVGPolygonElement : SVGGraphicsElement {
};

SVGPolygonElement implements SVGAnimatedPoints;
interface SVGPolylineElement : SVGGraphicsElement {
};

SVGPolylineElement implements SVGAnimatedPoints;
interface SVGPreserveAspectRatio {


  const unsigned short SVG_PRESERVEASPECTRATIO_UNKNOWN = 0;
  const unsigned short SVG_PRESERVEASPECTRATIO_NONE = 1;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMINYMIN = 2;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMINYMID = 5;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMIDYMID = 6;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMAXYMID = 7;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMINYMAX = 8;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9;
  const unsigned short SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10;


  const unsigned short SVG_MEETORSLICE_UNKNOWN = 0;
  const unsigned short SVG_MEETORSLICE_MEET = 1;
  const unsigned short SVG_MEETORSLICE_SLICE = 2;

  [SetterThrows]
  attribute unsigned short align;
  [SetterThrows]
  attribute unsigned short meetOrSlice;
};
interface SVGRadialGradientElement : SVGGradientElement {
  readonly attribute SVGAnimatedLength cx;
  readonly attribute SVGAnimatedLength cy;
  readonly attribute SVGAnimatedLength r;
  readonly attribute SVGAnimatedLength fx;
  readonly attribute SVGAnimatedLength fy;

};
interface SVGRect {
  [SetterThrows]
  attribute float x;
  [SetterThrows]
  attribute float y;
  [SetterThrows]
  attribute float width;
  [SetterThrows]
  attribute float height;
};
interface SVGRectElement : SVGGraphicsElement {
  [Constant]
  readonly attribute SVGAnimatedLength x;
  [Constant]
  readonly attribute SVGAnimatedLength y;
  [Constant]
  readonly attribute SVGAnimatedLength width;
  [Constant]
  readonly attribute SVGAnimatedLength height;
  [Constant]
  readonly attribute SVGAnimatedLength rx;
  [Constant]
  readonly attribute SVGAnimatedLength ry;
};
interface SVGScriptElement : SVGElement {
  [SetterThrows]
  attribute DOMString type;


  [SetterThrows]
  attribute DOMString crossOrigin;
};

SVGScriptElement implements SVGURIReference;
interface SVGSetElement : SVGAnimationElement {
};
interface SVGStopElement : SVGElement {
  readonly attribute SVGAnimatedNumber offset;
};
interface SVGStringList {
  readonly attribute unsigned long length;
  readonly attribute unsigned long numberOfItems;

  void clear();
  [Throws]
  DOMString initialize(DOMString newItem);
  [Throws]
  DOMString getItem(unsigned long index);
  getter DOMString(unsigned long index);
  [Throws]
  DOMString insertItemBefore(DOMString newItem, unsigned long index);
  [Throws]
  DOMString replaceItem(DOMString newItem, unsigned long index);
  [Throws]
  DOMString removeItem(unsigned long index);
  [Throws]
  DOMString appendItem(DOMString newItem);

};
interface SVGStyleElement : SVGElement {
  [SetterThrows]
  attribute DOMString xmlspace;
  [SetterThrows]
  attribute DOMString type;
  [SetterThrows]
  attribute DOMString media;
  [SetterThrows]
  attribute DOMString title;
  [SetterThrows]
  attribute boolean scoped;
};
interface SVGViewSpec;

interface SVGSVGElement : SVGGraphicsElement {

  readonly attribute SVGAnimatedLength x;
  readonly attribute SVGAnimatedLength y;
  readonly attribute SVGAnimatedLength width;
  readonly attribute SVGAnimatedLength height;

  readonly attribute float pixelUnitToMillimeterX;
  readonly attribute float pixelUnitToMillimeterY;
  readonly attribute float screenPixelToMillimeterX;
  readonly attribute float screenPixelToMillimeterY;
  readonly attribute boolean useCurrentView;

           attribute float currentScale;
  readonly attribute SVGPoint currentTranslate;

  unsigned long suspendRedraw(unsigned long maxWaitMilliseconds);
  void unsuspendRedraw(unsigned long suspendHandleID);
  void unsuspendRedrawAll();
  [Throws]
  void forceRedraw();
  void pauseAnimations();
  void unpauseAnimations();
  boolean animationsPaused();
  float getCurrentTime();
  void setCurrentTime(float seconds);




  void deselectAll();
  [Creator]
  SVGNumber createSVGNumber();
  [Creator]
  SVGLength createSVGLength();
  [Creator]
  SVGAngle createSVGAngle();
  [Creator]
  SVGPoint createSVGPoint();
  [Creator]
  SVGMatrix createSVGMatrix();
  [Creator]
  SVGRect createSVGRect();
  [Creator]
  SVGTransform createSVGTransform();
  [Creator]
  SVGTransform createSVGTransformFromMatrix(SVGMatrix matrix);
  [Throws]
  Element? getElementById(DOMString elementId);
};
SVGSVGElement implements SVGFitToViewBox;
SVGSVGElement implements SVGZoomAndPan;
interface SVGSwitchElement : SVGGraphicsElement {
};
interface SVGSymbolElement : SVGElement {
};

SVGSymbolElement implements SVGFitToViewBox;
SVGSymbolElement implements SVGTests;
[NoInterfaceObject]
interface SVGTests {

  readonly attribute SVGStringList requiredFeatures;
  readonly attribute SVGStringList requiredExtensions;
  readonly attribute SVGStringList systemLanguage;

  boolean hasExtension(DOMString extension);
};
interface SVGTextContentElement : SVGGraphicsElement {


  const unsigned short LENGTHADJUST_UNKNOWN = 0;
  const unsigned short LENGTHADJUST_SPACING = 1;
  const unsigned short LENGTHADJUST_SPACINGANDGLYPHS = 2;

  readonly attribute SVGAnimatedLength textLength;
  readonly attribute SVGAnimatedEnumeration lengthAdjust;

  long getNumberOfChars();
  float getComputedTextLength();
  [Throws]
  float getSubStringLength(unsigned long charnum, unsigned long nchars);
  [Throws]
  SVGPoint getStartPositionOfChar(unsigned long charnum);
  [Throws]
  SVGPoint getEndPositionOfChar(unsigned long charnum);
  [Creator, Throws]
  SVGRect getExtentOfChar(unsigned long charnum);
  [Throws]
  float getRotationOfChar(unsigned long charnum);
  long getCharNumAtPosition(SVGPoint point);
  [Throws, Pref="svg.text.css-frames.enabled"]
  void selectSubString(unsigned long charnum, unsigned long nchars);
};
interface SVGTextElement : SVGTextPositioningElement {
};
interface SVGTextPathElement : SVGTextContentElement {


  const unsigned short TEXTPATH_METHODTYPE_UNKNOWN = 0;
  const unsigned short TEXTPATH_METHODTYPE_ALIGN = 1;
  const unsigned short TEXTPATH_METHODTYPE_STRETCH = 2;


  const unsigned short TEXTPATH_SPACINGTYPE_UNKNOWN = 0;
  const unsigned short TEXTPATH_SPACINGTYPE_AUTO = 1;
  const unsigned short TEXTPATH_SPACINGTYPE_EXACT = 2;

  readonly attribute SVGAnimatedLength startOffset;
  readonly attribute SVGAnimatedEnumeration method;
  readonly attribute SVGAnimatedEnumeration spacing;
};

SVGTextPathElement implements SVGURIReference;
interface SVGTextPositioningElement : SVGTextContentElement {
  readonly attribute SVGAnimatedLengthList x;
  readonly attribute SVGAnimatedLengthList y;
  readonly attribute SVGAnimatedLengthList dx;
  readonly attribute SVGAnimatedLengthList dy;
  readonly attribute SVGAnimatedNumberList rotate;
};
interface SVGTitleElement : SVGElement {
};
interface SVGTransform {


  const unsigned short SVG_TRANSFORM_UNKNOWN = 0;
  const unsigned short SVG_TRANSFORM_MATRIX = 1;
  const unsigned short SVG_TRANSFORM_TRANSLATE = 2;
  const unsigned short SVG_TRANSFORM_SCALE = 3;
  const unsigned short SVG_TRANSFORM_ROTATE = 4;
  const unsigned short SVG_TRANSFORM_SKEWX = 5;
  const unsigned short SVG_TRANSFORM_SKEWY = 6;

  readonly attribute unsigned short type;
  readonly attribute SVGMatrix matrix;
  readonly attribute float angle;

  [Throws]
  void setMatrix(SVGMatrix matrix);
  [Throws]
  void setTranslate(float tx, float ty);
  [Throws]
  void setScale(float sx, float sy);
  [Throws]
  void setRotate(float angle, float cx, float cy);
  [Throws]
  void setSkewX(float angle);
  [Throws]
  void setSkewY(float angle);
};
interface SVGTransformList {
  readonly attribute unsigned long numberOfItems;
  [Throws]
  void clear();
  [Throws]
  SVGTransform initialize(SVGTransform newItem);
  [Throws]
  getter SVGTransform getItem(unsigned long index);
  [Throws]
  SVGTransform insertItemBefore(SVGTransform newItem, unsigned long index);
  [Throws]
  SVGTransform replaceItem(SVGTransform newItem, unsigned long index);
  [Throws]
  SVGTransform removeItem(unsigned long index);
  [Throws]
  SVGTransform appendItem(SVGTransform newItem);
  SVGTransform createSVGTransformFromMatrix(SVGMatrix matrix);
  [Throws]
  SVGTransform? consolidate();


  readonly attribute unsigned long length;
};
interface SVGTSpanElement : SVGTextPositioningElement {
};
interface SVGUnitTypes {

  const unsigned short SVG_UNIT_TYPE_UNKNOWN = 0;
  const unsigned short SVG_UNIT_TYPE_USERSPACEONUSE = 1;
  const unsigned short SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;
};
[NoInterfaceObject]
interface SVGURIReference {
  readonly attribute SVGAnimatedString href;
};
interface SVGUseElement : SVGGraphicsElement {
  [Constant]
  readonly attribute SVGAnimatedLength x;
  [Constant]
  readonly attribute SVGAnimatedLength y;
  [Constant]
  readonly attribute SVGAnimatedLength width;
  [Constant]
  readonly attribute SVGAnimatedLength height;


};

SVGUseElement implements SVGURIReference;
interface SVGViewElement : SVGElement {
  readonly attribute SVGStringList viewTarget;
};

SVGViewElement implements SVGFitToViewBox;
SVGViewElement implements SVGZoomAndPan;
interface SVGZoomAndPan {


  const unsigned short SVG_ZOOMANDPAN_UNKNOWN = 0;
  const unsigned short SVG_ZOOMANDPAN_DISABLE = 1;
  const unsigned short SVG_ZOOMANDPAN_MAGNIFY = 2;

  [SetterThrows]
  attribute unsigned short zoomAndPan;
};
interface SVGZoomEvent : UIEvent {



  [Constant]
  readonly attribute float previousScale;
  [Constant]
  readonly attribute SVGPoint? previousTranslate;
  [Constant]
  readonly attribute float newScale;
  [Constant]
  readonly attribute SVGPoint? newTranslate;
};
[Constructor(optional DOMString data = "")]
interface Text : CharacterData {
  [Throws]
  Text splitText(unsigned long offset);
  [Throws]
  readonly attribute DOMString wholeText;
};
[Constructor(optional DOMString label = "utf-8", optional TextDecoderOptions options)]
interface TextDecoder {
  [Constant]
  readonly attribute DOMString encoding;
  [Throws]
  DOMString decode();
  [Throws]
  DOMString decode(ArrayBufferView input, optional TextDecodeOptions options);
};

dictionary TextDecoderOptions {
  boolean fatal = false;
};

dictionary TextDecodeOptions {
  boolean stream = false;
};
[Constructor(optional DOMString utfLabel = "utf-8")]
interface TextEncoder {
  [Constant]
  readonly attribute DOMString encoding;
  [Throws]
  Uint8Array encode(optional DOMString input = "", optional TextEncodeOptions options);
};

dictionary TextEncodeOptions {
  boolean stream = false;
};
enum TextTrackKind {
  "subtitles",
  "captions",
  "descriptions",
  "chapters",
  "metadata"
};

enum TextTrackMode {
  "disabled",
  "hidden",
  "showing"
};

[Pref="media.webvtt.enabled"]
interface TextTrack : EventTarget {
  readonly attribute TextTrackKind kind;
  readonly attribute DOMString label;
  readonly attribute DOMString language;

  readonly attribute DOMString id;
  readonly attribute DOMString inBandMetadataTrackDispatchType;

           attribute TextTrackMode mode;

  readonly attribute TextTrackCueList? cues;
  readonly attribute TextTrackCueList? activeCues;

  void addCue(TextTrackCue cue);
  void removeCue(TextTrackCue cue);

  [SetterThrows]
           attribute EventHandler oncuechange;
};
enum AutoKeyword {
	"auto"
};
enum TextTrackCueAlign {
  "start",
  "middle",
  "end",
  "left",
  "right"
};

[Constructor(double startTime, double endTime, DOMString text), Pref="media.webvtt.enabled"]
interface TextTrackCue : EventTarget {
  readonly attribute TextTrack? track;

  attribute DOMString id;
  attribute double startTime;
  attribute double endTime;
  attribute boolean pauseOnExit;
  attribute DOMString vertical;
  attribute boolean snapToLines;


  attribute long position;
  attribute long size;
  attribute TextTrackCueAlign align;
  attribute DOMString text;
  DocumentFragment getCueAsHTML();

  [SetterThrows]
    attribute EventHandler onenter;

  [SetterThrows]
    attribute EventHandler onexit;
};
[Pref="media.webvtt.enabled"]
interface TextTrackCueList {
  readonly attribute unsigned long length;
  getter TextTrackCue (unsigned long index);
  TextTrackCue? getCueById(DOMString id);
};
[Pref="media.webvtt.enabled"]
interface TextTrackList : EventTarget {
  readonly attribute unsigned long length;
  getter TextTrack (unsigned long index);
  TextTrack? getTrackById(DOMString id);

           [SetterThrows]
           attribute EventHandler onaddtrack;
           [SetterThrows]
           attribute EventHandler onremovetrack;
};
interface WindowProxy;

interface TimeEvent : Event {
  readonly attribute long detail;
  readonly attribute WindowProxy? view;
  void initTimeEvent(DOMString aType, WindowProxy? aView, long aDetail);
};
interface TimeRanges {
  readonly attribute unsigned long length;

  [Throws]
  double start(unsigned long index);

  [Throws]
  double end(unsigned long index);
};
[PrefControlled]
interface Touch {
  readonly attribute long identifier;
  readonly attribute EventTarget target;
  readonly attribute long screenX;
  readonly attribute long screenY;
  readonly attribute long clientX;
  readonly attribute long clientY;
  readonly attribute long pageX;
  readonly attribute long pageY;
  readonly attribute long radiusX;
  readonly attribute long radiusY;
  readonly attribute float rotationAngle;
  readonly attribute float force;
};
interface WindowProxy;

[PrefControlled]
interface TouchEvent : UIEvent {
  readonly attribute TouchList touches;
  readonly attribute TouchList targetTouches;
  readonly attribute TouchList changedTouches;

  readonly attribute boolean altKey;
  readonly attribute boolean metaKey;
  readonly attribute boolean ctrlKey;
  readonly attribute boolean shiftKey;

  [Throws]
  void initTouchEvent(DOMString type, boolean canBubble, boolean cancelable, WindowProxy? view, long detail, boolean ctrlKey, boolean altKey, boolean shiftKey, boolean metaKey, TouchList? touches, TouchList? targetTouches, TouchList? changedTouches);
};
[PrefControlled]
interface TouchList {
  [Pure]
  readonly attribute unsigned long length;
  getter Touch? item(unsigned long index);
};


partial interface TouchList {
  Touch? identifiedTouch(long identifier);
};
[Constructor(DOMString type, optional TransitionEventInit eventInitDict)]
interface TransitionEvent : Event {
  readonly attribute DOMString propertyName;
  readonly attribute float elapsedTime;
  readonly attribute DOMString pseudoElement;
};

dictionary TransitionEventInit : EventInit {
  DOMString propertyName = "";
  float elapsedTime = 0;
  DOMString pseudoElement = "";
};
interface MozTreeBoxObject;
interface MozTreeColumn;

interface TreeColumns {
  readonly attribute MozTreeBoxObject? tree;
  readonly attribute unsigned long count;
  readonly attribute unsigned long length;
  MozTreeColumn? getFirstColumn();
  MozTreeColumn? getLastColumn();
  MozTreeColumn? getPrimaryColumn();
  MozTreeColumn? getSortedColumn();
  MozTreeColumn? getKeyColumn();
  MozTreeColumn? getColumnFor(Element? element);
  getter MozTreeColumn? getNamedColumn(DOMString id);
  getter MozTreeColumn? getColumnAt(unsigned long index);
  void invalidateColumns();

  void restoreNaturalOrder();
};
interface TreeWalker {
  [Constant]
  readonly attribute Node root;
  [Constant]
  readonly attribute unsigned long whatToShow;
  [Constant]
  readonly attribute NodeFilter? filter;
  [Pure, SetterThrows]
           attribute Node currentNode;

  [Throws]
  Node? parentNode();
  [Throws]
  Node? firstChild();
  [Throws]
  Node? lastChild();
  [Throws]
  Node? previousSibling();
  [Throws]
  Node? nextSibling();
  [Throws]
  Node? previousNode();
  [Throws]
  Node? nextNode();
};
interface WindowProxy;

[Constructor(DOMString type, optional UIEventInit eventInitDict)]
interface UIEvent : Event {
  readonly attribute WindowProxy? view;
  readonly attribute long detail;
  void initUIEvent(DOMString aType, boolean aCanBubble, boolean aCancelable, WindowProxy? aView, long aDetail);
};


partial interface UIEvent {
  const long SCROLL_PAGE_UP = -32768;
  const long SCROLL_PAGE_DOWN = 32768;

  readonly attribute long layerX;
  readonly attribute long layerY;
  readonly attribute long pageX;
  readonly attribute long pageY;
  readonly attribute unsigned long which;
  readonly attribute Node? rangeParent;
  readonly attribute long rangeOffset;
           attribute boolean cancelBubble;
  readonly attribute boolean isChar;
};

dictionary UIEventInit : EventInit {
  WindowProxy? view = null;
  long detail = 0;
};
[PrefControlled]
interface UndoManager {
  [Throws]
  void transact(DOMTransaction transaction, boolean merge);
  [Throws]
  void undo();
  [Throws]
  void redo();
  [Throws]
  sequence<DOMTransaction>? item(unsigned long index);
  [Throws]
  readonly attribute unsigned long length;
  [Throws]
  readonly attribute unsigned long position;
  [Throws]
  void clearUndo();
  [Throws]
  void clearRedo();
};
interface URL {
  [Throws]
  static DOMString? createObjectURL(Blob blob, optional objectURLOptions options);
  [Throws]
  static DOMString? createObjectURL(MediaStream stream, optional objectURLOptions options);
  static void revokeObjectURL(DOMString url);
};

dictionary objectURLOptions {

};


partial interface URL {
  [Throws]
  static DOMString? createObjectURL(MediaSource source, optional objectURLOptions options);
};
[NoInterfaceObject]
interface URLUtils {




           attribute DOMString protocol;


           attribute DOMString host;
           attribute DOMString hostname;
           attribute DOMString port;
           attribute DOMString pathname;
           attribute DOMString search;

           attribute DOMString hash;
};
[NoInterfaceObject]
interface URLUtilsReadOnly {
  stringifier;
  readonly attribute DOMString href;

  readonly attribute DOMString protocol;
  readonly attribute DOMString host;
  readonly attribute DOMString hostname;
  readonly attribute DOMString port;
  readonly attribute DOMString pathname;
  readonly attribute DOMString search;
  readonly attribute DOMString hash;
};
[Constructor(DOMString type, optional UserProximityEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface UserProximityEvent : Event {
  readonly attribute boolean near;
};

dictionary UserProximityEventInit : EventInit {
  boolean near = false;
};
[Constructor(DOMString type, optional USSDReceivedEventInit eventInitDict), HeaderFile="GeneratedEventClasses.h"]
interface USSDReceivedEvent : Event {
  readonly attribute DOMString? message;
  readonly attribute boolean sessionEnded;
};

dictionary USSDReceivedEventInit : EventInit {
  DOMString? message = null;
  boolean sessionEnded = false;
};
interface ValidityState {
  readonly attribute boolean valueMissing;
  readonly attribute boolean typeMismatch;
  readonly attribute boolean patternMismatch;
  readonly attribute boolean tooLong;
  readonly attribute boolean rangeUnderflow;
  readonly attribute boolean rangeOverflow;
  readonly attribute boolean stepMismatch;

  readonly attribute boolean customError;
  readonly attribute boolean valid;
};
[Pref="media.mediasource.enabled"]
interface VideoPlaybackQuality {
  readonly attribute DOMHighResTimeStamp creationTime;
  readonly attribute unsigned long totalVideoFrames;
  readonly attribute unsigned long droppedVideoFrames;
  readonly attribute unsigned long corruptedVideoFrames;
  readonly attribute double totalFrameDelay;
};
interface VideoStreamTrack : MediaStreamTrack {




};
[PrefControlled]
interface WaveShaperNode : AudioNode {

      attribute Float32Array? curve;

};
callback LifecycleCreatedCallback = void();

dictionary LifecycleCallbacks {
  LifecycleCreatedCallback? created = null;
};

dictionary ElementRegistrationOptions {
  object? prototype = null;
  LifecycleCallbacks lifecycle;
};
typedef unsigned long GLenum;
typedef boolean GLboolean;
typedef unsigned long GLbitfield;
typedef byte GLbyte;
typedef short GLshort;
typedef long GLint;
typedef long GLsizei;
typedef long long GLintptr;
typedef long long GLsizeiptr;

typedef octet GLubyte;
typedef unsigned short GLushort;
typedef unsigned long GLuint;
typedef unrestricted float GLfloat;
typedef unrestricted float GLclampf;

dictionary WebGLContextAttributes {



    boolean alpha;
    boolean depth = true;
    boolean stencil = false;
    boolean antialias = true;
    boolean premultipliedAlpha = true;
    boolean preserveDrawingBuffer = false;
};

interface WebGLBuffer {
};

interface WebGLFramebuffer {
};

interface WebGLProgram {
};

interface WebGLRenderbuffer {
};

interface WebGLShader {
};

interface WebGLTexture {
};

interface WebGLUniformLocation {
};

interface WebGLVertexArray {
};

interface WebGLActiveInfo {
    readonly attribute GLint size;
    readonly attribute GLenum type;
    readonly attribute DOMString name;
};

interface WebGLShaderPrecisionFormat {
    readonly attribute GLint rangeMin;
    readonly attribute GLint rangeMax;
    readonly attribute GLint precision;
};

interface WebGLRenderingContext {


    const GLenum DEPTH_BUFFER_BIT = 0x00000100;
    const GLenum STENCIL_BUFFER_BIT = 0x00000400;
    const GLenum COLOR_BUFFER_BIT = 0x00004000;


    const GLenum POINTS = 0x0000;
    const GLenum LINES = 0x0001;
    const GLenum LINE_LOOP = 0x0002;
    const GLenum LINE_STRIP = 0x0003;
    const GLenum TRIANGLES = 0x0004;
    const GLenum TRIANGLE_STRIP = 0x0005;
    const GLenum TRIANGLE_FAN = 0x0006;
    const GLenum ZERO = 0;
    const GLenum ONE = 1;
    const GLenum SRC_COLOR = 0x0300;
    const GLenum ONE_MINUS_SRC_COLOR = 0x0301;
    const GLenum SRC_ALPHA = 0x0302;
    const GLenum ONE_MINUS_SRC_ALPHA = 0x0303;
    const GLenum DST_ALPHA = 0x0304;
    const GLenum ONE_MINUS_DST_ALPHA = 0x0305;




    const GLenum DST_COLOR = 0x0306;
    const GLenum ONE_MINUS_DST_COLOR = 0x0307;
    const GLenum SRC_ALPHA_SATURATE = 0x0308;






    const GLenum FUNC_ADD = 0x8006;
    const GLenum BLEND_EQUATION = 0x8009;
    const GLenum BLEND_EQUATION_RGB = 0x8009;
    const GLenum BLEND_EQUATION_ALPHA = 0x883D;


    const GLenum FUNC_SUBTRACT = 0x800A;
    const GLenum FUNC_REVERSE_SUBTRACT = 0x800B;


    const GLenum BLEND_DST_RGB = 0x80C8;
    const GLenum BLEND_SRC_RGB = 0x80C9;
    const GLenum BLEND_DST_ALPHA = 0x80CA;
    const GLenum BLEND_SRC_ALPHA = 0x80CB;
    const GLenum CONSTANT_COLOR = 0x8001;
    const GLenum ONE_MINUS_CONSTANT_COLOR = 0x8002;
    const GLenum CONSTANT_ALPHA = 0x8003;
    const GLenum ONE_MINUS_CONSTANT_ALPHA = 0x8004;
    const GLenum BLEND_COLOR = 0x8005;


    const GLenum ARRAY_BUFFER = 0x8892;
    const GLenum ELEMENT_ARRAY_BUFFER = 0x8893;
    const GLenum ARRAY_BUFFER_BINDING = 0x8894;
    const GLenum ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

    const GLenum STREAM_DRAW = 0x88E0;
    const GLenum STATIC_DRAW = 0x88E4;
    const GLenum DYNAMIC_DRAW = 0x88E8;

    const GLenum BUFFER_SIZE = 0x8764;
    const GLenum BUFFER_USAGE = 0x8765;

    const GLenum CURRENT_VERTEX_ATTRIB = 0x8626;


    const GLenum FRONT = 0x0404;
    const GLenum BACK = 0x0405;
    const GLenum FRONT_AND_BACK = 0x0408;
    const GLenum CULL_FACE = 0x0B44;
    const GLenum BLEND = 0x0BE2;
    const GLenum DITHER = 0x0BD0;
    const GLenum STENCIL_TEST = 0x0B90;
    const GLenum DEPTH_TEST = 0x0B71;
    const GLenum SCISSOR_TEST = 0x0C11;
    const GLenum POLYGON_OFFSET_FILL = 0x8037;
    const GLenum SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
    const GLenum SAMPLE_COVERAGE = 0x80A0;


    const GLenum NO_ERROR = 0;
    const GLenum INVALID_ENUM = 0x0500;
    const GLenum INVALID_VALUE = 0x0501;
    const GLenum INVALID_OPERATION = 0x0502;
    const GLenum OUT_OF_MEMORY = 0x0505;


    const GLenum CW = 0x0900;
    const GLenum CCW = 0x0901;


    const GLenum LINE_WIDTH = 0x0B21;
    const GLenum ALIASED_POINT_SIZE_RANGE = 0x846D;
    const GLenum ALIASED_LINE_WIDTH_RANGE = 0x846E;
    const GLenum CULL_FACE_MODE = 0x0B45;
    const GLenum FRONT_FACE = 0x0B46;
    const GLenum DEPTH_RANGE = 0x0B70;
    const GLenum DEPTH_WRITEMASK = 0x0B72;
    const GLenum DEPTH_CLEAR_VALUE = 0x0B73;
    const GLenum DEPTH_FUNC = 0x0B74;
    const GLenum STENCIL_CLEAR_VALUE = 0x0B91;
    const GLenum STENCIL_FUNC = 0x0B92;
    const GLenum STENCIL_FAIL = 0x0B94;
    const GLenum STENCIL_PASS_DEPTH_FAIL = 0x0B95;
    const GLenum STENCIL_PASS_DEPTH_PASS = 0x0B96;
    const GLenum STENCIL_REF = 0x0B97;
    const GLenum STENCIL_VALUE_MASK = 0x0B93;
    const GLenum STENCIL_WRITEMASK = 0x0B98;
    const GLenum STENCIL_BACK_FUNC = 0x8800;
    const GLenum STENCIL_BACK_FAIL = 0x8801;
    const GLenum STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
    const GLenum STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
    const GLenum STENCIL_BACK_REF = 0x8CA3;
    const GLenum STENCIL_BACK_VALUE_MASK = 0x8CA4;
    const GLenum STENCIL_BACK_WRITEMASK = 0x8CA5;
    const GLenum VIEWPORT = 0x0BA2;
    const GLenum SCISSOR_BOX = 0x0C10;

    const GLenum COLOR_CLEAR_VALUE = 0x0C22;
    const GLenum COLOR_WRITEMASK = 0x0C23;
    const GLenum UNPACK_ALIGNMENT = 0x0CF5;
    const GLenum PACK_ALIGNMENT = 0x0D05;
    const GLenum MAX_TEXTURE_SIZE = 0x0D33;
    const GLenum MAX_VIEWPORT_DIMS = 0x0D3A;
    const GLenum SUBPIXEL_BITS = 0x0D50;
    const GLenum RED_BITS = 0x0D52;
    const GLenum GREEN_BITS = 0x0D53;
    const GLenum BLUE_BITS = 0x0D54;
    const GLenum ALPHA_BITS = 0x0D55;
    const GLenum DEPTH_BITS = 0x0D56;
    const GLenum STENCIL_BITS = 0x0D57;
    const GLenum POLYGON_OFFSET_UNITS = 0x2A00;

    const GLenum POLYGON_OFFSET_FACTOR = 0x8038;
    const GLenum TEXTURE_BINDING_2D = 0x8069;
    const GLenum SAMPLE_BUFFERS = 0x80A8;
    const GLenum SAMPLES = 0x80A9;
    const GLenum SAMPLE_COVERAGE_VALUE = 0x80AA;
    const GLenum SAMPLE_COVERAGE_INVERT = 0x80AB;







    const GLenum COMPRESSED_TEXTURE_FORMATS = 0x86A3;


    const GLenum DONT_CARE = 0x1100;
    const GLenum FASTEST = 0x1101;
    const GLenum NICEST = 0x1102;


    const GLenum GENERATE_MIPMAP_HINT = 0x8192;


    const GLenum BYTE = 0x1400;
    const GLenum UNSIGNED_BYTE = 0x1401;
    const GLenum SHORT = 0x1402;
    const GLenum UNSIGNED_SHORT = 0x1403;
    const GLenum INT = 0x1404;
    const GLenum UNSIGNED_INT = 0x1405;
    const GLenum FLOAT = 0x1406;


    const GLenum DEPTH_COMPONENT = 0x1902;
    const GLenum ALPHA = 0x1906;
    const GLenum RGB = 0x1907;
    const GLenum RGBA = 0x1908;
    const GLenum LUMINANCE = 0x1909;
    const GLenum LUMINANCE_ALPHA = 0x190A;



    const GLenum UNSIGNED_SHORT_4_4_4_4 = 0x8033;
    const GLenum UNSIGNED_SHORT_5_5_5_1 = 0x8034;
    const GLenum UNSIGNED_SHORT_5_6_5 = 0x8363;


    const GLenum FRAGMENT_SHADER = 0x8B30;
    const GLenum VERTEX_SHADER = 0x8B31;
    const GLenum MAX_VERTEX_ATTRIBS = 0x8869;
    const GLenum MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
    const GLenum MAX_VARYING_VECTORS = 0x8DFC;
    const GLenum MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
    const GLenum MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
    const GLenum MAX_TEXTURE_IMAGE_UNITS = 0x8872;
    const GLenum MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
    const GLenum SHADER_TYPE = 0x8B4F;
    const GLenum DELETE_STATUS = 0x8B80;
    const GLenum LINK_STATUS = 0x8B82;
    const GLenum VALIDATE_STATUS = 0x8B83;
    const GLenum ATTACHED_SHADERS = 0x8B85;
    const GLenum ACTIVE_UNIFORMS = 0x8B86;
    const GLenum ACTIVE_ATTRIBUTES = 0x8B89;
    const GLenum SHADING_LANGUAGE_VERSION = 0x8B8C;
    const GLenum CURRENT_PROGRAM = 0x8B8D;


    const GLenum NEVER = 0x0200;
    const GLenum LESS = 0x0201;
    const GLenum EQUAL = 0x0202;
    const GLenum LEQUAL = 0x0203;
    const GLenum GREATER = 0x0204;
    const GLenum NOTEQUAL = 0x0205;
    const GLenum GEQUAL = 0x0206;
    const GLenum ALWAYS = 0x0207;



    const GLenum KEEP = 0x1E00;
    const GLenum REPLACE = 0x1E01;
    const GLenum INCR = 0x1E02;
    const GLenum DECR = 0x1E03;
    const GLenum INVERT = 0x150A;
    const GLenum INCR_WRAP = 0x8507;
    const GLenum DECR_WRAP = 0x8508;


    const GLenum VENDOR = 0x1F00;
    const GLenum RENDERER = 0x1F01;
    const GLenum VERSION = 0x1F02;


    const GLenum NEAREST = 0x2600;
    const GLenum LINEAR = 0x2601;




    const GLenum NEAREST_MIPMAP_NEAREST = 0x2700;
    const GLenum LINEAR_MIPMAP_NEAREST = 0x2701;
    const GLenum NEAREST_MIPMAP_LINEAR = 0x2702;
    const GLenum LINEAR_MIPMAP_LINEAR = 0x2703;


    const GLenum TEXTURE_MAG_FILTER = 0x2800;
    const GLenum TEXTURE_MIN_FILTER = 0x2801;
    const GLenum TEXTURE_WRAP_S = 0x2802;
    const GLenum TEXTURE_WRAP_T = 0x2803;


    const GLenum TEXTURE_2D = 0x0DE1;
    const GLenum TEXTURE = 0x1702;

    const GLenum TEXTURE_CUBE_MAP = 0x8513;
    const GLenum TEXTURE_BINDING_CUBE_MAP = 0x8514;
    const GLenum TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
    const GLenum TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
    const GLenum TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
    const GLenum TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
    const GLenum TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
    const GLenum TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
    const GLenum MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;


    const GLenum TEXTURE0 = 0x84C0;
    const GLenum TEXTURE1 = 0x84C1;
    const GLenum TEXTURE2 = 0x84C2;
    const GLenum TEXTURE3 = 0x84C3;
    const GLenum TEXTURE4 = 0x84C4;
    const GLenum TEXTURE5 = 0x84C5;
    const GLenum TEXTURE6 = 0x84C6;
    const GLenum TEXTURE7 = 0x84C7;
    const GLenum TEXTURE8 = 0x84C8;
    const GLenum TEXTURE9 = 0x84C9;
    const GLenum TEXTURE10 = 0x84CA;
    const GLenum TEXTURE11 = 0x84CB;
    const GLenum TEXTURE12 = 0x84CC;
    const GLenum TEXTURE13 = 0x84CD;
    const GLenum TEXTURE14 = 0x84CE;
    const GLenum TEXTURE15 = 0x84CF;
    const GLenum TEXTURE16 = 0x84D0;
    const GLenum TEXTURE17 = 0x84D1;
    const GLenum TEXTURE18 = 0x84D2;
    const GLenum TEXTURE19 = 0x84D3;
    const GLenum TEXTURE20 = 0x84D4;
    const GLenum TEXTURE21 = 0x84D5;
    const GLenum TEXTURE22 = 0x84D6;
    const GLenum TEXTURE23 = 0x84D7;
    const GLenum TEXTURE24 = 0x84D8;
    const GLenum TEXTURE25 = 0x84D9;
    const GLenum TEXTURE26 = 0x84DA;
    const GLenum TEXTURE27 = 0x84DB;
    const GLenum TEXTURE28 = 0x84DC;
    const GLenum TEXTURE29 = 0x84DD;
    const GLenum TEXTURE30 = 0x84DE;
    const GLenum TEXTURE31 = 0x84DF;
    const GLenum ACTIVE_TEXTURE = 0x84E0;


    const GLenum REPEAT = 0x2901;
    const GLenum CLAMP_TO_EDGE = 0x812F;
    const GLenum MIRRORED_REPEAT = 0x8370;


    const GLenum FLOAT_VEC2 = 0x8B50;
    const GLenum FLOAT_VEC3 = 0x8B51;
    const GLenum FLOAT_VEC4 = 0x8B52;
    const GLenum INT_VEC2 = 0x8B53;
    const GLenum INT_VEC3 = 0x8B54;
    const GLenum INT_VEC4 = 0x8B55;
    const GLenum BOOL = 0x8B56;
    const GLenum BOOL_VEC2 = 0x8B57;
    const GLenum BOOL_VEC3 = 0x8B58;
    const GLenum BOOL_VEC4 = 0x8B59;
    const GLenum FLOAT_MAT2 = 0x8B5A;
    const GLenum FLOAT_MAT3 = 0x8B5B;
    const GLenum FLOAT_MAT4 = 0x8B5C;
    const GLenum SAMPLER_2D = 0x8B5E;
    const GLenum SAMPLER_CUBE = 0x8B60;


    const GLenum VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
    const GLenum VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
    const GLenum VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
    const GLenum VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
    const GLenum VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
    const GLenum VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
    const GLenum VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;


    const GLenum COMPILE_STATUS = 0x8B81;


    const GLenum LOW_FLOAT = 0x8DF0;
    const GLenum MEDIUM_FLOAT = 0x8DF1;
    const GLenum HIGH_FLOAT = 0x8DF2;
    const GLenum LOW_INT = 0x8DF3;
    const GLenum MEDIUM_INT = 0x8DF4;
    const GLenum HIGH_INT = 0x8DF5;


    const GLenum FRAMEBUFFER = 0x8D40;
    const GLenum RENDERBUFFER = 0x8D41;

    const GLenum RGBA4 = 0x8056;
    const GLenum RGB5_A1 = 0x8057;
    const GLenum RGB565 = 0x8D62;
    const GLenum DEPTH_COMPONENT16 = 0x81A5;
    const GLenum STENCIL_INDEX = 0x1901;
    const GLenum STENCIL_INDEX8 = 0x8D48;
    const GLenum DEPTH_STENCIL = 0x84F9;

    const GLenum RENDERBUFFER_WIDTH = 0x8D42;
    const GLenum RENDERBUFFER_HEIGHT = 0x8D43;
    const GLenum RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
    const GLenum RENDERBUFFER_RED_SIZE = 0x8D50;
    const GLenum RENDERBUFFER_GREEN_SIZE = 0x8D51;
    const GLenum RENDERBUFFER_BLUE_SIZE = 0x8D52;
    const GLenum RENDERBUFFER_ALPHA_SIZE = 0x8D53;
    const GLenum RENDERBUFFER_DEPTH_SIZE = 0x8D54;
    const GLenum RENDERBUFFER_STENCIL_SIZE = 0x8D55;

    const GLenum FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
    const GLenum FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
    const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
    const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

    const GLenum COLOR_ATTACHMENT0 = 0x8CE0;
    const GLenum DEPTH_ATTACHMENT = 0x8D00;
    const GLenum STENCIL_ATTACHMENT = 0x8D20;
    const GLenum DEPTH_STENCIL_ATTACHMENT = 0x821A;

    const GLenum NONE = 0;

    const GLenum FRAMEBUFFER_COMPLETE = 0x8CD5;
    const GLenum FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
    const GLenum FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
    const GLenum FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
    const GLenum FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

    const GLenum FRAMEBUFFER_BINDING = 0x8CA6;
    const GLenum RENDERBUFFER_BINDING = 0x8CA7;
    const GLenum MAX_RENDERBUFFER_SIZE = 0x84E8;

    const GLenum INVALID_FRAMEBUFFER_OPERATION = 0x0506;


    const GLenum UNPACK_FLIP_Y_WEBGL = 0x9240;
    const GLenum UNPACK_PREMULTIPLY_ALPHA_WEBGL = 0x9241;
    const GLenum CONTEXT_LOST_WEBGL = 0x9242;
    const GLenum UNPACK_COLORSPACE_CONVERSION_WEBGL = 0x9243;
    const GLenum BROWSER_DEFAULT_WEBGL = 0x9244;


    readonly attribute HTMLCanvasElement? canvas;
    readonly attribute GLsizei drawingBufferWidth;
    readonly attribute GLsizei drawingBufferHeight;

    [WebGLHandlesContextLoss]
    WebGLContextAttributes? getContextAttributes();
    [WebGLHandlesContextLoss]
    boolean isContextLost();

    sequence<DOMString>? getSupportedExtensions();

    [Throws]
    object? getExtension(DOMString name);

    void activeTexture(GLenum texture);
    void attachShader(WebGLProgram? program, WebGLShader? shader);
    void bindAttribLocation(WebGLProgram? program, GLuint index, DOMString name);
    void bindBuffer(GLenum target, WebGLBuffer? buffer);
    void bindFramebuffer(GLenum target, WebGLFramebuffer? framebuffer);
    void bindRenderbuffer(GLenum target, WebGLRenderbuffer? renderbuffer);
    void bindTexture(GLenum target, WebGLTexture? texture);
    void blendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
    void blendEquation(GLenum mode);
    void blendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);
    void blendFunc(GLenum sfactor, GLenum dfactor);
    void blendFuncSeparate(GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);

    void bufferData(GLenum target, GLsizeiptr size, GLenum usage);
    void bufferData(GLenum target, ArrayBufferView data, GLenum usage);
    void bufferData(GLenum target, ArrayBuffer? data, GLenum usage);
    void bufferSubData(GLenum target, GLintptr offset, ArrayBufferView data);
    void bufferSubData(GLenum target, GLintptr offset, ArrayBuffer? data);

    [WebGLHandlesContextLoss]
    GLenum checkFramebufferStatus(GLenum target);
    void clear(GLbitfield mask);
    void clearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
    void clearDepth(GLclampf depth);
    void clearStencil(GLint s);
    void colorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
    void compileShader(WebGLShader? shader);

    void compressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, ArrayBufferView data);
    void compressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, ArrayBufferView data);

    void copyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
    void copyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);

    WebGLBuffer? createBuffer();
    WebGLFramebuffer? createFramebuffer();
    WebGLProgram? createProgram();
    WebGLRenderbuffer? createRenderbuffer();
    WebGLShader? createShader(GLenum type);
    WebGLTexture? createTexture();

    void cullFace(GLenum mode);

    void deleteBuffer(WebGLBuffer? buffer);
    void deleteFramebuffer(WebGLFramebuffer? framebuffer);
    void deleteProgram(WebGLProgram? program);
    void deleteRenderbuffer(WebGLRenderbuffer? renderbuffer);
    void deleteShader(WebGLShader? shader);
    void deleteTexture(WebGLTexture? texture);

    void depthFunc(GLenum func);
    void depthMask(GLboolean flag);
    void depthRange(GLclampf zNear, GLclampf zFar);
    void detachShader(WebGLProgram? program, WebGLShader? shader);
    void disable(GLenum cap);
    void disableVertexAttribArray(GLuint index);
    void drawArrays(GLenum mode, GLint first, GLsizei count);
    void drawElements(GLenum mode, GLsizei count, GLenum type, GLintptr offset);

    void enable(GLenum cap);
    void enableVertexAttribArray(GLuint index);
    void finish();
    void flush();
    void framebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, WebGLRenderbuffer? renderbuffer);
    void framebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, WebGLTexture? texture, GLint level);
    void frontFace(GLenum mode);

    void generateMipmap(GLenum target);

    [Creator]
    WebGLActiveInfo? getActiveAttrib(WebGLProgram? program, GLuint index);
    [Creator]
    WebGLActiveInfo? getActiveUniform(WebGLProgram? program, GLuint index);

    sequence<WebGLShader>? getAttachedShaders(WebGLProgram? program);

    [WebGLHandlesContextLoss]
    GLint getAttribLocation(WebGLProgram? program, DOMString name);

    any getBufferParameter(GLenum target, GLenum pname);
    [Throws]
    any getParameter(GLenum pname);

    [WebGLHandlesContextLoss]
    GLenum getError();

    [Throws]
    any getFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname);
    any getProgramParameter(WebGLProgram? program, GLenum pname);
    DOMString? getProgramInfoLog(WebGLProgram? program);
    any getRenderbufferParameter(GLenum target, GLenum pname);
    any getShaderParameter(WebGLShader? shader, GLenum pname);

    [Creator]
    WebGLShaderPrecisionFormat? getShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype);

    DOMString? getShaderInfoLog(WebGLShader? shader);

    DOMString? getShaderSource(WebGLShader? shader);

    any getTexParameter(GLenum target, GLenum pname);

    [Throws]
    any getUniform(WebGLProgram? program, WebGLUniformLocation? location);

    [Creator]
    WebGLUniformLocation? getUniformLocation(WebGLProgram? program, DOMString name);

    [Throws]
    any getVertexAttrib(GLuint index, GLenum pname);

    [WebGLHandlesContextLoss]
    GLsizeiptr getVertexAttribOffset(GLuint index, GLenum pname);

    void hint(GLenum target, GLenum mode);
    [WebGLHandlesContextLoss]
    GLboolean isBuffer(WebGLBuffer? buffer);
    [WebGLHandlesContextLoss]
    GLboolean isEnabled(GLenum cap);
    [WebGLHandlesContextLoss]
	GLboolean isFramebuffer(WebGLFramebuffer? framebuffer);
    [WebGLHandlesContextLoss]
	GLboolean isProgram(WebGLProgram? program);
    [WebGLHandlesContextLoss]
	GLboolean isRenderbuffer(WebGLRenderbuffer? renderbuffer);
    [WebGLHandlesContextLoss]
	GLboolean isShader(WebGLShader? shader);
    [WebGLHandlesContextLoss]
	GLboolean isTexture(WebGLTexture? texture);
    void lineWidth(GLfloat width);
    void linkProgram(WebGLProgram? program);
    void pixelStorei(GLenum pname, GLint param);
    void polygonOffset(GLfloat factor, GLfloat units);

    [Throws]
    void readPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels);

    void renderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
    void sampleCoverage(GLclampf value, GLboolean invert);
    void scissor(GLint x, GLint y, GLsizei width, GLsizei height);

    void shaderSource(WebGLShader? shader, DOMString source);

    void stencilFunc(GLenum func, GLint ref, GLuint mask);
    void stencilFuncSeparate(GLenum face, GLenum func, GLint ref, GLuint mask);
    void stencilMask(GLuint mask);
    void stencilMaskSeparate(GLenum face, GLuint mask);
    void stencilOp(GLenum fail, GLenum zfail, GLenum zpass);
    void stencilOpSeparate(GLenum face, GLenum fail, GLenum zfail, GLenum zpass);


    [Throws]
    void texImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, ArrayBufferView? pixels);
    [Throws]
    void texImage2D(GLenum target, GLint level, GLenum internalformat, GLenum format, GLenum type, ImageData? pixels);
    [Throws]
    void texImage2D(GLenum target, GLint level, GLenum internalformat, GLenum format, GLenum type, HTMLImageElement image);
    [Throws]
    void texImage2D(GLenum target, GLint level, GLenum internalformat, GLenum format, GLenum type, HTMLCanvasElement canvas);
    [Throws]
    void texImage2D(GLenum target, GLint level, GLenum internalformat, GLenum format, GLenum type, HTMLVideoElement video);

    void texParameterf(GLenum target, GLenum pname, GLfloat param);
    void texParameteri(GLenum target, GLenum pname, GLint param);

    [Throws]
    void texSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels);
    [Throws]
    void texSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, ImageData? pixels);
    [Throws]
    void texSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, HTMLImageElement image);
    [Throws]
    void texSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, HTMLCanvasElement canvas);
    [Throws]
    void texSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, HTMLVideoElement video);

    void uniform1f(WebGLUniformLocation? location, GLfloat x);
    void uniform1fv(WebGLUniformLocation? location, Float32Array v);
    void uniform1fv(WebGLUniformLocation? location, sequence<GLfloat> v);
    void uniform1i(WebGLUniformLocation? location, GLint x);
    void uniform1iv(WebGLUniformLocation? location, Int32Array v);
    void uniform1iv(WebGLUniformLocation? location, sequence<long> v);
    void uniform2f(WebGLUniformLocation? location, GLfloat x, GLfloat y);
    void uniform2fv(WebGLUniformLocation? location, Float32Array v);
    void uniform2fv(WebGLUniformLocation? location, sequence<GLfloat> v);
    void uniform2i(WebGLUniformLocation? location, GLint x, GLint y);
    void uniform2iv(WebGLUniformLocation? location, Int32Array v);
    void uniform2iv(WebGLUniformLocation? location, sequence<long> v);
    void uniform3f(WebGLUniformLocation? location, GLfloat x, GLfloat y, GLfloat z);
    void uniform3fv(WebGLUniformLocation? location, Float32Array v);
    void uniform3fv(WebGLUniformLocation? location, sequence<GLfloat> v);
    void uniform3i(WebGLUniformLocation? location, GLint x, GLint y, GLint z);
    void uniform3iv(WebGLUniformLocation? location, Int32Array v);
    void uniform3iv(WebGLUniformLocation? location, sequence<long> v);
    void uniform4f(WebGLUniformLocation? location, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    void uniform4fv(WebGLUniformLocation? location, Float32Array v);
    void uniform4fv(WebGLUniformLocation? location, sequence<GLfloat> v);
    void uniform4i(WebGLUniformLocation? location, GLint x, GLint y, GLint z, GLint w);
    void uniform4iv(WebGLUniformLocation? location, Int32Array v);
    void uniform4iv(WebGLUniformLocation? location, sequence<long> v);

    void uniformMatrix2fv(WebGLUniformLocation? location, GLboolean transpose, Float32Array value);
    void uniformMatrix2fv(WebGLUniformLocation? location, GLboolean transpose, sequence<GLfloat> value);
    void uniformMatrix3fv(WebGLUniformLocation? location, GLboolean transpose, Float32Array value);
    void uniformMatrix3fv(WebGLUniformLocation? location, GLboolean transpose, sequence<GLfloat> value);
    void uniformMatrix4fv(WebGLUniformLocation? location, GLboolean transpose, Float32Array value);
    void uniformMatrix4fv(WebGLUniformLocation? location, GLboolean transpose, sequence<GLfloat> value);

    void useProgram(WebGLProgram? program);
    void validateProgram(WebGLProgram? program);

    void vertexAttrib1f(GLuint indx, GLfloat x);
    void vertexAttrib1fv(GLuint indx, Float32Array values);
    void vertexAttrib1fv(GLuint indx, sequence<GLfloat> values);
    void vertexAttrib2f(GLuint indx, GLfloat x, GLfloat y);
    void vertexAttrib2fv(GLuint indx, Float32Array values);
    void vertexAttrib2fv(GLuint indx, sequence<GLfloat> values);
    void vertexAttrib3f(GLuint indx, GLfloat x, GLfloat y, GLfloat z);
    void vertexAttrib3fv(GLuint indx, Float32Array values);
    void vertexAttrib3fv(GLuint indx, sequence<GLfloat> values);
    void vertexAttrib4f(GLuint indx, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    void vertexAttrib4fv(GLuint indx, Float32Array values);
    void vertexAttrib4fv(GLuint indx, sequence<GLfloat> values);
    void vertexAttribPointer(GLuint indx, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLintptr offset);

    void viewport(GLint x, GLint y, GLsizei width, GLsizei height);
};
[NoInterfaceObject]
interface WebGLExtensionCompressedTextureS3TC {
    const GLenum COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
    const GLenum COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
    const GLenum COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;
    const GLenum COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;
};

[NoInterfaceObject]
interface WebGLExtensionCompressedTextureATC {
    const GLenum COMPRESSED_RGB_ATC_WEBGL = 0x8C92;
    const GLenum COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL = 0x8C93;
    const GLenum COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL = 0x87EE;
};

[NoInterfaceObject]
interface WebGLExtensionCompressedTexturePVRTC {
    const GLenum COMPRESSED_RGB_PVRTC_4BPPV1 = 0x8C00;
    const GLenum COMPRESSED_RGB_PVRTC_2BPPV1 = 0x8C01;
    const GLenum COMPRESSED_RGBA_PVRTC_4BPPV1 = 0x8C02;
    const GLenum COMPRESSED_RGBA_PVRTC_2BPPV1 = 0x8C03;
};

[NoInterfaceObject]
interface WebGLExtensionDebugRendererInfo {
    const GLenum UNMASKED_VENDOR_WEBGL = 0x9245;
    const GLenum UNMASKED_RENDERER_WEBGL = 0x9246;
};

[NoInterfaceObject]
interface WebGLExtensionDepthTexture {
    const GLenum UNSIGNED_INT_24_8_WEBGL = 0x84FA;
};

[NoInterfaceObject]
interface WebGLExtensionElementIndexUint {
};

[NoInterfaceObject]
interface WebGLExtensionLoseContext {
    void loseContext();
    void restoreContext();
};

[NoInterfaceObject]
interface WebGLExtensionTextureFilterAnisotropic {
    const GLenum TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
    const GLenum MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
};

[NoInterfaceObject]
interface WebGLExtensionStandardDerivatives {
    const GLenum FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B;
};

[NoInterfaceObject]
interface WebGLExtensionTextureFloat {
};

[NoInterfaceObject]
interface WebGLExtensionDrawBuffers {
    const GLenum COLOR_ATTACHMENT0_WEBGL = 0x8CE0;
    const GLenum COLOR_ATTACHMENT1_WEBGL = 0x8CE1;
    const GLenum COLOR_ATTACHMENT2_WEBGL = 0x8CE2;
    const GLenum COLOR_ATTACHMENT3_WEBGL = 0x8CE3;
    const GLenum COLOR_ATTACHMENT4_WEBGL = 0x8CE4;
    const GLenum COLOR_ATTACHMENT5_WEBGL = 0x8CE5;
    const GLenum COLOR_ATTACHMENT6_WEBGL = 0x8CE6;
    const GLenum COLOR_ATTACHMENT7_WEBGL = 0x8CE7;
    const GLenum COLOR_ATTACHMENT8_WEBGL = 0x8CE8;
    const GLenum COLOR_ATTACHMENT9_WEBGL = 0x8CE9;
    const GLenum COLOR_ATTACHMENT10_WEBGL = 0x8CEA;
    const GLenum COLOR_ATTACHMENT11_WEBGL = 0x8CEB;
    const GLenum COLOR_ATTACHMENT12_WEBGL = 0x8CEC;
    const GLenum COLOR_ATTACHMENT13_WEBGL = 0x8CED;
    const GLenum COLOR_ATTACHMENT14_WEBGL = 0x8CEE;
    const GLenum COLOR_ATTACHMENT15_WEBGL = 0x8CEF;

    const GLenum DRAW_BUFFER0_WEBGL = 0x8825;
    const GLenum DRAW_BUFFER1_WEBGL = 0x8826;
    const GLenum DRAW_BUFFER2_WEBGL = 0x8827;
    const GLenum DRAW_BUFFER3_WEBGL = 0x8828;
    const GLenum DRAW_BUFFER4_WEBGL = 0x8829;
    const GLenum DRAW_BUFFER5_WEBGL = 0x882A;
    const GLenum DRAW_BUFFER6_WEBGL = 0x882B;
    const GLenum DRAW_BUFFER7_WEBGL = 0x882C;
    const GLenum DRAW_BUFFER8_WEBGL = 0x882D;
    const GLenum DRAW_BUFFER9_WEBGL = 0x882E;
    const GLenum DRAW_BUFFER10_WEBGL = 0x882F;
    const GLenum DRAW_BUFFER11_WEBGL = 0x8830;
    const GLenum DRAW_BUFFER12_WEBGL = 0x8831;
    const GLenum DRAW_BUFFER13_WEBGL = 0x8832;
    const GLenum DRAW_BUFFER14_WEBGL = 0x8833;
    const GLenum DRAW_BUFFER15_WEBGL = 0x8834;

    const GLenum MAX_COLOR_ATTACHMENTS_WEBGL = 0x8CDF;
    const GLenum MAX_DRAW_BUFFERS_WEBGL = 0x8824;

    void drawBuffersWEBGL(sequence<GLenum> buffers);
};

[NoInterfaceObject]
interface WebGLExtensionTextureFloatLinear {
};

[NoInterfaceObject]
interface WebGLExtensionVertexArray {
    const GLenum VERTEX_ARRAY_BINDING_OES = 0x85B5;

    WebGLVertexArray? createVertexArrayOES();
    void deleteVertexArrayOES(WebGLVertexArray? arrayObject);
    [WebGLHandlesContextLoss]
	GLboolean isVertexArrayOES(WebGLVertexArray? arrayObject);
    void bindVertexArrayOES(WebGLVertexArray? arrayObject);
};
enum BinaryType {
  "blob",
  "arraybuffer"
};

[PrefControlled, Constructor(DOMString url), Constructor(DOMString url, DOMString protocols), Constructor(DOMString url, sequence<DOMString> protocols)]
interface WebSocket : EventTarget {

  readonly attribute DOMString url;


  const unsigned short CONNECTING = 0;
  const unsigned short OPEN = 1;
  const unsigned short CLOSING = 2;
  const unsigned short CLOSED = 3;

  readonly attribute unsigned short readyState;

  readonly attribute unsigned long bufferedAmount;



  [SetterThrows]
  attribute EventHandler onopen;

  [SetterThrows]
  attribute EventHandler onerror;

  [SetterThrows]
  attribute EventHandler onclose;

  readonly attribute DOMString extensions;

  readonly attribute DOMString protocol;

  [Throws]
  void close([Clamp] optional unsigned short code, optional DOMString reason);



  [SetterThrows]
  attribute EventHandler onmessage;

  attribute BinaryType binaryType;

  [Throws]
  void send(DOMString data);

  [Throws]
  void send(Blob data);

  [Throws]
  void send(ArrayBuffer data);

  [Throws]
  void send(ArrayBufferView data);
};
[Constructor(DOMString type, optional WheelEventInit eventInitDict)]
interface WheelEvent : MouseEvent {
  const unsigned long DOM_DELTA_PIXEL = 0x00;
  const unsigned long DOM_DELTA_LINE = 0x01;
  const unsigned long DOM_DELTA_PAGE = 0x02;

  readonly attribute double deltaX;
  readonly attribute double deltaY;
  readonly attribute double deltaZ;
  readonly attribute unsigned long deltaMode;

};

dictionary WheelEventInit : MouseEventInit {
  double deltaX = 0;
  double deltaY = 0;
  double deltaZ = 0;
  unsigned long deltaMode = 0;
};
callback FrameRequestCallback = void (DOMHighResTimeStamp time);
interface WorkerLocation {
};
WorkerLocation implements URLUtilsReadOnly;
interface WorkerNavigator {
  [Constant]
  readonly attribute DOMString appName;
  [Constant]
  readonly attribute DOMString appVersion;
  [Constant]
  readonly attribute DOMString platform;
  [Constant]
  readonly attribute DOMString userAgent;
};
interface XMLDocument : Document {
};


partial interface XMLDocument {
  [Throws]
  boolean load(DOMString url);
};


partial interface XMLDocument {
  attribute boolean async;
};
interface Blob;
interface InputStream;
interface MozChannel;
interface IID;

enum XMLHttpRequestResponseType {
  "",
  "arraybuffer",
  "blob",
  "document",
  "json",
  "text",
  "moz-chunked-text",
  "moz-chunked-arraybuffer",
  "moz-blob"
};
dictionary MozXMLHttpRequestParameters {
  boolean mozAnon = false;
  boolean mozSystem = false;
};

[Constructor(optional MozXMLHttpRequestParameters params), Constructor(DOMString ignored)]
interface XMLHttpRequest : XMLHttpRequestEventTarget {

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler onreadystatechange;


  const unsigned short UNSENT = 0;
  const unsigned short OPENED = 1;
  const unsigned short HEADERS_RECEIVED = 2;
  const unsigned short LOADING = 3;
  const unsigned short DONE = 4;

  readonly attribute unsigned short readyState;


  [Throws]
  void open(ByteString method, DOMString url, optional boolean async = true, optional DOMString? user, optional DOMString? password);
  [Throws]
  void setRequestHeader(ByteString header, ByteString value);

  [SetterThrows]
  attribute unsigned long timeout;

  [SetterThrows]
  attribute boolean withCredentials;

  [Throws=Workers]
  readonly attribute XMLHttpRequestUpload upload;

  [Throws]
  void send();
  [Throws]
  void send(ArrayBuffer data);
  [Throws]
  void send(ArrayBufferView data);
  [Throws]
  void send(Blob data);
  [Throws]
  void send(Document data);
  [Throws]
  void send(DOMString? data);
  [Throws]
  void send(FormData data);
  [Throws]
  void send(InputStream data);

  [Throws=Workers]
  void abort();


  [Throws=Workers]
  readonly attribute unsigned short status;

  readonly attribute ByteString statusText;
  [Throws]
  ByteString? getResponseHeader(ByteString header);

  [Throws=Workers]
  ByteString getAllResponseHeaders();

  [Throws=Workers]
  void overrideMimeType(DOMString mime);

  [SetterThrows]
  attribute XMLHttpRequestResponseType responseType;
  [Throws]
  readonly attribute any response;
  [Throws]
  readonly attribute DOMString? responseText;

  [Throws=MainThread]
  readonly attribute Document? responseXML;



  [SetterThrows=Workers]
  attribute boolean mozBackgroundRequest;

  [ChromeOnly]
  readonly attribute MozChannel? channel;

  [Throws]
  void sendAsBinary(DOMString body);
  [Throws, ChromeOnly]
  any getInterface(IID iid);

  readonly attribute boolean mozAnon;
  readonly attribute boolean mozSystem;
};
[NoInterfaceObject]
interface XMLHttpRequestEventTarget : EventTarget {

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler onloadstart;

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler onprogress;

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler onabort;

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler onerror;

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler onload;

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler ontimeout;

  [SetterThrows, GetterThrows=Workers]
  attribute EventHandler onloadend;
};
interface XMLHttpRequestUpload : XMLHttpRequestEventTarget {

};
interface OutputStream;

[Constructor]
interface XMLSerializer {
  [Throws]
  DOMString serializeToString(Node root);


  [Throws, ChromeOnly]
  void serializeToStream(Node root, OutputStream stream, DOMString? charset);
};
interface XMLStylesheetProcessingInstruction : ProcessingInstruction {
  readonly attribute StyleSheet? sheet;
};
interface XPathExpression;
interface XPathNSResolver;
interface XPathResult;

[Constructor]
interface XPathEvaluator {

  [Creator, Throws]
  XPathExpression createExpression(DOMString expression, XPathNSResolver? resolver);
  [Creator, Throws]
  XPathNSResolver createNSResolver(Node? nodeResolver);
  [Throws]
  XPathResult evaluate(DOMString expression, Node? contextNode, XPathNSResolver? resolver, unsigned short type, XPathResult? result);
};
interface WindowProxy;

 interface XULCommandEvent : UIEvent {
  readonly attribute boolean ctrlKey;
  readonly attribute boolean shiftKey;
  readonly attribute boolean altKey;
  readonly attribute boolean metaKey;

  readonly attribute Event? sourceEvent;

  [Throws]
  void initCommandEvent(DOMString type, boolean canBubble, boolean cancelable, WindowProxy? view, long detail, boolean ctrlKey, boolean altKey, boolean shiftKey, boolean metaKey, Event? sourceEvent);
};
interface XULCommandDispatcher;
interface MozBoxObject;
interface MozObserver;

interface XULDocument : Document {
           attribute Node? popupNode;
  [Throws, ChromeOnly]
  readonly attribute Node? popupRangeParent;
  [Throws, ChromeOnly]
  readonly attribute long popupRangeOffset;

           attribute Node? tooltipNode;

  readonly attribute XULCommandDispatcher? commandDispatcher;

  [Throws]
  readonly attribute long width;
  [Throws]
  readonly attribute long height;

  NodeList getElementsByAttribute(DOMString name, [TreatNullAs=EmptyString] DOMString value);
  [Throws]
  NodeList getElementsByAttributeNS(DOMString? namespaceURI, DOMString name, [TreatNullAs=EmptyString] DOMString value);

  [Throws]
  void addBroadcastListenerFor(Element broadcaster, Element observer, DOMString attr);
  void removeBroadcastListenerFor(Element broadcaster, Element observer, DOMString attr);

  [Throws]
  void persist([TreatNullAs=EmptyString] DOMString id, DOMString attr);

  [Throws]
  MozBoxObject? getBoxObjectFor(Element? element);

  [Throws]
  void loadOverlay(DOMString url, MozObserver? observer);
};
interface MozBoxObject;
interface MozControllers;
interface MozFrameLoader;
interface MozRDFCompositeDataSource;
interface MozRDFResource;
interface MozXULTemplateBuilder;

interface XULElement : Element {
  [SetterThrows]
  attribute DOMString className;


  [SetterThrows]
  attribute DOMString align;
  [SetterThrows]
  attribute DOMString dir;
  [SetterThrows]
  attribute DOMString flex;
  [SetterThrows]
  attribute DOMString flexGroup;
  [SetterThrows]
  attribute DOMString ordinal;
  [SetterThrows]
  attribute DOMString orient;
  [SetterThrows]
  attribute DOMString pack;


  attribute boolean hidden;
  attribute boolean collapsed;


  [SetterThrows]
  attribute DOMString observes;


  [SetterThrows]
  attribute DOMString menu;
  [SetterThrows]
  attribute DOMString contextMenu;
  [SetterThrows]
  attribute DOMString tooltip;


  [SetterThrows]
  attribute DOMString width;
  [SetterThrows]
  attribute DOMString height;
  [SetterThrows]
  attribute DOMString minWidth;
  [SetterThrows]
  attribute DOMString minHeight;
  [SetterThrows]
  attribute DOMString maxWidth;
  [SetterThrows]
  attribute DOMString maxHeight;


  [SetterThrows]
  attribute DOMString persist;




  [SetterThrows]
  attribute DOMString left;
  [SetterThrows]
  attribute DOMString top;


  [SetterThrows]
  attribute DOMString datasources;
  [SetterThrows]
  attribute DOMString ref;


  [SetterThrows]
  attribute DOMString tooltipText;
  [SetterThrows]
  attribute DOMString statusText;

  attribute boolean allowEvents;

  readonly attribute MozRDFCompositeDataSource? database;
  readonly attribute MozXULTemplateBuilder? builder;
  [Throws]
  readonly attribute MozRDFResource? resource;
  [Throws]
  readonly attribute MozControllers controllers;
  [Throws]
  readonly attribute MozBoxObject? boxObject;

  [Throws]
  void focus();
  [Throws]
  void blur();
  [Throws]
  void click();
  void doCommand();


  NodeList getElementsByAttribute(DOMString name, DOMString value);

  [Throws]
  NodeList getElementsByAttributeNS(DOMString namespaceURI, DOMString name, DOMString value);
  [Constant]
  readonly attribute CSSStyleDeclaration style;
};


[NoInterfaceObject]
interface MozFrameLoaderOwner {
  [ChromeOnly]
  readonly attribute MozFrameLoader? frameLoader;

  [ChromeOnly, Throws]
  void swapFrameLoaders(XULElement aOtherOwner);
};

XULElement implements GlobalEventHandlers;
XULElement implements NodeEventHandlers;
XULElement implements TouchEventHandlers;
XULElement implements MozFrameLoaderOwner;
