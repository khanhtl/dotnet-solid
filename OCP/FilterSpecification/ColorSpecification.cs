using OCP.Enums;
using OCP.Interface;
using OCP.Products;
namespace OCP.FilterSpecification
{
    /// <summary>
    /// Lọc theo màu sắc
    /// </summary>
    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;
        public ColorSpecification(Color color)
        {
            this._color = color;
        }
        public bool IsSatisfied(Product item)
        {
            return item.Color == _color;
        }
    }
}
