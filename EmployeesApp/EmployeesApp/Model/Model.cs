using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeesApp.Model
{
    internal class Model
    {
        private List<Employee> employees;
        //Employee list,serialization and deserialization
        
        
        public Model() {
            employees = new List<Employee>();
        }
        public List<Employee> getList() { return employees; }
        public void addToList(Employee employee)
        {
            employees.Add(employee);
        }
        public void serialize()
        {
            string filename = "backup.xml";
            Employee[] list = employees.ToArray();
            if (!(System.IO.File.Exists(filename)))
            {
                System.IO.File.Create(filename);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Employee[]));
            Console.WriteLine(Directory.GetCurrentDirectory());
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, list);
            writer.Close();
            TextReader reader = new StreamReader(filename);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        
        }
        public void deserialize() {
            string filename = "backup.xml";
            Employee[] list;
            if (System.IO.File.Exists(filename))
            {

                XmlSerializer deserializer = new XmlSerializer(typeof(Employee[]));
                TextReader reader = new StreamReader(filename);
                list = (deserializer.Deserialize(reader)) as Employee[];
                employees = list.ToList<Employee>();
            }
            else { Console.WriteLine("No backup file found"); }

        }
    }
}
