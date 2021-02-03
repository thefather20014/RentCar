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
	public partial class Modelo : Form
	{
		MODELO modelo = new MODELO();

		public Modelo()
		{
			InitializeComponent();
			LoadTheme();
		}

		private void label1_Click(object sender, EventArgs e)
		{

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
			//dataGridView1.AutoGenerateColumns = false;
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from marca in db.MARCA
						  join modelo in db.MODELO
						  on marca.IdMarca equals modelo.IdMarca
						  select new MarcaModelo { IdModelo = modelo.IdModelo, Modelo = modelo.Despcricion,Marca = marca.Despcricion, Estado = modelo.Estado  };

				dataGridView1.DataSource = lst.ToList();
			}
		}

		public class MarcaModelo
		{
			public int IdModelo { get; set; }
			public string Modelo { get; set; }
			public string Marca { get; set; }
			public string Estado { get; set; }
		}

		private void Modelo_Load(object sender, EventArgs e)
		{
			ReFill();
			RefillCombo();
		}

		private void Clear()
		{
			txbModelo.Text = cbMarca.Text = cbEstado.Text = "";
			modelo.IdModelo = 0;
			btnSave.Text = "Save";
		}

		private void RefillCombo()
		{

			try
			{
				using (RentCarEntities db = new RentCarEntities())
				{
					var marcas = from marca in db.MARCA
								where marca.Estado == "A"
								select marca;

					if (marcas.Count() > 0)
					{
						cbMarca.DataSource = marcas.ToList();
						cbMarca.DisplayMember = "Despcricion";
						cbMarca.ValueMember = "IdMarca";
						if (cbMarca.Items.Count > 1)
							cbMarca.SelectedIndex = -1;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			
		}

		private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnSave_Click_1(object sender, EventArgs e)
		{
			try
			{
				modelo.Despcricion = txbModelo.Text;
				if (cbEstado.Text == "Activo")
					modelo.Estado = "A";
				else if (cbEstado.Text == "Inactivo")
					modelo.Estado = "I";

				if (txbModelo.Text.Trim() == "" || cbMarca.Text.Trim() == "" || cbEstado.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introduzca todos los campos.");
				}
				else
				{
					modelo.IdMarca = int.Parse(cbMarca.SelectedValue.ToString());

					using (RentCarEntities db = new RentCarEntities())
					{
						if (modelo.IdModelo == 0)
						{
							db.MODELO.Add(modelo);
							MessageBox.Show("Marca Added!");
						}
						else
						{
							db.Entry(modelo).State = EntityState.Modified;
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
				modelo.IdModelo = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from marca in db.MARCA
							  join modeloj in db.MODELO
							  on marca.IdMarca equals modeloj.IdMarca
							  select new MarcaModelo { IdModelo = modeloj.IdModelo, Marca = marca.Despcricion, Modelo = modeloj.Despcricion, Estado = modeloj.Estado };

				    var descri = lst.Where(x => x.IdModelo == modelo.IdModelo ).FirstOrDefault();
					modelo = db.MODELO.Where(x => x.IdModelo == modelo.IdModelo).FirstOrDefault();
					txbModelo.Text = modelo.Despcricion;
					cbMarca.Text = descri.Marca;
					cbEstado.Text = modelo.Estado;
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
				modelo.IdModelo = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					modelo = db.MODELO.Where(x => x.IdModelo == modelo.IdModelo).FirstOrDefault();
					db.MODELO.Remove(modelo);
					db.SaveChanges();
					Clear();
					ReFill();
					MessageBox.Show("Deleted Successfully!");
				}
			}
		}
	}
}
