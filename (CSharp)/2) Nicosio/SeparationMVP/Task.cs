using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparationMVP
{
    internal class Task
    {
        public string    Name           { get; set; }
        public string    Priority       { get; set; }
        public DateTime? StartDate      { get; set; }
        public DateTime? DueDate        { get; set; }
        public bool      Completed      { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
