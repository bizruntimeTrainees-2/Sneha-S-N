using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Newtonsoft.Json;

namespace JsonParser
{
    class Program1
    {
        Student student = new Student()
        {
            Id = 1,
            Name = "Sneha",
            Degree = "Bca",
            Hobbies = new List<string>()
            {
                "Reading",
                "Playing Games"
            }
        };

        string strResultJson = JsonConvert.SerializeObject(student);
        Console.WriteLine(strResultJson);   

        File.WriteAllText(@"student.json",strResultJson);
        Console.WriteLine("Stored!");

        strResultJson = String.Empty;
        strResultJson = File.ReadAllText(@"student.json");
     //   Student resultStudent = JsonConvert.DeserializeObject<student>(strResultJson);
     //   Console.WriteLine(resultStudent.ToString());

        var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);
        foreach (DictionaryEntry entry in dictionary)
        {
            Console.WriteLine(entry.Key + ": " +entry.Value);
        }
    }
}