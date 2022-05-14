using System;
namespace TechJobsOO
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Employer : JobField
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public Employer()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        public Employer(string value) : base(value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}

