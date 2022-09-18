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
            this.lotesPendientesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.OperacionLabel = new System.Windows.Forms.Label();
            this.TTLabel = new System.Windows.Forms.Label();
            this.TRLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lotesTerminadosList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loteEnProcesoList = new System.Windows.Forms.ListBox();
            this.LoteEPLabel = new System.Windows.Forms.Label();
            this.TiempoGlobalLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TeclaPresionadaLabel = new System.Windows.Forms.Label();
            this.TeclaAccionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lotesPendientesList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 231);
            this.panel1.TabIndex = 0;
            // 
            // lotesPendientesList
            // 
            this.lotesPendientesList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lotesPendientesList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lotesPendientesList.FormattingEnabled = true;
            this.lotesPendientesList.ItemHeight = 21;
            this.lotesPendientesList.Location = new System.Drawing.Point(12, 68);
            this.lotesPendientesList.Name = "lotesPendientesList";
            this.lotesPendientesList.Size = new System.Drawing.Size(162, 130);
            this.lotesPendientesList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pendientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IDLabel);
            this.panel2.Controls.Add(this.OperacionLabel);
            this.panel2.Controls.Add(this.TTLabel);
            this.panel2.Controls.Add(this.TRLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(205, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 231);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "____________________________________";
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
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "En proceso";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.lotesTerminadosList);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(470, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 425);
            this.panel3.TabIndex = 2;
            // 
            // lotesTerminadosList
            // 
            this.lotesTerminadosList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lotesTerminadosList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lotesTerminadosList.FormattingEnabled = true;
            this.lotesTerminadosList.ItemHeight = 21;
            this.lotesTerminadosList.Location = new System.Drawing.Point(12, 68);
            this.lotesTerminadosList.Name = "lotesTerminadosList";
            this.lotesTerminadosList.Size = new System.Drawing.Size(237, 340);
            this.lotesTerminadosList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
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
            this.label7.Location = new System.Drawing.Point(244, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 54);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lotes";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.loteEnProcesoList);
            this.panel4.Controls.Add(this.LoteEPLabel);
            this.panel4.Location = new System.Drawing.Point(12, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(452, 188);
            this.panel4.TabIndex = 4;
            // 
            // loteEnProcesoList
            // 
            this.loteEnProcesoList.FormattingEnabled = true;
            this.loteEnProcesoList.ItemHeight = 15;
            this.loteEnProcesoList.Location = new System.Drawing.Point(12, 66);
            this.loteEnProcesoList.Name = "loteEnProcesoList";
            this.loteEnProcesoList.Size = new System.Drawing.Size(417, 94);
            this.loteEnProcesoList.TabIndex = 1;
            // 
            // LoteEPLabel
            // 
            this.LoteEPLabel.AutoSize = true;
            this.LoteEPLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoteEPLabel.Location = new System.Drawing.Point(12, 16);
            this.LoteEPLabel.Name = "LoteEPLabel";
            this.LoteEPLabel.Size = new System.Drawing.Size(206, 37);
            this.LoteEPLabel.TabIndex = 0;
            this.LoteEPLabel.Text = "Lote en proceso";
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
            this.TeclaAccionLabel.Location = new System.Drawing.Point(630, 516);
            this.TeclaAccionLabel.Name = "TeclaAccionLabel";
            this.TeclaAccionLabel.Size = new System.Drawing.Size(22, 21);
            this.TeclaAccionLabel.TabIndex = 7;
            this.TeclaAccionLabel.Text = "...";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(743, 546);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ListBox lotesPendientesList;
        private Label label1;
        private Panel panel2;
        private Label TRLabel;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ListBox lotesTerminadosList;
        private Label label7;
        private Panel panel4;
        private Label TTLabel;
        private Label OperacionLabel;
        private Label IDLabel;
        private Label TiempoGlobalLabel;
        private System.Windows.Forms.Timer timer2;
        private ListBox loteEnProcesoList;
        private Label LoteEPLabel;
        private Label TeclaPresionadaLabel;
        private Label TeclaAccionLabel;
        private Label label4;
    }
}