using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryObject.Infrastructure
{
    public class Query
    {
        private QueryName _name;
        private IList<Criterion> _criteria;

        public Query()
            : this(QueryName.Dynamic, new List<Criterion>())
        { }

        public Query(QueryName name, IList<Criterion> criteria)
        {
            _name = name;
            _criteria = criteria;
        }

        /// <summary>
        /// 查询名称
        /// </summary>
        public QueryName Name
        {
            get { return _name; }
        }

        /// <summary>
        /// 是否动态创建
        /// </summary>
        /// <returns></returns>
        public bool IsNamedQuery()
        {
            return Name != QueryName.Dynamic;
        }
        

        /// <summary>
        /// 查询条件集合
        /// </summary>
        public IEnumerable<Criterion> Criteria
        {
            get { return _criteria; }
        }

        public void Add(Criterion criterion)
        {
            if (!IsNamedQuery())
            {
                _criteria.Add(criterion);
            }
            else
                throw new ApplicationException(
                    "You cannot add additionalcriteria to named queries");
        }

        /// <summary>
        /// 查询条件连接符枚举
        /// </summary>
        public QueryOperator QueryOperator 
        {
            get;
            set;
        }

        /// <summary>
        /// 查询排序类
        /// </summary>
        public OrderByClause OrderByProperty 
        {
            get;
            set;
        }
    }
}
