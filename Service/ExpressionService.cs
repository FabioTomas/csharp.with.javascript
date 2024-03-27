using csharp.with.javascript.DTO;
using csharp_with_javascript.Helper;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace csharp_with_javascript.Service
{
    public static class ExpressionService
    {
        public static string GetProperty(string propertyPath)
        {
            Root obj = ReadObjectHelper.GetObject();

            ParameterExpression parameter = Expression.Parameter(obj.GetType(), "Resource");

            Expression propertyAccess = propertyPath.Split('.').Aggregate((Expression)parameter, Expression.PropertyOrField);

            LambdaExpression lambda = Expression.Lambda(propertyAccess, parameter);

            Func<Root, object> compiled = (Func<Root, object>)lambda.Compile();
            object value = compiled(obj);

            return value.ToString();
        }
    }
}
