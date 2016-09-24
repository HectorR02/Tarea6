namespace Capitulo8
{
    partial class Capitulo8
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TBCadena = new System.Windows.Forms.TextBox();
            this.Listo = new System.Windows.Forms.Button();
            this.Separadas = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCad = new System.Windows.Forms.TextBox();
            this.Jutificar = new System.Windows.Forms.GroupBox();
            this.CBJustificar = new System.Windows.Forms.ComboBox();
            this.RTBPalJust = new System.Windows.Forms.RichTextBox();
            this.AgrJust = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TBDatTim = new System.Windows.Forms.TextBox();
            this.ActHora = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBCad1 = new System.Windows.Forms.TextBox();
            this.TBCad2 = new System.Windows.Forms.TextBox();
            this.RTBOrdenadas = new System.Windows.Forms.RichTextBox();
            this.ordenar = new System.Windows.Forms.Button();
            this.TBNum1 = new System.Windows.Forms.MaskedTextBox();
            this.TBnum2 = new System.Windows.Forms.MaskedTextBox();
            this.CBOperacion = new System.Windows.Forms.ComboBox();
            this.Resultado = new System.Windows.Forms.Button();
            this.TBResultado = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Jutificar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 259);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Separadas);
            this.tabPage1.Controls.Add(this.Listo);
            this.tabPage1.Controls.Add(this.TBCadena);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ej 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AgrJust);
            this.tabPage2.Controls.Add(this.RTBPalJust);
            this.tabPage2.Controls.Add(this.Jutificar);
            this.tabPage2.Controls.Add(this.TBCad);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ej 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena";
            // 
            // TBCadena
            // 
            this.TBCadena.Location = new System.Drawing.Point(55, 18);
            this.TBCadena.Name = "TBCadena";
            this.TBCadena.Size = new System.Drawing.Size(220, 20);
            this.TBCadena.TabIndex = 1;
            // 
            // Listo
            // 
            this.Listo.Location = new System.Drawing.Point(281, 16);
            this.Listo.Name = "Listo";
            this.Listo.Size = new System.Drawing.Size(40, 23);
            this.Listo.TabIndex = 2;
            this.Listo.Text = "Listo";
            this.Listo.UseVisualStyleBackColor = true;
            this.Listo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Separadas
            // 
            this.Separadas.Location = new System.Drawing.Point(26, 67);
            this.Separadas.Name = "Separadas";
            this.Separadas.Size = new System.Drawing.Size(279, 142);
            this.Separadas.TabIndex = 3;
            this.Separadas.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadena";
            // 
            // TBCad
            // 
            this.TBCad.Location = new System.Drawing.Point(74, 29);
            this.TBCad.Name = "TBCad";
            this.TBCad.Size = new System.Drawing.Size(169, 20);
            this.TBCad.TabIndex = 1;
            // 
            // Jutificar
            // 
            this.Jutificar.Controls.Add(this.CBJustificar);
            this.Jutificar.Location = new System.Drawing.Point(26, 65);
            this.Jutificar.Name = "Jutificar";
            this.Jutificar.Size = new System.Drawing.Size(138, 50);
            this.Jutificar.TabIndex = 2;
            this.Jutificar.TabStop = false;
            this.Jutificar.Text = "Forma de Jutificar";
            // 
            // CBJustificar
            // 
            this.CBJustificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBJustificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBJustificar.FormattingEnabled = true;
            this.CBJustificar.Items.AddRange(new object[] {
            "Seleccionar...",
            "Rigth",
            "Lefth"});
            this.CBJustificar.Location = new System.Drawing.Point(6, 19);
            this.CBJustificar.Name = "CBJustificar";
            this.CBJustificar.Size = new System.Drawing.Size(121, 21);
            this.CBJustificar.TabIndex = 0;
            // 
            // RTBPalJust
            // 
            this.RTBPalJust.Location = new System.Drawing.Point(27, 125);
            this.RTBPalJust.Name = "RTBPalJust";
            this.RTBPalJust.Size = new System.Drawing.Size(284, 91);
            this.RTBPalJust.TabIndex = 3;
            this.RTBPalJust.Text = "";
            // 
            // AgrJust
            // 
            this.AgrJust.Location = new System.Drawing.Point(197, 78);
            this.AgrJust.Name = "AgrJust";
            this.AgrJust.Size = new System.Drawing.Size(81, 26);
            this.AgrJust.TabIndex = 4;
            this.AgrJust.Text = "Justificar";
            this.AgrJust.UseVisualStyleBackColor = true;
            this.AgrJust.Click += new System.EventHandler(this.AgrJust_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ActHora);
            this.tabPage3.Controls.Add(this.TBDatTim);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(335, 233);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ej 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TBDatTim
            // 
            this.TBDatTim.Location = new System.Drawing.Point(53, 76);
            this.TBDatTim.Name = "TBDatTim";
            this.TBDatTim.Size = new System.Drawing.Size(221, 20);
            this.TBDatTim.TabIndex = 0;
            // 
            // ActHora
            // 
            this.ActHora.Location = new System.Drawing.Point(122, 122);
            this.ActHora.Name = "ActHora";
            this.ActHora.Size = new System.Drawing.Size(75, 23);
            this.ActHora.TabIndex = 1;
            this.ActHora.Text = "Actualizar";
            this.ActHora.UseVisualStyleBackColor = true;
            this.ActHora.Click += new System.EventHandler(this.ActHora_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TBResultado);
            this.tabPage4.Controls.Add(this.Resultado);
            this.tabPage4.Controls.Add(this.CBOperacion);
            this.tabPage4.Controls.Add(this.TBnum2);
            this.tabPage4.Controls.Add(this.TBNum1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(335, 233);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ej 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ordenar);
            this.tabPage5.Controls.Add(this.RTBOrdenadas);
            this.tabPage5.Controls.Add(this.TBCad2);
            this.tabPage5.Controls.Add(this.TBCad1);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(335, 233);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ej 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cadena1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cadena2";
            // 
            // TBCad1
            // 
            this.TBCad1.Location = new System.Drawing.Point(99, 39);
            this.TBCad1.Name = "TBCad1";
            this.TBCad1.Size = new System.Drawing.Size(100, 20);
            this.TBCad1.TabIndex = 2;
            // 
            // TBCad2
            // 
            this.TBCad2.Location = new System.Drawing.Point(99, 78);
            this.TBCad2.Name = "TBCad2";
            this.TBCad2.Size = new System.Drawing.Size(100, 20);
            this.TBCad2.TabIndex = 3;
            // 
            // RTBOrdenadas
            // 
            this.RTBOrdenadas.Location = new System.Drawing.Point(62, 124);
            this.RTBOrdenadas.Name = "RTBOrdenadas";
            this.RTBOrdenadas.Size = new System.Drawing.Size(220, 78);
            this.RTBOrdenadas.TabIndex = 4;
            this.RTBOrdenadas.Text = "";
            // 
            // ordenar
            // 
            this.ordenar.Location = new System.Drawing.Point(221, 56);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(75, 23);
            this.ordenar.TabIndex = 5;
            this.ordenar.Text = "Ordenar";
            this.ordenar.UseVisualStyleBackColor = true;
            this.ordenar.Click += new System.EventHandler(this.ordenar_Click);
            // 
            // TBNum1
            // 
            this.TBNum1.Location = new System.Drawing.Point(42, 59);
            this.TBNum1.Mask = "99";
            this.TBNum1.Name = "TBNum1";
            this.TBNum1.Size = new System.Drawing.Size(38, 20);
            this.TBNum1.TabIndex = 0;
            // 
            // TBnum2
            // 
            this.TBnum2.Location = new System.Drawing.Point(234, 59);
            this.TBnum2.Mask = "99";
            this.TBnum2.Name = "TBnum2";
            this.TBnum2.Size = new System.Drawing.Size(49, 20);
            this.TBnum2.TabIndex = 1;
            // 
            // CBOperacion
            // 
            this.CBOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOperacion.FormattingEnabled = true;
            this.CBOperacion.Items.AddRange(new object[] {
            "Suma",
            "Resta"});
            this.CBOperacion.Location = new System.Drawing.Point(121, 59);
            this.CBOperacion.Name = "CBOperacion";
            this.CBOperacion.Size = new System.Drawing.Size(74, 21);
            this.CBOperacion.TabIndex = 2;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(180, 116);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(75, 23);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Resultado";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // TBResultado
            // 
            this.TBResultado.Location = new System.Drawing.Point(71, 119);
            this.TBResultado.Name = "TBResultado";
            this.TBResultado.ReadOnly = true;
            this.TBResultado.Size = new System.Drawing.Size(66, 20);
            this.TBResultado.TabIndex = 4;
            // 
            // Capitulo8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Capitulo8";
            this.Text = "Capitulo8";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Jutificar.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox Separadas;
        private System.Windows.Forms.Button Listo;
        private System.Windows.Forms.TextBox TBCadena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Jutificar;
        private System.Windows.Forms.ComboBox CBJustificar;
        private System.Windows.Forms.TextBox TBCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgrJust;
        private System.Windows.Forms.RichTextBox RTBPalJust;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ActHora;
        private System.Windows.Forms.TextBox TBDatTim;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button ordenar;
        private System.Windows.Forms.RichTextBox RTBOrdenadas;
        private System.Windows.Forms.TextBox TBCad2;
        private System.Windows.Forms.TextBox TBCad1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBOperacion;
        private System.Windows.Forms.MaskedTextBox TBnum2;
        private System.Windows.Forms.MaskedTextBox TBNum1;
        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.TextBox TBResultado;
    }
}

