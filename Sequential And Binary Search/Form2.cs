using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequential_And_Binary_Search
{
    public partial class Form2 : Form
    {
        static string tempStr;
        static int Num = 10;
        static int[] List = new int[Num];
        //二元搜尋法
        int SearchCount = 0;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button_SequentialRandom_Click(object sender, EventArgs e)
        {
            labelRandom.Text = RandomNum();
        }
        public static string RandomNum()
        {
            //
            Random r = new Random();
            tempStr = $"產生{Num}個亂數值：";
            for (int i = 0; i < Num; i++)
            {
                List[i] = r.Next(10, 101);
                tempStr += "　" + List[i].ToString();
                
            }
            return tempStr;
        }

        private void button_SequentialSearch_Click(object sender, EventArgs e)
        {
            int indata;
            try
            {
                indata = int.Parse(textBox1.Text);
                labelSequential.Text = $"搜尋的數值：{indata}在陣列中的第{Sequential_Search(ref List, List.Length, indata)}筆";
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入數字");
            }
        }
        public static int Sequential_Search(ref int[] List,int N,int key)
        {
            int index = new int();
            for (index = 0; index < N; index++)
            {
                if (List[index] == key)
                {
                    return index + 1;  //若符合條件，傳回索引值
                }
            }
            return index = -1 ;  //若找不到符合條件，傳回 - 1
        }

        private void button_Binary_Click(object sender, EventArgs e)
        {
            int index = -2;
            int Input = new int() ;
            try
            {
                Input = int.Parse(textBox_Binary.Text);
                index = FindNum(Input);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
            if (index != -1)
            {
                label_Binary.Text = $"搜索的數值 {Input} 在第{index + 1}筆";
            }
            else label_Binary.Text = $"無法搜尋到數值!";

        }
        public int FindNum(int Input)
        {
            SearchCount = 0;
            int High = List.Length - 1;
            int Low = 0;
            int Mid = (High + Low) / 2;
            
            //二元搜尋法
            while (true)
            {
                SearchCount += 1;
                if (Input > List[Mid])
                {
                    if (High == Low) return -1;
                    Low = Mid + 1;
                    Mid = (High + Low) / 2;
                }
                else if (Input == List[Mid])
                {
                    return Mid;
                }
                else if (Input < List[Mid])
                {
                    if (High == Low) return -1;
                    High = Mid - 1;
                    Mid = (High + Low) / 2;
                }
            }

        }
            private void button1_Click(object sender, EventArgs e)
            {
                //利用氣泡排序法完成
                int temp = 0;
                for (int i = 1; i <= List.Length - 1; i++) //總共要排序Length - 1個回合
                {
                    for (int x = 0; x < List.Length - 1; x++) //相互比對
                    {
                        if (List[x] > List[x + 1])
                        {
                            temp = List[x];
                            List[x] = List[x + 1];
                            List[x + 1] = temp;
                        }
                    }
                }
                labelRandom.Text = "排序過亂數值：";
                for (int i = 0; i < List.Length; i++)
                {
                    labelRandom.Text += "　" + List[i].ToString();
                }

            }
            }
}
