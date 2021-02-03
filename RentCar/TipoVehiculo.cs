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
	public partial class TipoVehiculo : Form
	{
		TIPOVEHICULO tipovehiculo = new TIPOVEHICULO();

		public TipoVehiculo()
		{
			InitializeComponent(); 
			LoadTheme();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
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

		private void ReFill()
		{
			dataGridView1.AutoGenerateColumns = false;
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from tipoVehiculo in db.TIPOVEHICULO
						  select tipoVehiculo;

				dataGridView1.DataSource = lst.ToList();
			}
		}

		private void Clear()
		{
			txbDescripcion.Text = cbEstado.Text = "";
			tipovehiculo.IdTipoVehiculo = 0;
			btnSave.Text = "Save";
		}

		private void TipoVehiculo_Load(object sender, EventArgs e)
		{
			ReFill();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				tipovehiculo.Despcricion = txbDescripcion.Text;

				if (cbEstado.Text == "Activo")
					tipovehiculo.Estado = "A";
				else if (cbEstado.Text == "Inactivo")
					tipovehiculo.Estado = "I";

				if (txbDescripcion.Text.Trim() == "" || cbEstado.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introducir todos los campos.");
				}
				else
				{
					using (RentCarEntities db = new RentCarEntities())
					{
						if (tipovehiculo.IdTipoVehiculo == 0)
						{
							db.TIPOVEHICULO.Add(tipovehiculo);
							MessageBox.Show("Marca Added!");
						}
						else
						{
							db.Entry(tipovehiculo).State = EntityState.Modified;
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
				tipovehiculo.IdTipoVehiculo = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					tipovehiculo = db.TIPOVEHICULO.Where(x => x.IdTipoVehiculo == tipovehiculo.IdTipoVehiculo).FirstOrDefault();
					txbDescripcion.Text = tipovehiculo.Despcricion;
					cbEstado.Text = tipovehiculo.Estado;
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
				tipovehiculo.IdTipoVehiculo = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					tipovehiculo = db.TIPOVEHICULO.Where(x => x.IdTipoVehiculo == tipovehiculo.IdTipoVehiculo).FirstOrDefault();
					db.TIPOVEHICULO.Remove(tipovehiculo);
					db.SaveChanges();
					Clear();
					ReFill();
					MessageBox.Show("Deleted Successfully!");
				}
			}
		}
	}
}
