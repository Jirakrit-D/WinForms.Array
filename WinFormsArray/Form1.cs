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
            student[0] = "���";
            student[1] = "�ͤ��";
            student[2] = "ࢵ��";
            student[3] = "⪡ع";
            student[4] = "�鹡���";
            string test = "";
            int n = student.Length;   //�Ң�Ҵ�ͧ Array
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "���", "�����¹", "�С͡", "�ѡ��", "��ҡ����", "�ѡ���", "�ѡ������" };
            string myFruit = "";
            foreach (string str in Fruits)
            {
                myFruit += str + ", ";
            }
            MessageBox.Show(myFruit, "�����ͧ�ѹ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;   //���������к�÷Ѵ����� Array
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
            int sum = 0;
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))
                {
                    sum += x;
                    result += x.ToString() + Environment.NewLine;
                }
            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "������ͧ����Ţ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3,2];
            student[0, 0] = "�ͻ�";
            student[0, 1] = "�֧���";
            student[1, 0] = "���";
            student[1, 1] = "�شøҹ�";
            student[2, 0] = "����";
            student[2, 1] = "˹ͧ�������";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j] + "-";
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData,"�ʴ�������� Array 2 �Ե�");
        }
    }
}
