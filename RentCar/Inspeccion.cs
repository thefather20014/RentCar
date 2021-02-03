using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models;

namespace RentCar
{
	public partial class Inspeccion : Form
	{
		INSPECCION inspeccion = new INSPECCION();

		public Inspeccion()
		{
			InitializeComponent();
			LoadTheme();
		}

		private void LoadTheme()
		{
			foreach (Control btns in this.Controls)
			{
				if (btns.GetType() == typeof(Button))
				{
					Button btn = (Button)btns;
					btn.BackColor = ThemeColor.PrimaryColor;
					btn.ForeColor = Color.White;
					btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
				}
			}
		}

		private void Clear()
		{
			rbRalladurasSi.Checked = rbRalladurasNo.Checked = rbGomaSi.Checked = rbGomaNo.Checked = rbGatoSi.Checked = rbGatoNo.Checked = rbCristalSi.Checked =
				rbCristalNo.Checked = rbNeumatico1B.Checked = rbNeumatico1M.Checked = rbNeumatico2B.Checked = rbNeumatico2M.Checked =
				rbNeumatico3B.Checked = rbNeumatico3M.Checked = rbNeumatico4B.Checked = rbNeumatico4M.Checked = false;
			dtpFecha.Text = DateTime.Now.ToLongDateString();
			inspeccion.IdInspeccion = 0;
			cbVehiculo.Text = "";
			cbCliente.Text = "";
			cbEmpleado.Text = "";
			cbEstado.Text = "";
			cbCantidadC.Text = "";
			btnSave.Text = "Save";
		}

		public class InspeccionClass
		{
			public int IdInspeccion { get; set; }
			public string Vehiculo { get; set; }
			public string Cliente { get; set; }
			public string Empleado { get; set; }
			public string Ralladuras { get; set; }
			public string CantidadCombustible { get; set; }
			public string GomaRepuesto { get; set; }
			public string Gato { get; set; }
			public string RoturaCristal { get; set; }
			public string Neumatico1 { get; set; }
			public string Neumatico2 { get; set; }
			public string Neumatico3 { get; set; }
			public string Neumatico4 { get; set; }
			public DateTime Fecha { get; set; }
			public string Estado { get; set; }
		}

		private void ReFill()
		{
			//dataGridView1.AutoGenerateColumns = false;
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from inspeccion in db.INSPECCION
						  join vehiculo in db.Vehiculo
						  on inspeccion.IdVehiculo equals vehiculo.IdVehiculo
						  join cliente in db.CLIENTE
						  on inspeccion.IdCliente equals cliente.IdCliente
						  join empleado in db.EMPLEADO
						  on inspeccion.IdEmpleado equals empleado.IdEmpleado
						  join marca in db.MARCA
						  on vehiculo.IdMarca equals marca.IdMarca
						  join modelo in db.MODELO
						  on vehiculo.IdModelo equals modelo.IdModelo
						  select new InspeccionClass
						  {
							  IdInspeccion = inspeccion.IdInspeccion,
							  Vehiculo = marca.Despcricion + " " + modelo.Despcricion,
							  Cliente = cliente.Nombre,
							  Empleado = empleado.Nombre,
							  Ralladuras = inspeccion.Ralladuras,
							  CantidadCombustible = inspeccion.CantidadCombustible,
							  GomaRepuesto = inspeccion.GomaRepuesto,
							  Gato = inspeccion.Gato,
							  RoturaCristal = inspeccion.RoturaCristal,
							  Neumatico1 = inspeccion.EstadoNeumatico1,
							  Neumatico2 = inspeccion.EstadoNeumatico2,
							  Neumatico3 = inspeccion.EstadoNeumatico3,
							  Neumatico4 = inspeccion.EstadoNeumatico4,
							  Fecha = inspeccion.Fecha,
							  Estado = inspeccion.Estado
						  };

				dataGridView1.DataSource = lst.ToList();
			}
		}

		public class VehiculoModel
		{
			public int IdVehiculo { get; set; }
			public string Descripcion { get; set; }
		}

		private void RefillComboVehiculo()
		{

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from vehiculo in db.Vehiculo
							  where vehiculo.Estado == "D"
							  join marca in db.MARCA
							  on vehiculo.IdMarca equals marca.IdMarca
							  join modelo in db.MODELO
							  on vehiculo.IdModelo equals modelo.IdModelo
							  select new VehiculoModel
							  {
								  IdVehiculo = vehiculo.IdVehiculo,
								  Descripcion = marca.Despcricion + " " + modelo.Despcricion
							  };

					cbVehiculo.DataSource = lst.ToList();
					cbVehiculo.DisplayMember = "Descripcion";
					cbVehiculo.ValueMember = "IdVehiculo";

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void RefillComboCliente()
		{

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from cliente in db.CLIENTE
							  where cliente.Estado == "A"
							  select cliente;

					cbCliente.DataSource = lst.ToList();
					cbCliente.DisplayMember = "Nombre";
					cbCliente.ValueMember = "IdCliente";

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void RefillComboEmpleado()
		{

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from empleado in db.EMPLEADO
							  where empleado.Estado == "A"
							  select empleado;

					cbEmpleado.DataSource = lst.ToList();
					cbEmpleado.DisplayMember = "Nombre";
					cbEmpleado.ValueMember = "IdEmpleado";

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void Inspeccion_Load(object sender, EventArgs e)
		{
			ReFill();
			RefillComboVehiculo();
			RefillComboCliente();
			RefillComboEmpleado();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				//Ralladuras
				if (rbRalladurasSi.Checked)
					inspeccion.Ralladuras = "S";
				else if (rbRalladurasNo.Checked)
					inspeccion.Ralladuras = "N";
				//Goma de Respuesto
				if (rbGomaSi.Checked)
					inspeccion.GomaRepuesto = "S";
				else if (rbGomaNo.Checked)
					inspeccion.GomaRepuesto = "N";
				// Gato
				if (rbGatoSi.Checked)
					inspeccion.Gato = "S";
				else if (rbGatoNo.Checked)
					inspeccion.Gato = "N";
				// Cristal Roto
				if (rbCristalSi.Checked)
					inspeccion.RoturaCristal = "S";
				else if (rbCristalNo.Checked)
					inspeccion.RoturaCristal = "N";
				// Neumatico 1
				if (rbNeumatico1B.Checked)
					inspeccion.EstadoNeumatico1 = "B";
				else if (rbNeumatico1M.Checked)
					inspeccion.EstadoNeumatico1 = "M";
				//Neumatico 2
				if (rbNeumatico2B.Checked)
					inspeccion.EstadoNeumatico2 = "B";
				else if (rbNeumatico2M.Checked)
					inspeccion.EstadoNeumatico2 = "M";
				//Neumatico 3
				if (rbNeumatico3B.Checked)
					inspeccion.EstadoNeumatico3 = "B";
				else if (rbNeumatico3M.Checked)
					inspeccion.EstadoNeumatico3 = "M";
				//Neumatico 4
				if (rbNeumatico4B.Checked)
					inspeccion.EstadoNeumatico4 = "B";
				else if (rbNeumatico4M.Checked)
					inspeccion.EstadoNeumatico4 = "M";
				//Estado
				if (cbEstado.Text.Trim() == "Activo")
					inspeccion.Estado = "A";
				else if (cbEstado.Text.Trim() == "Inactivo")
					inspeccion.Estado = "I";

				inspeccion.CantidadCombustible = cbCantidadC.Text;
				inspeccion.Fecha = DateTime.Parse(dtpFecha.Text);

				if ((rbRalladurasSi.Checked == false && rbRalladurasNo.Checked == false) || (rbGomaSi.Checked == false && rbGomaNo.Checked == false)
					|| (rbCristalSi.Checked == false && rbCristalNo.Checked == false) || (rbNeumatico1B.Checked == false && rbNeumatico1M.Checked == false)
					|| (rbNeumatico2B.Checked == false && rbNeumatico2M.Checked == false) || (rbNeumatico3B.Checked == false && rbNeumatico3M.Checked == false)
					|| (rbNeumatico4B.Checked == false && rbNeumatico4M.Checked == false) || dtpFecha.Text.Trim() == "" || cbVehiculo.Text.Trim() == "" || cbEmpleado.Text.Trim() == ""
					|| cbCliente.Text.Trim() == "" || cbEstado.Text.Trim() == "" || cbCantidadC.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introduzca todos los campos.");
				}
				else
				{
					inspeccion.IdVehiculo = int.Parse(cbVehiculo.SelectedValue.ToString());
					inspeccion.IdCliente = int.Parse(cbCliente.SelectedValue.ToString());
					inspeccion.IdEmpleado = int.Parse(cbEmpleado.SelectedValue.ToString());

					using (RentCarEntities db = new RentCarEntities())
					{
						if (inspeccion.IdInspeccion == 0)
						{
							db.INSPECCION.Add(inspeccion);
							MessageBox.Show("Marca Added!");
						}
						else
						{
							db.Entry(inspeccion).State = EntityState.Modified;
							MessageBox.Show("Marca Updated!");
							btnSave.Text = "Save";
						}

						db.SaveChanges();

					}
					Clear();
					ReFill();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				inspeccion.IdInspeccion = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from inspeccion in db.INSPECCION
							  join vehiculo in db.Vehiculo
							  on inspeccion.IdVehiculo equals vehiculo.IdVehiculo
							  join cliente in db.CLIENTE
							  on inspeccion.IdCliente equals cliente.IdCliente
							  join empleado in db.EMPLEADO
							  on inspeccion.IdEmpleado equals empleado.IdEmpleado
							  join marca in db.MARCA
							  on vehiculo.IdMarca equals marca.IdMarca
							  join modelo in db.MODELO
							  on vehiculo.IdModelo equals modelo.IdModelo
							  select new InspeccionClass
							  {
								  IdInspeccion = inspeccion.IdInspeccion,
								  Vehiculo = marca.Despcricion + " " + modelo.Despcricion,
								  Cliente = cliente.Nombre,
								  Empleado = empleado.Nombre,
								  Ralladuras = inspeccion.Ralladuras,
								  CantidadCombustible = inspeccion.CantidadCombustible,
								  GomaRepuesto = inspeccion.GomaRepuesto,
								  Gato = inspeccion.Gato,
								  RoturaCristal = inspeccion.RoturaCristal,
								  Neumatico1 = inspeccion.EstadoNeumatico1,
								  Neumatico2 = inspeccion.EstadoNeumatico2,
								  Neumatico3 = inspeccion.EstadoNeumatico3,
								  Neumatico4 = inspeccion.EstadoNeumatico4,
								  Fecha = inspeccion.Fecha,
								  Estado = inspeccion.Estado
							  };

					dataGridView1.DataSource = lst.ToList();

					var descri = lst.Where(x => x.IdInspeccion == inspeccion.IdInspeccion).FirstOrDefault();
					inspeccion = db.INSPECCION.Where(x => x.IdInspeccion == inspeccion.IdInspeccion).FirstOrDefault();

					cbVehiculo.Text = descri.Vehiculo;
					cbEmpleado.Text = descri.Empleado;
					cbCliente.Text = descri.Cliente;
					cbCantidadC.Text = inspeccion.CantidadCombustible;

					//Ralladuras
					if (inspeccion.Ralladuras == "S")
						rbRalladurasSi.Checked = true;
					else if (inspeccion.Ralladuras == "N")
						rbRalladurasNo.Checked = true;
					//Goma de Respuesto
					if (inspeccion.GomaRepuesto == "S")
						rbGomaSi.Checked = true;
					else if (inspeccion.GomaRepuesto == "N")
						rbGomaNo.Checked = true;
					// Gato
					if (inspeccion.Gato == "S")
						rbGatoSi.Checked = true;
					else if (inspeccion.Gato == "N")
						rbGatoNo.Checked = true;
					// Cristal Roto
					if (inspeccion.RoturaCristal == "S")
						rbCristalSi.Checked = true;
					else if (inspeccion.RoturaCristal == "N")
						rbCristalNo.Checked = true;
					// Neumatico 1
					if (inspeccion.EstadoNeumatico1 == "B")
						rbNeumatico1B.Checked = true;
					else if (inspeccion.EstadoNeumatico1 == "M")
						rbNeumatico1M.Checked = true;
					// Neumatico 2
					if (inspeccion.EstadoNeumatico2 == "B")
						rbNeumatico2B.Checked = true;
					else if (inspeccion.EstadoNeumatico2 == "M")
						rbNeumatico2M.Checked = true;
					// Neumatico 3
					if (inspeccion.EstadoNeumatico3 == "B")
						rbNeumatico3B.Checked = true;
					else if (inspeccion.EstadoNeumatico3 == "M")
						rbNeumatico3M.Checked = true;
					// Neumatico 4
					if (inspeccion.EstadoNeumatico4 == "B")
						rbNeumatico4B.Checked = true;
					else if (inspeccion.EstadoNeumatico4 == "M")
						rbNeumatico4M.Checked = true;
					//Estado
					if (inspeccion.Estado == "A")
						cbEstado.Text = "Activo";
					else if (inspeccion.Estado == "I")
						cbEstado.Text = "Inactivo";

					dtpFecha.Text = inspeccion.Fecha.ToString();
				}

				btnSave.Text = "Update";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Estás seguro que quieres eliminar el registro?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				inspeccion.IdInspeccion = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					inspeccion = db.INSPECCION.Where(x => x.IdInspeccion == inspeccion.IdInspeccion).FirstOrDefault();
					db.INSPECCION.Remove(inspeccion);
					db.SaveChanges();
					Clear();
					ReFill();
					MessageBox.Show("Deleted Successfully!");
				}
			}
		}
	}
}
	

