using Abstract_Factory;

IToyFactory toyFactory = new WoodenToysFactory();
Bear bear = toyFactory.GetBear();
Cat cat = toyFactory.GetCat();
Console.WriteLine($"I've got {bear.Name} and {cat.Name}");

IToyFactory toyFactory1 = new TeddyToysFactory();
bear = toyFactory1.GetBear();
cat = toyFactory1.GetCat();
Console.WriteLine($"I've got {bear.Name} and {cat.Name}");



    