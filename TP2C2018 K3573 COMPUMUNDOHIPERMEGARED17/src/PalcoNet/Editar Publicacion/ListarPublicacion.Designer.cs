﻿namespace PalcoNet.Editar_Publicacion
{
    partial class ListarPublicacion
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.publicacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2018DataSet = new PalcoNet.GD2C2018DataSet();
            this.btnPublicacionLimpiar = new System.Windows.Forms.Button();
            this.btnPublicacionBuscar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.publicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionTableAdapter = new PalcoNet.GD2C2018DataSetTableAdapters.PublicacionTableAdapter();
            this.publicacionesDataGrid = new System.Windows.Forms.DataGridView();
            this.btnPagAnt = new System.Windows.Forms.Button();
            this.btnPagSig = new System.Windows.Forms.Button();
            this.checkBorrador = new System.Windows.Forms.CheckBox();
            this.btnPagPrimera = new System.Windows.Forms.Button();
            this.btnPagUltima = new System.Windows.Forms.Button();
            this.txtUltimaPag = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPagActual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNombre.TabIndex = 47;
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(38, 73);
            this.lblRolNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(47, 13);
            this.lblRolNombre.TabIndex = 46;
            this.lblRolNombre.Text = "Nombre:";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(819, 218);
            this.btnMod.Margin = new System.Windows.Forms.Padding(2);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(66, 24);
            this.btnMod.TabIndex = 44;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(23, 20);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(200, 25);
            this.l.TabIndex = 43;
            this.l.Text = "Listar Publicacion";
            // 
            // publicacionBindingSource1
            // 
            this.publicacionBindingSource1.DataMember = "Publicacion";
            this.publicacionBindingSource1.DataSource = this.gD2C2018DataSet;
            // 
            // gD2C2018DataSet
            // 
            this.gD2C2018DataSet.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPublicacionLimpiar
            // 
            this.btnPublicacionLimpiar.Location = new System.Drawing.Point(296, 67);
            this.btnPublicacionLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPublicacionLimpiar.Name = "btnPublicacionLimpiar";
            this.btnPublicacionLimpiar.Size = new System.Drawing.Size(66, 24);
            this.btnPublicacionLimpiar.TabIndex = 41;
            this.btnPublicacionLimpiar.Text = "Limpiar";
            this.btnPublicacionLimpiar.UseVisualStyleBackColor = true;
            this.btnPublicacionLimpiar.Click += new System.EventHandler(this.btnPublicacionLimpiar_Click);
            // 
            // btnPublicacionBuscar
            // 
            this.btnPublicacionBuscar.Location = new System.Drawing.Point(379, 66);
            this.btnPublicacionBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPublicacionBuscar.Name = "btnPublicacionBuscar";
            this.btnPublicacionBuscar.Size = new System.Drawing.Size(66, 24);
            this.btnPublicacionBuscar.TabIndex = 40;
            this.btnPublicacionBuscar.Text = "Buscar";
            this.btnPublicacionBuscar.UseVisualStyleBackColor = true;
            this.btnPublicacionBuscar.Click += new System.EventHandler(this.btnPublicacionBuscar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(896, 555);
            this.shapeContainer1.TabIndex = 50;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(23, 48);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(539, 64);
            // 
            // publicacionBindingSource
            // 
            this.publicacionBindingSource.DataMember = "Publicacion";
            this.publicacionBindingSource.DataSource = this.gD2C2018DataSet;
            // 
            // publicacionTableAdapter
            // 
            this.publicacionTableAdapter.ClearBeforeFill = true;
            // 
            // publicacionesDataGrid
            // 
            this.publicacionesDataGrid.AllowUserToAddRows = false;
            this.publicacionesDataGrid.AllowUserToDeleteRows = false;
            this.publicacionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicacionesDataGrid.Location = new System.Drawing.Point(23, 122);
            this.publicacionesDataGrid.Name = "publicacionesDataGrid";
            this.publicacionesDataGrid.ReadOnly = true;
            this.publicacionesDataGrid.Size = new System.Drawing.Size(791, 375);
            this.publicacionesDataGrid.TabIndex = 51;
            // 
            // btnPagAnt
            // 
            this.btnPagAnt.Location = new System.Drawing.Point(160, 520);
            this.btnPagAnt.Name = "btnPagAnt";
            this.btnPagAnt.Size = new System.Drawing.Size(108, 23);
            this.btnPagAnt.TabIndex = 52;
            this.btnPagAnt.Text = "Pág. Anterior";
            this.btnPagAnt.UseVisualStyleBackColor = true;
            this.btnPagAnt.Click += new System.EventHandler(this.btnPagAnt_Click);
            // 
            // btnPagSig
            // 
            this.btnPagSig.Location = new System.Drawing.Point(559, 520);
            this.btnPagSig.Name = "btnPagSig";
            this.btnPagSig.Size = new System.Drawing.Size(105, 23);
            this.btnPagSig.TabIndex = 53;
            this.btnPagSig.Text = "Pág. Siguiente";
            this.btnPagSig.UseVisualStyleBackColor = true;
            this.btnPagSig.Click += new System.EventHandler(this.btnPagSig_Click);
            // 
            // checkBorrador
            // 
            this.checkBorrador.AutoSize = true;
            this.checkBorrador.Location = new System.Drawing.Point(466, 73);
            this.checkBorrador.Name = "checkBorrador";
            this.checkBorrador.Size = new System.Drawing.Size(89, 17);
            this.checkBorrador.TabIndex = 54;
            this.checkBorrador.Text = "Sólo borrador";
            this.checkBorrador.UseVisualStyleBackColor = true;
            this.checkBorrador.CheckedChanged += new System.EventHandler(this.checkBorrador_CheckedChanged);
            // 
            // btnPagPrimera
            // 
            this.btnPagPrimera.Location = new System.Drawing.Point(41, 520);
            this.btnPagPrimera.Name = "btnPagPrimera";
            this.btnPagPrimera.Size = new System.Drawing.Size(75, 23);
            this.btnPagPrimera.TabIndex = 55;
            this.btnPagPrimera.Text = "Primera";
            this.btnPagPrimera.UseVisualStyleBackColor = true;
            this.btnPagPrimera.Click += new System.EventHandler(this.btnPagPrimera_Click);
            // 
            // btnPagUltima
            // 
            this.btnPagUltima.Location = new System.Drawing.Point(704, 520);
            this.btnPagUltima.Name = "btnPagUltima";
            this.btnPagUltima.Size = new System.Drawing.Size(75, 23);
            this.btnPagUltima.TabIndex = 56;
            this.btnPagUltima.Text = "Ultima";
            this.btnPagUltima.UseVisualStyleBackColor = true;
            this.btnPagUltima.Click += new System.EventHandler(this.btnPagUltima_Click);
            // 
            // txtUltimaPag
            // 
            this.txtUltimaPag.AutoSize = true;
            this.txtUltimaPag.Location = new System.Drawing.Point(438, 524);
            this.txtUltimaPag.Name = "txtUltimaPag";
            this.txtUltimaPag.Size = new System.Drawing.Size(17, 13);
            this.txtUltimaPag.TabIndex = 60;
            this.txtUltimaPag.Text = "yy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "de";
            // 
            // txtPagActual
            // 
            this.txtPagActual.AutoSize = true;
            this.txtPagActual.Location = new System.Drawing.Point(388, 524);
            this.txtPagActual.Name = "txtPagActual";
            this.txtPagActual.Size = new System.Drawing.Size(17, 13);
            this.txtPagActual.TabIndex = 58;
            this.txtPagActual.Text = "xx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Página";
            // 
            // ListarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 555);
            this.Controls.Add(this.txtUltimaPag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPagActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPagUltima);
            this.Controls.Add(this.btnPagPrimera);
            this.Controls.Add(this.checkBorrador);
            this.Controls.Add(this.btnPagSig);
            this.Controls.Add(this.btnPagAnt);
            this.Controls.Add(this.publicacionesDataGrid);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.l);
            this.Controls.Add(this.btnPublicacionLimpiar);
            this.Controls.Add(this.btnPublicacionBuscar);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListarPublicacion";
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.listarPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnPublicacionLimpiar;
        private System.Windows.Forms.Button btnPublicacionBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private GD2C2018DataSet gD2C2018DataSet;
        private System.Windows.Forms.BindingSource publicacionBindingSource;
        private GD2C2018DataSetTableAdapters.PublicacionTableAdapter publicacionTableAdapter;
        private System.Windows.Forms.BindingSource publicacionBindingSource1;
        private System.Windows.Forms.DataGridView publicacionesDataGrid;
        private System.Windows.Forms.Button btnPagAnt;
        private System.Windows.Forms.Button btnPagSig;
        private System.Windows.Forms.CheckBox checkBorrador;
        private System.Windows.Forms.Button btnPagPrimera;
        private System.Windows.Forms.Button btnPagUltima;
        private System.Windows.Forms.Label txtUltimaPag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtPagActual;
        private System.Windows.Forms.Label label5;
    }
}