// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace System.ComponentModel
{
    /// <summary>
    /// A "component" is an object that can be placed in a container.
    ///
    /// In this context, "containment" refers to logical containment, not visual
    /// containment. Components and containers can be used in a variety of
    /// scenarios, including both visual and non-visual scenarios.
    ///
    /// To be a component, a class implements the IComponent interface, and provides
    /// a parameter-less constructor.
    ///
    /// A component interacts with its container primarily through a container-
    /// provided "site".
    /// Provides functionality required by all components.
    /// </summary>
    public interface IComponent : IDisposable
    {
        /// <summary>
        /// When implemented by a class, gets or sets the <see cref='System.ComponentModel.ISite'/>
        /// associated with the <see cref='System.ComponentModel.IComponent'/>.
        /// </summary>
        ISite? Site { get; set; }

        /// <summary>
        /// Adds an event handler to listen to the Disposed event on the component.
        /// </summary>
        event EventHandler? Disposed;
    }
}
