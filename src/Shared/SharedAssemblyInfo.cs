﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion(Microsoft.CodeAnalysis.Sql.VersionConstants.AssemblyVersion)]
[assembly: AssemblyFileVersion(Microsoft.CodeAnalysis.Sql.VersionConstants.FileVersion)]

[assembly: AssemblyProduct("SqlSkim SQL Analyzer")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

[assembly: InternalsVisibleTo("SqlSkim")]
[assembly: InternalsVisibleTo("SqlSkim.Sdk.UnitTests")]
[assembly: InternalsVisibleTo("SqlSkim.Rules.UnitTests")]
[assembly: InternalsVisibleTo("SqlSkim.Driver.UnitTests")]