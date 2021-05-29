
namespace Minicalculadora_C___Eje4
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
            this.operando1 = new System.Windows.Forms.TextBox();
            this.operando2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operando1
            // 
            this.operando1.Location = new System.Drawing.Point(120, 81);
            this.operando1.Name = "operando1";
            this.operando1.Size = new System.Drawing.Size(125, 27);
            this.operando1.TabIndex = 0;
            // 
            // operando2
            // 
            this.operando2.Location = new System.Drawing.Point(120, 127);
            this.operando2.Name = "operando2";
            this.operando2.Size = new System.Drawing.Size(125, 27);
            this.operando2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(587, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(338, 57);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(94, 29);
            this.suma.TabIndex = 3;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(338, 100);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(94, 29);
            this.resta.TabIndex = 4;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(338, 144);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(94, 29);
            this.multiplicacion.TabIndex = 5;
            this.multiplicacion.Text = "*";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(338, 190);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(94, 29);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(468, 100);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(94, 29);
            this.igual.TabIndex = 7;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.operando2);
            this.Controls.Add(this.operando1);
            this.Name = "Form1";
            this.Text = "Minicalculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox operando1;
        private System.Windows.Forms.TextBox operando2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button igual;
    }
}

