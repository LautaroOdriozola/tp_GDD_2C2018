﻿namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class seleccionadorEmpresaRendicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer componentes = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (componentes != null))
            {
                componentes.Dispose();
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresaCuit = new System.Windows.Forms.Label();
            this.btnPagSig = new System.Windows.Forms.Button();
            this.btnPagAnt = new System.Windows.Forms.Button();
            this.lblComprasARendir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantComprasInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantComprasInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(675, 553);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // empresasDataGrid
            // 
            this.empresasDataGrid.AllowUserToAddRows = false;
            this.empresasDataGrid.AllowUserToDeleteRows = false;
            this.empresasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresasDataGrid.Location = new System.Drawing.Point(68, 151);
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.ReadOnly = true;
            this.empresasDataGrid.Size = new System.Drawing.Size(682, 328);
            this.empresasDataGrid.TabIndex = 1;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(361, 53);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(159, 20);
            this.txtCuit.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(675, 103);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(68, 103);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(578, 53);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(172, 20);
            this.txtMail.TabIndex = 26;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(137, 53);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(169, 20);
            this.txtRazonSocial.TabIndex = 25;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(65, 60);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 24;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "E- mail";
            // 
            // lblEmpresaCuit
            // 
            this.lblEmpresaCuit.AutoSize = true;
            this.lblEmpresaCuit.Location = new System.Drawing.Point(324, 56);
            this.lblEmpresaCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresaCuit.Name = "lblEmpresaCuit";
            this.lblEmpresaCuit.Size = new System.Drawing.Size(32, 13);
            this.lblEmpresaCuit.TabIndex = 30;
            this.lblEmpresaCuit.Text = "CUIT";
            // 
            // btnPagSig
            // 
            this.btnPagSig.Location = new System.Drawing.Point(647, 485);
            this.btnPagSig.Name = "btnPagSig";
            this.btnPagSig.Size = new System.Drawing.Size(103, 23);
            this.btnPagSig.TabIndex = 33;
            this.btnPagSig.Text = "Pág. Siguiente";
            this.btnPagSig.UseVisualStyleBackColor = true;
            this.btnPagSig.Click += new System.EventHandler(this.btnPagSig_Click_1);
            // 
            // btnPagAnt
            // 
            this.btnPagAnt.Location = new System.Drawing.Point(68, 485);
            this.btnPagAnt.Name = "btnPagAnt";
            this.btnPagAnt.Size = new System.Drawing.Size(98, 23);
            this.btnPagAnt.TabIndex = 32;
            this.btnPagAnt.Text = "Pág. Anterior";
            this.btnPagAnt.UseVisualStyleBackColor = true;
            this.btnPagAnt.Click += new System.EventHandler(this.btnPagAnt_Click_1);
            // 
            // lblComprasARendir
            // 
            this.lblComprasARendir.AutoSize = true;
            this.lblComprasARendir.Location = new System.Drawing.Point(180, 113);
            this.lblComprasARendir.Name = "lblComprasARendir";
            this.lblComprasARendir.Size = new System.Drawing.Size(176, 13);
            this.lblComprasARendir.TabIndex = 34;
            this.lblComprasARendir.Text = "CANTIDAD COMPRAS A RENDIR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Seleccione la empresa de la cual quiere rendir comisiones";
            // 
            // cantComprasInput
            // 
            this.cantComprasInput.Location = new System.Drawing.Point(362, 111);
            this.cantComprasInput.Name = "cantComprasInput";
            this.cantComprasInput.Size = new System.Drawing.Size(120, 20);
            this.cantComprasInput.TabIndex = 37;
            // 
            // seleccionadorEmpresaRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 608);
            this.Controls.Add(this.cantComprasInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComprasARendir);
            this.Controls.Add(this.btnPagSig);
            this.Controls.Add(this.btnPagAnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpresaCuit);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.empresasDataGrid);
            this.Controls.Add(this.btnAccept);
            this.Name = "seleccionadorEmpresaRendicion";
            this.Text = "SeleccionEmpresa";
            this.Load += new System.EventHandler(this.seleccionadorEmpresaRendicion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantComprasInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresaCuit;
        private System.Windows.Forms.Button btnPagSig;
        private System.Windows.Forms.Button btnPagAnt;
        private System.Windows.Forms.Label lblComprasARendir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cantComprasInput;
    }
}