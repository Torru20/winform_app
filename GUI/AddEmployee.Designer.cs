namespace GUI
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEmployeeList = new Krypton.Toolkit.KryptonDataGridView();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.tbxEmployeeName = new Krypton.Toolkit.KryptonTextBox();
            this.tbxSalary = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAccountName = new Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxAddress = new Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmail = new Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDepartment = new Krypton.Toolkit.KryptonComboBox();
            this.tBAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPosition = new Krypton.Toolkit.KryptonComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAccessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 20F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEmployeeList);
            this.groupBox2.Location = new System.Drawing.Point(43, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 369);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeight = 36;
            this.dgvEmployeeList.Location = new System.Drawing.Point(6, 21);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(984, 342);
            this.dgvEmployeeList.TabIndex = 0;
            this.dgvEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.CornerRoundingRadius = 15F;
            this.btnDelete.Location = new System.Drawing.Point(870, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnDelete.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnDelete.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnDelete.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.OverrideDefault.Border.Rounding = 15F;
            this.btnDelete.OverrideDefault.Border.Width = 2;
            this.btnDelete.Size = new System.Drawing.Size(128, 56);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnDelete.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 15F;
            this.btnDelete.StateCommon.Border.Width = 2;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnDelete.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnDelete.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnDelete.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnDelete.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateTracking.Border.Rounding = 15F;
            this.btnDelete.StateTracking.Border.Width = 2;
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Values.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CornerRoundingRadius = 15F;
            this.btnUpdate.Location = new System.Drawing.Point(723, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnUpdate.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdate.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdate.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUpdate.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.OverrideDefault.Border.Rounding = 15F;
            this.btnUpdate.OverrideDefault.Border.Width = 2;
            this.btnUpdate.Size = new System.Drawing.Size(128, 56);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 15F;
            this.btnUpdate.StateCommon.Border.Width = 2;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdate.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdate.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdate.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUpdate.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateTracking.Border.Rounding = 15F;
            this.btnUpdate.StateTracking.Border.Width = 2;
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Values.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Location = new System.Drawing.Point(227, 67);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(294, 40);
            this.tbxEmployeeName.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmployeeName.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmployeeName.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxEmployeeName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxEmployeeName.StateCommon.Border.Rounding = 15F;
            this.tbxEmployeeName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeName.TabIndex = 74;
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(265, 376);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(294, 40);
            this.tbxSalary.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxSalary.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxSalary.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxSalary.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxSalary.StateCommon.Border.Rounding = 15F;
            this.tbxSalary.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalary.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 70;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(75, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 84;
            this.label7.Text = "Lương theo ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(68, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tên nhân viên";
            // 
            // btnAdd
            // 
            this.btnAdd.CornerRoundingRadius = 15F;
            this.btnAdd.Location = new System.Drawing.Point(577, 369);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnAdd.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideDefault.Border.Rounding = 15F;
            this.btnAdd.OverrideDefault.Border.Width = 2;
            this.btnAdd.Size = new System.Drawing.Size(128, 56);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnAdd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 15F;
            this.btnAdd.StateCommon.Border.Width = 2;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnAdd.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.Rounding = 15F;
            this.btnAdd.StateTracking.Border.Width = 2;
            this.btnAdd.TabIndex = 83;
            this.btnAdd.Values.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(74, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Địa chỉ";
            // 
            // tbxAccountName
            // 
            this.tbxAccountName.Location = new System.Drawing.Point(704, 67);
            this.tbxAccountName.Name = "tbxAccountName";
            this.tbxAccountName.Size = new System.Drawing.Size(314, 40);
            this.tbxAccountName.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAccountName.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAccountName.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxAccountName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxAccountName.StateCommon.Border.Rounding = 15F;
            this.tbxAccountName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountName.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(71, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 73;
            this.label4.Text = "Chức vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(545, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 24);
            this.label10.TabIndex = 81;
            this.label10.Text = "Tên tài khoản";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(227, 221);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(781, 40);
            this.tbxAddress.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAddress.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAddress.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxAddress.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxAddress.StateCommon.Border.Rounding = 15F;
            this.tbxAddress.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(75, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 76;
            this.label5.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(227, 298);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(332, 40);
            this.tbxEmail.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmail.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmail.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxEmail.StateCommon.Border.Rounding = 15F;
            this.tbxEmail.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(558, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 78;
            this.label6.Text = "Phòng ban";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.CornerRoundingRadius = 15F;
            this.cbxDepartment.DropDownWidth = 284;
            this.cbxDepartment.IntegralHeight = false;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Phòng ban Giám Đốc",
            "Phòng ban Quản Lý",
            "Phòng ban Marketing",
            "Văn phòng nhân viên"});
            this.cbxDepartment.Location = new System.Drawing.Point(686, 139);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(347, 38);
            this.cbxDepartment.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxDepartment.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxDepartment.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxDepartment.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxDepartment.StateCommon.ComboBox.Border.Rounding = 15F;
            this.cbxDepartment.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxDepartment.StateCommon.DropBack.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxDepartment.StateCommon.DropBack.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxDepartment.TabIndex = 89;
            // 
            // cbxPosition
            // 
            this.cbxPosition.CornerRoundingRadius = 15F;
            this.cbxPosition.DropDownWidth = 284;
            this.cbxPosition.IntegralHeight = false;
            this.cbxPosition.Items.AddRange(new object[] {
            "Giám Đốc",
            "Quản Lý",
            "Nhân Viên"});
            this.cbxPosition.Location = new System.Drawing.Point(227, 139);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(294, 38);
            this.cbxPosition.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxPosition.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxPosition.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxPosition.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxPosition.StateCommon.ComboBox.Border.Rounding = 15F;
            this.cbxPosition.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPosition.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxPosition.StateCommon.DropBack.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxPosition.StateCommon.DropBack.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxPosition.TabIndex = 90;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxEmployeeName);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAccountName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAccessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonTextBox tbxEmployeeName;
        private Krypton.Toolkit.KryptonTextBox tbxSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox tbxAccountName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private Krypton.Toolkit.KryptonTextBox tbxAddress;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonTextBox tbxEmail;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonDataGridView dgvEmployeeList;
        private Krypton.Toolkit.KryptonComboBox cbxDepartment;
        private System.Windows.Forms.BindingSource tBAccessBindingSource;
        private Krypton.Toolkit.KryptonComboBox cbxPosition;
    }
}