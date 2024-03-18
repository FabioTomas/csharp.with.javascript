namespace csharp.with.javascript.Util
{
    public static class JavascriptHelper
    {
        public const string FUNCTIONS = "{content}\r\n\r\nfunction returnResult(content) {\r\n    return JSON.stringify(content);\r\n}\r\n\r\nreturnResult(R);";
    }
}
