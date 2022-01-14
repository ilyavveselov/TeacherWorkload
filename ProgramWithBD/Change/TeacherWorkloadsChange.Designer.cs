namespace ProgramWithBD.Change
{
    partial class TeacherWorkloadsChange
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
            this.cbWorkloadId = new System.Windows.Forms.ComboBox();
            this.bsWorkloadId = new System.Windows.Forms.BindingSource(this.components);
            this.bsTeacherId = new System.Windows.Forms.BindingSource(this.components);
            this.bChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTeacherId = new System.Windows.Forms.ComboBox();
            this.bsTeacherWorkloads = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbTWId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkloadId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherWorkloads)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWorkloadId
            // 
            this.cbWorkloadId.FormattingEnabled = true;
            this.cbWorkloadId.Location = new System.Drawing.Point(12, 91);
            this.cbWorkloadId.Name = "cbWorkloadId";
            this.cbWorkloadId.Size = new System.Drawing.Size(224, 21);
            this.cbWorkloadId.TabIndex = 12;
            // 
            // bsWorkloadId
            // 
            this.bsWorkloadId.DataSource = typeof(ProgramWithBD.Workloads);
            // 
            // bsTeacherId
            // 
            this.bsTeacherId.DataSource = typeof(ProgramWithBD.Teachers);
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(15, 118);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(75, 23);
            this.bChange.TabIndex = 21;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Нагрузка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Преподаватель";
            // 
            // cbTeacherId
            // 
            this.cbTeacherId.FormattingEnabled = true;
            this.cbTeacherId.Location = new System.Drawing.Point(12, 51);
            this.cbTeacherId.Name = "cbTeacherId";
            this.cbTeacherId.Size = new System.Drawing.Size(224, 21);
            this.cbTeacherId.TabIndex = 15;
            // 
            // bsTeacherWorkloads
            // 
            this.bsTeacherWorkloads.DataSource = typeof(ProgramWithBD.TeacherWorkloads);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Изменяемая нагрузка";
            // 
            // lbTWId
            // 
            this.lbTWId.AutoSize = true;
            this.lbTWId.Location = new System.Drawing.Point(161, 9);
            this.lbTWId.Name = "lbTWId";
            this.lbTWId.Size = new System.Drawing.Size(13, 13);
            this.lbTWId.TabIndex = 26;
            this.lbTWId.Text = "0";
            // 
            // TeacherWorkloadsChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 171);
            this.Controls.Add(this.lbTWId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbWorkloadId);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTeacherId);
            this.Name = "TeacherWorkloadsChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение нагрузки преподавателя";
            this.Load += new System.EventHandler(this.TeacherWorkloadsChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkloadId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeacherWorkloads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWorkloadId;
        private System.Windows.Forms.BindingSource bsWorkloadId;
        private System.Windows.Forms.BindingSource bsTeacherId;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTeacherId;
        private System.Windows.Forms.BindingSource bsTeacherWorkloads;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTWId;
    }
}