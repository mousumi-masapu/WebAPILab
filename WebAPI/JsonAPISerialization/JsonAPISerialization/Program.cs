using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAPISerialization
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee emp = new Employee();
            //string JSONresult = JsonConvert.SerializeObject(emp);
            //string path = @"D:\MVC Cloud\json\employee.json";

            Student student = new Student()
            {
                RollNo=1,
                Name="Aryan",
                Grade="Grade One",
                Subjects=new List<string>()
                {
                    "English",
                    "Math",
                    "Swedish"
                }

            };
            string JSONresult = JsonConvert.SerializeObject(student);
            string path = @"D:\MVC Cloud\json\student.json";

            if (File.Exists(path)) {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();

                }
            }

            else if (!File.Exists(path)) { 

                using (var tw = new StreamWriter(path, true)) { 

                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }

        }
        
            
    }
}
