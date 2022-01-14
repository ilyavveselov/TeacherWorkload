namespace ProgramWithBD.Change
{
    partial class WorkloadChange
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
            this.bChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.tbHPractice = new System.Windows.Forms.TextBox();
            this.tbHLectures = new System.Windows.Forms.TextBox();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(12, 209);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(75, 23);
            this.bChange.TabIndex = 25;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Год";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Часов практик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Часов лекций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Предмет";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(12, 183);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 19;
            // 
            // cbGroups
            // 
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(12, 143);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(175, 21);
            this.cbGroups.TabIndex = 18;
            // 
            // tbHPractice
            // 
            this.tbHPractice.Location = new System.Drawing.Point(12, 104);
            this.tbHPractice.Name = "tbHPractice";
            this.tbHPractice.Size = new System.Drawing.Size(100, 20);
            this.tbHPractice.TabIndex = 17;
            // 
            // tbHLectures
            // 
            this.tbHLectures.Location = new System.Drawing.Point(12, 65);
            this.tbHLectures.Name = "tbHLectures";
            this.tbHLectures.Size = new System.Drawing.Size(100, 20);
            this.tbHLectures.TabIndex = 16;
            // 
            // cbSubjects
            // 
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(12, 25);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(175, 21);
            this.cbSubjects.TabIndex = 15;
            // 
            // WorkloadChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 244);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.cbGroups);
            this.Controls.Add(this.tbHPractice);
            this.Controls.Add(this.tbHLectures);
            this.Controls.Add(this.cbSubjects);
            this.Name = "WorkloadChange";
            this.Text = "Изменение нагрузки";
            this.Load += new System.EventHandler(this.WorkloadChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.TextBox tbHPractice;
        private System.Windows.Forms.TextBox tbHLectures;
        private System.Windows.Forms.ComboBox cbSubjects;
    }
}