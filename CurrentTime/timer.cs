using System;

public class timer {

    public  static void get_duration_example ()
    {
        Console.WriteLine ("A task starts now....");
        DateTime start = DateTime.Now;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("The task is running....");
            Thread.Sleep(1000);
        }
         DateTime end = DateTime.Now;
         
         long duration = (long) (end - start).TotalMilliseconds;
         long seconds = duration/1000;
         //Console.WriteLine("Duration "+duration);
         Console.WriteLine("The task takes "+seconds+" seconds to complete!");

    }

}