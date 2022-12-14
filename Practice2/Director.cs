using System;

namespace Practice2
{
// Write a program that creates at least two orders with 2-3 products each.
// Call the methods to get the packing label, the shipping label, and the total price of the order, and display 
// the results of these methods.


public class Director
{
    private List<Order> _orders = new List<Order>();
    private static string _newLine = Environment.NewLine;

    /// <summary>
    /// Create orders
    /// </summary>

    public void CreateOrders()
    {
        // Create order 1

        string custonerName1 = "Zoey Fell";
        string customerStreetAddress1 = "123 Acorn Way";
        string customerCity1 = "Ulm";
        string customerStateOrProvince1 = "Baden-Wurttenberg";
        string customerCountry1 = "Germany";
        Order order1 = new Order(custonerName1, customerStreetAddress1, customerCity1, customerStateOrProvince1, customerCountry1);


        _orders.Add(order1);

        // Add products to order 1

        Product product1 = new Product("How to Draw Cats", "8888", 25.00M, 1);
        Product product2 = new Product("Drawing Dragons for Dummies", "8889", 54.99M, 10);
        Product product3 = new Product("Magical Stuffed Dragon", "0052", 19.50M, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


//*****************************************************************************************

        // Create order 2

        string customerName2 = "Henry Fell";
        string customerStreetAddress2 = "456 Mario Drive";
        string customerCity2 = "Dallas";
        string customerStateOrProvince2 = "Texas";
        string customerCountry2 = "USA";
        Order order2 = new Order(customerName2, customerStreetAddress2, customerCity2, customerStateOrProvince2, customerCountry2);

        _orders.Add(order2);

        // Add products to order 2 

        Product product4 = new Product("How to Help the U.S. Economy", "3612", 55.00M, 5);
        Product product5 = new Product("Becoming a Marine Biologist", "4006", 9.99M, 20);
        Product product6 = new Product("Color Changing Pen", "0939", 12.99M, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
    }

    ///<summary>
    /// Display order contents
    /// such as customer and their
    /// products.
    /// </summary>
    public void DisplayOrders()
    {
        int orderCounter = 1;

        foreach (Order order in _orders)
        {
            Console.WriteLine($"Processing Order {orderCounter} ... {_newLine}");
            order.GetPackingLabel();
            Console.WriteLine(_newLine);
            order.GetShippingLabel();
            Console.WriteLine($"The total cost of the order is: {order.CalculateCost().ToString("C2")}.");
            Console.WriteLine(_newLine);

            orderCounter++;
        }
    }

}
}