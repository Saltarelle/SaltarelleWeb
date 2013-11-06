interface Float32Array;
interface Uint8Array;
interface ArrayBuffer;
interface ArrayBufferView;
interface DOMTimeStamp;
interface ByteString;
interface Uint8ClampedArray;
interface Int32Array;

interface StyleSheetList {
	readonly attribute unsigned long length;
	getter StyleSheet item(unsigned long index);
};

interface nsIDOMCrypto {};

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

interface DOMStringList {
  readonly attribute unsigned long length;
  getter DOMString? item(unsigned long index);
  boolean contains(DOMString string);
};

interface MediaQueryList {
	readonly attribute boolean matches;
	readonly attribute DOMString media;
	void addListener(MediaQueryListListener listener);
	void removeListener(MediaQueryListListener listener);
};

callback interface MediaQueryListListener {
	void handleChange(MediaQueryList mql);
};

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
