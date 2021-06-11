
namespace conversionMoneda
{
    partial class frmPrincipal
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
            this.gpbIngresoColones = new System.Windows.Forms.GroupBox();
            this.txtConvertir = new System.Windows.Forms.TextBox();
            this.lblColones = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.gpbConversion = new System.Windows.Forms.GroupBox();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.txtColones2 = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtColones1 = new System.Windows.Forms.TextBox();
            this.lblEuros = new System.Windows.Forms.Label();
            this.lblColones2 = new System.Windows.Forms.Label();
            this.lblColones1 = new System.Windows.Forms.Label();
            this.lblDolares = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gpbIngresoColones.SuspendLayout();
            this.gpbConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIngresoColones
            // 
            this.gpbIngresoColones.Controls.Add(this.txtConvertir);
            this.gpbIngresoColones.Controls.Add(this.lblColones);
            this.gpbIngresoColones.Controls.Add(this.lblMonto);
            this.gpbIngresoColones.Location = new System.Drawing.Point(12, 12);
            this.gpbIngresoColones.Name = "gpbIngresoColones";
            this.gpbIngresoColones.Size = new System.Drawing.Size(273, 100);
            this.gpbIngresoColones.TabIndex = 0;
            this.gpbIngresoColones.TabStop = false;
            this.gpbIngresoColones.Text = "Ingreso en colones";
            // 
            // txtConvertir
            // 
            this.txtConvertir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertir.Location = new System.Drawing.Point(19, 65);
            this.txtConvertir.Name = "txtConvertir";
            this.txtConvertir.Size = new System.Drawing.Size(100, 26);
            this.txtConvertir.TabIndex = 10;
            // 
            // lblColones
            // 
            this.lblColones.AutoSize = true;
            this.lblColones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColones.Location = new System.Drawing.Point(125, 68);
            this.lblColones.Name = "lblColones";
            this.lblColones.Size = new System.Drawing.Size(59, 19);
            this.lblColones.TabIndex = 1;
            this.lblColones.Text = "Colones";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(15, 28);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(177, 19);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Ingrese el monto a convertir";
            // 
            // gpbConversion
            // 
            this.gpbConversion.Controls.Add(this.txtEuros);
            this.gpbConversion.Controls.Add(this.txtColones2);
            this.gpbConversion.Controls.Add(this.txtDolares);
            this.gpbConversion.Controls.Add(this.txtColones1);
            this.gpbConversion.Controls.Add(this.lblEuros);
            this.gpbConversion.Controls.Add(this.lblColones2);
            this.gpbConversion.Controls.Add(this.lblColones1);
            this.gpbConversion.Controls.Add(this.lblDolares);
            this.gpbConversion.Location = new System.Drawing.Point(12, 118);
            this.gpbConversion.Name = "gpbConversion";
            this.gpbConversion.Size = new System.Drawing.Size(378, 159);
            this.gpbConversion.TabIndex = 1;
            this.gpbConversion.TabStop = false;
            this.gpbConversion.Text = "Conversion";
            // 
            // txtEuros
            // 
            this.txtEuros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuros.Location = new System.Drawing.Point(203, 80);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.ReadOnly = true;
            this.txtEuros.Size = new System.Drawing.Size(100, 26);
            this.txtEuros.TabIndex = 9;
            // 
            // txtColones2
            // 
            this.txtColones2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColones2.Location = new System.Drawing.Point(19, 80);
            this.txtColones2.Name = "txtColones2";
            this.txtColones2.ReadOnly = true;
            this.txtColones2.Size = new System.Drawing.Size(100, 26);
            this.txtColones2.TabIndex = 8;
            // 
            // txtDolares
            // 
            this.txtDolares.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolares.Location = new System.Drawing.Point(203, 35);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.ReadOnly = true;
            this.txtDolares.Size = new System.Drawing.Size(100, 26);
            this.txtDolares.TabIndex = 7;
            // 
            // txtColones1
            // 
            this.txtColones1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColones1.Location = new System.Drawing.Point(19, 31);
            this.txtColones1.Name = "txtColones1";
            this.txtColones1.ReadOnly = true;
            this.txtColones1.Size = new System.Drawing.Size(100, 26);
            this.txtColones1.TabIndex = 6;
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuros.Location = new System.Drawing.Point(309, 87);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(44, 19);
            this.lblEuros.TabIndex = 5;
            this.lblEuros.Text = "Euros";
            // 
            // lblColones2
            // 
            this.lblColones2.AutoSize = true;
            this.lblColones2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColones2.Location = new System.Drawing.Point(125, 87);
            this.lblColones2.Name = "lblColones2";
            this.lblColones2.Size = new System.Drawing.Size(59, 19);
            this.lblColones2.TabIndex = 4;
            this.lblColones2.Text = "Colones";
            // 
            // lblColones1
            // 
            this.lblColones1.AutoSize = true;
            this.lblColones1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColones1.Location = new System.Drawing.Point(125, 38);
            this.lblColones1.Name = "lblColones1";
            this.lblColones1.Size = new System.Drawing.Size(59, 19);
            this.lblColones1.TabIndex = 3;
            this.lblColones1.Text = "Colones";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.Location = new System.Drawing.Point(309, 38);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(56, 19);
            this.lblDolares.TabIndex = 2;
            this.lblDolares.Text = "Dolares";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(315, 22);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(315, 51);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(315, 80);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 289);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.gpbConversion);
            this.Controls.Add(this.gpbIngresoColones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Conversion de Moneda";
            this.gpbIngresoColones.ResumeLayout(false);
            this.gpbIngresoColones.PerformLayout();
            this.gpbConversion.ResumeLayout(false);
            this.gpbConversion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIngresoColones;
        private System.Windows.Forms.TextBox txtConvertir;
        private System.Windows.Forms.Label lblColones;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox gpbConversion;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.TextBox txtColones2;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtColones1;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.Label lblColones2;
        private System.Windows.Forms.Label lblColones1;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

