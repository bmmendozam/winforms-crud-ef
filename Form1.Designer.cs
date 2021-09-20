
namespace winforms_crud_ef
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewM = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtid = new System.Windows.Forms.TextBox();
			this.txtnombres = new System.Windows.Forms.TextBox();
			this.txtedad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtgenero = new System.Windows.Forms.TextBox();
			this.txtciudad = new System.Windows.Forms.TextBox();
			this.btngrabar = new System.Windows.Forms.Button();
			this.btnnuevo = new System.Windows.Forms.Button();
			this.btnborrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewM
			// 
			this.dataGridViewM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridViewM.Location = new System.Drawing.Point(34, 204);
			this.dataGridViewM.Name = "dataGridViewM";
			this.dataGridViewM.Size = new System.Drawing.Size(446, 145);
			this.dataGridViewM.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Name";
			this.Column2.HeaderText = "Nombres y";
			this.Column2.Name = "Column2";
			// 
			// cmbGender
			// 
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
			this.cmbGender.Location = new System.Drawing.Point(501, 63);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(121, 21);
			this.cmbGender.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(34, 378);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(664, 217);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// txtid
			// 
			this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtid.Location = new System.Drawing.Point(179, 35);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(54, 21);
			this.txtid.TabIndex = 3;
			// 
			// txtnombres
			// 
			this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombres.Location = new System.Drawing.Point(179, 62);
			this.txtnombres.Name = "txtnombres";
			this.txtnombres.Size = new System.Drawing.Size(194, 21);
			this.txtnombres.TabIndex = 4;
			// 
			// txtedad
			// 
			this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtedad.Location = new System.Drawing.Point(179, 88);
			this.txtedad.Name = "txtedad";
			this.txtedad.Size = new System.Drawing.Size(54, 21);
			this.txtedad.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Apellidos y Nombres";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Edad";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ciudad";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Genero";
			// 
			// txtgenero
			// 
			this.txtgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtgenero.Location = new System.Drawing.Point(179, 155);
			this.txtgenero.Name = "txtgenero";
			this.txtgenero.Size = new System.Drawing.Size(153, 21);
			this.txtgenero.TabIndex = 11;
			// 
			// txtciudad
			// 
			this.txtciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtciudad.Location = new System.Drawing.Point(179, 120);
			this.txtciudad.Name = "txtciudad";
			this.txtciudad.Size = new System.Drawing.Size(177, 21);
			this.txtciudad.TabIndex = 12;
			// 
			// btngrabar
			// 
			this.btngrabar.Location = new System.Drawing.Point(523, 237);
			this.btngrabar.Name = "btngrabar";
			this.btngrabar.Size = new System.Drawing.Size(87, 27);
			this.btngrabar.TabIndex = 13;
			this.btngrabar.Text = "Grabar";
			this.btngrabar.UseVisualStyleBackColor = true;
			this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(523, 204);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(87, 27);
			this.btnnuevo.TabIndex = 14;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
			// 
			// btnborrar
			// 
			this.btnborrar.Location = new System.Drawing.Point(523, 270);
			this.btnborrar.Name = "btnborrar";
			this.btnborrar.Size = new System.Drawing.Size(87, 27);
			this.btnborrar.TabIndex = 15;
			this.btnborrar.Text = "Borrar";
			this.btnborrar.UseVisualStyleBackColor = true;
			this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 629);
			this.Controls.Add(this.btnborrar);
			this.Controls.Add(this.btnnuevo);
			this.Controls.Add(this.btngrabar);
			this.Controls.Add(this.txtciudad);
			this.Controls.Add(this.txtgenero);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtedad);
			this.Controls.Add(this.txtnombres);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.dataGridViewM);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewM;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.TextBox txtnombres;
		private System.Windows.Forms.TextBox txtedad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtgenero;
		private System.Windows.Forms.TextBox txtciudad;
		private System.Windows.Forms.Button btngrabar;
		private System.Windows.Forms.Button btnnuevo;
		private System.Windows.Forms.Button btnborrar;
	}
}

