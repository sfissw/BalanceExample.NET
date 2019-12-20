//+------------------------------------------------------------------+
//|                        MetaTrader 5 API Manager for .NET Example |
//|                   Copyright 2001-2016, MetaQuotes Software Corp. |
//|                                        http://www.metaquotes.net |
//+------------------------------------------------------------------+
namespace BalanceExample.NET
{
    using MetaQuotes.MT5CommonAPI;
    using MetaQuotes.MT5ManagerAPI;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MT5Manager;
    //+------------------------------------------------------------------+
    //|                                                                  |
    //+------------------------------------------------------------------+
    public partial class CBalanceExampleDlg : Form
    {
        //+------------------------------------------------------------------+
        //| Operation combo helper                                           |
        //+------------------------------------------------------------------+
        class COperationType
        {
            public CIMTDeal.EnDealAction Value { get; set; }
            public string Name { get; set; }
            public override string ToString() { return (Name); }
        }
        //---
        CManager m_manager = null;
        string username = null;
        string password = null;
        string url = null;
        //+------------------------------------------------------------------+
        //| Constructor                                                      |
        //+------------------------------------------------------------------+
        public CBalanceExampleDlg()
        {
            InitializeComponent();
            m_manager = new CManager();
            var lists = new List<string>();
            using (FileStream fs = new FileStream(@"D:\MetaTrader5SDK\Examples\Manager\BalanceExample.NET\user.txt", FileMode.Open, FileAccess.Read))
            {
                using (TextReader tr = new StreamReader(fs, Encoding.Default))
                {
                    string line;
                    while ((line = tr.ReadLine()) != null)
                    {
                        lists.Add(line);
                    }
                }
            }
            url = lists[0];
            username = lists[1];
            password = lists[2];
            this.m_Server.Text = url;
            this.m_Loginname.Text = username;
            this.m_Password.Text = password;
            lists.Clear();
            lists = null;
        }
        //+------------------------------------------------------------------+
        //| GC destructor                                                    |
        //+------------------------------------------------------------------+
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                m_manager.Dispose();
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }
        //+------------------------------------------------------------------+
        //| Enable or disable controls                                       |
        //+------------------------------------------------------------------+
        void EnableControls(bool enable = true)
        {
            //--- update controls
            m_Loginname.Enabled = !enable;
            m_Server.Enabled = !enable;
            m_Password.Enabled = !enable;
            m_Logout.Enabled = enable;
            m_Login.Enabled = !enable;
            m_User.Enabled = enable;
            m_Getuser.Enabled = enable;
            m_Withdraw.Enabled = enable;
            m_Amount.Enabled = enable;
            m_Deposit.Enabled = enable;
            m_Comment.Enabled = enable;
            m_Operation.Enabled = enable;
            m_GetDeals.Enabled = enable;
            m_From.Enabled = enable;
            m_To.Enabled = enable;
            m_List.Enabled = enable;
            //--- update buttons
            UpdateButtons();
        }
        //+------------------------------------------------------------------+
        //| Enable or disable buttons                                        |
        //+------------------------------------------------------------------+
        void UpdateButtons()
        {
            bool enable = (m_Comment.Text.Length > 0 && m_Amount.Text.Length > 0);
            //--- update buttons
            m_Deposit.Enabled = enable;
            m_Withdraw.Enabled = enable;
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnLoad(object sender, EventArgs e)
        {
            //--- disable controls
            EnableControls(false);
            //--- initialize manager api
            if (!m_manager.Initialize())
            {
                Close();
                return;
            }
            //--- initialize combo box operation
            m_Operation.Items.Add(new COperationType() { Value = CIMTDeal.EnDealAction.DEAL_BALANCE, Name = "Balance" });
            m_Operation.Items.Add(new COperationType() { Value = CIMTDeal.EnDealAction.DEAL_CREDIT, Name = "Credit" });
            m_Operation.Items.Add(new COperationType() { Value = CIMTDeal.EnDealAction.DEAL_CHARGE, Name = "Charge" });
            m_Operation.Items.Add(new COperationType() { Value = CIMTDeal.EnDealAction.DEAL_CORRECTION, Name = "Correction" });
            m_Operation.Items.Add(new COperationType() { Value = CIMTDeal.EnDealAction.DEAL_BONUS, Name = "Bonus" });
            m_Operation.Items.Add(new COperationType() { Value = CIMTDeal.EnDealAction.DEAL_COMMISSION, Name = "Commission" });
            //--- setup current operation
            OperationType = CIMTDeal.EnDealAction.DEAL_BALANCE;
            //---
            DateTime from = DateTime.Now - TimeSpan.FromDays(1);
            m_From.Value = from;
            //---
        }
        //+------------------------------------------------------------------+
        //| Operation type accessor                                          |
        //+------------------------------------------------------------------+
        CIMTDeal.EnDealAction OperationType
        {
            get
            {
                COperationType opt = m_Operation.SelectedItem as COperationType;
                int fault = ((int)CIMTDeal.EnDealAction.DEAL_LAST) + 1;
                return (opt != null ? opt.Value : (CIMTDeal.EnDealAction)fault);
            }
            set
            {
                m_Operation.SelectedItem = m_Operation.Items.Cast<COperationType>().Where(it => it.Value == value).First();
            }
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnBnClickedLogin(object sender = null, EventArgs e = null)
        {
            UInt64 login = 0;
            UInt64.TryParse(m_Loginname.Text, out login);
            //--- manager login
            if (!m_manager.Login(m_Server.Text, login, m_Password.Text))
            {
                MessageBox.Show("Login fail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Login success", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //--- enable controls
            EnableControls();
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnBnClickedLogout(object sender = null, EventArgs e = null)
        {
            m_manager.Logout();
            //--- disable controls
            EnableControls(false);
            //--- clear list
            m_List.Items.Clear();
            //--- clear user info
            m_Userinfo.Text = string.Empty;
            m_Balanceinfo.Text = string.Empty;
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnBnClickedGetUser(object sender = null, EventArgs e = null)
        {
            UInt64 login = 0;
            UInt64.TryParse(m_User.Text, out login);
            //---
            string str;
            //--- set user info
            if (m_manager.GetUserInfo(login, out str))
                m_Userinfo.Text = str;
            else
                m_Userinfo.Text = string.Empty;
            //--- set account info
            if (m_manager.GetAccountInfo(login, out str))
                m_Balanceinfo.Text = str;
            else
                m_Balanceinfo.Text = string.Empty;
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnBnClickedButtonDeposit(object sender = null, EventArgs e = null)
        {
            UInt64 login = 0;
            double amount = 0;
            uint type = 0;
            //---
            UInt64.TryParse(m_User.Text, out login);
            double.TryParse(m_Amount.Text, out amount);
            type = (uint)OperationType;
            //--- dealer operation
            if (!m_manager.DealerBalance(login, amount, type, m_Comment.Text, true))
            {
                MessageBox.Show("Deposit fail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //--- clear list
                m_List.Items.Clear();
                return;
            }
            //--- update list
            OnBnClickedButtonGetdeals();
            //---
            MessageBox.Show("Deposit successful", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnBnClickedButtonWithdrawal(object sender = null, EventArgs e = null)
        {
            UInt64 login;
            double amount;
            uint type;
            //---
            UInt64.TryParse(m_User.Text, out login);
            double.TryParse(m_Amount.Text, out amount);
            type = (uint)OperationType;
            //--- dealer operation
            if (!m_manager.DealerBalance(login, amount, type, m_Comment.Text, false))
            {
                MessageBox.Show("Withdrawal fail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //--- clear list
                m_List.Items.Clear();
                return;
            }
            //--- update list
            OnBnClickedButtonGetdeals();
            //---
            MessageBox.Show("Withdrawal successful", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnBnClickedButtonGetdeals(object sender = null, EventArgs e = null)
        {
            CIMTDealArray deal_array = null;
            CIMTDeal deal = null;
            UInt64 login = 0;
            DateTime from = m_From.Value;
            DateTime to = m_To.Value;
            string stype = string.Empty;
            //--- user login
            UInt64.TryParse(m_User.Text, out login);
            //--- get deal array
            if (!m_manager.GetUserDeal(out deal_array, login, from, to))
            {
                //--- clear list
                m_List.Items.Clear();
                //---
                MessageBox.Show("Get user deal fail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //--- clear list
            m_List.Items.Clear();
            //--- for all deal in array
            for (uint i = 0; i < deal_array.Total(); i++)
            {
                //--- get deal
                deal = deal_array.Next(i);
                //--- check error
                if (deal == null) break;
                //--- check action
                switch ((CIMTDeal.EnDealAction)deal.Action())
                {
                    case CIMTDeal.EnDealAction.DEAL_BALANCE:
                        stype = "Balance";
                        break;
                    case CIMTDeal.EnDealAction.DEAL_CREDIT:
                        stype = "Credit";
                        break;
                    case CIMTDeal.EnDealAction.DEAL_CHARGE:
                        stype = "Charge";
                        break;
                    case CIMTDeal.EnDealAction.DEAL_CORRECTION:
                        stype = "Correction";
                        break;
                    case CIMTDeal.EnDealAction.DEAL_BONUS:
                        stype = "Bonus";
                        break;
                    case CIMTDeal.EnDealAction.DEAL_COMMISSION:
                        stype = "Commission";
                        break;
                    default:
                        //--- skip other actions
                        continue;
                }
                //---
                string stime = SMTTime.ToDateTime(deal.Time()).ToString("yyyy.MM.dd HH:mm:ss.fff");
                //--- insert item
                string[] row = { deal.Deal().ToString(), stype, deal.Profit().ToString() };
                var it = m_List.Items.Insert(0, stime);
                it.SubItems.AddRange(row);
                m_List.EnsureVisible(0);
                m_List.Update();
            }
        }
        //+------------------------------------------------------------------+
        //|                                                                  |
        //+------------------------------------------------------------------+
        private void OnEnChangeEditCommentOrAmount(object sender = null, EventArgs e = null)
        {
            UpdateButtons();
        }

        private void UserAddMin_Click(object sender, EventArgs e)
        {
            string userName = this.textBoxUserAddUserName.Text.Trim();
            if (userName == string.Empty)
            {
                userName = null;
            }
            string group = this.textBoxUserAddGroup.Text.Trim();
            uint levelage = uint.Parse(this.textBoxUserAddLevelage.Text.Trim());
            string mainPassword = this.textBoxUserAddMainPassword.Text.Trim();
            string readonlyPassword = this.textBoxUserAddReadonlyPassword.Text.Trim();
            this.textBoxUserAddReturnInfo.Text =
                this.m_manager

                .UserAdd(
                group,
                levelage,
                mainPassword,
                readonlyPassword,
                userName
                )

                .ToString();
        }

        private void UserAddArray_Click(object sender, EventArgs e)
        {
            string userArrayNameStartWords = this.textBoxUserAddArrayUserNameStartWords.Text.Trim();
            if (userArrayNameStartWords == string.Empty)
            {
                userArrayNameStartWords = null;
            }
            this.textBoxUserAddArrayReturnInfo.Text = string.Empty;
            uint userAddArrayLength = uint.Parse(this.textBoxUserAddArrayLength.Text.Trim());
            string userAddArrayGroup = this.textBoxUserAddArrayGroup.Text.Trim();
            uint userAddArrayLevelage = uint.Parse(this.textBoxUserAddArrayLevelage.Text.Trim());
            string userAddArrayMainPassword = this.textBoxUserAddArrayMainPassword.Text.Trim();
            string userAddArrayReadonlyPassword = this.textBoxUserAddArrayReadonlyPassword.Text.Trim();
            foreach (string s in this.m_manager

                .UserAddArray(
                userAddArrayLength,
                userAddArrayGroup,
                userAddArrayLevelage,
                userAddArrayMainPassword,
                userAddArrayReadonlyPassword,
                userArrayNameStartWords
                )

                )
            {
                this.textBoxUserAddArrayReturnInfo.Text += (s + System.Environment.NewLine);
            }
        }

        private void UserDelete_Click(object sender, EventArgs e)
        {
            ulong loginID = ulong.Parse(this.textBoxUserDeleteLoginID.Text.Trim());
            this.textBoxUserDeleteReturnInfo.Text = this.m_manager

                .UserDelete(loginID)

                .ToString();
        }

        private void UserAddMax_Click(object sender, EventArgs e)
        {
            string userAddGroup = this.textBoxUserAddGroup.Text.Trim();
            userAddGroup = userAddGroup == string.Empty ? null : userAddGroup;
            uint userAddLevelage = uint.Parse(this.textBoxUserAddLevelage.Text.Trim());
            string userAddMainPassword = this.textBoxUserAddMainPassword.Text.Trim();
            userAddMainPassword = userAddMainPassword == string.Empty ? null : userAddMainPassword;
            string userAddReadonlyPassword = this.textBoxUserAddReadonlyPassword.Text.Trim();
            userAddReadonlyPassword = userAddReadonlyPassword == string.Empty ? null : userAddReadonlyPassword;
            //ulong loginID=this.textBoxUserAddLoginID.Text.Trim() == string.Empty ? (ulong?)(null) : (ulong?)(ulong.Parse(this.textBoxUserAddLoginID.Text.Trim())),
            //    this.textBoxUserAddRights.Text.Trim() == string.Empty ? (CIMTUser.EnUsersRights?)null : (CIMTUser.EnUsersRights?)(CIMTUser.EnUsersRights)Enum.Parse(typeof(CIMTUser.EnUsersRights), this.textBoxUserAddRights.Text.Trim()),
            //    this.textBoxUserAddCompany.Text.Trim() == string.Empty ? null : this.textBoxUserAddCompany.Text.Trim(),
            //    this.textBoxUserAddAccount.Text.Trim() == string.Empty ? null : this.textBoxUserAddAccount.Text.Trim(),
            //    this.textBoxUserAddCountry.Text.Trim() == string.Empty ? null : this.textBoxUserAddCountry.Text.Trim(),
            //    this.textBoxUserAddLanguage.Text.Trim() == string.Empty ? (uint?)(null) : (uint?)(uint.Parse(this.textBoxUserAddLanguage.Text.Trim())),
            //    this.textBoxUserAddCity.Text.Trim() == string.Empty ? null : this.textBoxUserAddCity.Text.Trim(),
            //    this.textBoxUserAddState.Text.Trim() == string.Empty ? null : this.textBoxUserAddState.Text.Trim(),
            //    this.textBoxUserAddZIPCode.Text.Trim() == string.Empty ? null : this.textBoxUserAddZIPCode.Text.Trim(),
            //    this.textBoxUserAddAddress.Text.Trim() == string.Empty ? null : this.textBoxUserAddAddress.Text.Trim(),
            //    this.textBoxUserAddPhone.Text.Trim() == string.Empty ? null : this.textBoxUserAddPhone.Text.Trim(),
            //    this.textBoxUserAddEMail.Text.Trim() == string.Empty ? null : this.textBoxUserAddEMail.Text.Trim(),
            //    this.textBoxUserAddID.Text.Trim() == string.Empty ? null : this.textBoxUserAddID.Text.Trim(),
            //    this.textBoxUserAddStatus.Text.Trim() == string.Empty ? null : this.textBoxUserAddStatus.Text.Trim(),
            //    this.textBoxUserAddComment.Text.Trim() == string.Empty ? null : this.textBoxUserAddComment.Text.Trim(),
            //    this.textBoxUserAddColor.Text.Trim() == string.Empty ? (uint?)(null) : (uint?)(uint.Parse(this.textBoxUserAddColor.Text.Trim())),
            //    this.textBoxUserAddPhonePassword.Text.Trim() == string.Empty ? null : this.textBoxUserAddPhonePassword.Text.Trim(),
            //    this.textBoxUserAddAgent.Text.Trim() == string.Empty ? (ulong?)(null) : (ulong?)(ulong.Parse(this.textBoxUserAddAgent.Text.Trim())),
            //    this.textBoxUserAddLeadSource.Text.Trim() == string.Empty ? null : this.textBoxUserAddLeadSource.Text.Trim(),
            //    this.textBoxUserAddLeadCampaign.Text.Trim() == string.Empty ? null : this.textBoxUserAddLeadCampaign.Text.Trim(),
            //    this.textBoxUserAddApp_id.Text.Trim() == string.Empty ? (ushort?)(null) : (ushort?)(ushort.Parse(this.textBoxUserAddApp_id.Text.Trim())),
            //    this.textBoxUserAddIdApp.Text.Trim() == string.Empty ? (byte?)(null) : (byte?)(byte.Parse(this.textBoxUserAddIdApp.Text.Trim())),
            //    this.textBoxUserAddValueLong.Text.Trim() == string.Empty ? (long?)(null) : (long?)(long.Parse(this.textBoxUserAddValueLong.Text.Trim())),
            //    this.textBoxUserAddValueUlong.Text.Trim() == string.Empty ? (ulong?)(null) : (ulong?)(ulong.Parse(this.textBoxUserAddValueUlong.Text.Trim())),
            //    this.textBoxUserAddValueDouble.Text.Trim() == string.Empty ? (double?)(null) : (double?)(double.Parse(this.textBoxUserAddValueDouble.Text.Trim()))

            this.textBoxUserAddReturnInfo.Text = this.m_manager.UserAdd(
                this.textBoxUserAddGroup.Text.Trim(),
                uint.Parse(this.textBoxUserAddLevelage.Text.Trim()),
                this.textBoxUserAddMainPassword.Text.Trim(),
                this.textBoxUserAddReadonlyPassword.Text.Trim(),
                this.textBoxUserAddUserName.Text.Trim() == string.Empty ? null : this.textBoxUserAddUserName.Text.Trim(),
                this.textBoxUserAddLoginID.Text.Trim() == string.Empty ? (ulong?)(null) : (ulong?)(ulong.Parse(this.textBoxUserAddLoginID.Text.Trim())),
                this.textBoxUserAddRights.Text.Trim() == string.Empty ? (CIMTUser.EnUsersRights?)null : (CIMTUser.EnUsersRights?)(CIMTUser.EnUsersRights)Enum.Parse(typeof(CIMTUser.EnUsersRights), this.textBoxUserAddRights.Text.Trim()),
                this.textBoxUserAddCompany.Text.Trim() == string.Empty ? null : this.textBoxUserAddCompany.Text.Trim(),
                this.textBoxUserAddAccount.Text.Trim() == string.Empty ? null : this.textBoxUserAddAccount.Text.Trim(),
                this.textBoxUserAddCountry.Text.Trim() == string.Empty ? null : this.textBoxUserAddCountry.Text.Trim(),
                this.textBoxUserAddLanguage.Text.Trim() == string.Empty ? (uint?)(null) : (uint?)(uint.Parse(this.textBoxUserAddLanguage.Text.Trim())),
                this.textBoxUserAddCity.Text.Trim() == string.Empty ? null : this.textBoxUserAddCity.Text.Trim(),
                this.textBoxUserAddState.Text.Trim() == string.Empty ? null : this.textBoxUserAddState.Text.Trim(),
                this.textBoxUserAddZIPCode.Text.Trim() == string.Empty ? null : this.textBoxUserAddZIPCode.Text.Trim(),
                this.textBoxUserAddAddress.Text.Trim() == string.Empty ? null : this.textBoxUserAddAddress.Text.Trim(),
                this.textBoxUserAddPhone.Text.Trim() == string.Empty ? null : this.textBoxUserAddPhone.Text.Trim(),
                this.textBoxUserAddEMail.Text.Trim() == string.Empty ? null : this.textBoxUserAddEMail.Text.Trim(),
                this.textBoxUserAddID.Text.Trim() == string.Empty ? null : this.textBoxUserAddID.Text.Trim(),
                this.textBoxUserAddStatus.Text.Trim() == string.Empty ? null : this.textBoxUserAddStatus.Text.Trim(),
                this.textBoxUserAddComment.Text.Trim() == string.Empty ? null : this.textBoxUserAddComment.Text.Trim(),
                this.textBoxUserAddColor.Text.Trim() == string.Empty ? (uint?)(null) : (uint?)(uint.Parse(this.textBoxUserAddColor.Text.Trim())),
                this.textBoxUserAddPhonePassword.Text.Trim() == string.Empty ? null : this.textBoxUserAddPhonePassword.Text.Trim(),
                this.textBoxUserAddAgent.Text.Trim() == string.Empty ? (ulong?)(null) : (ulong?)(ulong.Parse(this.textBoxUserAddAgent.Text.Trim())),
                this.textBoxUserAddLeadSource.Text.Trim() == string.Empty ? null : this.textBoxUserAddLeadSource.Text.Trim(),
                this.textBoxUserAddLeadCampaign.Text.Trim() == string.Empty ? null : this.textBoxUserAddLeadCampaign.Text.Trim(),
                this.textBoxUserAddApp_id.Text.Trim() == string.Empty ? (ushort?)(null) : (ushort?)(ushort.Parse(this.textBoxUserAddApp_id.Text.Trim())),
                this.textBoxUserAddIdApp.Text.Trim() == string.Empty ? (byte?)(null) : (byte?)(byte.Parse(this.textBoxUserAddIdApp.Text.Trim())),
                this.textBoxUserAddValueLong.Text.Trim() == string.Empty ? (long?)(null) : (long?)(long.Parse(this.textBoxUserAddValueLong.Text.Trim())),
                this.textBoxUserAddValueUlong.Text.Trim() == string.Empty ? (ulong?)(null) : (ulong?)(ulong.Parse(this.textBoxUserAddValueUlong.Text.Trim())),
                this.textBoxUserAddValueDouble.Text.Trim() == string.Empty ? (double?)(null) : (double?)(double.Parse(this.textBoxUserAddValueDouble.Text.Trim()))
                ).ToString();
        }

        private void UserRequest_Click(object sender, EventArgs e)
        {
            ulong loginID = ulong.Parse(this.textBoxUserRequestLoginID.Text.Trim());
            CManager.UserRequestReturnValue returnValue =
                this.m_manager

                .UserRequest(loginID);

            if (returnValue.mtRetCode == MTRetCode.MT_RET_OK || returnValue.mtRetCode == MTRetCode.MT_RET_OK_NONE)
            {
                this.textBoxUserRequestReturnInfo.Text = returnValue.cIMTUserJson;
            }
            else
            {
                this.textBoxUserRequestReturnInfo.Text = returnValue.mtRetCode.ToString();
            }
        }

        private void UserUpdatMin_Click(object sender, EventArgs e)
        {

        }

        private void UserUpdatMax_Click(object sender, EventArgs e)
        {

        }

        private void UserPasswordCheck_Click(object sender, EventArgs e)
        {
            CIMTUser.EnUsersPasswords userPasswordCheckType = (CIMTUser.EnUsersPasswords)Enum.Parse(typeof(CIMTUser.EnUsersPasswords), this.textBoxUserPasswordCheckType.Text.Trim());
            ulong userPasswordCheckLoginID = ulong.Parse(this.textBoxUserPasswordCheckLoginID.Text.Trim());
            string userPasswordCheckPassword = this.textBoxUserPasswordCheckPassword.Text.Trim();
            this.textBoxUserPasswordCheckReturnInfo.Text =
                this.m_manager

                .UserPasswordCheck(
                userPasswordCheckType,
                userPasswordCheckLoginID,
                userPasswordCheckPassword
                )

                .ToString();
        }
    }
}
//+------------------------------------------------------------------+
