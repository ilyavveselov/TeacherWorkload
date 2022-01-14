namespace ProgramWithBD.Add
{
    partial class TeacherWorkloadsAdd
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
            this.components = new System.ComponentModel.Container();
            this.cbTeacherLastname = new System.Windows.Forms.ComboBox();
            this.bsTeacherLastname = new System.Windows.Forms.BindingSource(this.components);
            this.bsTeacherId = new System.Windows.Forms.BindingSource(this.components);
            this.cbWorkloadId = new System.Windows.Forms.ComboBox();
            this.bsWorkloadId = new System.Windows.Forms.BindingSource(this.components);
            this.bsTeacherName = new System.Windows.Forms.BindingSource(this.components);
            this.bsTeacherMiddlename = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkloadId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherMiddlename)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTeacherLastname
            // 
            this.cbTeacherLastname.DisplayMember = "Lastname";
            this.cbTeacherLastname.FormattingEnabled = true;
            this.cbTeacherLastname.Location = new System.Drawing.Point(12, 59);
            this.cbTeacherLastname.Name = "cbTeacherLastname";
            this.cbTeacherLastname.Size = new System.Drawing.Size(343, 21);
            this.cbTeacherLastname.TabIndex = 0;
            this.cbTeacherLastname.ValueMember = "Lastname";
            // 
            // bsTeacherLastname
            // 
            this.bsTeacherLastname.DataSource = typeof(ProgramWithBD.Teachers);
            // 
            // bsTeacherId
            // 
            this.bsTeacherId.DataSource = typeof(ProgramWithBD.Teachers);
            // 
            // cbWorkloadId
            // 
            this.cbWorkloadId.FormattingEnabled = true;
            this.cbWorkloadId.Location = new System.Drawing.Point(12, 113);
            this.cbWorkloadId.Name = "cbWorkloadId";
            this.cbWorkloadId.Size = new System.Drawing.Size(343, 21);
            this.cbWorkloadId.TabIndex = 1;
            // 
            // bsWorkloadId
            // 
            this.bsWorkloadId.DataSource = typeof(ProgramWithBD.Workloads);
            // 
            // bsTeacherName
            // 
            this.bsTeacherName.DataSource = typeof(ProgramWithBD.Teachers);
            // 
            // bsTeacherMiddlename
            // 
            this.bsTeacherMiddlename.DataSource = typeof(ProgramWithBD.Teachers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Нагрузка";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(138, 147);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 10;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // TeacherWorkloadsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 182);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWorkloadId);
            this.Controls.Add(this.cbTeacherLastname);
            this.Name = "TeacherWorkloadsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить нагрузку преподавателя";
            this.Load += new System.EventHandler(this.TeacherWorkloadsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkloadId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherMiddlename)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeacherLastname;
        private System.Windows.Forms.BindingSource bsTeacherId;
        private System.Windows.Forms.ComboBox cbWorkloadId;
        private System.Windows.Forms.BindingSource bsWorkloadId;
        private System.Windows.Forms.BindingSource bsTeacherLastname;
        private System.Windows.Forms.BindingSource bsTeacherName;
        private System.Windows.Forms.BindingSource bsTeacherMiddlename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAdd;
    }
}