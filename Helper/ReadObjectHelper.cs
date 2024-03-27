using csharp.with.javascript.DTO;
using csharp.with.javascript.Util;
using Microsoft.ClearScript.V8;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace csharp_with_javascript.Helper
{
    public static class ReadObjectHelper
    {
        public static Root GetObject()
        {
            V8ScriptEngine _engine;

            _engine = new V8ScriptEngine();
            string content;
            string path = @"..\debug\resource\default.js";
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                content = streamReader.ReadToEnd();
            }

            string javascriptCode = JavascriptHelper.FUNCTIONS.Replace("{content}", content);

            string JsonObject = _engine.Evaluate(javascriptCode).ToString();

            string foo = JavascriptHelper.ROOT.Replace("{Root}", JsonObject);

            return JsonConvert.DeserializeObject<Root>(foo);
        }
    }
}
