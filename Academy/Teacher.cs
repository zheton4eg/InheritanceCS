using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Teacher:Human
	{
		static readonly int SPECIALITY_WIDTH = 24;
		static readonly int EXPERIANCE_WIDTH = 5;
		public string Speciality {  get; set; }
		public int Experience { get; set; }
		public Teacher(string LastName, string FirstName, int age,
			string speciality, int experiance)
			: base(LastName, FirstName, age)
		{
			Speciality = speciality;
			Experience = experiance;
			Console.WriteLine($"TeachConstructor:{GetHashCode()}");
		}
		~Teacher() 
		{ 
			Console.WriteLine($"TeachDestructor:{GetHashCode()}"); 
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality} {Experience}");
		}
		public override string ToString()
		{
			return base.ToString()+$" {Speciality.PadRight(SPECIALITY_WIDTH)} {Experience.ToString().PadRight(EXPERIANCE_WIDTH)}";	
		}
	}
}
