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


[NoInterfaceObject]
interface NavigatorDataStore {
    [Throws, NewObject, Pref="dom.datastore.enabled"]
    Promise getDataStores(DOMString name);
};
Navigator implements NavigatorDataStore;


partial interface Navigator {


    boolean vibrate(unsigned long duration);
    boolean vibrate(sequence<unsigned long> pattern);
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
partial interface Navigator {
  [Throws, Func="Navigator::HasTelephonySupport"]
  readonly attribute Telephony? mozTelephony;
};



partial interface Navigator {
  [Throws, Pref="dom.gamepad.enabled"]
  sequence<Gamepad?> getGamepads();
};
partial interface Navigator {
  [Throws, Func="Navigator::HasTimeSupport"]
  readonly attribute MozTimeManager mozTime;
};




partial interface Navigator {
  [Throws]
  readonly attribute AudioChannelManager mozAudioChannelManager;
};



callback NavigatorUserMediaSuccessCallback = void (MediaStream stream);
callback NavigatorUserMediaErrorCallback = void (DOMString error);

partial interface Navigator {
  [Throws, Func="Navigator::HasUserMediaSupport"]
  void mozGetUserMedia(MediaStreamConstraints constraints,
                       NavigatorUserMediaSuccessCallback successCallback,
                       NavigatorUserMediaErrorCallback errorCallback);
};


callback MozGetUserMediaDevicesSuccessCallback = void (nsIVariant? devices);
partial interface Navigator {
  [Throws, ChromeOnly]
  void mozGetUserMediaDevices(MediaStreamConstraintsInternal constraints,
                              MozGetUserMediaDevicesSuccessCallback onsuccess,
                              NavigatorUserMediaErrorCallback onerror);
};
