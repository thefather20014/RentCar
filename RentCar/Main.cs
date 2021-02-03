using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models;

namespace RentCar
{
	public partial class Main : Form
	{
		private Button currentButton;
		private Random random;
		private int tempIndex;
		private Form activeForm;

		public Main()
		{
			InitializeComponent();
			random = new Random();
			btnCloseChild.Visible = false;
			/*this.Text = string.Empty;
			this.ControlBox = false;*/
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			customizeDesign();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void Main_Load(object sender, EventArgs e)
		{
		
		}

		private void customizeDesign()
		{
			panelSubMenu.Visible = false;
			panelSubMenu2.Visible = false;
		}

		private void hideSubMenu()
		{
			if (panelSubMenu.Visible == true)
				panelSubMenu.Visible = false;
			if (panelSubMenu2.Visible == true)
				panelSubMenu2.Visible = false;
		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
			{
				subMenu.Visible = false;
			}
				
		}

		private void btnMantenimiento_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			showSubMenu(panelSubMenu);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Marcas marcas = new Marcas();
			OpenChildForm(marcas, sender);
			hideSubMenu();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Modelo modelo = new Modelo();
			OpenChildForm(modelo, sender);
			hideSubMenu();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TipoVehiculo tipoveh = new TipoVehiculo();
			OpenChildForm(tipoveh, sender);
			hideSubMenu();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			VehiculoForm vehiculo = new VehiculoForm();
			OpenChildForm(vehiculo, sender);
			hideSubMenu();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			TipoCombustible combustible = new TipoCombustible();
			OpenChildForm(combustible, sender);
			hideSubMenu();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Empleados empleados = new Empleados();
			OpenChildForm(empleados, sender);
			hideSubMenu();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Clientes clientes = new Clientes();
			OpenChildForm(clientes, sender);
			hideSubMenu();
		}

		private void btnInspeccion_Click(object sender, EventArgs e)
		{

			Inspeccion inspeccion = new Inspeccion();
			OpenChildForm(inspeccion, sender);
			hideSubMenu();
		}

		private void btnRenta_Click(object sender, EventArgs e)
		{
			Renta renta = new Renta();
			OpenChildForm(renta, sender);
			hideSubMenu();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Devolucion devolucion = new Devolucion();
			OpenChildForm(devolucion, sender);
			hideSubMenu();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			showSubMenu(panelSubMenu2);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Report report = new Report();
			OpenChildForm(report, sender);
			hideSubMenu();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			this.Close();
			Form1 login = new Form1();
			login.Show();
		}

		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}

		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					DisableButton();
					Color color = SelectThemeColor();
					currentButton = (Button)btnSender;
					currentButton.BackColor = color;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					panelTitleBar.BackColor = color;
					panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					ThemeColor.PrimaryColor = color;
					ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
				}
			}
		}

		private void DisableButton()
		{
			foreach (Control previousBtn in panelSideMenu.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				}
			}
		}

		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			btnCloseChild.Visible = true;
			Color color = SelectThemeColor();
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelForm.Controls.Add(childForm);
			this.panelForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitle.Text = childForm.Text.ToUpper();
			ThemeColor.PrimaryColor = color;
			ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

		}

		private void btnCloseChild_Click(object sender, EventArgs e)
		{
			if (activeForm != null)
				activeForm.Close();
			Reset();
		}

		private void Reset()
		{
			DisableButton();
			lblTitle.Text = "HOME";
			panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
			panelLogo.BackColor = Color.FromArgb(39, 39, 58);
			currentButton = null;
			btnCloseChild.Visible = false;
		}

		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnMaximized_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				this.WindowState = FormWindowState.Maximized;
			else
				this.WindowState = FormWindowState.Normal;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void panelForm_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
