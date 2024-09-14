namespace GUI
{
    partial class Account_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Info));
            this.btnUpdateInfo = new Krypton.Toolkit.KryptonButton();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxAccountName = new Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPosition = new Krypton.Toolkit.KryptonTextBox();
            this.tbxNewPassWord1 = new Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxNewPassWord = new Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPassWord = new Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxEmail = new Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btExit = new Krypton.Toolkit.KryptonButton();
            this.btnUpdatePassword = new Krypton.Toolkit.KryptonButton();
            this.tbxAddress = new Krypton.Toolkit.KryptonTextBox();
            this.tbxEmployeeName = new Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.CornerRoundingRadius = 15F;
            this.btnUpdateInfo.Location = new System.Drawing.Point(544, 392);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnUpdateInfo.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdateInfo.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdateInfo.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUpdateInfo.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateInfo.OverrideDefault.Border.Rounding = 15F;
            this.btnUpdateInfo.OverrideDefault.Border.Width = 2;
            this.btnUpdateInfo.Size = new System.Drawing.Size(358, 56);
            this.btnUpdateInfo.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateInfo.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdateInfo.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateInfo.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdateInfo.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateInfo.StateCommon.Border.Rounding = 15F;
            this.btnUpdateInfo.StateCommon.Border.Width = 2;
            this.btnUpdateInfo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdateInfo.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdateInfo.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdateInfo.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUpdateInfo.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateInfo.StateTracking.Border.Rounding = 15F;
            this.btnUpdateInfo.StateTracking.Border.Width = 2;
            this.btnUpdateInfo.TabIndex = 6;
            this.btnUpdateInfo.Values.Text = "Cập nhật thông tin";
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(50, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 33);
            this.label11.TabIndex = 57;
            this.label11.Text = "Đổi mật khẩu";
            // 
            // tbxAccountName
            // 
            this.tbxAccountName.Location = new System.Drawing.Point(664, 84);
            this.tbxAccountName.Name = "tbxAccountName";
            this.tbxAccountName.ReadOnly = true;
            this.tbxAccountName.Size = new System.Drawing.Size(294, 40);
            this.tbxAccountName.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAccountName.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAccountName.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxAccountName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxAccountName.StateCommon.Border.Rounding = 15F;
            this.tbxAccountName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountName.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(505, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "Tên tài khoản";
            // 
            // tbxPosition
            // 
            this.tbxPosition.Location = new System.Drawing.Point(184, 154);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.ReadOnly = true;
            this.tbxPosition.Size = new System.Drawing.Size(294, 40);
            this.tbxPosition.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxPosition.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxPosition.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxPosition.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxPosition.StateCommon.Border.Rounding = 15F;
            this.tbxPosition.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPosition.TabIndex = 3;
            // 
            // tbxNewPassWord1
            // 
            this.tbxNewPassWord1.Location = new System.Drawing.Point(310, 682);
            this.tbxNewPassWord1.Name = "tbxNewPassWord1";
            this.tbxNewPassWord1.PasswordChar = '●';
            this.tbxNewPassWord1.Size = new System.Drawing.Size(294, 40);
            this.tbxNewPassWord1.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxNewPassWord1.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxNewPassWord1.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxNewPassWord1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxNewPassWord1.StateCommon.Border.Rounding = 15F;
            this.tbxNewPassWord1.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassWord1.TabIndex = 9;
            this.tbxNewPassWord1.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(71, 698);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "Nhập lại mật khẩu mới";
            // 
            // tbxNewPassWord
            // 
            this.tbxNewPassWord.Location = new System.Drawing.Point(310, 625);
            this.tbxNewPassWord.Name = "tbxNewPassWord";
            this.tbxNewPassWord.PasswordChar = '●';
            this.tbxNewPassWord.Size = new System.Drawing.Size(294, 40);
            this.tbxNewPassWord.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxNewPassWord.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxNewPassWord.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxNewPassWord.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxNewPassWord.StateCommon.Border.Rounding = 15F;
            this.tbxNewPassWord.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassWord.TabIndex = 8;
            this.tbxNewPassWord.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(71, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Mật khẩu mới";
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.Location = new System.Drawing.Point(310, 558);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.PasswordChar = '●';
            this.tbxPassWord.Size = new System.Drawing.Size(294, 40);
            this.tbxPassWord.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxPassWord.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxPassWord.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxPassWord.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxPassWord.StateCommon.Border.Rounding = 15F;
            this.tbxPassWord.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassWord.TabIndex = 7;
            this.tbxPassWord.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(71, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Mật khẩu hiện tại";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(184, 315);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(294, 40);
            this.tbxEmail.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmail.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmail.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxEmail.StateCommon.Border.Rounding = 15F;
            this.tbxEmail.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(32, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Email";
            // 
            // btExit
            // 
            this.btExit.CornerRoundingRadius = 15F;
            this.btExit.Location = new System.Drawing.Point(673, 650);
            this.btExit.Name = "btExit";
            this.btExit.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btExit.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btExit.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btExit.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btExit.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btExit.OverrideDefault.Border.Rounding = 15F;
            this.btExit.OverrideDefault.Border.Width = 2;
            this.btExit.Size = new System.Drawing.Size(150, 56);
            this.btExit.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btExit.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btExit.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btExit.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btExit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btExit.StateCommon.Border.Rounding = 15F;
            this.btExit.StateCommon.Border.Width = 2;
            this.btExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btExit.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btExit.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btExit.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btExit.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btExit.StateTracking.Border.Rounding = 15F;
            this.btExit.StateTracking.Border.Width = 2;
            this.btExit.TabIndex = 11;
            this.btExit.Values.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.CornerRoundingRadius = 15F;
            this.btnUpdatePassword.Location = new System.Drawing.Point(673, 583);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.OverrideDefault.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.btnUpdatePassword.OverrideDefault.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdatePassword.OverrideDefault.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdatePassword.OverrideDefault.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUpdatePassword.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdatePassword.OverrideDefault.Border.Rounding = 15F;
            this.btnUpdatePassword.OverrideDefault.Border.Width = 2;
            this.btnUpdatePassword.Size = new System.Drawing.Size(150, 56);
            this.btnUpdatePassword.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePassword.StateCommon.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdatePassword.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePassword.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdatePassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdatePassword.StateCommon.Border.Rounding = 15F;
            this.btnUpdatePassword.StateCommon.Border.Width = 2;
            this.btnUpdatePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdatePassword.StateTracking.Back.Color2 = System.Drawing.Color.AliceBlue;
            this.btnUpdatePassword.StateTracking.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUpdatePassword.StateTracking.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUpdatePassword.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdatePassword.StateTracking.Border.Rounding = 15F;
            this.btnUpdatePassword.StateTracking.Border.Width = 2;
            this.btnUpdatePassword.TabIndex = 10;
            this.btnUpdatePassword.Values.Text = "Cập nhật";
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(184, 238);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(771, 40);
            this.tbxAddress.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAddress.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxAddress.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxAddress.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxAddress.StateCommon.Border.Rounding = 15F;
            this.tbxAddress.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.TabIndex = 4;
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Location = new System.Drawing.Point(184, 84);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.ReadOnly = true;
            this.tbxEmployeeName.Size = new System.Drawing.Size(294, 40);
            this.tbxEmployeeName.StateCommon.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmployeeName.StateCommon.Border.Color1 = System.Drawing.Color.AliceBlue;
            this.tbxEmployeeName.StateCommon.Border.Color2 = System.Drawing.Color.AliceBlue;
            this.tbxEmployeeName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxEmployeeName.StateCommon.Border.Rounding = 15F;
            this.tbxEmployeeName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(28, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(31, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(340, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Thông tin tài khoản";
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
            // Account_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxAccountName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.tbxNewPassWord1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxNewPassWord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxPassWord);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxEmployeeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account_Info";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnUpdateInfo;
        private System.Windows.Forms.Label label11;
        private Krypton.Toolkit.KryptonTextBox tbxAccountName;
        private System.Windows.Forms.Label label10;
        private Krypton.Toolkit.KryptonTextBox tbxPosition;
        private Krypton.Toolkit.KryptonTextBox tbxNewPassWord1;
        private System.Windows.Forms.Label label9;
        private Krypton.Toolkit.KryptonTextBox tbxNewPassWord;
        private System.Windows.Forms.Label label8;
        private Krypton.Toolkit.KryptonTextBox tbxPassWord;
        private System.Windows.Forms.Label label7;
        private Krypton.Toolkit.KryptonTextBox tbxEmail;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonButton btExit;
        private Krypton.Toolkit.KryptonButton btnUpdatePassword;
        private Krypton.Toolkit.KryptonTextBox tbxAddress;
        private Krypton.Toolkit.KryptonTextBox tbxEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}