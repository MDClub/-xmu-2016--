using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManageSystem.BLL;
using BookManageSystem.Model;
using BookManageSystem.Common;

namespace BookManageSystem
{
    public partial class frmBorrowReturnMana : Form
    {
        private bool IsExistLendInfo = false;//标记是否存在此入住信息

        public frmBorrowReturnMana()
        {
            InitializeComponent();
        }

        //绑定客户编号列表到控件
        public void ReadersComboxBinding()
        {
            cbReader.Items.Clear();
            CtbReaderInformationBLL cReaderBll = new CtbReaderInformationBLL();
            List<CtbReaderInformation> cReaders = cReaderBll.GetModelList("readerID>0");
            foreach (CtbReaderInformation cr in cReaders)
            {
                cbReader.Items.Add(cr.readerID);
                cbGReaderID.Items.Add(cr.readerID);
            }
        }

        //绑定客房编号列表到控件
        public void BooksComboxBinding()
        {
            cbBook.Items.Clear();
            CtbBookInformationBLL cBookBll = new CtbBookInformationBLL();
            List<CtbBookInformation> cBooks = cBookBll.GetModelList("bookID>0");
            foreach (CtbBookInformation cb in cBooks)
            {
                cbBook.Items.Add(cb.bookID);
                cbGBookID.Items.Add(cb.bookID);
                
            }
        }

        private void cbReader_TextChanged(object sender, EventArgs e)
        {
            CtbReaderInformationBLL cReaderBll = new CtbReaderInformationBLL();
            CtbReaderInformation creader = cReaderBll.GetModel(int.Parse(cbReader.Text));
            if (creader != null)
            {
                lbRname.Visible = true;
                lbRname1.Visible = true;
                lbRname1.Text = creader.readerName;
            }
        }

        private void cbBook_TextChanged(object sender, EventArgs e)
        {
            CtbBookInformationBLL cBookBll = new CtbBookInformationBLL();
            CtbBookInformation cBook = cBookBll.GetModel(int.Parse(cbBook.Text));
            if (cBook != null)
            {
                lbBname.Visible = true;
                lbBname1.Visible = true;
                lbBname1.Text = cBook.bookName;

                //同时显示客房实际数
                lbTrueNum.Visible = true;
                lbTrueName1.Visible = true;
                lbTrueName1.Text = cBook.bookRealNum.ToString();
            }
        }

        //在窗体加载事件中载入列表
        private void frmBorrowReturnMana_Load(object sender, EventArgs e)
        {
            ReadersComboxBinding();
            BooksComboxBinding();

            //将应还客房日期定在1天后
            DateTime dt = dtkBorrowDate.Value;
            dt = dt.AddDays(1);
            dtkYReturnDate.Value = dt;

            //权限读取与设置
            char[] openOrclose = Session.UserPurview.ToCharArray();
            if (!CCharToBool.CharToBool(openOrclose[16]))
            {
                this.tabControl1.TabPages.Remove(tabBorrow);
            }
            if (!CCharToBool.CharToBool(openOrclose[17]))
            {
                this.tabControl1.TabPages.Remove(tabReturn);
            }
        }

        //入住按钮事件
        private void btEnter_Click(object sender, EventArgs e)
        {
            //首先判断是否存在已经入住了此本客房的情况
            if (cbReader.Text != "" && cbBook.Text != "")
            {
                CtbLend cLend = new CtbLend();
                CtbLendBLL cLendBll = new CtbLendBLL();
                int readerID = int.Parse(cbReader.Text);
                int bookID = int.Parse(cbBook.Text);
                string sql = "bookID=" + bookID + " and readerID=" + readerID+" and lendNum>0";
                if (cLendBll.GetModelList(sql).Count > 0)
                {
                    MessageBox.Show("该客户已经入住了此本客房.请先退还现有数目！", "操作提示");
                    return;
                }
                else
                {
                    if (tbLendNum.Text != "")
                    {
                        int lendNum = 0;
                        try
                        {
                            lendNum = int.Parse(tbLendNum.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("输入的数量不正确,请确定格式正确。详细异常信息：\n" + ex.Message, "出现异常");
                            return;
                        }
                        if (lendNum > int.Parse(lbTrueName1.Text))
                        {
                            MessageBox.Show("入住数量不应该大于实际客房数量", "出现异常");
                            return;
                        }
                        CtbLendBLL lendBll = new CtbLendBLL();
                        CtbLend lend = new CtbLend();
                        lend.readerID = int.Parse(cbReader.Text);
                        lend.bookID = int.Parse(cbBook.Text);
                        lend.lendDate = dtkBorrowDate.Value;
                        lend.lendYDate = dtkYReturnDate.Value;
                        lend.lendSDate = null;
                        lend.lendNum = int.Parse(tbLendNum.Text);

                        CtbBookInformation cBook = new CtbBookInformation();
                        CtbBookInformationBLL cBookBll = new CtbBookInformationBLL();
                        cBook = cBookBll.GetModel(lend.bookID);
                        cBook.bookLendNum = cBook.bookLendNum + lend.lendNum;
                        cBookBll.Update(cBook);

                        lendBll.Add(lend);
                        MessageBox.Show("添加入住信息成功！", "操作提示");
                    }
                    else
                    {
                        MessageBox.Show("入住数量不能为空", "出现异常");
                        return;
                    }
                }
            }


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查询
        /// </summary>
        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbGReaderID.Text != "" && cbGBookID.Text != "")
            {
                CtbLend cLend = new CtbLend();
                CtbLendBLL cLendBll = new CtbLendBLL();
                int readerID = int.Parse(cbGReaderID.Text);
                int bookID = int.Parse(cbGBookID.Text);
                string sql = "bookID=" + bookID + " and readerID=" + readerID+" and lendNum>0" ;
                if (cLendBll.GetModelList(sql).Count > 0)//如果存在入住信息，将信息赋值到相应控件
                {
                    cLend = cLendBll.GetModelList(sql)[0];
                    tbGLendNum.Text = cLend.lendNum.ToString();
                    dtkGLendDate.Value = cLend.lendDate;
                    dtkGYreturn.Value = cLend.lendYDate;
                    dtkSreturn.Value = DateTime.Now;
                    //计算

                    if (DateTime.Compare(dtkSreturn.Value, dtkGYreturn.Value) > 0)
                    {
                        TimeSpan ts = dtkSreturn.Value - dtkGYreturn.Value;

                        Double unit = 60;//一天

                        tbFmoney.Text = ((ts.Days + 1 )*unit).ToString();

                    }
                    else
                    {
                        tbFmoney.Text = "0";
                    }


                    IsExistLendInfo = true;
                }
                else
                {
                    MessageBox.Show("没有此入住信息！","操作提示");
                    IsExistLendInfo = false;
                }
            }
        }

        //退还客房
        private void btGEnter_Click(object sender, EventArgs e)
        {
            if (IsExistLendInfo)
            {
                int readerID = int.Parse(cbGReaderID.Text);
                int bookID = int.Parse(cbGBookID.Text);
                string sql = "bookID=" + bookID + " and readerID=" + readerID + " and lendNum>0";

                
                CtbLendBLL cLendBll = new CtbLendBLL();
                CtbLend cLend = cLendBll.GetModelList(sql)[0];


                cLend.lendNum = 0;//将租出的客房数量置为0
                cLend.lendSDate = dtkSreturn.Value.ToString();
                cLend.lendYDate = dtkGYreturn.Value;

                cLendBll.Update(cLend);
                MessageBox.Show("操作成功！", "操作提示");
            }

        }
    }
}
