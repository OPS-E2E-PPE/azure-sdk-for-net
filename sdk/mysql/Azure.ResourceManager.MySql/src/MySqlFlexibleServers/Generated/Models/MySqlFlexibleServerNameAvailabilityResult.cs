// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Represents a resource name availability. </summary>
    public partial class MySqlFlexibleServerNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerNameAvailabilityResult. </summary>
        internal MySqlFlexibleServerNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerNameAvailabilityResult. </summary>
        /// <param name="message"> Error Message. </param>
        /// <param name="isNameAvailable"> Indicates whether the resource name is available. </param>
        /// <param name="reason"> Reason for name being unavailable. </param>
        internal MySqlFlexibleServerNameAvailabilityResult(string message, bool? isNameAvailable, string reason)
        {
            Message = message;
            IsNameAvailable = isNameAvailable;
            Reason = reason;
        }

        /// <summary> Error Message. </summary>
        public string Message { get; }
        /// <summary> Indicates whether the resource name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> Reason for name being unavailable. </summary>
        public string Reason { get; }
    }
}
