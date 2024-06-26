﻿using System;
using System.Reflection.Emit;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
       

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
        public Job() 
        {
            Id = nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency):this()
        {
            Id = nextId++;
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
   public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
         public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
public override string ToString()
{
return $"{Environment.NewLine}ID: {nextId++}{Environment.NewLine}Name: {Name}{Environment.NewLine}EmployerName: {EmployerName}{Environment.NewLine}EmployerLocation: {EmployerLocation}{Environment.NewLine}JobType: {JobType}{Environment.NewLine}JobCoreCompetency: {JobCoreCompetency}{Environment.NewLine}";
}  

}
}

