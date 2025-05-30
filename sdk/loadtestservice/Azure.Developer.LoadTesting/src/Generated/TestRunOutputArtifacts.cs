// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting
{
    /// <summary> The output artifacts for the test run. </summary>
    public partial class TestRunOutputArtifacts
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TestRunOutputArtifacts"/>. </summary>
        internal TestRunOutputArtifacts()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TestRunOutputArtifacts"/>. </summary>
        /// <param name="resultFileInfo"> The test run results file. </param>
        /// <param name="logsFileInfo"> The test run report with metrics. </param>
        /// <param name="artifactsContainerInfo"> The container for test run artifacts. </param>
        /// <param name="reportFileInfo"> The report file for the test run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TestRunOutputArtifacts(TestRunFileInfo resultFileInfo, TestRunFileInfo logsFileInfo, ArtifactsContainerInfo artifactsContainerInfo, TestRunFileInfo reportFileInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResultFileInfo = resultFileInfo;
            LogsFileInfo = logsFileInfo;
            ArtifactsContainerInfo = artifactsContainerInfo;
            ReportFileInfo = reportFileInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The test run results file. </summary>
        public TestRunFileInfo ResultFileInfo { get; }
        /// <summary> The test run report with metrics. </summary>
        public TestRunFileInfo LogsFileInfo { get; }
        /// <summary> The container for test run artifacts. </summary>
        public ArtifactsContainerInfo ArtifactsContainerInfo { get; }
        /// <summary> The report file for the test run. </summary>
        public TestRunFileInfo ReportFileInfo { get; }
    }
}
