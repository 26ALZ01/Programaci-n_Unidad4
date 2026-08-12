namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = 1;
                Application.DoEvents();
                Thread.Sleep(30);
            }
        }
    }
}
