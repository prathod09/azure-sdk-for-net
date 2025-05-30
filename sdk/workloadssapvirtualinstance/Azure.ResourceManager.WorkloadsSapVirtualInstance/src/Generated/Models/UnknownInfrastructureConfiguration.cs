// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> Unknown version of InfrastructureConfiguration. </summary>
    internal partial class UnknownInfrastructureConfiguration : InfrastructureConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownInfrastructureConfiguration"/>. </summary>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <param name="deploymentType"> The SAP deployment type. Eg: SingleServer/ThreeTier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownInfrastructureConfiguration(string appResourceGroup, SapDeploymentType deploymentType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(appResourceGroup, deploymentType, serializedAdditionalRawData)
        {
            DeploymentType = deploymentType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownInfrastructureConfiguration"/> for deserialization. </summary>
        internal UnknownInfrastructureConfiguration()
        {
        }
    }
}
