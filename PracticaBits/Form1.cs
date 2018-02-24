using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Int32 entrada = Convert.ToInt32(txtEntrada.Text);
            Cadena(entrada).ToString();
        }
        public int Cadena(int entrada)
        {
            entrada >>= 1;
            Int32 direccion = entrada & 7;
            Direccion(direccion);
            entrada >>= 3;
            Int32 nivel = entrada & 3;
            Nivel(nivel);
            entrada >>= 2;
            Int32 s1 = entrada & 1;
            S1(s1);
            entrada >>= 1;
            Int32 s2 = entrada & 1;
            S2(s2);
            entrada >>= 1;
            Int32 dia = entrada & 31;
            entrada >>= 5;
            Int32 mes = entrada & 15;
            entrada >>= 4;
            Int32 ano = 1900 + entrada;

            lblFecha.Text = ano + "/" + mes + "/" + dia;

            return entrada;
        }

        public int Direccion(int direccion)
        {
            if (direccion == 0)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.norte;
            else if (direccion == 1)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.noreste;
            else if (direccion == 2)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.este;
            else if (direccion == 3)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.sureste;
            else if (direccion == 4)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.sur;
            else if (direccion == 5)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.suroeste;
            else if (direccion == 6)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.oeste;
            else if (direccion == 7)
                this.pictureDireccion.Image = PracticaBits.Properties.Resources.noroeste;

            return direccion;
        }
        public int Nivel(int nivel)
        {
            if (nivel == 0)
                this.pictureNivel.Image = PracticaBits.Properties.Resources.vacio;
            else if (nivel == 1)
                this.pictureNivel.Image = PracticaBits.Properties.Resources.medio;
            else if (nivel == 2)
                this.pictureNivel.Image = PracticaBits.Properties.Resources.lleno;
            else if (nivel == 3)
                this.pictureNivel.Image = PracticaBits.Properties.Resources.lleno;

            return nivel;

        }
        public int S1(int s1)
        {
            if (s1 == 0)
                this.pictureS1.Image = PracticaBits.Properties.Resources.prendido;
            else if (s1 == 1)
                this.pictureS1.Image = PracticaBits.Properties.Resources.apagado;

            return s1;
        }
        public int S2(int s2)
        {
            if (s2 == 0)
                this.pictureS2.Image = PracticaBits.Properties.Resources.prendido;
            else if (s2 == 1)
                this.pictureS2.Image = PracticaBits.Properties.Resources.apagado;

            return s2;
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            Int32 fecha = Convert.ToInt32(txtFecha.Text);
            lblFecha.Text = Fecha(fecha).ToString();
        }
        public int Fecha(int fecha)
        {
            Int32 nvfecha = 0;
            Int32 dia = fecha & 5;
            nvfecha += dia;
            fecha >>= 5;
            Int32 mes = fecha & 4;
            nvfecha += mes;
            fecha >>= 4;
            Int32 ano = fecha & 5;
            ano -= 1900;
            nvfecha += ano;

            txtNvFecha.Text = nvfecha.ToString();

            return fecha;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
