//+------------------------------------------------------------------+
//|                        MetaTrader 5 API Manager for .NET Example |
//|                   Copyright 2001-2016, MetaQuotes Software Corp. |
//|                                        http://www.metaquotes.net |
//+------------------------------------------------------------------+
namespace BalanceExample.NET
  {
   partial class CBalanceExampleDlg
     {
      private System.ComponentModel.IContainer components = null;
      //+------------------------------------------------------------------+
      //| Designer generated code                                          |
      //+------------------------------------------------------------------+
      private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CBalanceExampleDlg));
            this.m_Server = new System.Windows.Forms.TextBox();
            this.m_Loginname = new System.Windows.Forms.TextBox();
            this.m_Password = new System.Windows.Forms.TextBox();
            this.m_Login = new System.Windows.Forms.Button();
            this.m_Logout = new System.Windows.Forms.Button();
            this.m_Getuser = new System.Windows.Forms.Button();
            this.m_User = new System.Windows.Forms.TextBox();
            this.m_Userinfo = new System.Windows.Forms.Label();
            this.m_Balanceinfo = new System.Windows.Forms.Label();
            this.m_Withdraw = new System.Windows.Forms.Button();
            this.m_Comment = new System.Windows.Forms.TextBox();
            this.m_From = new System.Windows.Forms.DateTimePicker();
            this.m_To = new System.Windows.Forms.DateTimePicker();
            this.m_GetDeals = new System.Windows.Forms.Button();
            this.m_List = new System.Windows.Forms.ListView();
            this.m_clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_clDeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_clType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_clAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_Operation = new System.Windows.Forms.ComboBox();
            this.m_Amount = new System.Windows.Forms.TextBox();
            this.m_Deposit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxUserAddGroup = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxUserAddUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserAddReturnInfo = new System.Windows.Forms.TextBox();
            this.textBoxUserAddReadonlyPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUserAddMainPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxUserAddArrayLength = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxUserAddArrayUserNameStartWords = new System.Windows.Forms.TextBox();
            this.textBoxUserAddArrayReturnInfo = new System.Windows.Forms.TextBox();
            this.textBoxUserAddArrayReadonlyPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxUserAddArrayMainPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxUserAddLevelage = new System.Windows.Forms.TextBox();
            this.textBoxUserAddArrayLevelage = new System.Windows.Forms.TextBox();
            this.textBoxUserAddArrayGroup = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(27, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Server:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(27, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Login:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(24, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Location = new System.Drawing.Point(12, 92);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(448, 2);
            label4.TabIndex = 6;
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(27, 107);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 21);
            label5.TabIndex = 9;
            label5.Text = "User:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label6.Location = new System.Drawing.Point(12, 210);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(448, 2);
            label6.TabIndex = 14;
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(27, 271);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 21);
            label8.TabIndex = 19;
            label8.Text = "Comment:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label10.Location = new System.Drawing.Point(12, 306);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(448, 2);
            label10.TabIndex = 24;
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Location = new System.Drawing.Point(233, 318);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(11, 21);
            label11.TabIndex = 26;
            label11.Text = "-";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Location = new System.Drawing.Point(24, 318);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(76, 21);
            label12.TabIndex = 29;
            label12.Text = "Period:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(27, 222);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 21);
            label7.TabIndex = 15;
            label7.Text = "Operation:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(27, 247);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(76, 21);
            label9.TabIndex = 17;
            label9.Text = "Amount:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_Server
            // 
            this.m_Server.Location = new System.Drawing.Point(109, 13);
            this.m_Server.Name = "m_Server";
            this.m_Server.Size = new System.Drawing.Size(182, 21);
            this.m_Server.TabIndex = 1;
            // 
            // m_Loginname
            // 
            this.m_Loginname.Location = new System.Drawing.Point(109, 37);
            this.m_Loginname.Name = "m_Loginname";
            this.m_Loginname.Size = new System.Drawing.Size(182, 21);
            this.m_Loginname.TabIndex = 3;
            // 
            // m_Password
            // 
            this.m_Password.Location = new System.Drawing.Point(109, 61);
            this.m_Password.Name = "m_Password";
            this.m_Password.PasswordChar = '*';
            this.m_Password.Size = new System.Drawing.Size(182, 21);
            this.m_Password.TabIndex = 5;
            // 
            // m_Login
            // 
            this.m_Login.Location = new System.Drawing.Point(297, 11);
            this.m_Login.Name = "m_Login";
            this.m_Login.Size = new System.Drawing.Size(75, 21);
            this.m_Login.TabIndex = 7;
            this.m_Login.Text = "Login";
            this.m_Login.UseVisualStyleBackColor = true;
            this.m_Login.Click += new System.EventHandler(this.OnBnClickedLogin);
            // 
            // m_Logout
            // 
            this.m_Logout.Location = new System.Drawing.Point(376, 11);
            this.m_Logout.Name = "m_Logout";
            this.m_Logout.Size = new System.Drawing.Size(75, 21);
            this.m_Logout.TabIndex = 8;
            this.m_Logout.Text = "Logout";
            this.m_Logout.UseVisualStyleBackColor = true;
            this.m_Logout.Click += new System.EventHandler(this.OnBnClickedLogout);
            // 
            // m_Getuser
            // 
            this.m_Getuser.Location = new System.Drawing.Point(297, 107);
            this.m_Getuser.Name = "m_Getuser";
            this.m_Getuser.Size = new System.Drawing.Size(75, 21);
            this.m_Getuser.TabIndex = 11;
            this.m_Getuser.Text = "Get Info";
            this.m_Getuser.UseVisualStyleBackColor = true;
            this.m_Getuser.Click += new System.EventHandler(this.OnBnClickedGetUser);
            // 
            // m_User
            // 
            this.m_User.Location = new System.Drawing.Point(109, 109);
            this.m_User.Name = "m_User";
            this.m_User.Size = new System.Drawing.Size(182, 21);
            this.m_User.TabIndex = 10;
            // 
            // m_Userinfo
            // 
            this.m_Userinfo.Location = new System.Drawing.Point(20, 143);
            this.m_Userinfo.Name = "m_Userinfo";
            this.m_Userinfo.Size = new System.Drawing.Size(433, 21);
            this.m_Userinfo.TabIndex = 12;
            this.m_Userinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_Balanceinfo
            // 
            this.m_Balanceinfo.Location = new System.Drawing.Point(20, 164);
            this.m_Balanceinfo.Name = "m_Balanceinfo";
            this.m_Balanceinfo.Size = new System.Drawing.Size(433, 21);
            this.m_Balanceinfo.TabIndex = 13;
            this.m_Balanceinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_Withdraw
            // 
            this.m_Withdraw.Location = new System.Drawing.Point(376, 247);
            this.m_Withdraw.Name = "m_Withdraw";
            this.m_Withdraw.Size = new System.Drawing.Size(75, 21);
            this.m_Withdraw.TabIndex = 22;
            this.m_Withdraw.Text = "Withdrawal";
            this.m_Withdraw.UseVisualStyleBackColor = true;
            this.m_Withdraw.Click += new System.EventHandler(this.OnBnClickedButtonWithdrawal);
            // 
            // m_Comment
            // 
            this.m_Comment.Location = new System.Drawing.Point(109, 273);
            this.m_Comment.Name = "m_Comment";
            this.m_Comment.Size = new System.Drawing.Size(182, 21);
            this.m_Comment.TabIndex = 20;
            this.m_Comment.TextChanged += new System.EventHandler(this.OnEnChangeEditCommentOrAmount);
            // 
            // m_From
            // 
            this.m_From.CustomFormat = "";
            this.m_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_From.Location = new System.Drawing.Point(109, 320);
            this.m_From.Name = "m_From";
            this.m_From.Size = new System.Drawing.Size(118, 21);
            this.m_From.TabIndex = 23;
            // 
            // m_To
            // 
            this.m_To.CustomFormat = "";
            this.m_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_To.Location = new System.Drawing.Point(250, 320);
            this.m_To.Name = "m_To";
            this.m_To.Size = new System.Drawing.Size(120, 21);
            this.m_To.TabIndex = 25;
            // 
            // m_GetDeals
            // 
            this.m_GetDeals.Location = new System.Drawing.Point(376, 318);
            this.m_GetDeals.Name = "m_GetDeals";
            this.m_GetDeals.Size = new System.Drawing.Size(75, 21);
            this.m_GetDeals.TabIndex = 27;
            this.m_GetDeals.Text = "Get History";
            this.m_GetDeals.UseVisualStyleBackColor = true;
            this.m_GetDeals.Click += new System.EventHandler(this.OnBnClickedButtonGetdeals);
            // 
            // m_List
            // 
            this.m_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_clTime,
            this.m_clDeal,
            this.m_clType,
            this.m_clAmount});
            this.m_List.GridLines = true;
            this.m_List.Location = new System.Drawing.Point(27, 349);
            this.m_List.Name = "m_List";
            this.m_List.Size = new System.Drawing.Size(424, 170);
            this.m_List.TabIndex = 28;
            this.m_List.UseCompatibleStateImageBehavior = false;
            this.m_List.View = System.Windows.Forms.View.Details;
            // 
            // m_clTime
            // 
            this.m_clTime.Text = "Time";
            this.m_clTime.Width = 100;
            // 
            // m_clDeal
            // 
            this.m_clDeal.Text = "Deal";
            this.m_clDeal.Width = 100;
            // 
            // m_clType
            // 
            this.m_clType.Text = "Type";
            this.m_clType.Width = 70;
            // 
            // m_clAmount
            // 
            this.m_clAmount.Text = "Amount";
            this.m_clAmount.Width = 150;
            // 
            // m_Operation
            // 
            this.m_Operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_Operation.FormattingEnabled = true;
            this.m_Operation.Location = new System.Drawing.Point(109, 224);
            this.m_Operation.Name = "m_Operation";
            this.m_Operation.Size = new System.Drawing.Size(182, 20);
            this.m_Operation.TabIndex = 16;
            // 
            // m_Amount
            // 
            this.m_Amount.Location = new System.Drawing.Point(109, 249);
            this.m_Amount.Name = "m_Amount";
            this.m_Amount.Size = new System.Drawing.Size(182, 21);
            this.m_Amount.TabIndex = 18;
            this.m_Amount.TextChanged += new System.EventHandler(this.OnEnChangeEditCommentOrAmount);
            // 
            // m_Deposit
            // 
            this.m_Deposit.Location = new System.Drawing.Point(297, 247);
            this.m_Deposit.Name = "m_Deposit";
            this.m_Deposit.Size = new System.Drawing.Size(75, 21);
            this.m_Deposit.TabIndex = 21;
            this.m_Deposit.Text = "Deposit";
            this.m_Deposit.UseVisualStyleBackColor = true;
            this.m_Deposit.Click += new System.EventHandler(this.OnBnClickedButtonDeposit);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(458, 11);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(607, 508);
            this.tabControl.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxUserAddLevelage);
            this.tabPage1.Controls.Add(this.textBoxUserAddGroup);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.textBoxUserAddUserName);
            this.tabPage1.Controls.Add(this.textBoxUserAddReturnInfo);
            this.tabPage1.Controls.Add(this.textBoxUserAddReadonlyPassword);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textBoxUserAddMainPassword);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UserAdd";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxUserAddGroup
            // 
            this.textBoxUserAddGroup.Location = new System.Drawing.Point(87, 131);
            this.textBoxUserAddGroup.Name = "textBoxUserAddGroup";
            this.textBoxUserAddGroup.Size = new System.Drawing.Size(230, 21);
            this.textBoxUserAddGroup.TabIndex = 11;
            this.textBoxUserAddGroup.Text = "demo\\demoforex";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(323, 135);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 10;
            this.label21.Text = "levelage";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(46, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 9;
            this.label20.Text = "group";
            // 
            // textBoxUserAddUserName
            // 
            this.textBoxUserAddUserName.Location = new System.Drawing.Point(165, 10);
            this.textBoxUserAddUserName.Name = "textBoxUserAddUserName";
            this.textBoxUserAddUserName.Size = new System.Drawing.Size(301, 21);
            this.textBoxUserAddUserName.TabIndex = 8;
            // 
            // textBoxUserAddReturnInfo
            // 
            this.textBoxUserAddReturnInfo.Location = new System.Drawing.Point(45, 177);
            this.textBoxUserAddReturnInfo.Multiline = true;
            this.textBoxUserAddReturnInfo.Name = "textBoxUserAddReturnInfo";
            this.textBoxUserAddReturnInfo.ReadOnly = true;
            this.textBoxUserAddReturnInfo.Size = new System.Drawing.Size(455, 276);
            this.textBoxUserAddReturnInfo.TabIndex = 7;
            // 
            // textBoxUserAddReadonlyPassword
            // 
            this.textBoxUserAddReadonlyPassword.Location = new System.Drawing.Point(165, 85);
            this.textBoxUserAddReadonlyPassword.Name = "textBoxUserAddReadonlyPassword";
            this.textBoxUserAddReadonlyPassword.Size = new System.Drawing.Size(301, 21);
            this.textBoxUserAddReadonlyPassword.TabIndex = 6;
            this.textBoxUserAddReadonlyPassword.Text = "12345abcdeABCDE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "Readonly password";
            // 
            // textBoxUserAddMainPassword
            // 
            this.textBoxUserAddMainPassword.Location = new System.Drawing.Point(165, 46);
            this.textBoxUserAddMainPassword.Name = "textBoxUserAddMainPassword";
            this.textBoxUserAddMainPassword.Size = new System.Drawing.Size(301, 21);
            this.textBoxUserAddMainPassword.TabIndex = 4;
            this.textBoxUserAddMainPassword.Text = "12345abcdeABCDE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "Main password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Do it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "Want to add UserName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxUserAddArrayLevelage);
            this.tabPage2.Controls.Add(this.textBoxUserAddArrayGroup);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.textBoxUserAddArrayLength);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.textBoxUserAddArrayUserNameStartWords);
            this.tabPage2.Controls.Add(this.textBoxUserAddArrayReturnInfo);
            this.tabPage2.Controls.Add(this.textBoxUserAddArrayReadonlyPassword);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBoxUserAddArrayMainPassword);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "userAddArray";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxUserAddArrayLength
            // 
            this.textBoxUserAddArrayLength.Location = new System.Drawing.Point(186, 169);
            this.textBoxUserAddArrayLength.Name = "textBoxUserAddArrayLength";
            this.textBoxUserAddArrayLength.Size = new System.Drawing.Size(183, 21);
            this.textBoxUserAddArrayLength.TabIndex = 18;
            this.textBoxUserAddArrayLength.Text = "3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(103, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 17;
            this.label19.Text = "ArrayLength";
            // 
            // textBoxUserAddArrayUserNameStartWords
            // 
            this.textBoxUserAddArrayUserNameStartWords.Location = new System.Drawing.Point(260, 20);
            this.textBoxUserAddArrayUserNameStartWords.Name = "textBoxUserAddArrayUserNameStartWords";
            this.textBoxUserAddArrayUserNameStartWords.Size = new System.Drawing.Size(241, 21);
            this.textBoxUserAddArrayUserNameStartWords.TabIndex = 16;
            this.textBoxUserAddArrayUserNameStartWords.Text = "批量测试用户";
            // 
            // textBoxUserAddArrayReturnInfo
            // 
            this.textBoxUserAddArrayReturnInfo.Location = new System.Drawing.Point(80, 214);
            this.textBoxUserAddArrayReturnInfo.Multiline = true;
            this.textBoxUserAddArrayReturnInfo.Name = "textBoxUserAddArrayReturnInfo";
            this.textBoxUserAddArrayReturnInfo.ReadOnly = true;
            this.textBoxUserAddArrayReturnInfo.Size = new System.Drawing.Size(455, 249);
            this.textBoxUserAddArrayReturnInfo.TabIndex = 15;
            // 
            // textBoxUserAddArrayReadonlyPassword
            // 
            this.textBoxUserAddArrayReadonlyPassword.Location = new System.Drawing.Point(200, 95);
            this.textBoxUserAddArrayReadonlyPassword.Name = "textBoxUserAddArrayReadonlyPassword";
            this.textBoxUserAddArrayReadonlyPassword.Size = new System.Drawing.Size(301, 21);
            this.textBoxUserAddArrayReadonlyPassword.TabIndex = 14;
            this.textBoxUserAddArrayReadonlyPassword.Text = "12345abcdeABCDE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "Readonly password";
            // 
            // textBoxUserAddArrayMainPassword
            // 
            this.textBoxUserAddArrayMainPassword.Location = new System.Drawing.Point(200, 56);
            this.textBoxUserAddArrayMainPassword.Name = "textBoxUserAddArrayMainPassword";
            this.textBoxUserAddArrayMainPassword.Size = new System.Drawing.Size(301, 21);
            this.textBoxUserAddArrayMainPassword.TabIndex = 12;
            this.textBoxUserAddArrayMainPassword.Text = "12345abcdeABCDE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(105, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "Main password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Do it!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(215, 12);
            this.label18.TabIndex = 9;
            this.label18.Text = "Want to add UserNameArrayStartWords";
            // 
            // textBoxUserAddLevelage
            // 
            this.textBoxUserAddLevelage.Location = new System.Drawing.Point(382, 132);
            this.textBoxUserAddLevelage.Name = "textBoxUserAddLevelage";
            this.textBoxUserAddLevelage.Size = new System.Drawing.Size(37, 21);
            this.textBoxUserAddLevelage.TabIndex = 12;
            this.textBoxUserAddLevelage.Text = "100";
            // 
            // textBoxUserAddArrayLevelage
            // 
            this.textBoxUserAddArrayLevelage.Location = new System.Drawing.Point(439, 132);
            this.textBoxUserAddArrayLevelage.Name = "textBoxUserAddArrayLevelage";
            this.textBoxUserAddArrayLevelage.Size = new System.Drawing.Size(37, 21);
            this.textBoxUserAddArrayLevelage.TabIndex = 22;
            this.textBoxUserAddArrayLevelage.Text = "100";
            // 
            // textBoxUserAddArrayGroup
            // 
            this.textBoxUserAddArrayGroup.Location = new System.Drawing.Point(144, 131);
            this.textBoxUserAddArrayGroup.Name = "textBoxUserAddArrayGroup";
            this.textBoxUserAddArrayGroup.Size = new System.Drawing.Size(230, 21);
            this.textBoxUserAddArrayGroup.TabIndex = 21;
            this.textBoxUserAddArrayGroup.Text = "demo\\demoforex";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(380, 135);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 20;
            this.label22.Text = "levelage";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(103, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 19;
            this.label23.Text = "group";
            // 
            // CBalanceExampleDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 539);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(label12);
            this.Controls.Add(this.m_List);
            this.Controls.Add(this.m_GetDeals);
            this.Controls.Add(label11);
            this.Controls.Add(this.m_To);
            this.Controls.Add(label10);
            this.Controls.Add(this.m_From);
            this.Controls.Add(this.m_Withdraw);
            this.Controls.Add(this.m_Deposit);
            this.Controls.Add(this.m_Comment);
            this.Controls.Add(label8);
            this.Controls.Add(this.m_Amount);
            this.Controls.Add(label9);
            this.Controls.Add(this.m_Operation);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.m_Balanceinfo);
            this.Controls.Add(this.m_Userinfo);
            this.Controls.Add(this.m_Getuser);
            this.Controls.Add(this.m_User);
            this.Controls.Add(label5);
            this.Controls.Add(this.m_Logout);
            this.Controls.Add(this.m_Login);
            this.Controls.Add(label4);
            this.Controls.Add(this.m_Password);
            this.Controls.Add(label3);
            this.Controls.Add(this.m_Loginname);
            this.Controls.Add(label2);
            this.Controls.Add(this.m_Server);
            this.Controls.Add(label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CBalanceExampleDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanceExample";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      private System.Windows.Forms.TextBox m_Server;
      private System.Windows.Forms.TextBox m_Loginname;
      private System.Windows.Forms.TextBox m_Password;
      private System.Windows.Forms.Button m_Login;
      private System.Windows.Forms.Button m_Logout;
      private System.Windows.Forms.Button m_Getuser;
      private System.Windows.Forms.TextBox m_User;
      private System.Windows.Forms.Label m_Userinfo;
      private System.Windows.Forms.Label m_Balanceinfo;
      private System.Windows.Forms.Button m_Withdraw;
      private System.Windows.Forms.TextBox m_Comment;
      private System.Windows.Forms.DateTimePicker m_From;
      private System.Windows.Forms.DateTimePicker m_To;
      private System.Windows.Forms.Button m_GetDeals;
      private System.Windows.Forms.ListView m_List;
      private System.Windows.Forms.ColumnHeader m_clTime;
      private System.Windows.Forms.ColumnHeader m_clDeal;
      private System.Windows.Forms.ColumnHeader m_clType;
      private System.Windows.Forms.ColumnHeader m_clAmount;
        private System.Windows.Forms.ComboBox m_Operation;
        private System.Windows.Forms.TextBox m_Amount;
        private System.Windows.Forms.Button m_Deposit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxUserAddMainPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxUserAddReadonlyPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxUserAddReturnInfo;
        private System.Windows.Forms.TextBox textBoxUserAddUserName;
        private System.Windows.Forms.TextBox textBoxUserAddArrayLength;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxUserAddArrayUserNameStartWords;
        private System.Windows.Forms.TextBox textBoxUserAddArrayReturnInfo;
        private System.Windows.Forms.TextBox textBoxUserAddArrayReadonlyPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxUserAddArrayMainPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxUserAddGroup;
        private System.Windows.Forms.TextBox textBoxUserAddLevelage;
        private System.Windows.Forms.TextBox textBoxUserAddArrayLevelage;
        private System.Windows.Forms.TextBox textBoxUserAddArrayGroup;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
  }
//+------------------------------------------------------------------+
