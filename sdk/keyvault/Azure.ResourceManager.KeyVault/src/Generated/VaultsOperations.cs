// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> The Vaults service client. </summary>
    public partial class VaultsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VaultsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of VaultsOperations for mocking. </summary>
        protected VaultsOperations()
        {
        }
        /// <summary> Initializes a new instance of VaultsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal VaultsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-09-01")
        {
            RestClient = new VaultsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to patch the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Vault>> UpdateAsync(string resourceGroupName, string vaultName, VaultPatchParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, vaultName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to patch the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Vault> Update(string resourceGroupName, string vaultName, VaultPatchParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, vaultName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, vaultName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Vault>> GetAsync(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Vault> Get(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, vaultName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update access policies in a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="operationKind"> Name of the operation. </param>
        /// <param name="parameters"> Access policy to merge into the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VaultAccessPolicyParameters>> UpdateAccessPolicyAsync(string resourceGroupName, string vaultName, AccessPolicyUpdateKind operationKind, VaultAccessPolicyParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.UpdateAccessPolicy");
            scope.Start();
            try
            {
                return await RestClient.UpdateAccessPolicyAsync(resourceGroupName, vaultName, operationKind, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update access policies in a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="operationKind"> Name of the operation. </param>
        /// <param name="parameters"> Access policy to merge into the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VaultAccessPolicyParameters> UpdateAccessPolicy(string resourceGroupName, string vaultName, AccessPolicyUpdateKind operationKind, VaultAccessPolicyParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.UpdateAccessPolicy");
            scope.Start();
            try
            {
                return RestClient.UpdateAccessPolicy(resourceGroupName, vaultName, operationKind, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedVault>> GetDeletedAsync(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.GetDeleted");
            scope.Start();
            try
            {
                return await RestClient.GetDeletedAsync(vaultName, location, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedVault> GetDeleted(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.GetDeleted");
            scope.Start();
            try
            {
                return RestClient.GetDeleted(vaultName, location, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityAsync(VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.CheckNameAvailability");
            scope.Start();
            try
            {
                return await RestClient.CheckNameAvailabilityAsync(vaultName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailability(VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.CheckNameAvailability");
            scope.Start();
            try
            {
                return RestClient.CheckNameAvailability(vaultName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription and within the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Vault> ListByResourceGroupAsync(string resourceGroupName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<Vault>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Vault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription and within the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Vault> ListByResourceGroup(string resourceGroupName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<Vault> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Vault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Vault> ListBySubscriptionAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Vault>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Vault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Vault> ListBySubscription(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Vault> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Vault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscriptionNextPage(nextLink, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about the deleted vaults in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeletedVault> ListDeletedAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedVault>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListDeleted");
                scope.Start();
                try
                {
                    var response = await RestClient.ListDeletedAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedVault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListDeleted");
                scope.Start();
                try
                {
                    var response = await RestClient.ListDeletedNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about the deleted vaults in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeletedVault> ListDeleted(CancellationToken cancellationToken = default)
        {
            Page<DeletedVault> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListDeleted");
                scope.Start();
                try
                {
                    var response = RestClient.ListDeleted(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedVault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.ListDeleted");
                scope.Start();
                try
                {
                    var response = RestClient.ListDeletedNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Resource> ListAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Resource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Resource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Resource> List(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Resource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Resource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VaultsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, vaultName, parameters, cancellationToken).ConfigureAwait(false);
                return new VaultsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vaultName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VaultsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, vaultName, parameters, cancellationToken);
                return new VaultsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vaultName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the soft-deleted vault. </param>
        /// <param name="location"> The location of the soft-deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<VaultsPurgeDeletedOperation> StartPurgeDeletedAsync(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.StartPurgeDeleted");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PurgeDeletedAsync(vaultName, location, cancellationToken).ConfigureAwait(false);
                return new VaultsPurgeDeletedOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurgeDeletedRequest(vaultName, location).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the soft-deleted vault. </param>
        /// <param name="location"> The location of the soft-deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VaultsPurgeDeletedOperation StartPurgeDeleted(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultsOperations.StartPurgeDeleted");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PurgeDeleted(vaultName, location, cancellationToken);
                return new VaultsPurgeDeletedOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurgeDeletedRequest(vaultName, location).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
