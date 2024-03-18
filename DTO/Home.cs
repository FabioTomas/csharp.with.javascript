using Newtonsoft.Json;

namespace csharp.with.javascript.DTO
{
    public class Home
    {
        [JsonProperty("tituloDisciplinasDigital")]
        public string TituloDisciplinasDigital { get; set; }

        [JsonProperty("tituloDisciplinasNaoDigital")]
        public string TituloDisciplinasNaoDigital { get; set; }

        [JsonProperty("tituloDisciplinasGeral")]
        public string TituloDisciplinasGeral { get; set; }
    }


}
