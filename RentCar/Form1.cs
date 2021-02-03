using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RentCar.Models;

namespace RentCar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		private void txtUser_Enter(object sender, EventArgs e)
		{
			if(txtUser.Text == "USUARIO")
			{
				txtUser.Text = "";
				txtUser.ForeColor = Color.LightGray;
			}
		}

		private void txtUser_Leave(object sender, EventArgs e)
		{
			if (txtUser.Text == "")
			{
				txtUser.Text = "USUARIO";
				txtUser.ForeColor = Color.DimGray;
			}
		}

		private void txtPass_Enter(object sender, EventArgs e)
		{
			if (txtPass.Text == "CONTRASEÑA")
			{
				txtPass.Text = "";
				txtPass.ForeColor = Color.LightGray;
				txtPass.UseSystemPasswordChar = true;
			}
		}

		private void txtPass_Leave(object sender, EventArgs e)
		{
			if (txtPass.Text == "")
			{
				txtPass.Text = "CONTRASEÑA";
				txtPass.ForeColor = Color.DimGray;
				txtPass.UseSystemPasswordChar = false;
			}
		}

		private void imgClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void imgHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			using(RentCarEntities db = new RentCarEntities())
			{
				var login = from emp in db.EMPLEADO
							where emp.Usuario == txtUser.Text && emp.Password == txtPass.Text
							select emp;

				if(login.Count() > 0)
				{
					this.Hide();
					Main main = new Main();
					main.Show();
				}
				else
				{
					MessageBox.Show("User Not Exist");
				}
				
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
