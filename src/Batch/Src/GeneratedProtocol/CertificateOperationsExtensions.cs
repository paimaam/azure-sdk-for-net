// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for CertificateOperations.
    /// </summary>
    public static partial class CertificateOperationsExtensions
    {
            /// <summary>
            /// Adds a certificate to the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificate'>
            /// Specifies the certificate to be added.
            /// </param>
            /// <param name='certificateAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CertificateAddHeaders Add(this ICertificateOperations operations, CertificateAddParameter certificate, CertificateAddOptions certificateAddOptions = default(CertificateAddOptions))
            {
                return Task.Factory.StartNew(s => ((ICertificateOperations)s).AddAsync(certificate, certificateAddOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a certificate to the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificate'>
            /// Specifies the certificate to be added.
            /// </param>
            /// <param name='certificateAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateAddHeaders> AddAsync(this ICertificateOperations operations, CertificateAddParameter certificate, CertificateAddOptions certificateAddOptions = default(CertificateAddOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(certificate, certificateAddOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the certificates that have been added to the specified
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateListOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<Certificate> List(this ICertificateOperations operations, CertificateListOptions certificateListOptions = default(CertificateListOptions))
            {
                return Task.Factory.StartNew(s => ((ICertificateOperations)s).ListAsync(certificateListOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the certificates that have been added to the specified
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateListOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Certificate>> ListAsync(this ICertificateOperations operations, CertificateListOptions certificateListOptions = default(CertificateListOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(certificateListOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a failed deletion of a certificate from the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='thumbprintAlgorithm'>
            /// The algorithm used to derive the thumbprint parameter. This must be sha1.
            /// </param>
            /// <param name='thumbprint'>
            /// The thumbprint of the certificate being deleted.
            /// </param>
            /// <param name='certificateCancelDeletionOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CertificateCancelDeletionHeaders CancelDeletion(this ICertificateOperations operations, string thumbprintAlgorithm, string thumbprint, CertificateCancelDeletionOptions certificateCancelDeletionOptions = default(CertificateCancelDeletionOptions))
            {
                return Task.Factory.StartNew(s => ((ICertificateOperations)s).CancelDeletionAsync(thumbprintAlgorithm, thumbprint, certificateCancelDeletionOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a failed deletion of a certificate from the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='thumbprintAlgorithm'>
            /// The algorithm used to derive the thumbprint parameter. This must be sha1.
            /// </param>
            /// <param name='thumbprint'>
            /// The thumbprint of the certificate being deleted.
            /// </param>
            /// <param name='certificateCancelDeletionOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateCancelDeletionHeaders> CancelDeletionAsync(this ICertificateOperations operations, string thumbprintAlgorithm, string thumbprint, CertificateCancelDeletionOptions certificateCancelDeletionOptions = default(CertificateCancelDeletionOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelDeletionWithHttpMessagesAsync(thumbprintAlgorithm, thumbprint, certificateCancelDeletionOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Deletes a certificate from the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='thumbprintAlgorithm'>
            /// The algorithm used to derive the thumbprint parameter. This must be sha1.
            /// </param>
            /// <param name='thumbprint'>
            /// The thumbprint of the certificate to be deleted.
            /// </param>
            /// <param name='certificateDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CertificateDeleteHeaders Delete(this ICertificateOperations operations, string thumbprintAlgorithm, string thumbprint, CertificateDeleteOptions certificateDeleteOptions = default(CertificateDeleteOptions))
            {
                return Task.Factory.StartNew(s => ((ICertificateOperations)s).DeleteAsync(thumbprintAlgorithm, thumbprint, certificateDeleteOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a certificate from the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='thumbprintAlgorithm'>
            /// The algorithm used to derive the thumbprint parameter. This must be sha1.
            /// </param>
            /// <param name='thumbprint'>
            /// The thumbprint of the certificate to be deleted.
            /// </param>
            /// <param name='certificateDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateDeleteHeaders> DeleteAsync(this ICertificateOperations operations, string thumbprintAlgorithm, string thumbprint, CertificateDeleteOptions certificateDeleteOptions = default(CertificateDeleteOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(thumbprintAlgorithm, thumbprint, certificateDeleteOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the specified certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='thumbprintAlgorithm'>
            /// The algorithm used to derive the thumbprint parameter. This must be sha1.
            /// </param>
            /// <param name='thumbprint'>
            /// The thumbprint of the certificate to get.
            /// </param>
            /// <param name='certificateGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Certificate Get(this ICertificateOperations operations, string thumbprintAlgorithm, string thumbprint, CertificateGetOptions certificateGetOptions = default(CertificateGetOptions))
            {
                return Task.Factory.StartNew(s => ((ICertificateOperations)s).GetAsync(thumbprintAlgorithm, thumbprint, certificateGetOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='thumbprintAlgorithm'>
            /// The algorithm used to derive the thumbprint parameter. This must be sha1.
            /// </param>
            /// <param name='thumbprint'>
            /// The thumbprint of the certificate to get.
            /// </param>
            /// <param name='certificateGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Certificate> GetAsync(this ICertificateOperations operations, string thumbprintAlgorithm, string thumbprint, CertificateGetOptions certificateGetOptions = default(CertificateGetOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(thumbprintAlgorithm, thumbprint, certificateGetOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the certificates that have been added to the specified
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='certificateListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<Certificate> ListNext(this ICertificateOperations operations, string nextPageLink, CertificateListNextOptions certificateListNextOptions = default(CertificateListNextOptions))
            {
                return Task.Factory.StartNew(s => ((ICertificateOperations)s).ListNextAsync(nextPageLink, certificateListNextOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the certificates that have been added to the specified
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='certificateListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Certificate>> ListNextAsync(this ICertificateOperations operations, string nextPageLink, CertificateListNextOptions certificateListNextOptions = default(CertificateListNextOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, certificateListNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
