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
	public partial class Renta : Form
	{
		RENTADEVOLUCION renta = new RENTADEVOLUCION();

		public Renta()
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
			tbxMontoDia.Text = "";
			tbxCantidadDias.Text = "";
			porCliente.Text = "";
			porVehiculo.Text = "";
			porFecha.Text = DateTime.Now.ToShortDateString();
			dtpFecha.Text = DateTime.Now.ToLongDateString();
			renta.IdRentaDevolucion = 0;
			cbVehiculo.Text = "";
			cbCliente.Text = "";
			cbEmpleado.Text = "";
			cbEstado.Text = "";
			btnSave.Text = "Save";
		}

		private void ReFill()
		{
			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = (from renta in db.RENTADEVOLUCION
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
							   where DbFunctions.TruncateTime(renta.FechaRenta) >= DbFunctions.TruncateTime(porFecha.Value) && 
							   DbFunctions.TruncateTime(renta.FechaRenta) <= DbFunctions.TruncateTime(FechaHasta.Value)
							   select new RentaClass
							   {
								   IdRenta = renta.IdRentaDevolucion,
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
							   }).AsQueryable();


					if (!porCliente.Text.Trim().Equals(""))
					{
						lst = lst.Where(x => x.Cliente.Contains(porCliente.Text.Trim()));
					}

					if (!porVehiculo.Text.Trim().Equals(""))
					{
						lst = lst.Where(x => x.Vehiculo.Contains(porVehiculo.Text.Trim()));
					}

					dataGridView1.DataSource = lst.ToList();
				}
			}
			catch(NotSupportedException ex)
			{

			}
			
		}

		public class RentaClass
		{
			public int IdRenta { get; set; }
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

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void Renta_Load(object sender, EventArgs e)
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
				renta.MontoAtraso = null;
				renta.MontoDia = decimal.Parse(tbxMontoDia.Text);
				renta.Comentarios = null;
				renta.FechaRenta = DateTime.Parse(dtpFecha.Text);
				renta.FechaDevolucon = null;
				renta.CantidadDias = tbxCantidadDias.Text;

				if (cbEstado.Text.Trim() == "Activo")
					renta.Estado = "A";
				else if (cbEstado.Text.Trim() == "Inactivo")
					renta.Estado = "I";

				if ( tbxMontoDia.Text.Trim() == "" || cbEstado.Text.Trim() == "" || dtpFecha.Text.Trim() == "" 
					|| tbxCantidadDias.Text.Trim() == "")
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
							if (int.Parse(tbxMontoDia.Text) < 0)
							{
								MessageBox.Show("Por favor, ingrese un monto correcto.");
							}
							else
							{
								db.RENTADEVOLUCION.Add(renta);
								MessageBox.Show("Renta Added!");
							}
							
						}
						else
						{
							if (int.Parse(tbxMontoDia.Text) < 0)
							{
								MessageBox.Show("Por favor, ingrese un monto correcto.");
							}
							else
							{
								db.Entry(renta).State = EntityState.Modified;
								MessageBox.Show("Renta Updated!");
								btnSave.Text = "Save";
							}
							
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

		private void btnEdit_Click(object sender, EventArgs e)
		{

			try
			{
				renta.IdRentaDevolucion = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

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
							  select new RentaClass
							  {
								  IdRenta = renta.IdRentaDevolucion,
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

					renta = db.RENTADEVOLUCION.Where(x => x.IdRentaDevolucion == renta.IdRentaDevolucion).FirstOrDefault();
					var descri = lst.Where(x => x.IdRenta == renta.IdRentaDevolucion).FirstOrDefault();
					tbxCantidadDias.Text = renta.CantidadDias;
					tbxMontoDia.Text = renta.MontoDia.ToString();
					cbCliente.Text = descri.Cliente;
					cbEmpleado.Text = descri.Empleado;
					cbVehiculo.Text = descri.Vehiculo;
					dtpFecha.Text = renta.FechaRenta.ToString();

					//Estado
					if (renta.Estado == "A")
					{
						cbEstado.Text = "Activo";
					}
					else if(renta.Estado == "I")
					{
						cbEstado.Text = "Inactivo";
					}

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
				renta.IdRentaDevolucion = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					renta = db.RENTADEVOLUCION.Where(x => x.IdRentaDevolucion == renta.IdRentaDevolucion).FirstOrDefault();
					db.RENTADEVOLUCION.Remove(renta);
					db.SaveChanges();
					Clear();
					ReFill();
					MessageBox.Show("Deleted Successfully!");
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ReFill();
		}
	}
	}

