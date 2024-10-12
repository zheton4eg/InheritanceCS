using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate:Student
	{ 
		string ThesisTopic {  get; set; }
		public Graduate(
			string LastName, string FirstName, int age,
			string speciality, string group, double rating, double attendance,
			string thesisTopic):base(LastName, FirstName, age, speciality, group, rating, attendance)
		{
			ThesisTopic = thesisTopic;
			Console.WriteLine($"GraduateConstructor:{GetHashCode()}");
		}
		~Graduate()
		{
			Console.WriteLine($"GraduateDestructor:{GetHashCode()}");
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($" {ThesisTopic}");
		}
		public override string ToString()
		{
			return base.ToString()+$" {ThesisTopic}";
		}
		
	}
}
