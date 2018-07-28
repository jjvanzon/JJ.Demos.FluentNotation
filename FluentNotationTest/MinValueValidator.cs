using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    public class MinValueValidator : ValidatorBase<IComparable>
    {
        private IComparable _value;
        private object _propertyDisplayName;
        private int _min;

        public MinValueValidator(IComparable value, object propertyDisplayName, int min)
            : base(value)
        {
            // TODO: Complete member initialization
            _value = value;
            _propertyDisplayName = propertyDisplayName;
            _min = min;
        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
