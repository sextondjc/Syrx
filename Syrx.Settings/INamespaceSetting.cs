﻿//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Collections.Generic;

namespace Syrx.Settings
{
    /// <summary>
    /// Provides the grouping of <see cref="ITypeSetting{TCommandSetting}"/> according 
    /// to namespaces allowing the configuration to be structured similarly to 
    /// the code.
    /// </summary>
    /// <typeparam name="TCommandSetting"></typeparam>
    public interface INamespaceSetting<TCommandSetting> where TCommandSetting : ICommandSetting
    {
        /// <summary>
        /// The fully qualified namespace.
        /// </summary>
        string Namespace { get; set; }

        /// <summary>
        /// The collection of types within this namespace to which this configuration applies. 
        /// </summary>
        IEnumerable<ITypeSetting<TCommandSetting>> Types { get; set; }
    }
}