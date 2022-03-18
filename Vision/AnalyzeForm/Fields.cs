// Copyright (c) Microsoft. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.  

using Newtonsoft.Json;

namespace AzureCognitiveSearch.PowerSkills.Vision.AnalyzeForm
{
    public class Fields
    {
        /*[JsonProperty("THC unit")]
        public THCUnit THCUnit { get; set; }
        public CBD CBD { get; set; }

        [JsonProperty("CBD unit")]
        public CBDUnit CBDUnit { get; set; }
        public EcoliLabel Ecoli_label { get; set; }
        public CertificateIssuedDate CertificateIssuedDate { get; set; }
        public THC THC { get; set; }
        public EcoliResult Ecoli_Result { get; set; }*/

        [JsonProperty("Lot Number")]
        public LotNumber LotNumber { get; set; }
    }
}
