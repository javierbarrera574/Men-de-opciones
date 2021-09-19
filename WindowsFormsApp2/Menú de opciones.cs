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
    public partial class Menú : Form //Menú es el objeto de la clase Form
    {
       


        public Menú()
        {
            InitializeComponent();
        }

        private void Menú_Load(object sender, EventArgs e)
        {
            
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
            //MENU DE OPCIONES

            lblResultado.Visible = true;

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
                case 5:
                    txtOpcion.Text = "5: avion";
                    lblResultado.Text = "Elegiste viajar en avion";
                    break;
                case 6:
                    txtOpcion.Text = "6: bicicleta";
                    lblResultado.Text = "Elegiste viajar en bicicleta";
                    break;
            }
        }

        private void btLlamar_Click(object sender, EventArgs e)
        {

            /*ESTE BOTON TENDRIA QUE LLAMAR A OTRO FORMULARIO PARA DARME MAS OPCIONES 
             * DENTRO DE LAS OPCIONES PRINCIPALES, UNA VEZ QUE YO ELIJA UNA
             * ME DESPLEGA OTRO FORMULARIO CON SUBOPCIONES
             */

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
       
    }
    
 





