namespace GPAxCalculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPACal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInpu = Convert.ToDouble(input);
            oGPACal.addGPA(dInpu, name);

            double gpax = oGPACal.gatGPAx();
            textBoxGPAx.Text = gpax.ToString();

            double max = oGPACal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            string maxname = oGPACal.getMaxName();
            textBoxMaxName.Text = maxname.ToString();

            double min = oGPACal.gatMin();
            textBoxMinGPA.Text = min.ToString();
            string minname = oGPACal.getMinName();
            textBoxMinName.Text = minname.ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = string.Empty;
            textBoxAllData.Text = oGPACal.gatAlldata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
        }

    }
}