namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker1.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            // Adjust age if birthday hasn't occurred this year yet
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            label1.Text = $"You are: {age} years old";

        }
    }
}
