using System.Collections;

namespace CompositePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }











    public interface AbstractEmployee
    {
        float getSalary();      //get current salary 
        string getName();      //get name 
        bool isLeaf();      //true if leaf 
        void add(string nm, float salary);  //add subordinate 
        void add(AbstractEmployee emp);    //add subordinate 
        IEnumerator getSubordinates();    //get subordinates 
        AbstractEmployee getChild();    //get child 
        float getSalaries();    //get sum of salaries  
    }




    public class Employee : AbstractEmployee
    {
        protected float salary;
        protected string name;
        protected ArrayList subordinates;
        //------ 
        public Employee(string nm, float salry)
        {
            subordinates = new ArrayList();
            name = nm;
            salary = salry;
        }
        //------ 
        public float getSalary()
        {
            return salary;
        }
        //------ 
        public string getName()
        {
            return name;
        }
        //------ 
        public bool isLeaf()
        {
            return subordinates.Count == 0;
        }
        //------ 
        public virtual AbstractEmployee getChild()
        {
            return null;
        }

        public void add(string nm, float salary)
        {
            throw new Exception("No subordinates in base employee class");
        }

        public void add(AbstractEmployee emp)
        {
            throw new Exception("No subordinates in base employee class");
        }

        public IEnumerator getSubordinates()
        {
            return subordinates.GetEnumerator();
        }

        public float getSalaries()
        {
            float sum;
            AbstractEmployee esub;
            //get the salaries of the boss and subordinates 
            sum = getSalary();
            IEnumerator enumSub = subordinates.GetEnumerator();
            while (enumSub.MoveNext())
            {
                esub = (AbstractEmployee)enumSub.Current;
                sum += esub.getSalaries();
            }
            return sum;
        }






    }



    public class Boss : Employee
    {
        public Boss(string name, float salary) : base(name, salary) { }
        //------ 
        public override void add(string nm, float salary)
        {
            AbstractEmployee emp = new Employee(nm, salary);
            subordinates.Add(emp);
        }
        //------ 
        public override void add(AbstractEmployee emp)
        {
            subordinates.Add(emp);
        }
        //------ 
    }









}