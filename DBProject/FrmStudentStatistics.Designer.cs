namespace DBProject
{
    partial class FrmStudentStatistics
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
            this.txtStudentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbLevels = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSemster = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYearStudy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStudentName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.txtStudentName.BorderRadius = 10;
            this.txtStudentName.BorderThickness = 2;
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.DefaultText = "";
            this.txtStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.txtStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Location = new System.Drawing.Point(9, 74);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtStudentName.PlaceholderText = "أدخل إسم الطالب";
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.Size = new System.Drawing.Size(443, 62);
            this.txtStudentName.TabIndex = 46;
            // 
            // cmbLevels
            // 
            this.cmbLevels.BackColor = System.Drawing.Color.Transparent;
            this.cmbLevels.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbLevels.BorderThickness = 2;
            this.cmbLevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevels.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevels.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevels.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbLevels.ItemHeight = 30;
            this.cmbLevels.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث",
            "الرابع"});
            this.cmbLevels.Location = new System.Drawing.Point(11, 189);
            this.cmbLevels.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLevels.Name = "cmbLevels";
            this.cmbLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLevels.Size = new System.Drawing.Size(243, 36);
            this.cmbLevels.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(268, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(196, 33);
            this.label10.TabIndex = 49;
            this.label10.Text = "المستوى الدراسي:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(268, 285);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(190, 33);
            this.label11.TabIndex = 52;
            this.label11.Text = "الفصل الدراسي:";
            // 
            // cmbSemster
            // 
            this.cmbSemster.BackColor = System.Drawing.Color.Transparent;
            this.cmbSemster.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbSemster.BorderThickness = 2;
            this.cmbSemster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSemster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemster.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSemster.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSemster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbSemster.ItemHeight = 30;
            this.cmbSemster.Items.AddRange(new object[] {
            "الترم الأول",
            "الترم الثاني"});
            this.cmbSemster.Location = new System.Drawing.Point(55, 272);
            this.cmbSemster.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSemster.Name = "cmbSemster";
            this.cmbSemster.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSemster.Size = new System.Drawing.Size(199, 36);
            this.cmbSemster.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(286, 371);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(172, 33);
            this.label3.TabIndex = 54;
            this.label3.Text = "العام الدراسي:";
            // 
            // cmbYearStudy
            // 
            this.cmbYearStudy.BackColor = System.Drawing.Color.Transparent;
            this.cmbYearStudy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbYearStudy.BorderThickness = 2;
            this.cmbYearStudy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYearStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearStudy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYearStudy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYearStudy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearStudy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbYearStudy.ItemHeight = 30;
            this.cmbYearStudy.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbYearStudy.Location = new System.Drawing.Point(69, 374);
            this.cmbYearStudy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYearStudy.Name = "cmbYearStudy";
            this.cmbYearStudy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYearStudy.Size = new System.Drawing.Size(185, 36);
            this.cmbYearStudy.TabIndex = 53;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 2;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(69, 474);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(303, 56);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "حفظ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(89, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 39);
            this.label1.TabIndex = 56;
            this.label1.Text = "معلومات الإحصائية";
            // 
            // FrmStudentStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYearStudy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbSemster);
            this.Controls.Add(this.cmbLevels);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStudentName);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStudentStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلومات الإحصائية";
            this.Load += new System.EventHandler(this.FrmStudentStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtStudentName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLevels;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemster;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYearStudy;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}