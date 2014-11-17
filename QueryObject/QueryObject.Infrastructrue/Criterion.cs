using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace QueryObject.Infrastructure
{
    /// <summary>
    /// 查询条件类
    /// </summary>
    public class Criterion
    {
        private string _propertyName;
        private object _value;
        private CriteriaOperator _criteriaOperator;

        public Criterion(string propertyName, object value,
       CriteriaOperator criteriaOperator)
        {
            _propertyName = propertyName;
            _value = value;
            _criteriaOperator = criteriaOperator;
        }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string PropertyName
        {
            get { return _propertyName; }
        }


        /// <summary>
        /// 属性名称对应的值
        /// </summary>
        public object Value
        {
            get { return _value; }
        }

        /// <summary>
        /// 条件操作符枚举
        /// </summary>
        public CriteriaOperator CriteriaOperator
        {
            get { return _criteriaOperator; }
        }

        public static Criterion Createe<T>(Expression<Func<T, object>> expression, object value, CriteriaOperator criteriaOpertor)
        {
            string propertyName = PropertyNameHelper.ResolvePropertyName<T>(expression);
            Criterion myCriteria = new Criterion(propertyName, value, criteriaOpertor);
            return myCriteria;
        }
    }
}
