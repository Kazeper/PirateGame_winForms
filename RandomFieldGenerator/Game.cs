using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFieldGenerator
{
	public class Game
	{
		private int numberOfRows;
		private int numberOfColumns;
		public List<int> fields;
		public Random random = new Random();

		public StartForm form;

		public Game(int numberOfRows, int numberOfColumns, StartForm form)
		{
			this.numberOfRows = numberOfRows;
			this.numberOfColumns = numberOfColumns;
			FillFieldsList(this.numberOfRows, this.numberOfColumns);

			this.form = form;
		}

		public string DisplayField()
		{
			string result = "END";
			if (fields.Count > 0)
			{
				int field = GetNextField();
				int x = (int)Math.Floor(((double)field / numberOfColumns));
				int y = field % numberOfColumns;
				char letter = (char)(x + 65);
				result = letter + (y + 1).ToString();
			}

			return result;
		}

		public void FillFieldsList(int x, int y)
		{
			int length = x * y;
			fields = new List<int>();

			for (int i = 0; i < length; i++)
			{
				fields.Add(i);
			}
		}

		public int GetNextField()
		{
			int indexOfField = random.Next(0, fields.Count);
			int field = fields[indexOfField];

			fields.RemoveAt(indexOfField);
			form.buttons[field].BackgroundImage = global::RandomFieldGenerator.Properties.Resources.dot;
			form.buttons[field].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			form.buttons[field].Enabled = false;

			return field;
		}

		public int GetNextField(string field)
		{
			int result;
			char letter = field[0];
			string numberFromString = field[1].ToString();
			int letterToNumber = (int)letter - 65;
			int number = Convert.ToInt32(numberFromString);
			result = (letterToNumber * numberOfColumns) + number - 1;
			fields.Remove(result);

			return result;
		}
	}
}