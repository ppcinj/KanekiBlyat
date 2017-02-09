using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFilter
{
    public static class FilterListOf<T>
    {
        public static FilterCriterionTypeSpecification<T> WithFilterMode => new FilterCriterionTypeSpecification<T>();
    }

    public class FilterCriterionTypeSpecification<T>
    {
        public FilterCriterion<T> Or => new FilterCriterion<T>(FilterMode.Or);
        public FilterCriterion<T> And => new FilterCriterion<T>(FilterMode.And);
        public FilterCriterion<T> Exclude => new FilterCriterion<T>(FilterMode.Exclude);
    }
}
