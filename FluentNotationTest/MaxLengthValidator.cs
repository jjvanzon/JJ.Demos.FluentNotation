using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    public class MaxLengthValidator : ValidatorBase<string>
    {
        private string _value;
        private object _propertyDisplayName;
        private int maxLength;

        public MaxLengthValidator(string _value, object _propertyDisplayName, int maxLength)
            : base(_value)
        {
            // TODO: Complete member initialization
            this._value = _value;
            this._propertyDisplayName = _propertyDisplayName;
            this.maxLength = maxLength;
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
