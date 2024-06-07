﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency
	{
       
        private static int nextId = 1;


        // TODO: Task 2: Change the fields to auto-implemented properties.
 public string Value{ get; set; }
 public int Id{ get; set; }
        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

