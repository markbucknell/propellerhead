using System;
using System.Collections.Generic;
using System.Text;

namespace Propellerhead.Models
{
    public class Note
    {
        public int NoteId { get; set; }

        public string Value { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool Active { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
