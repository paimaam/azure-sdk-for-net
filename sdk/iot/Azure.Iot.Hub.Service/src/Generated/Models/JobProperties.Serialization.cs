// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class JobProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (JobId != null)
            {
                writer.WritePropertyName("jobId");
                writer.WriteStringValue(JobId);
            }
            if (StartTimeUtc != null)
            {
                writer.WritePropertyName("startTimeUtc");
                writer.WriteStringValue(StartTimeUtc.Value, "O");
            }
            if (EndTimeUtc != null)
            {
                writer.WritePropertyName("endTimeUtc");
                writer.WriteStringValue(EndTimeUtc.Value, "O");
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Status != null)
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Progress != null)
            {
                writer.WritePropertyName("progress");
                writer.WriteNumberValue(Progress.Value);
            }
            if (InputBlobContainerUri != null)
            {
                writer.WritePropertyName("inputBlobContainerUri");
                writer.WriteStringValue(InputBlobContainerUri);
            }
            if (InputBlobName != null)
            {
                writer.WritePropertyName("inputBlobName");
                writer.WriteStringValue(InputBlobName);
            }
            if (OutputBlobContainerUri != null)
            {
                writer.WritePropertyName("outputBlobContainerUri");
                writer.WriteStringValue(OutputBlobContainerUri);
            }
            if (OutputBlobName != null)
            {
                writer.WritePropertyName("outputBlobName");
                writer.WriteStringValue(OutputBlobName);
            }
            if (ExcludeKeysInExport != null)
            {
                writer.WritePropertyName("excludeKeysInExport");
                writer.WriteBooleanValue(ExcludeKeysInExport.Value);
            }
            if (StorageAuthenticationType != null)
            {
                writer.WritePropertyName("storageAuthenticationType");
                writer.WriteStringValue(StorageAuthenticationType.Value.ToString());
            }
            if (FailureReason != null)
            {
                writer.WritePropertyName("failureReason");
                writer.WriteStringValue(FailureReason);
            }
            writer.WriteEndObject();
        }

        internal static JobProperties DeserializeJobProperties(JsonElement element)
        {
            string jobId = default;
            DateTimeOffset? startTimeUtc = default;
            DateTimeOffset? endTimeUtc = default;
            JobPropertiesType? type = default;
            JobPropertiesStatus? status = default;
            int? progress = default;
            string inputBlobContainerUri = default;
            string inputBlobName = default;
            string outputBlobContainerUri = default;
            string outputBlobName = default;
            bool? excludeKeysInExport = default;
            JobPropertiesStorageAuthenticationType? storageAuthenticationType = default;
            string failureReason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new JobPropertiesType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new JobPropertiesStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("progress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inputBlobContainerUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputBlobContainerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputBlobName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputBlobContainerUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputBlobContainerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputBlobName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludeKeysInExport"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeKeysInExport = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageAuthenticationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAuthenticationType = new JobPropertiesStorageAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failureReason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failureReason = property.Value.GetString();
                    continue;
                }
            }
            return new JobProperties(jobId, startTimeUtc, endTimeUtc, type, status, progress, inputBlobContainerUri, inputBlobName, outputBlobContainerUri, outputBlobName, excludeKeysInExport, storageAuthenticationType, failureReason);
        }
    }
}
