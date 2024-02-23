using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoHill
{
    public partial class Form1 : Form
    {
        public Dictionary<char, int> Alfavit = new Dictionary<char, int>();
        public int[,] A;
        public string InpString;
        public int n;
        public Form1()
        {
            InitializeComponent();
            dataGridViewMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewMain.Height = 180;
            n = 3;
            for (int i = 0; i < n; i++)
            {
                dataGridViewMain.Columns.Add("Column" + i.ToString(), "");
                dataGridViewMain.Rows.Add();
                dataGridViewMain.Rows[i].Height = dataGridViewMain.Height / n-1;
            }
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < alpha.Length; i++)
            {
                Alfavit.Add(alpha[i], (i+1) % alpha.Length);
            }
            //MessageBox.Show(Alfavit.ContainsKey('A').ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GetMassA();
            InpString = textBox1.Text;
            while (InpString.Length % n != 0)
            {
                InpString += "Z";
            }
            InpString = InpString.ToUpper();
            CreateHill1(InpString);
        }

        private void CreateHill1(string s)
        {
            while(s.Length % n != 0)
            {
                s += "Z";
            }
            char[] beta = s.ToCharArray();
            int t = s.Length / n;
            int[][] mda = new int[t][];
            for (int i = 0; i < t; i++)
            {
                mda[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    mda[i][j] = Alfavit[beta[i*n+j]];
                }
            }//составил вектора из буковок)

            int[][] newmda = new int[t][];
            for (int i = 0; i < t; i++)
            {
                newmda[i] = Multi(A, mda[i]);
            }
            string res = "";
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res += Alfavit.FirstOrDefault(x => x.Value==newmda[i][j]).Key;
                }
            }
            textBox2.Text = res;
        }

        private int[] Multi(int[,] a, int[] b)
        {
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += (a[i, j] * b[j]) % 26;
                }
                res[i] = sum % 26;
            }
            return res;
        }

        public void GetMassA()
        {
            A = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(dataGridViewMain.Rows[i].Cells[j].Value.ToString());
                }
            }
        }
    }
}
