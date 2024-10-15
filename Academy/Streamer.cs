﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Streamer
	{
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);

			}
		}
		internal static string SetDirectory()
		{
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(location);
            Console.WriteLine(location);
            Console.WriteLine(path);
            Directory.SetCurrentDirectory($"{path}\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
			return Directory.GetCurrentDirectory();
        }
		internal static void Save(Human[] group, string filename)
		{
            SetDirectory();

            StreamWriter groupsave = new StreamWriter(filename);

			for (int i = 0; i < group.Length; i++)
			{
				groupsave.WriteLine(group[i].ToFileString());

			}
			groupsave.Close();
			Process.Start("notepad", filename);

		}
		internal static Human[] Load(string filename)
		{
			SetDirectory();
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			try
			{
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					string[] values = buffer.Split(',');
					values=values.Where(i=>i!="").ToArray();
					if (values.Length == 1) continue;
					Console.WriteLine(buffer);
					/*Human human = HumanFactory.Create(values[0]);
					human.Init(values);
					group.Add(human);*/
					group.Add(HumanFactory.Create(values[0]).Init(values));
				}
				sr.Close();
			}
			catch (Exception ex)
			{ 
				Console.WriteLine(ex.Message);
			}
			return group.ToArray();
        } 
	}
}
