using CurrencyConverter = Currency_Conventer___ETS_PBKK.CurrencyConverter;
namespace Currency_Conventer___ETS_PBKK
{
    public partial class Form1 : Form
    {
        CurrencyConverter currencyConverter;
        public Form1()
        {
            InitializeComponent();
            currencyConverter = new CurrencyConverter();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> symbolData = currencyConverter.getSymbols();
            cmbFromCurrency.Items.Clear();
            cmbToCurrency.Items.Clear();

            cmbFromCurrency.DataSource = new BindingSource(symbolData, null);
            cmbFromCurrency.DisplayMember = "Value";
            cmbFromCurrency.ValueMember = "Key";


            cmbToCurrency.DataSource = new BindingSource(symbolData, null);
            cmbToCurrency.DisplayMember = "Value";
            cmbToCurrency.ValueMember = "Key";


            if (symbolData.Keys.Count > 1)
            {
                cmbFromCurrency.SelectedIndex = 0;
                cmbToCurrency.SelectedIndex = 1;
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            string fromCurrencySymbol = ((KeyValuePair<string, string>)cmbFromCurrency.SelectedItem).Key;
            string toCurrencySymbol = ((KeyValuePair<string, string>)cmbToCurrency.SelectedItem).Key;
            double currencyAmount = double.Parse(txtFromCurrency.Text);
            double finalValue = currencyConverter.Convert(fromCurrencySymbol, toCurrencySymbol, currencyAmount);
            txtToCurrency.Text = finalValue.ToString();
        }
    }
}