public class Address
{
    //Attributes---------------------------
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;

    //Constructor---------------------------
    public Address(string street, string city, string state_province, string country)
    {
        _street = street;
        _city = city;
        _state_province = state_province;
        _country = country;
    }

    //Getters and Setters---------------------
    public string GetSteet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState_Province()
    {
        return _state_province;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetStateProvince(string state_province)
    {
        _state_province = state_province;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    //Methods-----------------------------------------------------
    public bool IsUSA()
    {
        //This method will return false if the country is not part of the USA. If so, true.

        if (_country.ToUpper() == "USA" || _country.ToLower() == "united states of america" || _country.ToLower() == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        //This method will return the full address.
        string fullAddress = $"\n\n{_street.ToLower()}, {_city}, {_state_province}, {_country}";
        return fullAddress;

    }

}