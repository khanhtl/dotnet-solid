using OCP.Enums;
using OCP.Interface;
using OCP.Products;

namespace OCP.FilterSpecification
{
    /// <summary>
    /// Lọc theo size
    /// </summary>
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product item)
        {
            return item.Size == _size;
        }
    }
}
