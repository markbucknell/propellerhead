using Propellerhead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Propellerhead.ViewModels
{
    public class NoteDetailViewModel
    {
        public int NoteId { get; set; }

        public string Value { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool Active { get; set; }

        public virtual int CustomerId { get; set; }
    }
}