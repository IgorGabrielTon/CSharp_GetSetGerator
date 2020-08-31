namespace GeradorGetSetCsharp
{
    partial class BaseGeratorProperty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.baseTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cbpublicGet = new System.Windows.Forms.CheckBox();
            this.cbGerarSet = new System.Windows.Forms.CheckBox();
            this.cbgerarGet = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_resp = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.baseTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "C#"});
            this.comboBox1.Location = new System.Drawing.Point(334, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // baseTop
            // 
            this.baseTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.baseTop.Controls.Add(this.button1);
            this.baseTop.Controls.Add(this.titulo);
            this.baseTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.baseTop.Location = new System.Drawing.Point(0, 0);
            this.baseTop.Name = "baseTop";
            this.baseTop.Size = new System.Drawing.Size(469, 40);
            this.baseTop.TabIndex = 1;
            this.baseTop.Paint += new System.Windows.Forms.PaintEventHandler(this.baseTop_Paint);
            this.baseTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTop_MouseMove);
            this.baseTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseTop_MouseDown);
            this.baseTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseTop_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(421, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titulo.Location = new System.Drawing.Point(51, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(346, 24);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "GERADOR DE METODOS GET E SET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(211, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Linguagem";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 433);
            this.tabControl1.TabIndex = 11;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.button3);
            this.tab1.Controls.Add(this.button2);
            this.tab1.Controls.Add(this.checkBox6);
            this.tab1.Controls.Add(this.checkBox7);
            this.tab1.Controls.Add(this.checkBox8);
            this.tab1.Controls.Add(this.checkBox5);
            this.tab1.Controls.Add(this.checkBox4);
            this.tab1.Controls.Add(this.cbpublicGet);
            this.tab1.Controls.Add(this.cbGerarSet);
            this.tab1.Controls.Add(this.cbgerarGet);
            this.tab1.Controls.Add(this.textBox2);
            this.tab1.Controls.Add(this.textBox1);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(437, 407);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Gerar Comum";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.button2.Location = new System.Drawing.Point(98, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 86);
            this.button2.TabIndex = 23;
            this.button2.Text = "Gerar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox6.Location = new System.Drawing.Point(287, 252);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(103, 18);
            this.checkBox6.TabIndex = 22;
            this.checkBox6.Text = "Private Set";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox7.Location = new System.Drawing.Point(287, 228);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(117, 18);
            this.checkBox7.TabIndex = 21;
            this.checkBox7.Text = "Protected Set";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox8.Location = new System.Drawing.Point(287, 204);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(96, 18);
            this.checkBox8.TabIndex = 20;
            this.checkBox8.Text = "Public Set";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox5.Location = new System.Drawing.Point(67, 252);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(103, 18);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "Private Get";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox4.Location = new System.Drawing.Point(67, 228);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(117, 18);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Protected Get";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbpublicGet
            // 
            this.cbpublicGet.AutoSize = true;
            this.cbpublicGet.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.cbpublicGet.Location = new System.Drawing.Point(67, 204);
            this.cbpublicGet.Name = "cbpublicGet";
            this.cbpublicGet.Size = new System.Drawing.Size(96, 18);
            this.cbpublicGet.TabIndex = 17;
            this.cbpublicGet.Text = "Public Get";
            this.cbpublicGet.UseVisualStyleBackColor = true;
            this.cbpublicGet.CheckedChanged += new System.EventHandler(this.cbpublicGet_CheckedChanged);
            // 
            // cbGerarSet
            // 
            this.cbGerarSet.AutoSize = true;
            this.cbGerarSet.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbGerarSet.Location = new System.Drawing.Point(263, 170);
            this.cbGerarSet.Name = "cbGerarSet";
            this.cbGerarSet.Size = new System.Drawing.Size(137, 28);
            this.cbGerarSet.TabIndex = 16;
            this.cbGerarSet.Text = "Gerar Set";
            this.cbGerarSet.UseVisualStyleBackColor = true;
            this.cbGerarSet.CheckedChanged += new System.EventHandler(this.cbGerarSet_CheckedChanged);
            // 
            // cbgerarGet
            // 
            this.cbgerarGet.AutoSize = true;
            this.cbgerarGet.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbgerarGet.Location = new System.Drawing.Point(44, 170);
            this.cbgerarGet.Name = "cbgerarGet";
            this.cbgerarGet.Size = new System.Drawing.Size(137, 28);
            this.cbgerarGet.TabIndex = 15;
            this.cbgerarGet.Text = "Gerar Get";
            this.cbgerarGet.UseVisualStyleBackColor = true;
            this.cbgerarGet.CheckedChanged += new System.EventHandler(this.cbgerarGet_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(199, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 32);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(199, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 32);
            this.textBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo Variavel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome Variavel";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox16);
            this.tabPage2.Controls.Add(this.checkBox15);
            this.tabPage2.Controls.Add(this.checkBox14);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox9);
            this.tabPage2.Controls.Add(this.checkBox10);
            this.tabPage2.Controls.Add(this.checkBox11);
            this.tabPage2.Controls.Add(this.checkBox12);
            this.tabPage2.Controls.Add(this.checkBox13);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gerar Property";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_resp
            // 
            this.txt_resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp.Location = new System.Drawing.Point(16, 521);
            this.txt_resp.Multiline = true;
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.Size = new System.Drawing.Size(445, 256);
            this.txt_resp.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.button5.Location = new System.Drawing.Point(112, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 86);
            this.button5.TabIndex = 37;
            this.button5.Text = "Gerar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(278, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 18);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Private Set";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(278, 255);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 18);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "Protected Set";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox3.Location = new System.Drawing.Point(278, 231);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 18);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "Public Set";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox9.Location = new System.Drawing.Point(58, 279);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(103, 18);
            this.checkBox9.TabIndex = 33;
            this.checkBox9.Text = "Private Get";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox10.Location = new System.Drawing.Point(58, 255);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(117, 18);
            this.checkBox10.TabIndex = 32;
            this.checkBox10.Text = "Protected Get";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Bold);
            this.checkBox11.Location = new System.Drawing.Point(58, 231);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(96, 18);
            this.checkBox11.TabIndex = 31;
            this.checkBox11.Text = "Public Get";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox12.Location = new System.Drawing.Point(254, 197);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(137, 28);
            this.checkBox12.TabIndex = 30;
            this.checkBox12.Text = "Gerar Set";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox13.Location = new System.Drawing.Point(35, 197);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(137, 28);
            this.checkBox13.TabIndex = 29;
            this.checkBox13.Text = "Gerar Get";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(208, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 32);
            this.textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(208, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 32);
            this.textBox4.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipo Variavel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nome Variavel";
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox14.Location = new System.Drawing.Point(28, 142);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(113, 28);
            this.checkBox14.TabIndex = 39;
            this.checkBox14.Text = "Publico";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox15.Location = new System.Drawing.Point(296, 142);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(113, 28);
            this.checkBox15.TabIndex = 40;
            this.checkBox15.Text = "Privado";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox16.Location = new System.Drawing.Point(147, 142);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(137, 28);
            this.checkBox16.TabIndex = 41;
            this.checkBox16.Text = "Protegido";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // BaseGeratorProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 780);
            this.Controls.Add(this.txt_resp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseTop);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseGeratorProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeradorBase";
            this.Load += new System.EventHandler(this.BaseGeratorProperty_Load);
            this.baseTop.ResumeLayout(false);
            this.baseTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel baseTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.CheckBox cbGerarSet;
        private System.Windows.Forms.CheckBox cbgerarGet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox cbpublicGet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_resp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
    }
}

