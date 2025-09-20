using System;

class Program
{
    static void Main(string[] args)
    {
        //Instancia 1 de la clase Job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2022;
        job1._endYear = 2025;

        //Instancia 2 de la clase Job
        Job job2 = new Job();
        job2._jobTitle = "Electricista";
        job2._company = "PELSA";
        job2._startYear = 20;
        job2._endYear = 2017;

        // Invoca el método DisplayJob
        //job1.DisplayJob();




        Resume MyResume = new Resume();
        MyResume._Name = "Jorge Silva";
        MyResume._jobs.Add(job1);
        MyResume._jobs.Add(job2);
        
        MyResume.DisplayResume();

    }
}
