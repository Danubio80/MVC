
namespace claseLucas4
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
            this.textCliente = new System.Windows.Forms.TextBox();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonMostar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(92, 48);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(220, 27);
            this.textCliente.TabIndex = 0;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(571, 48);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(139, 29);
            this.buttonAñadir.TabIndex = 2;
            this.buttonAñadir.Text = "añadir cliente";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonMostar
            // 
            this.buttonMostar.Location = new System.Drawing.Point(571, 181);
            this.buttonMostar.Name = "buttonMostar";
            this.buttonMostar.Size = new System.Drawing.Size(139, 34);
            this.buttonMostar.TabIndex = 3;
            this.buttonMostar.Text = "mostar clientes";
            this.buttonMostar.UseVisualStyleBackColor = true;
            this.buttonMostar.Click += new System.EventHandler(this.buttonMostar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(92, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 184);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonMostar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.textCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonMostar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

