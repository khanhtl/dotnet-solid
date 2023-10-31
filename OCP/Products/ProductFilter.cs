using OCP.Enums;

namespace OCP.Products
{
    public class ProductFilter
    {
        /// <summary>
        /// Nghiệp vụ lọc theo màu
        /// </summary>
        /// <param name="products"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }
        /// <summary>
        /// Nghiệp vụ lọc theo size
        /// </summary>
        /// <param name="products"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }
        #region Nghiệp vụ mới phát sinh
        /// <summary>
        /// Nghiệp vụ mới lọc theo màu và size
        /// </summary>
        /// <param name="products"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        }
        #endregion
    }
}
