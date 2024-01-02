using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;
using InvoiceManage.App.Resources.CustomToolBox;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.CommonService;
using System.Collections.Generic;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class ItemStepAdd : UserControl
    {
        public ItemStepAdd()
        {
            InitializeComponent();
            SetComboBoxDataSource();
        }

        private void SetComboBoxDataSource()
        {
            CbMu.SetEnumDataSource(typeof(Mu));
        }

        #region Events

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //TODO: Calculate

            var newItem = new InvoiceItem()
            {
                SstId = TxtSstid.Text,
                Sstt = TxtSstt.Text,
                Am = decimal.Parse(TxtAm.Text),
                Mu = CbMu.SelectedText,
                Mu_1 = CbMu.SelectedValue.ToString(),
                Nw = decimal.Parse(TxtNw.Text),
                Fee = decimal.Parse(TxtFee.Text),
                CFee = decimal.Parse(TxtCFee.Text),
                Cut = TxtCut.Text,
                Exr = decimal.Parse(TxtExr.Text),
                Ssrv = decimal.Parse(TxtSsrv.Text),
                Sscv = decimal.Parse(TxtSscv.Text),
                Dis = decimal.Parse(TxtDis.Text),
                Vra = double.Parse(TxtVra.Text),
                Odt = TxtOdt.Text,
                Odr = double.Parse(TxtOdr.Text),
                Odam = decimal.Parse(TxtOdam.Text),
                Olt = TxtOlt.Text,
                Olr = double.Parse(TxtOlr.Text),
                Olam = decimal.Parse(TxtOlam.Text),
                Consfee = decimal.Parse(TxtConsfee.Text),
                Spro = decimal.Parse(TxtSpro.Text),
                Bros = decimal.Parse(TxtBros.Text)
            };

            var parentForm = ParentForm as FrmInvoice;
            parentForm!.Invoice.Items.Add(newItem);

            ClearForm();

            CustomMessageBox.Show("کالا با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicAdd_Click(object sender, EventArgs e)
        {
            BtnAdd_Click(sender, e);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            using var commonService = new CommonService();

            List<Product> data = commonService.GetProducts();
            var frmSelect = new FrmSelect(null);

            if (frmSelect.ShowDialog() == DialogResult.OK)
            {
                var selectItem = (Customer)frmSelect.SelectedItem!;
            }
        }

        #endregion

        private void ClearForm()
        {
            foreach (var control in Controls)
            {
                if (control is not CustomGroupBox groupBox) continue;
                foreach (var gbControl in groupBox.Controls)
                {
                    switch (gbControl)
                    {
                        case TextBox textBox:
                            textBox.Clear();
                            break;

                        case ComboBox comboBox:
                            comboBox.SelectedItem = null;
                            break;
                    }
                }
            }
        }
    }
}