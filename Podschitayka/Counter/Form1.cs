using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Счётчик_букв
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string d = rich.Text;
            int result = Obrabotchik(d);
            string res = Convert.ToString(result);
            label2.Text = res;
        }

        private static int Obrabotchik(string d)
        {
            string s = d.ToLower();
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'а' || s[i] == 'о' || s[i] == 'у' || s[i] == 'е' || s[i] == 'ё' ||
                    s[i] == 'ы' || s[i] == 'э' || s[i] == 'я' || s[i] == 'и' || s[i] == 'ю')
                {
                    result += 1;
                }
                if (s[i] == '!')
                {
                    break;
                }
            }

            return result;
        }
    }
}
