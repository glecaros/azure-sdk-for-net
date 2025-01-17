// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactoryTrigger data model.
    /// Trigger resource type.
    /// </summary>
    public partial class DataFactoryTriggerData : ResourceData
    {
        /// <summary> Initializes a new instance of DataFactoryTriggerData. </summary>
        /// <param name="properties">
        /// Properties of the trigger.
        /// Please note <see cref="DataFactoryTriggerDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryBlobEventsTrigger"/>, <see cref="DataFactoryBlobTrigger"/>, <see cref="ChainingTrigger"/>, <see cref="CustomEventsTrigger"/>, <see cref="MultiplePipelineTrigger"/>, <see cref="RerunTumblingWindowTrigger"/>, <see cref="ScheduleTrigger"/> and <see cref="TumblingWindowTrigger"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryTriggerData(DataFactoryTriggerDefinition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DataFactoryTriggerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of the trigger.
        /// Please note <see cref="DataFactoryTriggerDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryBlobEventsTrigger"/>, <see cref="DataFactoryBlobTrigger"/>, <see cref="ChainingTrigger"/>, <see cref="CustomEventsTrigger"/>, <see cref="MultiplePipelineTrigger"/>, <see cref="RerunTumblingWindowTrigger"/>, <see cref="ScheduleTrigger"/> and <see cref="TumblingWindowTrigger"/>.
        /// </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        internal DataFactoryTriggerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataFactoryTriggerDefinition properties, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary>
        /// Properties of the trigger.
        /// Please note <see cref="DataFactoryTriggerDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryBlobEventsTrigger"/>, <see cref="DataFactoryBlobTrigger"/>, <see cref="ChainingTrigger"/>, <see cref="CustomEventsTrigger"/>, <see cref="MultiplePipelineTrigger"/>, <see cref="RerunTumblingWindowTrigger"/>, <see cref="ScheduleTrigger"/> and <see cref="TumblingWindowTrigger"/>.
        /// </summary>
        public DataFactoryTriggerDefinition Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
