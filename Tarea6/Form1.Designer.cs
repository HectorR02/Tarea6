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
            this.AgrCalf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBCalf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBProm = new System.Windows.Forms.TextBox();
            this.TBMax = new System.Windows.Forms.TextBox();
            this.TBMin = new System.Windows.Forms.TextBox();
            this.Resultados = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 270);
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
            this.tabPage2.Size = new System.Drawing.Size(363, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calificacion";
            // 
            // TBCalf
            // 
            this.TBCalf.Location = new System.Drawing.Point(141, 36);
            this.TBCalf.Mask = "99.9";
            this.TBCalf.Name = "TBCalf";
            this.TBCalf.Size = new System.Drawing.Size(51, 20);
            this.TBCalf.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max.";
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
            // TBProm
            // 
            this.TBProm.Location = new System.Drawing.Point(65, 157);
            this.TBProm.Name = "TBProm";
            this.TBProm.ReadOnly = true;
            this.TBProm.Size = new System.Drawing.Size(53, 20);
            this.TBProm.TabIndex = 6;
            // 
            // TBMax
            // 
            this.TBMax.Location = new System.Drawing.Point(182, 157);
            this.TBMax.Name = "TBMax";
            this.TBMax.ReadOnly = true;
            this.TBMax.Size = new System.Drawing.Size(50, 20);
            this.TBMax.TabIndex = 7;
            // 
            // TBMin
            // 
            this.TBMin.Location = new System.Drawing.Point(288, 157);
            this.TBMin.Name = "TBMin";
            this.TBMin.ReadOnly = true;
            this.TBMin.Size = new System.Drawing.Size(52, 20);
            this.TBMin.TabIndex = 8;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 269);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

