﻿using Newtonsoft.Json;

namespace Bolgrot.Core.Common.Entity.Data
{
    public class AlignmentSides
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }

        [JsonProperty("canConquest")]
        public bool CanConquest { get; set; }
    }
}