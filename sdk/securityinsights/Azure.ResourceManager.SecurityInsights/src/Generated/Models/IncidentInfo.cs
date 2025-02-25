// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes related incident information for the bookmark. </summary>
    public partial class IncidentInfo
    {
        /// <summary> Initializes a new instance of IncidentInfo. </summary>
        public IncidentInfo()
        {
        }

        /// <summary> Initializes a new instance of IncidentInfo. </summary>
        /// <param name="incidentId"> Incident Id. </param>
        /// <param name="severity"> The severity of the incident. </param>
        /// <param name="title"> The title of the incident. </param>
        /// <param name="relationName"> Relation Name. </param>
        internal IncidentInfo(string incidentId, IncidentSeverity? severity, string title, string relationName)
        {
            IncidentId = incidentId;
            Severity = severity;
            Title = title;
            RelationName = relationName;
        }

        /// <summary> Incident Id. </summary>
        public string IncidentId { get; set; }
        /// <summary> The severity of the incident. </summary>
        public IncidentSeverity? Severity { get; set; }
        /// <summary> The title of the incident. </summary>
        public string Title { get; set; }
        /// <summary> Relation Name. </summary>
        public string RelationName { get; set; }
    }
}
