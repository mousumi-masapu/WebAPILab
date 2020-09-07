using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace JsonAPISerialization
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\MVC Cloud\json\student.json";

            if (File.Exists(path))
            {
                using (StreamReader fileReader = new StreamReader(path))
                {
                    string jsonFileReader = fileReader.ReadToEnd();
                    //Converts between .net types and Json types
                    //Deserializes a JSON to .NET object and returns deserialized object from the json string.
                    Student studentObj =JsonConvert.DeserializeObject<Student>(jsonFileReader);
                    Console.WriteLine(studentObj.Name);
                    Console.WriteLine(studentObj.RollNo);
                    Console.WriteLine(studentObj.Grade);
                    //Using JArray and JObject to parse the JSON File.
                    JObject obj = JObject.Parse(jsonFileReader);
                    var jsonArray = JArray.Parse(obj["Subjects"].ToString());
                    foreach (var jToken in jsonArray)
                    {
                        Console.WriteLine(jToken.ToString());
                    }

                    //foreach (object value in studentObj.Subjects)
                    //{
                    //    Console.WriteLine("Subjects:" +value);

                    //}
                    Console.Read();
                }

            }
            else
            {
                Console.WriteLine("File Not Found");
                Console.Read();
            }

            //Employee emp = new Employee();
            //string JSONresult = JsonConvert.SerializeObject(emp);
            //string path = @"D:\MVC Cloud\json\employee.json";




            //    Student student = new Student()
            //    {
            //        RollNo=1,
            //        Name="Aryan",
            //        Grade="Grade One",
            //        Subjects=new List<string>()
            //        {
            //            "English",
            //            "Math",
            //            "Swedish"
            //        }



            //    };
            //    string JSONresult = JsonConvert.SerializeObject(student);
            //    string path = @"D:\MVC Cloud\json\student.json";

            //    if (File.Exists(path)) {
            //        File.Delete(path);
            //        using (var tw = new StreamWriter(path, true))
            //        {
            //            tw.WriteLine(JSONresult.ToString());
            //            tw.Close();

            //        }
            //    }

            //    else if (!File.Exists(path)) { 

            //        using (var tw = new StreamWriter(path, true)) { 

            //            tw.WriteLine(JSONresult.ToString());
            //            tw.Close();
            //        }
            //    }

        }


    }

}



