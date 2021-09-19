using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int opcion = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void txtOpcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEleccion_Click(object sender, EventArgs e)
        {
            this.Close();//usar esto para depurar el codigo de la calculadora
        }



        private void btEleccion_Click_1(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MENU DE OPCIONES


            int opciones = 0;

            switch (opciones)
            {
                case 1:
                    txtOpcion.Text = "1: automovil";
                    lblResultado.Text = "Elegiste viajar automovil";
                    break;
                case 2:
                    txtOpcion.Text = "2: tren";
                    lblResultado.Text = "Elegiste viajar en tren";
                    break;
                case 3:
                    txtOpcion.Text = "3: helicoptero";
                    lblResultado.Text = "Elegiste viajar en helicoptero";
                    break;
                case 4:
                    txtOpcion.Text = "4: cohete";
                    lblResultado.Text = "Elegiste viajar en cohete";
                    break;
            }
        }
        private void Suma()
        {
            int num1  =0;
            int num2 =0;
            txtOpcion.Text = ($"El resultado es {num1 + num2}");

            

        }
    }
    
 

}



