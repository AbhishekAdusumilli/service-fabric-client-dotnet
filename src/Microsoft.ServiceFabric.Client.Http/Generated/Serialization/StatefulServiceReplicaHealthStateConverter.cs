// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Client.Http.Serialization
{
    using System;
    using System.Collections.Generic;
    using Microsoft.ServiceFabric.Common;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converter for <see cref="StatefulServiceReplicaHealthState" />.
    /// </summary>
    internal class StatefulServiceReplicaHealthStateConverter
    {
        /// <summary>
        /// Deserializes the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <returns>The object Value.</returns>
        internal static StatefulServiceReplicaHealthState Deserialize(JsonReader reader)
        {
            return reader.Deserialize(GetFromJsonProperties);
        }

        /// <summary>
        /// Gets the object from Json properties.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from, reader must be placed at first property.</param>
        /// <returns>The object Value.</returns>
        internal static StatefulServiceReplicaHealthState GetFromJsonProperties(JsonReader reader)
        {
            var aggregatedHealthState = default(HealthState?);
            var partitionId = default(PartitionId);
            var replicaId = default(ReplicaId);

            do
            {
                var propName = reader.ReadPropertyName();
                if (string.Compare("AggregatedHealthState", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    aggregatedHealthState = HealthStateConverter.Deserialize(reader);
                }
                else if (string.Compare("PartitionId", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    partitionId = PartitionIdConverter.Deserialize(reader);
                }
                else if (string.Compare("ReplicaId", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    replicaId = ReplicaIdConverter.Deserialize(reader);
                }
                else
                {
                    reader.SkipPropertyValue();
                }
            }
            while (reader.TokenType != JsonToken.EndObject);

            return new StatefulServiceReplicaHealthState(
                aggregatedHealthState: aggregatedHealthState,
                partitionId: partitionId,
                replicaId: replicaId);
        }

        /// <summary>
        /// Serializes the object to JSON.
        /// </summary>
        /// <param name="writer">The <see cref="T: Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="obj">The object to serialize to JSON.</param>
        internal static void Serialize(JsonWriter writer, StatefulServiceReplicaHealthState obj)
        {
            // Required properties are always serialized, optional properties are serialized when not null.
            writer.WriteStartObject();
            writer.WriteProperty(obj.ServiceKind, "ServiceKind", ServiceKindConverter.Serialize);
            writer.WriteProperty(obj.AggregatedHealthState, "AggregatedHealthState", HealthStateConverter.Serialize);
            if (obj.PartitionId != null)
            {
                writer.WriteProperty(obj.PartitionId, "PartitionId", PartitionIdConverter.Serialize);
            }

            if (obj.ReplicaId != null)
            {
                writer.WriteProperty(obj.ReplicaId, "ReplicaId", ReplicaIdConverter.Serialize);
            }

            writer.WriteEndObject();
        }
    }
}
