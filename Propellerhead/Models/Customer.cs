using System;
using System.Collections.Generic;

namespace Propellerhead.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool Active { get; set; }

        public virtual List<Note> Notes { get; set; }
    }

    public enum Status
    {
        Prospective,
        Current,
        NonActive
    }
}
