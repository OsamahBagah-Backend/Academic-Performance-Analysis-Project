namespace DBProject
{
    partial class UsBatchStatiSticsInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsBatchStatiSticsInfo));
            this.pnAcademic = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKind = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYearStudy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSemster = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLevels = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMajors = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.pnAcademic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAcademic
            // 
            this.pnAcademic.BackColor = System.Drawing.Color.Transparent;
            this.pnAcademic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnAcademic.BorderRadius = 20;
            this.pnAcademic.BorderThickness = 1;
            this.pnAcademic.Controls.Add(this.label2);
            this.pnAcademic.Controls.Add(this.cmbKind);
            this.pnAcademic.Controls.Add(this.label3);
            this.pnAcademic.Controls.Add(this.cmbYearStudy);
            this.pnAcademic.Controls.Add(this.label11);
            this.pnAcademic.Controls.Add(this.cmbSemster);
            this.pnAcademic.Controls.Add(this.cmbLevels);
            this.pnAcademic.Controls.Add(this.label10);
            this.pnAcademic.Controls.Add(this.cmbMajors);
            this.pnAcademic.Controls.Add(this.label6);
            this.pnAcademic.FillColor = System.Drawing.Color.White;
            this.pnAcademic.Location = new System.Drawing.Point(39, 485);
            this.pnAcademic.Name = "pnAcademic";
            this.pnAcademic.ShadowDecoration.BorderRadius = 20;
            this.pnAcademic.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnAcademic.ShadowDecoration.Depth = 50;
            this.pnAcademic.ShadowDecoration.Enabled = true;
            this.pnAcademic.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.pnAcademic.Size = new System.Drawing.Size(1391, 331);
            this.pnAcademic.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(714, 192);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(171, 51);
            this.label2.TabIndex = 58;
            this.label2.Text = "نوع الإحصائية:";
            // 
            // cmbKind
            // 
            this.cmbKind.BackColor = System.Drawing.Color.Transparent;
            this.cmbKind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbKind.BorderThickness = 2;
            this.cmbKind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKind.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKind.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbKind.ItemHeight = 30;
            this.cmbKind.Items.AddRange(new object[] {
            "على مستوى الدفعه كامله",
            "على مستوى الأولاد والبنات",
            "طباعة الكشف النهائي للدفعه"});
            this.cmbKind.Location = new System.Drawing.Point(308, 192);
            this.cmbKind.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKind.Name = "cmbKind";
            this.cmbKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbKind.Size = new System.Drawing.Size(375, 36);
            this.cmbKind.TabIndex = 57;
            this.cmbKind.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(1191, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(172, 33);
            this.label3.TabIndex = 56;
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
            "2024",
            "2023"});
            this.cmbYearStudy.Location = new System.Drawing.Point(931, 192);
            this.cmbYearStudy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYearStudy.Name = "cmbYearStudy";
            this.cmbYearStudy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYearStudy.Size = new System.Drawing.Size(256, 36);
            this.cmbYearStudy.TabIndex = 55;
            this.cmbYearStudy.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(262, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(190, 33);
            this.label11.TabIndex = 54;
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
            this.cmbSemster.Location = new System.Drawing.Point(42, 73);
            this.cmbSemster.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSemster.Name = "cmbSemster";
            this.cmbSemster.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSemster.Size = new System.Drawing.Size(199, 36);
            this.cmbSemster.TabIndex = 53;
            this.cmbSemster.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
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
            this.cmbLevels.Location = new System.Drawing.Point(498, 73);
            this.cmbLevels.Name = "cmbLevels";
            this.cmbLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLevels.Size = new System.Drawing.Size(173, 36);
            this.cmbLevels.TabIndex = 23;
            this.cmbLevels.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(677, 73);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(208, 51);
            this.label10.TabIndex = 22;
            this.label10.Text = "المستوى الدراسي:";
            // 
            // cmbMajors
            // 
            this.cmbMajors.BackColor = System.Drawing.Color.Transparent;
            this.cmbMajors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbMajors.BorderThickness = 2;
            this.cmbMajors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMajors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajors.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMajors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMajors.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMajors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbMajors.ItemHeight = 30;
            this.cmbMajors.Items.AddRange(new object[] {
            "تقنية المعلومات",
            "علوم الحاسوب"});
            this.cmbMajors.Location = new System.Drawing.Point(931, 74);
            this.cmbMajors.Name = "cmbMajors";
            this.cmbMajors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMajors.Size = new System.Drawing.Size(299, 36);
            this.cmbMajors.TabIndex = 21;
            this.cmbMajors.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(1236, 74);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(127, 51);
            this.label6.TabIndex = 20;
            this.label6.Text = "التخصص:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(581, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 59);
            this.label1.TabIndex = 50;
            this.label1.Text = "معلومات الإحصائية";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(469, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(562, 392);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 49;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Animated = true;
            this.btnShow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnShow.BorderRadius = 10;
            this.btnShow.BorderThickness = 2;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.White;
            this.btnShow.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnShow.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnShow.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(39, 843);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 57);
            this.btnShow.TabIndex = 52;
            this.btnShow.Text = "عرض";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // UsBatchStatiSticsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pnAcademic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "UsBatchStatiSticsInfo";
            this.Size = new System.Drawing.Size(1468, 923);
            this.Load += new System.EventHandler(this.UsBatchStatiSticsInfo_Load);
            this.pnAcademic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnAcademic;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYearStudy;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemster;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLevels;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMajors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKind;
    }
}
