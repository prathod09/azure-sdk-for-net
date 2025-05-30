// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute
{
    internal class OperationalizationClusterOperationSource : IOperationSource<OperationalizationClusterResource>
    {
        private readonly ArmClient _client;

        internal OperationalizationClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        OperationalizationClusterResource IOperationSource<OperationalizationClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<OperationalizationClusterData>(response.Content);
            return new OperationalizationClusterResource(_client, data);
        }

        async ValueTask<OperationalizationClusterResource> IOperationSource<OperationalizationClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<OperationalizationClusterData>(response.Content);
            return await Task.FromResult(new OperationalizationClusterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
