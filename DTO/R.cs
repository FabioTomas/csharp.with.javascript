using Newtonsoft.Json;

namespace csharp.with.javascript.DTO
{
    public class R
    {
        [JsonProperty("student")]
        public Student Student { get; set; }

        [JsonProperty("admin")]
        public Admin Admin { get; set; }
    }
}
