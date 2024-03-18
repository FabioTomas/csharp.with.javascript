using Newtonsoft.Json;

namespace csharp.with.javascript.DTO
{
    public class Root
    {
        [JsonProperty("r")]
        public R R { get; set; }
    }
}
