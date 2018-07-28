using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNotationTest
{
    public class ItemValidator : ValidatorBase<Item>
    {
        public ItemValidator(Item item)
            : base(item)
        { }

        public override void Execute()
        {
            // This is the right way. But too verbose.
            var itemName1Validator1 = new PropertyValidator(Object.ItemName1, PropertyDisplayNames.ItemName1);
            itemName1Validator1.NotNullOrWhiteSpace();
            itemName1Validator1.MaxLength(24);
            ExecuteValidator(itemName1Validator1);

            // This is how you would hope it could be programmed. If only they took over the with statement from VB when they made C#.
            var itemName1Validator2 = new PropertyValidator(Object.ItemName1, PropertyDisplayNames.ItemName1);
            //with (itemName1Validator2)
            //{
            //    .NotNullOrWhiteSpace();
            //    .MaxLength(24);
            //};
            ExecuteValidator(itemName1Validator2);

            // And because we can't, we use fluent notation, which means abusing the language, creating all sorts of pitfalls.
            // We abuse member access, we abuse delegates, we abuse return values and there is order-dependence while we assume there is not.
            // All this to create brevity where we need it, plus brevity where we shouldn't want it and then consistent stupidity,
            // by also making the DisplayName a fluent method, which you really shouldn't do.
            For(x => x.ItemName1)
                .DisplayName(PropertyDisplayNames.ItemName1)
                .NotNullOrWhiteSpace()
                .MaxLength(24);
            // But also because script kiddies think it is 'cool'. Like that matters.
            // The abuse of return values for fluent notation is exactly why ExpressionVisitor methods have to return this.

            // But since 'with' statements are not possible in C#, I shall go with the fluent notation, for brevity's sake, except for the .DisplayName method (that's stupid):
            For(x => x.ItemName1, PropertyDisplayNames.ItemName1)
                .NotNullOrWhiteSpace()
                .MaxLength(24);

            // Maybe you can make something like with:
            var itemName1Validator4 = new PropertyValidator(Object.ItemName1, PropertyDisplayNames.ItemName1);
            X.With(itemName1Validator4,
                x => x.NotNullOrWhiteSpace(),
                x => x.MaxLength(24)
            );
            ExecuteValidator(itemName1Validator2);
            // The fact that it is such a workaround and really does not create the brevity we hoped for, makes it a fail.
        }
    }
}
