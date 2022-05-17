using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcNew
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String peratin = "";
        bool enter_value = false;
        float Icelus, iFarengeith, iKelvin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
            this.Width = 332;
            this.Height = 460;
            textBox1.Width = 294;
            стандартныйToolStripMenuItem.Checked = true;
            label3.Text = "";
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            стандартныйToolStripMenuItem.Checked = !стандартныйToolStripMenuItem.Checked;
            if (стандартныйToolStripMenuItem.Checked == true)
            {
                this.Width = 332;
                this.Height = 460;
                textBox1.Width = 294;
                инженерныйToolStripMenuItem.Checked = false;
                температураToolStripMenuItem.Checked = false;
                таблицаУмноженияToolStripMenuItem.Checked = false;

            }
            else
            {
                this.Width = 675;
                this.Height = 460;
                textBox1.Width = 634;
                инженерныйToolStripMenuItem.Checked = true;
            }
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            инженерныйToolStripMenuItem.Checked = !инженерныйToolStripMenuItem.Checked;
            if (инженерныйToolStripMenuItem.Checked == true)
            {
                стандартныйToolStripMenuItem.Checked = false;
                this.Width = 675;
                this.Height = 460;
                textBox1.Width = 634;
            }
            else
            {
                стандартныйToolStripMenuItem.Checked = true;
                this.Width = 332;
                this.Height = 460;
                textBox1.Width = 294;
            }
        }

        private void температураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Температура.Location = new Point(676, 28);
            groupBox1.Location = new Point(18, 75);
            groupBox2.Location = new Point(1147, 28);
            this.Width = 1152;
            this.Height = 460;
            textBox1.Width = 634;
            температураToolStripMenuItem.Checked = !температураToolStripMenuItem.Checked;
            if (температураToolStripMenuItem.Checked == true)
            {
                стандартныйToolStripMenuItem.Checked = false;
                инженерныйToolStripMenuItem.Checked = true;
                таблицаУмноженияToolStripMenuItem.Checked = false;

            }
            else
            {
                инженерныйToolStripMenuItem.Checked = true;
                таблицаУмноженияToolStripMenuItem.Checked = false;
                this.Width = 675;
                this.Height = 460;
                textBox1.Width = 634;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + num.Text;
                    label3.Text = label3.Text + num.Text;
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
                label3.Text = label3.Text + num.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                label3.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            peratin = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label3.Text = System.Convert.ToString(results)+ " " + peratin;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            switch (peratin)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox1.Text) == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    }
                    break;
                case "*":
                    textBox1.Text = (Double.Parse(textBox1.Text)*results).ToString();
                    break;
                case "Mоd":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilg = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("lоg" + "(" + (textBox1.Text) + ")");
            ilg = Math.Log10(ilg);
            textBox1.Text = System.Convert.ToString(ilg);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double ilg = Double.Parse(textBox1.Text);
            if (ilg < 0)
            {
                MessageBox.Show("Отрицательный корень!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0";
            }
            else
            {
                label3.Text = System.Convert.ToString("sqrt" + "(" + ilg + ")");
                ilg = Math.Sqrt(ilg);
                textBox1.Text = System.Convert.ToString(ilg);
            }
            
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("sinh" + "(" + sinh + ")");
            sinh = Math.Sinh(sinh);
            textBox1.Text = System.Convert.ToString(sinh);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double csh = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("cоsh" + "(" + csh + ")");
            csh = Math.Cosh(csh);
            textBox1.Text = System.Convert.ToString(csh);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double csh = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("cоs" + "(" + csh + ")");
            csh = Math.Cos(csh);
            textBox1.Text = System.Convert.ToString(csh);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("sin" + "(" + sin + ")");
            sin = Math.Cos(sin);
            textBox1.Text = System.Convert.ToString(sin);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("Tanh" + "(" + sin + ")");
            sin = Math.Tanh(sin);
            textBox1.Text = System.Convert.ToString(sin);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("Tan" + "(" + sin + ")");
            sin = Math.Tan(sin);
            textBox1.Text = System.Convert.ToString(sin);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;

            a =Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double a;

            if (Convert.ToDouble(textBox1.Text) == 0)
            {
                MessageBox.Show("Деление на ноль невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0";
            }
            else
            {
                a = Convert.ToDouble((1.0) / Convert.ToDouble(textBox1.Text));
                textBox1.Text = System.Convert.ToString(a);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilg = Double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("lоg" + "(" + (textBox1.Text) + ")");
            ilg = Math.Log(ilg);
            textBox1.Text = System.Convert.ToString(ilg);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch(iOperation)
            {
                case 'C':
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Ничего не введено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Icelus = float.Parse(textBox2.Text);
                        textBox3.Text = ((((9 * Icelus) / 5) + 32).ToString("0.00"));
                    }
                    break;
                case 'F':
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Ничего не введено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        iFarengeith = float.Parse(textBox2.Text);
                        textBox3.Text = ((((iFarengeith - 32) * 5) / 9).ToString("0.00"));
                    }
                    break;
                case 'K':
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Ничего не введено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        iKelvin = float.Parse(textBox2.Text);
                        textBox3.Text = (((((9 * iKelvin) / 5) + 32) + 273.15).ToString("0.00"));
                    }
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.Height = 44;
            textBox3.Width = 112;
            textBox2.Clear();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox4.Clear();

        }

        private void button44_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox4.Text);
            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(i + " * " + a + " = " + a*i);
            }
        }

        private void таблицаУмноженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            таблицаУмноженияToolStripMenuItem.Checked = !таблицаУмноженияToolStripMenuItem.Checked;
            if (таблицаУмноженияToolStripMenuItem.Checked == true)
            {
                this.Width = 1152;
                this.Height = 460;
                textBox1.Width = 634;
                groupBox2.Location = new Point(676, 28);
                groupBox1.Location = new Point(1147, 28);
                Температура.Location = new Point(1147, 28);
                инженерныйToolStripMenuItem.Checked = true;
                стандартныйToolStripMenuItem.Checked = false;
                температураToolStripMenuItem.Checked = false;
            }
            else
            {
                this.Width = 675;
                this.Height = 460;
                инженерныйToolStripMenuItem.Checked = true;
                groupBox2.Location = new Point(1147, 28);
                groupBox1.Location = new Point(676, 28);
                Температура.Location = new Point(676, 28);
                температураToolStripMenuItem.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-1 * p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label3.Text = "";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            float p = 24;
            Font f = new Font(((TextBox)sender).Font.Name, p);
            SizeF s = g.MeasureString(((TextBox)sender).Text, f);

            while (s.Width >= ((TextBox)sender).Width - 10)
            {
                p = p - 0.1f;
                f = new Font(((TextBox)sender).Font.Name, p);
                s = g.MeasureString(((TextBox)sender).Text, f);
            }
            ((TextBox)sender).Font = f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            float p = 18;
            Font f = new Font(((TextBox)sender).Font.Name, p);
            SizeF s = g.MeasureString(((TextBox)sender).Text, f);

            while (s.Width >= ((TextBox)sender).Width - 20)
            {
                p = p - 0.1f;
                f = new Font(((TextBox)sender).Font.Name, p);
                s = g.MeasureString(((TextBox)sender).Text, f);
            }
            ((TextBox)sender).Font = f;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            float p = 24;
            Font f = new Font(((TextBox)sender).Font.Name, p);
            SizeF s = g.MeasureString(((TextBox)sender).Text, f);

            while (s.Width >= ((TextBox)sender).Width - 20)
            {
                p = p - 0.1f;
                f = new Font(((TextBox)sender).Font.Name, p);
                s = g.MeasureString(((TextBox)sender).Text, f);
            }
            ((TextBox)sender).Font = f;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            float p = 24;
            Font f = new Font(((TextBox)sender).Font.Name, p);
            SizeF s = g.MeasureString(((TextBox)sender).Text, f);

            while (s.Width >= ((TextBox)sender).Width - 20)
            {
                p = p - 0.1f;
                f = new Font(((TextBox)sender).Font.Name, p);
                s = g.MeasureString(((TextBox)sender).Text, f);
            }
            ((TextBox)sender).Font = f;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')// цифра
                    return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    // Нажата клавиша <Enter>.
                    // Переместить курсор на кнопку Расчёт
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //в поле Срок можно ввести только целое число
            if (e.KeyChar >= '0' && e.KeyChar <= '9') // цифра
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    // Нажата клавиша <Enter>.
                    // Переместить курсор на кнопку Расчёт
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }
    }
}
