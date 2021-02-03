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
	public partial class VehiculoForm : Form
	{
		Vehiculo vehiculo = new Vehiculo();

		public VehiculoForm()
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
			cbMarca.Text = cbModelo.Text = cbEstado.Text = cbTVehiculo.Text = cbTCombustible.Text = tbxDescripcion.Text = tbxChasis.Text = tbxMotor.Text =
				tbxPlaca.Text = "";
			vehiculo.IdVehiculo = 0;
			btnSave.Text = "Save";
		}

		private void ReFill()
		{
			//dataGridView1.AutoGenerateColumns = false;
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from vehiculo in db.Vehiculo
						  join modelo in db.MODELO
						  on vehiculo.IdModelo equals modelo.IdModelo
						  join marca in db.MARCA
						  on vehiculo.IdMarca equals marca.IdMarca
						  join tipoVehiculo in db.TIPOVEHICULO
						  on vehiculo.IdTipoVehiculo equals tipoVehiculo.IdTipoVehiculo
						  join tipoCombustible in db.TIPOCOMBUSTIBLE
						  on vehiculo.IdTipoCombustible equals tipoCombustible.IdTipoCombustible
						  select new VehiculoClass
						  {
							  IdVehiculo = vehiculo.IdVehiculo,
							  Modelo = modelo.Despcricion,
							  Marca = marca.Despcricion,
							  Descripcion = vehiculo.Despcricion,
							  TipoCombustible = tipoCombustible.Despcricion,
							  TipoVehiculo = tipoVehiculo.Despcricion,
							  NoChasis = vehiculo.NoChasis,
							  NoMotor = vehiculo.NoMotor,
							  NoPlaca = vehiculo.NoPlaca,
							  Estado = vehiculo.Estado
						  };

				if (!tbxBMarca.Text.Trim().Equals(""))
				{
					lst = lst.Where(x => x.Marca.Contains(tbxBMarca.Text.Trim()));
				}

				if (!tbxModelo.Text.Trim().Equals(""))
				{
					lst = lst.Where(x => x.Modelo.Contains(tbxModelo.Text.Trim()));
				}

				dataGridView1.DataSource = lst.ToList();
			}
		}

		public class VehiculoClass
		{
			public int IdVehiculo { get; set; }
			public string Modelo { get; set; }
			public string Marca { get; set; }
			public string Descripcion { get; set; }
			public string TipoCombustible { get; set; }
			public string TipoVehiculo { get; set; }
			public int NoChasis { get; set; }
			public int NoMotor { get; set; }
			public int NoPlaca { get; set; }
			public string Estado { get; set; }
		}

		private void VehiculoForm_Load(object sender, EventArgs e)
		{
			ReFill();
			RefillComboMarca();
			RefillComboTipoVehiculo();
			RefillComboTipoCombustible();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void RefillComboMarca()
		{

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from marca in db.MARCA
							  where marca.Estado == "A"
							  select marca;

						cbMarca.DataSource = lst.ToList();
						cbMarca.DisplayMember = "Despcricion";
						cbMarca.ValueMember = "IdMarca";

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}


		private void RefillComboTipoCombustible()
		{

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from tCombustible in db.TIPOCOMBUSTIBLE
								 where tCombustible.Estado == "A"
								 select tCombustible;
					if (lst.Count() > 0)
					{
						cbTCombustible.DataSource = lst.ToList();
						cbTCombustible.DisplayMember = "Despcricion";
						cbTCombustible.ValueMember = "IdTipoCombustible";
						if (cbTCombustible.Items.Count > 1)
							cbTCombustible.SelectedIndex = -1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void RefillComboTipoVehiculo()
		{

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from tVehiculo in db.TIPOVEHICULO
								 where tVehiculo.Estado == "A"
								 select tVehiculo;
					if (lst.Count() > 0)
					{
						cbTVehiculo.DataSource = lst.ToList();
						cbTVehiculo.DisplayMember = "Despcricion";
						cbTVehiculo.ValueMember = "IdTipoVehiculo";
						if (cbTVehiculo.Items.Count > 1)
							cbTVehiculo.SelectedIndex = -1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void cbMarca_SelectedValueChanged(object sender, EventArgs e)
		{
			using (RentCarEntities db = new RentCarEntities())
			{
				try
				{
					int Id = (int)cbMarca.SelectedValue;
					var lst = from modelo in db.MODELO
							  where (modelo.Estado == "A" && modelo.IdMarca == Id) 
							  select modelo;
					
						cbModelo.DataSource = lst.ToList();
						cbModelo.DisplayMember = "Despcricion";
						cbModelo.ValueMember = "IdModelo";

				}
				catch (InvalidCastException ex)
				{
					Console.WriteLine(ex);
				}
				catch (NullReferenceException ex)
				{
					Console.WriteLine(ex);
				}

			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				vehiculo.Despcricion = tbxDescripcion.Text;
				vehiculo.NoChasis = int.Parse(tbxChasis.Text);
				vehiculo.NoMotor = int.Parse(tbxMotor.Text);
				vehiculo.NoPlaca = int.Parse(tbxPlaca.Text);
				if (cbEstado.Text == "Disponible")
					vehiculo.Estado = "D";
				else if (cbEstado.Text == "Rentado")
					vehiculo.Estado = "R";
				else if (cbEstado.Text == "En mantenimiento")
					vehiculo.Estado = "M";
				else if (cbEstado.Text == "Inactivo")
					vehiculo.Estado = "I";

				if (tbxDescripcion.Text.Trim() == "" || cbMarca.Text.Trim() == "" || cbEstado.Text.Trim() == "" || cbModelo.Text.Trim() == "" || cbTCombustible.Text.Trim() == ""
					|| cbTVehiculo.Text.Trim() == "" || tbxChasis.Text.Trim() == "" || tbxMotor.Text.Trim() == "" || tbxPlaca.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introduzca todos los campos.");
				}
				else
				{
					vehiculo.IdMarca = int.Parse(cbMarca.SelectedValue.ToString());
					vehiculo.IdModelo = int.Parse(cbModelo.SelectedValue.ToString());
					vehiculo.IdTipoCombustible = int.Parse(cbTCombustible.SelectedValue.ToString());
					vehiculo.IdTipoVehiculo = int.Parse(cbTVehiculo.SelectedValue.ToString());

					using (RentCarEntities db = new RentCarEntities())
					{
						if (vehiculo.IdVehiculo == 0)
						{
							db.Vehiculo.Add(vehiculo);
							MessageBox.Show("Marca Added!");
						}
						else
						{
							db.Entry(vehiculo).State = EntityState.Modified;
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			try
			{

				vehiculo.IdVehiculo = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from vehiculo in db.Vehiculo
							  join modelo in db.MODELO
							  on vehiculo.IdModelo equals modelo.IdModelo
							  join marca in db.MARCA
							  on vehiculo.IdMarca equals marca.IdMarca
							  join tipoVehiculo in db.TIPOVEHICULO
							  on vehiculo.IdTipoVehiculo equals tipoVehiculo.IdTipoVehiculo	
							  join tipoCombustible in db.TIPOCOMBUSTIBLE
							  on vehiculo.IdTipoCombustible equals tipoCombustible.IdTipoCombustible
							  select new VehiculoClass
							  {
								  IdVehiculo = vehiculo.IdVehiculo,
								  Modelo = modelo.Despcricion,
								  Marca = marca.Despcricion,
								  Descripcion = vehiculo.Despcricion,
								  TipoCombustible = tipoCombustible.Despcricion,
								  TipoVehiculo = tipoVehiculo.Despcricion,
								  NoChasis = vehiculo.NoChasis,
								  NoMotor = vehiculo.NoMotor,
								  NoPlaca = vehiculo.NoPlaca,
								  Estado = vehiculo.Estado
							  };

					var descri = lst.Where(x => x.IdVehiculo == vehiculo.IdVehiculo).FirstOrDefault();
					vehiculo = db.Vehiculo.Where(x => x.IdVehiculo == vehiculo.IdVehiculo).FirstOrDefault();
					tbxDescripcion.Text = vehiculo.Despcricion;
					tbxChasis.Text = vehiculo.NoChasis.ToString();
					tbxMotor.Text = vehiculo.NoMotor.ToString();
					tbxPlaca.Text = vehiculo.NoPlaca.ToString();
					cbMarca.Text = descri.Marca;
					cbTCombustible.Text = descri.TipoCombustible;
					cbTVehiculo.Text = descri.TipoVehiculo;
					cbModelo.Text = descri.Modelo;

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
				vehiculo.IdVehiculo = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					vehiculo = db.Vehiculo.Where(x => x.IdVehiculo == vehiculo.IdVehiculo).FirstOrDefault();
					db.Vehiculo.Remove(vehiculo);
					db.SaveChanges();
					Clear();
					ReFill();
					MessageBox.Show("Deleted Successfully!");
				}
			}
		}

		private void btxnBuscar_Click(object sender, EventArgs e)
		{
			ReFill();
		}

		private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
