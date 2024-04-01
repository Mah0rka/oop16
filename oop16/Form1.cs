namespace oop16
{
    public partial class Form1 : Form
    {
        StringArray[] arrays;//����� ����� ����� ��� ������� � 2 ��������
        private int i_for_in = 0;
        private int y_for_in = 0;
        private int i_for_rows = 0;
        private bool memory = false;


        public Form1()
        {
            InitializeComponent();
        }
        private void button_len_Click(object sender, EventArgs e)//�������� ����� ��� ������ �����
        {
            try
            {
                if (!memory)
                    array_num();

                arrays[i_for_rows] = new StringArray(Convert.ToInt32(textBox_lenght.Text));
                i_for_rows++;
                label_i_for_rows.Text = (i_for_rows + 1).ToString();
                if (i_for_rows == arrays.Length)
                {
                    label_i_for_rows.Text = string.Empty;
                    textBox_lenght.BackColor = Color.Green;
                    MessageBox.Show("���'��� ������� ������");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("������ �� ���� ��������!");
            }
        }

        private void button_in_Click(object sender, EventArgs e)//�������� �����
        {
            try
            {
                if (textBox_lenght.Text == string.Empty)
                    throw new Exception("������ ������� ������");

                arrays[y_for_in].Array[i_for_in] = textBox_array.Text;

                i_for_in++;
                label_index.Text = i_for_in.ToString();

                if (arrays[y_for_in].lenght == i_for_in)
                {
                    y_for_in++;
                    label_y_for_in.Text = (y_for_in + 1).ToString();
                    label_index.Text = "0";
                    i_for_in = 0;
                }
                if (y_for_in == arrays.Length)
                {
                    label_index.Text = string.Empty;
                    label_y_for_in.Text = string.Empty;
                    MessageBox.Show("����� ���������");
                    textBox_array.BackColor = Color.Green;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("������ ������ �� �������!");
            }

        }

        private void button_out_Click(object sender, EventArgs e)
        {
            ArrayOutput();
        }

        private void ArrayOutput()//��������� ������
        {
            try
            {
                label_ans.Text += "�������� ������� ������: ";
                for (int i = 0; i < arrays.Length; i++)
                {
                    if (i == 1)
                    {
                        label_ans.Text += "\n\n�������� ������� ������: ";
                    }
                    foreach (string item in arrays[i].Array)
                    {
                        label_ans.Text += item + "; ";
                    }
                }
            }
            catch
            {
                label_ans.Text = string.Empty;
                MessageBox.Show("������ �� �������� ����!");
            }
        }
        private void array_num()//�������� ����� ��� ������ ����� �����
        {
            try
            {
                if (Convert.ToInt32(textBox_array_num.Text) < 1 || Convert.ToInt32(textBox_array_num.Text) > 2)
                    throw new Exception("³� 0 �� 2!");
                arrays = new StringArray[Convert.ToInt32(textBox_array_num.Text)];
                textBox_array_num.BackColor = Color.Green;
                memory = true;
            }
            catch (Exception)
            {
                MessageBox.Show("������ �� ���� ��������!");
            }
        }

        private void button_change_Click(object sender, EventArgs e)//�����������
        {
            try
            {
                arrays[Convert.ToInt32(textBox_arr_edit.Text) - 1].Array[Convert.ToInt32(textBox_el_edit.Text)] = textBox_edit.Text;
                label_ans.Text += ("\n\n��������� ���� �����������:\n\n");
                ArrayOutput();
            }
            catch (Exception)
            {
                MessageBox.Show("������ �� ���� ��������!");
            }
        }

        private void button1_Click(object sender, EventArgs e)//������
        {
            try
            {
                StringArray stringArray = new StringArray();

                stringArray = arrays[0].MargeAndDelate(arrays[1]);
                label_ans.Text += ("\n\n��������� ���� ������:\n\n");
                foreach (string item in stringArray.Array)
                {
                    label_ans.Text += item + "; ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("������ �� ���� ��������!");
            }
        }

        private void button2_Click(object sender, EventArgs e)//���������
        {
            try
            {
                StringArray stringArray = new StringArray(arrays[0].lenght);
                stringArray = arrays[0] + arrays[1];

                label_ans.Text += ("\n\n��������� ���� ���������:\n\n");
                foreach (string item in stringArray.Array)
                {
                    label_ans.Text += item + "; ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("������ �� ���� ��������!");
            }
        }
    }
}
