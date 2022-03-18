// Copyright (c) Microsoft. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.  

using Newtonsoft.Json;

namespace AzureCognitiveSearch.PowerSkills.Vision.AnalyzeForm
{
    public class Document
    {
        public string DocType { get; set; }

        public BoundingRegion[] BoundinRegions { get; set; }

        public Field Field { get; set; }

        public double Confidence { get; set; }

        public Span[] span { get; set; }

    }
}
