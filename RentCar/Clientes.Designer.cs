
namespace RentCar
{
	partial class Clientes
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
			this.tbxDocumento = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxLimite = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxTarjeta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbTPersona = new System.Windows.Forms.ComboBox();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxCedula = new System.Windows.Forms.TextBox();
			this.tbxBNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btxnBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbxDocumento
			// 
			this.tbxDocumento.Location = new System.Drawing.Point(113, 56);
			this.tbxDocumento.Name = "tbxDocumento";
			this.tbxDocumento.Size = new System.Drawing.Size(100, 20);
			this.tbxDocumento.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Documento";
			// 
			// tbxNombre
			// 
			this.tbxNombre.Location = new System.Drawing.Point(113, 26);
			this.tbxNombre.Name = "tbxNombre";
			this.tbxNombre.Size = new System.Drawing.Size(100, 20);
			this.tbxNombre.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nombre";
			// 
			// tbxLimite
			// 
			this.tbxLimite.Location = new System.Drawing.Point(112, 135);
			this.tbxLimite.Name = "tbxLimite";
			this.tbxLimite.Size = new System.Drawing.Size(100, 20);
			this.tbxLimite.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Límite de crédito";
			// 
			// tbxTarjeta
			// 
			this.tbxTarjeta.Location = new System.Drawing.Point(113, 109);
			this.tbxTarjeta.Name = "tbxTarjeta";
			this.tbxTarjeta.Size = new System.Drawing.Size(100, 20);
			this.tbxTarjeta.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Tarjeta de crédito";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Tipo de persona";
			// 
			// cbTPersona
			// 
			this.cbTPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTPersona.FormattingEnabled = true;
			this.cbTPersona.Items.AddRange(new object[] {
            " ",
            "Física",
            "Jurídica"});
			this.cbTPersona.Location = new System.Drawing.Point(113, 172);
			this.cbTPersona.Name = "cbTPersona";
			this.cbTPersona.Size = new System.Drawing.Size(100, 21);
			this.cbTPersona.TabIndex = 13;
			// 
			// cbEstado
			// 
			this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
			this.cbEstado.Location = new System.Drawing.Point(113, 209);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(100, 21);
			this.cbEstado.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(24, 215);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Estado";
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(252, 361);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(109, 38);
			this.btnClear.TabIndex = 62;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(615, 361);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 38);
			this.btnDelete.TabIndex = 61;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Location = new System.Drawing.Point(491, 361);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(109, 38);
			this.btnEdit.TabIndex = 60;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(367, 361);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(109, 38);
			this.btnSave.TabIndex = 59;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(234, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(581, 283);
			this.dataGridView1.TabIndex = 58;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(110, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 12);
			this.label6.TabIndex = 63;
			this.label6.Text = "Sin guiones";
			// 
			// tbxCedula
			// 
			this.tbxCedula.Location = new System.Drawing.Point(234, 25);
			this.tbxCedula.Name = "tbxCedula";
			this.tbxCedula.Size = new System.Drawing.Size(100, 20);
			this.tbxCedula.TabIndex = 64;
			// 
			// tbxBNombre
			// 
			this.tbxBNombre.Location = new System.Drawing.Point(352, 25);
			this.tbxBNombre.Name = "tbxBNombre";
			this.tbxBNombre.Size = new System.Drawing.Size(100, 20);
			this.tbxBNombre.TabIndex = 65;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(231, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 66;
			this.label7.Text = "Cédula";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(349, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 67;
			this.label8.Text = "Nombre";
			// 
			// btxnBuscar
			// 
			this.btxnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btxnBuscar.Location = new System.Drawing.Point(458, 24);
			this.btxnBuscar.Name = "btxnBuscar";
			this.btxnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btxnBuscar.TabIndex = 68;
			this.btxnBuscar.Text = "Buscar";
			this.btxnBuscar.UseVisualStyleBackColor = true;
			this.btxnBuscar.Click += new System.EventHandler(this.btxnBuscar_Click);
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 450);
			this.Controls.Add(this.btxnBuscar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbxBNombre);
			this.Controls.Add(this.tbxCedula);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbEstado);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbTPersona);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbxLimite);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxTarjeta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbxDocumento);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxNombre);
			this.Controls.Add(this.label1);
			this.Name = "Clientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.Clientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbxDocumento;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxLimite;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxTarjeta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbTPersona;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbxCedula;
		private System.Windows.Forms.TextBox tbxBNombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btxnBuscar;
	}
}