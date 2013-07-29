﻿/* -*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this file,
 * You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * The origin of this IDL file is
 * http://dvcs.w3.org/hg/undomanager/raw-file/tip/undomanager.html
 *
 * Copyright Â© 2012 W3CÂ® (MIT, ERCIM, Keio), All Rights Reserved. W3C
 * liability, trademark and document use rules apply.
 */

callback DOMTransactionCallback = void();

callback interface DOMTransaction {
  readonly attribute DOMString? label;
  readonly attribute DOMTransactionCallback? executeAutomatic;
  readonly attribute DOMTransactionCallback? execute;
  readonly attribute DOMTransactionCallback? undo;
  readonly attribute DOMTransactionCallback? redo;
};


