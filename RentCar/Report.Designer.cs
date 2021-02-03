
namespace RentCar
{
	partial class Report
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
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.rentaClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.porVehiculo = new System.Windows.Forms.TextBox();
			this.porCliente = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.FechaHasta = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.porFecha = new System.Windows.Forms.DateTimePicker();
			this.button2 = new System.Windows.Forms.Button();
			this.filtroFecha = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.rentaClassBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			reportDataSource2.Name = "DataSet";
			reportDataSource2.Value = this.rentaClassBindingSource1;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "RentCar.Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(-1, 55);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(974, 392);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// rentaClassBindingSource1
			// 
			this.rentaClassBindingSource1.DataSource = typeof(RentCar.Renta.RentaClass);
			this.rentaClassBindingSource1.CurrentChanged += new System.EventHandler(this.rentaClassBindingSource1_CurrentChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(151, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 115;
			this.label5.Text = "Vehiculo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 114;
			this.label4.Text = "Cliente";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(637, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 113;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// porVehiculo
			// 
			this.porVehiculo.Location = new System.Drawing.Point(154, 29);
			this.porVehiculo.Name = "porVehiculo";
			this.porVehiculo.Size = new System.Drawing.Size(124, 20);
			this.porVehiculo.TabIndex = 111;
			// 
			// porCliente
			// 
			this.porCliente.Location = new System.Drawing.Point(12, 29);
			this.porCliente.Name = "porCliente";
			this.porCliente.Size = new System.Drawing.Size(124, 20);
			this.porCliente.TabIndex = 110;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(390, 10);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 119;
			this.label9.Text = "Desde";
			// 
			// FechaHasta
			// 
			this.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.FechaHasta.Location = new System.Drawing.Point(393, 29);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.Size = new System.Drawing.Size(96, 20);
			this.FechaHasta.TabIndex = 118;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(288, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 117;
			this.label6.Text = "Hasta";
			// 
			// porFecha
			// 
			this.porFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.porFecha.Location = new System.Drawing.Point(291, 29);
			this.porFecha.Name = "porFecha";
			this.porFecha.Size = new System.Drawing.Size(96, 20);
			this.porFecha.TabIndex = 116;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(718, 25);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 120;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// filtroFecha
			// 
			this.filtroFecha.AutoSize = true;
			this.filtroFecha.Location = new System.Drawing.Point(496, 29);
			this.filtroFecha.Name = "filtroFecha";
			this.filtroFecha.Size = new System.Drawing.Size(135, 17);
			this.filtroFecha.TabIndex = 121;
			this.filtroFecha.Text = "Activar el fitro de fecha";
			this.filtroFecha.UseVisualStyleBackColor = true;
			this.filtroFecha.CheckedChanged += new System.EventHandler(this.filtroFecha_CheckedChanged);
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 450);
			this.Controls.Add(this.filtroFecha);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.FechaHasta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.porFecha);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.porVehiculo);
			this.Controls.Add(this.porCliente);
			this.Controls.Add(this.reportViewer1);
			this.Name = "Report";
			this.Text = "Report";
			this.Load += new System.EventHandler(this.Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.rentaClassBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource rentaClassBindingSource1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox porVehiculo;
		private System.Windows.Forms.TextBox porCliente;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker FechaHasta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker porFecha;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox filtroFecha;
	}
}