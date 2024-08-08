using EmployeesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Presenter
{
    internal class Presenter
    {
        View.Form1 _view;
        Model.Model _model;
        Model.Employee currentEmployee;
        public Presenter(Model.Model model, View.Form1 view) {

            this._model = model;
            this._view = view;
            currentEmployee = new Employee("", "", DateTime.Today, 1000, ContractType.Permanent, Position.JuniorDeveloper);
            _view.GetName += _changeName;
            _view.GetSurname += _changeSurname;
            _view.GetBirthDate += _changeBirthDate;
            _view.GetSalary += _changeSalary;
            _view.GetPositionType += _changePosition;
            _view.GetContractType += _changeContractType;
            _view.AddEmployee += _addEmployee;
            _view.UpdateListBox += _updateListBox;
            _view.SaveSerialize += _model.serialize;
            _view.LoadDeserialize +=_model.deserialize;
            _view.GetEmployeeFromListBox += _getEmployeeFromList;
           
        }
        private void _changeName(string name)
        {
            currentEmployee.Name = name;
        }
        private void _changeSurname(string surname)
        {
            currentEmployee.Surname = surname;
        }
        private void _changeBirthDate(DateTime date)
        {
            currentEmployee.Birthdate = date;
        }
        private void _changeSalary(decimal salary)
        {
            currentEmployee.Salary = salary;
        }
        private void _changePosition(string positionType)
        {
            if (positionType == "Junior Developer") { currentEmployee.Position = Position.JuniorDeveloper; }
            if (positionType == "Mid Developer") { currentEmployee.Position = Position.MidDeveloper; }
            if (positionType == "Senior Developer") { currentEmployee.Position = Position.SeniorDeveloper; }
            if (positionType == "Project Manager") { currentEmployee.Position = Position.ProjectManager; }
            if (positionType == "Tester") { currentEmployee.Position = Position.Tester; }
        }
        private void _changeContractType(string contractType)
        {
            if (contractType == "Permanent") { currentEmployee.Contract = ContractType.Permanent; }
            if (contractType == "Fixed-Term") { currentEmployee.Contract = ContractType.FixedTerm; }
            if (contractType == "Mandate") { currentEmployee.Contract = ContractType.Mandate; }
        }
        private void _updateListBox() {
            _view.EmployeeBoxContents.Clear();
            foreach (Employee e in _model.getList()) {
                _view.EmployeeBoxContents.Add(e);
                Console.WriteLine(e.ToString());
            }
            
        }
        private void _addEmployee()
        {
            if (currentEmployee.Name != "" && currentEmployee.Surname != "") { 
            _model.addToList(currentEmployee);
            currentEmployee = new Employee("", "", DateTime.Today, 1000, ContractType.Permanent, Position.JuniorDeveloper);
        }
        }
        private void _getEmployeeFromList(int index) {
            Employee emp = _model.getList()[index];
            Console.WriteLine(emp.Contract.ToString());
// currentEmployee = emp;
            _view.nameString = emp.Name;
            _view.surnameString = emp.Surname;
            _view.dateBoxDate = emp.Birthdate;
            _view.salaryDecimal = emp.Salary;
            _view.positionString = emp.Position.ToString();
            _view.contractString = emp.Contract.ToString();
        }
    }
}

