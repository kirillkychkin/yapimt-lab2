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
            return "��������� ����������� � 2025 ���� � ������ ������ '����� ���������������� � ������ ����������' � �������� ������ ������������ ������." + Environment.NewLine + Environment.NewLine + "��������� ������� ��� ��������� ���������� �����";
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getAboutText());
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
