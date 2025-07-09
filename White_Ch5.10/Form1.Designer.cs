namespace White_Ch5._10
{
    partial class Addition_Tutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.User_Answers = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Rand_NumsLbl = new System.Windows.Forms.Label();
            this.CheckAnsBtn = new System.Windows.Forms.Button();
            this.ProblemLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addition Tutor";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(25, 220);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(63, 37);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate Problem";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // User_Answers
            // 
            this.User_Answers.Location = new System.Drawing.Point(413, 107);
            this.User_Answers.Margin = new System.Windows.Forms.Padding(2);
            this.User_Answers.Name = "User_Answers";
            this.User_Answers.Size = new System.Drawing.Size(102, 20);
            this.User_Answers.TabIndex = 2;
            this.User_Answers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_Answers_KeyPress);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(251, 287);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(63, 37);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "What is the sum of these numbers?";
            // 
            // Rand_NumsLbl
            // 
            this.Rand_NumsLbl.AutoSize = true;
            this.Rand_NumsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rand_NumsLbl.Location = new System.Drawing.Point(187, 107);
            this.Rand_NumsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rand_NumsLbl.Name = "Rand_NumsLbl";
            this.Rand_NumsLbl.Size = new System.Drawing.Size(0, 17);
            this.Rand_NumsLbl.TabIndex = 5;
            // 
            // CheckAnsBtn
            // 
            this.CheckAnsBtn.Location = new System.Drawing.Point(452, 220);
            this.CheckAnsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CheckAnsBtn.Name = "CheckAnsBtn";
            this.CheckAnsBtn.Size = new System.Drawing.Size(63, 37);
            this.CheckAnsBtn.TabIndex = 6;
            this.CheckAnsBtn.Text = "Check Answer";
            this.CheckAnsBtn.UseVisualStyleBackColor = true;
            this.CheckAnsBtn.Click += new System.EventHandler(this.CheckAnsBtn_Click);
            // 
            // ProblemLbl
            // 
            this.ProblemLbl.AutoSize = true;
            this.ProblemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemLbl.Location = new System.Drawing.Point(263, 107);
            this.ProblemLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProblemLbl.Name = "ProblemLbl";
            this.ProblemLbl.Size = new System.Drawing.Size(16, 17);
            this.ProblemLbl.TabIndex = 7;
            this.ProblemLbl.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click to Generate Problem";
            // 
            // Addition_Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProblemLbl);
            this.Controls.Add(this.CheckAnsBtn);
            this.Controls.Add(this.Rand_NumsLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.User_Answers);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Addition_Tutor";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox User_Answers;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Rand_NumsLbl;
        private System.Windows.Forms.Button CheckAnsBtn;
        private System.Windows.Forms.Label ProblemLbl;
        private System.Windows.Forms.Label label3;
    }
}

