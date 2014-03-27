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
