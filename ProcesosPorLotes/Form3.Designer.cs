namespace ProcesosPorLotes
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.procesosListosList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuantumLabel = new System.Windows.Forms.Label();
            this.tmeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.OperacionLabel = new System.Windows.Forms.Label();
            this.TTLabel = new System.Windows.Forms.Label();
            this.TRLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.terminadosList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bloqueadosList = new System.Windows.Forms.ListBox();
            this.LoteEPLabel = new System.Windows.Forms.Label();
            this.TiempoGlobalLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TeclaPresionadaLabel = new System.Windows.Forms.Label();
            this.TeclaAccionLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ProcesosNuevosLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.QuantumValueLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.procesosListosList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 357);
            this.panel1.TabIndex = 0;
            // 
            // procesosListosList
            // 
            this.procesosListosList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.procesosListosList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.procesosListosList.FormattingEnabled = true;
            this.procesosListosList.ItemHeight = 21;
            this.procesosListosList.Location = new System.Drawing.Point(12, 68);
            this.procesosListosList.Name = "procesosListosList";
            this.procesosListosList.Size = new System.Drawing.Size(255, 277);
            this.procesosListosList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesos listos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.QuantumLabel);
            this.panel2.Controls.Add(this.tmeLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IDLabel);
            this.panel2.Controls.Add(this.OperacionLabel);
            this.panel2.Controls.Add(this.TTLabel);
            this.panel2.Controls.Add(this.TRLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(303, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 231);
            this.panel2.TabIndex = 1;
            // 
            // QuantumLabel
            // 
            this.QuantumLabel.AutoSize = true;
            this.QuantumLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantumLabel.Location = new System.Drawing.Point(139, 73);
            this.QuantumLabel.Name = "QuantumLabel";
            this.QuantumLabel.Size = new System.Drawing.Size(91, 25);
            this.QuantumLabel.TabIndex = 10;
            this.QuantumLabel.Text = "Quantum:";
            // 
            // tmeLabel
            // 
            this.tmeLabel.AutoSize = true;
            this.tmeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tmeLabel.Location = new System.Drawing.Point(14, 189);
            this.tmeLabel.Name = "tmeLabel";
            this.tmeLabel.Size = new System.Drawing.Size(47, 21);
            this.tmeLabel.TabIndex = 9;
            this.tmeLabel.Text = "TME: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "_________________________________________";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(14, 73);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(34, 25);
            this.IDLabel.TabIndex = 7;
            this.IDLabel.Text = "ID:";
            // 
            // OperacionLabel
            // 
            this.OperacionLabel.AutoSize = true;
            this.OperacionLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OperacionLabel.Location = new System.Drawing.Point(14, 98);
            this.OperacionLabel.Name = "OperacionLabel";
            this.OperacionLabel.Size = new System.Drawing.Size(103, 25);
            this.OperacionLabel.TabIndex = 6;
            this.OperacionLabel.Text = "Operación: ";
            // 
            // TTLabel
            // 
            this.TTLabel.AutoSize = true;
            this.TTLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TTLabel.Location = new System.Drawing.Point(14, 134);
            this.TTLabel.Name = "TTLabel";
            this.TTLabel.Size = new System.Drawing.Size(156, 21);
            this.TTLabel.TabIndex = 5;
            this.TTLabel.Text = "Tiempo Transcurrido:";
            // 
            // TRLabel
            // 
            this.TRLabel.AutoSize = true;
            this.TRLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TRLabel.Location = new System.Drawing.Point(14, 162);
            this.TRLabel.Name = "TRLabel";
            this.TRLabel.Size = new System.Drawing.Size(129, 21);
            this.TRLabel.TabIndex = 4;
            this.TRLabel.Text = "Tiempo Restante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "En ejecución";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.terminadosList);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(610, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 425);
            this.panel3.TabIndex = 2;
            // 
            // terminadosList
            // 
            this.terminadosList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.terminadosList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.terminadosList.FormattingEnabled = true;
            this.terminadosList.ItemHeight = 21;
            this.terminadosList.Location = new System.Drawing.Point(14, 68);
            this.terminadosList.Name = "terminadosList";
            this.terminadosList.Size = new System.Drawing.Size(337, 340);
            this.terminadosList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Terminados";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(488, 54);
            this.label7.TabIndex = 3;
            this.label7.Text = "Algoritmo de Planificación";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.bloqueadosList);
            this.panel4.Controls.Add(this.LoteEPLabel);
            this.panel4.Location = new System.Drawing.Point(303, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 188);
            this.panel4.TabIndex = 4;
            // 
            // bloqueadosList
            // 
            this.bloqueadosList.FormattingEnabled = true;
            this.bloqueadosList.ItemHeight = 15;
            this.bloqueadosList.Location = new System.Drawing.Point(12, 66);
            this.bloqueadosList.Name = "bloqueadosList";
            this.bloqueadosList.Size = new System.Drawing.Size(272, 109);
            this.bloqueadosList.TabIndex = 1;
            // 
            // LoteEPLabel
            // 
            this.LoteEPLabel.AutoSize = true;
            this.LoteEPLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoteEPLabel.Location = new System.Drawing.Point(12, 16);
            this.LoteEPLabel.Name = "LoteEPLabel";
            this.LoteEPLabel.Size = new System.Drawing.Size(231, 31);
            this.LoteEPLabel.TabIndex = 0;
            this.LoteEPLabel.Text = "Procesos bloqueados";
            // 
            // TiempoGlobalLabel
            // 
            this.TiempoGlobalLabel.AutoSize = true;
            this.TiempoGlobalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TiempoGlobalLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TiempoGlobalLabel.Location = new System.Drawing.Point(498, 34);
            this.TiempoGlobalLabel.Name = "TiempoGlobalLabel";
            this.TiempoGlobalLabel.Size = new System.Drawing.Size(121, 23);
            this.TiempoGlobalLabel.TabIndex = 5;
            this.TiempoGlobalLabel.Text = "Tiempo Global";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TeclaPresionadaLabel
            // 
            this.TeclaPresionadaLabel.AutoSize = true;
            this.TeclaPresionadaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TeclaPresionadaLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TeclaPresionadaLabel.Location = new System.Drawing.Point(12, 516);
            this.TeclaPresionadaLabel.Name = "TeclaPresionadaLabel";
            this.TeclaPresionadaLabel.Size = new System.Drawing.Size(19, 21);
            this.TeclaPresionadaLabel.TabIndex = 6;
            this.TeclaPresionadaLabel.Text = "...";
            // 
            // TeclaAccionLabel
            // 
            this.TeclaAccionLabel.AutoSize = true;
            this.TeclaAccionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TeclaAccionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TeclaAccionLabel.Location = new System.Drawing.Point(818, 516);
            this.TeclaAccionLabel.Name = "TeclaAccionLabel";
            this.TeclaAccionLabel.Size = new System.Drawing.Size(22, 21);
            this.TeclaAccionLabel.TabIndex = 7;
            this.TeclaAccionLabel.Text = "...";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Thistle;
            this.panel5.Controls.Add(this.ProcesosNuevosLabel);
            this.panel5.Location = new System.Drawing.Point(12, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 62);
            this.panel5.TabIndex = 8;
            // 
            // ProcesosNuevosLabel
            // 
            this.ProcesosNuevosLabel.AutoSize = true;
            this.ProcesosNuevosLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcesosNuevosLabel.Location = new System.Drawing.Point(12, 11);
            this.ProcesosNuevosLabel.Name = "ProcesosNuevosLabel";
            this.ProcesosNuevosLabel.Size = new System.Drawing.Size(203, 32);
            this.ProcesosNuevosLabel.TabIndex = 9;
            this.ProcesosNuevosLabel.Text = "Procesos nuevos: ";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // QuantumValueLabel
            // 
            this.QuantumValueLabel.AutoSize = true;
            this.QuantumValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantumValueLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.QuantumValueLabel.Location = new System.Drawing.Point(745, 34);
            this.QuantumValueLabel.Name = "QuantumValueLabel";
            this.QuantumValueLabel.Size = new System.Drawing.Size(155, 23);
            this.QuantumValueLabel.TabIndex = 9;
            this.QuantumValueLabel.Text = "Valor de Quantum:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(987, 546);
            this.Controls.Add(this.QuantumValueLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TeclaAccionLabel);
            this.Controls.Add(this.TeclaPresionadaLabel);
            this.Controls.Add(this.TiempoGlobalLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ListBox procesosListosList;
        private Label label1;
        private Panel panel2;
        private Label TRLabel;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ListBox terminadosList;
        private Label label7;
        private Panel panel4;
        private Label TTLabel;
        private Label OperacionLabel;
        private Label IDLabel;
        private Label TiempoGlobalLabel;
        private System.Windows.Forms.Timer timer2;
        private ListBox bloqueadosList;
        private Label LoteEPLabel;
        private Label TeclaPresionadaLabel;
        private Label TeclaAccionLabel;
        private Label label4;
        private Panel panel5;
        private Label ProcesosNuevosLabel;
        private System.Windows.Forms.Timer timer3;
        private Label tmeLabel;
        private Label QuantumLabel;
        private Label QuantumValueLabel;
    }
}