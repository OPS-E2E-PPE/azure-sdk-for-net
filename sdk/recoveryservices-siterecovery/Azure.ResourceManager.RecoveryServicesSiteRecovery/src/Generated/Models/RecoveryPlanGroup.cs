// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan group details. </summary>
    public partial class RecoveryPlanGroup
    {
        /// <summary> Initializes a new instance of RecoveryPlanGroup. </summary>
        /// <param name="groupType"> The group type. </param>
        public RecoveryPlanGroup(RecoveryPlanGroupType groupType)
        {
            GroupType = groupType;
            ReplicationProtectedItems = new ChangeTrackingList<RecoveryPlanProtectedItem>();
            StartGroupActions = new ChangeTrackingList<RecoveryPlanAction>();
            EndGroupActions = new ChangeTrackingList<RecoveryPlanAction>();
        }

        /// <summary> Initializes a new instance of RecoveryPlanGroup. </summary>
        /// <param name="groupType"> The group type. </param>
        /// <param name="replicationProtectedItems"> The list of protected items. </param>
        /// <param name="startGroupActions"> The start group actions. </param>
        /// <param name="endGroupActions"> The end group actions. </param>
        internal RecoveryPlanGroup(RecoveryPlanGroupType groupType, IList<RecoveryPlanProtectedItem> replicationProtectedItems, IList<RecoveryPlanAction> startGroupActions, IList<RecoveryPlanAction> endGroupActions)
        {
            GroupType = groupType;
            ReplicationProtectedItems = replicationProtectedItems;
            StartGroupActions = startGroupActions;
            EndGroupActions = endGroupActions;
        }

        /// <summary> The group type. </summary>
        public RecoveryPlanGroupType GroupType { get; set; }
        /// <summary> The list of protected items. </summary>
        public IList<RecoveryPlanProtectedItem> ReplicationProtectedItems { get; }
        /// <summary> The start group actions. </summary>
        public IList<RecoveryPlanAction> StartGroupActions { get; }
        /// <summary> The end group actions. </summary>
        public IList<RecoveryPlanAction> EndGroupActions { get; }
    }
}
