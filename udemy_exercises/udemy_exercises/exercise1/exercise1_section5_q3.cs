using System;

namespace udemy_exercises.exercise1
{
    public class exercise1_section5_q3
    {
        public int imgHeight;
        public int imgWidth;

     public void getImageHeight()
        {

            try
            {
                Console.WriteLine("******Enter Height of the Image******");
                imgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Height = {0}", imgHeight);
                getImageWidth();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Width! Please Try Again");
                getImageHeight();
                
            }
        }

     public void getImageWidth()
        {

            try
            {
                Console.WriteLine("******Enter Width of the Image******");
                imgWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Width = {0}", imgWidth);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Width! Please Try Again");
                getImageHeight();
            }

            //conditional block
            if (imgHeight > imgWidth)
            {
                Console.WriteLine("The image is Portrait");
            }
            else if(imgHeight < imgWidth)
            {
                Console.WriteLine("The image is Landscape");
            }
            else
            {
                Console.WriteLine("The image is Square");
            }
        }

    }
}
