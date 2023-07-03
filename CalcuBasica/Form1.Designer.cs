namespace CalcuBasica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_multiplicacion = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor1 = new System.Windows.Forms.TextBox();
            this.btn_division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_valor2
            // 
            this.txt_valor2.Location = new System.Drawing.Point(12, 76);
            this.txt_valor2.Multiline = true;
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(100, 25);
            this.txt_valor2.TabIndex = 1;
            this.txt_valor2.TextChanged += new System.EventHandler(this.txt_valor2_TextChanged);
            // 
            // btn_suma
            // 
            this.btn_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suma.Location = new System.Drawing.Point(12, 118);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(50, 35);
            this.btn_suma.TabIndex = 3;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_multiplicacion
            // 
            this.btn_multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicacion.Location = new System.Drawing.Point(62, 118);
            this.btn_multiplicacion.Name = "btn_multiplicacion";
            this.btn_multiplicacion.Size = new System.Drawing.Size(50, 35);
            this.btn_multiplicacion.TabIndex = 4;
            this.btn_multiplicacion.Text = "x";
            this.btn_multiplicacion.UseVisualStyleBackColor = true;
            this.btn_multiplicacion.Click += new System.EventHandler(this.btn_multiplicacion_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resta.Location = new System.Drawing.Point(12, 159);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(50, 35);
            this.btn_resta.TabIndex = 5;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(12, 200);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 25);
            this.txt_resultado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado";
            // 
            // txt_valor1
            // 
            this.txt_valor1.Location = new System.Drawing.Point(12, 45);
            this.txt_valor1.Multiline = true;
            this.txt_valor1.Name = "txt_valor1";
            this.txt_valor1.Size = new System.Drawing.Size(100, 25);
            this.txt_valor1.TabIndex = 12;
            this.txt_valor1.TextChanged += new System.EventHandler(this.txt_valor1_TextChanged);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(62, 159);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(50, 35);
            this.btn_division.TabIndex = 13;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 252);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.txt_valor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_multiplicacion);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.txt_valor2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valor2;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_multiplicacion;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor1;
        private System.Windows.Forms.Button btn_division;
    }
}

