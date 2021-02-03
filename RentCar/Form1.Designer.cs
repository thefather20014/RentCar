
namespace RentCar
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLog = new System.Windows.Forms.Button();
			this.imgClose = new System.Windows.Forms.PictureBox();
			this.imgHide = new System.Windows.Forms.PictureBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgHide)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 406);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 258);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 27);
			this.label2.TabIndex = 0;
			this.label2.Text = "RENT CAR INC.";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(66, 111);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(165, 124);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(910, 406);
			this.shapeContainer1.TabIndex = 1;
			this.shapeContainer1.TabStop = false;
			// 
			// lineShape2
			// 
			this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
			this.lineShape2.Enabled = false;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 349;
			this.lineShape2.X2 = 756;
			this.lineShape2.Y1 = 172;
			this.lineShape2.Y2 = 172;
			// 
			// lineShape1
			// 
			this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
			this.lineShape1.Enabled = false;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 349;
			this.lineShape1.X2 = 756;
			this.lineShape1.Y1 = 111;
			this.lineShape1.Y2 = 111;
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.ForeColor = System.Drawing.Color.DimGray;
			this.txtPass.Location = new System.Drawing.Point(349, 150);
			this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(408, 20);
			this.txtPass.TabIndex = 9;
			this.txtPass.Text = "CONTRASEÑA";
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(553, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 33);
			this.label1.TabIndex = 6;
			this.label1.Text = "LOGIN";
			// 
			// btnLog
			// 
			this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLog.FlatAppearance.BorderSize = 0;
			this.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLog.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnLog.Location = new System.Drawing.Point(349, 258);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(408, 40);
			this.btnLog.TabIndex = 3;
			this.btnLog.Text = "Log In";
			this.btnLog.UseVisualStyleBackColor = false;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// imgClose
			// 
			this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
			this.imgClose.Location = new System.Drawing.Point(892, 3);
			this.imgClose.Name = "imgClose";
			this.imgClose.Size = new System.Drawing.Size(15, 15);
			this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgClose.TabIndex = 6;
			this.imgClose.TabStop = false;
			this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
			// 
			// imgHide
			// 
			this.imgHide.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgHide.Image = ((System.Drawing.Image)(resources.GetObject("imgHide.Image")));
			this.imgHide.Location = new System.Drawing.Point(861, 3);
			this.imgHide.Name = "imgHide";
			this.imgHide.Size = new System.Drawing.Size(15, 15);
			this.imgHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgHide.TabIndex = 7;
			this.imgHide.TabStop = false;
			this.imgHide.Click += new System.EventHandler(this.imgHide_Click);
			// 
			// txtUser
			// 
			this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.ForeColor = System.Drawing.Color.DimGray;
			this.txtUser.Location = new System.Drawing.Point(349, 88);
			this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(408, 20);
			this.txtUser.TabIndex = 8;
			this.txtUser.Text = "USUARIO";
			this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
			this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(910, 406);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.imgHide);
			this.Controls.Add(this.imgClose);
			this.Controls.Add(this.btnLog);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.shapeContainer1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "USUARIO";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgHide)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.PictureBox imgClose;
		private System.Windows.Forms.PictureBox imgHide;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUser;
	}
}

