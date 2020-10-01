using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using ProjectModel;

namespace ProjectBusiness
{
    public class CRUDManager
    {

        // create a method that takes the person the activity and the time 
        public string Action(string Activity, DateTime StartTime, DateTime EndTime)
        {
            using (var db = new ProjectContext())
            return $"{Activity}: {StartTime} - {EndTime}";
        }

        public List<string> MondayActivties = new List<string>();



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
