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
        public int N = 26;
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
            GetInverseMatrix(A);
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
                    sum += (a[i, j] * b[j]) % N;
                }
                res[i] = sum % N;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetInverseMatrix(int[,] matrix)
        {
            int[,] newMatrix = new int[n, n];
            int opr = GetOpr(matrix); //находим определитель
            int invOpr = GetInverseOprforModule(opr, N); // обратное определителю по модулю
            //MessageBox.Show(opr.ToString()+ ',' + invOpr.ToString());
        }

        public int GetOpr(int[,] matrix)
        {
            return ((matrix[0, 0] * matrix[1, 1] * matrix[2, 2]
                + matrix[1, 0] * matrix[2, 1] * matrix[0, 2]
                + matrix[0, 1] * matrix[1, 2] * matrix[2, 0])
                - (matrix[0, 2] * matrix[1, 1] * matrix[2, 0]
                + matrix[0, 0] * matrix[1, 2] * matrix[2, 1]
                + matrix[2, 2] * matrix[0, 1] * matrix[1, 0]) + N*100) % N;
        }

        public int GetInverseOprforModule(int opr, int mod)
        {
            for (int i = 0; i < mod; i++)
            {
                if ((opr * i) % mod == 1)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
