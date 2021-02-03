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
	public partial class Clientes : Form
	{
		CLIENTE cliente = new CLIENTE();

		public Clientes()
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
			tbxNombre.Text = tbxDocumento.Text = cbEstado.Text = tbxTarjeta.Text = tbxLimite.Text = cbTPersona.Text = "";
			cliente.IdCliente = 0;
			btnSave.Text = "Save";
		}

		public class ClienteModel
		{
			public int IdCliente { get; set; }
			public string Nombre { get; set; }
			public string Documento { get; set; }
			public string TarjetaCredito { get; set; }
			public string LimiteCredito  { get; set; }
			public string TipoPersona { get; set; }
			public string Estado { get; set; }
		}


		private void ReFill()
		{
			using (RentCarEntities db = new RentCarEntities())
			{
				var lst = from cliente in db.CLIENTE
						  select new ClienteModel
						  {
							  IdCliente = cliente.IdCliente,
							  Nombre = cliente.Nombre,
							  Documento = cliente.Documento,
							  TarjetaCredito = cliente.TarjetaCredito,
							  LimiteCredito = cliente.LimiteCredito,
							  TipoPersona = cliente.TipoPersona,
							  Estado = cliente.Estado
						  };


				if (!tbxCedula.Text.Trim().Equals(""))
				{
					lst = lst.Where(x => x.Documento.Contains(tbxCedula.Text.Trim()));
				}

				if (!tbxBNombre.Text.Trim().Equals(""))
				{
					lst = lst.Where(x => x.Nombre.Contains(tbxBNombre.Text.Trim()));
				}

				dataGridView1.DataSource = lst.ToList();
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void Clientes_Load(object sender, EventArgs e)
		{
			ReFill();
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

		private bool esUnRNCValido(string pRNC)

		{

			int vnTotal = 0;

			int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

			string vcRNC = pRNC.Replace("-", "").Replace(" ", "");

			string vDigito = vcRNC.Substring(8, 1);

			if (vcRNC.Length.Equals(9))

				if (!"145".Contains(vcRNC.Substring(0, 1)))

					return false;

			for (int vDig = 1; vDig <= 8; vDig++)

			{

				int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

				vnTotal += vCalculo;

			}

			if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||

				(11 - (vnTotal % 11)).Equals(vDigito))

				return true;

			else

				return false;

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				cliente.Nombre = tbxNombre.Text;
				cliente.Documento = tbxDocumento.Text;
				cliente.TarjetaCredito = tbxTarjeta.Text;
				cliente.LimiteCredito = tbxLimite.Text;

				if (cbTPersona.Text == "Física")
					cliente.TipoPersona = "F";
				else if (cbTPersona.Text == "Jurídica")
					cliente.TipoPersona = "J";

				if (cbEstado.Text == "Activo")
					cliente.Estado = "A";
				else if (cbEstado.Text == "Inactivo")
					cliente.Estado = "I";

				if (tbxNombre.Text.Trim() == "" || tbxDocumento.Text.Trim() == "" || tbxTarjeta.Text.Trim() == "" || tbxLimite.Text.Trim() == ""
					|| cbTPersona.Text.Trim() == "" || cbEstado.Text.Trim() == "")
				{
					MessageBox.Show("Por favor, introduzca todos los campos.");
				}
				else
				{

					using (RentCarEntities db = new RentCarEntities())
					{
						if (cliente.IdCliente == 0)
						{
							if (cliente.TipoPersona == "J" && cliente.Documento.Length != 9)
							{
								MessageBox.Show("Por favor, ingrese una RNC válido");
							}
							else if (cliente.TipoPersona == "F" && cliente.Documento.Length != 11)
							{
								MessageBox.Show("Por favor, ingrese una cédula válida");
							}
							else if (cliente.TarjetaCredito.Length != 16)
							{
								MessageBox.Show("Por favor, ingrese una tarjeta de crédito válida");
							}
							else if (int.Parse(tbxLimite.Text) < 0)
							{
								MessageBox.Show("Por favor, ingrese un límite válido");
							}
							else
							{
								db.CLIENTE.Add(cliente);
								MessageBox.Show("Marca Added!");
								
							}
						}
						else
						{
							if (cliente.TipoPersona == "J" && cliente.Documento.Length != 9)
							{
								MessageBox.Show("Por favor, ingrese una RNC válido");
							}
							else if (cliente.TipoPersona == "F" && cliente.Documento.Length != 11)
							{
								MessageBox.Show("Por favor, ingrese una cédula válida");
							}
							else if(cliente.TarjetaCredito.Length != 16)
							{
								MessageBox.Show("Por favor, ingrese una tarjeta de crédito válida");
							}
							else if (int.Parse(tbxLimite.Text) < 0)
							{
								MessageBox.Show("Por favor, ingrese un límite válido");
							}
							else
							{
								db.Entry(cliente).State = EntityState.Modified;
								MessageBox.Show("Marca Updated!");
								btnSave.Text = "Save";
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
				cliente.IdCliente = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					var lst = from cliente in db.CLIENTE
							  select new ClienteModel
							  {
								  IdCliente = cliente.IdCliente,
								  Nombre = cliente.Nombre,
								  Documento = cliente.Documento,
								  TarjetaCredito = cliente.TarjetaCredito,
								  LimiteCredito = cliente.LimiteCredito,
								  TipoPersona = cliente.TipoPersona,
								  Estado = cliente.Estado
							  };

					cliente = db.CLIENTE.Where(x => x.IdCliente == cliente.IdCliente).FirstOrDefault();
					tbxNombre.Text = cliente.Nombre;
					tbxDocumento.Text = cliente.Documento;
					tbxTarjeta.Text = cliente.TarjetaCredito;
					tbxLimite.Text = cliente.LimiteCredito;

					//Estado
					if (cliente.Estado == "A")
					{
						cbEstado.Text = "Activo";
					}
					else
					{
						cbEstado.Text = "Inactivo";
					}
					//Tipo de persona
					if (cliente.TipoPersona == "F")
					{
						cbTPersona.Text = "Física";
					}
					else if (cliente.TipoPersona == "J")
					{
						cbTPersona.Text = "Jurídica";
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
				cliente.IdCliente = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

				using (RentCarEntities db = new RentCarEntities())
				{
					cliente = db.CLIENTE.Where(x => x.IdCliente == cliente.IdCliente).FirstOrDefault();
					db.CLIENTE.Remove(cliente);
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
	}
}
