using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using POS.UserInterfaceLayer.Portal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class FrmSupplierAddEdit : frmBaseAddEditForm
    {
       int? SupplierID;
        BDSupplierWrapper supplierWrapper;
        BDSupplier supplier;
        public FrmSupplierAddEdit()
        {
            InitializeComponent();
            supplierWrapper = new BDSupplierWrapper();
           
        }
        public FrmSupplierAddEdit(int? SupplierId)
        {
            InitializeComponent();
            supplierWrapper = new BDSupplierWrapper();
            SupplierID = SupplierId;
        }
        #region Event Handeler
        private void FrmSupplierAddEdit_Load(object sender, EventArgs e)
        {
            if (SupplierID != null)
            {
                LoadControls();
            }
        }


        public override void btn_Save_Click(object sender, EventArgs e)
        {
            if (tbx_Name.Text != "")
            {
                supplier = new BDSupplier();
                BDSupplierService supplierService = new BDSupplierService();
                if (SupplierID == null)//new supplier
                {
                    supplier.SupplierCode = tbx_Code.Text;
                    supplier.SupplierName = tbx_Name.Text;
                    supplier.Address = tbx_Address.Text;
                    supplier.Phone1 = tbx_Pone1.Text;
                    supplier.phone2 = tbx_phone2.Text;
                    supplier.Mobile1 = tbx_Mobile1.Text;
                    supplier.Mobile2 = tbx_Mobile2.Text;
                    supplier.Email = tbx_Email.Text;
                    supplier.IsActive = chk_IsActive.Checked;
                    supplierService.Insert(supplier);
                    ClearControls(); 
                    MessageBox.Show("تم الحفظ بنجاح");
                }
                else
                {
                    BDSupplierPrimaryKey pk = new BDSupplierPrimaryKey();
                    pk.SupplierID = SupplierID;
                    supplier = supplierService.SelectOne(pk);
                    supplier.SupplierCode = tbx_Code.Text;
                    supplier.SupplierName = tbx_Name.Text;
                    supplier.Address = tbx_Address.Text;
                    supplier.Phone1 = tbx_Pone1.Text;
                    supplier.phone2 = tbx_phone2.Text;
                    supplier.Mobile1 = tbx_Mobile1.Text;
                    supplier.Mobile2 = tbx_Mobile2.Text;
                    supplier.Email = tbx_Email.Text;
                    supplier.IsActive = chk_IsActive.Checked;
                   supplierService.Update(supplier);
                   MessageBox.Show("تم التعديل بنجاح");
                }
                
               
            
            }
            else
            {
                MessageBox.Show("لابد من ادخال إسم المورد");
            }
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #endregion
        #region Methods
        private void LoadControls()
        {
            BDSupplierPrimaryKey pk = new BDSupplierPrimaryKey();
            pk.SupplierID = SupplierID;
            supplier = supplierWrapper.SelectOne(pk);
            tbx_Code.Text = supplier.SupplierCode != null ? supplier.SupplierCode : "";
            tbx_Name.Text = supplier.SupplierName;
            tbx_Address.Text = supplier.Address != null ? supplier.Address : "";
            tbx_Pone1.Text = supplier.Phone1 != null ? supplier.Phone1 : "";
            tbx_phone2.Text = supplier.phone2 != null ? supplier.phone2 : "";
            tbx_Mobile1.Text = supplier.Mobile1 != null ? supplier.Mobile1 : "";
            tbx_Mobile2.Text = supplier.Mobile2 != null ? supplier.Mobile2 : "";
            tbx_Email.Text = supplier.Email != null ? supplier.Email : "";
            chk_IsActive.Checked = supplier.IsActive != null ? (bool)supplier.IsActive : true;
        }
        private void ClearControls()
        {
            tbx_Code.Text =  "";
            tbx_Name.Text = "";
            tbx_Address.Text =  "";
            tbx_Pone1.Text =  "";
            tbx_phone2.Text =  "";
            tbx_Mobile1.Text ="";
            tbx_Mobile2.Text =  "";
            tbx_Email.Text = "";
            chk_IsActive.Checked = true;
        }
        #endregion
    }
}
