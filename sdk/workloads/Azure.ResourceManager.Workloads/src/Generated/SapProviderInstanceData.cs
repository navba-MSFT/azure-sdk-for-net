// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing the SapProviderInstance data model.
    /// A provider instance associated with SAP monitor.
    /// </summary>
    public partial class SapProviderInstanceData : ResourceData
    {
        /// <summary> Initializes a new instance of SapProviderInstanceData. </summary>
        public SapProviderInstanceData()
        {
        }

        /// <summary> Initializes a new instance of SapProviderInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> [currently not in use] Managed service identity(user assigned identities). </param>
        /// <param name="provisioningState"> State of provisioning of the provider instance. </param>
        /// <param name="errors"> Defines the provider instance errors. </param>
        /// <param name="providerSettings">
        /// Defines the provider specific properties.
        /// Please note <see cref="ProviderSpecificProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DB2ProviderInstanceProperties"/>, <see cref="MsSqlServerProviderInstanceProperties"/>, <see cref="PrometheusHAClusterProviderInstanceProperties"/>, <see cref="PrometheusOSProviderInstanceProperties"/>, <see cref="HanaDBProviderInstanceProperties"/> and <see cref="SapNetWeaverProviderInstanceProperties"/>.
        /// </param>
        internal SapProviderInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, UserAssignedServiceIdentity identity, WorkloadMonitorProvisioningState? provisioningState, ResponseError errors, ProviderSpecificProperties providerSettings) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            Errors = errors;
            ProviderSettings = providerSettings;
        }

        /// <summary> [currently not in use] Managed service identity(user assigned identities). </summary>
        public UserAssignedServiceIdentity Identity { get; set; }
        /// <summary> State of provisioning of the provider instance. </summary>
        public WorkloadMonitorProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the provider instance errors. </summary>
        public ResponseError Errors { get; }
        /// <summary>
        /// Defines the provider specific properties.
        /// Please note <see cref="ProviderSpecificProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DB2ProviderInstanceProperties"/>, <see cref="MsSqlServerProviderInstanceProperties"/>, <see cref="PrometheusHAClusterProviderInstanceProperties"/>, <see cref="PrometheusOSProviderInstanceProperties"/>, <see cref="HanaDBProviderInstanceProperties"/> and <see cref="SapNetWeaverProviderInstanceProperties"/>.
        /// </summary>
        public ProviderSpecificProperties ProviderSettings { get; set; }
    }
}
