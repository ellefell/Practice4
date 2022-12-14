using System;

namespace Practice3
{
/* Write a program that has a base Event class along with derived classes for each type of event. These classes should contain the necessary data and provide methods to return strings for each of the messages the company desires.

Remember that any data or methods that are common among all types of events should be in the base class.

Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.

In addition, your program must:

1. Use inheritance to avoid duplicating shared attributes and methods.
2. Use an address class for the addresses.
3. Follow the principles of encapsulation, making sure each member variable is private. */

public class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private DateTime _eventDate;
    private TimeOnly _eventTime;
    private Address _eventAddress;
    private Constants.EVENTTYPE _eventType;

    //Constructor
    public Event(string inputTitle, string inputDescription, DateTime inputDate, TimeOnly inputTime, Address inputAddress, Constants.EVENTTYPE inputEventType)
    {
        _eventTitle = inputTitle;
        _eventDescription = inputDescription;
        _eventDate = inputDate;
        _eventTime = inputTime;
        _eventAddress = inputAddress;
        _eventType = inputEventType;

    }
    //Getters & Setters

    ///<summary>
    ///Get the event
    ///title
    ///</summary>
    public string GetEventTitle()
    {
        return _eventTitle;
    }

    ///<summary>
    ///Set the event
    ///title
    ///<param name="inputEventTitle"> Represents the event title string object</param>
    ///</summary>
    public void SetEventTitle(string inputEventTitle)
    {
        _eventTitle = inputEventTitle;
    }

    ///<summary>
    ///Get the event
    ///date as a string
    ///</summary>
    public string GetEventDate()
    {
        return _eventDate.ToShortDateString();
    }

    ///<summary>
    ///Set the event
    ///date
    ///<param name="inputEventDate"> Represents the event date</param>
    ///</summary>
    public void SetEventDate(DateTime inputEventDate)
    {
        _eventDate = inputEventDate;
    }

    ///<summary>
    ///Get the event
    ///description
    ///</summary>
    public string GetEventDescription()
    {
        return _eventDescription;

    }

    ///<summary>
    ///Set the event
    ///description
    ///<param name="inputEventDescription"> Represents the event description string object</param>
    ///</summary>
    public void SetEventDescription(string inputEventDescription)
    {
        _eventDescription = inputEventDescription;
    }

    ///<summary>
    ///Get the event
    ///time
    ///</summary>
    public string GetEventTime()
    {
        return _eventTime.ToString();

    }

    ///<summary>
    ///Set the event
    ///time
    ///<param name="inputEventTime"> Represents the event timeonly object</param>
    ///</summary>
    public void SetEventTime(TimeOnly inputEventTime)
    {
        _eventTime = inputEventTime;
    }

    ///<summary>
    ///Get the event
    ///address
    ///</summary>
    public void GetFullAddress()
    {
        _eventAddress.GetFullAddress();

    }

    ///<summary>
    ///Set the event
    ///address
    ///<param name="inputEventAddress"> Represents the event address object</param>
    ///</summary>
    public void SetEventAddress(Address inputEventAddress)
    {
        _eventAddress = inputEventAddress;
    }

    ///<summary>
    ///Gets the string representation of the event
    ///type based on teh enum event type.
    ///The event type os set initially in the constructor.
    ///</summary>
    public string GetEventType()
    {
        switch (_eventType)
        {
            case Constants.EVENTTYPE.Lecture:
                return "Lecture";
            case Constants.EVENTTYPE.Outdoor:
                return "Outdoor";
            case Constants.EVENTTYPE.Reception:
                return "Reception";
            default:
                return "Unknown";
        }
    }

    ///<summary>
    ///Set the event
    ///type
    ///<param name="inputEventType"> Represents the event type enum object</param>
    ///</summary>
    public void SetEventType(Constants.EVENTTYPE inputEventType)
    {
        _eventType = inputEventType;
    }

    ///<summary>
    ///Displays the standard details
    ///of the event
    ///</summary>
    public virtual void DisplayStandardEventDetails()
    {
        Console.WriteLine("Standard Event Details");
        Console.WriteLine(Constants._dividingLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine($"Event Title: {GetEventTitle()}");
        Console.WriteLine($"Event Description: {GetEventDescription()}");
        Console.WriteLine($"Event Date: {GetEventDate()}");
        Console.WriteLine($"Event Time: {GetEventTime()}");
        Console.WriteLine($"Event Address: {Constants._newLine}{_eventAddress.GetFullAddress()}");
    }
    ///<summary>
    ///Displays the full details
    ///of the event
    ///</summary>
    public virtual void DisplayFullEventDetails()
    {
        Console.WriteLine("Full Event Details");
        Console.WriteLine(Constants._dividingLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine($"Event Title: {GetEventTitle()}");
        Console.WriteLine($"Event Type: {GetEventType()}");
        Console.WriteLine($"Event Description: {GetEventDescription()}");
        Console.WriteLine($"Event Date: {GetEventDate()}");
        Console.WriteLine($"Event Time: {GetEventTime()}");
        Console.WriteLine($"Event Address: {Constants._newLine}{_eventAddress.GetFullAddress()}");

    }

    ///<summary>
    ///Displays a shortened list 
    ///of the event details
    ///</summary>
    public virtual void DisplayShortEventDetails()
    {
        Console.WriteLine("Short Event Details");
        Console.WriteLine(Constants._dividingLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine($"Event Title: {GetEventTitle()}");
        Console.WriteLine($"Event Type: {GetEventType()}");
        Console.WriteLine($"Event Date: {GetEventDate()}");
        
        

    }


    }


}

