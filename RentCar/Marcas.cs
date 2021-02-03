using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models;
using System.Data.Entity;

namespace RentCar
{
    public partial class Marcas : Form
    {
        MARCA marca = new MARCA();

        public Marcas()
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
            /*label4.ForeColor = ThemeColor.SecondaryColor; 
            label5.ForeColor = ThemeColor.PrimaryColor;*/
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            ReFill();
        }

        private void Clear()
        {
            txbDescripcion.Text = cbEstado.Text = "";
            marca.IdMarca = 0;
            btnSave.Text = "Save";
        }

        private void ReFill()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (RentCarEntities db = new RentCarEntities())
            {
                var lst = from marca in db.MARCA
                          select marca;

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
			{
                marca.Despcricion = txbDescripcion.Text;

                if (cbEstado.Text == "Activo")
                    marca.Estado = "A";
                else if (cbEstado.Text == "Inactivo")
                    marca.Estado = "I";

               if (txbDescripcion.Text.Trim() == "" || cbEstado.Text.Trim() == "")
				{
                    MessageBox.Show("Por favor, introducir todos los campos.");
                }
               else
				{
                   using(RentCarEntities db = new RentCarEntities())
					{
                        if (marca.IdMarca == 0)
						{
                            db.MARCA.Add(marca);
                            MessageBox.Show("Marca Added!");
                        }
						else
						{
                            db.Entry(marca).State = EntityState.Modified;
                            MessageBox.Show("Marca Updated!");
                            btnSave.Text = "Save";
                        }

                        db.SaveChanges();

                    }
                    Clear();
                    ReFill();
                    
                }
            }
            catch(Exception ex)
			{
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
			{
                marca.IdMarca = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

                using (RentCarEntities db = new RentCarEntities())
                {
                    marca = db.MARCA.Where(x => x.IdMarca == marca.IdMarca).FirstOrDefault();
                    txbDescripcion.Text = marca.Despcricion;
                    cbEstado.Text = marca.Estado;
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
            if(MessageBox.Show("¿Estás seguro que quieres eliminar el registro?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
                marca.IdMarca = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

                using (RentCarEntities db = new RentCarEntities())
                {
                    marca = db.MARCA.Where(x => x.IdMarca == marca.IdMarca).FirstOrDefault();
                    db.MARCA.Remove(marca);
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txbDescripcion_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}