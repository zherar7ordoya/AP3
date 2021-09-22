using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Integrador_1
{
    public partial class Form1 : Form
    {
        Concesionario _c;
        VistaAuto _va;
        public Form1()
        {
            InitializeComponent();
            _c = new Concesionario();
            _va = new VistaAuto();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
            dataGridView3.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RefrescaGrilla(dataGridView1, _c.RetornaListaPersonas());
            RefrescaGrilla(dataGridView2, _c.RetornaListaAutos());
            RefrescaGrilla(dataGridView3, _c.RetornaListaAutos());
        }

        void RefrescaGrilla(DataGridView pDGV, object pObject)
        {
            pDGV.DataSource = null;pDGV.DataSource = pObject;
        }
        //todo ABM Autos
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               //todo validar DNI
                string _auxdni = Interaction.InputBox("DNI: ");
                _c.AgregarPersona(new Persona(_auxdni, Interaction.InputBox("Nombre: "), Interaction.InputBox("Apellido: ")));
                RefrescaGrilla(dataGridView1,_c.RetornaListaPersonas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
               // Verifica que haya datods para borrar
                if(dataGridView1.Rows.Count>0)
                {
                    // Se le pasa a BorrarPpersona del concesionario La persona seleccionado en el grilla 1
                    _c.BorrarPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
                    RefrescaGrilla(dataGridView1,_c.RetornaListaPersonas());
                }
               else
                { throw new Exception("No hay nada que borrar !!!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                // Verifica si hay algo para modificar
                if(dataGridView1.Rows.Count>0)
                {
                    // Obtiene la persona seleccionada en la grilla 1
                    Persona _auxPersona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                    // Si la persona en distinta de nulo se procede a la modificación
                    if(_auxPersona!=null)
                    {
                        // Se modifica el nombre
                        _auxPersona.Nombre = Interaction.InputBox("Nombre: ","Modificando Persona ...", _auxPersona.Nombre);
                        // Se modifica el apellido
                        _auxPersona.Apellido = Interaction.InputBox("Apellido: ", "Modificando Persona ...", _auxPersona.Apellido);
                        // Se envía a ModificarPersona del concesionario la persona seleccionada en la grilla 
                        // con el estado actualizado
                        _c.ModificarPersona(_auxPersona);
                        RefrescaGrilla(dataGridView1,_c.RetornaListaPersonas());
                        // Opción con LinQ
                        // RefrescaGrilla(dataGridView4, _va.VistaAutos(_c.RetornaListaAutos());

                        // Opción con Clase Vista
                        RefrescaGrilla(dataGridView4, _va.RetornaVistaAuto(_c.RetornaListaAutos()));
                    }
                    else { throw new Exception("La persona que intenta modificar en null"); }
                }
                else { throw new Exception("No existe persona para modificar !!!"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //todo validar PATENTE
                string _auxpatente = Interaction.InputBox("Patente: ");
                _c.AgregarAuto(new Auto(_auxpatente, Interaction.InputBox("Marca: "), Interaction.InputBox("Modelo: "), Interaction.InputBox("Año: "),decimal.Parse(Interaction.InputBox("Precio: "))));
                RefrescaGrilla(dataGridView2, _c.RetornaListaAutos());
                // Opción con LinQ
                // RefrescaGrilla(dataGridView4, _va.VistaAutos(_c.RetornaListaAutos());

                // Opción con Clase Vista
                RefrescaGrilla(dataGridView4, _va.RetornaVistaAuto(_c.RetornaListaAutos()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Se controla que el la grilla 2 haya algo para borrar
                if (dataGridView2.Rows.Count > 0)
                {

                    // Se envía el Auto seleccionado en la grilla 2 a BorrarAuto del concesionario
                    _c.BorrarAuto(dataGridView2.SelectedRows[0].DataBoundItem as Auto);
                    RefrescaGrilla(dataGridView2, _c.RetornaListaAutos());
                    // Opción con LinQ
                    // RefrescaGrilla(dataGridView4, _va.VistaAutos(_c.RetornaListaAutos()));

                    // Opción con Clase Vista
                    RefrescaGrilla(dataGridView4, _va.RetornaVistaAuto(_c.RetornaListaAutos()));
                }
                else
                { throw new Exception("No hay nada que borrar !!!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay algún auto que modificar en la grilla 2
                if (dataGridView2.Rows.Count > 0)
                {
                    // Se obtiene el auto seleccionado en la grilla 2
                    Auto _auxAuto = dataGridView2.SelectedRows[0].DataBoundItem as Auto;
                    if (_auxAuto != null)
                    {
                       // Se actualiza el estado del auto
                        _auxAuto.Marca = Interaction.InputBox("Marca: ", "Modificando Auto ...", _auxAuto.Marca);
                        _auxAuto.Modelo = Interaction.InputBox("Modelo: ", "Modificando Auto ...", _auxAuto.Modelo);
                        _auxAuto.Axo = Interaction.InputBox("Año: ", "Modificando Auto ...", _auxAuto.Axo);
                        _auxAuto.Precio = decimal.Parse(Interaction.InputBox("Precio: ", "Modificando Auto ...", _auxAuto.Precio.ToString()));
                        // Se llama a ModificarAuto del concesionario
                        _c.ModificarAuto(_auxAuto);
                        RefrescaGrilla(dataGridView2, _c.RetornaListaAutos());
                        RefrescaGrilla(dataGridView3, _c.AutosDeUnaPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona));

                        // Opción con LinQ
                        // RefrescaGrilla(dataGridView4, _va.VistaAutos(_c.RetornaListaAutos());

                        // Opción con Clase Vista
                        RefrescaGrilla(dataGridView4, _va.RetornaVistaAuto(_c.RetornaListaAutos()));
                        ActualizaPrecioTotal();
                    }
                    else { throw new Exception("El auto que intenta modificar en null"); }
                }
                else { throw new Exception("No existe auto para modificar !!!"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                // Se envía a Asignar auto del concesionario la Persona seleccionada en la grilla 1
                // y el auto seleccionado en la grilla 2
                _c.AsignarAuto(dataGridView1.SelectedRows[0].DataBoundItem as Persona, dataGridView2.SelectedRows[0].DataBoundItem as Auto);
                RefrescaGrilla(dataGridView3, _c.AutosDeUnaPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona));
               
                // Opción con LinQ
                 RefrescaGrilla(dataGridView4, _va.VistaAutos(_c.RetornaListaAutos()));
                
                // Opción con Clase Vista
               // RefrescaGrilla(dataGridView4,_va.RetornaVistaAuto(_c.RetornaListaAutos()));

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                RefrescaGrilla(dataGridView3, _c.AutosDeUnaPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona));
                ActualizaPrecioTotal();
                
            }
            catch (Exception) { }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                // Se envia a QuitarAutoAsignado del concesionario:
                // 1. La persona seleccionada en la grilla 1 (Esto también se puede ubicar tomando el auto
                // seleccionado en la grilla 3 y consultandole por su dueño). 
                // 2. El auto seleccionado en la grilla 3.
                _c.QuitarAutoAsignado(dataGridView1.SelectedRows[0].DataBoundItem as Persona, dataGridView3.SelectedRows[0].DataBoundItem as Auto);
                RefrescaGrilla(dataGridView3, _c.AutosDeUnaPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona));

                // Opción con LinQ
                // RefrescaGrilla(dataGridView4, _va.VistaAutos(_c.RetornaListaAutos());

                // Opción con Clase Vista
                RefrescaGrilla(dataGridView4, _va.RetornaVistaAuto(_c.RetornaListaAutos()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void ActualizaPrecioTotal()
        {
            decimal _total = 0;
            List<Auto> _la = _c.AutosDeUnaPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
            if (_la.Count > 0)
            {
                foreach (Auto _a in _la)
                {
                    _total += _a.Precio;
                }
            }
            label1.Text = _total.ToString();
        }

        private void dataGridView3_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ActualizaPrecioTotal();
        }
    }
}
