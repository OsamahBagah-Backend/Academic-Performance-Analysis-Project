namespace DBProject
{
    partial class UsEnterMarkes
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnMarkInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.txtGrade = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYearStudy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSemster = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSubjects = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCansel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnAcademic = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPeriods = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLevels = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMajors = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnMarkInformation.SuspendLayout();
            this.pnAcademic.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(633, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدخال الدرجات";
            // 
            // pnMarkInformation
            // 
            this.pnMarkInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnMarkInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnMarkInformation.BorderRadius = 20;
            this.pnMarkInformation.BorderThickness = 1;
            this.pnMarkInformation.Controls.Add(this.txtGrade);
            this.pnMarkInformation.Controls.Add(this.label4);
            this.pnMarkInformation.Controls.Add(this.label3);
            this.pnMarkInformation.Controls.Add(this.cmbYearStudy);
            this.pnMarkInformation.Controls.Add(this.label11);
            this.pnMarkInformation.Controls.Add(this.cmbSemster);
            this.pnMarkInformation.Controls.Add(this.cmbSubjects);
            this.pnMarkInformation.Controls.Add(this.label9);
            this.pnMarkInformation.Controls.Add(this.txtStudentName);
            this.pnMarkInformation.Controls.Add(this.label2);
            this.pnMarkInformation.FillColor = System.Drawing.Color.White;
            this.pnMarkInformation.Location = new System.Drawing.Point(29, 402);
            this.pnMarkInformation.Name = "pnMarkInformation";
            this.pnMarkInformation.ShadowDecoration.BorderRadius = 20;
            this.pnMarkInformation.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnMarkInformation.ShadowDecoration.Depth = 50;
            this.pnMarkInformation.ShadowDecoration.Enabled = true;
            this.pnMarkInformation.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.pnMarkInformation.Size = new System.Drawing.Size(1387, 431);
            this.pnMarkInformation.TabIndex = 1;
            // 
            // txtGrade
            // 
            this.txtGrade.BeepOnError = true;
            this.txtGrade.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.txtGrade.HidePromptOnLeave = true;
            this.txtGrade.Location = new System.Drawing.Point(986, 341);
            this.txtGrade.Mask = "000";
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.PromptChar = ' ';
            this.txtGrade.Size = new System.Drawing.Size(100, 42);
            this.txtGrade.TabIndex = 66;
            this.txtGrade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtGrade_MaskInputRejected);
            this.txtGrade.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(1072, 341);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(265, 51);
            this.label4.TabIndex = 64;
            this.label4.Text = "الدرجة المستحقة:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(287, 206);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(199, 51);
            this.label3.TabIndex = 51;
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
            this.cmbYearStudy.Location = new System.Drawing.Point(102, 212);
            this.cmbYearStudy.Name = "cmbYearStudy";
            this.cmbYearStudy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYearStudy.Size = new System.Drawing.Size(174, 36);
            this.cmbYearStudy.TabIndex = 50;
            this.cmbYearStudy.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            this.cmbYearStudy.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(1122, 206);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(215, 51);
            this.label11.TabIndex = 49;
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
            this.cmbSemster.Location = new System.Drawing.Point(926, 215);
            this.cmbSemster.Name = "cmbSemster";
            this.cmbSemster.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSemster.Size = new System.Drawing.Size(174, 36);
            this.cmbSemster.TabIndex = 48;
            this.cmbSemster.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            this.cmbSemster.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.AllowDrop = true;
            this.cmbSubjects.BackColor = System.Drawing.Color.Transparent;
            this.cmbSubjects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbSubjects.BorderThickness = 2;
            this.cmbSubjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubjects.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubjects.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbSubjects.ItemHeight = 30;
            this.cmbSubjects.Location = new System.Drawing.Point(54, 69);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSubjects.Size = new System.Drawing.Size(444, 36);
            this.cmbSubjects.TabIndex = 47;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            this.cmbSubjects.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(483, 65);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(127, 51);
            this.label9.TabIndex = 46;
            this.label9.Text = "المادة:";
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
            this.txtStudentName.Location = new System.Drawing.Point(659, 62);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PlaceholderText = "";
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.Size = new System.Drawing.Size(498, 52);
            this.txtStudentName.TabIndex = 45;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(1159, 65);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(178, 51);
            this.label2.TabIndex = 44;
            this.label2.Text = "إسم الطالب:";
            // 
            // btnCansel
            // 
            this.btnCansel.Animated = true;
            this.btnCansel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnCansel.BorderRadius = 10;
            this.btnCansel.BorderThickness = 2;
            this.btnCansel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCansel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCansel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCansel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCansel.FillColor = System.Drawing.Color.White;
            this.btnCansel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCansel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnCansel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnCansel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCansel.Location = new System.Drawing.Point(29, 855);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(180, 57);
            this.btnCansel.TabIndex = 46;
            this.btnCansel.Text = "إلغاء";
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
            this.btnSave.Location = new System.Drawing.Point(1236, 855);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 57);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnAcademic
            // 
            this.pnAcademic.BackColor = System.Drawing.Color.Transparent;
            this.pnAcademic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnAcademic.BorderRadius = 20;
            this.pnAcademic.BorderThickness = 1;
            this.pnAcademic.Controls.Add(this.label5);
            this.pnAcademic.Controls.Add(this.cmbPeriods);
            this.pnAcademic.Controls.Add(this.cmbLevels);
            this.pnAcademic.Controls.Add(this.label10);
            this.pnAcademic.Controls.Add(this.cmbMajors);
            this.pnAcademic.Controls.Add(this.label6);
            this.pnAcademic.Controls.Add(this.label8);
            this.pnAcademic.FillColor = System.Drawing.Color.White;
            this.pnAcademic.Location = new System.Drawing.Point(25, 148);
            this.pnAcademic.Name = "pnAcademic";
            this.pnAcademic.ShadowDecoration.BorderRadius = 20;
            this.pnAcademic.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnAcademic.ShadowDecoration.Depth = 50;
            this.pnAcademic.ShadowDecoration.Enabled = true;
            this.pnAcademic.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.pnAcademic.Size = new System.Drawing.Size(1391, 203);
            this.pnAcademic.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(198, 115);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(159, 51);
            this.label5.TabIndex = 25;
            this.label5.Text = "فترة الدراسة:";
            // 
            // cmbPeriods
            // 
            this.cmbPeriods.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbPeriods.BorderThickness = 2;
            this.cmbPeriods.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriods.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriods.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriods.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmbPeriods.ItemHeight = 30;
            this.cmbPeriods.Items.AddRange(new object[] {
            "مسائي",
            "صباحي"});
            this.cmbPeriods.Location = new System.Drawing.Point(18, 115);
            this.cmbPeriods.Name = "cmbPeriods";
            this.cmbPeriods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPeriods.Size = new System.Drawing.Size(174, 36);
            this.cmbPeriods.TabIndex = 24;
            this.cmbPeriods.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
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
            this.cmbLevels.Location = new System.Drawing.Point(390, 115);
            this.cmbLevels.Name = "cmbLevels";
            this.cmbLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLevels.Size = new System.Drawing.Size(299, 36);
            this.cmbLevels.TabIndex = 23;
            this.cmbLevels.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(687, 115);
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
            "علوم حاسوب"});
            this.cmbMajors.Location = new System.Drawing.Point(931, 115);
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
            this.label6.Location = new System.Drawing.Point(1236, 115);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(127, 51);
            this.label6.TabIndex = 20;
            this.label6.Text = "التخصص:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(1094, 17);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(279, 49);
            this.label8.TabIndex = 19;
            this.label8.Text = "البيانات الأكاديمية:";
            // 
            // UsEnterMarkes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnAcademic);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnMarkInformation);
            this.Controls.Add(this.label1);
            this.Name = "UsEnterMarkes";
            this.Size = new System.Drawing.Size(1468, 923);
            this.Load += new System.EventHandler(this.UsEnterMarkes_Load);
            this.pnMarkInformation.ResumeLayout(false);
            this.pnMarkInformation.PerformLayout();
            this.pnAcademic.ResumeLayout(false);
            this.pnAcademic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnMarkInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYearStudy;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemster;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubjects;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCansel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Panel pnAcademic;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriods;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLevels;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMajors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtGrade;
    }
}
