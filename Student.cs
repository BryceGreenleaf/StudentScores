using System;

namespace StudentScores
{
	public class Student : ICloneable
	{
		public Student() { }

		public Student(string studentAndScores)
		{
			string[] colums = studentAndScores.Split(Sep);

			if (colums.Length >= 2 )
			{
				//Set name
				Name = colums[0];
				
				//set scorelist
				for(int i =1; i < colums.Length; i++)
				{
					if (colums[i] != "")
						studentAndScores
				}

			}
		}
		private const char Sep = '|';
		public List<int> Scores { get; set; } = new List<int>();
		public string Name { get; set; }
	}

}