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
        INVBatchCollection _iNVBatchCollection;
        INVBatchWrapper _iNVBatchWrapper;
        private int _productStockID;


        public frmOpenningQuantitiesBatches(int ProductStockID)
        {
            InitializeComponent();
            _iNVBatchCollection = new INVBatchCollection();
            _iNVBatchWrapper = new INVBatchWrapper();
            _productStockID = ProductStockID;
        }

        #region -- Events
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (_iNVBatchCollection.Count == 0)
            {
                MessageBox.Show("برجاء أدخال أرقام تشغيله أولا");
                return;
            }
            if (_iNVBatchWrapper.SaveProductStockWithBatches(_iNVBatchCollection, _productStockID))
            {
                MessageBox.Show("تم العملية بنجاح");
                this.Close();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region -- Public Methods

        #endregion
        #region -- Private Methods
        private void CollectScreenData()
        {
            foreach (DataGridViewRow row in dgrd_Batches.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["ExpiryDate"].Value.ToString()) && !string.IsNullOrEmpty(row.Cells["BatchNumber"].Value.ToString()) && !string.IsNullOrEmpty(row.Cells["Qty"].Value.ToString()))
                {
                    INVBatch _iNVBatch = new INVBatch();
                    _iNVBatch.BatchNumber = row.Cells["BatchNumber"].Value.ToString();
                    _iNVBatch.ExpiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
                    _iNVBatch.Qty = Convert.ToDecimal(row.Cells["Qty"].Value);

                    _iNVBatchCollection.Add(_iNVBatch);
                }
            }
        }

        #endregion


    }
}
