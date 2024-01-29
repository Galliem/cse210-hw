using System;
namespace Learning02;
class Programs{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Receptionist";
        job1._jobCompany = "Salt Lake County";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Behavior Therapist";
        job2._jobCompany = "Integrated Autism Therapies";
        job2._startYear = 2021;
        job2._endYear = 2021;

        Job job3 = new Job();
        job3._jobTitle = "Dishwasher";
        job3._jobCompany = "BYU-I Food Services";
        job3._startYear = 2023;
        job3._endYear = 2023;

        Job job4 = new Job();
        job4._jobTitle = "Kitchen Staff";
        job4._jobCompany = "Chick-Fil-A";
        job4._startYear = 2023;
        job4._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allie Garner";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);

        myResume.Display();
    }
    
}