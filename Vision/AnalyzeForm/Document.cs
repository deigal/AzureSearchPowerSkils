﻿// Copyright (c) Microsoft. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.  

using Newtonsoft.Json;
using System.Collections.Generic;

namespace AzureCognitiveSearch.PowerSkills.Vision.AnalyzeForm
{
    public class Document
    {
        public string DocType { get; set; }

        public BoundingRegion[] BoundingRegions { get; set; }

        public Dictionary<string, FieldContainer> Fields { get; set; }

        public double Confidence { get; set; }

        public Span[] Spans { get; set; }

    }
}
