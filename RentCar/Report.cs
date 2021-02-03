using RentCar.Models;
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

namespace RentCar
{
	public partial class Report : Form
	{
		public Report()
		{
			InitializeComponent();
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

		private List<RentaClass> ReFill()
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
							   where filtroFecha.Checked ? DbFunctions.TruncateTime(renta.FechaRenta) >= DbFunctions.TruncateTime(porFecha.Value) && DbFunctions.TruncateTime(renta.FechaRenta)
							   <= DbFunctions.TruncateTime(FechaHasta.Value) : true
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

					return lst.ToList();
				}
		}

		private void Clear()
		{
			filtroFecha.Checked = false;
			porCliente.Text = "";
			porVehiculo.Text = "";
			porFecha.Text = DateTime.Now.ToLongDateString();
			FechaHasta.Text = DateTime.Now.ToLongDateString();
			FechaHasta.Text = null;
			FechaHasta.Enabled = false;
			porFecha.Text = null;
			porFecha.Enabled = false;
		}
			

		private void Report_Load(object sender, EventArgs e)
		{
			FechaHasta.Text = null;
			FechaHasta.Enabled = false;
			porFecha.Text = null;
			porFecha.Enabled = false;
			this.rentaClassBindingSource1.DataSource = ReFill();
			this.reportViewer1.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			this.rentaClassBindingSource1.DataSource = ReFill();
		}

		private void rentaClassBindingSource1_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void porFecha_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ReFill();
			this.rentaClassBindingSource1.DataSource = ReFill();
			this.reportViewer1.RefreshReport();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Clear();
			this.rentaClassBindingSource1.DataSource = ReFill();
			this.reportViewer1.RefreshReport();
		}

		private void filtroFecha_CheckedChanged(object sender, EventArgs e)
		{
			if(filtroFecha.Checked == false)
			{
				FechaHasta.Enabled = false;
				porFecha.Enabled = false;
				ReFill();
				this.rentaClassBindingSource1.DataSource = ReFill();
				this.reportViewer1.RefreshReport();
				
			}
			else
			{
				FechaHasta.Enabled = true;
				porFecha.Enabled = true;
				ReFill();
				this.rentaClassBindingSource1.DataSource = ReFill();
				this.reportViewer1.RefreshReport();
			}
		}
	}
}
