﻿//#define SAVE_CHECK
#define LOAD_CHECK

//#define INHERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Academy
{
	class Program
	{
		static void Main(string[] args)
		{


#if INHERITANCE_CHECK
			Human human = new Human("Montana", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);
			Student student = new Student("Pinkman","Jessie",22,"Chemistry", "WW_220", 95, 96);
			student.Print();
			Console.WriteLine(student);
			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry",25);
			teacher.Print();
			Console.WriteLine(teacher);
			Graduate graduate = new Graduate("Evgene", "Krylov", 32, "C#", "PW319", 100, 100,"DrugDillerOnline");
			graduate.Print();
			Console.WriteLine(graduate);
#endif
#if SAVE_CHECK
            Human[] group = new Human[]
				{
				new Human ("Montana", "Antonio", 25),
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
				new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 97, 98),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Evgene", "Krylov", 32, "C#", "PW319", 100, 100, "DrugDillerOnline"),
				new Graduate("Schreder", "Hank", 40, "Criminalistic", "Dea", 70, 40, "How to catch Heisenberg"),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),

				};


			Streamer.Print(group);
			Streamer.Save(group, "group.csv"); 
#endif

#if LOAD_CHECK

			Human[] group = Streamer.Load("group.csv");
			Streamer.Print(group);
#endif
        }

    }
}
