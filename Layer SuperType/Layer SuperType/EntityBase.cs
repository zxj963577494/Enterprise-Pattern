using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layer_SuperType
{
    /// <summary>
    /// 超类型,领域驱动实体类父类
    /// </summary>
    public abstract class EntityBase<T>
    {
        private T _id;

        private IList<string> _brokenRules = new List<string>();

        private bool _idHasBeenSet = false;

        public EntityBase()
        {

        }

        public EntityBase(T id)
        {
            this.Id = id;
        }

        public T Id {
            get { return _id; }
            set {
                if (_idHasBeenSet)
                {
                    ThrowExceptionOverwritingAnId();
                }
                _id = value;
                _idHasBeenSet = true;
            }
        }

        private void ThrowExceptionOverwritingAnId()
        {
            throw new ApplicationException("无法更改该实体ID");
        }

        public bool IsValid()
        {
            CleanCollectionOfBrokenRules();
            CheckForBrokenRules();
            return _brokenRules.Count == 0;
        }

        protected abstract void CheckForBrokenRules();

        private void CleanCollectionOfBrokenRules()
        {
            _brokenRules.Clear();
        }

        public IEnumerable<string> GetBrokenBussnessRules()
        {
            return _brokenRules;
        }

        protected void AddBrokenRule(string brokenRule)
        {
            _brokenRules.Add(brokenRule);
        }
    }
}
