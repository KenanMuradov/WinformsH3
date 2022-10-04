using System.Text.RegularExpressions;

namespace WinformsH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double gasStationPayment = 0;
        private double miniCafePayment = 0;

        private void MessageBoxCustom(string message) => MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void combobGasType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGasPrice.Text = (sender as ComboBox)?.Text switch
            {
                "Diesel" => 0.5.ToString(),
                "A-72" => 0.75.ToString(),
                "A-92" => 1.3.ToString(),
                "A-95" => 1.75.ToString(),
                "A-100" => 2.5.ToString(),
                _ => 0.ToString(),
            };


            lblGasStationPayment.Text = "0$";
            foreach (var txt in panelGasPayment.Controls.OfType<TextBox>())
                txt.Text = string.Empty;

        }

        private void rbByVolume_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByVolume.Checked)
            {
                txtByVolume.ReadOnly = false;
                txtByPrice.Text = string.Empty;
                txtByVolume.Text = string.Empty;
                txtByPrice.ReadOnly = true;
            }
            lblGasStationPayment.Text = 0.ToString() + "$";
        }

        private void rbByPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByPrice.Checked)
            {
                txtByPrice.ReadOnly = false;
                txtByVolume.Text = string.Empty;
                txtByPrice.Text = string.Empty;
                txtByVolume.ReadOnly = true;
            }
            lblGasStationPayment.Text = 0.ToString() + "$";
        }

        private void txtGasStation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox)!.Text))
                return;

            if (string.IsNullOrWhiteSpace(combobGasType.Text))
            {
                if ((sender as TextBox)!.Text == 0.ToString())
                    return;

                MessageBoxCustom("Please Choose Gas Type First");
                (sender as TextBox)!.Text = 0.ToString();
            }

            if (!Regex.Match((sender as TextBox)?.Text!, @"^([0-9]+([,][0-9]*)?|[,][0-9]+)$").Success)
            {
                (sender as TextBox)!.Text = string.Empty;
                lblGasStationPayment.Text = 0.ToString() + "$";
                MessageBoxCustom("Only numbers allowed");
                return;
            }

            if (rbByPrice.Checked)
                gasStationPayment = double.Parse((sender as TextBox)!.Text);
            else
                gasStationPayment = double.Parse((sender as TextBox)!.Text) * double.Parse(txtGasPrice.Text);

            lblGasStationPayment.Text = gasStationPayment.ToString() + "$";
            lblTotalAmount.Text = (miniCafePayment + gasStationPayment).ToString() + '$';

        }

        private void checkBoxMiniCafe_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox)!.Checked)
            {
                foreach (var control in (sender as CheckBox)!.Parent.Controls.OfType<TextBox>())
                {
                    control.ReadOnly = false;
                    control.Text = string.Empty;
                }
                return;
            }

            foreach (var control in (sender as CheckBox)!.Parent.Controls.OfType<TextBox>())
            {
                control.Text = "0";
                control.ReadOnly = true;
            }
        }

        private void txtMiniCafe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox)!.Text))
                return;

            if (!Regex.Match((sender as TextBox)?.Text!, @"^(0|[1-9][0-9]*)$").Success)
            {
                (sender as TextBox)!.Text = string.Empty;
                MessageBoxCustom("Only numbers allowed");
                return;
            }



            double sum = 0;
            double price;
            int amount;

            foreach (var panel in gbMiniCafe.Controls.OfType<Panel>())
            {
                price = 0;
                amount = 0;
                foreach (var control in panel.Controls)
                {
                    if (control is Label l)
                        price = double.Parse(l.Text);
                    if (control is TextBox t && !string.IsNullOrEmpty(t.Text))
                        amount = int.Parse(t.Text);
                }

                sum += amount * price;
            }

            miniCafePayment = sum;

            lblMiniCafePayment.Text = miniCafePayment.ToString() + '$';

            lblTotalAmount.Text = (miniCafePayment + gasStationPayment).ToString() + '$';
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lblTotalAmount.Text == "0$")
            {
                MessageBoxCustom("You Haven't bought anything");
                return;
            }

            MessageBoxCustom(@$"Your Payment Is: {lblTotalAmount.Text}
Thanks For Choosing Us!");

            foreach (var gb in Controls.OfType<GroupBox>())
            {
                foreach (var lbl in gb.Controls.OfType<Label>())
                {
                    if (lbl.Text.Contains('$'))
                        lbl.Text = "0$";
                }

                foreach (var txt in gb.Controls.OfType<TextBox>())
                    txt.Text = 0.ToString();

                foreach (var comboBox in gb.Controls.OfType<ComboBox>())
                    comboBox.SelectedItem = string.Empty;

                foreach (var panel in gb.Controls.OfType<Panel>())
                {
                    foreach (var rb in panel.Controls.OfType<RadioButton>())
                        rb.Checked = false;

                    foreach (var cb in panel.Controls.OfType<CheckBox>())
                        cb.Checked = false;

                    foreach (var txt in panel.Controls.OfType<TextBox>())
                        txt.Text = 0.ToString();
                }

                gasStationPayment = 0;
                miniCafePayment = 0;

            }
        }

    }
}