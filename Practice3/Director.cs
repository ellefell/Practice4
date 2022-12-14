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




public class Director
{
    private Lecture _lecture1;
    private Outdoor _outdoor1;
    private Reception _reception1;

    public void CreateEvents()
    {
        //Create lecture event
        //************************************************************************
        string lecture1Title = "Rediscovering the backyard";
        string lecture1SpeakerName = "Ivy Greenfield";
        string lecture1Description =    "When Property owners find their backyard is a disaster, ";
                lecture1Description += "they want to find solutions to improving aesthetic beauty and harmony of natural elements. ";
                lecture1Description +=  "This lecture invites the audience to start a wonderful journey finding peace in their ";
                lecture1Description += "backyard through good lawn maintenance, gardening, and landscaping best practices.";
    
        DateTime lecture1Date = new DateTime(2022, 12, 19);
        TimeOnly lecture1Time = TimeOnly.Parse("3:00 PM");
        int lecture1HallCapacity = 50;
        Address lecture1Address = new Address();
        lecture1Address.SetStreetAddress ("548 Bellevue Ave");
        lecture1Address.SetCity ("Newport");
        lecture1Address.SetStateOrProvince ("RI");
        lecture1Address.SetCountry ("USA");

        _lecture1 = new Lecture(lecture1Title, lecture1Description, lecture1Date, lecture1Time, lecture1Address, Constants.EVENTTYPE.Lecture);
        _lecture1.SetLectureHallCapacity(lecture1HallCapacity);
        _lecture1.SetLectureSpeaker(lecture1SpeakerName);

        //Create an outdoor event
        //************************************************************************

        string outdoor1Title = "Shakespear in the Park: A Midsummer Night's Dream";
        string outdoor1Description = "One a midsummer's night, four young friends find themselves wrapped in the dream-like ";
            outdoor1Description += "arms of an enchanted forest where sprites lurk and fairies rule. While a feuding Fairy King ";
            outdoor1Description += "and Queen are at war, their paths are crossed by Bottom, Quince and their friends presenting a play within a play.";
        DateTime outdoor1Date = new DateTime(2008, 8, 1);
        TimeOnly outdoor1Time = TimeOnly.Parse("7:00 PM");
        string outdoor1WeatherForecast = "Clear Tonight";
        Address outdoor1Address = new Address();
        outdoor1Address.SetStreetAddress ("1500 Tenison Pkwy");
        outdoor1Address.SetCity("Dallas");
        outdoor1Address.SetStateOrProvince("Texas");
        outdoor1Address.SetCountry("USA");

        _outdoor1 = new Outdoor(outdoor1Title, outdoor1Description, outdoor1Date, outdoor1Time, outdoor1Address, Constants.EVENTTYPE.Outdoor);
        _outdoor1.SetWeatherStatement(outdoor1WeatherForecast);

        //Create reception event
        //**************************************************************************

        string reception1Title = "Lisa and John's Wedding Reception";
        string reception1Description = "Please join us as we celebrate John and Lisa, ";
            reception1Description += "united in etermal matrimony in the holy temple. ";
            reception1Description += "a ring ceremony will begin in the evening followed by dinner, ";
            reception1Description += "visiting with the bride and groom, and dancing.";
        
        DateTime reception1Date = new DateTime(2008, 11, 1);
        TimeOnly reception1Time = TimeOnly.Parse("5:00 PM");
        Address reception1Address = new Address();
        reception1Address.SetStreetAddress("10600 Preston Road");
        reception1Address.SetCity("Dallas");
        reception1Address.SetStateOrProvince("Texas");
        reception1Address.SetCountry("USA");

        _reception1 = new Reception(reception1Title, reception1Description, reception1Date, reception1Time, reception1Address, Constants.EVENTTYPE.Reception);


    }

    public void DisplayEvents()
    {
        //Display Lecture 1 Messages
        Console.WriteLine(Constants._dividingLine);
        _lecture1.DisplayShortEventDetails();
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._dividingLine);
        _lecture1.DisplayStandardEventDetails();
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._dividingLine);
        _lecture1.DisplayFullEventDetails();

        //Display Outdoor 1 Messages
        Console.WriteLine(Constants._dividingLine);
        _outdoor1.DisplayShortEventDetails();
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._dividingLine);
        _outdoor1.DisplayStandardEventDetails();
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._dividingLine);
        _outdoor1.DisplayFullEventDetails();

        //Display Reception 1 Messages
        Console.WriteLine(Constants._dividingLine);
        _reception1.DisplayShortEventDetails();
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._dividingLine);
        _reception1.DisplayStandardEventDetails();
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._newLine);
        Console.WriteLine(Constants._dividingLine);
        _reception1.DisplayFullEventDetails();
        
    }

}



}