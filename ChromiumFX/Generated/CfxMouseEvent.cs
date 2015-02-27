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

namespace Chromium {
    /// <summary>
    /// Structure representing mouse event information.
    /// </summary>
    public sealed class CfxMouseEvent : CfxStructure {

        public CfxMouseEvent() : base(CfxApi.cfx_mouse_event_ctor, CfxApi.cfx_mouse_event_dtor) {}

        /// <summary>
        /// X coordinate relative to the left side of the view.
        /// </summary>
        public int X {
            get {
                int value;
                CfxApi.cfx_mouse_event_get_x(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_mouse_event_set_x(nativePtrUnchecked, value);
            }
        }

        /// <summary>
        /// Y coordinate relative to the top side of the view.
        /// </summary>
        public int Y {
            get {
                int value;
                CfxApi.cfx_mouse_event_get_y(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_mouse_event_set_y(nativePtrUnchecked, value);
            }
        }

        /// <summary>
        /// Bit flags describing any pressed modifier keys. See
        /// cef_event_flags_t for values.
        /// </summary>
        public uint Modifiers {
            get {
                uint value;
                CfxApi.cfx_mouse_event_get_modifiers(nativePtrUnchecked, out value);
                return value;
            }
            set {
                CfxApi.cfx_mouse_event_set_modifiers(nativePtrUnchecked, value);
            }
        }

    }
}
