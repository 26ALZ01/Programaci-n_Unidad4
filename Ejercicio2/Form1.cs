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

            string genero = "";
            if (radioButton1.Checked)
                genero = "masculino";
            if (radioButton2.Checked)
                genero = "Femenino";

            //Mostrar la información
            MessageBox.Show("DATOS DEL ESTUDIANTE\n\n" +
                "Nombre: " + textBox1.Text +
                "\nEdad: " + numericUpDown1.Value +
                "\nNivel Académico: " + comboBox1.Text +
                "\nFecha de Nacimiento" + dateTimePicker1.Text +
                "\nGénero: " + genero +
                "\nInformación del Estudiante Inscrito!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Seleccione una Fotografía";
            abrir.Filter = "Archivos de Imagen|* .jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(abrir.FileName);
            }
        }
    }
}
