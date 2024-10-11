using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Student:Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public string Rating { get; set; }
		public double Attendance { get; set; }
		public Student(string LastName, string FirstName, int age,
			string speciality, string group, string rating, double attendance) : base(LastName, FirstName, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"StudentConstructor:{GetHashCode()}");
		}
	}
}
