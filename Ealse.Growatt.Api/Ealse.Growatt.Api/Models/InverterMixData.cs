using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ealse.Growatt.Api.Models
{
    public class InverterMixData
    {
        [JsonPropertyName("pex")]
        public List<double> pex { get; set; }=new List<double>();

        [JsonPropertyName("pacToGrid")]
        public List<double> ExportedToGrid { get; set; } = new List<double>();

        [JsonPropertyName("ppv")]
        public List<double> SolarGeneration { get; set; } = new List<double>();

        [JsonPropertyName("sysOut")]
        public List<double> SystemProduction { get; set; } = new List<double>();

        [JsonPropertyName("pself")]
        public List<double> SelfConsumption { get; set; } = new List<double>();

        [JsonPropertyName(("elocalLoad"))]
        public List<double> LoadConsumption { get; set; } = new List<double>();

        [JsonPropertyName("pdischarge")]
        public List<double> pdischarge { get; set; } = new List<double>();

        [JsonPropertyName("pacToUser")]
        public List<double> ImportFromGrid { get; set; } = new List<double>();

        public bool Any()
        {
            if (SolarGeneration?.Count == 0) return false; return true;
        }

    }
}
