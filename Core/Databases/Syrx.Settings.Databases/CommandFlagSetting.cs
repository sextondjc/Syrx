﻿//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;

namespace Syrx.Settings.Databases
{
    [Flags]
    public enum CommandFlagSetting
    {
        None = 0,
        Buffered = 1,
        Pipelined = 2,
        NoCache = 4
    }
}