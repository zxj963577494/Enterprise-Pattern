using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryObject.Infrastructure
{
    /// <summary>
    /// 有时候复杂的查询难以创建，我们需要使用数据库视图或存储过程实现，下面创建QueryName枚举类来存放所有的名称查询的名称
    /// </summary>
    public enum QueryName
    {
        /// <summary>
        /// 动态创建
        /// </summary>
        Dynamic = 0,
        /// <summary>
        /// 使用已经创建好了的存储过程、视图、特别是查询比较复杂时使用存储过程
        /// </summary>
        RetrieveOrdersUsingAComplexQuery = 1
    }
}
