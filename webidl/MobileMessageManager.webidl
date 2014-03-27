/* -*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this file,
 * You can obtain one at http://mozilla.org/MPL/2.0/.
 */

dictionary MmsParameters {
  sequence<DOMString> receivers;
  DOMString? subject = null;
  DOMString? smil = null;
  sequence<MmsAttachment> attachments;
};

// If we start using MmsParameters here, remove it from DummyBinding.

dictionary SmsSendParameters {
  unsigned long serviceId; // The ID of the RIL service which needs to be
                           // specified under the multi-sim scenario.
};

dictionary MmsSendParameters {
  unsigned long serviceId; // The ID of the RIL service which needs to be
                           // specified under the multi-sim scenario.
};
