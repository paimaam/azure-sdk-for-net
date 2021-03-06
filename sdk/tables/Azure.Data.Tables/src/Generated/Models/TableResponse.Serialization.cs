// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    internal partial class TableResponse
    {
        internal static TableResponse DeserializeTableResponse(JsonElement element)
        {
            string odataMetadata = default;
            string tableName = default;
            string odataType = default;
            string odataId = default;
            string odataEditLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataMetadata = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TableName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.editLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataEditLink = property.Value.GetString();
                    continue;
                }
            }
            return new TableResponse(tableName, odataType, odataId, odataEditLink, odataMetadata);
        }
    }
}
