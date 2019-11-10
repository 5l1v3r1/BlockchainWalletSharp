﻿using Newtonsoft.Json;

namespace BlockchainWalletSharp.Models
{
    public class AddressBalance
    {
        /// <summary>
        ///     The address balance in satoshis
        /// </summary>
        [JsonProperty("balance")]
        public long Balance { get; set; }

        /// <summary>
        ///     The address string
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        ///    The address all time received satoshis
        /// </summary>
        [JsonProperty("total_received")]
        public long TotalReceived { get; set; }
    }
}