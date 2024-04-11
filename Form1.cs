namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Repository rep = new Repository();
            mostrarInfo.DataSource = rep.getAllContactos();
        }
    }
}
