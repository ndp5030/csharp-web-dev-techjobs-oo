using System;
namespace TechJobsOO
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class CoreCompetency : JobField
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //// TODO: Change the fields to auto-implemented properties.

        //public CoreCompetency()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        public CoreCompetency(string value) : base(value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
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

