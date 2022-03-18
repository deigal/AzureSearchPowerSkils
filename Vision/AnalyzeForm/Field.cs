// Copyright (c) Microsoft. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.  

using Newtonsoft.Json;

namespace AzureCognitiveSearch.PowerSkills.Vision.AnalyzeForm
{
    public class Field
    {
        [JsonProperty(PropertyName = "field")]

        public string Type { get; set; }
        
        public string ValueString { get; set; }
        public int ValueNumber { get; set; }

        public string content { get; set; }

        public BoundingRegion boundingRegion { get; set; }

        public double Confidence { get; set; }


    }
}
