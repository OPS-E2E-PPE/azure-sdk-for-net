// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update certificate operation. </summary>
    public partial class CertificatePatch
    {
        /// <summary> Initializes a new instance of CertificatePatch. </summary>
        public CertificatePatch()
        {
        }

        /// <summary> Gets or sets the name of the certificate. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the description of the certificate. </summary>
        public string Description { get; set; }
    }
}
