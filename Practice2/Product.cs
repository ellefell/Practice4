using System;

namespace Practice2
{

/* Product contains the name, product ID, price, and quantity of each product;
The price of this product is computer by multiplying the price and quantity. */


public class Product 
{
    private string _productName;
    private string _productID;
    private decimal _productPrice;
    private int _productQuantity;

    public Product(string name, string ID, decimal price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _productPrice = price;
        _productQuantity = quantity;
    }

///<summary>
///Sets the product name
///</summary>

public void SetProductName(string inputProductName)
{
    _productName = inputProductName;
}


///<summary>
///Gets the product name
///</summary>
public string GetProductName()
{
    return _productName;
}

///<summary>
///Sets the product ID
///</summary>
public void SetProductID(string inputProductID)
{
    _productID = inputProductID;
}

///<summary>
///Gets the product ID
///</summary>
public string GetProductID()
{
    return _productID;
}

///<summary>
///Sets the product price.
///</summary>
public void SetProductPrice(decimal inputProductPrice)
{
    _productPrice = inputProductPrice;
}

///<summary>
///Gets the product price.
///</summary>
public decimal GetProductPrice()
{
    return _productPrice;
}

///<summary>
///Sets the product quantity.
///</summary>
public void SetProductQuantity(int inputProductQuantity)
{
    _productQuantity = inputProductQuantity;
}


///<summary>
///Gets the product quantity.
///</summary>
public int GetProductQuantity()
{
    return _productQuantity;
}

///<summary>
///Returns the price 
///multiplied by the quantity
///</summary>

    public decimal CalculateTotalPrice()
    {
        return _productPrice * _productQuantity;
    }

}
}