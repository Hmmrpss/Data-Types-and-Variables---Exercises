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

namespace _00.Data_Types_Exercise
{
    class Program
    {
        static void Main()
        {
            var allOfThePictures = long.Parse(Console.ReadLine()); //ammount of all the pictures she has tanken
            var timeToFilterEverySinglePicture = long.Parse(Console.ReadLine()); //time to filter one pic (in seconds)
            var percentOfFilteredPictures = double.Parse(Console.ReadLine());//percentage of the total pictures that are considered “good” to be uploaded
            var timeForUploadingAPictureToTheCloud = long.Parse(Console.ReadLine()); //in seconds

            var timeToFilterAllOfThePictures = (long)(timeToFilterEverySinglePicture * allOfThePictures); //time for filtering the pictures (in seconds) <----1
            var filteredPictures = (long)(Math.Ceiling((allOfThePictures * percentOfFilteredPictures) / 100D)); //total filtered pictures
            var timeForUploadingTheFilteredPictures = (long)(filteredPictures * timeForUploadingAPictureToTheCloud); //time for uploading the filtered pictures (in seconds) <----2
            var totalTimeNeeded = (long)(timeToFilterAllOfThePictures + timeForUploadingTheFilteredPictures); //total time needed (in seconds)

            /* //the judge is too picky for this one
            var seconds = totalTimeNeeded % 60; //the time in seconds
            var minutes = (totalTimeNeeded / 60) % 60; //the time in minutes
            var hours = (totalTimeNeeded / 3600) % 60; //the time in hours
            var days = (totalTimeNeeded / 86400) % 24; //the time in days
             * 
            var result = days.ToString("D1") + ":" + hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2");
            Console.WriteLine(result);
             */

            TimeSpan time = TimeSpan.FromSeconds(totalTimeNeeded);
            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}