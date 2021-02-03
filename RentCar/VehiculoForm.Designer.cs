
namespace RentCar
{
	partial class VehiculoForm
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
			this.label9 = new System.Windows.Forms.Label();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.tbxPlaca = new System.Windows.Forms.TextBox();
			this.tbxMotor = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxChasis = new System.Windows.Forms.TextBox();
			this.labelDescri = new System.Windows.Forms.Label();
			this.cbTCombustible = new System.Windows.Forms.ComboBox();
			this.cbTVehiculo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbModelo = new System.Windows.Forms.ComboBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cbMarca = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxDescripcion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblMarca = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btxnBuscar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.labl = new System.Windows.Forms.Label();
			this.tbxModelo = new System.Windows.Forms.TextBox();
			this.tbxBMarca = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(17, 376);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 67;
			this.label9.Text = "Estado";
			// 
			// cbEstado
			// 
			this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "Rentado",
            "En mantenimiento",
            "Inactivo"});
			this.cbEstado.Location = new System.Drawing.Point(122, 373);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(100, 21);
			this.cbEstado.TabIndex = 66;
			// 
			// tbxPlaca
			// 
			this.tbxPlaca.Location = new System.Drawing.Point(122, 347);
			this.tbxPlaca.Name = "tbxPlaca";
			this.tbxPlaca.Size = new System.Drawing.Size(100, 20);
			this.tbxPlaca.TabIndex = 65;
			// 
			// tbxMotor
			// 
			this.tbxMotor.Location = new System.Drawing.Point(122, 314);
			this.tbxMotor.Name = "tbxMotor";
			this.tbxMotor.Size = new System.Drawing.Size(100, 20);
			this.tbxMotor.TabIndex = 64;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(17, 350);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 63;
			this.label8.Text = "No. Placa";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(17, 317);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 62;
			this.label7.Text = "No. Motor";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 283);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 61;
			this.label6.Text = "No. Chasis";
			// 
			// tbxChasis
			// 
			this.tbxChasis.Location = new System.Drawing.Point(122, 280);
			this.tbxChasis.Name = "tbxChasis";
			this.tbxChasis.Size = new System.Drawing.Size(100, 20);
			this.tbxChasis.TabIndex = 60;
			// 
			// labelDescri
			// 
			this.labelDescri.AutoSize = true;
			this.labelDescri.Location = new System.Drawing.Point(17, 240);
			this.labelDescri.Name = "labelDescri";
			this.labelDescri.Size = new System.Drawing.Size(63, 13);
			this.labelDescri.TabIndex = 59;
			this.labelDescri.Text = "Descripción";
			// 
			// cbTCombustible
			// 
			this.cbTCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTCombustible.FormattingEnabled = true;
			this.cbTCombustible.Location = new System.Drawing.Point(122, 186);
			this.cbTCombustible.Name = "cbTCombustible";
			this.cbTCombustible.Size = new System.Drawing.Size(100, 21);
			this.cbTCombustible.TabIndex = 57;
			// 
			// cbTVehiculo
			// 
			this.cbTVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTVehiculo.FormattingEnabled = true;
			this.cbTVehiculo.Location = new System.Drawing.Point(122, 150);
			this.cbTVehiculo.Name = "cbTVehiculo";
			this.cbTVehiculo.Size = new System.Drawing.Size(100, 21);
			this.cbTVehiculo.TabIndex = 56;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 55;
			this.label2.Text = "Tipo de Vehículo";
			// 
			// cbModelo
			// 
			this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbModelo.FormattingEnabled = true;
			this.cbModelo.Location = new System.Drawing.Point(122, 86);
			this.cbModelo.Name = "cbModelo";
			this.cbModelo.Size = new System.Drawing.Size(100, 21);
			this.cbModelo.TabIndex = 54;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(327, 365);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(109, 38);
			this.btnClear.TabIndex = 53;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(237, 55);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(609, 291);
			this.dataGridView1.TabIndex = 52;
			// 
			// cbMarca
			// 
			this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMarca.FormattingEnabled = true;
			this.cbMarca.Location = new System.Drawing.Point(122, 50);
			this.cbMarca.Name = "cbMarca";
			this.cbMarca.Size = new System.Drawing.Size(100, 21);
			this.cbMarca.TabIndex = 51;
			this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
			this.cbMarca.SelectedValueChanged += new System.EventHandler(this.cbMarca_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 50;
			this.label3.Text = "Módelo";
			// 
			// tbxDescripcion
			// 
			this.tbxDescripcion.Location = new System.Drawing.Point(122, 222);
			this.tbxDescripcion.Multiline = true;
			this.tbxDescripcion.Name = "tbxDescripcion";
			this.tbxDescripcion.Size = new System.Drawing.Size(100, 52);
			this.tbxDescripcion.TabIndex = 49;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Marca";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(690, 365);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 38);
			this.btnDelete.TabIndex = 47;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Location = new System.Drawing.Point(566, 365);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(109, 38);
			this.btnEdit.TabIndex = 46;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(442, 365);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(109, 38);
			this.btnSave.TabIndex = 45;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.ForeColor = System.Drawing.Color.Red;
			this.lblMarca.Location = new System.Drawing.Point(22, 121);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(0, 13);
			this.lblMarca.TabIndex = 68;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 13);
			this.label4.TabIndex = 69;
			this.label4.Text = "Tipo de Combustible";
			// 
			// btxnBuscar
			// 
			this.btxnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btxnBuscar.Location = new System.Drawing.Point(461, 24);
			this.btxnBuscar.Name = "btxnBuscar";
			this.btxnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btxnBuscar.TabIndex = 78;
			this.btxnBuscar.Text = "Buscar";
			this.btxnBuscar.UseVisualStyleBackColor = true;
			this.btxnBuscar.Click += new System.EventHandler(this.btxnBuscar_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(352, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(50, 13);
			this.label10.TabIndex = 77;
			this.label10.Text = "Vehículo";
			// 
			// labl
			// 
			this.labl.AutoSize = true;
			this.labl.Location = new System.Drawing.Point(234, 9);
			this.labl.Name = "labl";
			this.labl.Size = new System.Drawing.Size(37, 13);
			this.labl.TabIndex = 76;
			this.labl.Text = "Marca";
			// 
			// tbxModelo
			// 
			this.tbxModelo.Location = new System.Drawing.Point(355, 25);
			this.tbxModelo.Name = "tbxModelo";
			this.tbxModelo.Size = new System.Drawing.Size(100, 20);
			this.tbxModelo.TabIndex = 75;
			// 
			// tbxBMarca
			// 
			this.tbxBMarca.Location = new System.Drawing.Point(237, 25);
			this.tbxBMarca.Name = "tbxBMarca";
			this.tbxBMarca.Size = new System.Drawing.Size(100, 20);
			this.tbxBMarca.TabIndex = 74;
			// 
			// VehiculoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 450);
			this.Controls.Add(this.btxnBuscar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.labl);
			this.Controls.Add(this.tbxModelo);
			this.Controls.Add(this.tbxBMarca);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbEstado);
			this.Controls.Add(this.tbxPlaca);
			this.Controls.Add(this.tbxMotor);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbxChasis);
			this.Controls.Add(this.labelDescri);
			this.Controls.Add(this.cbTCombustible);
			this.Controls.Add(this.cbTVehiculo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbModelo);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbMarca);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxDescripcion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSave);
			this.Name = "VehiculoForm";
			this.Text = "VehiculoForm";
			this.Load += new System.EventHandler(this.VehiculoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.TextBox tbxPlaca;
		private System.Windows.Forms.TextBox tbxMotor;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbxChasis;
		private System.Windows.Forms.Label labelDescri;
		private System.Windows.Forms.ComboBox cbTCombustible;
		private System.Windows.Forms.ComboBox cbTVehiculo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbModelo;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cbMarca;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxDescripcion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btxnBuscar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labl;
		private System.Windows.Forms.TextBox tbxModelo;
		private System.Windows.Forms.TextBox tbxBMarca;
	}
}