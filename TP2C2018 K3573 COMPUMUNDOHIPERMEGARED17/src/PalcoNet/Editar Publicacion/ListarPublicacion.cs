﻿using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.DataBasePackage;
using PalcoNet.PublicacionesUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Editar_Publicacion
{
    public partial class ListarPublicacion : Form
    {
        private Pagina PaginaActual;
        private Empresa empresa;
        private int countResult;

        public ListarPublicacion(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            PaginaActual = new Pagina(1, 15);
            publicacionesDataGrid.MultiSelect = false;
        }

        private Boolean SoloBorradores
        {
            get
            {
                return checkBorrador.Checked;
            }
        }

        private void listarPublicacion_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
            ActualizarCantPaginas();
        }

        private void ActualizarTabla()
        {
            var lista = new BindingList<Publicacion>(
                Publicaciones.PublicacionesByEmpresaId(idEmpresa:empresa.id, pag:PaginaActual,
                soloBorradores:SoloBorradores, nombre:txtNombre.Text));
            var bindingSource = new BindingSource(lista, null);

            publicacionesDataGrid.DataSource = bindingSource;
            publicacionesDataGrid.Columns["id"].Visible = false;
            ActualizarTextPaginaActual();
        }

        private void ActualizarTextPaginaActual()
        {
            this.txtPagActual.Text = this.PaginaActual.pageNumber.ToString();
        }

        private void ActualizarCantPaginas()
        {
            this.countResult = Publicaciones
                .CantidadPublicacionesByEmpresaId(idEmpresa: empresa.id,
                soloBorradores: SoloBorradores, nombre: txtNombre.Text);
            this.txtUltimaPag.Text = this.PaginaActual.LastPageNumer(countResult).ToString();
        }

        private void btnPagSig_Click(object sender, EventArgs e)
        {
            if (PaginaActual.TieneSiguiente(this.countResult))
            {
                PaginaActual.Next();
                ActualizarTabla();
            }
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            PaginaActual.Previous();
            ActualizarTabla();
        }

        private void btnPublicacionLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            PaginaActual.pageNumber = 1;
            ActualizarCantPaginas();
            ActualizarTabla();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Publicacion publicacion;
            try
            {
                publicacion = PublicacionSeleccionada();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una publicacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!publicacion.PuedeModificarse())
            {
                MessageBox.Show("Esta publicación no puede modificarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ignored = new EditarPublicacion(new FuncionModificarPublicacion(publicacion), empresa).ShowDialog();
            ActualizarTabla();
        }

        private Publicacion PublicacionSeleccionada()
        {
            return (Publicacion)publicacionesDataGrid.CurrentRow.DataBoundItem;
        }

        private void checkBorrador_CheckedChanged(object sender, EventArgs e)
        {
            PaginaActual.pageNumber = 1;
            ActualizarCantPaginas();
            ActualizarTabla();
        }

        private void btnPublicacionBuscar_Click(object sender, EventArgs e)
        {
            ActualizarCantPaginas();
            PaginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            PaginaActual.Last(countResult);
            ActualizarTabla();
        }

        private void btnPagPrimera_Click(object sender, EventArgs e)
        {
            PaginaActual.pageNumber = 1;
            ActualizarTabla();
        }

    }
}
