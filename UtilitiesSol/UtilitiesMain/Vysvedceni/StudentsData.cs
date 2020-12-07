namespace UtilitiesMain.Vysvedceni
{
	public class StudentsData
	{ 
		public string StudentName;
		public string SubjectName;
		public int StudentsMark;
	
		public StudentsData(string studentName, string subjectName, int studentsMark)
		{
			this.StudentName = studentName;
			this.SubjectName = subjectName;
			this.StudentsMark = studentsMark;
		}
	}
}
