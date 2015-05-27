using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Inventory
{
    public partial class frmOpenningQuantitiesBatches : Form
    {
        INVProductStock iNVProductStock;
        private INVProductStockWrapper _iNVProductStockWrapper;
        frmOpenningQuantities frmOpenningQuantitiesObj;
        public frmOpenningQuantitiesBatches(INVProductStock iNVProductStock, frmOpenningQuantities frm)
        {
            InitializeComponent();
            _iNVProductStockWrapper = new INVProductStockWrapper();
            this.iNVProductStock = iNVProductStock;
            this.frmOpenningQuantitiesObj = frm;
        }
        #region -- Events
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dgrd_Batches.Rows.Count == 0)
            {
                MessageBox.Show("برجاء أدخال أرقام تشغيله أولا");
                return;
            }
            if (ValidateTotalQty())
                if (CollectScreenData())
                    this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region -- Public Methods

        #endregion
        #region -- Private Methods
        private bool CollectScreenData()
        {
            foreach (DataGridViewRow row in dgrd_Batches.Rows)
            {
                if (row.Index != dgrd_Batches.Rows.Count - 1)
                {
                    if (!Validate(row))
                        return false;
                    INVProductStock _iNVProductStock = new INVProductStock();
                    _iNVProductStock.InventoryID = this.iNVProductStock.InventoryID;
                    _iNVProductStock.CreateDate = this.iNVProductStock.CreateDate;
                    _iNVProductStock.CreatedBy = this.iNVProductStock.CreatedBy;
                    _iNVProductStock.OpeningQty = this.iNVProductStock.OpeningQty;
                    _iNVProductStock.OpennigDate = this.iNVProductStock.OpennigDate;
                    _iNVProductStock.ProductID = this.iNVProductStock.ProductID;
                    _iNVProductStock.StockTypeID = this.iNVProductStock.StockTypeID;
                    _iNVProductStock.TotalQty = this.iNVProductStock.TotalQty;
                    _iNVProductStock.BatchNo = row.Cells["BatchNumber"].Value.ToString();
                    _iNVProductStock.ExpiryDate = DateTime.Parse(row.Cells["ExpiryDate"].Value.ToString());
                    _iNVProductStock.BatchQty = Convert.ToDecimal(row.Cells["Qty"].Value);
                    frmOpenningQuantitiesObj.iNVProductStockCollection.Add(_iNVProductStock);
                }
            }
            return true;
        }
        new private bool Validate(DataGridViewRow row)
        {
            if (row.Cells["BatchNumber"].Value == null)
            {
                row.Cells["BatchNumber"].Style.BackColor = Color.Red;
                return false;
            }
            if (row.Cells["ExpiryDate"].Value == null)
            {
                row.Cells["ExpiryDate"].Style.BackColor = Color.Red;
                return false;
            }

            DateTime result;
            if (!DateTime.TryParse(row.Cells["ExpiryDate"].Value.ToString(), out result))
            {
                MessageBox.Show("صيغة تاريخ الصلاحية غير صحيحة لابد ان تكون (يوم -شهر -سنة)");
                row.Cells["ExpiryDate"].Style.BackColor = Color.Red;
                return false;
            }
            if (row.Cells["Qty"].Value == null)
            {
                row.Cells["Qty"].Style.BackColor = Color.Red;
                return false;
            }

            return true;
        }

        private bool ValidateTotalQty()
        {
            decimal _totalQty = 0;
            foreach (DataGridViewRow row in dgrd_Batches.Rows)
            {
                if (row.Index != dgrd_Batches.Rows.Count - 1)
                {
                    _totalQty += Convert.ToDecimal(row.Cells["Qty"].Value);
                }
            }

            if (_totalQty > this.iNVProductStock.TotalQty)
            {
                MessageBox.Show("الكمية المدخله اكبر من الكمية الكليه للمنتج");
                return false;
            }
            else if (_totalQty < this.iNVProductStock.TotalQty)
            {
                MessageBox.Show("الكمية المدخله أقل من الكمية الكليه للمنتج");
                return false;
            }

            return true;
        }
        #endregion


    }
}
