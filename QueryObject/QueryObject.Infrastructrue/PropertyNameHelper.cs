using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace QueryObject.Infrastructure
{
    /// <summary>
    /// 使用Lambda表达式获取查询属性名称
    /// </summary>
    public static class PropertyNameHelper
    {
        public static string ResolvePropertyName<T>(Expression<Func<T, object>> expression)
        {
            var expr = expression.Body as MemberExpression;
            if (expr == null)
            {
                var u = expression.Body as UnaryExpression;
                expr = u.Operand as MemberExpression;
            }
            return expr.ToString().Substring(expr.ToString().IndexOf(".") + 1);
        }
    }
}
