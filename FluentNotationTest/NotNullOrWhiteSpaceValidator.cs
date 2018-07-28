using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    public class NotNullOrWhiteSpaceValidator : ValidatorBase<string>
    {
        private string _value;
        private object _propertyDisplayName;

        public NotNullOrWhiteSpaceValidator(string _value, object _propertyDisplayName)
            : base(_value)
        {
            // TODO: Complete member initialization
            this._value = _value;
            this._propertyDisplayName = _propertyDisplayName;
        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
