using System;

namespace Practice3
{

/* Address contains a string for the street ddress, the ciry, state/province, and country. The Address
should have a method that can return whether it is in the USA or not.
The address should have a method to retuen a string all of its fields togeher in one string
(with newline characters where appropriate) */

public class Address
{
    private bool _livesInUSA = false;

    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    ///<summary>
    ///Determines if the 
    ///country is in the USA
    ///</summary>

    public bool LivesInUSA()
    {
        if (_country == "USA" || _country == "United States")
        {
            _livesInUSA = true;
        }
        return _livesInUSA;
    }

    ///<summary>
    ///Sets the street address
    ///</summary>
    public void SetStreetAddress(string inputAddress)
    {
        _streetAddress = inputAddress;
    }

    ///<summary>
    ///Returns the street address
    ///</summary>
    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    ///<summary>
    ///Returns the city
    ///</summary>
    public string GetCity()
    {
        return _city;
    }

    ///<summary>
    ///Sets the city
    ///</summary>
    public void SetCity(string inputCity)
    {
        _city = inputCity;
    }

    ///<summary>
    ///Sets the state/province
    ///</summary>
    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }

    ///<summary>
    ///Gets the state/province
    ///</summary>
    public string GetStateOrProvince()
    {
        return _stateOrProvince;

    }

    ///<summary>
    ///Sets the country
    ///</summary>
    public void SetCountry(string inputCountry)
    {
        _country = inputCountry;
    }

    ///<summary>
    ///Returns the country
    ///</summary>
    public string GetCountry()
    {
        return _country;
    }

    ///<summary>
    ///Returns all address components
    ///combined into one string.
    ///</summary>
    public string GetFullAddress()
    {
        string _fullAddress = String.Empty;
        string _newLine = Environment.NewLine;

        _fullAddress = $"{_streetAddress}{_newLine}{_city}, {_stateOrProvince}{_newLine}{_country}";

        return _fullAddress;
    }



}


}
