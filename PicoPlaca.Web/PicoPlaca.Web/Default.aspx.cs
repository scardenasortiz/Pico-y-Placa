using PicoPlaca.DistributedServices.Contracts.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PicoPlaca.Web
{
    public partial class Default : System.Web.UI.Page
    {
        #region Variable
        ConsumoServicio consumo = new ConsumoServicio();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (ValidaIngreso(txtPlacaLetras) && ValidaIngreso(txtPlacaNumero) && ValidaIngreso(txtFecha) && ValidaIngreso(txtTiempo))
            {
                txtMensaje.Text = Recursos.Mensajes.MensajeGeneral;
            }
            else
            {
                txtMensaje.Text = consumo.ConsultarHorarios(AgregarDatos());
            }
        }


        #region Metodos Privados
        private bool ValidaIngreso(TextBox control)
        {
            try
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        private PicoPlacaDatos AgregarDatos()
        {
            var datos = new PicoPlacaDatos();
            datos.Fecha = txtFecha.Text;
            datos.Placa = string.Format("{0}-{1}", txtPlacaLetras.Text, txtPlacaNumero.Text);
            datos.Tiempo = TimeSpan.Parse(txtTiempo.Text);
            return datos;
        }
        #endregion

        protected void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtFecha.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            txtMensaje.Text = string.Empty;
            txtPlacaLetras.Text = string.Empty;
            txtPlacaNumero.Text = string.Empty;
        }
    }
}