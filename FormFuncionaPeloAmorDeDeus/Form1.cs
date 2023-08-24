namespace FormFuncionaPeloAmorDeDeus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.TopLevel = false;
            painel.Controls.Add(inicio);

            inicio.Location = new Point(painel.Width/2 - inicio.Width/2, painel.Height / 2 - inicio.Height / 2);
            
            inicio.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.TopLevel = false;
            painel.Controls.Add(login);

            login.Location = new Point(painel.Width / 2 - login.Width / 2, painel.Height / 2 - login.Height / 2);

            login.Show();
        }
    }
}