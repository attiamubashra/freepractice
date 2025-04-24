using methods4;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Linq;

namespace methods4
{  
    
    }
    public class Dictionary
    {
    
        public static void Main()
    {
        ArrayList al = new ArrayList();
        al.Add(1);

        Dictionary<int, string> student = new Dictionary<int, string>();
        student.Add(01, "Ali");
        student.Add(02, "Saim");
        student.Add(03, "zubair");
        student.Add(04, "Sohail");
        student.Add(05, "ghani");

        //Access to data.
        string name = student[01];
        Console.WriteLine(name);
        //updating data
        student[03]= "Sammaaaarrr";
        //removing data.
        student.Remove(02);
        
        // display of list
       
        //addition in list.
        if (!student.ContainsKey(02))
        { 
           student.Add(02, "vijay");
        }
        //another way of adding 
        int counter = 01;
        while (student.ContainsKey(counter)) 
        {

            counter++;
        
        }
        student.Add(counter, "xaveeeeer");


        Console.WriteLine("Total students.");
        Console.WriteLine(student.Count);
        foreach (KeyValuePair<int, string> studentList in student)
        {
            Console.WriteLine($"sTUDENT iD : {studentList.Key}...Name :{studentList.Value}");

        }
        Console.ReadLine();
    }
}

