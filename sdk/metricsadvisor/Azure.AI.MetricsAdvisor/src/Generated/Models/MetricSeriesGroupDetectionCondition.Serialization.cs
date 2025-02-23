// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricSeriesGroupDetectionCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("group"u8);
            writer.WriteObjectValue(SeriesGroupKey);
            if (Optional.IsDefined(ConditionOperator))
            {
                writer.WritePropertyName("conditionOperator"u8);
                writer.WriteStringValue(ConditionOperator.Value.ToString());
            }
            if (Optional.IsDefined(SmartDetectionCondition))
            {
                writer.WritePropertyName("smartDetectionCondition"u8);
                writer.WriteObjectValue(SmartDetectionCondition);
            }
            if (Optional.IsDefined(HardThresholdCondition))
            {
                writer.WritePropertyName("hardThresholdCondition"u8);
                writer.WriteObjectValue(HardThresholdCondition);
            }
            if (Optional.IsDefined(ChangeThresholdCondition))
            {
                writer.WritePropertyName("changeThresholdCondition"u8);
                writer.WriteObjectValue(ChangeThresholdCondition);
            }
            writer.WriteEndObject();
        }

        internal static MetricSeriesGroupDetectionCondition DeserializeMetricSeriesGroupDetectionCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DimensionKey group = default;
            Optional<DetectionConditionOperator> conditionOperator = default;
            Optional<SmartDetectionCondition> smartDetectionCondition = default;
            Optional<HardThresholdCondition> hardThresholdCondition = default;
            Optional<ChangeThresholdCondition> changeThresholdCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("group"u8))
                {
                    group = DimensionKey.DeserializeDimensionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("conditionOperator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionOperator = new DetectionConditionOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("smartDetectionCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartDetectionCondition = Models.SmartDetectionCondition.DeserializeSmartDetectionCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("hardThresholdCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardThresholdCondition = Models.HardThresholdCondition.DeserializeHardThresholdCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("changeThresholdCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeThresholdCondition = Models.ChangeThresholdCondition.DeserializeChangeThresholdCondition(property.Value);
                    continue;
                }
            }
            return new MetricSeriesGroupDetectionCondition(Optional.ToNullable(conditionOperator), smartDetectionCondition.Value, hardThresholdCondition.Value, changeThresholdCondition.Value, group);
        }
    }
}
