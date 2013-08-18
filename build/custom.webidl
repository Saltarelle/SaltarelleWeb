interface Float32Array;
interface Uint8Array;
interface ArrayBuffer;
interface ArrayBufferView;
interface DOMTimeStamp;
interface ByteString;
interface Uint8ClampedArray;
interface Int32Array;

interface WorkerUtils;

interface StyleSheetList {
	readonly attribute unsigned long length;
	getter StyleSheet item(unsigned long index);
};

////////////////////////////////////////////////////////////////////////////////////////////
// Storage
////////////////////////////////////////////////////////////////////////////////////////////

interface Storage {
	readonly attribute unsigned long length;
	DOMString? key(unsigned long index);
	getter DOMString getItem(DOMString key);
	setter creator void setItem(DOMString key, DOMString value);
	deleter void removeItem(DOMString key);
	void clear();
};

[NoInterfaceObject]
interface WindowSessionStorage {
  readonly attribute Storage sessionStorage;
};
WindowProxy implements WindowSessionStorage;

[NoInterfaceObject]
interface WindowLocalStorage {
  readonly attribute Storage localStorage;
};
WindowProxy implements WindowLocalStorage;


// No idea why this is commented out in the sources
[Constructor, Constructor((ArrayBuffer or ArrayBufferView or Blob or DOMString)[] blobParts, optional BlobPropertyBag options)] 
interface Blob {
	readonly attribute unsigned long long size;
	readonly attribute DOMString type;

	//slice Blob into byte-ranged chunks

	Blob slice(optional long long start,
	           optional long long end,
	           optional DOMString contentType);
	void close(); 
};

////////////////////////////////////////////////////////////////////////////////////////////
// IndexedDB
////////////////////////////////////////////////////////////////////////////////////////////

interface IDBKeyRange {
	readonly    attribute any     lower;
	readonly    attribute any     upper;
	readonly    attribute boolean lowerOpen;
	readonly    attribute boolean upperOpen;
	static IDBKeyRange only (any value);
	static IDBKeyRange lowerBound (any lower, optional boolean open);
	static IDBKeyRange upperBound (any upper, optional boolean open);
	static IDBKeyRange bound (any lower, any upper, optional boolean lowerOpen, optional boolean upperOpen);
};

[NoInterfaceObject]
interface IDBEnvironment {
	readonly    attribute IDBFactory indexedDB;
};

WindowProxy implements IDBEnvironment;
WorkerUtils implements IDBEnvironment;

////////////////////////////////////////////////////////////////////////////////////////////
// ApplicationCache
////////////////////////////////////////////////////////////////////////////////////////////

interface ApplicationCache : EventTarget {
	// update status
	const unsigned short UNCACHED = 0;
	const unsigned short IDLE = 1;
	const unsigned short CHECKING = 2;
	const unsigned short DOWNLOADING = 3;
	const unsigned short UPDATEREADY = 4;
	const unsigned short OBSOLETE = 5;
	readonly attribute unsigned short status;

	// updates
	void update();
	void abort();
	void swapCache();

	// events
	attribute EventHandler onchecking;
	attribute EventHandler onerror;
	attribute EventHandler onnoupdate;
	attribute EventHandler ondownloading;
	attribute EventHandler onprogress;
	attribute EventHandler onupdateready;
	attribute EventHandler oncached;
	attribute EventHandler onobsolete;
};

////////////////////////////////////////////////////////////////////////////////////////////
// WebWorkers
// http://www.w3.org/TR/workers/
////////////////////////////////////////////////////////////////////////////////////////////

[NoInterfaceObject]
interface WindowTimers {
	long setTimeout(Function func, optional long delay, any... args);
	long setTimeout(DOMString code, optional long delay);
	void clearTimeout(long timeoutId);
	long setInterval(Function func, optional long delay, any... args);
	long setInterval(DOMString code, optional long delay);
	void clearInterval(long intervalId);
};

[NoInterfaceObject]
interface WindowBase64 {
	DOMString atob(DOMString stringToEncode);
	DOMString btoa(DOMString encodedString);
};

[NoInterfaceObject]
interface Transferable { };

ArrayBuffer implements Transferable;
MessagePort implements Transferable;

interface MessagePort : EventTarget {
	void postMessage(any message, optional sequence<Transferable> transfer);
	void start();
	void close();

	// event handlers
	attribute EventHandler onmessage;
};

interface WorkerGlobalScope : EventTarget {
	readonly attribute WorkerGlobalScope self;
	readonly attribute WorkerLocation location;

	void close();
	attribute OnErrorEventHandler onerror;
	attribute EventHandler onoffline;
	attribute EventHandler ononline;
};

[Global]
/*sealed*/ interface DedicatedWorkerGlobalScope : WorkerGlobalScope {
	void postMessage(any message, optional sequence<Transferable> transfer);
	attribute EventHandler onmessage;
};

[Global]
/*sealed*/ interface SharedWorkerGlobalScope : WorkerGlobalScope {
	readonly attribute DOMString name;
	readonly attribute ApplicationCache applicationCache;
	attribute EventHandler onconnect;
};

[NoInterfaceObject]
interface AbstractWorker {
	attribute EventHandler onerror;
};

[Constructor(DOMString scriptURL)]
interface Worker : EventTarget {
	void terminate();

	void postMessage(any message, optional sequence<Transferable> transfer);
	attribute EventHandler onmessage;
};
Worker implements AbstractWorker;

[Constructor(DOMString scriptURL, optional DOMString name)]
interface SharedWorker : EventTarget {
	readonly attribute MessagePort port;
};
SharedWorker implements AbstractWorker;

[NoInterfaceObject]
partial interface WorkerGlobalScope {
	void importScripts(DOMString... urls);
	readonly attribute WorkerNavigator navigator;
};
WorkerGlobalScope implements WindowTimers;
WorkerGlobalScope implements WindowBase64;

interface DOMStringList {
  readonly attribute unsigned long length;
  getter DOMString? item(unsigned long index);
  boolean contains(DOMString string);
};

////////////////////////////////////////////////////////////////////////////////////////////
// WindowProxy
////////////////////////////////////////////////////////////////////////////////////////////

interface MediaQueryList {
	readonly attribute boolean matches;
	readonly attribute DOMString media;
	void addListener(MediaQueryListListener listener);
	void removeListener(MediaQueryListListener listener);
};

callback interface MediaQueryListListener {
	void handleChange(MediaQueryList mql);
};

interface WindowProxy : EventTarget {
	readonly attribute OfflineResourceList applicationCache;
	readonly attribute boolean closed;
	readonly attribute Crypto crypto;
	readonly attribute any dialogArguments;
	readonly attribute HTMLDocument document;
	readonly attribute HTMLElement frameElement;
	readonly attribute HTMLElement[] frames;
	         attribute boolean fullScreen;
	readonly attribute History history;
	readonly attribute long innerHeight;
	readonly attribute long innerWidth;
	readonly attribute long length;
	readonly attribute Location location;
	readonly attribute BarProp locationbar;
	readonly attribute BarProp menubar;
	         attribute DOMString name;
	readonly attribute Navigator navigator;
	readonly attribute WindowProxy opener;
	readonly attribute long outerHeight;
	readonly attribute long outerWidth;
	readonly attribute long pageXOffset;
	readonly attribute long pageYOffset;
	readonly attribute WindowProxy parent;
	readonly attribute Performance performance;
	readonly attribute BarProp personalbar;
	attribute any returnValue;
	readonly attribute Screen screen;
	readonly attribute long screenX;
	readonly attribute long screenY;
	readonly attribute BarProp scrollbars;
	readonly attribute long scrollMaxX;
	readonly attribute long scrollMaxY;
	readonly attribute long scrollX;
	readonly attribute long scrollY;
	readonly attribute WindowProxy self;
	         attribute DOMString status;
	readonly attribute BarProp statusbar;
	readonly attribute BarProp toolbar;
	readonly attribute WindowProxy top;
	readonly attribute WindowProxy window;

	void alert(DOMString message);
	void back();
	void blur();
	void close();
	boolean confirm(DOMString message);
	DOMString escape(DOMString regular);
	boolean find(DOMString aString, optional boolean aCaseSensitive, optional boolean aBackwards, optional boolean aWrapAround, optional boolean aWholeWord, optional boolean aSearchInFrames, optional boolean aShowDialog);
	void focus();
	CSSStyleDeclaration getComputedStyle(Element element, optional DOMString pseudoElt);
	Selection getSelection();
	MediaQueryList matchMedia(DOMString mediaQueryString);
	void moveBy(long deltaX, long deltaY);
	void moveTo(long x, long y);
	WindowProxy open(DOMString strUrl, optional DOMString strWindowName, optional DOMString strWindowFeatures);
	WindowProxy openDialog(DOMString url, optional DOMString name, optional DOMString features, any... args);
	void postMessage(any message, optional DOMString targetOrigin);
	void print();
	DOMString prompt(DOMString text, optional DOMString value);
	void resizeBy(long xDelta, long yDelta);
	void resizeTo(long iWidth, long iHeight);
	void scroll(long x, long y);
	void scrollBy(long xDelta, long yDelta);
	void scrollTo(long x, long y);
	any showModalDialog(DOMString uri, optional any arguments, optional DOMString options);
	void stop();
	DOMString unescape(DOMString escaped);
};

[NoInterfaceObject]
interface WindowDeviceEvents {
	[SetterThrows]
	attribute EventHandler ondevicelight;
	[SetterThrows]
	attribute EventHandler ondevicemotion;
	[SetterThrows]
	attribute EventHandler ondeviceorientation;
	[SetterThrows]
	attribute EventHandler ondeviceproximity;
	[SetterThrows]
	attribute EventHandler onuserproximity;
};

WindowProxy implements NodeEventHandlers;
WindowProxy implements WindowEventHandlers;
WindowProxy implements GlobalEventHandlers;
WindowProxy implements WindowDeviceEvents;

WindowProxy implements WindowTimers;
WindowProxy implements WindowBase64;

[NoInterfaceObject]
interface LineEndings {
	DOMString toNativeLineEndings(DOMString string);
};

Window implements LineEndings;
WorkerGlobalScope implements LineEndings;

////////////////////////////////////////////////////////////////////////////////////////////
// File
// http://www.w3.org/TR/FileAPI/
////////////////////////////////////////////////////////////////////////////////////////////

interface File : Blob {
  readonly attribute DOMString name;
  readonly attribute Date lastModifiedDate;
};

////////////////////////////////////////////////////////////////////////////////////////////
// Drag-drop
// http://www.whatwg.org/specs/web-apps/current-work/multipage/dnd.html
////////////////////////////////////////////////////////////////////////////////////////////

interface DataTransfer {
           attribute DropEffect dropEffect;
           attribute AllowedDropEffect effectAllowed;

  readonly attribute DataTransferItemList items;

  void setDragImage(Element image, long x, long y);

  /* old interface */
  readonly attribute DOMString[] types;
  DOMString getData(DOMString format);
  void setData(DOMString format, DOMString data);
  void clearData(optional DOMString format);
  readonly attribute FileList files;
};

interface DataTransferItemList {
  readonly attribute unsigned long length;
  getter DataTransferItem (unsigned long index);
  void remove(unsigned long index);
  void clear();

  DataTransferItem? add(DOMString data, DOMString type);
  DataTransferItem? add(File data);
};

interface DataTransferItem {
  readonly attribute DataTransferItemKind kind;
  readonly attribute DOMString type;
  void getAsString(FunctionStringCallback? _callback);
  File? getAsFile();
};

callback FunctionStringCallback = void (DOMString data);

enum DropEffect { "none", "copy", "link", "move" };
enum AllowedDropEffect { "none", "copy", "copyLink", "copyMove", "link", "linkMove", "move", "all", "uninitialized" };
enum DataTransferItemKind { "string", "file" };


////////////////////////////////////////////////////////////////////////////////////////////
// Editing
// https://dvcs.w3.org/hg/editing/raw-file/tip/editing.html#concept-selection
////////////////////////////////////////////////////////////////////////////////////////////

interface Selection {
  readonly attribute Node? anchorNode;
  readonly attribute unsigned long anchorOffset;
  readonly attribute Node? focusNode;
  readonly attribute unsigned long focusOffset;

  readonly attribute boolean isCollapsed;
  void               collapse(Node node, unsigned long offset);
  void               collapseToStart();
  void               collapseToEnd();

  void               extend(Node node, unsigned long offset);

  void               selectAllChildren(Node node);
  void               deleteFromDocument();

  readonly attribute unsigned long rangeCount;
  Range              getRangeAt(unsigned long index);
  void               addRange(Range range);
  void               removeRange(Range range);
  void               removeAllRanges();

  stringifier;
};

////////////////////////////////////////////////////////////////////////////////////////////
// XPath
// http://www.w3.org/TR/DOM-Level-3-XPath/xpath.html
////////////////////////////////////////////////////////////////////////////////////////////

interface XPathNSResolver {
  DOMString          lookupNamespaceURI(DOMString prefix);
};

interface XPathResult {

  // XPathResultType
  const unsigned short      ANY_TYPE                       = 0;
  const unsigned short      NUMBER_TYPE                    = 1;
  const unsigned short      STRING_TYPE                    = 2;
  const unsigned short      BOOLEAN_TYPE                   = 3;
  const unsigned short      UNORDERED_NODE_ITERATOR_TYPE   = 4;
  const unsigned short      ORDERED_NODE_ITERATOR_TYPE     = 5;
  const unsigned short      UNORDERED_NODE_SNAPSHOT_TYPE   = 6;
  const unsigned short      ORDERED_NODE_SNAPSHOT_TYPE     = 7;
  const unsigned short      ANY_UNORDERED_NODE_TYPE        = 8;
  const unsigned short      FIRST_ORDERED_NODE_TYPE        = 9;

  readonly attribute unsigned short  resultType;
  readonly attribute double          numberValue;
                                        // raises(XPathException) on retrieval

  readonly attribute DOMString       stringValue;
                                        // raises(XPathException) on retrieval

  readonly attribute boolean         booleanValue;
                                        // raises(XPathException) on retrieval

  readonly attribute Node            singleNodeValue;
                                        // raises(XPathException) on retrieval

  readonly attribute boolean         invalidIteratorState;
  readonly attribute unsigned long   snapshotLength;
                                        // raises(XPathException) on retrieval

  Node               iterateNext();
  Node               snapshotItem(unsigned long index);
};

interface XPathExpression {
	XPathResult evaluate(Node contextNode, unsigned short type, XPathResult result);
};

////////////////////////////////////////////////////////////////////////////////////////////
// CSS
// http://dev.w3.org/csswg/cssom/
////////////////////////////////////////////////////////////////////////////////////////////

interface CSSRule {
  const unsigned short STYLE_RULE = 1;
  const unsigned short CHARSET_RULE = 2;
  const unsigned short IMPORT_RULE = 3;
  const unsigned short MEDIA_RULE = 4;
  const unsigned short FONT_FACE_RULE = 5;
  const unsigned short PAGE_RULE = 6;
  const unsigned short NAMESPACE_RULE = 10;
  readonly attribute unsigned short type;
  attribute DOMString cssText;
  readonly attribute CSSRule? parentRule;
  readonly attribute CSSStyleSheet? parentStyleSheet;
};

interface MediaList {
	[TreatNullAs=EmptyString] stringifier attribute DOMString mediaText;
	readonly attribute unsigned long length;
	getter DOMString item(unsigned long index);
	void appendMedium(DOMString medium);
	void deleteMedium(DOMString medium);
};

// http://zvon.org/xxl/DOM2reference/Output/Style/interface_Counter.html

interface Counter {
	readonly attribute DOMString identifier;
	readonly attribute DOMString listStyle;
	readonly attribute DOMString separator;
};

////////////////////////////////////////////////////////////////////////////////////////////
// SVG
// http://www.w3.org/TR/SVG/types.html
////////////////////////////////////////////////////////////////////////////////////////////

interface SVGNumber {
  attribute float value;
};

interface SVGLength {

  // Length Unit Types
  const unsigned short SVG_LENGTHTYPE_UNKNOWN = 0;
  const unsigned short SVG_LENGTHTYPE_NUMBER = 1;
  const unsigned short SVG_LENGTHTYPE_PERCENTAGE = 2;
  const unsigned short SVG_LENGTHTYPE_EMS = 3;
  const unsigned short SVG_LENGTHTYPE_EXS = 4;
  const unsigned short SVG_LENGTHTYPE_PX = 5;
  const unsigned short SVG_LENGTHTYPE_CM = 6;
  const unsigned short SVG_LENGTHTYPE_MM = 7;
  const unsigned short SVG_LENGTHTYPE_IN = 8;
  const unsigned short SVG_LENGTHTYPE_PT = 9;
  const unsigned short SVG_LENGTHTYPE_PC = 10;

  readonly attribute unsigned short unitType;
           attribute float value;
           attribute float valueInSpecifiedUnits;
           attribute DOMString valueAsString;

  void newValueSpecifiedUnits(unsigned short unitType, float valueInSpecifiedUnits);
  void convertToSpecifiedUnits(unsigned short unitType);
};

////////////////////////////////////////////////////////////////////////////////////////////
// Device events
// http://www.w3.org/TR/orientation-event/
////////////////////////////////////////////////////////////////////////////////////////////

[NoInterfaceObject]
interface DeviceAcceleration {
	readonly attribute double? x;
	readonly attribute double? y;
	readonly attribute double? z;
};

[NoInterfaceObject]
interface DeviceRotationRate {
	readonly attribute double? alpha;
	readonly attribute double? beta;
	readonly attribute double? gamma;
};


////////////////////////////////////////////////////////////////////////////////////////////
// Web audio
// https://dvcs.w3.org/hg/audio/raw-file/tip/webaudio/specification.html
////////////////////////////////////////////////////////////////////////////////////////////

enum OscillatorType {
  "sine",
  "square",
  "sawtooth",
  "triangle",
  "custom"
};

interface OscillatorNode : AudioNode {
    attribute OscillatorType type;

    readonly attribute AudioParam frequency; // in Hertz
    readonly attribute AudioParam detune; // in Cents

    void start(double when);
    void stop(double when);
    void setPeriodicWave(PeriodicWave periodicWave);

    attribute EventHandler onended;
};

interface WaveTable {
};
