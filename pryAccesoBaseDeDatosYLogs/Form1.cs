﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAccesoBaseDeDatosYLogs
{
    public partial class frmConexionBaseDeDatos : Form
    {
        public frmConexionBaseDeDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsAccesoDatos objLogin = new clsAccesoDatos();

            objLogin.ConexionABase();
        }
    }
}
