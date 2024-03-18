using Newtonsoft.Json;

namespace csharp.with.javascript.DTO
{
    public class Student
    {
        [JsonProperty("home")]
        public Home Home { get; set; }
        [JsonProperty("tituloDisciplinas")]
        public string TituloDisciplinas { get; set; }
    }


}
