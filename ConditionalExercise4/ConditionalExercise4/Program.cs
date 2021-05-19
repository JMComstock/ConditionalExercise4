using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise4
{
    class Program
    {
        // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        // etc. and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        // the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        // display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        // demerit points. For every 5mph/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        // the console. If the number of demerit points is above 12, the program should display License Suspended.
        static void Main(string[] args)
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of the car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("OK");
            else
            {
                const int mphPerDetermitPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / mphPerDetermitPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}
