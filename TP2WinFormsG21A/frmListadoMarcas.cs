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
    public partial class frmListadoMarcas : Form
    {
        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvListadoMarcas.DataSource = negocio.listar();
        }
    }
}
