using System;

namespace Practice4
{
public class Cycling : Activity
    {


        private double _speed;


        ///<summary>
        ///Constructor for the Cycling class.
        ///Inherits from the Activity base class.
        ///<param name="inputCyclingSpeed"> The cycling speed in miles per hour.</param>
        ///<param name="inputCyclingDuration"> The duration of the cycling activity in minutes.</param>
        ///<param name="inputCyclingDate"> The date of the cycling activity.</param>
        ///<param name="inputActivityType"> The type of the activity.</param>
        ///</summary>
        public Cycling(double inputCyclingSpeed, double inputCyclingDuration, DateTime inputCyclingDate, Constants.ACTIVITYTYPE inputCyclingType) :
            base(inputCyclingDate, inputCyclingDuration, Constants.ACTIVITYTYPE.Cycling)
            {
                _speed = inputCyclingSpeed;
                base.SetActivityLengthInMinutes(inputCyclingDuration);
                base.SetActivityDate(inputCyclingDate);
                base.SetActivityType(inputCyclingType);
            }

        ///<summary>
        ///Get the cycling
        ///Speed in mph
        ///</summary>
        public double GetSpeed()
        {
            return _speed;
        }

        ///<summary>
        ///Set the speed
        ///in miles per hour
        ///</summary>
        public void SetSpeed(int inputSpeed)
        {
            _speed = inputSpeed;
        }

        ///<summary>
        ///Calculate the cycling
        ///distance in miles
        ///</summary>
        public override double CalculateDistance()
        {
            return (base.GetActivityLengthInMinutes() / (Constants.MinutesPerHour / CalculateSpeed()));
        }

        ///<summary>
        ///Calculate the cycling speed
        ///in miles per hour
        ///</summary>
        public override double CalculateSpeed()
        {
            return _speed;
        }

        ///<summary>
        ///Calculate the pace
        ///in minutes and seconds per mile
        ///</summary>
        public override string CalculatePace()
        {
            double doublePace = Constants.MinutesPerHour / CalculateSpeed();

            return $"{Math.Round(doublePace, 2, MidpointRounding.AwayFromZero)}";
        }

        ///<summary>
        ///Returns a summary
        ///of the activity statistics
        ///EX: 03 Nov 2022 Runing (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        ///</summary>
        public override void GetSummary(double distance, double speed, string pace)
        {
            base.GetSummary(distance, speed, pace);

            
        }



    }       





}