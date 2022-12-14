using System;

namespace Practice2
{

/* The customer contains a name and an address. The name is a string but the Address is a class.
The customer should have a method that can return whether they live in the US or not.
(Hint: This should call a methos on the address to find this.) */


public class Customer
{
    private string _customerName;
    private Address _customerAddress = new Address();

    public Customer(string customerName, string streetAddress, string city, string stateOrProvince, string country)
    {
        //Define customer name
        _customerName = customerName;

        //Define customer address
        _customerAddress.SetStreetAddress(streetAddress);
        _customerAddress.SetCity(city);
        _customerAddress.SetStateOrProvince(stateOrProvince);
        _customerAddress.SetCountry(country);

    }

    ///<summary>
    ///Set the customer name.
    ///</sumamry>
    public void SetCustomerName(string inputCustomerName)
    {
        _customerName = inputCustomerName;
    }

    ///<summary>
    ///Get the customer name.
    ///</summary>
    public string GetCustomerName()
    {
        return _customerName;
    }

    ///<summary>
    ///Set customer adddress
    ///</summary>

    public void SetCustomerAddress(Address inputAddress)
    {
        _customerAddress = inputAddress;
    }

    ///<summary>
    ///Gets customer adddress
    ///</summary>

    public string GetCustomerAddress()
    {
        return _customerAddress.GetFullAddress();
    }

    ///<summary>
    ///Returns true if the customer
    ///lives in the US.
    ///False otherwise.
    ///</summary>

    public bool LivesInUSA()
    {
        bool _livesInUSA = _customerAddress.LivesInUSA();

        return _livesInUSA;
    }
}



}