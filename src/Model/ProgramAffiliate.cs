﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapfiliateNet.Model
{
    public class ProgramAffiliate : AffiliateBase
    {
        [JsonProperty("referral_link")]
        public ReferralLink ReferralLink { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("approved")]
        public string Approved { get; set; }
    }
}
