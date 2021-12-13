using System;
using System.Windows.Forms;

namespace CalCc
{
    public partial class Form1 : Form
    {
        string x=null, y=null;
        double z = 0;
        int bi = 0;
        bool operation = false, v=false;
        public Form1(){
            InitializeComponent();}
        private void button10_Click(object sender, EventArgs e){
            print("0");}
        private void button1_Click(object sender, EventArgs e){
            print("1");}
        private void button2_Click(object sender, EventArgs e){
            print("2");}
        private void button3_Click(object sender, EventArgs e){
            print("3");}
        private void button4_Click(object sender, EventArgs e){
            print("4");}
        private void button5_Click(object sender, EventArgs e){
            print("5");}
        private void button6_Click(object sender, EventArgs e){
            print("6");}
        private void button7_Click(object sender, EventArgs e){
            print("7");}
        private void button8_Click(object sender, EventArgs e){
            print("8");}
        private void button9_Click(object sender, EventArgs e){
            print("9");}
        private void button11_Click(object sender, EventArgs e){
            count(sender, e, 1);}
        private void button13_Click(object sender, EventArgs e){
            count(sender, e, 2);}
        private void button14_Click(object sender, EventArgs e){
            count(sender, e, 3);}
        private void button15_Click(object sender, EventArgs e){
            count(sender, e, 4);}
        private void button16_Click(object sender, EventArgs e){
            count(sender, e, 5);}
        private void button12_Click(object sender, EventArgs e){
            if (operation == true)
            {  
                switch (bi)
                {
                    case 1:
                        z = Convert.ToDouble(x) + Convert.ToDouble(y);
                        break;
                    case 2:
                        z = Convert.ToDouble(x) - Convert.ToDouble(y);
                        break;
                    case 3:
                        z = Convert.ToDouble(x) * Convert.ToDouble(y);
                        break;
                    case 4:
                        if (y != "0")
                            z = Convert.ToDouble(x) / Convert.ToDouble(y);
                        else
                        {
                            textBox1.Text = "Деление на ноль невожможно";
                            obnul();
                            return;
                        }
                        break;
                    case 5:
                        z = Math.Pow(Convert.ToDouble(x), Convert.ToDouble(y));
                        break;
                    case 6:
                        if (x == "0" || x == "180" || x == "360")
                            z = 0;
                        else
                            z = Math.Sin(Math.PI / 180 * Convert.ToDouble(x));
                        break;
                    case 7:
                        if (x == "270" || x == "90")
                            z = 0;
                        else
                            z = Math.Cos(Math.PI / 180 * Convert.ToDouble(x));
                        break;
                    case 8:
                        if (x == "270" || x == "90")
                        {
                            textBox1.Text = "Ошибка";
                            return;
                        }
                        else
                            z = Math.Tan(Math.PI / 180 * Convert.ToDouble(x));
                        break;
                    case 9:
                        if (x == "0" || x == "180" || x == "360")
                        {
                            textBox1.Text = "Ошибка";
                            return;
                        }
                        else
                            z = 1 / Math.Tan(Math.PI / 180 * Convert.ToDouble(x));
                        break;
                    case 10:
                        if (Convert.ToDouble(x) < 0)
                            textBox1.Text = "Ошибка";
                        else
                            z = Math.Sqrt(Convert.ToDouble(x));
                        break;
                }
                v = true;
                vivod(z);                
            }
            obnul();
        }
        private void button18_Click(object sender, EventArgs e){
            print(",");}
        private void button17_Click(object sender, EventArgs e){
            count(sender, e, 10);}
        private void button21_Click(object sender, EventArgs e){
            count(sender, e, 6);}
        private void button22_Click(object sender, EventArgs e){
            count(sender, e, 7);}
        private void button23_Click(object sender, EventArgs e){
            count(sender, e, 8);}
        private void button24_Click(object sender, EventArgs e){
            count(sender, e, 9);}
        private void button20_Click(object sender, EventArgs e){
            if (textBox1.Text.Length>0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (Convert.ToDouble(x) > 0 && operation == false && Convert.ToDouble(y) == 0)
            {
                x = x.Remove(x.Length - 1);
                if (x.Length == 0)
                    x = null;
            }
            else if (Convert.ToDouble(x) > 0 && operation == true && Convert.ToDouble(y) == 0)
                operation = false;
            else if (Convert.ToDouble(x) > 0 && operation == true && Convert.ToDouble(y) > 0)
            {
                y = y.Remove(y.Length - 1);
                if (y.Length == 0)
                    y = null;
            }
        }
        private void button19_Click(object sender, EventArgs e){
            textBox1.Clear();
            obnul();
            x = null;}
        private void инфоToolStripMenuItem_Click(object sender, EventArgs e){
            Form info = new Form2();
            info.Show();}
        void vivod(double Z){
            if (operation != true)
            {
                textBox1.Text = x;
            }
            else if (operation == true && v == true)
            {
                switch (bi)
                {
                    case 1:
                        textBox1.Text = x + "+" + y + "=" + Z;
                        break;
                    case 2:
                        textBox1.Text = x + "-" + y + "=" + Z;
                        break;
                    case 3:
                        textBox1.Text = x + "*" + y + "=" + Z;
                        break;
                    case 4:
                        textBox1.Text = x + "/" + y + "=" + Z;
                        break;
                    case 5:
                        textBox1.Text = x + "^" + y + "=" + Z;
                        break;
                    case 6:
                        textBox1.Text = "Sin(" + x + ")=" + Z;
                        break;
                    case 7:
                        textBox1.Text = "Cos(" + x + ")=" + Z;
                        break;
                    case 8:
                        textBox1.Text = "Tg(" + x + ")=" + Z;
                        break;
                    case 9:
                        textBox1.Text = "Ctg(" + x + ")=" + Z;
                        break;
                    case 10:
                        textBox1.Text = "√" + x + "=" + Z;
                        break;
                }
            }
            else
            {
                switch (bi)
                {
                    case 1:
                        textBox1.Text = x + "+" + y;
                        break;
                    case 2:
                        textBox1.Text = x + "-" + y;
                        break;
                    case 3:
                        textBox1.Text = x + "*" + y;
                        break;
                    case 4:
                        textBox1.Text = x + "/" + y;
                        break;
                    case 5:
                        textBox1.Text = x + "^" + y;
                        break;
                }
            }
        }     
        void obnul(){
            x = z.ToString();
            y = null;
            z = 0;
            operation = false;
            bi = 0;
            v = false;
        }
        string Gradus(string X){
            if (Convert.ToDouble(X) > 360)
            {
                do{
                    X = (Convert.ToDouble(X) - 360).ToString();}
                while (Convert.ToDouble(X) > 360);
                return X;
            }
            else
                return X;
        }
        bool inf(){
            if (double.IsInfinity(Convert.ToDouble(x)) == true)
            {
                textBox1.Text = "Ошибка";
                obnul();
                return true;
            }
            else
                return false;
        }
        void print(string m){
            if (operation != true)
                x += m;
            else
                y += m;
            vivod(z);
        }
        void count(object sender, EventArgs e, int m){
            if (x==null || inf() == false)
            {
                if (m > 5 && m < 11)
                {
                    if (m > 0 && m < 6)
                        x = Gradus(x);
                    operation = true;
                    bi = m;
                    button12_Click(sender, e);
                }
                if (operation == true)
                    button12_Click(sender, e);
                operation = true;
                bi = m;
                vivod(z);
            }
        }
    }
}
