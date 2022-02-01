using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparationMVP
{
    internal class TaskPresenter
    {
        private readonly ITaskLayer view;
        private List<Task> tasks;

        // (primitive) maintenance of state:
        private int currentIndex = 0;
        private bool isNew = true;


        public TaskPresenter(ITaskLayer view)
        {
            this.view = view;
            Initialize();
        }


        private void Initialize()
        {
            tasks             = new List<Task>();
            view.SaveTask    += Save;
            view.NewTask     += New;
            view.PrevTask    += Previous;
            view.NextTask    += Next;
            BlankTask();
            view.StatusChange = "Ready";
        }


        private void Save(object sender, EventArgs e)
        {
            Task task;
            if (this.isNew)
            {
                task = new Task();
            }
            else
            {
                // editing an existing task
                task = tasks[currentIndex];
            }
            task.Name = view.TaskName;
            task.Priority = view.Priority;
            task.StartDate = view.StartDate;
            task.DueDate = view.DueDate;
            task.Completed = view.Completed;
            task.CompletionDate = view.CompletionDate;
            if (this.isNew)
            {
                tasks.Add(task);
                this.isNew = false;
                currentIndex = tasks.Count - 1;
                // new items are added at the end
            }
            view.isDirty = false;
            view.StatusChange = "Task saved";
        }


        private void New(object sender, EventArgs e)
        {
            BlankTask();
            this.isNew = true;
            view.isDirty = false;
            currentIndex = tasks.Count;
            view.StatusChange = "New task";
        }


        private void BlankTask()
        {
            view.TaskName       = String.Empty;
            view.Priority       = "Low";
            view.StartDate      = null;
            view.DueDate        = null;
            view.Completed      = false;
            view.CompletionDate = null;
        }


        private void Previous(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                loadTask(tasks[currentIndex]);
                view.isDirty = false;
                view.StatusChange = "Task: " + (currentIndex + 1);
            }
            else
            {
                view.StatusChange = "No previous task";
            }
        }

        private void Next(object sender, EventArgs e)
        {
            if (currentIndex < tasks.Count - 1)
            {
                currentIndex++;
                loadTask(tasks[currentIndex]);
                view.isDirty = false;
                view.StatusChange = "Task: " + (currentIndex + 1);
            }
            else
            {
                view.StatusChange = "No next task";
            }
        }


        private void loadTask(Task task)
        {
            view.TaskName = task.Name;
            view.Priority = task.Priority;
            view.StartDate = task.StartDate;
            view.DueDate = task.DueDate;
            view.Completed = task.Completed;
            view.CompletionDate = task.CompletionDate;
            this.isNew = false;
        }
    }
}
