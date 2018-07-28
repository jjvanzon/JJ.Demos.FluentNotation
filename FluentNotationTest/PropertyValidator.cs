using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    public class PropertyValidator : ValidatorBase<object>
    {
        private object _propertyDisplayName;

        public PropertyValidator(object value, object propertyDisplayName)
            : base(value)
        {
            _propertyDisplayName = propertyDisplayName;
        }

        private List<IValidator> _validators = new List<IValidator>();

        public void NotNullOrWhiteSpace()
        {
            _validators.Add(new NotNullOrWhiteSpaceValidator(Value.ToString(), _propertyDisplayName));
        }

        public void MinValue(int min)
        {
            _validators.Add(new MinValueValidator((IComparable)Value, _propertyDisplayName, min));
        }

        public void MaxValue(int max)
        {
            _validators.Add(new MaxValueValidator(Value.ToString(), _propertyDisplayName, max));
        }

        public void MaxLength(int maxLength)
        {
            _validators.Add(new MaxLengthValidator(Value.ToString(), _propertyDisplayName, maxLength));
        }

        public override void Execute()
        {
            foreach (IValidator validator in _validators)
            {
                ExecuteValidator(validator);
            }
        }
    }
}
