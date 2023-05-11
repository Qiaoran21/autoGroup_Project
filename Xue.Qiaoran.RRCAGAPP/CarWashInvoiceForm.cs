/*
 * Name: Qiaoran Xue
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-04-05
 * Updated: 2023-04-05
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xue.Qiaoran.RRCAGAPP
{
    public partial class CarWashInvoiceForm : ACE.BIT.ADEV.Forms.CarWashInvoiceForm
    {
        private BindingSource invoiceSource;
        
        public CarWashInvoiceForm(BindingSource source)
        {
            InitializeComponent();

            this.invoiceSource = source;

            PriceBind();
        }

        /// <summary>
        /// Sets the data binding for price.
        /// </summary>
        private void PriceBind()
        {
            Binding fragranceBind = new Binding("Text", invoiceSource, "FragranceCost");
            lblFragrancePrice.DataBindings.Add(fragranceBind);
            fragranceBind.FormattingEnabled = true;
            fragranceBind.FormatString = "n2";

            Binding packageBind = new Binding("Text", invoiceSource, "PackageCost");
            lblPackagePrice.DataBindings.Add(packageBind);
            packageBind.FormattingEnabled = true;
            packageBind.FormatString = "c";
            
            Binding subtotalBind = new Binding("Text", invoiceSource, "SubTotal");
            lblSubtotal.DataBindings.Add(subtotalBind);
            subtotalBind.FormattingEnabled = true;
            subtotalBind.FormatString = "c";

            Binding goodsAndServicesTaxBind = new Binding("Text", invoiceSource, "GoodsAndServicesTaxCharged");
            lblGoodsAndServicesTax.DataBindings.Add(goodsAndServicesTaxBind);

            Binding provincialSalesTaxBind = new Binding("Text", invoiceSource, "ProvincialSalesTaxCharged");
            lblProvincialSalesTax.DataBindings.Add(provincialSalesTaxBind);
            provincialSalesTaxBind.FormattingEnabled = true;
            provincialSalesTaxBind.FormatString = "n2";

            Binding totalBind = new Binding("Text", invoiceSource, "Total");
            lblTotal.DataBindings.Add(totalBind);
            totalBind.FormattingEnabled = true;
            totalBind.FormatString = "c";
        }
    }
}
