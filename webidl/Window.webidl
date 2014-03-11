interface ApplicationCache;
interface MozFrameRequestCallback;
interface nsIBrowserDOMWindow;
interface nsIMessageBroadcaster;
interface nsIDOMCrypto;
typedef any Transferable;


[Global, NeedNewResolve]
 interface Window : EventTarget {

  [Unforgeable, Throws,
   CrossOriginReadable] readonly attribute WindowProxy window;
  [Replaceable, Throws,
   CrossOriginReadable] readonly attribute WindowProxy self;

  [Throws] attribute DOMString name;
  [PutForwards=href, Unforgeable, Throws,
   CrossOriginReadable, CrossOriginWritable] readonly attribute Location? location;
  [Throws] readonly attribute History history;
  [Replaceable, Throws] readonly attribute BarProp locationbar;
  [Replaceable, Throws] readonly attribute BarProp menubar;
  [Replaceable, Throws] readonly attribute BarProp personalbar;
  [Replaceable, Throws] readonly attribute BarProp scrollbars;
  [Replaceable, Throws] readonly attribute BarProp statusbar;
  [Replaceable, Throws] readonly attribute BarProp toolbar;
  [Throws] attribute DOMString status;
  [Throws, CrossOriginCallable] void close();
  [Throws, CrossOriginReadable] readonly attribute boolean closed;
  [Throws] void stop();
  [Throws, CrossOriginCallable] void focus();
  [Throws, CrossOriginCallable] void blur();


  [Replaceable, Throws, CrossOriginReadable] readonly attribute WindowProxy frames;
  [Replaceable, CrossOriginReadable] readonly attribute unsigned long length;
  [Unforgeable, Throws, CrossOriginReadable] readonly attribute WindowProxy top;
  [Throws, CrossOriginReadable] attribute WindowProxy? opener;

  [Replaceable, Throws, CrossOriginReadable] readonly attribute WindowProxy? parent;
  [Throws] readonly attribute Element? frameElement;

  [Throws] WindowProxy? open(optional DOMString url = "", optional DOMString target = "", optional DOMString features = "");






  [Throws] readonly attribute Navigator navigator;

  [Throws] readonly attribute ApplicationCache applicationCache;


  [Throws] void alert(optional DOMString message = "");
  [Throws] boolean confirm(optional DOMString message = "");
  [Throws] DOMString? prompt(optional DOMString message = "", optional DOMString default = "");
  [Throws] void print();

  [Throws] any showModalDialog(DOMString url, any argument, optional DOMString options = "");

  [Throws, CrossOriginCallable] void postMessage(any message, DOMString targetOrigin, optional sequence<Transferable> transfer);


};
Window implements GlobalEventHandlers;
Window implements WindowEventHandlers;


[NoInterfaceObject]
interface WindowTimers {
  [Throws] long setTimeout(Function handler, optional long timeout = 0, any... arguments);
  [Throws] long setTimeout(DOMString handler, optional long timeout = 0, any... unused);
  [Throws] void clearTimeout(optional long handle = 0);
  [Throws] long setInterval(Function handler, optional long timeout, any... arguments);
  [Throws] long setInterval(DOMString handler, optional long timeout, any... unused);
  [Throws] void clearInterval(optional long handle = 0);
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
  void captureEvents();
  void releaseEvents();
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

  [Throws,NewObject] MediaQueryList? matchMedia(DOMString query);

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


  [ChromeOnly, Replaceable, Throws] readonly attribute MozControllers controllers;

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

  [ChromeOnly, Throws] readonly attribute object? __content;
};

Window implements TouchEventHandlers;

Window implements OnErrorEventHandlerForWindow;


partial interface Window {
  [Replaceable, GetterThrows]
  readonly attribute Console console;
};


[ChromeOnly] interface ChromeWindow {
  [Func="nsGlobalWindow::IsChromeWindow"]
  const unsigned short STATE_MAXIMIZED = 1;
  [Func="nsGlobalWindow::IsChromeWindow"]
  const unsigned short STATE_MINIMIZED = 2;
  [Func="nsGlobalWindow::IsChromeWindow"]
  const unsigned short STATE_NORMAL = 3;
  [Func="nsGlobalWindow::IsChromeWindow"]
  const unsigned short STATE_FULLSCREEN = 4;

  [Func="nsGlobalWindow::IsChromeWindow"]
  readonly attribute unsigned short windowState;
  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
           attribute nsIBrowserDOMWindow? browserDOMWindow;

  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void getAttention();

  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void getAttentionWithCycleCount(long aCycleCount);

  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void setCursor(DOMString cursor);

  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void maximize();
  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void minimize();
  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void restore();
  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void notifyDefaultButtonLoaded(Element defaultButton);

  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  readonly attribute nsIMessageBroadcaster messageManager;
  [Throws, Func="nsGlobalWindow::IsChromeWindow"]
  void beginWindowMove(Event mouseDownEvent, optional Element? panel = null);
};

Window implements ChromeWindow;
