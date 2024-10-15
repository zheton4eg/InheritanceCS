using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
		internal static void Save(Human[] group, string filename)
		{

			StreamWriter groupsave = new StreamWriter(filename);

			for (int i = 0; i < group.Length; i++)
			{
				groupsave.WriteLine(group[i].ToFileString());

			}
			groupsave.Close();
			Process.Start("notepad", filename);
		}
	}
}
