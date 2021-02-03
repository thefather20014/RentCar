
namespace RentCar
{
	partial class Renta
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
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cbEmpleado = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbVehiculo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCliente = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxMontoDia = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbxCantidadDias = new System.Windows.Forms.TextBox();
			this.porCliente = new System.Windows.Forms.TextBox();
			this.porVehiculo = new System.Windows.Forms.TextBox();
			this.porFecha = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.FechaHasta = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(345, 389);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(109, 38);
			this.btnClear.TabIndex = 90;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(708, 389);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 38);
			this.btnDelete.TabIndex = 89;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Location = new System.Drawing.Point(584, 389);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(109, 38);
			this.btnEdit.TabIndex = 88;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(460, 389);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(109, 38);
			this.btnSave.TabIndex = 87;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(365, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(478, 272);
			this.dataGridView1.TabIndex = 86;
			// 
			// cbEstado
			// 
			this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Items.AddRange(new object[] {
            " ",
            "Activo",
            "Inactivo"});
			this.cbEstado.Location = new System.Drawing.Point(142, 194);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(154, 21);
			this.cbEstado.TabIndex = 85;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(11, 197);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 13);
			this.label14.TabIndex = 84;
			this.label14.Text = "Estado";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 113);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(69, 13);
			this.label13.TabIndex = 83;
			this.label13.Text = "Fecha Renta";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(141, 110);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 82;
			// 
			// cbEmpleado
			// 
			this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEmpleado.FormattingEnabled = true;
			this.cbEmpleado.Location = new System.Drawing.Point(141, 77);
			this.cbEmpleado.Name = "cbEmpleado";
			this.cbEmpleado.Size = new System.Drawing.Size(154, 21);
			this.cbEmpleado.TabIndex = 71;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 70;
			this.label3.Text = "Cliente";
			// 
			// cbVehiculo
			// 
			this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbVehiculo.FormattingEnabled = true;
			this.cbVehiculo.Location = new System.Drawing.Point(141, 50);
			this.cbVehiculo.Name = "cbVehiculo";
			this.cbVehiculo.Size = new System.Drawing.Size(154, 21);
			this.cbVehiculo.TabIndex = 69;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 68;
			this.label2.Text = "Vehículo";
			// 
			// cbCliente
			// 
			this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCliente.FormattingEnabled = true;
			this.cbCliente.Location = new System.Drawing.Point(141, 23);
			this.cbCliente.Name = "cbCliente";
			this.cbCliente.Size = new System.Drawing.Size(154, 21);
			this.cbCliente.TabIndex = 67;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 66;
			this.label1.Text = "Empleado";
			// 
			// tbxMontoDia
			// 
			this.tbxMontoDia.Location = new System.Drawing.Point(142, 137);
			this.tbxMontoDia.Name = "tbxMontoDia";
			this.tbxMontoDia.Size = new System.Drawing.Size(153, 20);
			this.tbxMontoDia.TabIndex = 99;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 13);
			this.label7.TabIndex = 100;
			this.label7.Text = "Monto por Día";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 166);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 13);
			this.label8.TabIndex = 102;
			this.label8.Text = "Cantidad de Días";
			// 
			// tbxCantidadDias
			// 
			this.tbxCantidadDias.Location = new System.Drawing.Point(142, 163);
			this.tbxCantidadDias.Name = "tbxCantidadDias";
			this.tbxCantidadDias.Size = new System.Drawing.Size(153, 20);
			this.tbxCantidadDias.TabIndex = 101;
			// 
			// porCliente
			// 
			this.porCliente.Location = new System.Drawing.Point(366, 25);
			this.porCliente.Name = "porCliente";
			this.porCliente.Size = new System.Drawing.Size(124, 20);
			this.porCliente.TabIndex = 103;
			// 
			// porVehiculo
			// 
			this.porVehiculo.Location = new System.Drawing.Point(508, 25);
			this.porVehiculo.Name = "porVehiculo";
			this.porVehiculo.Size = new System.Drawing.Size(124, 20);
			this.porVehiculo.TabIndex = 104;
			// 
			// porFecha
			// 
			this.porFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.porFecha.Location = new System.Drawing.Point(639, 25);
			this.porFecha.Name = "porFecha";
			this.porFecha.Size = new System.Drawing.Size(96, 20);
			this.porFecha.TabIndex = 105;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(365, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 106;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(366, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 107;
			this.label4.Text = "Cliente";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(505, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 108;
			this.label5.Text = "Vehiculo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(636, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 109;
			this.label6.Text = "Hasta";
			// 
			// FechaHasta
			// 
			this.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.FechaHasta.Location = new System.Drawing.Point(741, 25);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.Size = new System.Drawing.Size(96, 20);
			this.FechaHasta.TabIndex = 110;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(738, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 111;
			this.label9.Text = "Desde";
			// 
			// Renta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 450);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.FechaHasta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.porFecha);
			this.Controls.Add(this.porVehiculo);
			this.Controls.Add(this.porCliente);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbxCantidadDias);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbxMontoDia);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbEstado);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.cbEmpleado);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbVehiculo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbCliente);
			this.Controls.Add(this.label1);
			this.Name = "Renta";
			this.Text = "Renta";
			this.Load += new System.EventHandler(this.Renta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cbEmpleado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbVehiculo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxMontoDia;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbxCantidadDias;
		private System.Windows.Forms.TextBox porCliente;
		private System.Windows.Forms.TextBox porVehiculo;
		private System.Windows.Forms.DateTimePicker porFecha;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker FechaHasta;
		private System.Windows.Forms.Label label9;
	}
}