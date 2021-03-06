// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The Device. </summary>
    public partial class DeviceIdentity
    {
        /// <summary> Initializes a new instance of DeviceIdentity. </summary>
        public DeviceIdentity()
        {
        }

        /// <summary> Initializes a new instance of DeviceIdentity. </summary>
        /// <param name="deviceId"> . </param>
        /// <param name="generationId"> . </param>
        /// <param name="etag"> . </param>
        /// <param name="connectionState"> . </param>
        /// <param name="status"> . </param>
        /// <param name="statusReason"> . </param>
        /// <param name="connectionStateUpdatedTime"> . </param>
        /// <param name="statusUpdatedTime"> . </param>
        /// <param name="lastActivityTime"> . </param>
        /// <param name="cloudToDeviceMessageCount"> . </param>
        /// <param name="authentication"> . </param>
        /// <param name="capabilities"> Status of Capabilities enabled on the device. </param>
        /// <param name="deviceScope"> . </param>
        /// <param name="parentScopes"> . </param>
        internal DeviceIdentity(string deviceId, string generationId, string etag, DeviceConnectionState? connectionState, DeviceStatus? status, string statusReason, DateTimeOffset? connectionStateUpdatedTime, DateTimeOffset? statusUpdatedTime, DateTimeOffset? lastActivityTime, int? cloudToDeviceMessageCount, AuthenticationMechanism authentication, DeviceCapabilities capabilities, string deviceScope, IList<string> parentScopes)
        {
            DeviceId = deviceId;
            GenerationId = generationId;
            Etag = etag;
            ConnectionState = connectionState;
            Status = status;
            StatusReason = statusReason;
            ConnectionStateUpdatedTime = connectionStateUpdatedTime;
            StatusUpdatedTime = statusUpdatedTime;
            LastActivityTime = lastActivityTime;
            CloudToDeviceMessageCount = cloudToDeviceMessageCount;
            Authentication = authentication;
            Capabilities = capabilities;
            DeviceScope = deviceScope;
            ParentScopes = parentScopes;
        }

        public string DeviceId { get; set; }
        public string GenerationId { get; set; }
        public string Etag { get; set; }
        public DeviceConnectionState? ConnectionState { get; set; }
        public DeviceStatus? Status { get; set; }
        public string StatusReason { get; set; }
        public DateTimeOffset? ConnectionStateUpdatedTime { get; set; }
        public DateTimeOffset? StatusUpdatedTime { get; set; }
        public DateTimeOffset? LastActivityTime { get; set; }
        public int? CloudToDeviceMessageCount { get; set; }
        public AuthenticationMechanism Authentication { get; set; }
        /// <summary> Status of Capabilities enabled on the device. </summary>
        public DeviceCapabilities Capabilities { get; set; }
        public string DeviceScope { get; set; }
        public IList<string> ParentScopes { get; set; }
    }
}
