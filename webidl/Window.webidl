interface ApplicationCache;
interface MediaQueryList;
interface MozFrameRequestCallback;
interface nsIDOMCrypto;
interface Pkcs11;
typedef any Transferable;


[Global]
 interface Window : EventTarget {

  [Unforgeable, Throws] readonly attribute WindowProxy window;
  [Replaceable, Throws] readonly attribute WindowProxy self;

  [Throws] attribute DOMString name;
  [PutForwards=href, Unforgeable, Throws] readonly attribute Location? location;
  [Throws] readonly attribute History history;
  [Replaceable, Throws] readonly attribute BarProp locationbar;
  [Replaceable, Throws] readonly attribute BarProp menubar;
  [Replaceable, Throws] readonly attribute BarProp personalbar;
  [Replaceable, Throws] readonly attribute BarProp scrollbars;
  [Replaceable, Throws] readonly attribute BarProp statusbar;
  [Replaceable, Throws] readonly attribute BarProp toolbar;
  [Throws] attribute DOMString status;
  [Throws] void close();
  [Throws] readonly attribute boolean closed;
  [Throws] void stop();
  [Throws] void focus();
  [Throws] void blur();


  [Replaceable, Throws] readonly attribute WindowProxy frames;
  [Replaceable] readonly attribute unsigned long length;
  [Unforgeable, Throws] readonly attribute WindowProxy top;
  [Throws] attribute WindowProxy? opener;

  [Replaceable, Throws] readonly attribute WindowProxy? parent;
  [Throws] readonly attribute Element? frameElement;

  [Throws] WindowProxy? open(optional DOMString url = "", optional DOMString target = "", optional DOMString features = "");






  [Throws] readonly attribute Navigator navigator;

  [Throws] readonly attribute ApplicationCache applicationCache;


  [Throws] void alert(optional DOMString message = "");
  [Throws] boolean confirm(optional DOMString message = "");
  [Throws] DOMString? prompt(optional DOMString message = "", optional DOMString default = "");
  [Throws] void print();

  [Throws] any showModalDialog(DOMString url, optional any argument, optional DOMString options = "");

  [Throws] void postMessage(any message, DOMString targetOrigin, optional sequence<Transferable> transfer);


};
Window implements GlobalEventHandlers;
Window implements WindowEventHandlers;


[NoInterfaceObject]
interface WindowTimers {
  [Throws] long setTimeout(Function handler, optional long timeout = 0, any... arguments);
  [Throws] long setTimeout(DOMString handler, optional long timeout = 0);
  [Throws] void clearTimeout(long handle);
  [Throws] long setInterval(Function handler, optional long timeout, any... arguments);
  [Throws] long setInterval(DOMString handler, optional long timeout);
  [Throws] void clearInterval(long handle);
};
Window implements WindowTimers;


[NoInterfaceObject]
interface WindowBase64 {
  [Throws] DOMString btoa(DOMString btoa);
  [Throws] DOMString atob(DOMString atob);
};
Window implements WindowBase64;


[NoInterfaceObject]
interface WindowSessionStorage {

  [Throws] readonly attribute Storage? sessionStorage;
};
Window implements WindowSessionStorage;


[NoInterfaceObject]
interface WindowLocalStorage {
  [Throws] readonly attribute Storage? localStorage;
};
Window implements WindowLocalStorage;


partial interface Window {
  void captureEvents(long dummy);
  void releaseEvents(long dummy);
};


partial interface Window {

  [Throws] Selection? getSelection();
};


Window implements IDBEnvironment;


partial interface Window {

  [NewObject, Throws] CSSStyleDeclaration? getComputedStyle(Element elt, optional DOMString pseudoElt = "");
};


enum ScrollBehavior { "auto", "instant", "smooth" };

dictionary ScrollOptions {
  ScrollBehavior behavior = "auto";
};

partial interface Window {

  [Throws] MediaQueryList? matchMedia(DOMString query);

  [Throws] readonly attribute Screen screen;






  [Throws] void moveTo(long x, long y);
  [Throws] void moveBy(long x, long y);
  [Throws] void resizeTo(long x, long y);
  [Throws] void resizeBy(long x, long y);




  [Throws] attribute long innerWidth;
  [Throws] attribute long innerHeight;









  [Replaceable, Throws] readonly attribute long scrollX;
  [Throws] readonly attribute long pageXOffset;
  [Replaceable, Throws] readonly attribute long scrollY;
  [Throws] readonly attribute long pageYOffset;
  void scroll(long x, long y);
  void scrollTo(long x, long y);
  void scrollBy(long x, long y);






  [Throws] attribute long screenX;
  [Throws] attribute long screenY;
  [Throws] attribute long outerWidth;
  [Throws] attribute long outerHeight;
};


partial interface Window {
  [Throws] long requestAnimationFrame(FrameRequestCallback callback);
  [Throws] void cancelAnimationFrame(long handle);
};
callback FrameRequestCallback = void (DOMHighResTimeStamp time);


partial interface Window {
  [Replaceable, Throws] readonly attribute Performance? performance;
};


partial interface Window {

  [Throws] readonly attribute nsIDOMCrypto crypto;
};



[NoInterfaceObject]
interface SpeechSynthesisGetter {
  [Throws, Pref="media.webspeech.synth.enabled"] readonly attribute SpeechSynthesis speechSynthesis;
};

Window implements SpeechSynthesisGetter;



partial interface Window {

  [NewObject, Throws] CSSStyleDeclaration? getDefaultComputedStyle(Element elt, optional DOMString pseudoElt = "");

  [Throws] long mozRequestAnimationFrame(MozFrameRequestCallback aCallback);
  [Throws] void mozCancelAnimationFrame(long aHandle);

  [Throws] void mozCancelRequestAnimationFrame(long aHandle);
  [Throws] readonly attribute long long mozAnimationStartTime;
  void scrollByLines(long numLines);
  void scrollByPages(long numPages);
  [Throws] void sizeToContent();

  readonly attribute Pkcs11? pkcs11;


  [Replaceable, Throws] readonly attribute MozControllers controllers;

  [Throws] readonly attribute float mozInnerScreenX;
  [Throws] readonly attribute float mozInnerScreenY;
  [Throws] readonly attribute float devicePixelRatio;
  [Replaceable, Throws] readonly attribute long scrollMaxX;
  [Replaceable, Throws] readonly attribute long scrollMaxY;

  [Throws] attribute boolean fullScreen;

  [Throws] void back();
  [Throws] void forward();
  [Throws] void home();


  void updateCommands(DOMString action);
  [Throws] boolean find(optional DOMString str = "",
                                 optional boolean caseSensitive = false,
                                 optional boolean backwards = false,
                                 optional boolean wrapAround = false,
                                 optional boolean wholeWord = false,
                                 optional boolean searchInFrames = false,
                                 optional boolean showDialog = false);
  [Throws] readonly attribute unsigned long long mozPaintCount;

           attribute EventHandler ondevicemotion;
           attribute EventHandler ondeviceorientation;
           attribute EventHandler ondeviceproximity;
           attribute EventHandler onuserproximity;
           attribute EventHandler ondevicelight;
  void dump(DOMString str);
  void setResizable(boolean resizable);
  [Throws, ChromeOnly] WindowProxy? openDialog(optional DOMString url = "",
                                               optional DOMString name = "",
                                               optional DOMString options = "",
                                               any... extraArguments);

  [Replaceable, Throws] readonly attribute object? content;
};

Window implements TouchEventHandlers;

Window implements OnErrorEventHandlerForWindow;
