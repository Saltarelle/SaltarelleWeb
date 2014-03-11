/* -*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this file,
 * You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * The origin of this IDL file is
 * https://dvcs.w3.org/hg/IndexedDB/raw-file/tip/Overview.html#idl-def-IDBObjectStore
 */

dictionary IDBObjectStoreParameters {
    // TODO (DOMString or sequence<DOMString>)? keyPath = null;
    any                                         keyPath = null;
    boolean                             autoIncrement = false;
};

interface IDBObjectStore {
    readonly    attribute DOMString      name;

    [Throws]
    readonly    attribute any            keyPath;

    [Throws]
    readonly    attribute DOMStringList  indexNames;
    readonly    attribute IDBTransaction transaction;
    readonly    attribute boolean        autoIncrement;

    [Throws]
    IDBRequest put (any value, any key);

    [Throws]
    IDBRequest add (any value, any key);

    [Throws]
    IDBRequest delete (any key);

    [Throws]
    IDBRequest get (any key);

    [Throws]
    IDBRequest clear ();

    [Throws]
    IDBRequest openCursor (any range, optional IDBCursorDirection direction = "next");

    // Bug 899972
    // IDBIndex   createIndex (DOMString name, (DOMString or sequence<DOMString>) keyPath, optional IDBIndexParameters optionalParameters);

    [Throws]
    IDBIndex   createIndex (DOMString name, DOMString keyPath, optional IDBIndexParameters optionalParameters);

    [Throws]
    IDBIndex   createIndex (DOMString name, sequence<DOMString> keyPath, optional IDBIndexParameters optionalParameters);

    [Throws]
    IDBIndex   index (DOMString name);

    [Throws]
    void       deleteIndex (DOMString indexName);

    [Throws]
    IDBRequest count (any key);
};

partial interface IDBObjectStore {
    // Success fires IDBTransactionEvent, result == array of values for given keys
    [Throws]
    IDBRequest mozGetAll (any key, optional unsigned long limit);

    [Pref="dom.indexedDB.experimental", Throws]
    IDBRequest getAll (any key, optional unsigned long limit);

    [Pref="dom.indexedDB.experimental", Throws]
    IDBRequest getAllKeys (any key, optional unsigned long limit);

    [Pref="dom.indexedDB.experimental", Throws]
    IDBRequest openKeyCursor (any range, optional IDBCursorDirection direction = "next");
};
