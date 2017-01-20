/* Задача 19: Thea the Photographer
This problem is from the Programming Fundamentals Retake Exam (11 September 2016).
Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.
She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural) every single picture - you decide to write a program in order to help her.
Thea follows this pattern: first she takes all pictures. Then she goes through every single picture to filter these pictures that are considered "good". Then she needs to upload every single filtered picture to her cloud. She is considered ready when all filtered pictures are uploaded in her picture storage.
You will receive the amount of pictures she had taken. Then the approximate time in seconds for every picture to be filtered. Then a filter factor – a percentage (integer number) of the total photos (rounded to the nearest bigger integer value e.g. 5.01 -> 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded will be given again in seconds. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main()
        {
            int allOfThePictures = int.Parse(Console.ReadLine());
            int timeToFilterEverySinglePicture = int.Parse(Console.ReadLine()); //in seconds
            int FilteredPictures = int.Parse(Console.ReadLine());//percentage of the total pictures that are considered “good” to be uploaded
            int timeForUploadingAPictureToTheCloud = int.Parse(Console.ReadLine()); //in seconds
            int timeForUploadingTheApprovedPictures = ((allOfThePictures * FilteredPictures)/100) * timeForUploadingAPictureToTheCloud;
            int timeNeededInSeconds = (allOfThePictures * timeToFilterEverySinglePicture) + timeForUploadingTheApprovedPictures;
            int seconds = Math.Round(timeNeededInSeconds /60);
            int minutes = seconds / 60;
            int hours = minutes /60;
            int days = hours / 24;
            Console.WriteLine("{0}:{1}:{2}:{3}", days, hours, minutes, seconds);
        }
    }
}
