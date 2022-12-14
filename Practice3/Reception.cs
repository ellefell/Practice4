using System;

namespace Practice3
{


public class Reception : Event
{

    ///<summary>
    ///Constructor for the Reception
    ///class. This class inherits from the Event base class.
    ///<param name="inputReceptionTitle"> The title of the reception</param> 
    ///<param name="inputReceptionDescription"> The desciption of the reception</param> 
    ///<param name="inputReceptionDate"> The date of the reception</param> 
    ///<param name="inputReceptionTime"> The time of the reception</param> 
    ///<param name="inputReceptionAddress"> The address of the reception</param> 
    ///<param name="inputEventType"> The type of the event</param> 
    ///<summary>
    public Reception(string inputReceptionTitle, string inputReceptionDescription, DateTime inputReceptionDate, TimeOnly inputReceptionTime, Address inputReceptionAddress, Constants.EVENTTYPE inputReceptionType):
    base(inputReceptionTitle, inputReceptionDescription, inputReceptionDate, inputReceptionTime, inputReceptionAddress, Constants.EVENTTYPE.Reception)
    {
        SetEventTitle(inputReceptionTitle);
        SetEventDescription(inputReceptionDescription);
        SetEventTime(inputReceptionTime);
        SetEventAddress(inputReceptionAddress);
        SetEventType(inputReceptionType);
    }

    ///<summary>
    ///Return the email
    ///to RSVP
    ///</summary>
    public string GetRegistrationEmailAddress()
    {
        return Constants._registrationEmailAddress;
    }

    ///<summary>
    ///Displays the full
    ///reception details
    ///</summary>
    public override void DisplayFullEventDetails()
    {
        base.DisplayFullEventDetails();
        Console.WriteLine(Constants._dividingLine);
        Console.WriteLine($"Please RSVP to: {GetRegistrationEmailAddress()}");
    }

}

}