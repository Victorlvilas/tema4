namespace Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtRgb1 = new System.Windows.Forms.TextBox();
            this.txtRgb2 = new System.Windows.Forms.TextBox();
            this.txtRgb3 = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRgb1 = new System.Windows.Forms.Label();
            this.lblRgb2 = new System.Windows.Forms.Label();
            this.lblRgb3 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(297, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(389, 47);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.button2_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // txtRgb1
            // 
            this.txtRgb1.Location = new System.Drawing.Point(152, 12);
            this.txtRgb1.Name = "txtRgb1";
            this.txtRgb1.Size = new System.Drawing.Size(100, 20);
            this.txtRgb1.TabIndex = 0;
            this.txtRgb1.Enter += new System.EventHandler(this.textBoxColor_Enter);
            // 
            // txtRgb2
            // 
            this.txtRgb2.Location = new System.Drawing.Point(152, 50);
            this.txtRgb2.Name = "txtRgb2";
            this.txtRgb2.Size = new System.Drawing.Size(100, 20);
            this.txtRgb2.TabIndex = 1;
            this.txtRgb2.Enter += new System.EventHandler(this.textBoxColor_Enter);
            // 
            // txtRgb3
            // 
            this.txtRgb3.Location = new System.Drawing.Point(152, 97);
            this.txtRgb3.Name = "txtRgb3";
            this.txtRgb3.Size = new System.Drawing.Size(100, 20);
            this.txtRgb3.TabIndex = 2;
            this.txtRgb3.Enter += new System.EventHandler(this.textBoxColor_Enter);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(124, 154);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(248, 20);
            this.txtPath.TabIndex = 4;
            this.txtPath.Enter += new System.EventHandler(this.textBoxImg_Enter);
            // 
            // lblImagen
            // 
            this.lblImagen.Location = new System.Drawing.Point(472, 200);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(297, 214);
            this.lblImagen.TabIndex = 11;
            this.lblImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(389, 151);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "Imagen";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.button3_Click);
            this.btnPath.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.btnPath.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(124, 259);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Restablecer";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button4_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // lblRgb1
            // 
            this.lblRgb1.AutoSize = true;
            this.lblRgb1.Location = new System.Drawing.Point(42, 19);
            this.lblRgb1.Name = "lblRgb1";
            this.lblRgb1.Size = new System.Drawing.Size(81, 13);
            this.lblRgb1.TabIndex = 14;
            this.lblRgb1.Text = "1. RGB  (0-255)";
            // 
            // lblRgb2
            // 
            this.lblRgb2.AutoSize = true;
            this.lblRgb2.Location = new System.Drawing.Point(42, 57);
            this.lblRgb2.Name = "lblRgb2";
            this.lblRgb2.Size = new System.Drawing.Size(81, 13);
            this.lblRgb2.TabIndex = 15;
            this.lblRgb2.Text = "2. RGB  (0-255)";
            // 
            // lblRgb3
            // 
            this.lblRgb3.AutoSize = true;
            this.lblRgb3.Location = new System.Drawing.Point(42, 104);
            this.lblRgb3.Name = "lblRgb3";
            this.lblRgb3.Size = new System.Drawing.Size(81, 13);
            this.lblRgb3.TabIndex = 16;
            this.lblRgb3.Text = "3. RGB  (0-255)";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(42, 156);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(82, 13);
            this.lblPath.TabIndex = 17;
            this.lblPath.Text = "Ruta de imagen";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblRgb3);
            this.Controls.Add(this.lblRgb2);
            this.Controls.Add(this.lblRgb1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtRgb3);
            this.Controls.Add(this.txtRgb2);
            this.Controls.Add(this.txtRgb1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtRgb1;
        private System.Windows.Forms.TextBox txtRgb2;
        private System.Windows.Forms.TextBox txtRgb3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRgb1;
        private System.Windows.Forms.Label lblRgb2;
        private System.Windows.Forms.Label lblRgb3;
        private System.Windows.Forms.Label lblPath;
    }
}

