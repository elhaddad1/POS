using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Portal
{
    public partial class frmBaseSearchForm : Form
    {
        public DataGridView dgrid_Result
        {
            get { return Dgrid_Result; }
            set { Dgrid_Result = value; }
        }

        public frmBaseSearchForm()
        {
            InitializeComponent();
            Dgrid_Result.AutoGenerateColumns = false;
            Dgrid_Result.ReadOnly = true;
        }


        /// <summary>
        /// Events implementation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void btn_Add_Click(object sender, EventArgs e) { }
        public virtual void btn_Edit_Click(object sender, EventArgs e) { }
        public virtual void btn_Delete_Click(object sender, EventArgs e) { }
        public virtual void btn_Back_Click(object sender, EventArgs e) { }
        #region MyRegion
        public void addColumnToGrid(string header, string dataField, int width, bool visible)//you can overload this method if u need additional parameters
        {
            DataGridViewColumn col = new DataGridViewColumn();
            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            col.CellTemplate = dataGridViewCell;
            col.Name = dataField;
            col.HeaderText = header;
            col.DataPropertyName = dataField;
            col.Visible = visible;
            if (visible)
            {
                col.Width = width;
            }
           
            Dgrid_Result.Columns.Add(col);
        }

        #endregion


    }
}
