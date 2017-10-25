using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeAPIGoogle.APIs;
using testeAPIGoogle.DB;

namespace testeAPIGoogle
{
    public partial class Principal : Form
    {
        Endereco endereco = new Endereco();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnConsuAPI_Click(object sender, EventArgs e)
        {
            ConsumirGeoAPI consuAPI = new ConsumirGeoAPI();
            string[] results = consuAPI.consumirGeoAPI(txtEnd.Text);
            txtEnd.Text = results[0];
            txtLong.Text = results[1];
            txtLat.Text = results[2];
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            endereco.cadEnd(txtEnd.Text, txtLong.Text, txtLat.Text);
        }

        private void btnConsuTodos_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = endereco.consuEnd().Tables[0];
        }

        private void txtEndConsu_TextChanged(object sender, EventArgs e)
        {
            dgvResultados.DataSource = endereco.consuEnd(txtEndConsu.Text).Tables[0];
        }
    }
}
