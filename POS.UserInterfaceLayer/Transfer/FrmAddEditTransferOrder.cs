using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Transfer
{
    public partial class FrmAddEditTransferOrder : Form
    {
        private INVInventoryWrapper _inventoryWrapper;
        private INVTransferHeaderWrapper _transferHeaderWrapper;
        private BDTaxTypeWrapper _bDTaxTypeWrapper;
        private PaymentTypeWrapper _paymentTypeWrapper;
        private BDCustomerWrapper _bDCustomerWrapper;
        private FrmTransferOrderSearch _frmTransferOrderSearch;
        public INVTransferLineCollection transferLineCollection;
        private INVTransferHeader _transferHeader;
        private int _transferHeaderID = 0;

        public FrmAddEditTransferOrder(FrmTransferOrderSearch frmTransferOrderSearch, int transferHeaderID)
        {
            InitializeComponent();
            this._bDTaxTypeWrapper = new BDTaxTypeWrapper();
            this._paymentTypeWrapper = new PaymentTypeWrapper();
            this._bDCustomerWrapper = new BDCustomerWrapper();
            this.transferLineCollection = new INVTransferLineCollection();
            this._inventoryWrapper = new INVInventoryWrapper();
            this._transferHeaderWrapper = new INVTransferHeaderWrapper();
            this._frmTransferOrderSearch = frmTransferOrderSearch;
            FillStokeCBX();
            if (transferHeaderID > 0)
            {
                this._transferHeaderID = transferHeaderID;
                GetTransferOrderData(transferHeaderID);
            }
        }

        #region -- Events

        private void num_Remaining_Leave(object sender, EventArgs e)
        {

            /*if (num_Remaining.Value > 0)
            {
                dtb_LastTimeToPay.Enabled = true;
            }*/
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            int cbxFrom = 0;
            if (cbx_StoreFrom.SelectedValue != null)
                int.TryParse(cbx_StoreFrom.SelectedValue.ToString(), out cbxFrom);
            if (cbxFrom > 0)
            {
                FrmTransferLineAddEdit frm = new FrmTransferLineAddEdit(Convert.ToInt32(cbx_StoreFrom.SelectedValue), this);
                frm.FormClosed += frmSalesOrderAddEdit_FormClosed;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("برجاء أختيار المخزن المحول منه");
            }

        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                transferLineCollection.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                //dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                BindGrid();

            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                transferLineCollection.Where(a => a.ProductID == (int?)dgrd_OrderLines.SelectedRows[0].Cells["ProductID"].Value).SingleOrDefault().Qty++;
                BindGrid();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                transferLineCollection.Where(a => a.ProductID == (int?)dgrd_OrderLines.SelectedRows[0].Cells["ProductID"].Value).SingleOrDefault().Qty--;
                BindGrid();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    bool rtn_result = false;
                    if (_transferHeaderID > 0)
                        rtn_result = _transferHeaderWrapper.UpdateTransferOrder(CollectHeaderData(), transferLineCollection);
                    else
                        rtn_result = _transferHeaderWrapper.SaveTransferOrder(CollectHeaderData(), transferLineCollection);
                    if (rtn_result)
                    {
                        _frmTransferOrderSearch.InitiateGrid(null);
                        MessageBox.Show("تمت العملية");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
                }
            }
        }


        private void btn_ClosePrint_Click_1(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    bool rtn_result = false;
                    if (_transferHeaderID > 0)
                    {
                        rtn_result = _transferHeaderWrapper.UpdateTransferOrder(CollectHeaderData(), transferLineCollection);
                        rtn_result = _transferHeaderWrapper.CloseOrder(_transferHeaderID);
                    }
                    else
                        rtn_result = _transferHeaderWrapper.SaveCloseTransferOrder(CollectHeaderData(), transferLineCollection);

                    if (rtn_result)
                    {
                        _frmTransferOrderSearch.InitiateGrid(null);
                        MessageBox.Show("تمت العملية");

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesOrderAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
        }
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
        private void FillStokeCBX()
        {

            try
            {
                cbx_StoreFrom.DataSource = _inventoryWrapper.SelectAll();
                cbx_StoreFrom.DisplayMember = "InventoryName";
                cbx_StoreFrom.ValueMember = "InventoryID";
                cbx_StoreFrom.SelectedIndex = -1;
                cbx_StoreTo.DataSource = _inventoryWrapper.SelectAll();
                cbx_StoreTo.DisplayMember = "InventoryName";
                cbx_StoreTo.ValueMember = "InventoryID";
                cbx_StoreTo.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindGrid()
        {
            dgrd_OrderLines.DataSource = null;
            dgrd_OrderLines.AutoGenerateColumns = false;
            dgrd_OrderLines.DataSource = transferLineCollection;
            dgrd_OrderLines.Columns[0].DataPropertyName = "ProductID";
            dgrd_OrderLines.Columns[1].DataPropertyName = "ProductName";
            dgrd_OrderLines.Columns[2].DataPropertyName = "Qty";
           
        }


        private void GetTransferOrderData(int salesHeaderID)
        {
            INVTransferHeaderPrimaryKey pk = new INVTransferHeaderPrimaryKey();
            pk.INVTransferHeaderID = salesHeaderID;
            _transferHeader = _transferHeaderWrapper.SelectOne(pk);
            transferLineCollection = _transferHeaderWrapper.SelectByField(salesHeaderID);
            BindGrid();
            cbx_StoreFrom.SelectedValue = _transferHeader.FromInventoryID;
            cbx_StoreTo.SelectedValue = _transferHeader.ToInventoryID;
            dtb_Date.Value = _transferHeader.TransferDate.Value;
        }

        private INVTransferHeader CollectHeaderData()
        {
            if (_transferHeaderID > 0)
            {
                _transferHeader.FromInventoryID = Convert.ToInt32(cbx_StoreFrom.SelectedValue);
                _transferHeader.ToInventoryID = Convert.ToInt32(cbx_StoreTo.SelectedValue);
                _transferHeader.TransferDate = dtb_Date.Value;
                return _transferHeader;
            }
            else
            {
                INVTransferHeader _INVTransferHeader = new INVTransferHeader();
                _INVTransferHeader.FromInventoryID = Convert.ToInt32(cbx_StoreFrom.SelectedValue);
                _INVTransferHeader.ToInventoryID = Convert.ToInt32(cbx_StoreTo.SelectedValue);
                _INVTransferHeader.TransferDate = dtb_Date.Value;
                return _INVTransferHeader;
            }
        }

        private bool Validate()
        {
            if (cbx_StoreFrom.SelectedIndex == -1)
            {
                MessageBox.Show("اختار المخزن المحول منه");
                return false;
            }
            if (cbx_StoreTo.SelectedIndex == -1)
            {
                MessageBox.Show("اختار المخزن المحول اليه");
                return false;
            }
            if (cbx_StoreFrom.SelectedIndex == cbx_StoreTo.SelectedIndex)
            {
                MessageBox.Show("اختار اختيار مخزن مختلف عن المخزن المحول منه");
                return false;
            }



            return true;
        }
        #endregion



    }
}
