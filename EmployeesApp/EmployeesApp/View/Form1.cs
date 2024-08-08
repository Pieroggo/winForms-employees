using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeesApp.View
{
    public partial class Form1 : Form
    {

        public event Action<string> GetName;
        public event Action<string> GetSurname;
        public event Action<DateTime> GetBirthDate;
        public event Action<decimal> GetSalary;
        public event Action<string> GetPositionType;
        public event Action<string> GetContractType;
        public event Action<int> GetEmployeeFromListBox;
        public event Action AddEmployee; //add currentEmployee to model.list
        public event Action UpdateListBox; //update employeeBox with current list in model
        public event Action SaveSerialize;//serialization of list
        public event Action LoadDeserialize; //deserialization from xml file
        bool nameBoxChosen = false;
        bool surnameBoxChosen = false;
        public ListBox.ObjectCollection EmployeeBoxContents {
            get { return employeeBox.Items; }

        }
        public string nameString {
            set { nameBox.Text = value; }
        }
        public string surnameString
        {
            set { surnameBox.Text = value; }
        }
        public DateTime dateBoxDate
        {
            set { dateTimeBox.Value = value; }
        }
        public decimal salaryDecimal
        {
            set { salaryBox.Value = value; }
        }
        public string positionString{
            set {
                if (value == "JuniorDeveloper") { positionBox.SelectedItem = "Junior Developer"; }
                if (value == "MidDeveloper") { positionBox.SelectedItem = "Mid Developer"; }
                if (value == "SeniorDeveloper") { positionBox.SelectedItem = "Senior Developer"; }
                if (value == "ProjectManager") { positionBox.SelectedItem = "Project Manager"; }
                if (value == "Tester") { positionBox.SelectedItem = "Tester"; }
            }

}
        public string contractString
        {
            set {
                if (value == "Permanent")
                {
                    permanentContractButton.Checked = true;
                    fixedTermContractButton.Checked = false;
                    mandateContractButton.Checked = false;
                }
                  if (value == "FixedTerm")
                    {
                        permanentContractButton.Checked = false;
                        fixedTermContractButton.Checked = true;
                        mandateContractButton.Checked = false;
                    }
                    if (value == "Mandate")
                    {
                        permanentContractButton.Checked = false;
                        fixedTermContractButton.Checked = false;
                        mandateContractButton.Checked = true;
                    }

                }
        }
        public Form1()
        {
            InitializeComponent();
            permanentContractButton.Checked = true;
            this.Text = "Employees";
            this.Update();

        }

        private void addClick(object sender, EventArgs e)
        {
            AddEmployee?.Invoke();
            UpdateListBox?.Invoke();
            nameBox.Text = string.Empty;
            surnameBox.Text = string.Empty;
            dateTimeBox.Value = DateTime.Now;
            salaryBox.Value = 1000;
            permanentContractButton.Checked = true;
            fixedTermContractButton.Checked = false;
            mandateContractButton.Checked = false;

        }

        private void nameChanged(object sender, EventArgs e)
        {
            if (sender == nameBox) { GetName?.Invoke(nameBox.Text); }
            else { GetSurname?.Invoke(surnameBox.Text); }
            Console.WriteLine((sender as TextBox).Text);
            inputValidation(sender,new CancelEventArgs());
        }

        private void dateChanged(object sender, EventArgs e)
        {
            GetBirthDate?.Invoke(dateTimeBox.Value);
            Console.WriteLine(dateTimeBox.Value.ToShortDateString());
            

        }

        private void salaryChanged(object sender, EventArgs e)
        {
            GetSalary?.Invoke(salaryBox.Value);
            Console.WriteLine(salaryBox.Value);
            

        }

        private void positionChanged(object sender, EventArgs e)
        {
            string positionStr = positionBox.SelectedItem.ToString();
            GetPositionType?.Invoke(positionStr);
            Console.WriteLine(positionStr);
        }

        private void contractChanged(object sender, EventArgs e)
        {
            string contractStr = "";
            if (permanentContractButton.Checked == true) { contractStr = "Permanent"; }
            if (fixedTermContractButton.Checked == true) { contractStr = "Fixed-Term"; }
            if (mandateContractButton.Checked == true) { contractStr = "Mandate"; }
            GetContractType?.Invoke(contractStr);
            Console.WriteLine(contractStr);
        }

        private void inputValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text)) { errorProvider_name.SetError(nameBox, "Proszę wpisz imię"); }
            else { errorProvider_name.SetError(nameBox,null); }
            if (string.IsNullOrEmpty(surnameBox.Text)) { errorProvider_surname.SetError(surnameBox, "Proszę wpisz imię"); }
            else { errorProvider_surname.SetError(surnameBox,null); }
        }

        private void saveToFile(object sender, EventArgs e)
        {
            SaveSerialize?.Invoke();
        }

        private void loadFromFile(object sender, EventArgs e)
        {
            LoadDeserialize?.Invoke();
            UpdateListBox?.Invoke();
        }

        private void chosenNameBox(object sender, EventArgs e)
        {
            nameBoxChosen = true;
        }

        private void chosenSurnameBox(object sender, EventArgs e)
        {
            surnameBoxChosen = true;
        }

        private void getEmployeeFromList(object sender, EventArgs e)
        {
            Console.WriteLine(employeeBox.SelectedIndex);
            GetEmployeeFromListBox?.Invoke(employeeBox.SelectedIndex);
        }

        
    }
}
