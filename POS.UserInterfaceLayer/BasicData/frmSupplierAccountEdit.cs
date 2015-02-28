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
using POS.BusinessLayer.Utility;
using POS.BusinessLayer.Wrapper;
using POS.UserInterfaceLayer.BasicData;

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmSupplierAccountEdit : Form
    {
        BDSupplierWrapper _bDSupplierWrapper;
        public BDSupplier _supplier;
        public FrmSupplierSearch frmSupplierSearchObj;
        private int _supplierID = -1;
        public frmSupplierAccountEdit(int supplierID, FrmSupplierSearch _frmSupplierSearch)
        {
            InitializeComponent();
            this._supplierID = supplierID;
            this._bDSupplierWrapper = new BDSupplierWrapper();
            this._supplier = new BDSupplier();
            this.frmSupplierSearchObj = _frmSupplierSearch;
            FillSupplierData();
        }

        #region -- Events Methods

        private void tbx_Price_Leave(object sender, EventArgs e)
        {

        }
        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                _supplier.Credit = num_Credit.Value ;
                _supplier.Debit = num_Debit.Value;
                _bDSupplierWrapper.Update(_supplier);
                frmSupplierSearchObj.InitionGrid();
                this.Close();
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
        private void FillSupplierData()
        {
            try
            {
                BDSupplierPrimaryKey _supplierPrimaryKey = new BDSupplierPrimaryKey();
                _supplierPrimaryKey.SupplierID = _supplierID;
                _supplier = _bDSupplierWrapper.SelectOne(_supplierPrimaryKey);
                num_Credit.Value = _supplier.Credit.Value;
                num_Debit.Value = _supplier.Debit.Value;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool Validate()
        {
            /*if (string.IsNullOrEmpty(tbx_Price.Text))
            {
                MessageBox.Show("برجاء أدهال سعر المنتج");
                return false;
            }
            if (Convert.ToDecimal(tbx_Price.Text == "" ? "0" : tbx_Price.Text) < Convert.ToDecimal(lbl_MinPriceValue.Text == "" ? "0" : lbl_MinPriceValue.Text))
            {
                MessageBox.Show("برجاء مراعاة أقل سعر للمنتج");
                return false;
            }
            if (string.IsNullOrEmpty(num_Quantity.Text) || Convert.ToInt32(num_Quantity.Text) <= 0)
            {
                MessageBox.Show("أدخل كميه مناسبه");
                return false;
            }*/
            return true;
        }
        #endregion


    }
}
