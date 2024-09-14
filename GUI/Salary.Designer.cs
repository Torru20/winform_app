namespace GUI
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.btnCalculateSalary = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.dgvSalary = new Krypton.Toolkit.KryptonDataGridView();
            this.btnSendMail = new Krypton.Toolkit.KryptonButton();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.CornerRoundingRadius = 15F;
            this.btnCalculateSalary.Location = new System.Drawing.Point(249, 12);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnCalculateSalary.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnCalculateSalary.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnCalculateSalary.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnCalculateSalary.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalculateSalary.OverrideDefault.Border.Rounding = 15F;
            this.btnCalculateSalary.OverrideDefault.Border.Width = 2;
            this.btnCalculateSalary.Size = new System.Drawing.Size(358, 56);
            this.btnCalculateSalary.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnCalculateSalary.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnCalculateSalary.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnCalculateSalary.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnCalculateSalary.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalculateSalary.StateCommon.Border.Rounding = 15F;
            this.btnCalculateSalary.StateCommon.Border.Width = 2;
            this.btnCalculateSalary.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSalary.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnCalculateSalary.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnCalculateSalary.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnCalculateSalary.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnCalculateSalary.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalculateSalary.StateTracking.Border.Rounding = 15F;
            this.btnCalculateSalary.StateTracking.Border.Width = 2;
            this.btnCalculateSalary.TabIndex = 52;
            this.btnCalculateSalary.Values.Text = "Tính lương";
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
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
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeight = 36;
            this.dgvSalary.Location = new System.Drawing.Point(34, 89);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.RowTemplate.Height = 24;
            this.dgvSalary.Size = new System.Drawing.Size(821, 340);
            this.dgvSalary.TabIndex = 53;
            // 
            // btnSendMail
            // 
            this.btnSendMail.CornerRoundingRadius = 15F;
            this.btnSendMail.Location = new System.Drawing.Point(639, 12);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnSendMail.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnSendMail.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSendMail.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSendMail.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendMail.OverrideDefault.Border.Rounding = 15F;
            this.btnSendMail.OverrideDefault.Border.Width = 2;
            this.btnSendMail.Size = new System.Drawing.Size(192, 56);
            this.btnSendMail.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnSendMail.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnSendMail.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnSendMail.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnSendMail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendMail.StateCommon.Border.Rounding = 15F;
            this.btnSendMail.StateCommon.Border.Width = 2;
            this.btnSendMail.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSendMail.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnSendMail.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSendMail.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSendMail.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSendMail.StateTracking.Border.Rounding = 15F;
            this.btnSendMail.StateTracking.Border.Width = 2;
            this.btnSendMail.TabIndex = 54;
            this.btnSendMail.Values.Text = "Gửi Mail";
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxMonth.Location = new System.Drawing.Point(133, 28);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(70, 24);
            this.cbxMonth.TabIndex = 55;
            this.cbxMonth.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 22);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "Chọn tháng:";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.dgvSalary);
            this.Controls.Add(this.btnCalculateSalary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Salary";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính lương";
            this.Click += new System.EventHandler(this.NutGui_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnCalculateSalary;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonDataGridView dgvSalary;
        private Krypton.Toolkit.KryptonButton btnSendMail;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.TextBox textBox1;
    }
}