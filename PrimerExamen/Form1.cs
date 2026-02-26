namespace PrimerExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sueldo;
        double inferior;
        double cuota;
        double porcentaje;

        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                sueldo = double.Parse(txtSueldo.Text);

                if (sueldo <= 0)
                {
                    MessageBox.Show("El sueldo debe ser mayor a Cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(sueldo <= 746.04)
                    {
                        inferior = 0.01;
                        cuota = 0.00;
                        porcentaje = 1.92;
                    }else if(sueldo <= 6332.05)
                    {
                        inferior = 746.05;
                        cuota = 14.32;
                        porcentaje = 6.40;
                    }
                    else if(sueldo <= 11128.01)
                    {
                        inferior = 6332.06;
                        cuota = 371.83;
                        porcentaje = 10.88;
                    }
                    else if(sueldo <= 12935.82)
                    {
                        inferior = 1128.02;
                        cuota = 893.63;
                        porcentaje = 16.00;
                    }
                    else if(sueldo <= 15487.71)
                    {
                        inferior = 12935.83;
                        cuota = 1318.26;
                        porcentaje = 17.92;
                    }
                    else if(sueldo <= 31236.49)
                    {
                        inferior = 15487.72;
                        cuota = 1972.12;
                        porcentaje = 21.36;
                    }
                    else if(sueldo <= 49233.00)
                    {
                        inferior = 31236.50;
                        cuota = 5850.76;
                        porcentaje = 23.52;
                    }
                    else if(sueldo <= 93993.90)
                    {
                        inferior = 49233.01;
                        cuota = 10837.02;
                        porcentaje = 30.00;
                    }
                    else if(sueldo <= 125325.20)
                    {
                        inferior = 93993.91;
                        cuota = 26177.04;
                        porcentaje = 32.00;
                    }
                    else if(sueldo <= 375975.61)
                    {
                        inferior = 125325.21;
                        cuota = 38243.68;
                        porcentaje = 34.00;
                    }
                    else
                    {
                        inferior = 375975.62;
                        cuota = 142119.38;
                        porcentaje = 35.00;
                    }
                    double isr = cuota + (sueldo - inferior) * (porcentaje / 100);

                    txtExcedente.Text = (sueldo - inferior) + "";
                    txtIsr.Text = isr + "";
                    txtNeto.Text = (sueldo - isr) + "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un sueldo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
