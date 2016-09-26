using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using order.controller;
using order.Entity;
namespace order.view
{
    public partial class Main : Form
    {
        private MainController maincontroller;
        private DataSet userInfodata;
        private DataSet orderInfodata;
        private DataSet goodsInfodata;
        private bool orderInfoListHasButton;
        private bool goodsInfoListHasButton;
        private List<DataRow> chooseMap;

        public Main()
        {
            InitializeComponent();
            orderInfoListHasButton = false;
            goodsInfoListHasButton = false;
            chooseMap = new List<DataRow>();
            this.goodsCalcute.SelectedIndex = 0;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Formeing);
        }
        //读取用户信息列表
        private void reloadUserInfoResultList()
        {
            //加载默认的会员信息列表
            maincontroller = new MainController(this);
            userInfodata = maincontroller.selectUserInfoList(userInfoName.Text, userInfoPhone.Text);
            userInfoGrid.DataSource = userInfodata.Tables[0];
        }
        //读取交易信息列表
        private void reloadBusinessResuletList()
        {
            DateTime startBusinesstime = startTime.Value;
            DateTime endBusinessTime = endTime.Value;
            string orderId = businessId.Text;
            bool isLoadTime = isInTime.Checked;
            string receiverName = this.receiverName.Text;
            orderInfodata = maincontroller.selectBusinessRecordList(receiverName, orderId, startBusinesstime, endBusinessTime, isLoadTime);
            orderGridView.DataSource = orderInfodata.Tables[0];
        }
        //读取商品信息列表
        private void reloadGoodsInfoList()
        {
            string goodsId = this.goodId.Text;
            string goodsName = this.goodsName.Text;
            goodsInfodata = maincontroller.selectGoodInfoList(goodsId, goodsName);
            goodsInfoGridView.DataSource = goodsInfodata.Tables[0];
        }
        private void Main_Load(object sender, EventArgs e)
        {
            reloadUserInfoResultList();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "userInfoedit";
            button.HeaderText = "编辑详情";
            button.UseColumnTextForButtonValue = true;
            button.Text = "编辑";
            this.userInfoGrid.Columns.AddRange(button);
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.Name = "userInfodelete";
            delete.HeaderText = "删除记录";
            delete.UseColumnTextForButtonValue = true;
            delete.Text = "删除";
            this.userInfoGrid.Columns.AddRange(delete);
            DataGridViewButtonColumn selectThisUser = new DataGridViewButtonColumn();
            selectThisUser.Name = "selectUserInfo";
            selectThisUser.HeaderText = "会员交易记录";
            selectThisUser.UseColumnTextForButtonValue = true;
            selectThisUser.Text = "查看";
            this.userInfoGrid.Columns.AddRange(selectThisUser);
        }

        private void userInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userInfoGrid.Columns[e.ColumnIndex].Name == "userInfoedit")
            {
                DataRow row = userInfodata.Tables[0].Rows[e.RowIndex];
                UserInfoEntity.userId = (string)row[0];
                UserInfoEntity.userName = (string)row[1];
                UserInfoEntity.userSex = (string)row[2];
                UserInfoEntity.userPhone = (string)row[3];
                UserInfoEntity.userAddress = (string)row[4];
                UserInfoEntity.userWechat = (string)row[5];
                new UserInfoEdit().Show();
            }
            if (userInfoGrid.Columns[e.ColumnIndex].Name == "userInfodelete")
            {
                DataRow row = userInfodata.Tables[0].Rows[e.RowIndex];
                UserInfoEntity.userId = (string)row[0];
                new EditUserInfo().deleteUserInfo();
            }
            if (userInfoGrid.Columns[e.ColumnIndex].Name == "selectUserInfo")
            {
                this.mainWindow.SelectTab("businessRecord");
                DataRow row = userInfodata.Tables[0].Rows[e.RowIndex];
                string userName = (string)row[1];
                this.receiverName.Text = userName;
                reloadBusinessResuletList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserInfoEdit().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reloadUserInfoResultList();
        }

        private void userInfoName_TextChanged(object sender, EventArgs e)
        {
            reloadUserInfoResultList();
        }

        private void userInfoPhone_TextChanged(object sender, EventArgs e)
        {
            reloadUserInfoResultList();
        }

        private void select_Click(object sender, EventArgs e)
        {
            reloadBusinessResuletList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reloadGoodsInfoList();
            new BusinessRecordEdit(goodsInfodata).Show();
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.mainWindow.SelectedTab.Name.Equals("businessRecord"))
            {
                reloadBusinessResuletList();
                if (!orderInfoListHasButton)
                {
                    DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                    button.Name = "orderInfoedit";
                    button.HeaderText = "编辑详情";
                    button.UseColumnTextForButtonValue = true;
                    button.Text = "编辑";
                    this.orderGridView.Columns.AddRange(button);
                    DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                    delete.Name = "orderInfodelete";
                    delete.HeaderText = "删除记录";
                    delete.UseColumnTextForButtonValue = true;
                    delete.Text = "删除";
                    this.orderGridView.Columns.AddRange(delete);
                    DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
                    checkBox.Name = "orderChecked";
                    checkBox.HeaderText = "选择";
                    this.orderGridView.Columns.AddRange(checkBox);
                    //DataGridViewButtonColumn printOutPut = new DataGridViewButtonColumn();
                    //printOutPut.Name = "printOutPut";
                    //printOutPut.HeaderText = "打印";
                    //printOutPut.UseColumnTextForButtonValue = true;
                    //printOutPut.Text = "打印出货单";
                    //this.orderGridView.Columns.AddRange(printOutPut);
                    //DataGridViewButtonColumn printExpress = new DataGridViewButtonColumn();
                    //printExpress.Name = "printExpress";
                    //printExpress.HeaderText = "打印";
                    //printExpress.UseColumnTextForButtonValue = true;
                    //printExpress.Text = "打印快递单";
                    //this.orderGridView.Columns.AddRange(printExpress);
                }
            }
            else if (this.mainWindow.SelectedTab.Name.Equals("goodsInfo"))
            {
                reloadGoodsInfoList();
                if (!goodsInfoListHasButton)
                {
                    DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                    button.Name = "goodsInfoedit";
                    button.HeaderText = "编辑详情";
                    button.UseColumnTextForButtonValue = true;
                    button.Text = "编辑";
                    this.goodsInfoGridView.Columns.AddRange(button);
                    DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                    delete.Name = "goodsInfodelete";
                    delete.HeaderText = "删除记录";
                    delete.UseColumnTextForButtonValue = true;
                    delete.Text = "删除";
                    this.goodsInfoGridView.Columns.AddRange(delete);
                    goodsInfoListHasButton = true;
                }
            }
        }

        private void businessId_TextChanged(object sender, EventArgs e)
        {
            reloadBusinessResuletList();
        }

        private void businessRecord_Click(object sender, EventArgs e)
        {
            reloadBusinessResuletList();
        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderGridView.Columns[e.ColumnIndex].Name == "orderInfoedit")
            {
                DataRow row = orderInfodata.Tables[0].Rows[e.RowIndex];
                saveValueIntoEntity(row);
                new BusinessRecordEdit().Show();
            }
            if (orderGridView.Columns[e.ColumnIndex].Name == "orderInfodelete")
            {
                DataRow row = orderInfodata.Tables[0].Rows[e.RowIndex];
                BusinessInfoEntity.orderId = (string)row[0];
                new EditBusinessInfo().deleteOrderRecord();
            }
            if (orderGridView.Columns[e.ColumnIndex].Name == "orderChecked")
            {
                DataRow row = orderInfodata.Tables[0].Rows[e.RowIndex];
                if (chooseMap.Contains(row))
                {
                    chooseMap.Remove(row);
                }
                else
                {
                    chooseMap.Add(row);
                }
            }
        }
        private void saveValueIntoEntity(DataRow row)
        {
            BusinessInfoEntity.orderId = (string)row[0];
            BusinessInfoEntity.status = (string)row[1];
            BusinessInfoEntity.goodsName = (string)row[2];
            BusinessInfoEntity.price = (string)row[3];
            BusinessInfoEntity.orderAmount = (string)row[4];
            BusinessInfoEntity.receiveAdress = (string)row[5];
            BusinessInfoEntity.receiverName = (string)row[6];
            BusinessInfoEntity.receiverPhone = (string)row[7];
            BusinessInfoEntity.sendAdress = (string)row[8];
            BusinessInfoEntity.senderName = (string)row[9];
            BusinessInfoEntity.senderPhone = (string)row[10];
            BusinessInfoEntity.exchangeTime = Convert.ToDateTime((string)row[11]);
            BusinessInfoEntity.orderOperator = (string)row[12];
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //将map中的元素的状态设置为已读
            List<string> chooseList = new List<string>();
            foreach (DataRow ite in chooseMap)
            {
                chooseList.Add((string)ite[0]);
            }
            new EditBusinessInfo().setListStatus(chooseList);
            chooseMap.Clear();
            reloadBusinessResuletList();
        }

        private void goodsInfo_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            reloadGoodsInfoList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            reloadGoodsInfoList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            reloadGoodsInfoList();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new BusinessInfoEdit().Show();
        }

        private void goodsInfoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (goodsInfoGridView.Columns[e.ColumnIndex].Name == "goodsInfoedit")
            {
                DataRow row = goodsInfodata.Tables[0].Rows[e.RowIndex];
                GoodsInfoEntity.goodsId = (string)row[0];
                GoodsInfoEntity.goodsName = (string)row[1];
                GoodsInfoEntity.goodsPrice = (string)row[2];
                GoodsInfoEntity.goodsVipPrice = (string)row[3];
                GoodsInfoEntity.goodsAmount = (string)row[4];
                new BusinessInfoEdit().Show();
            }
            if (goodsInfoGridView.Columns[e.ColumnIndex].Name == "goodsInfodelete")
            {
                DataRow row = goodsInfodata.Tables[0].Rows[e.RowIndex];
                GoodsInfoEntity.goodsId = (string)row[0];
                new EditGoodsInfocs().deleteGoodsInfo();
            }
        }

        private void userInfo_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Formeing(object sender, FormClosingEventArgs e)
        {
            LoginWindow.getInstance().Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            reloadBusinessResuletList();
        }

        private void receiverName_TextChanged(object sender, EventArgs e)
        {
            reloadBusinessResuletList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> chooseList = new List<string>();
            //remove reduce module
            foreach (DataRow ite in chooseMap)
            {
                if (!new EditGoodsInfocs().reduceGoodsAmount((string)ite[2]))
                {
                    return;
                }
            }
            new OutBussiness(chooseMap).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new OutBussiness(chooseMap).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new  OutGoodsCalcute(new GoodsCalculate().selectGoodsInfo(this.goodsCalcute.SelectedIndex),this.goodsCalcute.SelectedIndex).Show();
        }

    }
}
