namespace ProcesosPorLotes
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cajita6 = new System.Windows.Forms.TextBox();
            this.cajita2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cajita3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cajita = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cajita4 = new System.Windows.Forms.TextBox();
            this.cajita5 = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "# de programa";
            // 
            // cajita6
            // 
            this.cajita6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cajita6.Location = new System.Drawing.Point(46, 135);
            this.cajita6.Name = "cajita6";
            this.cajita6.Size = new System.Drawing.Size(143, 31);
            this.cajita6.TabIndex = 1;
            this.cajita6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajita6_KeyPress);
            // 
            // cajita2
            // 
            this.cajita2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cajita2.Location = new System.Drawing.Point(224, 135);
            this.cajita2.Name = "cajita2";
            this.cajita2.Size = new System.Drawing.Size(240, 31);
            this.cajita2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del programador";
            // 
            // cajita3
            // 
            this.cajita3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cajita3.Location = new System.Drawing.Point(489, 135);
            this.cajita3.Name = "cajita3";
            this.cajita3.Size = new System.Drawing.Size(239, 31);
            this.cajita3.TabIndex = 5;
            this.cajita3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajita3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(489, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo máximo estimado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proceso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(141, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "#1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Capturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(406, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(252, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División",
            "Residuo",
            "Potencia"});
            this.comboBox1.Location = new System.Drawing.Point(46, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 31);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Selecciona uno...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(46, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Operación";
            // 
            // cajita
            // 
            this.cajita.Location = new System.Drawing.Point(331, 357);
            this.cajita.Name = "cajita";
            this.cajita.Size = new System.Drawing.Size(100, 23);
            this.cajita.TabIndex = 12;
            this.cajita.ReadOnlyChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cajita.TextChanged += new System.EventHandler(this.cajita_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(100, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Esperando a elección de operación...";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cajita4
            // 
            this.cajita4.Enabled = false;
            this.cajita4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cajita4.Location = new System.Drawing.Point(145, 64);
            this.cajita4.Name = "cajita4";
            this.cajita4.Size = new System.Drawing.Size(78, 43);
            this.cajita4.TabIndex = 15;
            this.cajita4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajita4_KeyPress);
            // 
            // cajita5
            // 
            this.cajita5.Enabled = false;
            this.cajita5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cajita5.Location = new System.Drawing.Point(285, 65);
            this.cajita5.Name = "cajita5";
            this.cajita5.Size = new System.Drawing.Size(78, 43);
            this.cajita5.TabIndex = 16;
            this.cajita5.TextChanged += new System.EventHandler(this.cajita5_TextChanged);
            this.cajita5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajita5_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(38, 367);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 23);
            this.nombre.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cajita5);
            this.panel1.Controls.Add(this.cajita4);
            this.panel1.Location = new System.Drawing.Point(231, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 133);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(229, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 54);
            this.label8.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cajita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cajita3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cajita2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajita6);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox cajita6;
        private TextBox cajita2;
        private TextBox cajita3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ProgressBar progressBar1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        public TextBox cajita4;
        public TextBox cajita5;
        public TextBox cajita;
        private TextBox nombre;
        private Panel panel1;
        private Label label8;
    }
}