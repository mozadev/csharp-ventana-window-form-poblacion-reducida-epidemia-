
namespace poblacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuintaParte = new System.Windows.Forms.Button();
            this.txtCantidadAnimales = new System.Windows.Forms.TextBox();
            this.txtCantidadAnios = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "POBLACION ANIMAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese cantidad de animales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese cantidad de años";
            // 
            // btnQuintaParte
            // 
            this.btnQuintaParte.Location = new System.Drawing.Point(235, 267);
            this.btnQuintaParte.Name = "btnQuintaParte";
            this.btnQuintaParte.Size = new System.Drawing.Size(243, 23);
            this.btnQuintaParte.TabIndex = 3;
            this.btnQuintaParte.Text = "Quinta parte del total de animales";
            this.btnQuintaParte.UseVisualStyleBackColor = true;
            this.btnQuintaParte.Click += new System.EventHandler(this.btnQuintaParte_Click);
            // 
            // txtCantidadAnimales
            // 
            this.txtCantidadAnimales.Location = new System.Drawing.Point(327, 118);
            this.txtCantidadAnimales.Name = "txtCantidadAnimales";
            this.txtCantidadAnimales.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadAnimales.TabIndex = 4;
            // 
            // txtCantidadAnios
            // 
            this.txtCantidadAnios.Location = new System.Drawing.Point(327, 183);
            this.txtCantidadAnios.Name = "txtCantidadAnios";
            this.txtCantidadAnios.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadAnios.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(539, 267);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCantidadAnios);
            this.Controls.Add(this.txtCantidadAnimales);
            this.Controls.Add(this.btnQuintaParte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuintaParte;
        private System.Windows.Forms.TextBox txtCantidadAnimales;
        private System.Windows.Forms.TextBox txtCantidadAnios;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

