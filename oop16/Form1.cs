namespace oop16
{
    public partial class Form1 : Form
    {
        StringArray[] arrays;//масив обєктів класів для випадку з 2 масивами
        private int i_for_in = 0;
        private int y_for_in = 0;
        private int i_for_rows = 0;
        private bool memory = false;


        public Form1()
        {
            InitializeComponent();
        }
        private void button_len_Click(object sender, EventArgs e)//виділення памяті для масиву рядків
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
                    MessageBox.Show("Пам'ять виділено успішно");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть усі данні коректно!");
            }
        }

        private void button_in_Click(object sender, EventArgs e)//введення даних
        {
            try
            {
                if (textBox_lenght.Text == string.Empty)
                    throw new Exception("Введіть довжину масиву");

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
                    MessageBox.Show("Масив заповнено");
                    textBox_array.BackColor = Color.Green;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Індекс більший за довжину!");
            }

        }

        private void button_out_Click(object sender, EventArgs e)
        {
            ArrayOutput();
        }

        private void ArrayOutput()//виведення данних
        {
            try
            {
                label_ans.Text += "Елементи першого масиву: ";
                for (int i = 0; i < arrays.Length; i++)
                {
                    if (i == 1)
                    {
                        label_ans.Text += "\n\nЕлементи другого масиву: ";
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
                MessageBox.Show("Введіть усі необхідні данні!");
            }
        }
        private void array_num()//виділення памяті для масиву обєктів класу
        {
            try
            {
                if (Convert.ToInt32(textBox_array_num.Text) < 1 || Convert.ToInt32(textBox_array_num.Text) > 2)
                    throw new Exception("Від 0 до 2!");
                arrays = new StringArray[Convert.ToInt32(textBox_array_num.Text)];
                textBox_array_num.BackColor = Color.Green;
                memory = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть усі данні коректно!");
            }
        }

        private void button_change_Click(object sender, EventArgs e)//Редагування
        {
            try
            {
                arrays[Convert.ToInt32(textBox_arr_edit.Text) - 1].Array[Convert.ToInt32(textBox_el_edit.Text)] = textBox_edit.Text;
                label_ans.Text += ("\n\nРезультат після редагування:\n\n");
                ArrayOutput();
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть усі данні коректно!");
            }
        }

        private void button1_Click(object sender, EventArgs e)//злиття
        {
            try
            {
                StringArray stringArray = new StringArray();

                stringArray = arrays[0].MargeAndDelate(arrays[1]);
                label_ans.Text += ("\n\nРезультат після злиття:\n\n");
                foreach (string item in stringArray.Array)
                {
                    label_ans.Text += item + "; ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть усі данні коректно!");
            }
        }

        private void button2_Click(object sender, EventArgs e)//зчеплення
        {
            try
            {
                StringArray stringArray = new StringArray(arrays[0].lenght);
                stringArray = arrays[0] + arrays[1];

                label_ans.Text += ("\n\nРезультат після зчеплення:\n\n");
                foreach (string item in stringArray.Array)
                {
                    label_ans.Text += item + "; ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть усі данні коректно!");
            }
        }
    }
}
