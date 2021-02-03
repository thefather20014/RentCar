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
	public partial class Empleados : Form
	{
		EMPLEADO emp = new EMPLEADO();
		bool disabled = false;

		public Empleados()
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

		public class EmpleadoModel
		{
			public int IdEmpleado { get; set; }
			public string Nombre { get; set; }
			public string Cedula { get; set; }
			public string Tanda { get; set; }
			public string Comision { get; set; }
			public DateTime Ingreso { get; set; }
			public DateTime? Salida { get; set; }
			public string Usuario { get; set; }
			public string Password { get; set; }
			public string Estado { get; set; }
		}

		private void ReFill()
		{
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from empleado in db.EMPLEADO
						  select new EmpleadoModel 
						  { 
							  IdEmpleado = empleado.IdEmpleado,
							  Nombre = empleado.Nombre, 
							  Cedula = empleado.Documento, 
							  Tanda = empleado.Tanda,
							  Comision = empleado.PorcientoComision,
							  Ingreso = empleado.FechaIngreso,
							  Salida = empleado.FechaSalida,
							  Usuario = empleado.Usuario,
							  Password = empleado.Password,
							  Estado = empleado.Estado
						  };

				if (!tbxBCedula.Text.Trim().Equals(""))
				{
					lst = lst.Where(x => x.Cedula.Contains(tbxBCedula.Text.Trim()));
				}

				if (!tbxBNombre.Text.Trim().Equals(""))
				{
					lst = lst.Where(x => x.Nombre.Contains(tbxBNombre.Text.Trim()));
				}

				dataGridView1.DataSource = lst.ToList();
			}
		}

		public static bool validaCedula(string pCedula)

		{
			int vnTotal = 0;
			string vcCedula = pCedula.Replace("-", "");
			int pLongCed = vcCedula.Trim().Length;
			int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

			if (pLongCed < 11 || pLongCed > 11)
				return false;

			for (int vDig = 1; vDig <= pLongCed; vDig++)
			{
				int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
				if (vCalculo < 10)
					vnTotal += vCalculo;
				else
					vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
			}

			if (vnTotal % 10 == 0)
				return true;
			else
				return false;
		}

		private void Empleados_Load(object sender, EventArgs e)
		{
			ReFill();
			btnDisabled.Visible = false;
			dtpSalida.Enabled = false;
		}

		private void Clear()
		{
			tbxNombre.Text = tbxBNombre.Text = tbxCedula.Text = tbxBCedula.Text = cbEstado.Text = cbTanda.Text = tbxComision.Text = tbxUsuario.Text = tbxPass.Text = "" ;
			dtpIngreso.Text = dtpSalida.Text = DateTime.Now.ToLongDateString();
			emp.IdEmpleado = 0;
			ReFill();
			btnSave.Text = "Save";
			btnDisabled.Visible = false;
			disabled = false;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				emp.Nombre = tbxNombre.Text;
				emp.Documento = tbxCedula.Text;
				emp.Usuario = tbxUsuario.Text;
				emp.Password = tbxPass.Text;
				emp.PorcientoComision = tbxComision.Text;
				emp.FechaIngreso = DateTime.Parse(dtpIngreso.Text);

				if (cbTanda.Text == "Matutina")
					emp.Tanda = "M";
				else if (cbTanda.Text == "Vespertina")
					emp.Tanda = "V";
				else if (cbTanda.Text == "Nocturna")
					emp.Tanda = "N";

				if (cbEstado.Text == "Activo")
					emp.Estado = "A";
				else if (cbEstado.Text == "Inactivo")
					emp.Estado = "I";

				if (tbxNombre.Text.Trim() == "" || tbxCedula.Text.Trim() == "" || tbxUsuario.Text.Trim() == "" || tbxPass.Text.Trim() == "" 
					|| tbxComision.Text.Trim() == "" || dtpIngreso.Text.Trim() == "" || cbEstado.Text.Trim() == "" || cbTanda.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introduzca todos los campos.");
				}
				else
				{

					using (RentCarEntities db = new RentCarEntities())
					{
						if (emp.IdEmpleado == 0)
						{

							if (emp.Documento.Length != 11)
							{
								MessageBox.Show("Por favor, ingrese una cédula válida");
							}
							else if (emp.Documento.Length == 11)
							{
								emp.FechaSalida = null;
								db.EMPLEADO.Add(emp);
								MessageBox.Show("Empleado Added!");
							}
						}
						else
						{
							if (disabled) { emp.FechaSalida = DateTime.Parse(dtpSalida.Text); }

							if (emp.Documento.Length != 11)
							{
								MessageBox.Show("Por favor, ingrese una cédula válida");
							}
							else if (emp.Documento.Length == 11)
							{
								db.Entry(emp).State = EntityState.Modified;
								MessageBox.Show("Empleado Updated!");
								btnSave.Text = "Save";
								btnDisabled.Visible = false;
								dtpSalida.Enabled = false;
							}
							
						}

						db.SaveChanges();

					}
					ReFill();
					Clear();

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
				emp.IdEmpleado = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
				btnDisabled.Visible = true; //Se visualiza el botón
				dtpSalida.Enabled = true; // Se activa el datepicker

				if (emp.FechaSalida != null && emp.FechaSalida.ToString().Trim() != "")
				{
					btnDisabled.Visible = false;
				}
				else
				{
					btnDisabled.Visible = true;
				}

				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from empleado in db.EMPLEADO
							  select new EmpleadoModel
							  {
								  IdEmpleado = empleado.IdEmpleado,
								  Nombre = empleado.Nombre,
								  Cedula = empleado.Documento,
								  Tanda = empleado.Tanda,
								  Comision = empleado.PorcientoComision,
								  Ingreso = empleado.FechaIngreso,
								  Salida = empleado.FechaSalida,
								  Usuario = empleado.Usuario,
								  Password = empleado.Password,
								  Estado = empleado.Estado
							  };

					emp = db.EMPLEADO.Where(x => x.IdEmpleado == emp.IdEmpleado).FirstOrDefault();
					tbxNombre.Text = emp.Nombre;
					tbxCedula.Text = emp.Documento;
					tbxUsuario.Text = emp.Usuario;
					tbxPass.Text = emp.Password;
					tbxComision.Text = emp.PorcientoComision;
					dtpIngreso.Text = emp.FechaIngreso.ToString();
					dtpSalida.Text = emp.FechaSalida.ToString();

					//Estado
					if(emp.Estado == "A")
					{
						cbEstado.Text = "Activo";
					}
					else
					{
						cbEstado.Text = "Inactivo";
					}
					//Tanda
					if (emp.Tanda == "M")
					{
						cbTanda.Text = "Matutina";
					}
					else if(emp.Tanda == "V")
					{
						cbTanda.Text = "Vespertina";
					}
					else
					{
						cbTanda.Text = "Nocturna";
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
				emp.IdEmpleado = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					emp = db.EMPLEADO.Where(x => x.IdEmpleado == emp.IdEmpleado).FirstOrDefault();
					db.EMPLEADO.Remove(emp);
					db.SaveChanges();
					Clear();
					ReFill();
					MessageBox.Show("Deleted Successfully!");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			disabled = !disabled;
			dtpSalida.Enabled = !dtpSalida.Enabled;

			if (disabled)
			{
				btnDisabled.Text = "Disabled";
			}
			else
			{
				btnDisabled.Text = "Enabled";
			}

		}

		private void btxnBuscar_Click(object sender, EventArgs e)
		{
			ReFill();
		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void tbxBNombre_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbxBCedula_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
