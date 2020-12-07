using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace UtilitiesMain.Vysvedceni
{
	public class StudentsReportCard
	{
		public List<StudentsData> dataList = new List<StudentsData>();

		public void CreateReport(string path)
		{
			LoadCSV(path);
			ExtractStudentData();
		}

		public void LoadCSV(string path)
		{
			using (StreamReader sr = new StreamReader(path))
			{
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					if (line != null)
					{
						string[] text = line.Split(',');
						StudentsData data = new StudentsData(text[0], text[1], Convert.ToInt32(text[3]));
						dataList.Add(data);
					}
				}
			}

		}

		public void ExtractStudentData()
		{
			List<string> studentNames = new List<string>();
			List<string> subjectNames = new List<string>();
			foreach (var item in dataList)
			{
				if (!studentNames.Contains(item.StudentName))
					studentNames.Add(item.StudentName);

				if (!subjectNames.Contains(item.SubjectName))
					subjectNames.Add(item.SubjectName);

			}

			foreach (var studentName in studentNames)
			{
				List<int> endMarks = new List<int>();
				Console.WriteLine("***** " + studentName + " *****");
				foreach (var subjectName in subjectNames)
				{
					Console.Write(subjectName + " - ");
					List<int> marks = new List<int>();
					foreach (var data in dataList)
					{
						if (data.StudentName == studentName && data.SubjectName == subjectName)
							marks.Add(data.StudentsMark);

					}
					Console.Write(ConvertMarkToWord((int)(Math.Round(StudentEndMark(marks), 0))));
					endMarks.Add((int)Math.Round(StudentEndMark(marks), 0));
					Console.WriteLine();
				}
				Console.WriteLine("All Subjects average: " + Math.Round(StudentEndMark(endMarks), 2));
				Console.WriteLine(Prospel(endMarks));
			}

		}

		public string Prospel(List<int> marks)
		{
			if (marks.Average() < 1.5 && !marks.Contains(3) && !marks.Contains(4))
				return "Passed with graduation";
			else if (marks.Contains(5))
				return "Failed";
			else
				return "Passed";

		}

		public string ConvertMarkToWord(int mark)
		{
			switch (mark)
			{
				case 1:
					return "Excellent (A)";
				case 2:
					return "Good(B)";
				case 3:
					return "Normal(C)";
				case 4:
					return "Enough(D)";
				case 5:
					return "Fail(F)";
			}

			return "Student dosent have any marks!";
		}

		public double StudentEndMark(List<int> marks)
		{
			double endMark = 0;
			foreach (var mark in marks)
			{
				endMark += mark;
			}

			return endMark / marks.Count;
		}

	}
}
