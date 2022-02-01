using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparationMVP
{
    internal interface ITaskLayer
    {
        string    TaskName       { get; set; }
        string    Priority       { get; set; }
        DateTime? StartDate      { get; set; }
        DateTime? DueDate        { get; set; }
        bool      Completed      { get; set; }
        DateTime? CompletionDate { get; set; }

        // communication/messaging
        string StatusChange { set; }
        bool   isDirty      { get; set; }

        event EventHandler<EventArgs> SaveTask;
        event EventHandler<EventArgs> NewTask;
        event EventHandler<EventArgs> PrevTask;
        event EventHandler<EventArgs> NextTask;
    }
}
