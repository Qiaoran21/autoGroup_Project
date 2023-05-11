/*
 * Name: Qiaoran Xue
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-29
 * Updated: 2023-04-05
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV.CarWash;
using Xue.Qiaoran.Business;

namespace Xue.Qiaoran.RRCAGAPP
{
    public partial class CarWashForm : ACE.BIT.ADEV.Forms.CarWashForm
    {
        private BindingList<CarWashItem> fragrances;
        private BindingSource fragranceSource;

        private BindingList<Package> packages;
        private BindingSource packageSource;

        private BindingSource invoiceSource;

        private CarWashInvoice carWashInvoice;

        /// <summary>
        /// Initializes an instance of the CarWashForm class.
        /// </summary>
        public CarWashForm()
        {
            this.packages = new BindingList<Package>();
            this.packageSource = new BindingSource();
            this.packageSource.DataSource = this.packages;

            this.carWashInvoice = new CarWashInvoice(0.07m, 0.05m);

            this.invoiceSource = new BindingSource();
            this.invoiceSource.DataSource = this.carWashInvoice;

            PopulateInteriorExterior();

            FragranceBindData();
            PackageBindData();
            PriceBindData();

            this.Load += CarWashForm_Load;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;
        }

        /// <summary>
        /// Handles the Click event of the tools generate invoice menu item.
        /// </summary>
        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
            Form form = new CarWashInvoiceForm(this.invoiceSource);
            
            form.Text = "Car Wash Invoice";

            form.Width = 650;
            form.Height = 430;

            form.FormClosed += Form_FormClosed;

            form.ShowDialog();
        }

        /// <summary>
        /// Handles the FormClosed event of the form.
        /// </summary>
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.cboFragrance.Text = "Pine";
            this.cboPackage.SelectedItem = null;

            this.lstExterior.DataSource = null;
            this.lstExterior.Items.Clear();

            this.lstInterior.DataSource = null;
            this.lstInterior.Items.Clear();

            this.lblSubtotal.Text = string.Empty;
            this.lblProvincialSalesTax.Text = string.Empty;
            this.lblGoodsAndServicesTax.Text = string.Empty;
            this.lblTotal.Text = string.Empty;
        }

        /// <summary>
        /// Populate the interior and exterior collections. 
        /// </summary>
        private void PopulateInteriorExterior()
        {
            List<string> interior = new List<string>();
            interior.Add("Fragrance");
            interior.Add("Shampoo Carpets");
            interior.Add("Shampoo Upholstery");
            interior.Add("Interior Protection Coat");

            List<string> exterior = new List<string>();
            exterior.Add("Hand Wash");
            exterior.Add("Hand Wax");
            exterior.Add("Wheel Polish");
            exterior.Add("Detail Engine Compartment");

            List<string> interiorStandard = new List<string>();
            interiorStandard.Add(interior[0]);

            List<string> interiorDeluxe = new List<string>();
            interiorDeluxe.Add(interior[0]);
            interiorDeluxe.Add(interior[1]);

            List<string> interiorExecutive = new List<string>();
            interiorExecutive.Add(interior[0]);
            interiorExecutive.Add(interior[1]);
            interiorExecutive.Add(interior[2]);

            List<string> interiorLuxury = new List<string>();
            interiorLuxury.Add(interior[0]);
            interiorLuxury.Add(interior[1]);
            interiorLuxury.Add(interior[2]);
            interiorLuxury.Add(interior[3]);

            List<string> exteriorStandard = new List<string>();
            exteriorStandard.Add(exterior[0]);

            List<string> exteriorDeluxe = new List<string>();
            exteriorDeluxe.Add(exterior[0]);
            exteriorDeluxe.Add(exterior[1]);

            List<string> exteriorExecutive = new List<string>();
            exteriorExecutive.Add(exterior[0]);
            exteriorExecutive.Add(exterior[1]);
            exteriorExecutive.Add(exterior[2]);

            List<string> exteriorLuxury = new List<string>();
            exteriorLuxury.Add(exterior[0]);
            exteriorLuxury.Add(exterior[1]);
            exteriorLuxury.Add(exterior[2]);
            exteriorLuxury.Add(exterior[3]);

            this.packages.Add(new Package("Standard", 7.50m, interiorStandard, exteriorStandard));
            this.packages.Add(new Package("Deluxe", 15.00m, interiorDeluxe, exteriorDeluxe));
            this.packages.Add(new Package("Executive", 35.00m, interiorExecutive, exteriorExecutive));
            this.packages.Add(new Package("Luxury", 55.00m, interiorLuxury, exteriorLuxury));
        }

        /// <summary>
        /// Handles the Click event of the file close menu item.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Load event of this form.
        /// </summary>
        private void CarWashForm_Load(object sender, EventArgs e)
        {
            this.Text = "Car Wash";
            this.mnuToolsGenerateInvoice.Enabled = false;
            this.lblSubtotal.Text = string.Empty;
            this.lblProvincialSalesTax.Text = string.Empty;
            this.lblGoodsAndServicesTax.Text = string.Empty;
            this.lblTotal.Text = string.Empty;
        }

        /// <summary>
        /// Loading data from fragrance data file.
        /// </summary>
        private void LoadCarWashItem()
        {
            try
            {
                string filepath = "fragrances.txt";

                FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(stream);

                this.fragrances = new BindingList<CarWashItem>();

                this.fragranceSource = new BindingSource();
                this.fragranceSource.DataSource = this.fragrances;

                Console.WriteLine("Reading from {0}...", filepath);

                CarWashItem fragrance;

                while (reader.Peek() != -1)
                {
                    string record = reader.ReadLine();

                    char[] delimiters = { ',' };

                    string[] fields = record.Split(delimiters);

                    string Description = fields[0];
                    decimal Price = decimal.Parse(fields[1]);

                    fragrance = new CarWashItem(Description, Price);

                    fragrances.Add(fragrance);
                }

                foreach (CarWashItem item in fragrances)
                    Console.WriteLine(item);

                this.fragrances.Add(new CarWashItem("Pine", 0.00m));

                reader.Close();
                stream.Dispose();
            }
            catch (System.IO.FileNotFoundException)
            {
                string message = "Fragrances data file not found.";
                string name = "Data File Error";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;

                result = MessageBox.Show(message, name, buttons, icon);
            }
            catch 
            {
                string message = "An error occurred while reading the data file.";
                string name = "Data File Error";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;

                result = MessageBox.Show(message, name, buttons, icon);
            }
        }

        /// <summary>
        /// Sets the data binding for Fragrance.
        /// </summary>
        private void FragranceBindData()
        {
            LoadCarWashItem();

            this.cboFragrance.DataSource = this.fragranceSource;
            this.cboFragrance.DisplayMember = "description";
            this.cboFragrance.ValueMember = "price";

            this.cboFragrance.Text = "Pine";
        }

        /// <summary>
        /// Sets the data binding for Package. 
        /// </summary>
        private void PackageBindData()
        {
            this.packageSource.DataSource = this.packages;

            this.cboPackage.DataSource = this.packageSource;
            this.cboPackage.DisplayMember = "Description";
            this.cboPackage.ValueMember = "Price";
            this.cboPackage.SelectedItem = null;

            //this.lblSubtotal.DataBindings.Add("Text", this.cboPackage, "SelectedValue");

            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Package ComboBox.
        /// </summary>
        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboPackage.SelectedIndex != -1)
            {
                List<string> interiorServices = this.packages[this.cboPackage.SelectedIndex].InteriorServices;
                interiorServices[0] = interiorServices[0] + " - " + this.cboFragrance.Text;

                this.lstInterior.DataSource = interiorServices;

                this.lstExterior.DataSource = this.packages[this.cboPackage.SelectedIndex].ExteriorServices;

                this.mnuToolsGenerateInvoice.Enabled = true;

                this.carWashInvoice.PackageCost = (decimal)cboPackage.SelectedValue;

                this.carWashInvoice.FragranceCost = (decimal)cboFragrance.SelectedValue;
            }
        }

        /// <summary>
        /// Sets the data binding for price. 
        /// </summary>
        private void PriceBindData()
        {
            Binding subtotalBind = new Binding("Text", invoiceSource, "SubTotal");
            this.lblSubtotal.DataBindings.Add(subtotalBind);
            subtotalBind.FormattingEnabled = true;
            subtotalBind.FormatString = "c";

            Binding goodsAndServicesTaxBind = new Binding("Text", invoiceSource, "GoodsAndServicesTaxCharged");
            this.lblGoodsAndServicesTax.DataBindings.Add(goodsAndServicesTaxBind);

            Binding provincialSalesTaxBind = new Binding("Text", invoiceSource, "ProvincialSalesTaxCharged");
            this.lblProvincialSalesTax.DataBindings.Add(provincialSalesTaxBind);
            provincialSalesTaxBind.FormattingEnabled = true;
            provincialSalesTaxBind.FormatString = "n2";

            Binding totalBind = new Binding("Text", invoiceSource, "Total");
            this.lblTotal.DataBindings.Add(totalBind);
            totalBind.FormattingEnabled = true;
            totalBind.FormatString = "c";
        }
    }
}

