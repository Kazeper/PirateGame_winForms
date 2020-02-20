namespace RandomFieldGenerator
{
	partial class StartForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelPlayerNO = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxSelectedField = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonNextRandomField = new System.Windows.Forms.Button();
			this.textBoxNumberOfPlayers = new System.Windows.Forms.TextBox();
			this.labelNumberOfPlayers = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.buttonChooseNext = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			AddButtons();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGenerate.Location = new System.Drawing.Point(261, 376);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(75, 42);
			this.buttonGenerate.TabIndex = 5;
			this.buttonGenerate.Text = "Start";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelPlayerNO);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBoxSelectedField);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.buttonNextRandomField);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(345, 281);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// labelPlayerNO
			// 
			this.labelPlayerNO.AutoSize = true;
			this.labelPlayerNO.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPlayerNO.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelPlayerNO.Location = new System.Drawing.Point(224, 74);
			this.labelPlayerNO.Name = "labelPlayerNO";
			this.labelPlayerNO.Size = new System.Drawing.Size(29, 25);
			this.labelPlayerNO.TabIndex = 9;
			this.labelPlayerNO.Text = "#";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(26, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(195, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Player\'s turn NO:";
			// 
			// textBoxSelectedField
			// 
			this.textBoxSelectedField.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSelectedField.Location = new System.Drawing.Point(224, 34);
			this.textBoxSelectedField.Name = "textBoxSelectedField";
			this.textBoxSelectedField.Size = new System.Drawing.Size(100, 33);
			this.textBoxSelectedField.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(51, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Choosen Field:";
			// 
			// buttonNextRandomField
			// 
			this.buttonNextRandomField.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNextRandomField.Location = new System.Drawing.Point(18, 148);
			this.buttonNextRandomField.Name = "buttonNextRandomField";
			this.buttonNextRandomField.Size = new System.Drawing.Size(302, 110);
			this.buttonNextRandomField.TabIndex = 6;
			this.buttonNextRandomField.Text = "Draw next field";
			this.buttonNextRandomField.UseVisualStyleBackColor = true;
			this.buttonNextRandomField.Click += new System.EventHandler(this.buttonNextRandomField_Click);
			// 
			// textBoxNumberOfPlayers
			// 
			this.textBoxNumberOfPlayers.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNumberOfPlayers.Location = new System.Drawing.Point(241, 340);
			this.textBoxNumberOfPlayers.Name = "textBoxNumberOfPlayers";
			this.textBoxNumberOfPlayers.Size = new System.Drawing.Size(100, 33);
			this.textBoxNumberOfPlayers.TabIndex = 4;
			// 
			// labelNumberOfPlayers
			// 
			this.labelNumberOfPlayers.AutoSize = true;
			this.labelNumberOfPlayers.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumberOfPlayers.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelNumberOfPlayers.Location = new System.Drawing.Point(25, 343);
			this.labelNumberOfPlayers.Name = "labelNumberOfPlayers";
			this.labelNumberOfPlayers.Size = new System.Drawing.Size(217, 25);
			this.labelNumberOfPlayers.TabIndex = 6;
			this.labelNumberOfPlayers.Text = "Number of players:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label21.Location = new System.Drawing.Point(365, 265);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(28, 25);
			this.label21.TabIndex = 61;
			this.label21.Text = "G";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label23.Location = new System.Drawing.Point(365, 230);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(24, 25);
			this.label23.TabIndex = 60;
			this.label23.Text = "F";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label24.Location = new System.Drawing.Point(365, 195);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(25, 25);
			this.label24.TabIndex = 59;
			this.label24.Text = "E";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label25.Location = new System.Drawing.Point(365, 160);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(28, 25);
			this.label25.TabIndex = 58;
			this.label25.Text = "D";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label26.Location = new System.Drawing.Point(365, 125);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(27, 25);
			this.label26.TabIndex = 57;
			this.label26.Text = "C";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label27.Location = new System.Drawing.Point(365, 90);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(26, 25);
			this.label27.TabIndex = 10;
			this.label27.Text = "B";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label28.Location = new System.Drawing.Point(365, 55);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(26, 25);
			this.label28.TabIndex = 56;
			this.label28.Text = "A";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label29.Location = new System.Drawing.Point(613, 20);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(25, 25);
			this.label29.TabIndex = 55;
			this.label29.Text = "7";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label30.Location = new System.Drawing.Point(578, 20);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(25, 25);
			this.label30.TabIndex = 54;
			this.label30.Text = "6";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label31.Location = new System.Drawing.Point(543, 20);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(25, 25);
			this.label31.TabIndex = 53;
			this.label31.Text = "5";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label32.Location = new System.Drawing.Point(508, 20);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(25, 25);
			this.label32.TabIndex = 52;
			this.label32.Text = "4";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label33.Location = new System.Drawing.Point(473, 20);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(25, 25);
			this.label33.TabIndex = 51;
			this.label33.Text = "3";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label34.Location = new System.Drawing.Point(438, 20);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(25, 25);
			this.label34.TabIndex = 50;
			this.label34.Text = "2";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label35.Location = new System.Drawing.Point(403, 20);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(25, 25);
			this.label35.TabIndex = 49;
			this.label35.Text = "1";
			// 
			// buttonChooseNext
			// 
			this.buttonChooseNext.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonChooseNext.Location = new System.Drawing.Point(399, 310);
			this.buttonChooseNext.Name = "buttonChooseNext";
			this.buttonChooseNext.Size = new System.Drawing.Size(119, 90);
			this.buttonChooseNext.TabIndex = 62;
			this.buttonChooseNext.Text = "Choose as next";
			this.buttonChooseNext.UseVisualStyleBackColor = true;
			this.buttonChooseNext.Visible = false;
			this.buttonChooseNext.Click += new System.EventHandler(this.buttonChooseNext_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(517, 310);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(124, 90);
			this.buttonDelete.TabIndex = 63;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(921, 501);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonChooseNext);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.textBoxNumberOfPlayers);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.labelNumberOfPlayers);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.label35);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label34);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.label33);
			this.Name = "StartForm";
			this.Text = "PirateBay";
			this.Load += new System.EventHandler(this.StartForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonNextRandomField;
		private System.Windows.Forms.TextBox textBoxSelectedField;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNumberOfPlayers;
		private System.Windows.Forms.Label labelNumberOfPlayers;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelPlayerNO;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Button buttonChooseNext;
		private System.Windows.Forms.Button buttonDelete;
	}
}

