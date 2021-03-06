﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TapfiliateNet.Model
{
    public class Conversion
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("click")]
        public ConversionClick Click { get; set; }

        [JsonProperty("commissions")]
        public IList<Commission> Commissions { get; set; }

        [JsonProperty("program")]
        public Program Program { get; set; }

        [JsonProperty("affiliate")]
        public ConversionAffiliate Affiliate { get; set; }

        [JsonProperty("meta_data")]
        public IDictionary<string, string> Metadata { get; set; }
    }

    public class ConversionAffiliate
    {
        [JsonProperty("id")]
        public string AffiliateId { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }
    }

    public class ConversionClick
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
