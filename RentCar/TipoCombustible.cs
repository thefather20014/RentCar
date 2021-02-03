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
	public partial class TipoCombustible : Form
	{
		TIPOCOMBUSTIBLE combustible = new TIPOCOMBUSTIBLE();

		public TipoCombustible()
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

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}
		private void Clear()
		{
			txbDescripcion.Text = cbEstado.Text = "";
			combustible.IdTipoCombustible = 0;
			btnSave.Text = "Save";
		}

		private void ReFill()
		{
			dataGridView1.AutoGenerateColumns = false;
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from combustible in db.TIPOCOMBUSTIBLE
						  select combustible;

				dataGridView1.DataSource = lst.ToList();
			}
		}

		private void TipoCombustible_Load(object sender, EventArgs e)
		{
			ReFill();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				combustible.Despcricion = txbDescripcion.Text;

				if (cbEstado.Text == "Activo")
					combustible.Estado = "A";
				else if (cbEstado.Text == "Inactivo")
					combustible.Estado = "I";

				if (txbDescripcion.Text.Trim() == "" || cbEstado.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introducir todos los campos.");
				}
				else
				{
					using (RentCarEntities db = new RentCarEntities())
					{
						if (combustible.IdTipoCombustible == 0)
						{
							db.TIPOCOMBUSTIBLE.Add(combustible);
							MessageBox.Show("Marca Added!");
						}
						else
						{
							db.Entry(combustible).State = EntityState.Modified;
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
				combustible.IdTipoCombustible = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					combustible = db.TIPOCOMBUSTIBLE.Where(x => x.IdTipoCombustible == combustible.IdTipoCombustible).FirstOrDefault();
					txbDescripcion.Text = combustible.Despcricion;
					cbEstado.Text = combustible.Estado;
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
				combustible.IdTipoCombustible = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					combustible = db.TIPOCOMBUSTIBLE.Where(x => x.IdTipoCombustible == combustible.IdTipoCombustible).FirstOrDefault();
					db.TIPOCOMBUSTIBLE.Remove(combustible);
					db.SaveChanges();
					Clear();
					ReFill();
					MessageBox.Show("Deleted Successfully!");
				}
			}
		}
	}
}
