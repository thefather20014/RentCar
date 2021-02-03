
namespace RentCar
{
	partial class Empleados
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tbxNombre = new System.Windows.Forms.TextBox();
			this.tbxCedula = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbTanda = new System.Windows.Forms.ComboBox();
			this.tbxComision = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
			this.dtpSalida = new System.Windows.Forms.DateTimePicker();
			this.lblSalida = new System.Windows.Forms.Label();
			this.tbxUsuario = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbxPass = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDisabled = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btxnBuscar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tbxBNombre = new System.Windows.Forms.TextBox();
			this.tbxBCedula = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// tbxNombre
			// 
			this.tbxNombre.Location = new System.Drawing.Point(121, 32);
			this.tbxNombre.Name = "tbxNombre";
			this.tbxNombre.Size = new System.Drawing.Size(100, 20);
			this.tbxNombre.TabIndex = 1;
			// 
			// tbxCedula
			// 
			this.tbxCedula.Location = new System.Drawing.Point(121, 62);
			this.tbxCedula.Name = "tbxCedula";
			this.tbxCedula.Size = new System.Drawing.Size(100, 20);
			this.tbxCedula.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cédula";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tanda";
			// 
			// cbTanda
			// 
			this.cbTanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTanda.FormattingEnabled = true;
			this.cbTanda.Items.AddRange(new object[] {
            "",
            "Matutina",
            "Vespertina",
            "Nocturna"});
			this.cbTanda.Location = new System.Drawing.Point(121, 110);
			this.cbTanda.Name = "cbTanda";
			this.cbTanda.Size = new System.Drawing.Size(100, 21);
			this.cbTanda.TabIndex = 5;
			// 
			// tbxComision
			// 
			this.tbxComision.Location = new System.Drawing.Point(121, 142);
			this.tbxComision.Name = "tbxComision";
			this.tbxComision.Size = new System.Drawing.Size(100, 20);
			this.tbxComision.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "PorcientoxComisión";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 180);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Fecha de Ingreso";
			// 
			// dtpIngreso
			// 
			this.dtpIngreso.Location = new System.Drawing.Point(121, 174);
			this.dtpIngreso.Name = "dtpIngreso";
			this.dtpIngreso.Size = new System.Drawing.Size(200, 20);
			this.dtpIngreso.TabIndex = 9;
			// 
			// dtpSalida
			// 
			this.dtpSalida.Location = new System.Drawing.Point(121, 211);
			this.dtpSalida.Name = "dtpSalida";
			this.dtpSalida.Size = new System.Drawing.Size(200, 20);
			this.dtpSalida.TabIndex = 11;
			// 
			// lblSalida
			// 
			this.lblSalida.AutoSize = true;
			this.lblSalida.Location = new System.Drawing.Point(20, 217);
			this.lblSalida.Name = "lblSalida";
			this.lblSalida.Size = new System.Drawing.Size(84, 13);
			this.lblSalida.TabIndex = 10;
			this.lblSalida.Text = "Fecha de Sálida";
			// 
			// tbxUsuario
			// 
			this.tbxUsuario.Location = new System.Drawing.Point(121, 270);
			this.tbxUsuario.Name = "tbxUsuario";
			this.tbxUsuario.Size = new System.Drawing.Size(100, 20);
			this.tbxUsuario.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 273);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Usuario";
			// 
			// tbxPass
			// 
			this.tbxPass.Location = new System.Drawing.Point(121, 306);
			this.tbxPass.Name = "tbxPass";
			this.tbxPass.PasswordChar = '*';
			this.tbxPass.Size = new System.Drawing.Size(100, 20);
			this.tbxPass.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 309);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Password";
			// 
			// cbEstado
			// 
			this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
			this.cbEstado.Location = new System.Drawing.Point(121, 342);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(100, 21);
			this.cbEstado.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 350);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Estado";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(327, 77);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(533, 284);
			this.dataGridView1.TabIndex = 18;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(327, 382);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(109, 38);
			this.btnClear.TabIndex = 57;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(690, 382);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 38);
			this.btnDelete.TabIndex = 56;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Location = new System.Drawing.Point(566, 382);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(109, 38);
			this.btnEdit.TabIndex = 55;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(442, 382);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(109, 38);
			this.btnSave.TabIndex = 54;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDisabled
			// 
			this.btnDisabled.FlatAppearance.BorderSize = 0;
			this.btnDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDisabled.Location = new System.Drawing.Point(195, 237);
			this.btnDisabled.Name = "btnDisabled";
			this.btnDisabled.Size = new System.Drawing.Size(56, 21);
			this.btnDisabled.TabIndex = 59;
			this.btnDisabled.Text = "Disabled";
			this.btnDisabled.UseVisualStyleBackColor = true;
			this.btnDisabled.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(118, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 12);
			this.label6.TabIndex = 64;
			this.label6.Text = "Sin guiones";
			// 
			// btxnBuscar
			// 
			this.btxnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btxnBuscar.Location = new System.Drawing.Point(548, 47);
			this.btxnBuscar.Name = "btxnBuscar";
			this.btxnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btxnBuscar.TabIndex = 73;
			this.btxnBuscar.Text = "Buscar";
			this.btxnBuscar.UseVisualStyleBackColor = true;
			this.btxnBuscar.Click += new System.EventHandler(this.btxnBuscar_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(439, 32);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 13);
			this.label10.TabIndex = 72;
			this.label10.Text = "Nombre";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(321, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 71;
			this.label11.Text = "Cédula";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// tbxBNombre
			// 
			this.tbxBNombre.Location = new System.Drawing.Point(442, 48);
			this.tbxBNombre.Name = "tbxBNombre";
			this.tbxBNombre.Size = new System.Drawing.Size(100, 20);
			this.tbxBNombre.TabIndex = 70;
			this.tbxBNombre.TextChanged += new System.EventHandler(this.tbxBNombre_TextChanged);
			// 
			// tbxBCedula
			// 
			this.tbxBCedula.Location = new System.Drawing.Point(324, 48);
			this.tbxBCedula.Name = "tbxBCedula";
			this.tbxBCedula.Size = new System.Drawing.Size(100, 20);
			this.tbxBCedula.TabIndex = 69;
			this.tbxBCedula.TextChanged += new System.EventHandler(this.tbxBCedula_TextChanged);
			// 
			// Empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 450);
			this.Controls.Add(this.btxnBuscar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.tbxBNombre);
			this.Controls.Add(this.tbxBCedula);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnDisabled);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbEstado);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbxPass);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbxUsuario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtpSalida);
			this.Controls.Add(this.lblSalida);
			this.Controls.Add(this.dtpIngreso);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbxComision);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbTanda);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxCedula);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxNombre);
			this.Controls.Add(this.label1);
			this.Name = "Empleados";
			this.Text = "Empleados";
			this.Load += new System.EventHandler(this.Empleados_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxNombre;
		private System.Windows.Forms.TextBox tbxCedula;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbTanda;
		private System.Windows.Forms.TextBox tbxComision;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIngreso;
		private System.Windows.Forms.DateTimePicker dtpSalida;
		private System.Windows.Forms.Label lblSalida;
		private System.Windows.Forms.TextBox tbxUsuario;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbxPass;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDisabled;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btxnBuscar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbxBNombre;
		private System.Windows.Forms.TextBox tbxBCedula;
	}
}