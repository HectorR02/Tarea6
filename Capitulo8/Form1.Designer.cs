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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 233);
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
    }
}

