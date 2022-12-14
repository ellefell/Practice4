using System;

namespace Practice3
{



public class Lecture : Event
{
    private string _speakerName;

    private int _lectureHallCapacity;


    
    ///<summary>
    ///Constructor for the lecture class.
    ///This class inherits from the Event base class.
    ///<param name="inputLectureTitle"> The title of the lecture</param>
    ///<param name="inputLectureDescription"> A short description of the lecture</param>
    ///<param name="inputLectureDate"> The date of the lecture</param>
    ///<param name="inputLectureTime"> The time of the lecture</param>
    ///<param name="inputLectureAddress"> The location of the lecture</param>
    ///<param name="inputEventType"> The type of the event</param>
    ///</summary>

    public Lecture(string inputLectureTitle, string inputLectureDescription, DateTime inputLectureDate,TimeOnly inputLectureTime, Address inputLectureAddress, Constants.EVENTTYPE inputLectureType):
    base(inputLectureTitle, inputLectureDescription, inputLectureDate, inputLectureTime, inputLectureAddress, Constants.EVENTTYPE.Lecture)
    {
        SetEventTitle(inputLectureTitle);
        SetEventDescription(inputLectureDescription);
        SetEventTime(inputLectureTime);
        SetEventAddress(inputLectureAddress);
        SetEventType(inputLectureType);

    }

    ///Getters and Setters
    ///<summary>
    ///Get the lecture
    ///speaker.
    ///</summary>
    public string GetLectureSpeaker()
    {
        return _speakerName;

    }

    ///<summary>
    ///Set the lecture
    ///speaker name.
    ///<param name="inputLectureSpeaker"> The string representation of the lecture speaker name.</param>
    ///</summary>
    public void SetLectureSpeaker(string inputLectureSpeaker)
    {
        _speakerName = inputLectureSpeaker;
    }

    ///<summary>
    ///Get the lecture
    ///hall capacity.
    ///</summary>
    public string GetLectureHallCapacity()
    {
        return _lectureHallCapacity.ToString();

    }

    ///<summary>
    ///Set the lecture
    ///hall capacity.
    ///<param name="inputLectureHallCapacity"> The int representation of the lecture hall capacity.</param>
    ///</summary>
    public void SetLectureHallCapacity(int inputLectureHallCapacity)
    {
        _lectureHallCapacity = inputLectureHallCapacity;
    }


    ///<summary>
    ///Displays the full
    ///lecture details
    ///</summary>
    public override void DisplayFullEventDetails()
    {
        base.DisplayFullEventDetails();
        Console.WriteLine(Constants._dividingLine);
        Console.WriteLine($"Speaker Name: {GetLectureSpeaker()}");
        Console.WriteLine($"Lecture Capacity: {GetLectureHallCapacity()}");

    }





}


}