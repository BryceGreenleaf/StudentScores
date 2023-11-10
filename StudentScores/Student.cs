using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentScores
{
	public class Student : ICloneable
	{
		public Student() { }

		public Student(string studentAndScores)
		{
			string[] colums = studentAndScores.Split(Sep);

			if (colums.Length >= 2)
			{
				//Set name
				Name = colums[0];

				//set scorelist
				for (int i = 1; i < colums.Length; i++)
				{
					if (colums[i] != "")
						Scores.Add(Convert.ToInt32(colums[i]));
				}

			}
		}
		private const char Sep = '|';
		public List<int> Scores { get; set; } = new List<int>();
		public string Name { get; set; }

		public int ScoreCount => Scores.Count;

		public int ScoreTotal
		{
			get
			{
				int total = 0;
				foreach (int i in Scores)
					total += i;
				return total;
			}
		}

		public int ScoreAverage
		{

			get
			{
				if (ScoreTotal > 0)
					return ScoreTotal / ScoreCount;
				else
					return 0;
			}
		}

		public override string ToString()
		{
			string scoresString = "";
			foreach (int i in Scores)
				scoresString += $"{Sep}{i}";
			return $"{Name}{scoresString}";
		}


		public object Clone()
		{
			Student s = new Student();
			{
				Name = this.Name;
			}

			foreach (int i in Scores)
				s.Scores.Add(i);
			return s;

		}


	}
}