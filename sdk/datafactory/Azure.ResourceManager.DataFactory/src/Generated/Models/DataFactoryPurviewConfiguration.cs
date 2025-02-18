// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Purview configuration. </summary>
    internal partial class DataFactoryPurviewConfiguration
    {
        /// <summary> Initializes a new instance of DataFactoryPurviewConfiguration. </summary>
        public DataFactoryPurviewConfiguration()
        {
        }

        /// <summary> Initializes a new instance of DataFactoryPurviewConfiguration. </summary>
        /// <param name="purviewResourceId"> Purview resource id. </param>
        internal DataFactoryPurviewConfiguration(ResourceIdentifier purviewResourceId)
        {
            PurviewResourceId = purviewResourceId;
        }

        /// <summary> Purview resource id. </summary>
        public ResourceIdentifier PurviewResourceId { get; set; }
    }
}
