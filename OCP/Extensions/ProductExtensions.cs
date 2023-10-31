using OCP.Enums;
using OCP.FilterSpecification;
using OCP.Products;

namespace OCP.ProductExtensions
{
    public static class Extensions
    {
        public static AndSpecification<Product> And(this Color color, Size size)
        {
            return new AndSpecification<Product>(
                new ColorSpecification(color),
                new SizeSpecification(size));
        }
        public static AndSpecification<Product> And(this Size size, Color color)
        {
            return new AndSpecification<Product>(
                new ColorSpecification(color),
                new SizeSpecification(size));
        }
    }
}
