namespace GUI
{
    partial class Main_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Employee));
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.btnToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThusday = new System.Windows.Forms.Button();
            this.btnPreviours = new Krypton.Toolkit.KryptonButton();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhiệmVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btCheck = new Krypton.Toolkit.KryptonButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.CornerRoundingRadius = 15F;
            this.btnNext.Location = new System.Drawing.Point(1089, 109);
            this.btnNext.Name = "btnNext";
            this.btnNext.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnNext.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnNext.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnNext.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnNext.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.OverrideDefault.Border.Rounding = 15F;
            this.btnNext.OverrideDefault.Border.Width = 2;
            this.btnNext.Size = new System.Drawing.Size(59, 87);
            this.btnNext.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnNext.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnNext.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnNext.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnNext.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Border.Rounding = 15F;
            this.btnNext.StateCommon.Border.Width = 2;
            this.btnNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnNext.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnNext.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnNext.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnNext.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateTracking.Border.Rounding = 15F;
            this.btnNext.StateTracking.Border.Width = 2;
            this.btnNext.TabIndex = 27;
            this.btnNext.Values.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnToDay
            // 
            this.btnToDay.Location = new System.Drawing.Point(605, 7);
            this.btnToDay.Name = "btnToDay";
            this.btnToDay.Size = new System.Drawing.Size(112, 35);
            this.btnToDay.TabIndex = 1;
            this.btnToDay.Text = "hôm nay";
            this.btnToDay.UseVisualStyleBackColor = true;
            this.btnToDay.Click += new System.EventHandler(this.btnToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(376, 13);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnToDay);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Location = new System.Drawing.Point(93, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 49);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMonday);
            this.panel1.Controls.Add(this.btnSunday);
            this.panel1.Controls.Add(this.btnTuesday);
            this.panel1.Controls.Add(this.btnSaturday);
            this.panel1.Controls.Add(this.btnWednesday);
            this.panel1.Controls.Add(this.btnFriday);
            this.panel1.Controls.Add(this.btnThusday);
            this.panel1.Location = new System.Drawing.Point(93, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 87);
            this.panel1.TabIndex = 24;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(3, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(135, 80);
            this.btnMonday.TabIndex = 10;
            this.btnMonday.Text = "Thứ hai";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(849, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(135, 80);
            this.btnSunday.TabIndex = 16;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(144, 3);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(135, 80);
            this.btnTuesday.TabIndex = 11;
            this.btnTuesday.Text = "Thứ ba";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(708, 4);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(135, 80);
            this.btnSaturday.TabIndex = 15;
            this.btnSaturday.Text = "Thứ bảy";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(285, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(135, 80);
            this.btnWednesday.TabIndex = 12;
            this.btnWednesday.Text = "Thứ tư";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(567, 3);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(135, 80);
            this.btnFriday.TabIndex = 14;
            this.btnFriday.Text = "Thứ sáu";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThusday
            // 
            this.btnThusday.Location = new System.Drawing.Point(426, 3);
            this.btnThusday.Name = "btnThusday";
            this.btnThusday.Size = new System.Drawing.Size(135, 80);
            this.btnThusday.TabIndex = 13;
            this.btnThusday.Text = "Thứ năm";
            this.btnThusday.UseVisualStyleBackColor = true;
            // 
            // btnPreviours
            // 
            this.btnPreviours.CornerRoundingRadius = 15F;
            this.btnPreviours.Location = new System.Drawing.Point(28, 109);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnPreviours.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnPreviours.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnPreviours.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnPreviours.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPreviours.OverrideDefault.Border.Rounding = 15F;
            this.btnPreviours.OverrideDefault.Border.Width = 2;
            this.btnPreviours.Size = new System.Drawing.Size(59, 87);
            this.btnPreviours.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnPreviours.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnPreviours.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnPreviours.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnPreviours.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPreviours.StateCommon.Border.Rounding = 15F;
            this.btnPreviours.StateCommon.Border.Width = 2;
            this.btnPreviours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviours.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnPreviours.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnPreviours.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnPreviours.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnPreviours.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPreviours.StateTracking.Border.Rounding = 15F;
            this.btnPreviours.StateTracking.Border.Width = 2;
            this.btnPreviours.TabIndex = 26;
            this.btnPreviours.Values.Text = "<";
            this.btnPreviours.Click += new System.EventHandler(this.btnPreviours_Click);
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(95, 202);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(991, 482);
            this.pnlMatrix.TabIndex = 22;
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // phânCôngToolStripMenuItem
            // 
            this.phânCôngToolStripMenuItem.Name = "phânCôngToolStripMenuItem";
            this.phânCôngToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.phânCôngToolStripMenuItem.Text = "Phân công";
            this.phânCôngToolStripMenuItem.Click += new System.EventHandler(this.phânCôngToolStripMenuItem_Click);
            // 
            // nhiệmVụToolStripMenuItem
            // 
            this.nhiệmVụToolStripMenuItem.Name = "nhiệmVụToolStripMenuItem";
            this.nhiệmVụToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.nhiệmVụToolStripMenuItem.Text = "Nhiệm vụ";
            this.nhiệmVụToolStripMenuItem.Click += new System.EventHandler(this.nhiệmVụToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhiệmVụToolStripMenuItem,
            this.phânCôngToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // btCheck
            // 
            this.btCheck.CornerRoundingRadius = 15F;
            this.btCheck.Location = new System.Drawing.Point(429, 690);
            this.btCheck.Name = "btCheck";
            this.btCheck.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btCheck.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btCheck.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btCheck.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btCheck.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCheck.OverrideDefault.Border.Rounding = 15F;
            this.btCheck.OverrideDefault.Border.Width = 2;
            this.btCheck.Size = new System.Drawing.Size(334, 60);
            this.btCheck.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btCheck.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btCheck.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btCheck.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btCheck.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCheck.StateCommon.Border.Rounding = 15F;
            this.btCheck.StateCommon.Border.Width = 2;
            this.btCheck.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btCheck.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btCheck.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btCheck.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btCheck.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btCheck.StateTracking.Border.Rounding = 15F;
            this.btCheck.StateTracking.Border.Width = 2;
            this.btCheck.TabIndex = 23;
            this.btCheck.Values.Text = "Điểm danh";
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
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
            // Main_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPreviours);
            this.Controls.Add(this.pnlMatrix);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Employee";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnNext;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThusday;
        private Krypton.Toolkit.KryptonButton btnPreviours;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhiệmVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private Krypton.Toolkit.KryptonButton btCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}