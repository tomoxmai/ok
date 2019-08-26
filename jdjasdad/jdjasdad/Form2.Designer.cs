namespace jdjasdad
{
    partial class Curso_programacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.basic = new System.Windows.Forms.CheckBox();
            this.c = new System.Windows.Forms.CheckBox();
            this.credito = new System.Windows.Forms.RadioButton();
            this.paypal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cursos en venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Formas de pago";
            // 
            // basic
            // 
            this.basic.AutoSize = true;
            this.basic.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basic.Location = new System.Drawing.Point(18, 285);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(148, 23);
            this.basic.TabIndex = 5;
            this.basic.Text = "VISUAL BASIC";
            this.basic.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(18, 153);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(118, 23);
            this.c.TabIndex = 6;
            this.c.Text = "Visual C#";
            this.c.UseVisualStyleBackColor = true;
            // 
            // credito
            // 
            this.credito.AutoSize = true;
            this.credito.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credito.Location = new System.Drawing.Point(314, 153);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(191, 23);
            this.credito.TabIndex = 7;
            this.credito.TabStop = true;
            this.credito.Text = "Tarjeta Credito";
            this.credito.UseVisualStyleBackColor = true;
            // 
            // paypal
            // 
            this.paypal.AutoSize = true;
            this.paypal.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paypal.Location = new System.Drawing.Point(314, 284);
            this.paypal.Name = "paypal";
            this.paypal.Size = new System.Drawing.Size(96, 23);
            this.paypal.TabIndex = 8;
            this.paypal.TabStop = true;
            this.paypal.Text = "PayPal";
            this.paypal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "comprar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Curso_programacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(553, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paypal);
            this.Controls.Add(this.credito);
            this.Controls.Add(this.c);
            this.Controls.Add(this.basic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Curso_programacion";
            this.Text = "Curso programacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox basic;
        private System.Windows.Forms.CheckBox c;
        private System.Windows.Forms.RadioButton credito;
        private System.Windows.Forms.RadioButton paypal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}