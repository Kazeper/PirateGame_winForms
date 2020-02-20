using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomFieldGenerator
{
	public partial class StartForm : Form
	{
		public List<Button> buttons;
		private int counter;
		public const int NumberOfRows = 7;
		public const int NumberOfColumns = 7;

		public Random random = new Random();
		public Game game;

		public int numberOfPlayers;
		public int clickedButtonIndex;

		public StartForm()
		{
			buttons = new List<Button>();
			InitializeComponent();

			counter = -1;
		}

		private void buttonGenerate_Click(object sender, EventArgs e)
		{
			game = new Game(NumberOfRows, NumberOfColumns, this);
			numberOfPlayers = Int32.Parse(textBoxNumberOfPlayers.Text);

			textBoxNumberOfPlayers.Visible = false;
			buttonGenerate.Visible = false;
			labelNumberOfPlayers.Visible = false;
		}

		private void AddButtons()
		{
			int buttonCounter = 0;

			Point startingPoint = new Point(40, 55);
			for (int i = 0; i < NumberOfRows; i++)
			{
				for (int j = 0; j < NumberOfColumns; j++)
				{
					Button button = new System.Windows.Forms.Button();

					button.BackColor = System.Drawing.SystemColors.ButtonFace;
					button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
					button.FlatAppearance.BorderSize = 3;
					button.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					button.Location = new System.Drawing.Point((j * 35) + 400, (i * 35) + 55);
					button.Name = "button" + buttonCounter.ToString();
					button.Size = new System.Drawing.Size(30, 30);
					button.TabIndex = buttonCounter;
					button.Click += new System.EventHandler(this.ButtonOnBoard_Click);

					buttons.Add(button);
					this.Controls.Add(button);
					buttonCounter++;
				}
			}
		}

		private void StartForm_Load(object sender, EventArgs e)
		{
		}

		private void ButtonOnBoard_Click(object sender, EventArgs e)
		{
			buttonChooseNext.Visible = true;
			buttonDelete.Visible = true;

			foreach (Button button in buttons)
			{
				if (sender.Equals(button))
				{
					clickedButtonIndex = button.TabIndex;
				}
			}
		}

		private void buttonNextRandomField_Click(object sender, EventArgs e)
		{
			textBoxSelectedField.Text = game.DisplayField();
			counter++;
			labelPlayerNO.Text = ((counter % numberOfPlayers) + 1).ToString();
		}

		private void buttonChooseNext_Click(object sender, EventArgs e)
		{
			buttonChooseNext.Visible = false;
			buttonDelete.Visible = false;

			game.fields.Remove(clickedButtonIndex);
			buttons[clickedButtonIndex].BackgroundImage = global::RandomFieldGenerator.Properties.Resources.dot;
			buttons[clickedButtonIndex].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			buttons[clickedButtonIndex].Enabled = false;

			clickedButtonIndex = -1;
			counter++;
			labelPlayerNO.Text = ((counter % numberOfPlayers) + 1).ToString();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			buttonChooseNext.Visible = false;
			buttonDelete.Visible = false;

			game.fields.Remove(clickedButtonIndex);
			buttons[clickedButtonIndex].BackColor = Color.DarkRed;
			buttons[clickedButtonIndex].Enabled = false;

			clickedButtonIndex = -1;
		}
	}
}