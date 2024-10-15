﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	 class Student:Human
	{
		static readonly int SPECIALITY_WIDTH = 24;
		static readonly int GROUP_WIDTH = 8;
		static readonly int RATING_WIDTH = 8;
		static readonly int ATTENDANCE_WIDTH = 8;
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }
		public Student
			(string LastName, string FirstName, int age,
			string speciality, string group, double rating, double attendance)
			: base(LastName, FirstName, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"StudentConstructor:{GetHashCode()}");
		}
		~Student()
		{
			Console.WriteLine($"StudentDestructor:{GetHashCode()}");
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");	
		}
		public override string ToString()
		{
			return base.ToString()+$" {Speciality.PadRight(SPECIALITY_WIDTH)} {Group.PadRight(GROUP_WIDTH)} {Rating.ToString().PadRight(RATING_WIDTH)} {Attendance.ToString().PadRight(ATTENDANCE_WIDTH)}";
		}
		public override string ToFileString()
		{
			return base.ToFileString()+$"{Speciality},{Group},{Rating}";
		}
	}
} 
