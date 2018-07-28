using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    class MaxValueValidator : ValidatorBase<IComparable>
    {
        private object _propertyDisplayName;
        private int max;

        public MaxValueValidator(IComparable _value, object _propertyDisplayName, int max)
            : base(_value)
        {
            this._propertyDisplayName = _propertyDisplayName;
            this.max = max;
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
