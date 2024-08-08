using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Model
{
    public enum ContractType{Permanent,FixedTerm,Mandate};
    public enum Position{JuniorDeveloper,MidDeveloper,SeniorDeveloper,ProjectManager,Tester};
    public class Employee
    {
        private string _name;
        private string _surname;
        private DateTime _date;
        private decimal _salary;
        private ContractType _contract;
        private Position _position;

        public Employee(string name, string surname, DateTime date, decimal salary, ContractType contract, Position position)
        {
            _name = name;
            _surname = surname;
            _date = date;
            _salary = salary;
            _contract = contract;
            _position = position;
        }
        public Employee() { }
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
        public string Surname {
            get { return _surname;}
            set { _surname = value; }
        }
        public DateTime Birthdate
        {
            get { return _date; }
            set
            {
                _date = value;
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
            }
        }
        public ContractType Contract
        {
            get { return _contract; }
            set
            {
                _contract = value;
            }
        }
        public Position Position {
            get { return _position; }
            set
            {
                _position = value;
            }
                
                }
        public override string ToString()
        {
            string positionStr = "";
            string contractStr = "";
            if (this._position == Position.Tester) { positionStr = "Tester"; }
            if (this._position == Position.ProjectManager) { positionStr = "Project Manager"; }
            if (this._position == Position.JuniorDeveloper) { positionStr = "Junior Developer"; }
            if (this._position == Position.MidDeveloper) { positionStr = "Mid Developer"; }
            if (this._position == Position.SeniorDeveloper) { positionStr = "Senior Developer"; }
            if (this._contract == ContractType.Permanent) { contractStr = "Na czas nieokreślony"; }
            if (this._contract == ContractType.FixedTerm) { contractStr = "Na czas określony"; }
            if (this._contract == ContractType.Mandate) { contractStr = "Umowa zlecanie"; }
            return _name + " " + _surname + " Data urodzenia: " + _date.ToShortDateString() + " Pensja: " + _salary.ToString() + " Posada: " + positionStr + " Typ umowy: " + contractStr;

        }
    }
}
