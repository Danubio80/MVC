
namespace cursoLucas3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPeso = new System.Windows.Forms.Label();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.buttonCalculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(156, 106);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(42, 20);
            this.labelPeso.TabIndex = 0;
            this.labelPeso.Text = "Peso:";
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(235, 99);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(125, 27);
            this.textPeso.TabIndex = 1;
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(235, 170);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(125, 27);
            this.textAltura.TabIndex = 3;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(156, 177);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(52, 20);
            this.labelAltura.TabIndex = 2;
            this.labelAltura.Text = "Altura:";
            // 
            // buttonCalculo
            // 
            this.buttonCalculo.Location = new System.Drawing.Point(235, 241);
            this.buttonCalculo.Name = "buttonCalculo";
            this.buttonCalculo.Size = new System.Drawing.Size(94, 29);
            this.buttonCalculo.TabIndex = 4;
            this.buttonCalculo.Text = "Calcular";
            this.buttonCalculo.UseVisualStyleBackColor = true;
            this.buttonCalculo.Click += new System.EventHandler(this.buttonCalculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "CALCULADORA DE INDICE MASA CORPORAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculo);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.labelPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Button buttonCalculo;
        private System.Windows.Forms.Label label1;
    }
}

