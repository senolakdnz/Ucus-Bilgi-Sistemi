namespace ucus_bilgi_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route : " + comboBox1.Text + " - " + comboBox2.Text);
            listBox1.Items.Add("Date : " + dateTimePicker1.Text);
            listBox1.Items.Add("Hours : " + maskedTextBox1.Text);

            listBox2.Items.Add("Name Surname : " + textBox1.Text + " " + textBox2.Text);
            listBox2.Items.Add("ID Number : " + maskedTextBox2.Text);
            listBox2.Items.Add("Phone : " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;

            /* Y�N DE���T�RME!!!  
             1. "To" da ki de�eri label10'a aktard�k
             2. "From" da ki de�eri "To" de�erine aktard�k
             3. label10'da ki de�eri "From" de�erine aktard�k
            */
        }
    }
}