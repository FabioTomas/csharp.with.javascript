using csharp.with.javascript.Util;
using Microsoft.ClearScript.V8;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace csharp.with.javascript.Service
{

    public class ScriptEngine
    {
        public ScriptEngine()
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

            dynamic result = JsonConvert.DeserializeObject<dynamic>(JsonObject);

            Console.WriteLine(result["student"]["tituloDisciplinas"]);
            Console.WriteLine(result["admin"]["disciplinasMinistradas"]);

            Console.ReadKey();
        }
    }
}
