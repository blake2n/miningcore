using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Miningcore.Blockchain.Equihash.DaemonResponses
{
    public class ZeroNodeBlockTemplateExtra : PayeeBlockTemplateExtra
    {
        public JToken Zeronode { get; set; }

        [JsonProperty("payee")]
        public string ZeroNodePayee { get; set; }

        [JsonProperty("payee_amount")]
        public long ZeroNodePayeeAmount { get; set; }

        [JsonProperty("masternode_payments")]
        public bool ZeroNodePaymentsStarted { get; set; }

        [JsonProperty("enforce_masternode_payments")]
        public bool ZeroNodePaymentsEnforced { get; set; }
    }
}
