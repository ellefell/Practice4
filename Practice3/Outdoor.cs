using System;

namespace Practice3
{


public class Outdoor: Event
{
    private string _weatherStatement;

    ///<summary>
    ///Constructor for the Outdoor
    ///class. This class inherits from
    ///the Event base class.
    ///<param name="inputOutdoorTitle"> The title of the outdoor event</param>
    ///<param name="inputOutdoorDescription"> The description of the outdoor event</param>
    ///<param name="inputOutdoorDate"> The date of the outdoor event</param>
    ///<param name="inputOutdoorTime"> The time of the outdoor event</param>
    ///<param name="inputOutdoorAddress"> The address of the outdoor event</param>
    ///<param name="inputOutdoorType"> The type of the event</param>
    ///</summary>

    public Outdoor(string inputOutdoorTitle, string inputOutdoorDescription, DateTime inputOutdoorDate, TimeOnly inputOutdoorTime, Address inputOutdoorAddress, Constants.EVENTTYPE inputOutdoorType):
    base(inputOutdoorTitle, inputOutdoorDescription, inputOutdoorDate, inputOutdoorTime, inputOutdoorAddress, Constants.EVENTTYPE.Outdoor)
    {
        SetEventTitle(inputOutdoorTitle);
        SetEventDescription(inputOutdoorDescription);
        SetEventTime(inputOutdoorTime);
        SetEventAddress(inputOutdoorAddress);
        SetEventType(inputOutdoorType);

    }


    ///<summary>
    ///Return the weather statement
    ///</summary>
    public string GetWeatherStatement()
    {
        return _weatherStatement;

    }

    ///<summary>
    ///Set the weather statement
    ///<param name="inputWeatherStatement"> The string representation of the weather forecast</param>
    ///</summary>
    public void SetWeatherStatement(string inputWeatherStatement)
    {
        _weatherStatement = inputWeatherStatement;
    }


    ///<summary>
    ///Displays the full
    ///outdoor event details
    ///</summary>
    public override void DisplayFullEventDetails()
    {
        base.DisplayFullEventDetails();
        Console.WriteLine(Constants._dividingLine);
        Console.WriteLine($"Weather Forecast: {GetWeatherStatement()}");
    }

}


}