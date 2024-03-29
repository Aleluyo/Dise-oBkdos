﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AdministracionOrgDatos
{
    public partial class frmRegistrarBecarios_ESA : Form
    {

        public frmRegistrarBecarios_ESA()
        {
            InitializeComponent();

            //Inicialiazcion de combo box de CCT
            cmbCCT.Items.Add("02DIT0021M ITT");
            cmbCCT.Items.Add("02PBH0079C UABC");
            cmbCCT.Items.Add("U602000    UNAM");
            cmbCCT.Items.Add("09PBH0056L ITESM");
            cmbCCT.Items.Add("19USU3353S UANL");
            cmbCCT.Items.Add("19USU3353S UANL");

            //Inicializacion de combo box del modelo 
            txtModelo.Items.Add("Semestre");
            txtModelo.Items.Add("Cuatrimestre");

            //Inicializacion de los estados de la republica
            txtEstadoNac.Items.Add("Aguascalientes");
            txtEstadoNac.Items.Add("Baja California");
            txtEstadoNac.Items.Add("Baja California Sur");
            txtEstadoNac.Items.Add("Campeche");
            txtEstadoNac.Items.Add("Chiapas");
            txtEstadoNac.Items.Add("Chihuahua");
            txtEstadoNac.Items.Add("Coahuila");
            txtEstadoNac.Items.Add("Colima");
            txtEstadoNac.Items.Add("Durango");
            txtEstadoNac.Items.Add("Estado de México");
            txtEstadoNac.Items.Add("Guanajuato");
            txtEstadoNac.Items.Add("Guerrero");
            txtEstadoNac.Items.Add("Hidalgo");
            txtEstadoNac.Items.Add("Jalisco");
            txtEstadoNac.Items.Add("Michoacán");
            txtEstadoNac.Items.Add("Morelos");
            txtEstadoNac.Items.Add("Nayarit");
            txtEstadoNac.Items.Add("Nuevo León");
            txtEstadoNac.Items.Add("Oaxaca");
            txtEstadoNac.Items.Add("Puebla");
            txtEstadoNac.Items.Add("Querétaro");
            txtEstadoNac.Items.Add("Quintana Roo");
            txtEstadoNac.Items.Add("San Luis Potosí");
            txtEstadoNac.Items.Add("Sinaloa");
            txtEstadoNac.Items.Add("Sonora");
            txtEstadoNac.Items.Add("Tabasco");
            txtEstadoNac.Items.Add("Tamaulipas");
            txtEstadoNac.Items.Add("Tlaxcala");
            txtEstadoNac.Items.Add("Veracruz ");
            txtEstadoNac.Items.Add("Yucatán");
            txtEstadoNac.Items.Add("Zacatecas");
            txtEstadoNac.Items.Add("CDMX");


            string aPaterno, aMaterno, nombres, fechanac, edad, curp, genero, estado_civil;
            string domicilio, codigo_postal, nacionalidad, estado_nacimiento, municipio, correo_electronico, telefono;
            string carrera, periodo, promedio, cct, modelo;
            int indicieNuevoRenglon;


            //Abrimos el archivo de texto en modo lectura
            FileStream becados = new FileStream("Becados.txt",FileMode.OpenOrCreate,FileAccess.Read);

            //Leemos linea por linea y cargamos esta misma en el datagridview
            using(StreamReader lector = new StreamReader(becados))
            {
                string renglon = lector.ReadLine();
                while (renglon != null)
                {
                    //Se usa el metodo split para leer los datos de manera individual
                    string[] datos = renglon.Split(',');

                    //Adicionamos nuevo renglon y regresamos su indice
                    indicieNuevoRenglon = dgv_Agregar.Rows.Add();

                    //Asignamos el valor a las variables
                    aPaterno = datos[0];
                    aMaterno = datos[1];
                    nombres = datos[2];
                    fechanac = datos[3];
                    edad = datos[4];
                    curp = datos[5];
                    genero = datos[6];
                    estado_civil = datos[7];
                    domicilio = datos[8];
                    codigo_postal = datos[9];
                    nacionalidad = datos[10];
                    estado_nacimiento = datos[11];
                    municipio = datos[12];
                    correo_electronico = datos[13];
                    telefono = datos[14];
                    carrera = datos[15];
                    periodo = datos[16];
                    promedio = datos[17];
                    cct = datos[18];
                    modelo = datos[19];


                    //Colocamos la informacion en el datagridview
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[0].Value = aPaterno;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[1].Value = aMaterno;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[2].Value = nombres;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[3].Value = fechanac;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[4].Value = edad;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[5].Value = curp;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[6].Value = genero;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[7].Value = estado_civil;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[8].Value = domicilio;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[9].Value = codigo_postal;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[10].Value = nacionalidad;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[11].Value = estado_nacimiento;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[12].Value = municipio;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[13].Value = correo_electronico;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[14].Value = telefono;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[15].Value = carrera;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[16].Value = periodo;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[17].Value = promedio;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[18].Value = cct;
                    dgv_Agregar.Rows[indicieNuevoRenglon].Cells[19].Value = modelo;


                    renglon = lector.ReadLine();
                }
            }
            becados.Close();
        }

        private void btnRegresarMenu_ESA_Click(object sender, EventArgs e)
        {
            //Guarda los datos y regresa a la pantalla anterior
            Guardar();
            Form objMenu_ESA = new frmMenu_ESA();
            objMenu_ESA.Show();
            this.Hide();

        }

        private bool camposImcompletos()
        {
            return txtApaterno.Text == "" || txtAmaterno.Text == "" || txtNombres.Text == "" || txtFechanac.Text == ""
               || txtEdad.Text == "" || txtCURP.Text == "" || CBGenero.Text == "" || txtEstadoCivil.Text == "" || txtDomicilio.Text == ""
               || txtCodigoPostal.Text == "" || txtNacionalidad.Text == "" || txtEstadoNac.Text == "" || txtMunicipio.Text == "" || txtCorreoElectronico.Text == ""
               || txtTelefono.Text == "" || txtCarrera.Text == "" || txtPeriodo.Text == "" || txtPromedio.Text == "" || cmbCCT.Text == "" || txtModelo.Text == "";
        }

        private void camposLimpieza()
        {
            txtApaterno.Text = "";
            txtAmaterno.Text = "";
            txtNombres.Text = "";
            txtFechanac.Text = "";
            txtEdad.Text = "";
            txtCURP.Text = "";
            CBGenero.Text = "";
            txtEstadoCivil.Text = "";
            txtDomicilio.Text = "";
            txtCodigoPostal.Text = "";
            txtNacionalidad.Text = "";
            txtEstadoNac.Text = "";
            txtMunicipio.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtCarrera.Text = "";
            txtPeriodo.Text = "";
            txtPromedio.Text = "";
            cmbCCT.Text = "";
            txtModelo.Text = "";
        }

        private void btnAgregar_ESA_Click(object sender, EventArgs e)
        {
            if(camposImcompletos())
            {
                MessageBox.Show("Favor de no olvidar todos los datos en casa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApaterno.Focus();
            }
            else
            {
                int indiceNuevaFila;

                //Sirve para adicionar un nuevo renglon y guardar el indice de este mismo
                indiceNuevaFila = dgv_Agregar.Rows.Add();

                //Colocamos la informacion en el DataGridView
                dgv_Agregar.Rows[indiceNuevaFila].Cells[0].Value = txtApaterno.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[1].Value = txtAmaterno.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[2].Value = txtNombres.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[3].Value = txtFechanac.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[4].Value = txtEdad.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[5].Value = txtCURP.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[6].Value = CBGenero.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[7].Value = txtEstadoCivil.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[8].Value = txtDomicilio.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[9].Value = txtCodigoPostal.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[10].Value = txtNacionalidad.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[11].Value = txtEstadoNac.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[12].Value = txtMunicipio.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[13].Value = txtCorreoElectronico.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[14].Value = txtTelefono.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[15].Value = txtCarrera.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[16].Value = txtPeriodo.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[17].Value = txtPromedio.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[18].Value = cmbCCT.Text;
                dgv_Agregar.Rows[indiceNuevaFila].Cells[19].Value = txtModelo.Text;

                camposLimpieza();

                //Regresar el "cursor" al label del nombre
                txtApaterno.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Verificamos si hay una celda seleccionada
            if (this.dgv_Agregar.SelectedRows.Count == 1)
            {
                //Se cargan los datos actuales en los textbox en el datagridview para actualizar sus valores
                int seleccion = dgv_Agregar.CurrentRow.Index;
                dgv_Agregar.Rows[seleccion].Cells[0].Value = txtApaterno.Text;
                dgv_Agregar.Rows[seleccion].Cells[1].Value = txtAmaterno.Text;
                dgv_Agregar.Rows[seleccion].Cells[2].Value = txtNombres.Text;
                dgv_Agregar.Rows[seleccion].Cells[3].Value = txtFechanac.Text;
                dgv_Agregar.Rows[seleccion].Cells[4].Value = txtEdad.Text;
                dgv_Agregar.Rows[seleccion].Cells[5].Value = txtCURP.Text;
                dgv_Agregar.Rows[seleccion].Cells[6].Value = CBGenero.Text;
                dgv_Agregar.Rows[seleccion].Cells[7].Value = txtEstadoCivil.Text;
                dgv_Agregar.Rows[seleccion].Cells[8].Value = txtDomicilio.Text;
                dgv_Agregar.Rows[seleccion].Cells[9].Value = txtCodigoPostal.Text;
                dgv_Agregar.Rows[seleccion].Cells[10].Value = txtNacionalidad.Text;
                dgv_Agregar.Rows[seleccion].Cells[11].Value = txtEstadoNac.Text;
                dgv_Agregar.Rows[seleccion].Cells[12].Value = txtMunicipio.Text;
                dgv_Agregar.Rows[seleccion].Cells[13].Value = txtCorreoElectronico.Text;
                dgv_Agregar.Rows[seleccion].Cells[14].Value = txtTelefono.Text;
                dgv_Agregar.Rows[seleccion].Cells[15].Value = txtCarrera.Text;
                dgv_Agregar.Rows[seleccion].Cells[16].Value = txtPeriodo.Text;
                dgv_Agregar.Rows[seleccion].Cells[17].Value = txtPromedio.Text;
                dgv_Agregar.Rows[seleccion].Cells[18].Value = cmbCCT.Text;
                dgv_Agregar.Rows[seleccion].Cells[19].Value = txtModelo.Text;

                camposLimpieza();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verificamos si hay una fila seleccionada
            if(dgv_Agregar.CurrentRow.Index > -1)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar esta fila permanentemente? Permanentemente es mucho tiempo.", 
                    "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                //Usuario confirma eliminacion
                if(confirmacion == DialogResult.Yes)
                {
                    dgv_Agregar.Rows.RemoveAt(dgv_Agregar.CurrentRow.Index);
                }
            }
        }

        private void dgv_Agregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificamos si hay una celda seleccionada
            if(this.dgv_Agregar.SelectedRows.Count == 1)
            {
                //Definimos el indice de la fila
                int seleccion = dgv_Agregar.CurrentRow.Index;

                //Cargamos los textbox con los datos de la fila seleccionada en sus celdas correspondientes
                txtApaterno.Text = dgv_Agregar.Rows[seleccion].Cells[0].Value.ToString();
                txtAmaterno.Text = dgv_Agregar.Rows[seleccion].Cells[1].Value.ToString();
                txtNombres.Text = dgv_Agregar.Rows[seleccion].Cells[2].Value.ToString();
                txtFechanac.Text = dgv_Agregar.Rows[seleccion].Cells[3].Value.ToString();
                txtEdad.Text = dgv_Agregar.Rows[seleccion].Cells[4].Value.ToString();
                txtCURP.Text = dgv_Agregar.Rows[seleccion].Cells[5].Value.ToString();
                CBGenero.Text = dgv_Agregar.Rows[seleccion].Cells[6].Value.ToString();
                txtEstadoCivil.Text = dgv_Agregar.Rows[seleccion].Cells[7].Value.ToString();
                txtDomicilio.Text = dgv_Agregar.Rows[seleccion].Cells[8].Value.ToString();
                txtCodigoPostal.Text = dgv_Agregar.Rows[seleccion].Cells[9].Value.ToString();
                txtNacionalidad.Text = dgv_Agregar.Rows[seleccion].Cells[10].Value.ToString();
                txtEstadoNac.Text = dgv_Agregar.Rows[seleccion].Cells[11].Value.ToString();
                txtMunicipio.Text = dgv_Agregar.Rows[seleccion].Cells[12].Value.ToString();
                txtCorreoElectronico.Text = dgv_Agregar.Rows[seleccion].Cells[13].Value.ToString();
                txtTelefono.Text = dgv_Agregar.Rows[seleccion].Cells[14].Value.ToString();
                txtCarrera.Text = dgv_Agregar.Rows[seleccion].Cells[15].Value.ToString();
                txtPeriodo.Text = dgv_Agregar.Rows[seleccion].Cells[16].Value.ToString();
                txtPromedio.Text = dgv_Agregar.Rows[seleccion].Cells[17].Value.ToString();
                cmbCCT.Text = dgv_Agregar.Rows[seleccion].Cells[18].Value.ToString();
                txtModelo.Text = dgv_Agregar.Rows[seleccion].Cells[19].Value.ToString();
            }
        }

        private void Guardar()
        {
            ///Se guardan los datos de los becados en el archivo txt
            ///Se tiene que sobreescribir ya que si es que se eliminan datos
            ///los indices estarian mal para las siguientes veces que se desplegara el programa
            FileStream becados = new FileStream("Becados.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(becados))
            {
                //Se recorren todas las filas del datagridview
                foreach(DataGridViewRow row in dgv_Agregar.Rows)
                {
                    writer.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value}," +
                        $"{row.Cells[4].Value},{row.Cells[5].Value},{row.Cells[6].Value},{row.Cells[7].Value}," +
                        $"{row.Cells[8].Value},{row.Cells[9].Value},{row.Cells[10].Value},{row.Cells[11].Value}," +
                        $"{row.Cells[12].Value},{row.Cells[13].Value},{row.Cells[14].Value},{row.Cells[15].Value}," +
                        $"{row.Cells[16].Value},{row.Cells[17].Value},{row.Cells[18].Value},{row.Cells[19].Value}");

                }
            }
            //Se terminan de guardar los datos y se cierra el archivo
            becados.Close();    
        }

        //Aqui estan las propiedades para agregar la fecha y la hora al programa
        private void FechaHora2_Tick(object sender, EventArgs e)
        {
            HoraC.Text = DateTime.Now.ToShortTimeString();
            FechaC.Text = DateTime.Now.ToShortDateString();
        }

        private void frmRegistrarBecarios_ESA_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Agregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_Estado_ESA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NO SUPE IMPLEMENTAR LA PARTE DE QUE SI PONES X UNI TE SALE SEMESTRAL
            //Y SI PONES OTRA UNI IMPRIME CUATRIMESTRAL, REVISAR PORFAVOR
            if (cmbCCT.Text == "TEC" && cmbCCT.Text == "UABC")
                txtModelo.Text = "Semestral".ToString();
            else if (cmbCCT.Text == "CETIS" && cmbCCT.Text == "UVM" && cmbCCT.Text == "ZOCHICALCO")
                txtModelo.Text = "Cuatrimestral".ToString();

        }

        private void txtModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
