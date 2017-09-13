﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseOcho.ClasesGenericas;

namespace TestPaletaWindowsForm
{
    public partial class FrmPaleta : Form
    {
        private Paleta _paleta;
        

        public FrmPaleta()
        {
            InitializeComponent();
            this._paleta = new Paleta();
        }

        private void FrmPaleta_Load(object sender, EventArgs e)
        {

        }

        private void btnMas_Click_1(object sender, EventArgs e)
        {
            /*Tempera unaTempera = new Tempera(ConsoleColor.Blue, "BIC", 10);
            this._paleta += unaTempera;            
            listBox2.Items.Clear();
            listBox2.Items.Add((string)this._paleta);
            */
            FrmTempera frm = new FrmTempera();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
                this._paleta += frm.getTempera();

            listBox2.Items.Clear();

            foreach (Tempera i in _paleta.getTemperas())
            {
                listBox2.Items.Add(Tempera.Mostrar(i));
            }
            
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
           
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera(this._paleta.getTemperas()[listBox2.SelectedIndex]);
            frm.ShowDialog();
            
        }

        private void FrmPaleta_Load_1(object sender, EventArgs e)
        {

        }

       




        
    }
}