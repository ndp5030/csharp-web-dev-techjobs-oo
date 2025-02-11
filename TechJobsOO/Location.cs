﻿using System;
namespace TechJobsOO
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Location : JobField
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public Location()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        //// TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
        public Location(string value) : base(value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
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
