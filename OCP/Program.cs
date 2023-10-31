using OCP.Enums;
using OCP.FilterSpecification;
using OCP.ProductExtensions;
using OCP.Products;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };


// Cách dùng bình thường, không theo OCP
var productFilter = new ProductFilter();
Console.WriteLine("==========Old Code==========");
foreach (var product in productFilter.FilterByColor(products, Color.Green))
{
    Console.WriteLine($"{product.Name} is Green");
}
Console.WriteLine("----------------------------");
foreach (var product in productFilter.FilterBySize(products, Size.Large))
{
    Console.WriteLine($"{product.Name} is Large");
}
Console.WriteLine("----------------------------");
foreach (var product in productFilter.FilterBySizeAndColor(products, Size.Large, Color.Green))
{
    Console.WriteLine($"{product.Name} is Large and Green");
}
// Cách dùng khi refactor
Console.WriteLine("\n==========New Code==========\n");
var productFilterRefactor = new ProductFilterRefactor();
var colorGreen = new ColorSpecification(Color.Green);
var sizeLarge = new SizeSpecification(Size.Large);
var colorGreenAndSizeLarge = new AndSpecification<Product>(colorGreen, sizeLarge);

var greenLarge = Color.Green.And(Size.Large);

foreach (var product in productFilterRefactor.Filter(products, colorGreen))
{
    Console.WriteLine($"{product.Name} is Green");
}
Console.WriteLine("----------------------------");
foreach (var product in productFilterRefactor.Filter(products, sizeLarge))
{
    Console.WriteLine($"{product.Name} is Large");
}
Console.WriteLine("----------------------------");
foreach (var product in productFilterRefactor.Filter(products, greenLarge))
{
    Console.WriteLine($"{product.Name} is Large and Green");
}

