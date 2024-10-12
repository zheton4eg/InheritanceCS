using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy

{
	internal class Human
	{
		public string LastName {  get; set; }
        public string FirstName { get; set; }
		public int Age {  get; set; }
		//Constructor:

		public Human(string LastName,String FirstName, int age) 
		{
			this.LastName = LastName;
			this.FirstName = FirstName;
			this.Age = age;
			Console.WriteLine($"HumanConstructor:{GetHashCode()}");
		}
		~Human() 
		{
			Console.WriteLine($"HumanDestructor:{GetHashCode()}");
		}
		public virtual void Print()
		{
			Console.WriteLine($"{LastName} {FirstName} {Age}");

		}
		public override string ToString()
		{
			return base.ToString()+$":\t{LastName} {FirstName} {Age}";
		}
	}
}
