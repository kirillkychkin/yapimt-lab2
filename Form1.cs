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

        private void copiesBtn_Click(object sender, EventArgs e)
        {
            string src = copiesSource.Text;
            string strb = "";
            int lenght = TestInput.TestInt32(copiesNum.Text);

            StringMethods.Copies(src, ref strb, lenght);

            copiesResult.Text = strb;
        }

        private void wordsBtn_Click(object sender, EventArgs e)
        {
            string str = wordsSource.Text;
            wordsRes.Text = StringMethods.Words(str).ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
