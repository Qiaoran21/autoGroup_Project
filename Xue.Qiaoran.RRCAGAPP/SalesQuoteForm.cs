/*
 * Name: Qiaoran Xue
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-10
 * Updated: 2023-03-27
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
using Xue.Qiaoran.Business;
using ACE.BIT.ADEV;
using System.CodeDom;

namespace Xue.Qiaoran.RRCAGAPP
{
    public partial class SalesQuoteForm : Form
    {
        public SalesQuoteForm()
        {
            InitializeComponent();

            this.Load += SalesQuoteForm_Load;
            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
            this.txtVehicleSalesPrice.TextChanged += TxtPriceAndValue_TextChanged;
            this.txtTradeInValue.TextChanged += TxtPriceAndValue_TextChanged;
            this.chkStereoSystem.CheckedChanged += Calculate_Changed;
            this.chkLeatherInterior.CheckedChanged += Calculate_Changed;
            this.chkComputerNavigation.CheckedChanged += Calculate_Changed;
            this.radStandard.CheckedChanged += Calculate_Changed;
            this.radPearlized.CheckedChanged += Calculate_Changed;
            this.radCustomizedDetailing.CheckedChanged += Calculate_Changed;
            this.nudNumberOfYears.ValueChanged += Calculate_Changed;
            this.nudAnnualInterestRate.ValueChanged += Calculate_Changed;
            this.btnReset.Click += BtnReset_Click;

            errorProvider.SetIconPadding(this.txtVehicleSalesPrice, 3);
            errorProvider.SetIconPadding(this.txtTradeInValue, 3);
        }

        /// <summary>
        /// Handles the ValueChanged event of the number of years and annual interest rate.
        /// </summary>
        private void Calculate_Changed(object sender, EventArgs e)
        {
            if (this.lblMonthlyPaymentBox.Text != string.Empty)
            {
                CalculateQuote();
            }
        }

        /// <summary>
        /// Handles the Click event of the reset button.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            string message = "Do you want to reset the form?";
            string caption = "Reset Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons,icon, MessageBoxDefaultButton.Button2);

            switch(result)
            {
                case DialogResult.Yes:
                    this.txtVehicleSalesPrice.Text = string.Empty;
                    this.txtTradeInValue.Text = "0";
                    this.lblMonthlyPaymentBox.Text = string.Empty;
                    this.radStandard.Checked = true;
                    this.chkStereoSystem.Checked = false;
                    this.chkLeatherInterior.Checked = false;
                    this.chkComputerNavigation.Checked = false;
                    this.txtVehicleSalesPrice.Focus();
                    this.nudNumberOfYears.Value = 1;
                    this.nudAnnualInterestRate.Value = 5.00m;
                    break;
                case DialogResult.No:
                    break;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the vehicle sales price and trade-in value text.
        /// </summary>
        private void TxtPriceAndValue_TextChanged(object sender, EventArgs e)
        {
            this.lblMonthlyPaymentBox.Text = string.Empty;
            this.lblSummaryVehicleSalePriceBox.Text = string.Empty;
            this.lblOptionsBox.Text = string.Empty;
            this.lblSubtotalBox.Text = string.Empty;
            this.lblSalesTaxBox.Text = string.Empty;
            this.lblTotalBox.Text = string.Empty;
            this.lblTradeInBox.Text = string.Empty;
            this.lblAmountDueBox.Text = string.Empty;
        }

        /// <summary>
        /// Handles the Click event of the calculate quote button. 
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            CalculateQuote();
        }

        /// <summary>
        /// Method to calculate sales quote.
        /// </summary>
        private void CalculateQuote()
        {
            decimal vehicleSalePrice = 0;
            decimal tradeInValue = 0;
            decimal salesTaxRate = 0.12m;

            this.errorProvider.SetError(this.txtVehicleSalesPrice, string.Empty);
            this.errorProvider.SetError(this.txtTradeInValue, string.Empty);
            this.errorProvider.SetError(this.lblMonthlyPaymentBox, string.Empty);

            if (this.txtVehicleSalesPrice.Text == string.Empty)
            {
                this.errorProvider.SetError(this.txtVehicleSalesPrice, "Vehicle price is a required field.");
            }

            try
            {
                vehicleSalePrice = Decimal.Parse(this.txtVehicleSalesPrice.Text);

                if (vehicleSalePrice <= 0)
                {
                    this.errorProvider.SetError(this.txtVehicleSalesPrice, "Vehicle price cannot be less than or equal to 0.");
                }
            }
            catch (FormatException)
            {
                this.errorProvider.SetError(this.txtVehicleSalesPrice, "Vehicle price cannot contain letters or special characters.");
            }


            if (this.txtTradeInValue.Text == string.Empty)
            {
                this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value is a required field");
            }

            try
            {
                tradeInValue = Decimal.Parse(this.txtTradeInValue.Text);

                if (tradeInValue < 0)
                {
                    this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot be less than 0.");
                }
            }
            catch (FormatException)
            {
                this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
            }

            if (tradeInValue > vehicleSalePrice)
            {
                this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
            }

            if (this.errorProvider.GetError(this.txtVehicleSalesPrice).Equals(string.Empty) &&
                this.errorProvider.GetError(this.txtTradeInValue).Equals(string.Empty))
            {
                Accessories accessories = Accessories.None;

                if (this.chkStereoSystem.Checked && this.chkLeatherInterior.Checked && this.chkComputerNavigation.Checked)
                {
                    accessories = Accessories.All;
                }
                else if (this.chkStereoSystem.Checked && this.chkLeatherInterior.Checked)
                {
                    accessories = Accessories.StereoAndLeather;
                }
                else if (this.chkStereoSystem.Checked && this.chkComputerNavigation.Checked)
                {
                    accessories = Accessories.StereoAndNavigation;
                }
                else if (this.chkLeatherInterior.Checked && this.chkComputerNavigation.Checked)
                {
                    accessories = Accessories.LeatherAndNavigation;
                }
                else if (this.chkStereoSystem.Checked)
                {
                    accessories = Accessories.StereoSystem;
                }
                else if (this.chkLeatherInterior.Checked)
                {
                    accessories = Accessories.LeatherInterior;
                }
                else if (this.chkComputerNavigation.Checked)
                {
                    accessories = Accessories.ComputerNavigation;
                }

                ExteriorFinish exteriorFinish = ExteriorFinish.None;

                if (this.radStandard.Checked)
                {
                    exteriorFinish = ExteriorFinish.Standard;
                }
                else if (this.radPearlized.Checked)
                {
                    exteriorFinish = ExteriorFinish.Pearlized;
                }
                else if (this.radCustomizedDetailing.Checked)
                {
                    exteriorFinish = ExteriorFinish.Custom;
                }

                SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessories, exteriorFinish);

                this.lblSummaryVehicleSalePriceBox.Text = vehicleSalePrice.ToString("c");
                this.lblOptionsBox.Text = salesQuote.TotalOptions.ToString("n");
                this.lblSubtotalBox.Text = salesQuote.SubTotal.ToString("c");
                this.lblSalesTaxBox.Text = salesQuote.SalesTax.ToString("n");
                this.lblTotalBox.Text = salesQuote.Total.ToString("c");
                this.lblTradeInBox.Text = "-" + tradeInValue.ToString("n");
                this.lblAmountDueBox.Text = salesQuote.AmountDue.ToString("c");

                decimal rate = this.nudAnnualInterestRate.Value / 100 / 12;
                decimal numberOfPaymentPeroids = this.nudNumberOfYears.Value * 12;
                decimal presentValue = salesQuote.AmountDue;

                this.lblMonthlyPaymentBox.Text = Financial.GetPayment(rate, (int)numberOfPaymentPeroids, presentValue).ToString("c");

                salesQuote = null;
            }
        }

        // <summary>
        // Handles the Load event of this form.
        // </summary>
        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            this.txtVehicleSalesPrice.Text = string.Empty;
            this.txtTradeInValue.Text = "0";
            this.lblMonthlyPaymentBox.Text = string.Empty;
        }
    }
}
