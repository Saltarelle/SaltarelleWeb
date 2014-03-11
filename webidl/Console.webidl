/* -*- Mode: IDL; tab-width: 8; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
/* vim: set ts=2 et sw=2 tw=80: */
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

[ChromeOnly]
interface Console {
  void log(any... data);
  void info(any... data);
  void warn(any... data);
  void error(any... data);
  void _exception(any... data);
  void debug(any... data);
  void trace();
  void dir(any... data);
  void group(any... data);
  void groupCollapsed(any... data);
  void groupEnd(any... data);
  void time(any time);
  void timeEnd(any time);

  [Throws]
  void profile(any... data);

  [Throws]
  void profileEnd(any... data);

  void assert(boolean condition, any... data);
  void count(any... data);

  void ___noSuchMethod__();
};

// This is used to propagate console events to the observers.
dictionary ConsoleEvent {
  (unsigned long or DOMString) ID;
  (unsigned long or DOMString) innerID;
  DOMString level = "";
  DOMString filename = "";
  unsigned long lineNumber = 0;
  DOMString functionName = "";
  double timeStamp = 0;
  sequence<any> arguments;
  boolean private = false;
  sequence<ConsoleStackEntry> stacktrace;
  DOMString groupName = "";
  any timer = null;
  any counter = null;
};

// Event for profile operations
dictionary ConsoleProfileEvent {
  DOMString action = "";
  sequence<any> arguments;
};

// This dictionary is used to manage stack trace data.
dictionary ConsoleStackEntry {
  DOMString filename = "";
  unsigned long lineNumber = 0;
  DOMString functionName = "";
  unsigned long language = 0;
};

dictionary ConsoleTimerStart {
  DOMString name = "";
  double started = 0;
};

dictionary ConsoleTimerEnd {
  DOMString name = "";
  double duration = 0;
};

dictionary ConsoleTimerError {
  DOMString error = "maxTimersExceeded";
};

dictionary ConsoleCounter {
  DOMString label = "";
  unsigned long count = 0;
};

dictionary ConsoleCounterError {
  DOMString error = "maxCountersExceeded";
};
