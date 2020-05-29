using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobbleAndSelectionSort
{
    
    public partial class Form1 : Form
    {
        //自行輸入的氣泡排序法
        int[] SortArray = new int[5];
        int register = new int();
        string Msg = "";
        //亂數產生氣泡排序法，用上面的~

        //選擇排序法
        public static int Num = 10;
        public static int[] A = new int[Num];
        static string TempStr1 = "";

        public Form1()
        {
            InitializeComponent();
            
        }
        public void Form1_Load(object sender,EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref SortArray, 5);
            TextBox[] txtArray = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            Msg = "";
            try
            {
                for (int i = 0; i <= 4; i++)
                {
                    SortArray[i] = Convert.ToInt32(txtArray[i].Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            for (int round = 0; round < 4; round++)
            {
                for (int i = 0 ; i < 4; i++)
                {
                    if (SortArray[i + 1] > SortArray[i])
                    {//從左大到右小
                        register = SortArray[i + 1];
                        SortArray[i + 1] = SortArray[i];
                        SortArray[i] = register;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Msg += SortArray[i] + "　";
            }
            MessageBox.Show($"大小依序為：{Msg}");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            labelRandom.Text = "產生十個亂數值：";
            Array.Resize(ref SortArray, 10);

            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                register = r.Next(10, 101);
                labelRandom.Text += "　" + register.ToString();
                SortArray[i] = register;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelSortRandom.Text = "排序十個亂數值：";
            for (int x = 0; x < 9; x++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (SortArray[i + 1] < SortArray[i])
                    {//從左大到右小
                        register = SortArray[i + 1];
                        SortArray[i + 1] = SortArray[i];
                        SortArray[i] = register;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                labelSortRandom.Text += "　" + SortArray[i];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           RandomNum();//產生亂數副程式
            label4.Text = TempStr1;
        }
        public static void RandomNum()
        {
            Random r = new Random();
            TempStr1 = "產生十個亂數值：";
            for (int i = 0; i < 10; i++)
            {
                A[i] = r.Next(10, 101);
                TempStr1 += "　" + A[i];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelSort();
            PrintSelSort();
            label3.Text = TempStr1;
        }
        public static void SelSort()
        {
            int min,temp = new int();

            for (int x = 0; x < 9; x++)
            {
                min = x;
                for (int i = x+1; i < 10; i++)
                { 
                    if (A[min] > A[i])
                    {
                        min = i;
                        Console.WriteLine("變更後的數字" + A[min]);
                    }
                }
                temp = A[x];
                A[x] = A[min];
                A[min] = temp;
            }
        }
        public static void PrintSelSort()
        {
            TempStr1 = "排序十個亂數值：";
            for (int i = 0; i < 10; i++)
            {
                TempStr1 += "　" + A[i];
            }
            
        }
    }
}
