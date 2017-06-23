namespace ECC_Diffie_Helman
{
    partial class Form1
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
            this.txt_hesoa = new System.Windows.Forms.TextBox();
            this.txt_hesob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_module = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_basepointx = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.txt_basepointy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_compute = new System.Windows.Forms.Button();
            this.lsb_points = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_simulation = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_privatekeyAlice = new System.Windows.Forms.TextBox();
            this.txt_privatekeyBob = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label_bobpicks = new System.Windows.Forms.Label();
            this.label_alicepicks = new System.Windows.Forms.Label();
            this.label_computesB = new System.Windows.Forms.Label();
            this.label_computesA = new System.Windows.Forms.Label();
            this.label_privatekeyb = new System.Windows.Forms.Label();
            this.label_privatekeya = new System.Windows.Forms.Label();
            this.label_computesSecretb = new System.Windows.Forms.Label();
            this.label_receivesb = new System.Windows.Forms.Label();
            this.label_computesSecreta = new System.Windows.Forms.Label();
            this.label_receivesa = new System.Windows.Forms.Label();
            this.label_bob = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_computesBetaBasePoint = new System.Windows.Forms.Label();
            this.label_computesAlphaBasePoint = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_secretkeyb2 = new System.Windows.Forms.Label();
            this.label_secretkeyb1 = new System.Windows.Forms.Label();
            this.label_secretkeya2 = new System.Windows.Forms.Label();
            this.label_secretkeya1 = new System.Windows.Forms.Label();
            this.label_receivesfromB = new System.Windows.Forms.Label();
            this.label_receivesfromA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_hesoa
            // 
            this.txt_hesoa.Location = new System.Drawing.Point(66, 26);
            this.txt_hesoa.Name = "txt_hesoa";
            this.txt_hesoa.Size = new System.Drawing.Size(206, 20);
            this.txt_hesoa.TabIndex = 0;
            this.txt_hesoa.Text = "2";
            // 
            // txt_hesob
            // 
            this.txt_hesob.Location = new System.Drawing.Point(66, 52);
            this.txt_hesob.Name = "txt_hesob";
            this.txt_hesob.Size = new System.Drawing.Size(206, 20);
            this.txt_hesob.TabIndex = 1;
            this.txt_hesob.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hệ số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hệ số b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Private Key Bob";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Module";
            // 
            // txt_module
            // 
            this.txt_module.Location = new System.Drawing.Point(66, 78);
            this.txt_module.Name = "txt_module";
            this.txt_module.Size = new System.Drawing.Size(206, 20);
            this.txt_module.TabIndex = 5;
            this.txt_module.Text = "17";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BasePoint";
            // 
            // txt_basepointx
            // 
            this.txt_basepointx.Location = new System.Drawing.Point(77, 104);
            this.txt_basepointx.Name = "txt_basepointx";
            this.txt_basepointx.Size = new System.Drawing.Size(43, 20);
            this.txt_basepointx.TabIndex = 5;
            this.txt_basepointx.Text = "5";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(36, 5);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(24, 26);
            this.label_1.TabIndex = 6;
            this.label_1.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "=";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_5.Location = new System.Drawing.Point(94, 6);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(24, 26);
            this.label_5.TabIndex = 6;
            this.label_5.Text = "x";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(53, -1);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(17, 19);
            this.label_2.TabIndex = 6;
            this.label_2.Text = "2";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_4.Location = new System.Drawing.Point(109, -1);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(17, 19);
            this.label_4.TabIndex = 6;
            this.label_4.Text = "3";
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_6.Location = new System.Drawing.Point(126, 9);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(26, 26);
            this.label_6.TabIndex = 6;
            this.label_6.Text = "+";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_a.Location = new System.Drawing.Point(158, 6);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(24, 26);
            this.label_a.TabIndex = 6;
            this.label_a.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "+";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_b.Location = new System.Drawing.Point(236, 7);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(25, 26);
            this.label_b.TabIndex = 6;
            this.label_b.Text = "b";
            // 
            // txt_basepointy
            // 
            this.txt_basepointy.Location = new System.Drawing.Point(142, 104);
            this.txt_basepointy.Name = "txt_basepointy";
            this.txt_basepointy.Size = new System.Drawing.Size(43, 20);
            this.txt_basepointy.TabIndex = 5;
            this.txt_basepointy.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "(";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = ",";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = ")";
            // 
            // btn_compute
            // 
            this.btn_compute.Location = new System.Drawing.Point(9, 130);
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.Size = new System.Drawing.Size(263, 23);
            this.btn_compute.TabIndex = 8;
            this.btn_compute.Text = "Compute";
            this.btn_compute.UseVisualStyleBackColor = true;
            this.btn_compute.Click += new System.EventHandler(this.btn_compute_Click);
            // 
            // lsb_points
            // 
            this.lsb_points.FormattingEnabled = true;
            this.lsb_points.Location = new System.Drawing.Point(9, 159);
            this.lsb_points.Name = "lsb_points";
            this.lsb_points.Size = new System.Drawing.Size(263, 69);
            this.lsb_points.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lsb_points);
            this.groupBox2.Controls.Add(this.txt_hesoa);
            this.groupBox2.Controls.Add(this.btn_compute);
            this.groupBox2.Controls.Add(this.txt_hesob);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_module);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_basepointx);
            this.groupBox2.Controls.Add(this.txt_basepointy);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 236);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btn_simulation
            // 
            this.btn_simulation.Location = new System.Drawing.Point(197, 19);
            this.btn_simulation.Name = "btn_simulation";
            this.btn_simulation.Size = new System.Drawing.Size(75, 46);
            this.btn_simulation.TabIndex = 14;
            this.btn_simulation.Text = "Simulation";
            this.btn_simulation.UseVisualStyleBackColor = true;
            this.btn_simulation.Click += new System.EventHandler(this.btn_simulation_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_simulation);
            this.groupBox3.Controls.Add(this.txt_privatekeyAlice);
            this.groupBox3.Controls.Add(this.txt_privatekeyBob);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(10, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 75);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulation";
            // 
            // txt_privatekeyAlice
            // 
            this.txt_privatekeyAlice.Location = new System.Drawing.Point(101, 45);
            this.txt_privatekeyAlice.Name = "txt_privatekeyAlice";
            this.txt_privatekeyAlice.Size = new System.Drawing.Size(90, 20);
            this.txt_privatekeyAlice.TabIndex = 0;
            this.txt_privatekeyAlice.Text = "3";
            // 
            // txt_privatekeyBob
            // 
            this.txt_privatekeyBob.Location = new System.Drawing.Point(101, 19);
            this.txt_privatekeyBob.Name = "txt_privatekeyBob";
            this.txt_privatekeyBob.Size = new System.Drawing.Size(90, 20);
            this.txt_privatekeyBob.TabIndex = 0;
            this.txt_privatekeyBob.Text = "9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Private Key Alice";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_exit);
            this.groupBox4.Controls.Add(this.btn_clear);
            this.groupBox4.Location = new System.Drawing.Point(10, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 56);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clear and Exit";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(145, 24);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(127, 23);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(9, 24);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label_bobpicks
            // 
            this.label_bobpicks.AutoSize = true;
            this.label_bobpicks.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bobpicks.ForeColor = System.Drawing.Color.Blue;
            this.label_bobpicks.Location = new System.Drawing.Point(12, 138);
            this.label_bobpicks.Name = "label_bobpicks";
            this.label_bobpicks.Size = new System.Drawing.Size(185, 17);
            this.label_bobpicks.TabIndex = 2;
            this.label_bobpicks.Text = "Bob picks private key";
            this.label_bobpicks.Visible = false;
            // 
            // label_alicepicks
            // 
            this.label_alicepicks.AutoSize = true;
            this.label_alicepicks.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alicepicks.ForeColor = System.Drawing.Color.Blue;
            this.label_alicepicks.Location = new System.Drawing.Point(336, 138);
            this.label_alicepicks.Name = "label_alicepicks";
            this.label_alicepicks.Size = new System.Drawing.Size(188, 17);
            this.label_alicepicks.TabIndex = 2;
            this.label_alicepicks.Text = "Alice picks private key";
            this.label_alicepicks.Visible = false;
            // 
            // label_computesB
            // 
            this.label_computesB.AutoSize = true;
            this.label_computesB.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_computesB.ForeColor = System.Drawing.Color.Blue;
            this.label_computesB.Location = new System.Drawing.Point(50, 194);
            this.label_computesB.Name = "label_computesB";
            this.label_computesB.Size = new System.Drawing.Size(86, 17);
            this.label_computesB.TabIndex = 2;
            this.label_computesB.Text = "Computes";
            this.label_computesB.Visible = false;
            // 
            // label_computesA
            // 
            this.label_computesA.AutoSize = true;
            this.label_computesA.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_computesA.ForeColor = System.Drawing.Color.Blue;
            this.label_computesA.Location = new System.Drawing.Point(384, 194);
            this.label_computesA.Name = "label_computesA";
            this.label_computesA.Size = new System.Drawing.Size(86, 17);
            this.label_computesA.TabIndex = 2;
            this.label_computesA.Text = "Computes";
            this.label_computesA.Visible = false;
            // 
            // label_privatekeyb
            // 
            this.label_privatekeyb.AutoSize = true;
            this.label_privatekeyb.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_privatekeyb.Location = new System.Drawing.Point(60, 167);
            this.label_privatekeyb.Name = "label_privatekeyb";
            this.label_privatekeyb.Size = new System.Drawing.Size(46, 17);
            this.label_privatekeyb.TabIndex = 2;
            this.label_privatekeyb.Text = "Beta";
            this.label_privatekeyb.Visible = false;
            // 
            // label_privatekeya
            // 
            this.label_privatekeya.AutoSize = true;
            this.label_privatekeya.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_privatekeya.Location = new System.Drawing.Point(395, 167);
            this.label_privatekeya.Name = "label_privatekeya";
            this.label_privatekeya.Size = new System.Drawing.Size(52, 17);
            this.label_privatekeya.TabIndex = 2;
            this.label_privatekeya.Text = "Alpha";
            this.label_privatekeya.Visible = false;
            // 
            // label_computesSecretb
            // 
            this.label_computesSecretb.AutoSize = true;
            this.label_computesSecretb.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_computesSecretb.ForeColor = System.Drawing.Color.Red;
            this.label_computesSecretb.Location = new System.Drawing.Point(50, 313);
            this.label_computesSecretb.Name = "label_computesSecretb";
            this.label_computesSecretb.Size = new System.Drawing.Size(86, 17);
            this.label_computesSecretb.TabIndex = 2;
            this.label_computesSecretb.Text = "Computes";
            this.label_computesSecretb.Visible = false;
            // 
            // label_receivesb
            // 
            this.label_receivesb.AutoSize = true;
            this.label_receivesb.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_receivesb.ForeColor = System.Drawing.Color.Blue;
            this.label_receivesb.Location = new System.Drawing.Point(50, 254);
            this.label_receivesb.Name = "label_receivesb";
            this.label_receivesb.Size = new System.Drawing.Size(74, 17);
            this.label_receivesb.TabIndex = 2;
            this.label_receivesb.Text = "Receives";
            this.label_receivesb.Visible = false;
            // 
            // label_computesSecreta
            // 
            this.label_computesSecreta.AutoSize = true;
            this.label_computesSecreta.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_computesSecreta.ForeColor = System.Drawing.Color.Red;
            this.label_computesSecreta.Location = new System.Drawing.Point(384, 313);
            this.label_computesSecreta.Name = "label_computesSecreta";
            this.label_computesSecreta.Size = new System.Drawing.Size(86, 17);
            this.label_computesSecreta.TabIndex = 2;
            this.label_computesSecreta.Text = "Computes";
            this.label_computesSecreta.Visible = false;
            // 
            // label_receivesa
            // 
            this.label_receivesa.AutoSize = true;
            this.label_receivesa.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_receivesa.ForeColor = System.Drawing.Color.Blue;
            this.label_receivesa.Location = new System.Drawing.Point(384, 254);
            this.label_receivesa.Name = "label_receivesa";
            this.label_receivesa.Size = new System.Drawing.Size(74, 17);
            this.label_receivesa.TabIndex = 2;
            this.label_receivesa.Text = "Receives";
            this.label_receivesa.Visible = false;
            // 
            // label_bob
            // 
            this.label_bob.AutoSize = true;
            this.label_bob.Font = new System.Drawing.Font("SketchFlow Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bob.ForeColor = System.Drawing.Color.Blue;
            this.label_bob.Location = new System.Drawing.Point(55, 16);
            this.label_bob.Name = "label_bob";
            this.label_bob.Size = new System.Drawing.Size(77, 32);
            this.label_bob.TabIndex = 11;
            this.label_bob.Text = "Bob";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SketchFlow Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(383, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Alice";
            // 
            // label_computesBetaBasePoint
            // 
            this.label_computesBetaBasePoint.AutoSize = true;
            this.label_computesBetaBasePoint.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_computesBetaBasePoint.Location = new System.Drawing.Point(22, 222);
            this.label_computesBetaBasePoint.Name = "label_computesBetaBasePoint";
            this.label_computesBetaBasePoint.Size = new System.Drawing.Size(99, 19);
            this.label_computesBetaBasePoint.TabIndex = 13;
            this.label_computesBetaBasePoint.Text = "B = Beta.G";
            this.label_computesBetaBasePoint.Visible = false;
            // 
            // label_computesAlphaBasePoint
            // 
            this.label_computesAlphaBasePoint.AutoSize = true;
            this.label_computesAlphaBasePoint.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_computesAlphaBasePoint.Location = new System.Drawing.Point(364, 222);
            this.label_computesAlphaBasePoint.Name = "label_computesAlphaBasePoint";
            this.label_computesAlphaBasePoint.Size = new System.Drawing.Size(108, 19);
            this.label_computesAlphaBasePoint.TabIndex = 13;
            this.label_computesAlphaBasePoint.Text = "A = Alpha.G";
            this.label_computesAlphaBasePoint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_secretkeyb2);
            this.groupBox1.Controls.Add(this.label_secretkeyb1);
            this.groupBox1.Controls.Add(this.label_secretkeya2);
            this.groupBox1.Controls.Add(this.label_secretkeya1);
            this.groupBox1.Controls.Add(this.label_receivesfromB);
            this.groupBox1.Controls.Add(this.label_receivesfromA);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label_computesAlphaBasePoint);
            this.groupBox1.Controls.Add(this.label_computesBetaBasePoint);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label_bob);
            this.groupBox1.Controls.Add(this.label_receivesa);
            this.groupBox1.Controls.Add(this.label_computesSecreta);
            this.groupBox1.Controls.Add(this.label_receivesb);
            this.groupBox1.Controls.Add(this.label_computesSecretb);
            this.groupBox1.Controls.Add(this.label_privatekeya);
            this.groupBox1.Controls.Add(this.label_privatekeyb);
            this.groupBox1.Controls.Add(this.label_computesA);
            this.groupBox1.Controls.Add(this.label_computesB);
            this.groupBox1.Controls.Add(this.label_alicepicks);
            this.groupBox1.Controls.Add(this.label_bobpicks);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(296, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 379);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress Simulation";
            // 
            // label_secretkeyb2
            // 
            this.label_secretkeyb2.AutoSize = true;
            this.label_secretkeyb2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secretkeyb2.Location = new System.Drawing.Point(33, 357);
            this.label_secretkeyb2.Name = "label_secretkeyb2";
            this.label_secretkeyb2.Size = new System.Drawing.Size(99, 19);
            this.label_secretkeyb2.TabIndex = 17;
            this.label_secretkeyb2.Text = "Secret Key";
            this.label_secretkeyb2.Visible = false;
            // 
            // label_secretkeyb1
            // 
            this.label_secretkeyb1.AutoSize = true;
            this.label_secretkeyb1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secretkeyb1.Location = new System.Drawing.Point(6, 336);
            this.label_secretkeyb1.Name = "label_secretkeyb1";
            this.label_secretkeyb1.Size = new System.Drawing.Size(99, 19);
            this.label_secretkeyb1.TabIndex = 17;
            this.label_secretkeyb1.Text = "Secret Key";
            this.label_secretkeyb1.Visible = false;
            // 
            // label_secretkeya2
            // 
            this.label_secretkeya2.AutoSize = true;
            this.label_secretkeya2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secretkeya2.Location = new System.Drawing.Point(373, 357);
            this.label_secretkeya2.Name = "label_secretkeya2";
            this.label_secretkeya2.Size = new System.Drawing.Size(99, 19);
            this.label_secretkeya2.TabIndex = 17;
            this.label_secretkeya2.Text = "Secret Key";
            this.label_secretkeya2.Visible = false;
            // 
            // label_secretkeya1
            // 
            this.label_secretkeya1.AutoSize = true;
            this.label_secretkeya1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secretkeya1.Location = new System.Drawing.Point(346, 337);
            this.label_secretkeya1.Name = "label_secretkeya1";
            this.label_secretkeya1.Size = new System.Drawing.Size(99, 19);
            this.label_secretkeya1.TabIndex = 17;
            this.label_secretkeya1.Text = "Secret Key";
            this.label_secretkeya1.Visible = false;
            // 
            // label_receivesfromB
            // 
            this.label_receivesfromB.AutoSize = true;
            this.label_receivesfromB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_receivesfromB.Location = new System.Drawing.Point(372, 283);
            this.label_receivesfromB.Name = "label_receivesfromB";
            this.label_receivesfromB.Size = new System.Drawing.Size(99, 19);
            this.label_receivesfromB.TabIndex = 16;
            this.label_receivesfromB.Text = "B = Beta.G";
            this.label_receivesfromB.Visible = false;
            // 
            // label_receivesfromA
            // 
            this.label_receivesfromA.AutoSize = true;
            this.label_receivesfromA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_receivesfromA.Location = new System.Drawing.Point(37, 282);
            this.label_receivesfromA.Name = "label_receivesfromA";
            this.label_receivesfromA.Size = new System.Drawing.Size(108, 19);
            this.label_receivesfromA.TabIndex = 15;
            this.label_receivesfromA.Text = "A = Alpha.G";
            this.label_receivesfromA.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ECC_Diffie_Helman.Properties.Resources.Untitled_12;
            this.pictureBox1.Location = new System.Drawing.Point(51, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ECC_Diffie_Helman.Properties.Resources.Untitled_23;
            this.pictureBox2.Location = new System.Drawing.Point(385, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 397);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECC Diffie-Helman";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hesoa;
        private System.Windows.Forms.TextBox txt_hesob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_module;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_basepointx;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TextBox txt_basepointy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_compute;
        private System.Windows.Forms.ListBox lsb_points;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_simulation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_privatekeyAlice;
        private System.Windows.Forms.TextBox txt_privatekeyBob;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label_bobpicks;
        private System.Windows.Forms.Label label_alicepicks;
        private System.Windows.Forms.Label label_computesB;
        private System.Windows.Forms.Label label_computesA;
        private System.Windows.Forms.Label label_privatekeyb;
        private System.Windows.Forms.Label label_privatekeya;
        private System.Windows.Forms.Label label_computesSecretb;
        private System.Windows.Forms.Label label_receivesb;
        private System.Windows.Forms.Label label_computesSecreta;
        private System.Windows.Forms.Label label_receivesa;
        private System.Windows.Forms.Label label_bob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_computesBetaBasePoint;
        private System.Windows.Forms.Label label_computesAlphaBasePoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_secretkeya1;
        private System.Windows.Forms.Label label_secretkeyb1;
        private System.Windows.Forms.Label label_receivesfromB;
        private System.Windows.Forms.Label label_receivesfromA;
        private System.Windows.Forms.Label label_secretkeyb2;
        private System.Windows.Forms.Label label_secretkeya2;
    }
}

