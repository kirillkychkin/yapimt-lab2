namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string getAboutText()
        {
            return "ѕрограмма разработана в 2025 году в рамках каурса 'языки программировани€ и методы трансл€ции' в качестве второй лабораторной работы." + Environment.NewLine + Environment.NewLine + "ѕрограмма создана дл€ обработки символьных строк";
        }

        private void оѕрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getAboutText());
        }

        private void выход»зѕрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
