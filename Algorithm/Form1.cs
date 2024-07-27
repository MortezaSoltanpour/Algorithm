namespace Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = AlignIt(textBox1.Text, int.Parse(textBox2.Text));
        }

        string AlignIt(string text, int length)
        {
            string[] arr = textBox1.Text.Split(' ');

            List<string> lines = new List<string>();
            string thisLineWords = string.Empty;
            int thisLine = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].Length + thisLine < length)
                {
                    thisLine += arr[i].Length + 1;
                    thisLineWords += arr[i] + " ";
                }
                else
                {
                    i--;
                    lines.Add(thisLineWords + Environment.NewLine);
                    thisLine = 0;
                    thisLineWords = string.Empty;
                }
            }

            string result = string.Empty;
            foreach (string line in lines)
            {
                string eachLine = line;
                if (eachLine.Length - 2 <= length)
                {
                    int spaceNeed = length - eachLine.Length + 2;
                    var words = eachLine.Split(" ");
                    for (int i = 0; i < Math.Min(words.Length, spaceNeed); i++)
                    {
                        words[i] = words[i] + "  ";
                    }

                    eachLine = "";
                    for (int i = 0; i < words.Length; i++)
                    {
                        eachLine += words[i];
                    }
                }

                result += eachLine;
            }
            return result;
        }
    }
}