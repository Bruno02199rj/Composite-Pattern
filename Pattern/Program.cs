

using Pattern;

Product livro = new Product() { Name = "livro", Price = 35.00m, Category = "Product" };
Product notebook  = new Product() { Name = "Notebook", Price = 35.00m, Category ="Product" };
Product luminaria = new Product() { Name = "luminaria", Price = 32.00m, Category = "Product" };


Combo comboOne = new Combo() { Name = "Combo one", Category = "Combo" };
comboOne.AddProduct(livro);
comboOne.AddProduct(notebook);
comboOne.AddProduct(luminaria);

Combo comboTwo = new Combo() { Name = "combo two", Category = "Combo" };
  
Product mesa = new Product()    { Name = "mesa", Price = 35.00m, Category = "Product" };
Product cadeira = new Product() { Name = "cadeira", Price = 65.00m, Category = "Product" };
Product monitor = new Product() { Name = "monitor", Price = 32.00m, Category = "Product" };

comboTwo.AddProduct(cadeira);
comboTwo.AddProduct(monitor);
comboTwo.AddProduct(mesa);

comboOne.AddProduct(comboTwo);

comboOne.GetProductDetails();
comboOne.GetProductPrice();

Console.Read();