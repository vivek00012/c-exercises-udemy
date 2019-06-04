using System;
using System.Collections.Generic;
using System.Linq;

namespace udemy_exercises.exercise1
{
    class exercise1_section5_q4 {
        //declaration of class properties
        public float speedLimit;
        public float remainingDemeritPoints;
        public float currentSpeed;
        public float extendedSpeed;
        public float speedDiffernce;
        public int totalDemeritPoints;
        public float exhaustedDemeritPoints;
        List<float> arrayList = new List<float>();
        const int kmPerDemeritPoint = 5;


        //declaration of class methods..
        public void get_demrit_points()
    {
            //declare local variables inside methods

            try
            {
                Console.WriteLine("Please Provide Your Speed Limit :");
                speedLimit = float.Parse(Console.ReadLine());
                Console.WriteLine("Speed Limit Adjusted: {0} km/hr", speedLimit);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Speed ! Please provide speed in numeric");
                get_demrit_points();
            }

            try
            {
                Console.WriteLine("Please Provide Your Demerit Points :");
                totalDemeritPoints = Convert.ToInt32(Console.ReadLine());
                calculateDemeritPoints();

            }
            catch (Exception)
            {
                Console.WriteLine("Provide Demerit Point in Numeric");
                get_demrit_points();
            }

    }

        public void calculateDemeritPoints()
        {

            try
            {
                Console.WriteLine("Please Input Your Current Speed");
                currentSpeed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Current Speed is:{0} km/hr",currentSpeed);
                if (currentSpeed>speedLimit)
                {
                    speedDiffernce = currentSpeed - speedLimit;
                    arrayList.Add(speedDiffernce);
                    foreach (var item in arrayList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    extendedSpeed = arrayList.Sum();

                    exhaustedDemeritPoints = extendedSpeed / kmPerDemeritPoint;


                    //conditional block

                    if (exhaustedDemeritPoints> totalDemeritPoints)
                    {

                        remainingDemeritPoints = totalDemeritPoints-exhaustedDemeritPoints ;
                        if (remainingDemeritPoints == 0 || remainingDemeritPoints < 0)
                        {
                            Console.WriteLine("Demerit Points Exhausted : {0} and remaining is {1}", exhaustedDemeritPoints, 0);

                        }

                        Console.WriteLine("Your License is Suspended");
                    }
                    else
                    {
                        calculateDemeritPoints();

                    }
                }
                else
                {
                    Console.WriteLine("You are safe ! Maintain the speed please");
                    calculateDemeritPoints();
                }

            }
            catch (Exception)
            {

                throw;
            }
           

        }
    }
}
