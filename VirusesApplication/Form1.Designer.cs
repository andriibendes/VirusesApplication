namespace VirusesApplication
{
    partial class MainForm
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
            this.organisms_button = new System.Windows.Forms.Button();
            this.genomes_button = new System.Windows.Forms.Button();
            this.sci_btn = new System.Windows.Forms.Button();
            this.drug_btn = new System.Windows.Forms.Button();
            this.vir_btn = new System.Windows.Forms.Button();
            this.med = new System.Windows.Forms.Button();
            this.dis = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.RadioButton();
            this.four = new System.Windows.Forms.RadioButton();
            this.three = new System.Windows.Forms.RadioButton();
            this.two = new System.Windows.Forms.RadioButton();
            this.one = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.RadioButton();
            this.eight = new System.Windows.Forms.RadioButton();
            this.seven = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // organisms_button
            // 
            this.organisms_button.Location = new System.Drawing.Point(56, 50);
            this.organisms_button.Name = "organisms_button";
            this.organisms_button.Size = new System.Drawing.Size(147, 72);
            this.organisms_button.TabIndex = 1;
            this.organisms_button.Text = "Organisms";
            this.organisms_button.UseVisualStyleBackColor = true;
            this.organisms_button.Click += new System.EventHandler(this.organisms_button_Click);
            // 
            // genomes_button
            // 
            this.genomes_button.Location = new System.Drawing.Point(231, 50);
            this.genomes_button.Name = "genomes_button";
            this.genomes_button.Size = new System.Drawing.Size(147, 72);
            this.genomes_button.TabIndex = 2;
            this.genomes_button.Text = "Genomes";
            this.genomes_button.UseVisualStyleBackColor = true;
            this.genomes_button.Click += new System.EventHandler(this.genomes_button_Click);
            // 
            // sci_btn
            // 
            this.sci_btn.Location = new System.Drawing.Point(139, 148);
            this.sci_btn.Name = "sci_btn";
            this.sci_btn.Size = new System.Drawing.Size(147, 72);
            this.sci_btn.TabIndex = 3;
            this.sci_btn.Text = "Scientists";
            this.sci_btn.UseVisualStyleBackColor = true;
            this.sci_btn.Click += new System.EventHandler(this.sci_btn_Click);
            // 
            // drug_btn
            // 
            this.drug_btn.Location = new System.Drawing.Point(567, 50);
            this.drug_btn.Name = "drug_btn";
            this.drug_btn.Size = new System.Drawing.Size(147, 72);
            this.drug_btn.TabIndex = 4;
            this.drug_btn.Text = "Drugs";
            this.drug_btn.UseVisualStyleBackColor = true;
            this.drug_btn.Click += new System.EventHandler(this.drug_btn_Click);
            // 
            // vir_btn
            // 
            this.vir_btn.Location = new System.Drawing.Point(403, 50);
            this.vir_btn.Name = "vir_btn";
            this.vir_btn.Size = new System.Drawing.Size(147, 72);
            this.vir_btn.TabIndex = 5;
            this.vir_btn.Text = "Viruses";
            this.vir_btn.UseVisualStyleBackColor = true;
            this.vir_btn.Click += new System.EventHandler(this.vir_btn_Click);
            // 
            // med
            // 
            this.med.Location = new System.Drawing.Point(500, 148);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(147, 72);
            this.med.TabIndex = 6;
            this.med.Text = "Medicine";
            this.med.UseVisualStyleBackColor = true;
            this.med.Click += new System.EventHandler(this.med_Click);
            // 
            // dis
            // 
            this.dis.Location = new System.Drawing.Point(321, 148);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(147, 72);
            this.dis.TabIndex = 7;
            this.dis.Text = "Discoveries";
            this.dis.UseVisualStyleBackColor = true;
            this.dis.Click += new System.EventHandler(this.dis_Click);
            // 
            // five
            // 
            this.five.AutoSize = true;
            this.five.Location = new System.Drawing.Point(37, 331);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(154, 17);
            this.five.TabIndex = 8;
            this.five.TabStop = true;
            this.five.Text = "Viruses threated by Drug X ";
            this.five.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.Location = new System.Drawing.Point(37, 308);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(190, 17);
            this.four.TabIndex = 9;
            this.four.TabStop = true;
            this.four.Text = "Viruses with Genome with Strand X";
            this.four.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.Location = new System.Drawing.Point(37, 283);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(271, 17);
            this.three.TabIndex = 10;
            this.three.TabStop = true;
            this.three.Text = "Viruses discovered by Scientist that discover Virus X";
            this.three.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.Location = new System.Drawing.Point(37, 260);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(174, 17);
            this.two.TabIndex = 11;
            this.two.TabStop = true;
            this.two.Text = "Viruses have drug with cost < X";
            this.two.UseVisualStyleBackColor = true;
            // 
            // one
            // 
            this.one.AutoSize = true;
            this.one.Location = new System.Drawing.Point(37, 237);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(243, 17);
            this.one.TabIndex = 12;
            this.one.TabStop = true;
            this.one.Text = "Viruses discoverd from scientist from country X";
            this.one.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(403, 318);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(133, 20);
            this.x.TabIndex = 14;
            this.x.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(592, 316);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(55, 23);
            this.find.TabIndex = 15;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // six
            // 
            this.six.AutoSize = true;
            this.six.Location = new System.Drawing.Point(37, 354);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(133, 17);
            this.six.TabIndex = 16;
            this.six.TabStop = true;
            this.six.Text = "Drugs that treat virus X";
            this.six.UseVisualStyleBackColor = true;
            // 
            // eight
            // 
            this.eight.AutoSize = true;
            this.eight.Location = new System.Drawing.Point(37, 400);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(269, 17);
            this.eight.TabIndex = 17;
            this.eight.TabStop = true;
            this.eight.Text = "Scientists that discovered Viruses treated by Drug X";
            this.eight.UseVisualStyleBackColor = true;
            // 
            // seven
            // 
            this.seven.AutoSize = true;
            this.seven.Location = new System.Drawing.Point(37, 377);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(157, 17);
            this.seven.TabIndex = 18;
            this.seven.TabStop = true;
            this.seven.Text = "Viruses that have > X Drugs";
            this.seven.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.six);
            this.Controls.Add(this.find);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.med);
            this.Controls.Add(this.vir_btn);
            this.Controls.Add(this.drug_btn);
            this.Controls.Add(this.sci_btn);
            this.Controls.Add(this.genomes_button);
            this.Controls.Add(this.organisms_button);
            this.Name = "MainForm";
            this.Text = "VirusesApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button organisms_button;
        private System.Windows.Forms.Button genomes_button;
        private System.Windows.Forms.Button sci_btn;
        private System.Windows.Forms.Button drug_btn;
        private System.Windows.Forms.Button vir_btn;
        private System.Windows.Forms.Button med;
        private System.Windows.Forms.Button dis;
        private System.Windows.Forms.RadioButton five;
        private System.Windows.Forms.RadioButton four;
        private System.Windows.Forms.RadioButton three;
        private System.Windows.Forms.RadioButton two;
        private System.Windows.Forms.RadioButton one;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.RadioButton six;
        private System.Windows.Forms.RadioButton eight;
        private System.Windows.Forms.RadioButton seven;
    }
}

