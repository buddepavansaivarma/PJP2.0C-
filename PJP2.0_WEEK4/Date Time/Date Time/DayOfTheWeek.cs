using System;
using System.Collections.Generic;

namespace Date_Time_Calculator
{
    public class DayOfTheWeek : IOperation
    {
        public List<string> InputList { get; set; }
        public string Result { get; set; }
        public void PerformOperation()
        {
            var date = InputList[0];
            var dateValue = DateTime.ParseExact(date, "dd-MM-yyyy");
            Result = dateValue.DayOfWeek.ToString();
        }

        public void DisplayResult()
        {
            Console.WriteLine("The Day of the Week is : {0}", Result);
        }
    }
}