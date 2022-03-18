// Copyright (c) Microsoft. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.  

using Newtonsoft.Json;

namespace AzureCognitiveSearch.PowerSkills.Vision.AnalyzeForm
{
    public class Field
    {
        public string Type { get; set; }
        
        public string ValueString { get; set; }

        public int valueNumber { get; set; }

        public string Content { get; set; }

        public BoundingRegion[] BoundingRegions { get; set; }
        
        public double Confidence { get; set; }

        public Span[] spans { get; set; }

    }
}
