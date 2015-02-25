// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {
    /// <summary>
    /// Structure used to represent a DOM node. The functions of this structure
    /// should only be called on the render process main thread.
    /// </summary>
    public class CfrDomNode : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrDomNode Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrDomNode)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrDomNode(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }



        private CfrDomNode(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}

        /// <summary>
        /// Returns the type for this node.
        /// </summary>
        public CfxDomNodeType Type {
            get {
                var call = new CfxDomNodeGetTypeRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return (CfxDomNodeType)call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this is a text node.
        /// </summary>
        public bool IsText {
            get {
                var call = new CfxDomNodeIsTextRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this is an element node.
        /// </summary>
        public bool IsElement {
            get {
                var call = new CfxDomNodeIsElementRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this is an editable node.
        /// </summary>
        public bool IsEditable {
            get {
                var call = new CfxDomNodeIsEditableRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this is a form control element node.
        /// </summary>
        public bool IsFormControlElement {
            get {
                var call = new CfxDomNodeIsFormControlElementRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the type of this form control element node.
        /// </summary>
        public String FormControlElementType {
            get {
                var call = new CfxDomNodeGetFormControlElementTypeRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the name of this node.
        /// </summary>
        public String Name {
            get {
                var call = new CfxDomNodeGetNameRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the value of this node.
        /// </summary>
        public String Value {
            get {
                var call = new CfxDomNodeGetValueRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the contents of this node as markup.
        /// </summary>
        public String AsMarkup {
            get {
                var call = new CfxDomNodeGetAsMarkupRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the document associated with this node.
        /// </summary>
        public CfrDomDocument Document {
            get {
                var call = new CfxDomNodeGetDocumentRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrDomDocument.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the parent node.
        /// </summary>
        public CfrDomNode Parent {
            get {
                var call = new CfxDomNodeGetParentRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrDomNode.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the previous sibling node.
        /// </summary>
        public CfrDomNode PreviousSibling {
            get {
                var call = new CfxDomNodeGetPreviousSiblingRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrDomNode.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the next sibling node.
        /// </summary>
        public CfrDomNode NextSibling {
            get {
                var call = new CfxDomNodeGetNextSiblingRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrDomNode.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns true (1) if this node has child nodes.
        /// </summary>
        public bool HasChildren {
            get {
                var call = new CfxDomNodeHasChildrenRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Return the first child node.
        /// </summary>
        public CfrDomNode FirstChild {
            get {
                var call = new CfxDomNodeGetFirstChildRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrDomNode.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// Returns the last child node.
        /// </summary>
        public CfrDomNode LastChild {
            get {
                var call = new CfxDomNodeGetLastChildRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return CfrDomNode.Wrap(call.__retval, remoteRuntime);
            }
        }

        /// <summary>
        /// The following functions are valid only for element nodes.
        /// Returns the tag name of this element.
        /// </summary>
        public String ElementTagName {
            get {
                var call = new CfxDomNodeGetElementTagNameRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this element has attributes.
        /// </summary>
        public bool HasElementAttributes {
            get {
                var call = new CfxDomNodeHasElementAttributesRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the inner text of the element.
        /// </summary>
        public String ElementInnerText {
            get {
                var call = new CfxDomNodeGetElementInnerTextRenderProcessCall();
                call.self = CfrObject.Unwrap(this);
                call.Execute(remoteRuntime.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        public bool IsSame(CfrDomNode that) {
            var call = new CfxDomNodeIsSameRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.that = CfrObject.Unwrap(that);
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Set the value of this node. Returns true (1) on success.
        /// </summary>
        public bool SetValue(string value) {
            var call = new CfxDomNodeSetValueRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if this element has an attribute named |attrName|.
        /// </summary>
        public bool HasElementAttribute(string attrName) {
            var call = new CfxDomNodeHasElementAttributeRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.attrName = attrName;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the element attribute named |attrName|.
        /// </summary>
        public String GetElementAttribute(string attrName) {
            var call = new CfxDomNodeGetElementAttributeRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.attrName = attrName;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns a map of all element attributes.
        /// </summary>
        public void GetElementAttributes(System.Collections.Generic.List<string[]> attrMap) {
            var call = new CfxDomNodeGetElementAttributesRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.attrMap = attrMap;
            call.Execute(remoteRuntime.connection);
        }

        /// <summary>
        /// Set the value for the element attribute named |attrName|. Returns true (1)
        /// on success.
        /// </summary>
        public bool SetElementAttribute(string attrName, string value) {
            var call = new CfxDomNodeSetElementAttributeRenderProcessCall();
            call.self = CfrObject.Unwrap(this);
            call.attrName = attrName;
            call.value = value;
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }
}
