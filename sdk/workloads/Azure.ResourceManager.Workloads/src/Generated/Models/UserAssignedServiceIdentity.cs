// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> A pre-created user assigned identity with appropriate roles assigned. To learn more on identity and roles required, visit the ACSS how-to-guide. </summary>
    public partial class UserAssignedServiceIdentity
    {
        /// <summary> Initializes a new instance of UserAssignedServiceIdentity. </summary>
        /// <param name="managedServiceIdentityType"> Type of manage identity. </param>
        public UserAssignedServiceIdentity(ManagedServiceIdentityType managedServiceIdentityType)
        {
            ManagedServiceIdentityType = managedServiceIdentityType;
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of UserAssignedServiceIdentity. </summary>
        /// <param name="managedServiceIdentityType"> Type of manage identity. </param>
        /// <param name="userAssignedIdentities"> User assigned identities dictionary. </param>
        internal UserAssignedServiceIdentity(ManagedServiceIdentityType managedServiceIdentityType, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            ManagedServiceIdentityType = managedServiceIdentityType;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> Type of manage identity. </summary>
        public ManagedServiceIdentityType ManagedServiceIdentityType { get; set; }
        /// <summary> User assigned identities dictionary. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
