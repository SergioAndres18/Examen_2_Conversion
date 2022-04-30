namespace Conversion
{
    public partial class Form1 : Form
    {
        private Label lblMoneda;
        private Label lblMonto;
        private Label lblConv;
        private Label lblMXN;
        private Label lblUSD;
        private Label lblCAD;
        private Label lblEUR;
        private Label lblJPY;

        private Button btnCalcular;
        private Button btnOpciones;

        private TextBox txtDisplay;
        private TextBox txtMXN;
        private TextBox txtUSD;
        private TextBox txtCAD;
        private TextBox txtEUR;
        private TextBox txtJPY;

        private ComboBox cmbMonedas;

        private bool USD;
        private bool MXN;
        private bool CAD;
        private bool EUR;
        private bool JPY;

        public Form1()
        {
            lblMoneda = new Label();
            lblMonto = new Label();
            lblConv = new Label();
            lblMXN = new Label();
            lblUSD = new Label();
            lblCAD = new Label();
            lblEUR = new Label();
            lblJPY = new Label();
            
            btnCalcular = new Button();
            btnOpciones = new Button();

            txtDisplay = new TextBox();
            txtMXN = new TextBox();
            txtUSD = new TextBox();
            txtCAD = new TextBox();
            txtEUR = new TextBox();
            txtJPY = new TextBox();

            cmbMonedas = new ComboBox();

            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(400, 405);
            this.Text = "Conversión de Monedas";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            //--------------------------------------------------------------------------------------------
            //Etiquetas
            lblMoneda.Text = "Moneda";
            lblMoneda.AutoSize = true;
            lblMoneda.Location = new Point(10, 10);
            this.Controls.Add(lblMoneda);

            lblMonto.Text = "Monto";
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(230, 10);
            this.Controls.Add(lblMonto);

            lblConv.Text = "Conversiones";
            lblConv.AutoSize = true;
            lblConv.Location = new Point(10, 110);
            this.Controls.Add(lblConv);

            lblMXN.Text = "MXN - Peso - - - - - - - - - - - - -";
            lblMXN.AutoSize = true;
            lblMXN.Location = new Point(10, 145);
            lblMXN.Visible = false;
            this.Controls.Add(lblMXN);

            lblUSD.Text = "USD - Dólar - - - - - - - - - - - - -";
            lblUSD.AutoSize = true;
            lblUSD.Location = new Point(10, 180);
            lblUSD.Visible = false;
            this.Controls.Add(lblUSD);

            lblCAD.Text = "CAD - Dólar - - - - - - - - - - - - -";
            lblCAD.AutoSize = true;
            lblCAD.Location = new Point(10, 215);
            lblCAD.Visible = false;
            this.Controls.Add(lblCAD);

            lblEUR.Text = "EUR - Euro - - - - - - - - - - - - - -";
            lblEUR.AutoSize = true;
            lblEUR.Location = new Point(10, 250);
            lblEUR.Visible = false;
            this.Controls.Add(lblEUR);

            lblJPY.Text = "JPY - Yen - - - - - - - - - - - - - - -";
            lblJPY.AutoSize = true;
            lblJPY.Location = new Point(10, 285);
            lblJPY.Visible = false;
            this.Controls.Add(lblJPY);

            //--------------------------------------------------------------------------------------------
            //Botones
            btnCalcular.Text = "Calcular";
            btnCalcular.Size = new Size(140, 30);
            btnCalcular.Location = new Point(230, 75);
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
            this.Controls.Add(btnCalcular);

            btnOpciones.Text = "Opciones";
            btnOpciones.AutoSize = true;
            btnOpciones.Location = new Point(10, 320);
            btnOpciones.Click += new EventHandler(btnOpciones_Click);
            this.Controls.Add(btnOpciones);

            //--------------------------------------------------------------------------------------------
            //Cajas de Texto
            txtDisplay.Size = new Size(140, 10);
            txtDisplay.Location = new Point(230, 40);
            this.Controls.Add(txtDisplay);

            txtMXN.Size = new Size(140, 10);
            txtMXN.Location = new Point(230, 140);
            txtMXN.Visible = false;
            this.Controls.Add(txtMXN);

            txtUSD.Size = new Size(140, 10);
            txtUSD.Location = new Point(230, 175);
            txtUSD.Visible = false;
            this.Controls.Add(txtUSD);

            txtCAD.Size = new Size(140, 10);
            txtCAD.Location = new Point(230, 210);
            txtCAD.Visible = false;
            this.Controls.Add(txtCAD);

            txtEUR.Size = new Size(140, 10);
            txtEUR.Location = new Point(230, 245);
            txtEUR.Visible = false;
            this.Controls.Add(txtEUR);

            txtJPY.Size = new Size(140, 10);
            txtJPY.Location = new Point(230, 280);
            txtJPY.Visible = false;
            this.Controls.Add(txtJPY);

            //--------------------------------------------------------------------------------------------
            //Combo Box
            cmbMonedas.Items.Add("Seleccionar Moneda");
            cmbMonedas.Items.Add("MXN - Peso Mexicano");
            cmbMonedas.Items.Add("USD - Dólar Estadounidense");
            cmbMonedas.Items.Add("CAD - Dólar Canadiense");
            cmbMonedas.Items.Add("EUR - Euro");
            cmbMonedas.Items.Add("JPY - Yen Japonés");
            cmbMonedas.SelectedIndex = 0;
            cmbMonedas.Location = new Point(10, 40);
            cmbMonedas.Size = new Size(215, 10);
            cmbMonedas.SelectedValueChanged += new EventHandler(cmb_ValueChanged);
            this.Controls.Add(cmbMonedas);

        }

        private void btnOpciones_Click(object? sender, EventArgs e)
        {
            Form2 frmVentana = new Form2();
            if (frmVentana.ShowDialog() == DialogResult.OK)
            {
                
            }
            else
            {

            }

        }

        private void btnCalcular_Click(object? sender, EventArgs e)
        {
            int moneda = cmbMonedas.SelectedIndex;
            string a;
            a = "0.00";

            if(txtDisplay.Text != "" && (txtDisplay.Text).All(char.IsDigit)) {
                if (moneda == 1)
                {
                    txtUSD.Text = $"$ {(Double.Parse(txtDisplay.Text) * 0.05).ToString(a)}";
                    txtCAD.Text = $"$ {(Double.Parse(txtDisplay.Text) * 0.06).ToString(a)}";
                    txtEUR.Text = $"€ {(Double.Parse(txtDisplay.Text) * 0.04).ToString(a)}";
                    txtJPY.Text = $"¥ {(Double.Parse(txtDisplay.Text) * 5.32).ToString(a)}";
                }
                if (moneda == 2)
                {
                    txtMXN.Text = $"$ {(Double.Parse(txtDisplay.Text) * 21.23).ToString(a)}";
                    txtCAD.Text = $"$ {(Double.Parse(txtDisplay.Text) * 1.28).ToString(a)}";
                    txtEUR.Text = $"€ {(Double.Parse(txtDisplay.Text) * 0.89).ToString(a)}";
                    txtJPY.Text = $"¥ {(Double.Parse(txtDisplay.Text) * 113.05).ToString(a)}";
                }
                if (moneda == 3)
                {
                    txtUSD.Text = $"$ {(Double.Parse(txtDisplay.Text) * 0.78).ToString(a)}";
                    txtMXN.Text = $"$ {(Double.Parse(txtDisplay.Text) * 16.55).ToString(a)}";
                    txtEUR.Text = $"€ {(Double.Parse(txtDisplay.Text) * 0.69).ToString(a)}";
                    txtJPY.Text = $"¥ {(Double.Parse(txtDisplay.Text) * 88.12).ToString(a)}";
                }
                if (moneda == 4)
                {
                    txtUSD.Text = $"$ {(Double.Parse(txtDisplay.Text) * 1.13).ToString(a)}";
                    txtCAD.Text = $"$ {(Double.Parse(txtDisplay.Text) * 1.45).ToString(a)}";
                    txtMXN.Text = $"$ {(Double.Parse(txtDisplay.Text) * 23.96).ToString(a)}";
                    txtJPY.Text = $"¥ {(Double.Parse(txtDisplay.Text) * 127.56).ToString(a)}";
                }
                if (moneda == 5)
                {
                    txtUSD.Text = $"$ { (Double.Parse(txtDisplay.Text) * 0.0088).ToString(a)}";
                    txtCAD.Text = $"$ {(Double.Parse(txtDisplay.Text) * 0.0113).ToString(a)}";
                    txtEUR.Text = $"€ {(Double.Parse(txtDisplay.Text) * 0.0078).ToString(a)}";
                    txtMXN.Text = $"$ {(Double.Parse(txtDisplay.Text) * 0.1878).ToString(a)}";
                }
            }
            else if(txtDisplay.Text == "")
            {
                MessageBox.Show("No ingresaste ningún monto");
                txtDisplay.Text = "";
            }
            else
            {
                MessageBox.Show("Debes ingresar un monto numérico");
                txtDisplay.Text = "";
            }
        }

        private void cmb_ValueChanged(object? sender, EventArgs e)
        {
            if (cmbMonedas.SelectedIndex != 0)
            {
                txtMXN.Text = "";
                txtUSD.Text = "";
                txtCAD.Text = "";
                txtEUR.Text = "";
                txtJPY.Text = "";

                if (cmbMonedas.SelectedIndex == 1)//MXN
                {
                    lblMXN.Visible = false;
                    lblUSD.Visible = true;
                    lblCAD.Visible = true;
                    lblEUR.Visible = true;
                    lblJPY.Visible = true;

                    txtMXN.Visible = false;
                    txtUSD.Visible = true;
                    txtCAD.Visible = true;
                    txtEUR.Visible = true;
                    txtJPY.Visible = true;

                    txtUSD.Location = new Point(230, 140);
                    txtCAD.Location = new Point(230, 175);
                    txtEUR.Location = new Point(230, 210);
                    txtJPY.Location = new Point(230, 245);

                    lblUSD.Location = new Point(10, 145);
                    lblCAD.Location = new Point(10, 180);
                    lblEUR.Location = new Point(10, 215);
                    lblJPY.Location = new Point(10, 250);

                    
                }
                if (cmbMonedas.SelectedIndex == 2)//USD
                {
                    lblMXN.Visible = true;
                    lblUSD.Visible = false;
                    lblCAD.Visible = true;
                    lblEUR.Visible = true;
                    lblJPY.Visible = true;

                    txtMXN.Visible = true;
                    txtUSD.Visible = false;
                    txtCAD.Visible = true;
                    txtEUR.Visible = true;
                    txtJPY.Visible = true;

                    txtMXN.Location = new Point(230, 140);
                    txtCAD.Location = new Point(230, 175);
                    txtEUR.Location = new Point(230, 210);
                    txtJPY.Location = new Point(230, 245);

                    lblMXN.Location = new Point(10, 145);
                    lblCAD.Location = new Point(10, 180);
                    lblEUR.Location = new Point(10, 215);
                    lblJPY.Location = new Point(10, 250);
                }
                if (cmbMonedas.SelectedIndex == 3)//CAD
                {
                    lblMXN.Visible = true;
                    lblUSD.Visible = true;
                    lblCAD.Visible = false;
                    lblEUR.Visible = true;
                    lblJPY.Visible = true;

                    txtMXN.Visible = true;
                    txtUSD.Visible = true;
                    txtCAD.Visible = false;
                    txtEUR.Visible = true;
                    txtJPY.Visible = true;

                    txtMXN.Location = new Point(230, 140);
                    txtUSD.Location = new Point(230, 175);
                    txtEUR.Location = new Point(230, 210);
                    txtJPY.Location = new Point(230, 245);

                    lblMXN.Location = new Point(10, 145);
                    lblUSD.Location = new Point(10, 180);
                    lblEUR.Location = new Point(10, 215);
                    lblJPY.Location = new Point(10, 250);
                }
                if (cmbMonedas.SelectedIndex == 4)//EUR
                {
                    lblMXN.Visible = true;
                    lblUSD.Visible = true;
                    lblCAD.Visible = true;
                    lblEUR.Visible = false;
                    lblJPY.Visible = true;

                    txtMXN.Visible = true;
                    txtUSD.Visible = true;
                    txtCAD.Visible = true;
                    txtEUR.Visible = false;
                    txtJPY.Visible = true;

                    txtMXN.Location = new Point(230, 140);
                    txtUSD.Location = new Point(230, 175);
                    txtCAD.Location = new Point(230, 210);
                    txtJPY.Location = new Point(230, 245);

                    lblMXN.Location = new Point(10, 145);
                    lblUSD.Location = new Point(10, 180);
                    lblCAD.Location = new Point(10, 215);
                    lblJPY.Location = new Point(10, 250);
                }
                if (cmbMonedas.SelectedIndex == 5)//JPY
                {
                    lblMXN.Visible = true;
                    lblUSD.Visible = true;
                    lblCAD.Visible = true;
                    lblEUR.Visible = true;
                    lblJPY.Visible = false;

                    txtMXN.Visible = true;
                    txtUSD.Visible = true;
                    txtCAD.Visible = true;
                    txtEUR.Visible = true;
                    txtJPY.Visible = false;

                    txtMXN.Location = new Point(230, 140);
                    txtUSD.Location = new Point(230, 175);
                    txtCAD.Location = new Point(230, 210);
                    txtEUR.Location = new Point(230, 245);

                    lblMXN.Location = new Point(10, 145);
                    lblUSD.Location = new Point(10, 180);
                    lblCAD.Location = new Point(10, 215);
                    lblEUR.Location = new Point(10, 250);
                }
            }
            else
            {
                lblMXN.Visible = false;
                lblUSD.Visible = false;
                lblCAD.Visible = false;
                lblEUR.Visible = false;
                lblMXN.Visible = false;

                txtMXN.Visible = false;
                txtUSD.Visible = false;
                txtCAD.Visible = false;
                txtEUR.Visible = false;
                txtMXN.Visible = false;
            }
        }
    }
}