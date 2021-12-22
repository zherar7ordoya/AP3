using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite1
{
    public partial class Form1 : Form
    {
        public Form1() {  InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buildEmployeeList()
        {

            Boss prez = new Boss("CEO", 200000);
            Boss marketVP = new Boss("Marketing VP", 100000);
            prez.add(marketVP);
            Boss salesMgr = new Boss("Sales Mgr", 50000);
            Boss advMgr = new Boss("Advt Mgr", 50000);
            marketVP.add(salesMgr);
            marketVP.add(advMgr);
            Boss prodVP = new Boss("Production VP", 100000);
            prez.add(prodVP);
            advMgr.add("Secy", 20000);


            //add salesmen reporting to sales manager 
            for (int i = 1; i <= 5; i++)
            {
                salesMgr.add("Sales" + i.ToString(), 30000);
            }

            Boss prodMgr = new Boss("Prod Mgr", 40000);
            Boss shipMgr = new Boss("Ship Mgr", 35000);
            prodVP.add(prodMgr);
            prodVP.add(shipMgr);

            for (int i = 1; i <= 3; i++)
            {
                shipMgr.add("Ship" + i.ToString(), 25000);
            }
            for (int i = 1; i <= 4; i++)
            {
                prodMgr.add("Manuf" + i.ToString(), 20000);
            }
        }



        private void buildTree()
        {
            EmpNode nod = new EmpNode(prez);
            EmpNode rootNode = nod;
            EmpTree.Nodes.Add(nod);
            addNodes(nod, prez);
        }


        private void getNodeSum(EmpNode node)
        {
            AbstractEmployee emp;
            float sum;

            emp = node.getEmployee();
            sum = emp.getSalaries();
            lbSalary.Text = sum.ToString();
        }

        private void EmpTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EmpNode node;
            node = (EmpNode)EmpTree.SelectedNode;
            getNodeSum(node);
        }


    }






    public class EmpNode : TreeNode
    {
        private AbstractEmployee emp;
        public EmpNode(AbstractEmployee aemp) :
      base(aemp.getName())
        {
            emp = aemp;
        }
        //----- 
        public AbstractEmployee getEmployee()
        {
            return emp;
        }
    }






    public interface AbstractEmployee
    {
        float getSalary();                  //get current salary 
        string getName();                   //get name 
        bool isLeaf();                      //true if leaf 
        void add(string nm, float salary);  //add subordinate 
        void add(AbstractEmployee emp);     //add subordinate 
        IEnumerator getSubordinates();      //get subordinates 
        AbstractEmployee getChild();        //get child 
        float getSalaries();                //get sum of salaries  
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

        //------
        public IEnumerator getSubordinates()
        {
            return subordinates.GetEnumerator();
        }

        //------
        public virtual void add(string nm, float salary)
        {
            throw new Exception("No subordinates in base employee class");
        }

        //------
        public virtual void add(AbstractEmployee emp)
        {
            throw new Exception("No subordinates in base employee class");
        }

        //------
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
