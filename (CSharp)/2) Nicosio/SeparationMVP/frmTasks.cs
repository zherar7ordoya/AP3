using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeparationMVP
{
    public partial class frmTasks : Form, ITaskLayer
    {
        private TaskPresenter presenter;

        public string TaskName
        {
            get { return txtTask.Text; }
            set { txtTask.Text = value; }
        }
        public string Priority
        {
            get { return cboPriority.Text; }
            set { cboPriority.Text = value; }
        }
        public DateTime? StartDate
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtStartDate.Text))
                    return null;
                else
                    return DateTime.Parse(txtStartDate.Text);
            }
            set
            {
                if (value == null)
                    txtStartDate.Text = String.Empty;
                else
                    txtStartDate.Text = value.Value.ToShortDateString();
            }
        }
        public DateTime? DueDate
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtDueDate.Text))
                    return null;
                else
                    return DateTime.Parse(txtDueDate.Text);
            }
            set
            {
                if (value == null)
                    txtDueDate.Text = String.Empty;
                else
                    txtDueDate.Text = value.Value.ToShortDateString();
            }
        }
        public bool Completed
        {
            get { return ckbCompleted.Checked; }
            set { ckbCompleted.Checked = value; }
        }
        public DateTime? CompletionDate
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtCompletionDate.Text))
                    return null;
                else
                    return DateTime.Parse(txtCompletionDate.Text);
            }
            set
            {
                if (value == null)
                    txtCompletionDate.Text = String.Empty;
                else
                    txtCompletionDate.Text = value.Value.ToShortDateString();
            }
        }

        public string StatusChange
        {
            set { lblStatus.Text = value; }
        }

        public bool isDirty { get; set; }

        public event EventHandler<EventArgs> SaveTask;
        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> PrevTask;
        public event EventHandler<EventArgs> NextTask;

        public frmTasks()
        {
            InitializeComponent();
        }
        private void frmTasks_Load(object sender, EventArgs e)
        {
            presenter = new TaskPresenter(this);
            this.isDirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // some basic validation
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                MessageBox.Show("Enter the task name/description.", "Task Detail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTask.Focus();
                return;
            }
            if (SaveTask != null)
            {
                SaveTask(this, EventArgs.Empty);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                if (AbandonEdit() == System.Windows.Forms.DialogResult.Yes)
                {
                    isDirty = false;
                }
                else
                {
                    return;
                }
            }
            if (NewTask != null)
            {
                NewTask(this, EventArgs.Empty);
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                if (AbandonEdit() == System.Windows.Forms.DialogResult.Yes)
                {
                    isDirty = false;
                }
                else
                {
                    return;
                }
            }
            if (PrevTask != null)
            {
                PrevTask(this, EventArgs.Empty);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isDirty)
            {
                if (AbandonEdit() == System.Windows.Forms.DialogResult.Yes)
                {
                    isDirty = false;
                }
                else
                {
                    return;
                }
            }
            if (NextTask != null)
            {
                NextTask(this, EventArgs.Empty);
            }
        }

        private DialogResult AbandonEdit()
        {
            return MessageBox.Show("Abandon current editing?", "Abandon",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }
        private void cboPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }
        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }
        private void txtDueDate_TextChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }
        private void ckbCompleted_CheckedChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }
        private void txtCompletionDate_TextChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }
    }
}
