using Newtonsoft.Json;

namespace csharp.with.javascript.DTO
{
    public class Admin
    {
        [JsonProperty("tituloDisciplinas")]
        public string TituloDisciplinas { get; set; }

        [JsonProperty("disciplinasMinistradas")]
        public string DisciplinasMinistradas { get; set; }
    }


}
