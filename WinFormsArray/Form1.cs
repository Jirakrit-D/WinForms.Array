namespace WinFormsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "คิม";
            student[1] = "ไอคิว";
            student[2] = "เขตต์";
            student[3] = "โชกุน";
            student[4] = "ต้นกล้า";
            string test = "";
            int n = student.Length;   //หาขนาดของ Array
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "ทุเรียน", "มะกอก", "บักแงว", "หมากเม่า", "บักหุ่ง", "บักเล็บแมว" };
            string myFruit = "";
            foreach (string str in Fruits)
            {
                myFruit += str + ", ";
            }
            MessageBox.Show(myFruit, "ผลไม้ของฉัน");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;   //ข้อมูลแต่ละบรรทัดไปใส่ใน Array
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }

            }
            label1.Text = result;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str,out x))
                {
                    result += x.ToString() + Environment.NewLine;
                }
            }
            label1.Text = result;
        }
    }
}
