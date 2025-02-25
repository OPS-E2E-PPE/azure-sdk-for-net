// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Linux specific update configuration. </summary>
    public partial class LinuxProperties
    {
        /// <summary> Initializes a new instance of LinuxProperties. </summary>
        public LinuxProperties()
        {
            ExcludedPackageNameMasks = new ChangeTrackingList<string>();
            IncludedPackageNameMasks = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of LinuxProperties. </summary>
        /// <param name="includedPackageClassifications"> Update classifications included in the software update configuration. </param>
        /// <param name="excludedPackageNameMasks"> packages excluded from the software update configuration. </param>
        /// <param name="includedPackageNameMasks"> packages included from the software update configuration. </param>
        /// <param name="rebootSetting"> Reboot setting for the software update configuration. </param>
        internal LinuxProperties(LinuxUpdateClass? includedPackageClassifications, IList<string> excludedPackageNameMasks, IList<string> includedPackageNameMasks, string rebootSetting)
        {
            IncludedPackageClassifications = includedPackageClassifications;
            ExcludedPackageNameMasks = excludedPackageNameMasks;
            IncludedPackageNameMasks = includedPackageNameMasks;
            RebootSetting = rebootSetting;
        }

        /// <summary> Update classifications included in the software update configuration. </summary>
        public LinuxUpdateClass? IncludedPackageClassifications { get; set; }
        /// <summary> packages excluded from the software update configuration. </summary>
        public IList<string> ExcludedPackageNameMasks { get; }
        /// <summary> packages included from the software update configuration. </summary>
        public IList<string> IncludedPackageNameMasks { get; }
        /// <summary> Reboot setting for the software update configuration. </summary>
        public string RebootSetting { get; set; }
    }
}
