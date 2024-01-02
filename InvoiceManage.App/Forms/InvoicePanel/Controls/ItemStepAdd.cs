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
                Am = decimal.TryParse(TxtAm.Text, out var am)
                    ? am : default,
                Mu = CbMu.SelectedText,
                Mu_1 = CbMu.SelectedValue?.ToString(),
                Nw = decimal.TryParse(TxtNw.Text, out var nw)
                    ? nw : default,
                Fee = decimal.TryParse(TxtFee.Text, out var fee)
                    ? fee : default,
                CFee = decimal.TryParse(TxtCFee.Text, out var cfee)
                    ? cfee : default,
                Cut = TxtCut.Text,
                Exr = decimal.TryParse(TxtExr.Text, out var exr)
                    ? exr : default,
                Ssrv = decimal.TryParse(TxtSsrv.Text, out var ssrv)
                    ? ssrv : default,
                Sscv = decimal.TryParse(TxtSscv.Text, out var sscv)
                    ? sscv : default,
                Dis = decimal.TryParse(TxtDis.Text, out var dis)
                    ? dis : default,
                Vra = double.TryParse(TxtVra.Text, out var vra)
                    ? vra : default,
                Odt = TxtOdt.Text,
                Odr = double.TryParse(TxtOdr.Text, out var odr)
                    ? odr : default,
                Odam = decimal.TryParse(TxtOdam.Text, out var odam)
                    ? odam : default,
                Olt = TxtOlt.Text,
                Olr = double.TryParse(TxtOlr.Text, out var olr)
                    ? olr : default,
                Olam = decimal.TryParse(TxtOlam.Text, out var olam)
                    ? olam : default,
                Consfee = decimal.TryParse(TxtConsfee.Text, out var consfee)
                    ? consfee : default,
                Spro = decimal.TryParse(TxtSpro.Text, out var spro)
                    ? spro : default,
                Bros = decimal.TryParse(TxtBros.Text, out var bros)
                    ? bros : default
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