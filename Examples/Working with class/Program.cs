
using Working with class;

Console.WriteLine("Hello, World!");

Product p1 = new Product();
p1.price = 340;
Console.WriteLine(p1.price);
p1.Discount(10);
Console.WriteLine(Product.count);

Product p2 = new Product();
p2.price = 1100;
Console.WriteLine(p2.price);
p2.Discount(10);
Console.WriteLine(Product.count);
