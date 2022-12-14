using System;

namespace Practice2
{

public class Address
{
    private bool _livesInUSA = false;

    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    ///<summary>
    ///Determines if the address is in the USA.
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
    /// Sets the full address
    ///</summary>
    public void SetStreetAddress(string inputAddress)
    {
        _streetAddress = inputAddress;
    }

    ///<summary>
    ///Returns the street address.
    ///</summary>
    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    ///<summary>
    /// Returns the city
    ///</summary>
    public string GetCity()
    {
        return _city;
    }

    ///<summary>
    /// Sets the City
    ///</summary>

    public void SetCity(string inputCity)
    {
        _city = inputCity;
    }

    ///<summary>
    /// Sets the state or province.
    ///</summary>

    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }

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
    /// Gets the country.
    /// </summary>
    public string GetCountry()
    {
        return _country;
    }


    ///<summary>
    /// Returns all address components 
    /// combined into one string.
    ///</summary>

    public string GetFullAddress()
    {
        string _fullAddress;
        string _newLine = Environment.NewLine;

        _fullAddress = $"{_streetAddress}{_newLine}{_city}, {_stateOrProvince}{_newLine}{_country}";
        
        return _fullAddress; 
    }

    
}

}