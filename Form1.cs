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
            return "Программа разработана в 2025 году в рамках каурса 'Языки программирования и методы трансляции' в качестве второй лабораторной работы." + Environment.NewLine + Environment.NewLine + "Программа создана для обработки символьных строк";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getAboutText());
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copiesBtn_Click(object sender, EventArgs e)
        {
            string src = copiesSource.Text;
            string strRes = "";
            int lenght = TestInput.TestInt32(copiesNum.Text);

            StringMethods.Copies(src, ref strRes, lenght);

            copiesResult.Text = strRes;
        }

        private void wordsBtn_Click(object sender, EventArgs e)
        {
            string str = wordsSource.Text;
            wordsRes.Text = StringMethods.Words(str).ToString();
        }

        private void concatBtn_Click(object sender, EventArgs e)
        {
            string first = concatFirst.Text;
            string second = concatSecond.Text;
            concatResult.Text = StringMethods.Concat(first, second);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string str = deleteSource.Text;
            int pos = TestInput.TestInt32(deleteStart.Text);
            int lenght = TestInput.TestInt32(deleteLen.Text);

            StringMethods.Delete(ref str, pos, lenght);

            deleteRes.Text = str;
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            string str = reverseStr.Text;
            StringMethods.Reverse(ref str);
            reverseStr.Text = str;
        }

        private void wordBtn_Click(object sender, EventArgs e)
        {
            string str = wordStr.Text;
            string word = StringMethods.Word(str);
            wordRes.Text = word;
        }

        private void compulBtn_Click(object sender, EventArgs e)
        {
            string first = compulFirst.Text;
            string second = compulSecond.Text;
            int res = StringMethods.Compul(first, second);

            if (res == 0)
            {
                compulRes.Text = "Строка 1 идентична Строке 2";
            }
            else if (res > 0)
            {
                compulRes.Text = "Строка 1 больше Строки 2";
            }
            else
            {
                compulRes.Text = "Строка 1 меньше Строки 2";
            }
        }

        private void findwordBtn_Click(object sender, EventArgs e)
        {
            string str = findwordsSrc.Text;
            string search = findwordSearch.Text;
            int res = StringMethods.Findwords(str, search);

            if (res >= 0)
            {
                findwordsRes.Text = $"Найдено, позиция: {res}";
            }
            else
            {
                findwordsRes.Text = "Не найдено";
            }
        }

        private void overlayBtn_Click(object sender, EventArgs e)
        {

            string str = overlayBase.Text;
            string strOverlay = overlayOverlay.Text;
            int pos = TestInput.TestInt32(overlayStartPos.Text);

            StringMethods.Overlay(ref str, strOverlay, pos);

            overlayRes.Text = str;
        }

        private void strSetBtn_Click(object sender, EventArgs e)
        {

            string str = strSetBase.Text;
            int pos = TestInput.TestInt32(strSetStartPos.Text);
            int length = TestInput.TestInt32(strSetLength.Text);
            char symbol = strSetSymbol.Text.ToCharArray()[0];

            StringMethods.StrSet(ref str, pos, length, symbol);

            strSetRes.Text = str;
        }
    }
}
