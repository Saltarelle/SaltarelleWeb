/* -*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
/* vim: set ts=2 et sw=2 tw=80: */
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this file,
 * You can obtain one at http://mozilla.org/MPL/2.0/.
 */

enum CameraMode { "picture", "video" };

/* Used for the dimensions of a captured picture,
   a preview stream, a video capture stream, etc. */
dictionary CameraSize
{
  unsigned long width = 0;
  unsigned long height = 0;
};

/* Pre-emptive camera configuration options. */
dictionary CameraConfiguration
{
  CameraMode mode = "picture";
  CameraSize previewSize = null;
  DOMString recorderProfile = "cif";  // or some other recording profile
                                      // supported by the CameraControl
};

callback CameraErrorCallback = void (DOMString error);

callback GetCameraCallback = void (CameraControl camera,
                                   CameraConfiguration configuration);

interface CameraManager
{
  /* get a camera instance; 'camera' is one of the camera
     identifiers returned by getListOfCameras() below.
  */
  [Throws]
  void getCamera(DOMString camera,
                 CameraConfiguration initialConfiguration,
                 GetCameraCallback callback,
                 optional CameraErrorCallback errorCallback);

  /* return an array of camera identifiers, e.g.
       [ "front", "back" ]
   */
  [Throws]
  sequence<DOMString> getListOfCameras();
};
