/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Multimedia.Remoting
{
    /// <summary>
    /// Provides data for the <see cref="ScreenMirroring.StateChanged"/> event.
    /// </summary>
    public class ScreenMirroringStateChangedEventArgs : EventArgs
    {
        internal ScreenMirroringStateChangedEventArgs(ScreenMirroringState state)
        {
            State = state;
        }

        /// <summary>
        /// Gets the current state of screen mirroring.
        /// </summary>
        public ScreenMirroringState State { get; }
    }

    /// <summary>
    /// Provides data for the <see cref="ScreenMirroring.ErrorOccurred"/> event.
    /// </summary>
    public class ScreenMirroringErrorOccurredEventArgs : EventArgs
    {
        internal ScreenMirroringErrorOccurredEventArgs(ScreenMirroringError error)
        {
            Error = error;
        }

        /// <summary>
        /// Gets the error that occurred.
        /// </summary>
        public ScreenMirroringError Error { get; }
    }
}