using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeradorGetSetCsharp
{
    public partial class BaseGeratorProperty : Form
    {
        Point MousePos, FormPos;
        bool Clique = false;

        public BaseGeratorProperty()
        {
            InitializeComponent();
        }

        private void BaseGeratorProperty_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "C#";
            txt_resp.Visible = false;
            cbgerarGet.Checked = true;
            cbGerarSet.Checked = true;
            cbpublicGet.Checked = true;
            checkBox8.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
            checkBox11.Checked = true;
            checkBox3.Checked = true;
            checkBox14.Checked = true;
        }

        private void baseTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baseTop_MouseUp(object sender, MouseEventArgs e)
        {
            Clique = false;
        }

        private void baseTop_MouseDown(object sender, MouseEventArgs e)
        {
            Clique = true;
            MousePos = Cursor.Position;
            FormPos = this.Location;
        }

        private void baseTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(Clique == true){
                Point direction = Point.Subtract(Cursor.Position, new Size(MousePos));
                this.Location = Point.Add(FormPos, new Size(direction));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_resp.Text = "";
            if (cbgerarGet.Checked)
            {
                
                GerarGetPadrao();
               
            }
            if (cbGerarSet.Checked)
            {
                GerarSetPadrao();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            txt_resp.Text = "";
            textBox1.Focus();
        }

        private void cbpublicGet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbpublicGet.Checked == true)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                cbpublicGet.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                cbpublicGet.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox6.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox8.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void cbgerarGet_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbgerarGet.Checked)
            {
                cbpublicGet.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;

            }
            else
            {
                cbpublicGet.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
            }
        }

        private void cbGerarSet_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbGerarSet.Checked)
            {
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;

            }
            else
            {
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
            }
        }

        public void GerarGetPadrao()
        {
            if (cbgerarGet.Checked && cbpublicGet.Checked && !textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                String resp1 = "public " + textBox2.Text + " get"+ textBox1.Text+ "(){\r\n" +
                                    "   return "+textBox1.Text+";\r\n" +
                                "}";
                

                txt_resp.Visible = true;
                txt_resp.Text = resp1;
            }
            if (cbgerarGet.Checked && checkBox4.Checked && !textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                String resp1 = "protected " + textBox2.Text + " get" + textBox1.Text + "(){\r\n" +
                                    "   return " + textBox1.Text + ";\r\n" +
                                "}";


                txt_resp.Visible = true;
                txt_resp.Text = resp1;
            }
            if (cbgerarGet.Checked && checkBox5.Checked && !textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                String resp1 = "private " + textBox2.Text + " get" + textBox1.Text + "(){\r\n" +
                                    "   return " + textBox1.Text + ";\r\n" +
                                "}";


                txt_resp.Visible = true;
                txt_resp.Text = resp1;
            }
            
            
        }
        public void GerarSetPadrao()
        {
            if (cbGerarSet.Checked && checkBox8.Checked && !textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                String resp1 = "\r\npublic void set" + textBox1.Text + "("+ textBox2.Text +" "+textBox1.Text.ToLower() +"){\r\n" +
                                    "   this." + textBox1.Text + " = "+ textBox1.Text.ToLower() + ";\r\n" +
                                "}";


                txt_resp.Visible = true;
                txt_resp.Text += resp1;
            }
            if (cbGerarSet.Checked && checkBox7.Checked && !textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                String resp1 = "\r\nprotected void set" + textBox1.Text + "(" + textBox2.Text + " " + textBox1.Text.ToLower() + "){\r\n" +
                                    "   this." + textBox1.Text + " = " + textBox1.Text.ToLower() + ";\r\n" +
                                "}";


                txt_resp.Visible = true;
                txt_resp.Text += resp1;
            }
            if (cbGerarSet.Checked && checkBox6.Checked && !textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                String resp1 = "\r\nprivate void set" + textBox1.Text + "(" + textBox2.Text + " " + textBox1.Text.ToLower() + "){\r\n" +
                                    "   this." + textBox1.Text + " = " + textBox1.Text.ToLower() + ";\r\n" +
                                "}";


                txt_resp.Visible = true;
                txt_resp.Text += resp1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
             txt_resp.Visible = true;
             txt_resp.Text = "";
             if (!textBox3.Text.Equals("") && !textBox3.Text.Equals(""))
             {
                 if (!textBox4.Text.StartsWith("_"))
                 {
                     String varTexto = textBox4.Text;
                     varTexto = "_" + textBox4.Text;
                     textBox4.Text = varTexto;
                 }
                 CimaProperty();

                 if(checkBox13.Checked)
                 {
                     GerarGetProperty();
                 }
                 if (checkBox12.Checked)
                 {
                     GerarSetProperty();
                 }

                 BaixoProperty();
             }
             
                 
             
        }
        public void GerarSetProperty()
        {
            if (checkBox3.Checked)
            {
                String meiop2 = "\r\n   set{\n\r";
                String meiop3 = "\r\n       " + textBox4.Text + " = value;";
                String meiop4 = "\r\n   }";
                txt_resp.Text += meiop2 + meiop3 + meiop4;
            }
            if (checkBox2.Checked)
            {
                String meiop2 = "\r\n   protected set{\n\r";
                String meiop3 = "\r\n       " + textBox4.Text + " = value;";
                String meiop4 = "\r\n   }";
                txt_resp.Text += meiop2 + meiop3 + meiop4;
            }
            if (checkBox1.Checked)
            {
                String meiop2 = "\r\n   private set{\n\r";
                String meiop3 = "\r\n       " + textBox4.Text + " = value;";
                String meiop4 = "\r\n   }";
                txt_resp.Text += meiop2 + meiop3 + meiop4;
            }
           
        }
        public void GerarGetProperty()
        {
            if(checkBox11.Checked){
                String meiop2 = "\r\n   get{\n\r";
                String meiop3 = "\r\n       return "+textBox4.Text+";";
                String meiop4 = "\r\n   }";
                txt_resp.Text += meiop2 + meiop3 + meiop4;
            }
            if (checkBox10.Checked)
            {
                String meiop2 = "\r\n   protected get{\n\r";
                String meiop3 = "\r\n       return " + textBox4.Text + ";";
                String meiop4 = "\r\n   }";
                txt_resp.Text += meiop2 + meiop3 + meiop4;
            }
            if (checkBox9.Checked)
            {
                String meiop2 = "\r\n   private get{\n\r";
                String meiop3 = "\r\n       return " + textBox4.Text + ";";
                String meiop4 = "\r\n   }";
                txt_resp.Text += meiop2 + meiop3 + meiop4;
            }
        }
        public void CimaProperty(){
            String nomeVar = textBox4.Text;
            String CaixaMaior = Char.ToUpper(nomeVar[1]) + nomeVar.Substring(2);
            if(checkBox14.Checked){
                
                String p1 = "public " + textBox3.Text +" " + CaixaMaior+"{";
                txt_resp.Text += p1;
            }
            if (checkBox16.Checked)
            {
                String p1 = "protected " + textBox3.Text + " " + CaixaMaior + "{";
                txt_resp.Text += p1;
            }
            if (checkBox15.Checked)
            {
                String p1 = "private " + textBox3.Text + " " + CaixaMaior + "{";
                txt_resp.Text += p1;
            }

        }
        public void BaixoProperty()
        {
            txt_resp.Text += "\r\n}";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox10.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox10.Checked)
            {
                checkBox11.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
            }
            else
            {
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox15.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox15.Checked = false;
                checkBox14.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox16.Checked = false;
                checkBox14.Checked = false;
            }
        }
        String t = null;

        public String T
        {
            private get
            {
                 return t;
            }
            set
            {
                t = value;
            }
           
        }

       
    }
}
