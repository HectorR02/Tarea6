namespace Tarea6
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Resultados = new System.Windows.Forms.Button();
            this.TBMin = new System.Windows.Forms.TextBox();
            this.TBMax = new System.Windows.Forms.TextBox();
            this.TBProm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCalf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgrCalf = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TBDes = new System.Windows.Forms.MaskedTextBox();
            this.TBPal = new System.Windows.Forms.MaskedTextBox();
            this.Dicc = new System.Windows.Forms.Button();
            this.ContPal = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AtClient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBCliente = new System.Windows.Forms.MaskedTextBox();
            this.AgreClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ContClient = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ContGastros = new System.Windows.Forms.RichTextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.TBGasto = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BAgenda = new System.Windows.Forms.Button();
            this.Agendar = new System.Windows.Forms.Button();
            this.ContContactos = new System.Windows.Forms.RichTextBox();
            this.TBTalf = new System.Windows.Forms.MaskedTextBox();
            this.TBNombre = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Resultados);
            this.tabPage2.Controls.Add(this.TBMin);
            this.tabPage2.Controls.Add(this.TBMax);
            this.tabPage2.Controls.Add(this.TBProm);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TBCalf);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.AgrCalf);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ej 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Resultados
            // 
            this.Resultados.Enabled = false;
            this.Resultados.Location = new System.Drawing.Point(141, 98);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(75, 23);
            this.Resultados.TabIndex = 9;
            this.Resultados.Text = "Resultados";
            this.Resultados.UseVisualStyleBackColor = true;
            this.Resultados.Click += new System.EventHandler(this.Resultados_Click);
            // 
            // TBMin
            // 
            this.TBMin.Location = new System.Drawing.Point(288, 157);
            this.TBMin.Name = "TBMin";
            this.TBMin.ReadOnly = true;
            this.TBMin.Size = new System.Drawing.Size(52, 20);
            this.TBMin.TabIndex = 8;
            // 
            // TBMax
            // 
            this.TBMax.Location = new System.Drawing.Point(182, 157);
            this.TBMax.Name = "TBMax";
            this.TBMax.ReadOnly = true;
            this.TBMax.Size = new System.Drawing.Size(50, 20);
            this.TBMax.TabIndex = 7;
            // 
            // TBProm
            // 
            this.TBProm.Location = new System.Drawing.Point(65, 157);
            this.TBProm.Name = "TBProm";
            this.TBProm.ReadOnly = true;
            this.TBProm.Size = new System.Drawing.Size(53, 20);
            this.TBProm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promedio";
            // 
            // TBCalf
            // 
            this.TBCalf.Location = new System.Drawing.Point(141, 36);
            this.TBCalf.Mask = "99.9";
            this.TBCalf.Name = "TBCalf";
            this.TBCalf.Size = new System.Drawing.Size(51, 20);
            this.TBCalf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calificacion";
            // 
            // AgrCalf
            // 
            this.AgrCalf.Location = new System.Drawing.Point(211, 33);
            this.AgrCalf.Name = "AgrCalf";
            this.AgrCalf.Size = new System.Drawing.Size(75, 23);
            this.AgrCalf.TabIndex = 0;
            this.AgrCalf.Text = "Agregar";
            this.AgrCalf.UseVisualStyleBackColor = true;
            this.AgrCalf.Click += new System.EventHandler(this.AgrCalf_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TBDes);
            this.tabPage1.Controls.Add(this.TBPal);
            this.tabPage1.Controls.Add(this.Dicc);
            this.tabPage1.Controls.Add(this.ContPal);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Agregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 244);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ej 2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TBDes
            // 
            this.TBDes.Location = new System.Drawing.Point(80, 70);
            this.TBDes.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.TBDes.Name = "TBDes";
            this.TBDes.Size = new System.Drawing.Size(239, 20);
            this.TBDes.TabIndex = 6;
            // 
            // TBPal
            // 
            this.TBPal.Location = new System.Drawing.Point(80, 26);
            this.TBPal.Mask = "LLLLLLLLLLLLLLLL";
            this.TBPal.Name = "TBPal";
            this.TBPal.Size = new System.Drawing.Size(109, 20);
            this.TBPal.TabIndex = 5;
            // 
            // Dicc
            // 
            this.Dicc.Enabled = false;
            this.Dicc.Location = new System.Drawing.Point(177, 211);
            this.Dicc.Name = "Dicc";
            this.Dicc.Size = new System.Drawing.Size(75, 23);
            this.Dicc.TabIndex = 4;
            this.Dicc.Text = "Diccionario";
            this.Dicc.UseVisualStyleBackColor = true;
            this.Dicc.Click += new System.EventHandler(this.Dicc_Click);
            // 
            // ContPal
            // 
            this.ContPal.Location = new System.Drawing.Point(14, 96);
            this.ContPal.Name = "ContPal";
            this.ContPal.Size = new System.Drawing.Size(386, 96);
            this.ContPal.TabIndex = 3;
            this.ContPal.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Palabra";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(325, 67);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AtClient);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(411, 244);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Ej 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AtClient
            // 
            this.AtClient.Enabled = false;
            this.AtClient.Location = new System.Drawing.Point(332, 147);
            this.AtClient.Name = "AtClient";
            this.AtClient.Size = new System.Drawing.Size(75, 23);
            this.AtClient.TabIndex = 5;
            this.AtClient.Text = "Atender";
            this.AtClient.UseVisualStyleBackColor = true;
            this.AtClient.Click += new System.EventHandler(this.AtClient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBCliente);
            this.groupBox2.Controls.Add(this.AgreClient);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(25, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Cliente";
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(62, 23);
            this.TBCliente.Mask = "LLLLLLLLLLLLLL";
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(100, 20);
            this.TBCliente.TabIndex = 3;
            // 
            // AgreClient
            // 
            this.AgreClient.Location = new System.Drawing.Point(185, 21);
            this.AgreClient.Name = "AgreClient";
            this.AgreClient.Size = new System.Drawing.Size(75, 23);
            this.AgreClient.TabIndex = 2;
            this.AgreClient.Text = "Agregar";
            this.AgreClient.UseVisualStyleBackColor = true;
            this.AgreClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContClient);
            this.groupBox1.Location = new System.Drawing.Point(25, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes en cola";
            // 
            // ContClient
            // 
            this.ContClient.Location = new System.Drawing.Point(15, 19);
            this.ContClient.Name = "ContClient";
            this.ContClient.Size = new System.Drawing.Size(267, 122);
            this.ContClient.TabIndex = 2;
            this.ContClient.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.Registrar);
            this.tabPage4.Controls.Add(this.TBGasto);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.LB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(411, 244);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Ej 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ContGastros);
            this.groupBox3.Location = new System.Drawing.Point(32, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 159);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gastos";
            // 
            // ContGastros
            // 
            this.ContGastros.Location = new System.Drawing.Point(20, 19);
            this.ContGastros.Name = "ContGastros";
            this.ContGastros.Size = new System.Drawing.Size(261, 134);
            this.ContGastros.TabIndex = 4;
            this.ContGastros.Text = "";
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(238, 44);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 3;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // TBGasto
            // 
            this.TBGasto.Location = new System.Drawing.Point(93, 49);
            this.TBGasto.Mask = "9999999.99";
            this.TBGasto.Name = "TBGasto";
            this.TBGasto.Size = new System.Drawing.Size(81, 20);
            this.TBGasto.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gasto";
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Location = new System.Drawing.Point(139, 20);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(13, 13);
            this.LB.TabIndex = 0;
            this.LB.Text = "  ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.BAgenda);
            this.tabPage5.Controls.Add(this.Agendar);
            this.tabPage5.Controls.Add(this.ContContactos);
            this.tabPage5.Controls.Add(this.TBTalf);
            this.tabPage5.Controls.Add(this.TBNombre);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.Nombre);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(411, 244);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Ej 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // BAgenda
            // 
            this.BAgenda.Enabled = false;
            this.BAgenda.Location = new System.Drawing.Point(161, 213);
            this.BAgenda.Name = "BAgenda";
            this.BAgenda.Size = new System.Drawing.Size(75, 23);
            this.BAgenda.TabIndex = 6;
            this.BAgenda.Text = "Agenda";
            this.BAgenda.UseVisualStyleBackColor = true;
            this.BAgenda.Click += new System.EventHandler(this.BAgenda_Click);
            // 
            // Agendar
            // 
            this.Agendar.Location = new System.Drawing.Point(232, 65);
            this.Agendar.Name = "Agendar";
            this.Agendar.Size = new System.Drawing.Size(75, 23);
            this.Agendar.TabIndex = 5;
            this.Agendar.Text = "Agendar";
            this.Agendar.UseVisualStyleBackColor = true;
            this.Agendar.Click += new System.EventHandler(this.Agendar_Click);
            // 
            // ContContactos
            // 
            this.ContContactos.Location = new System.Drawing.Point(41, 94);
            this.ContContactos.Name = "ContContactos";
            this.ContContactos.Size = new System.Drawing.Size(329, 113);
            this.ContContactos.TabIndex = 4;
            this.ContContactos.Text = "";
            // 
            // TBTalf
            // 
            this.TBTalf.Location = new System.Drawing.Point(94, 65);
            this.TBTalf.Mask = "(999) 999-9999";
            this.TBTalf.Name = "TBTalf";
            this.TBTalf.Size = new System.Drawing.Size(100, 20);
            this.TBTalf.TabIndex = 3;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(94, 28);
            this.TBNombre.Mask = "LLLLLLLLLLLLLLLLL";
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(112, 20);
            this.TBNombre.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Telf.";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(38, 28);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 269);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Resultados;
        private System.Windows.Forms.TextBox TBMin;
        private System.Windows.Forms.TextBox TBMax;
        private System.Windows.Forms.TextBox TBProm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TBCalf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgrCalf;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox TBDes;
        private System.Windows.Forms.MaskedTextBox TBPal;
        private System.Windows.Forms.Button Dicc;
        private System.Windows.Forms.RichTextBox ContPal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AgreClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox ContClient;
        private System.Windows.Forms.Button AtClient;
        private System.Windows.Forms.MaskedTextBox TBCliente;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button BAgenda;
        private System.Windows.Forms.Button Agendar;
        private System.Windows.Forms.RichTextBox ContContactos;
        private System.Windows.Forms.MaskedTextBox TBTalf;
        private System.Windows.Forms.MaskedTextBox TBNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox ContGastros;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.MaskedTextBox TBGasto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LB;
    }
}

