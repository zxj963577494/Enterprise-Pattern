using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryObject.Infrastructure
{
    /// <summary>
    /// 查询排序类
    /// </summary>
    public class OrderByClause
    {
        private string _propertyName;
        private bool _desc;

        public OrderByClause(string propertyName, bool desc)
        {
            PropertyName = propertyName;
            Desc = desc;
        }

        /// <summary>
        /// 属性名称，根据该属性进行排序
        /// </summary>
        public string PropertyName
        {
            get { return _propertyName; }
            set { _propertyName = value; }
        }

        /// <summary>
        /// 排序类型，ture为倒序,反之为正序
        /// </summary>
        public bool Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
    }
}
