﻿/* -*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * The origin of this IDL file is
 * http://www.w3.org/TR/battery-status/
 *
 * Copyright Â© 2012 W3CÂ® (MIT, ERCIM, Keio), All Rights Reserved. W3C
 * liability, trademark and document use rules apply.
 */

interface BatteryManager : EventTarget {
    readonly attribute boolean             charging;
    readonly attribute unrestricted double chargingTime;
    readonly attribute unrestricted double dischargingTime;
    readonly attribute double              level;

    [SetterThrows]
             attribute EventHandler        onchargingchange;
    [SetterThrows]
             attribute EventHandler        onchargingtimechange;
    [SetterThrows]
             attribute EventHandler        ondischargingtimechange;
    [SetterThrows]
             attribute EventHandler        onlevelchange;
};

