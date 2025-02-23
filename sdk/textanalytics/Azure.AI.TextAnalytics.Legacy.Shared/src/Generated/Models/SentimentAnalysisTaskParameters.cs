// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.AI.TextAnalytics.Legacy;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The SentimentAnalysisTaskParameters. </summary>
    internal partial class SentimentAnalysisTaskParameters
    {
        /// <summary> Initializes a new instance of SentimentAnalysisTaskParameters. </summary>
        public SentimentAnalysisTaskParameters()
        {
        }

        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> Gets or sets the opinion mining. </summary>
        public bool? OpinionMining { get; set; }
        /// <summary> Gets or sets the string index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
