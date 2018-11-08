namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.Carbohidratos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carbohidratosNum = new System.Windows.Forms.NumericUpDown();
            this.proteinasNum = new System.Windows.Forms.NumericUpDown();
            this.grasasNum = new System.Windows.Forms.NumericUpDown();
            this.agregarButton = new System.Windows.Forms.Button();
            this.listadoComidas = new System.Windows.Forms.ListBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carbohidratosNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinasNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grasasNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(118, 28);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(100, 20);
            this.nombreText.TabIndex = 1;
            // 
            // Carbohidratos
            // 
            this.Carbohidratos.AutoSize = true;
            this.Carbohidratos.Location = new System.Drawing.Point(33, 78);
            this.Carbohidratos.Name = "Carbohidratos";
            this.Carbohidratos.Size = new System.Drawing.Size(72, 13);
            this.Carbohidratos.TabIndex = 2;
            this.Carbohidratos.Text = "Carbohidratos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proteinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grasas";
            // 
            // carbohidratosNum
            // 
            this.carbohidratosNum.Location = new System.Drawing.Point(118, 76);
            this.carbohidratosNum.Name = "carbohidratosNum";
            this.carbohidratosNum.Size = new System.Drawing.Size(120, 20);
            this.carbohidratosNum.TabIndex = 8;
            // 
            // proteinasNum
            // 
            this.proteinasNum.Location = new System.Drawing.Point(118, 109);
            this.proteinasNum.Name = "proteinasNum";
            this.proteinasNum.Size = new System.Drawing.Size(120, 20);
            this.proteinasNum.TabIndex = 9;
            // 
            // grasasNum
            // 
            this.grasasNum.Location = new System.Drawing.Point(118, 145);
            this.grasasNum.Name = "grasasNum";
            this.grasasNum.Size = new System.Drawing.Size(120, 20);
            this.grasasNum.TabIndex = 10;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(99, 192);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 11;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // listadoComidas
            // 
            this.listadoComidas.FormattingEnabled = true;
            this.listadoComidas.Location = new System.Drawing.Point(390, 28);
            this.listadoComidas.Name = "listadoComidas";
            this.listadoComidas.Size = new System.Drawing.Size(345, 225);
            this.listadoComidas.TabIndex = 12;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(510, 260);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 13;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.listadoComidas);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.grasasNum);
            this.Controls.Add(this.proteinasNum);
            this.Controls.Add(this.carbohidratosNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Carbohidratos);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.carbohidratosNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinasNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grasasNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Label Carbohidratos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown carbohidratosNum;
        private System.Windows.Forms.NumericUpDown proteinasNum;
        private System.Windows.Forms.NumericUpDown grasasNum;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.ListBox listadoComidas;
        private System.Windows.Forms.Button eliminarButton;
    }
}

