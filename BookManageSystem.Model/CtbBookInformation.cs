﻿using System;
namespace BookManageSystem.Model
{
    /// <summary>
    /// 实体类CtbBookInformation 。
    /// </summary>
    public class CtbBookInformation
    {
        public CtbBookInformation()
        { }
        #region Model
        private int _bookid;
        private int _booksortid;
        private string _bookname;
        private string _bookautor;
        private string _bookpublish;
        private DateTime _bookpubdate;
        private decimal _bookprice;
        private string _booksummary;
        private int _bookrealnum;
        private int _booklendnum;
        private DateTime _bookresdate;
        /// <summary>
        /// 客房编号
        /// </summary>
        public int bookID
        {
            set { _bookid = value; }
            get { return _bookid; }
        }
        /// <summary>
        /// 客房类别编号
        /// </summary>
        public int bookSortID
        {
            set { _booksortid = value; }
            get { return _booksortid; }
        }
        /// <summary>
        /// 客房名称
        /// </summary>
        public string bookName
        {
            set { _bookname = value; }
            get { return _bookname; }
        }
        /// <summary>
        /// 风格
        /// </summary>
        public string bookAutor
        {
            set { _bookautor = value; }
            get { return _bookautor; }
        }
        /// <summary>
        /// 计价周期
        /// </summary>
        public string bookPublish
        {
            set { _bookpublish = value; }
            get { return _bookpublish; }
        }
        /// <summary>
        /// 投用日期
        /// </summary>
        public DateTime bookPubDate
        {
            set { _bookpubdate = value; }
            get { return _bookpubdate; }
        }
        /// <summary>
        /// 定价
        /// </summary>
        public decimal bookPrice
        {
            set { _bookprice = value; }
            get { return _bookprice; }
        }
        /// <summary>
        /// 客房介绍
        /// </summary>
        public string bookSummary
        {
            set { _booksummary = value; }
            get { return _booksummary; }
        }
        /// <summary>
        /// 实际数量
        /// </summary>
        public int bookRealNum
        {
            set { _bookrealnum = value; }
            get { return _bookrealnum; }
        }
        /// <summary>
        /// 入住数量
        /// </summary>
        public int bookLendNum
        {
            set { _booklendnum = value; }
            get { return _booklendnum; }
        }
        /// <summary>
        /// 客房登记日期
        /// </summary>
        public DateTime bookResDate
        {
            set { _bookresdate = value; }
            get { return _bookresdate; }
        }
        #endregion Model

    }
}

