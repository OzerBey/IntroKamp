namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer() { Id=1,FirstName="Yasin",LastName="Özer",City="İstanbul"};
           string result= customer.FirstName;
            System.Console.WriteLine(result);
        }
    }
}
