﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the Office Open XML file format version.
    /// </summary>
    [Flags]
    public enum FileFormatVersions
    {
        /// <summary>
        /// Represents an invalid value which will cause an exception.
        /// </summary>
        None = 0,

        /// <summary>
        /// Represents Microsoft Office 2007.
        /// </summary>
        Office2007 = 0x1,

        /// <summary>
        /// Represents Microsoft Office 2010.
        /// </summary>
        Office2010 = 0x2,

        /// <summary>
        /// Represents Microsoft Office 2013.
        /// </summary>
        Office2013 = 0x4
    }
}
