using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form2 : Form
    {
        public CheckedListBox cblMonedas;

        private Button btnCancelar;
        private Button btnAceptar;

        public Form2()
        {
            cblMonedas = new CheckedListBox();

            btnAceptar = new Button();
            btnCancelar = new Button();

            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(300, 300);
            this.Text = "Opciones";

            cblMonedas.Items.Add("MXN - Peso Mexicano", true);
            cblMonedas.Items.Add("USD - Dólar estadounidense", true);
            cblMonedas.Items.Add("CAD - Dólar canadiense", true);
            cblMonedas.Items.Add("EUR - Euro", true);
            cblMonedas.Items.Add("JPY - Yen japonés", true);
            cblMonedas.Size = new Size(260, 200);
            cblMonedas.Location = new Point(10, 10);
            cblMonedas.CheckOnClick = true;
            cblMonedas.SelectedIndexChanged += new EventHandler(cblMonedas_Change);
            this.Controls.Add(cblMonedas);

            btnCancelar.Text = "Cancelar";
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(10, 210);
            btnCancelar.Click += new EventHandler(btnCancelar_Click);
            this.Controls.Add(btnCancelar);

            btnAceptar.Text = "Aceptar";
            btnAceptar.AutoSize = true;
            btnAceptar.Location = new Point(197, 210);
            btnAceptar.Click += new EventHandler(btnAceptar_Click);
            this.Controls.Add(btnAceptar);
        }

        private void cblMonedas_Change(object? sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            if (cblMonedas.GetItemChecked(i) == false)
            {

            }
            else { 
            }
        }

        private void btnAceptar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
