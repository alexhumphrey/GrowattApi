using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ealse.Growatt.Api.Models
{
    public class InverterMixData
    {
        [JsonPropertyName("pex")]
        public List<double> pex { get; set; }

        [JsonPropertyName("pacToGrid")]
        public List<double> ExportedToGrid { get; set; }

        [JsonPropertyName("ppv")]
        public List<double> SolarGeneration { get; set; }

        [JsonPropertyName("sysOut")]
        public List<double> SystemProduction { get; set; }

        [JsonPropertyName("pself")]
        public List<double> SelfConsumption { get; set; }

        [JsonPropertyName(("elocalLoad"))]
        public List<double> LoadConsumption { get; set; }

        [JsonPropertyName("pdischarge")]
        public List<double> pdischarge { get; set; }

        [JsonPropertyName("pacToUser")]
        public List<double> ImportFromGrid { get; set; }

    }
}
