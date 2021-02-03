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
	public partial class Devolucion : Form
	{
		RENTADEVOLUCION renta = new RENTADEVOLUCION();

		public Devolucion()
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

		public class RentaClass
		{
			public int IdRentaDevolucion { get; set; }
			public string EstadoVehiculo { get; set; }
			public string Vehiculo { get; set; }
			public string Cliente { get; set; }
			public string Empleado { get; set; }
			public string CantidadDias { get; set; }
			public string Comentarios { get; set; }
			public decimal MontoDia { get; set; }
			public decimal? MontoAtraso { get; set; }
			public DateTime Fecha { get; set; }
			public DateTime? FechaDevolucion { get; set; }
			public string Estado { get; set; }
		}

		private void ReFill()
		{
			//dataGridView1.AutoGenerateColumns = false;
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from renta in db.RENTADEVOLUCION
						  join vehiculo in db.Vehiculo
						  on renta.IdVehiculo equals vehiculo.IdVehiculo		
						  join cliente in db.CLIENTE
						  on renta.IdCliente equals cliente.IdCliente
						  join empleado in db.EMPLEADO
						  on renta.IdEmpleado equals empleado.IdEmpleado
						  join marca in db.MARCA
						  on vehiculo.IdMarca equals marca.IdMarca
						  join modelo in db.MODELO
						  on vehiculo.IdModelo equals modelo.IdModelo
						  where vehiculo.Estado == "R" && renta.Estado == "A"
						  select new RentaClass
						  {
							  IdRentaDevolucion = renta.IdRentaDevolucion,
							  EstadoVehiculo = vehiculo.Estado,
							  Vehiculo = marca.Despcricion + " " + modelo.Despcricion,
							  Cliente = cliente.Nombre,
							  Empleado = empleado.Nombre,
							  CantidadDias = renta.CantidadDias,
							  Comentarios = renta.Comentarios,
							  MontoDia = renta.MontoDia,
							  MontoAtraso = renta.MontoAtraso,
							  Fecha = renta.FechaRenta,
							  FechaDevolucion = renta.FechaDevolucon,
							  Estado = renta.Estado
						  };

				dataGridView1.DataSource = lst.ToList();
			}
		}

		private void Clear()
		{
			tbxComentarios.Text = "";
			tbxMontoAtraso.Text = "";
			tbxMontoDia.Text = "";
			tbxCantidadDias.Text = "";
			dtpFecha.Text = DateTime.Now.ToLongDateString();
			renta.IdRentaDevolucion = 0;
			cbVehiculo.Text = "";
			cbCliente.Text = "";
			cbEmpleado.Text = "";
			cbEstado.Text = "";
			dtpFechaDevolucion.Text = DateTime.Now.ToLongDateString();
			btnSave.Text = "Save";
			RefillComboEmpleado();
			RefillComboCliente();
			RefillComboVehiculo();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
			RefillComboEmpleado();
			RefillComboCliente();
			RefillComboVehiculo();
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

					if (cbVehiculo.Items.Count > 0)
						cbVehiculo.SelectedIndex = -1;

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
							  select cliente;

					cbCliente.DataSource = lst.ToList();
					cbCliente.DisplayMember = "Nombre";
					cbCliente.ValueMember = "IdCliente";

					if (cbCliente.Items.Count > 0)
						cbCliente.SelectedIndex = -1;

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
							  select empleado;

					cbEmpleado.DataSource = lst.ToList();
					cbEmpleado.DisplayMember = "Nombre";
					cbEmpleado.ValueMember = "IdEmpleado";

					if (cbEmpleado.Items.Count > 0)
						cbEmpleado.SelectedIndex = -1;

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void Devolucion_Load(object sender, EventArgs e)
		{
			tbxMontoDia.Enabled = false;
			tbxCantidadDias.Enabled = false;
			dtpFecha.Enabled = false;
			cbVehiculo.Enabled = false;
			cbCliente.Enabled = false;
			cbEmpleado.Enabled = false;
			cbEstado.Enabled = false;
			ReFill();
			RefillComboEmpleado();
			RefillComboCliente();
			RefillComboVehiculo();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				renta.MontoAtraso = decimal.Parse(tbxMontoAtraso.Text);
				renta.MontoDia = decimal.Parse(tbxMontoDia.Text);
				renta.Comentarios = tbxComentarios.Text;
				renta.FechaRenta = DateTime.Parse(dtpFecha.Text);
				renta.FechaDevolucon = DateTime.Parse(dtpFechaDevolucion.Text);
				renta.CantidadDias = tbxCantidadDias.Text;

				if (cbEstado.Text.Trim() == "Activo")
					renta.Estado = "A";
				else if (cbEstado.Text.Trim() == "Inactivo")
					renta.Estado = "I";

				if (tbxMontoAtraso.Text.Trim() == "" || tbxComentarios.Text.Trim() == "" || dtpFechaDevolucion.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introduzca todos los campos.");
				}
				else
				{
					renta.IdCliente = int.Parse(cbCliente.SelectedValue.ToString());
					renta.IdEmpleado = int.Parse(cbEmpleado.SelectedValue.ToString());
					renta.IdVehiculo = int.Parse(cbVehiculo.SelectedValue.ToString());

					using (RentCarEntities db = new RentCarEntities())
					{
						if (renta.IdRentaDevolucion == 0)
						{
							//db.RENTADEVOLUCION.Add(renta);
							//MessageBox.Show("Devolución Added!");
							//RefillComboVehiculo();
							//RefillComboCliente();
							//RefillComboEmpleado();
						}
						else
						{
							
							db.Entry(renta).State = EntityState.Modified;
							MessageBox.Show("Succesfully Confirmed");
						}

						db.SaveChanges();

					}
					Clear();
					ReFill();
					RefillComboVehiculo();
					RefillComboCliente();
					RefillComboEmpleado();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{

			renta.IdRentaDevolucion = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from renta in db.RENTADEVOLUCION
							  join vehiculo in db.Vehiculo
							  on renta.IdVehiculo equals vehiculo.IdVehiculo
							  join cliente in db.CLIENTE
							  on renta.IdCliente equals cliente.IdCliente
							  join empleado in db.EMPLEADO
							  on renta.IdEmpleado equals empleado.IdEmpleado
							  join marca in db.MARCA
							  on vehiculo.IdMarca equals marca.IdMarca
							  join modelo in db.MODELO
							  on vehiculo.IdModelo equals modelo.IdModelo
							  where vehiculo.Estado == "R"
							  select new RentaClass
							  {
								  IdRentaDevolucion = renta.IdRentaDevolucion,
								  EstadoVehiculo = vehiculo.Estado,
								  Vehiculo = marca.Despcricion + " " + modelo.Despcricion,
								  Cliente = cliente.Nombre,
								  Empleado = empleado.Nombre,
								  CantidadDias = renta.CantidadDias,
								  Comentarios = renta.Comentarios,
								  MontoDia = renta.MontoDia,
								  MontoAtraso = renta.MontoAtraso,
								  Fecha = renta.FechaRenta,
								  FechaDevolucion = renta.FechaDevolucon,
								  Estado = renta.Estado
							  };


					var descri = lst.Where(x => x.IdRentaDevolucion == renta.IdRentaDevolucion).FirstOrDefault();
					renta = db.RENTADEVOLUCION.Where(x => x.IdRentaDevolucion == renta.IdRentaDevolucion).FirstOrDefault();
					cbVehiculo.Text = descri.Vehiculo;
					cbEmpleado.Text = descri.Empleado;
					cbCliente.Text = descri.Cliente;
					tbxCantidadDias.Text = renta.CantidadDias;
					tbxMontoDia.Text = renta.MontoDia.ToString();
					dtpFecha.Text = renta.FechaRenta.ToString();
					dtpFechaDevolucion.Text = renta.FechaDevolucon.ToString();
					tbxComentarios.Text = renta.Comentarios;
					tbxMontoAtraso.Text = renta.MontoAtraso.ToString();

					if (renta.Estado == "A")
					{
						cbEstado.Text = "Activo";
					}
					else if (renta.Estado == "I")
					{
						cbEstado.Text = "Inactivo";
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

}

