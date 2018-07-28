using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    public abstract class ValidatorBase<TObject> : IValidator
    {
        public TObject Object { get; private set; }
        public TObject Value { get { return Object; } }

        public ValidatorBase(TObject obj)
        {
            Object = obj;
        }

        protected void ExecuteValidator(IValidator validator)
        {
            throw new NotImplementedException();
        }

        public abstract void Execute();

        public ValidatorBase<TObject> For(Func<TObject, object> value, string propertyDisplayName = null)
        {
            throw new NotImplementedException();
        }

        public ValidatorBase<TObject> NotNullOrWhiteSpace()
        {
            throw new NotImplementedException();
        }

        public ValidatorBase<TObject> MaxLength(int maxLength)
        {
            throw new NotImplementedException();
        }

        internal ValidatorBase<TObject> DisplayName(string p)
        {
            throw new NotImplementedException();
        }
    }
}
