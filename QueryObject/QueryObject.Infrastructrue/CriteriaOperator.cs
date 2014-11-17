using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryObject.Infrastructure
{
    /// <summary>
    /// 条件操作符枚举
    /// </summary>
    public enum CriteriaOperator
    {
        Equal,              //=
        NotApplicable,      //<>
        LessThanOrEqual,    //<=
        LessThan,           //<
        GreaterThan,        //>
        GreaterThanOrEqual, //>=
        Like               //%
    }
}
