﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP2WinFormsG21A
{
    public partial class FRMmenuPrincipal : Form
    {
        public FRMmenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void LBLmarca_Click(object sender, EventArgs e)
        {

        }

        private void FRMmenuPrincipal_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            try
            {
                CMBmarca.DataSource = negocioMarca.listar();
                CMBcategoria.DataSource = negocioCategoria.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListArtPorMarca ventanaListArtMarcas = new frmListArtPorMarca();
            ventanaListArtMarcas.ShowDialog();
        }

        private void todosLosArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMlistaTodosArticulos ventanaListaTodosArticulos = new FRMlistaTodosArticulos();
            ventanaListaTodosArticulos.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void MSlistarArtículos_Click(object sender, EventArgs e)
        {

        }

        private void CMBmarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXBnomnre_TextChanged(object sender, EventArgs e)
        {

        }

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoMarcas ventanaListadoMarcas = new frmListadoMarcas();
            ventanaListadoMarcas.ShowDialog();
        }

        private void CMBmarca_DropDown(object sender, EventArgs e)
        {
            ///CMBmarca.Items.Clear();

            CargarMarcas();
        }

        private void CargarMarcas()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> listaMarcas = marcaNegocio.listar();

            foreach (Marca marca in listaMarcas)
            {
                ///CMBmarca.Items.Add(marca.NombreMarca);
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();

            try
            {
                articulo.Codigo = TXBcodigo.Text;
                articulo.Nombre = TXBnomnre.Text;
                articulo.Descripcion = TXBdescripcion.Text;
                articulo.Precio = decimal.Parse(TXBprecio.Text);
                articulo.Marca = (Marca)CMBmarca.SelectedItem;
                articulo.Categoria = (Categoria)CMBcategoria.SelectedItem;

                negocioArticulo.agregar(articulo);
                MessageBox.Show("Articulo agregado");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
