using System;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.Data.Filtering;


namespace ShowFilterPopupDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.table1TableAdapter.Fill(this._treelistdb__2_DataSet.Table1);
        }

        private void treeList1_ShowFilterPopupDate(object sender, FilterPopupDateEventArgs e)
        {
            if (e.Column.FieldName != "Hired") return;
            DateTime firstDayOfFirstYear = new DateTime(1982, 1, 1);
            DateTime lastDayOfFirstYear = new DateTime(1982, 12, 31);

            CriteriaOperator firstDay = new BinaryOperator(
                e.Column.FieldName, firstDayOfFirstYear, BinaryOperatorType.GreaterOrEqual);
            CriteriaOperator lastDay = new BinaryOperator(
                e.Column.FieldName, lastDayOfFirstYear, BinaryOperatorType.Less);
            CriteriaOperator crit = new GroupOperator(GroupOperatorType.And, firstDay, lastDay);

            e.List.Add(new DevExpress.XtraEditors.FilterDateElement("Year of Foundation", "", crit));

        }
    }
}
