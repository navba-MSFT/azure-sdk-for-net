// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class VwanConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkVirtualApplianceId))
            {
                writer.WritePropertyName("networkVirtualApplianceId"u8);
                writer.WriteStringValue(NetworkVirtualApplianceId);
            }
            writer.WritePropertyName("vHub"u8);
            writer.WriteObjectValue(VHub);
            if (Optional.IsDefined(TrustSubnet))
            {
                writer.WritePropertyName("trustSubnet"u8);
                writer.WriteObjectValue(TrustSubnet);
            }
            if (Optional.IsDefined(UnTrustSubnet))
            {
                writer.WritePropertyName("unTrustSubnet"u8);
                writer.WriteObjectValue(UnTrustSubnet);
            }
            if (Optional.IsDefined(IPOfTrustSubnetForUdr))
            {
                writer.WritePropertyName("ipOfTrustSubnetForUdr"u8);
                writer.WriteObjectValue(IPOfTrustSubnetForUdr);
            }
            writer.WriteEndObject();
        }

        internal static VwanConfiguration DeserializeVwanConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> networkVirtualApplianceId = default;
            IPAddressSpace vHub = default;
            Optional<IPAddressSpace> trustSubnet = default;
            Optional<IPAddressSpace> unTrustSubnet = default;
            Optional<IPAddress> ipOfTrustSubnetForUdr = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkVirtualApplianceId"u8))
                {
                    networkVirtualApplianceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vHub"u8))
                {
                    vHub = IPAddressSpace.DeserializeIPAddressSpace(property.Value);
                    continue;
                }
                if (property.NameEquals("trustSubnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trustSubnet = IPAddressSpace.DeserializeIPAddressSpace(property.Value);
                    continue;
                }
                if (property.NameEquals("unTrustSubnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unTrustSubnet = IPAddressSpace.DeserializeIPAddressSpace(property.Value);
                    continue;
                }
                if (property.NameEquals("ipOfTrustSubnetForUdr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipOfTrustSubnetForUdr = IPAddress.DeserializeIPAddress(property.Value);
                    continue;
                }
            }
            return new VwanConfiguration(networkVirtualApplianceId.Value, vHub, trustSubnet.Value, unTrustSubnet.Value, ipOfTrustSubnetForUdr.Value);
        }
    }
}
