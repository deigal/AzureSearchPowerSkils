// Copyright (c) Microsoft. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.  

using Newtonsoft.Json;

namespace AzureCognitiveSearch.PowerSkills.Vision.AnalyzeForm
{
    public class FieldContainer
    {
        public string type { get; set; }
        public string valueString { get; set; }
        public string content { get; set; }
        public BoundingRegion[] boundingRegions { get; set; }
        public double confidence { get; set; }
        public Span[] spans { get; set; }
    }
}
