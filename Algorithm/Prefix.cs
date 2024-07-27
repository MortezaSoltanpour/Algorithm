using System.Data;

namespace Algorithm
{
    public partial class Prefix : Form
    {
        public Prefix()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnFound_Click(object sender, EventArgs e)
        {
            int maxLength = GetMaxLength();
            Dictionary<string, int> eachPrefix = new Dictionary<string, int>();

            string prefix = string.Empty;

            for (int i = 0; i < listBox1.Items.Count; i++)
                for (int j = 0; j <= maxLength; j++)
                    if (listBox1.Items[i].ToString().Length >= j)
                    {
                        var sa = GetFirstMostIterate(j, prefix);
                        if (sa.Any())
                        {
                            eachPrefix.Add(prefix + sa.First().Key, sa.First().Value);
                            prefix += sa.First().Key;
                        }
                    }

            string result = string.Empty;
            int maxIterate = eachPrefix.Max(p => p.Value);
            foreach (var item in eachPrefix.Where(p => p.Value == maxIterate))
                if (item.Key.Length > result.Length)
                    result = item.Key;

            lblResult.Text = $"prefix : {result}";
        }


        int GetMaxLength()
        {
            int max = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
                if (listBox1.Items[i].ToString().Length > max)
                    max = listBox1.Items[i].ToString().Length;
            return max;
        }

        Dictionary<string, int> GetFirstMostIterate(int position, string prefix)
        {
            List<string> charArray = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
                if (listBox1.Items[i].ToString().StartsWith(prefix) && listBox1.Items[i].ToString().Length > position)
                    charArray.Add(listBox1.Items[i].ToString()[position].ToString());

            Dictionary<string, int> charCount = new Dictionary<string, int>();

            foreach (string c in charArray)
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;

            Dictionary<string, int> maxItems = new Dictionary<string, int>();

            if (charCount.Any())
            {
                var maxIterate = charCount.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
                foreach (var item in charCount)
                    if (item.Value == maxIterate)
                        maxItems.Add(item.Key, item.Value);
            }
            return maxItems;
        }
    }
}