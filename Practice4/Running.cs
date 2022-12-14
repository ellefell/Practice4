using System;

namespace Practice4
{

    public class Running : Activity
    {

        private double _runningDistance;

        
        ///<summary>
        ///Constructor for the Running class.
        ///Inherits from the Activity base class.
        ///<param name="inputRunningDistance"> The total distance in miles of the running activity.</param>
        ///<param name="inputRunningDuration"> The duration of the running activity in minutes.</param>
        ///<param name="inputRunningDate"> The date of the running activity.</param>
        ///<param name="inputActivityType"> The type of the activity.</param>
        ///</summary>
        public Running(double inputRunningDistance, double inputRunningDuration, DateTime inputRunningDate, Constants.ACTIVITYTYPE inputRunningType) :
            base(inputRunningDate, inputRunningDuration, Constants.ACTIVITYTYPE.Running)
            {
                _runningDistance = inputRunningDistance;
                base.SetActivityLengthInMinutes(inputRunningDuration);
                base.SetActivityDate(inputRunningDate);
                base.SetActivityType(inputRunningType);

            }


        ///<summary>
        ///Get the running 
        ///distance
        ///</summary>
        public double GetRunningDistance()
        {
            return _runningDistance;
        }    


        ///<summary>
        ///Set the running
        ///distance
        ///<param name="inputRunningDistance"> The input running distance. </param>
        ///</summary>
        public void SetRunningDistance(double inputRunningDistance)
        {
            _runningDistance = inputRunningDistance;

        }

        ///<summary>
        ///Calculate the 
        ///running distance
        ///in miles
        ///</summary>
        public override double CalculateDistance()
        {
            return (_runningDistance);
        }

        ///<summary>
        ///Calculate the 
        ///running speed
        ///in miles per hour
        ///</summary>
        public override double CalculateSpeed()
        {
            return ((_runningDistance / base.GetActivityLengthInMinutes()) * Constants.MinutesPerHour);
        }


        ///<summary>
        ///Calculate the running
        ///pace.
        ///</summary>
        public override string CalculatePace()
        {
            double doublePace = Constants.MinutesPerHour / CalculateSpeed();
            return $"{Math.Round(doublePace, 2, MidpointRounding.AwayFromZero)}";

        }

        ///<summary>
        ///Returns a summary
        ///of the activity statistics
        ///Example: 03 Nov 2022 Running (30 Min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        ///</summary>
        public override void GetSummary(double distance, double speed, string pace)
        {
            base.GetSummary(distance, speed, pace);
        }




    }
}