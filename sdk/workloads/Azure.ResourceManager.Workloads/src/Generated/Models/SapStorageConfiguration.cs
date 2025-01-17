// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the storage configuration. </summary>
    internal partial class SapStorageConfiguration
    {
        /// <summary> Initializes a new instance of SapStorageConfiguration. </summary>
        public SapStorageConfiguration()
        {
        }

        /// <summary> Initializes a new instance of SapStorageConfiguration. </summary>
        /// <param name="transportFileShareConfiguration">
        /// The properties of the transport directory attached to the VIS. The default for transportFileShareConfiguration is the createAndMount flow if storage configuration is missing.
        /// Please note <see cref="FileShareConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CreateAndMountFileShareConfiguration"/>, <see cref="MountFileShareConfiguration"/> and <see cref="SkipFileShareConfiguration"/>.
        /// </param>
        internal SapStorageConfiguration(FileShareConfiguration transportFileShareConfiguration)
        {
            TransportFileShareConfiguration = transportFileShareConfiguration;
        }

        /// <summary>
        /// The properties of the transport directory attached to the VIS. The default for transportFileShareConfiguration is the createAndMount flow if storage configuration is missing.
        /// Please note <see cref="FileShareConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CreateAndMountFileShareConfiguration"/>, <see cref="MountFileShareConfiguration"/> and <see cref="SkipFileShareConfiguration"/>.
        /// </summary>
        public FileShareConfiguration TransportFileShareConfiguration { get; set; }
    }
}
