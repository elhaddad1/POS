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
using POS.BusinessLayer;
using POS.BusinessLayer .Wrapper ;

namespace POS.UserInterfaceLayer.Inventory
{
    public partial class FrmCloseTakingInventory : Form
    {
        INVTakingInventoryCollection _takingHeaders;
        public FrmCloseTakingInventory()
        {
            InitializeComponent();
        }

        private void FrmCloseTakingInventory_Load(object sender, EventArgs e)
        {
            cmboBox_TakingName.ValueMember = "TakingHeaderID";
            cmboBox_TakingName.DisplayMember = "TakingName";
           
            _takingHeaders = new INVTakingInventoryWrapper().GetUnCommittedTaking();
           
            cmboBox_TakingName.DataSource = _takingHeaders;
           // cmboBox_TakingName.SelectedValue = "";
        }

        private void cmboBox_TakingName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int headerID ;
          if(! int.TryParse ( cmboBox_TakingName.SelectedValue.ToString (),out headerID ))
          {
              return;
          }
          INVTakingInventory _selectedHeader =  _takingHeaders.Where(a => a.TakingHeaderID == headerID).FirstOrDefault();
          txtbox_Date.Text = _selectedHeader.TakingDate.Value.ToShortDateString();
          txtbox_InventoryName.Text = _selectedHeader.InventoryName;
          dgv_Lines.AutoGenerateColumns = false;
          dgv_Lines.DataSource = new INVTakingInventoryLineWrapper().GetLines(headerID);
        }
        public  void btn_Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_Lines .Rows.Count ; i++)
            {
                int lineID = Convert.ToInt32(dgv_Lines.Rows[i].Cells["Col_TakingInventoryLineID"].Value);
                int batchID = Convert.ToInt32(dgv_Lines.Rows[i].Cells["Col_TakingLineBatchID"].Value);
                decimal actualQty = Convert.ToDecimal(dgv_Lines.Rows[i].Cells["Col_ActualQty"].Value);
                INVTakingInventoryLineWrapper.saveLines(lineID, batchID, actualQty);
            }
            MessageBox.Show("تم الحفظ بنجاح");
        }
        public  void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            INVTakingInventoryWrapper.CommitTaking(Convert .ToInt32( cmboBox_TakingName.SelectedValue));
            MessageBox.Show("تم الاغلاق  بنجاح");
            this.Close();
        }

       
    }
}
 