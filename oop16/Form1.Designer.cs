namespace oop16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox_lenght = new TextBox();
            textBox_array = new TextBox();
            label2 = new Label();
            label4 = new Label();
            button_in = new Button();
            button_out = new Button();
            button_len = new Button();
            label_index = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_array_num = new TextBox();
            label7 = new Label();
            label_i_for_rows = new Label();
            label_y_for_in = new Label();
            label8 = new Label();
            label13 = new Label();
            textBox_el_edit = new TextBox();
            textBox_arr_edit = new TextBox();
            label14 = new Label();
            label15 = new Label();
            button_change = new Button();
            textBox_edit = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            label_ans = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 99);
            label1.Name = "label1";
            label1.Size = new Size(348, 30);
            label1.TabIndex = 0;
            label1.Text = "Введіть кількість елементів масиву";
            // 
            // textBox_lenght
            // 
            textBox_lenght.Location = new Point(409, 106);
            textBox_lenght.Name = "textBox_lenght";
            textBox_lenght.Size = new Size(47, 23);
            textBox_lenght.TabIndex = 1;
            // 
            // textBox_array
            // 
            textBox_array.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_array.Location = new Point(368, 156);
            textBox_array.Name = "textBox_array";
            textBox_array.Size = new Size(88, 33);
            textBox_array.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 155);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 3;
            label2.Text = "Введіть";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(136, 155);
            label4.Name = "label4";
            label4.Size = new Size(168, 30);
            label4.TabIndex = 5;
            label4.Text = "елемент масиву";
            // 
            // button_in
            // 
            button_in.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_in.Location = new Point(559, 151);
            button_in.Name = "button_in";
            button_in.Size = new Size(229, 45);
            button_in.TabIndex = 6;
            button_in.Text = "Ввести";
            button_in.UseVisualStyleBackColor = true;
            button_in.Click += button_in_Click;
            // 
            // button_out
            // 
            button_out.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_out.Location = new Point(555, 421);
            button_out.Name = "button_out";
            button_out.Size = new Size(229, 91);
            button_out.TabIndex = 7;
            button_out.Text = "Вивести результат";
            button_out.UseVisualStyleBackColor = true;
            button_out.Click += button_out_Click;
            // 
            // button_len
            // 
            button_len.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_len.Location = new Point(559, 48);
            button_len.Name = "button_len";
            button_len.Size = new Size(229, 89);
            button_len.TabIndex = 9;
            button_len.Text = "Ввести ";
            button_len.UseVisualStyleBackColor = true;
            button_len.Click += button_len_Click;
            // 
            // label_index
            // 
            label_index.AutoSize = true;
            label_index.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_index.ForeColor = Color.Red;
            label_index.Location = new Point(106, 155);
            label_index.Name = "label_index";
            label_index.Size = new Size(24, 30);
            label_index.TabIndex = 10;
            label_index.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 388);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 11;
            label3.Text = "Результат:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 198);
            label5.Name = "label5";
            label5.Size = new Size(781, 30);
            label5.TabIndex = 12;
            label5.Text = "------------------------------------------------------------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(311, 9);
            label6.Name = "label6";
            label6.Size = new Size(171, 30);
            label6.TabIndex = 13;
            label6.Text = "Введення даннх:";
            // 
            // textBox_array_num
            // 
            textBox_array_num.Location = new Point(409, 55);
            textBox_array_num.Name = "textBox_array_num";
            textBox_array_num.Size = new Size(47, 23);
            textBox_array_num.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(20, 48);
            label7.Name = "label7";
            label7.Size = new Size(383, 30);
            label7.TabIndex = 14;
            label7.Text = "Введіть кількість масивів (не більше 2)";
            // 
            // label_i_for_rows
            // 
            label_i_for_rows.AutoSize = true;
            label_i_for_rows.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_i_for_rows.ForeColor = Color.Red;
            label_i_for_rows.Location = new Point(374, 99);
            label_i_for_rows.Name = "label_i_for_rows";
            label_i_for_rows.Size = new Size(24, 30);
            label_i_for_rows.TabIndex = 16;
            label_i_for_rows.Text = "1";
            // 
            // label_y_for_in
            // 
            label_y_for_in.AutoSize = true;
            label_y_for_in.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_y_for_in.ForeColor = Color.Red;
            label_y_for_in.Location = new Point(311, 158);
            label_y_for_in.Name = "label_y_for_in";
            label_y_for_in.Size = new Size(24, 30);
            label_y_for_in.TabIndex = 17;
            label_y_for_in.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(311, 228);
            label8.Name = "label8";
            label8.Size = new Size(138, 30);
            label8.TabIndex = 18;
            label8.Text = "Редагування:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(20, 325);
            label13.Name = "label13";
            label13.Size = new Size(258, 30);
            label13.TabIndex = 22;
            label13.Text = "Елемент для редагування";
            // 
            // textBox_el_edit
            // 
            textBox_el_edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_el_edit.Location = new Point(286, 332);
            textBox_el_edit.Name = "textBox_el_edit";
            textBox_el_edit.Size = new Size(47, 23);
            textBox_el_edit.TabIndex = 21;
            // 
            // textBox_arr_edit
            // 
            textBox_arr_edit.Location = new Point(286, 276);
            textBox_arr_edit.Name = "textBox_arr_edit";
            textBox_arr_edit.Size = new Size(47, 23);
            textBox_arr_edit.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(20, 269);
            label14.Name = "label14";
            label14.Size = new Size(241, 30);
            label14.TabIndex = 19;
            label14.Text = "Масив для редагування";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label15.Location = new Point(3, 366);
            label15.Name = "label15";
            label15.Size = new Size(781, 30);
            label15.TabIndex = 27;
            label15.Text = "------------------------------------------------------------------------------------------------";
            // 
            // button_change
            // 
            button_change.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_change.Location = new Point(409, 318);
            button_change.Name = "button_change";
            button_change.Size = new Size(379, 45);
            button_change.TabIndex = 28;
            button_change.Text = "Редагувати";
            button_change.UseVisualStyleBackColor = true;
            button_change.Click += button_change_Click;
            // 
            // textBox_edit
            // 
            textBox_edit.Location = new Point(559, 276);
            textBox_edit.Name = "textBox_edit";
            textBox_edit.Size = new Size(229, 23);
            textBox_edit.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(409, 267);
            label9.Name = "label9";
            label9.Size = new Size(133, 30);
            label9.TabIndex = 29;
            label9.Text = "Редагування";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(555, 518);
            button1.Name = "button1";
            button1.Size = new Size(229, 158);
            button1.TabIndex = 31;
            button1.Text = "Злиття";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(555, 682);
            button2.Name = "button2";
            button2.Size = new Size(229, 155);
            button2.TabIndex = 32;
            button2.Text = "Зчеплення";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label_ans
            // 
            label_ans.AutoSize = true;
            label_ans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_ans.Location = new Point(3, 0);
            label_ans.Name = "label_ans";
            label_ans.Size = new Size(0, 25);
            label_ans.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(label_ans);
            flowLayoutPanel1.Location = new Point(12, 421);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(530, 416);
            flowLayoutPanel1.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 849);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_edit);
            Controls.Add(label9);
            Controls.Add(button_change);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(textBox_el_edit);
            Controls.Add(textBox_arr_edit);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label_y_for_in);
            Controls.Add(label_i_for_rows);
            Controls.Add(textBox_array_num);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label_index);
            Controls.Add(button_len);
            Controls.Add(button_out);
            Controls.Add(button_in);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox_array);
            Controls.Add(textBox_lenght);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OOP16";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_lenght;
        private TextBox textBox_array;
        private Label label2;
        private Label label4;
        private Button button_in;
        private Button button_out;
        private Button button_len;
        private Label label_index;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox_array_num;
        private Label label7;
        private Label label_i_for_rows;
        private Label label_y_for_in;
        private Label label8;
        private Label label10;
        private Label label13;
        private TextBox textBox_el_edit;
        private TextBox textBox_arr_edit;
        private Label label14;
        private Label label15;
        private Button button_change;
        private TextBox textBox_edit;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label label_ans;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
