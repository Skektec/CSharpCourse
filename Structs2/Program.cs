namespace Structs2;

class Program
{
    public struct Event
    {
        public DateTime StartDate;
        public DateTime EndDate;

        public double GetDuration()
        {
            TimeSpan durationDate = EndDate - StartDate; 
            int duration = durationDate.Days;
            return duration;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            bool isOverlapping = otherEvent.EndDate > StartDate;
            return isOverlapping;
        }
    }

   
    public class Exercise
    {
        public static void TestEvents()
        {
            Event event1;
            Event event2;

            event1.StartDate = new DateTime(2024,  07,  01);
            event1.EndDate = new DateTime(2024,  07,  10);
            
            event2.StartDate = new DateTime(2024,  07,  05);
            event2.EndDate = new DateTime(2024,  07,  15);

            double duration = event1.GetDuration();
            Console.WriteLine($"Event 1 Duration: {duration} days");
            
            duration = event2.GetDuration();
            Console.WriteLine($"Event 2 Duration: {duration} days");

            bool overlap = event1.IsOverlapping(event2);

            Console.WriteLine($"Events Overlap: {overlap}");

        }
    }
    
    
    static void Main(string[] args)
    {
        Exercise.TestEvents();
        Console.ReadKey();
    }
}