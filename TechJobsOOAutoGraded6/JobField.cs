using System;


namespace TechJobsOOAutoGraded6;

public abstract class JobField
{
    private static int nextId = 1;
    public int Id { get;  set; }
    public string Value { get; set; }

    public JobField()
    {
        Id = nextId;
        nextId++;
    }

    public JobField(string value) : this()
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }

    public override bool Equals(object obj)
    {
        return obj is JobField field &&
               Id == field.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }


}