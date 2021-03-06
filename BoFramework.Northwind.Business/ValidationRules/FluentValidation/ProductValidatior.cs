using BoFramework.Northwind.Entities.Concrate;
using FluentValidation;

namespace BoFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidatior : AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 20);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p => p.CategoryId==1);

           // RuleFor(p => p.ProductName).Must(startWithA);
        }

        private bool startWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
