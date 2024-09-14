namespace GUI
{
    partial class Assign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign));
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.tbxTaskName = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTaskList = new Krypton.Toolkit.KryptonDataGridView();
            this.cbxAccountDo = new Krypton.Toolkit.KryptonComboBox();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.tbxIDTask = new Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStatus = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAccountDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStatus)).BeginInit();
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
            // tbxTaskName
            // 
            this.tbxTaskName.Location = new System.Drawing.Point(314, 84);
            this.tbxTaskName.Name = "tbxTaskName";
            this.tbxTaskName.Size = new System.Drawing.Size(647, 40);
            this.tbxTaskName.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxTaskName.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxTaskName.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxTaskName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxTaskName.StateCommon.Border.Rounding = 15F;
            this.tbxTaskName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTaskName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(123, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Người thực hiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(121, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên nhiệm vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(413, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Giao nhiệm vụ";
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.ColumnHeadersHeight = 36;
            this.dgvTaskList.Location = new System.Drawing.Point(119, 356);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.RowHeadersWidth = 51;
            this.dgvTaskList.RowTemplate.Height = 24;
            this.dgvTaskList.Size = new System.Drawing.Size(873, 259);
            this.dgvTaskList.TabIndex = 24;
            this.dgvTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskList_CellContentClick);
            // 
            // cbxAccountDo
            // 
            this.cbxAccountDo.CornerRoundingRadius = 15F;
            this.cbxAccountDo.DropDownWidth = 284;
            this.cbxAccountDo.IntegralHeight = false;
            this.cbxAccountDo.Items.AddRange(new object[] {
            "Giám Đốc",
            "Quản Lý",
            "Nhân Viên"});
            this.cbxAccountDo.Location = new System.Drawing.Point(314, 159);
            this.cbxAccountDo.Name = "cbxAccountDo";
            this.cbxAccountDo.Size = new System.Drawing.Size(647, 38);
            this.cbxAccountDo.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxAccountDo.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxAccountDo.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxAccountDo.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxAccountDo.StateCommon.ComboBox.Border.Rounding = 15F;
            this.cbxAccountDo.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccountDo.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxAccountDo.StateCommon.DropBack.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxAccountDo.StateCommon.DropBack.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxAccountDo.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.CornerRoundingRadius = 15F;
            this.btnDelete.Location = new System.Drawing.Point(620, 280);
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
            this.btnDelete.TabIndex = 90;
            this.btnDelete.Values.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CornerRoundingRadius = 15F;
            this.btnUpdate.Location = new System.Drawing.Point(461, 280);
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
            this.btnUpdate.Size = new System.Drawing.Size(153, 56);
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
            this.btnUpdate.TabIndex = 89;
            this.btnUpdate.Values.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CornerRoundingRadius = 15F;
            this.btnAdd.Location = new System.Drawing.Point(327, 280);
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
            this.btnAdd.TabIndex = 88;
            this.btnAdd.Values.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxIDTask
            // 
            this.tbxIDTask.Location = new System.Drawing.Point(314, 223);
            this.tbxIDTask.Name = "tbxIDTask";
            this.tbxIDTask.ReadOnly = true;
            this.tbxIDTask.Size = new System.Drawing.Size(182, 40);
            this.tbxIDTask.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxIDTask.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxIDTask.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxIDTask.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxIDTask.StateCommon.Border.Rounding = 15F;
            this.tbxIDTask.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIDTask.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(121, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 91;
            this.label4.Text = "Mã nhiệm vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(560, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "Trạng thái";
            // 
            // cbxStatus
            // 
            this.cbxStatus.CornerRoundingRadius = 15F;
            this.cbxStatus.DropDownWidth = 284;
            this.cbxStatus.IntegralHeight = false;
            this.cbxStatus.Items.AddRange(new object[] {
            "Mới giao",
            "Đang thực hiện",
            "Hoàn thành"});
            this.cbxStatus.Location = new System.Drawing.Point(685, 223);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(276, 38);
            this.cbxStatus.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxStatus.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxStatus.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxStatus.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxStatus.StateCommon.ComboBox.Border.Rounding = 15F;
            this.cbxStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxStatus.StateCommon.DropBack.Color1 = System.Drawing.Color.AliceBlue;
            this.cbxStatus.StateCommon.DropBack.Color2 = System.Drawing.Color.AliceBlue;
            this.cbxStatus.TabIndex = 94;
            // 
            // Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxIDTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxAccountDo);
            this.Controls.Add(this.dgvTaskList);
            this.Controls.Add(this.tbxTaskName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Assign";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao nhiệm vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAccountDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonTextBox tbxTaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDataGridView dgvTaskList;
        private Krypton.Toolkit.KryptonComboBox cbxAccountDo;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonTextBox tbxIDTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonComboBox cbxStatus;
    }
}