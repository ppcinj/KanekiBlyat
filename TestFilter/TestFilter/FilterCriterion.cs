using System;
using System.Collections.Generic;
using System.Linq;

namespace TestFilter
{
    public class FilterCriterion<T>
    {
        private readonly List<Func<T, bool>> _filters;
        private readonly FilterMode _mode;
        private IEnumerable<T> _origin;

        public FilterCriterion(FilterMode mode)
        {
            _filters = new List<Func<T, bool>>();
            _origin = new List<T>();
            _mode = mode;
        }

        public FilterCriterion<T> UseCriterium(Func<T, bool> exp)
        {
            _filters.Add(exp);
            return this;
        }

        public FilterCriterion<T> SetSource(IEnumerable<T> origin)
        {
            _origin = origin;
            return this;
        }

        public IEnumerable<T> Execute()
        {
            if (_mode == FilterMode.And)
                return _origin.Where(o => _filters.All(f => f(o)));
            else if (_mode == FilterMode.Or)
                return _origin.Where(o => _filters.Any(f => f(o)));
            else if (_mode == FilterMode.And)
                return _origin.Where(o => _filters.All(f => f(o)));
            return null;
        }
    }

    public enum FilterMode
    {
        And,
        Or,
        Exclude
    }
}
