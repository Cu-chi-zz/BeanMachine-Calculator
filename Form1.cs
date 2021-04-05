using System;
using System.Windows.Forms;

namespace BeanMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static short SellerItemPrice = 20;
        public static int PriceCoffee = 45;
        public static int ValueCoffee = 0;
        public static int PriceCappuccino = 50;
        public static int ValueCappuccino = 0;
        public static int PriceMilkShake = 45;
        public static int ValueMilkShake = 0;
        public static int PriceMuffin = 40;
        public static int ValueMuffin = 0;
        public static int PriceDonuts = 35;
        public static int ValueDonuts = 0;
        public static int PriceIceCream = 40;
        public static int ValueIceCream = 0;
        public static int PriceTea = 40;
        public static int ValueTea = 0;
        public static int PriceChoco = 50;
        public static int ValueChoco = 0;
        public static int PriceBrownies = 40;
        public static int ValueBrownies = 0;

        // CheckBox part
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCoffee.Checked == false)
            {
                TrackbarCoffee.Enabled = false;
                CoffeeTextBox.Enabled = false;
            }
            else
            {
                TrackbarCoffee.Enabled = true;
                CoffeeTextBox.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBoxCappuccino.Checked == false)
            {
                CappuccinoTrackBar.Enabled = false;
                CappuccinoTextBox.Enabled = false;
            }
            else
            {
                CappuccinoTrackBar.Enabled = true;
                CappuccinoTextBox.Enabled = true;
            }
        }

        private void MilkShakeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MilkShakeCheckBox.Checked == false)
            {
                TrackbarMilkshake.Enabled = false;
                TextBoxMilkShake.Enabled = false;
            }
            else
            {
                TrackbarMilkshake.Enabled = true;
                TextBoxMilkShake.Enabled = true;
            }
        }

        private void MuffinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MuffinCheckBox.Checked == false)
            {
                MuffinTrackBar.Enabled = false;
                MuffinTextBox.Enabled = false;
            }
            else
            {
                MuffinTrackBar.Enabled = true;
                MuffinTextBox.Enabled = true;
            }
        }

        private void DonutsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DonutsCheckbox.Checked == false)
            {
                DonutsTrackbar.Enabled = false;
                DonutsTextBox.Enabled = false;
            }
            else
            {
                DonutsTrackbar.Enabled = true;
                DonutsTextBox.Enabled = true;
            }
        }

        private void ICCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ICCheckbox.Checked == false)
            {
                ICTrackBar.Enabled = false;
                ICTextbox.Enabled = false;
            }
            else
            {
                ICTrackBar.Enabled = true;
                ICTextbox.Enabled = true;
            }
        }

        private void TeaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCB.Checked == false)
            {
                TeaTB.Enabled = false;
                TeaTxtB.Enabled = false;
            }
            else
            {
                TeaTB.Enabled = true;
                TeaTxtB.Enabled = true;
            }
        }

        private void CCCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CCCB.Checked == false) { CCTrackbar.Enabled = false; CCTxtbox.Enabled = false; }
            else
            { CCTrackbar.Enabled = true;
                CCTxtbox.Enabled = true;
            }
        }

        private void BrownieCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BrownieCB.Checked == false)
            {
                BrownieTrackBar.Enabled = false;
                BrownieTb.Enabled = false;
            }
            else
            {
                BrownieTrackBar.Enabled = true;
                BrownieTb.Enabled = true;
            }
        }

        ///////////////////////////////////////////
        //              Coffee Part              //
        ///////////////////////////////////////////
        private void TrackbarCoffee_ValueChanged(object sender, EventArgs e)
        {
            ValueCoffee = TrackbarCoffee.Value;
            try { ValueCoffee = Int32.Parse(CoffeeTextBox.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            CoffeeTextBox.Text = TrackbarCoffee.Value.ToString();
            ReloadPrice();
        }

        private void CoffeeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValueCoffee = TrackbarCoffee.Value;
            try
            {
                ValueCoffee = Int32.Parse(CoffeeTextBox.Text);
                TrackbarCoffee.Value = ValueCoffee;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //            Cappuccino Part            //
        ///////////////////////////////////////////
        private void trackBar1_ValueChanged_1(object sender, EventArgs e)
        {
            ValueCappuccino = CappuccinoTrackBar.Value;
            try { ValueCappuccino = Int32.Parse(CappuccinoTextBox.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            CappuccinoTextBox.Text = CappuccinoTrackBar.Value.ToString();
            ReloadPrice();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValueCappuccino = CappuccinoTrackBar.Value;
            try
            {
                ValueCappuccino = Int32.Parse(CappuccinoTextBox.Text);
                CappuccinoTrackBar.Value = ValueCappuccino;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //            MilkShake Part             //
        ///////////////////////////////////////////
        private void TrackbarMilkshake_ValueChanged(object sender, EventArgs e)
        {
            ValueMilkShake = TrackbarMilkshake.Value;
            try { ValueMilkShake = Int32.Parse(CappuccinoTextBox.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            TextBoxMilkShake.Text = TrackbarMilkshake.Value.ToString();
            ReloadPrice();
        }

        private void TextBoxMilkShake_TextChanged(object sender, EventArgs e)
        {
            ValueMilkShake = TrackbarMilkshake.Value;
            try
            {
                ValueMilkShake = Int32.Parse(TextBoxMilkShake.Text);
                TrackbarMilkshake.Value = ValueMilkShake;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //              Muffin Part              //
        ///////////////////////////////////////////
        private void MuffinTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ValueMuffin = MuffinTrackBar.Value;
            try { ValueMuffin = Int32.Parse(MuffinTextBox.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            MuffinTextBox.Text = MuffinTrackBar.Value.ToString();
            ReloadPrice();
        }

        private void MuffinTextBox_TextChanged(object sender, EventArgs e)
        {
            ValueMuffin = MuffinTrackBar.Value;
            try
            {
                ValueMuffin = Int32.Parse(MuffinTextBox.Text);
                MuffinTrackBar.Value = ValueMuffin;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //              Donuts Part              //
        ///////////////////////////////////////////
        private void DonutsTrackbar_ValueChanged_1(object sender, EventArgs e)
        {
            ValueDonuts = DonutsTrackbar.Value;
            try { ValueDonuts = Int32.Parse(DonutsTextBox.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            DonutsTextBox.Text = DonutsTrackbar.Value.ToString();
            ReloadPrice();
        }

        private void DonutsTextBox_TextChanged_1(object sender, EventArgs e)
        {
            ValueDonuts = DonutsTrackbar.Value;
            try
            {
                ValueDonuts = Int32.Parse(DonutsTextBox.Text);
                DonutsTrackbar.Value = ValueDonuts;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //              IceCream Part            //
        ///////////////////////////////////////////
        private void ICTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ValueIceCream = ICTrackBar.Value;
            try { ValueIceCream = Int32.Parse(ICTextbox.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            ICTextbox.Text = ICTrackBar.Value.ToString();
            ReloadPrice();
        }

        private void ICTextbox_TextChanged(object sender, EventArgs e)
        {
            ValueIceCream = ICTrackBar.Value;
            try
            {
                ValueIceCream = Int32.Parse(ICTextbox.Text);
                ICTrackBar.Value = ValueIceCream;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //                Tea Part               //
        ///////////////////////////////////////////
        private void TeaTxtB_TextChanged(object sender, EventArgs e)
        {
            ValueTea = TeaTB.Value;
            try
            {
                ValueTea = Int32.Parse(TeaTxtB.Text);
                TeaTB.Value = ValueTea;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        private void TeaTB_ValueChanged(object sender, EventArgs e)
        {
            ValueTea = TeaTB.Value;
            try { ValueTea = Int32.Parse(TeaTxtB.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            TeaTxtB.Text = TeaTB.Value.ToString();
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //                 CC Part               //
        ///////////////////////////////////////////
        private void CCTb_TextChanged(object sender, EventArgs e)
        {
            ValueChoco = CCTrackbar.Value;
            try
            {
                ValueChoco = Int32.Parse(CCTxtbox.Text);
                CCTrackbar.Value = ValueChoco;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        private void CCTrackbar_ValueChanged(object sender, EventArgs e)
        {
            ValueChoco = CCTrackbar.Value;
            try { ValueChoco = Int32.Parse(CCTxtbox.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            CCTxtbox.Text = CCTrackbar.Value.ToString();
            ReloadPrice();
        }

        ///////////////////////////////////////////
        //              Brownies Part            //
        ///////////////////////////////////////////
        private void BrownieTb_TextChanged(object sender, EventArgs e)
        {
            ValueBrownies = BrownieTrackBar.Value;
            try
            {
                ValueBrownies = Int32.Parse(BrownieTb.Text);
                BrownieTrackBar.Value = ValueBrownies;
            }
            catch { Console.WriteLine("textBox is empty."); }
            ReloadPrice();
        }

        private void BrownieTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ValueBrownies = BrownieTrackBar.Value;
            try { ValueBrownies = Int32.Parse(BrownieTb.Text); }
            catch { Console.WriteLine("textBox is empty."); }
            BrownieTb.Text = BrownieTrackBar.Value.ToString();
            ReloadPrice();
        }

        /////////////////////////////////////////////
        private void ReloadPrice()
        {
            int ClientPrice =
                (ValueCoffee * PriceCoffee) +
                (ValueCappuccino * PriceCappuccino) +
                (ValueMilkShake * PriceMilkShake) +
                (ValueMuffin * ValueMuffin) +
                (ValueDonuts * PriceDonuts) +
                (ValueIceCream * PriceIceCream) +
                (ValueTea * PriceTea) +
                (ValueChoco * PriceChoco) +
                (ValueBrownies * PriceBrownies);

            int SellerPrice =
                (ValueCoffee +
                ValueCappuccino +
                ValueMilkShake +
                ValueMuffin +
                ValueDonuts +
                ValueIceCream +
                ValueTea +
                ValueChoco +
                ValueBrownies)* SellerItemPrice;
            TotalPriceLabel.Text = $"{ClientPrice}$";
            PriceSellerLabel.Text = $"{SellerPrice}$";
        }
    }
}