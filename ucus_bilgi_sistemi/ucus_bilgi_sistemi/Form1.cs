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

            /* YÖN DEĞİSTİRME!!!  
             1. "To" da ki değeri label10'a aktardık;
             2. "From" da ki deðeri "To" değerine aktardık;
             3. label10'da ki değeri "From" değerine aktardık;
            */
            
            /* CHANGE DIRECTION!!!
               1. We transferred the value in "To" to label10;
               2. We transferred the value in "From" to "To";
               3. We transferred the value "From" in label10;
              */
        }
    }
}
