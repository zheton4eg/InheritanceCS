using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy

{
	internal class Human
	{
		static readonly int TIPE_NAME_WIDTH = 10;
		static readonly int LAST_NAME_WIDTH = 12;
		static readonly int FIRST_NAME_WIDTH = 12;
		static readonly int AGE_NAME_WIDTH = 5;
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
			return base.ToString().Split('.').Last().PadRight(TIPE_NAME_WIDTH) +$":\t{LastName.PadRight(LAST_NAME_WIDTH)}" +
				$" {FirstName.PadRight(FIRST_NAME_WIDTH)} {Age.ToString().PadRight(AGE_NAME_WIDTH)}";
		}
		public virtual string ToFileString()
		{
return this.GetType().ToString().Split('.').Last()+$",{LastName},{FirstName},{Age}";
		}
		public virtual Human Init(string[]values)
		{
			LastName = values[1];
			FirstName = values[2];
			Age=Convert.ToInt32(values[3]);
			return this;
		}
	}
}
