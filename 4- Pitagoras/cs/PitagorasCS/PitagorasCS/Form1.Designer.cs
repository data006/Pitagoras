namespace PitagorasCS
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
			this.lblLadoA = new System.Windows.Forms.Label();
			this.lblLadoB = new System.Windows.Forms.Label();
			this.lblLadoC = new System.Windows.Forms.Label();
			this.lblFormula = new System.Windows.Forms.Label();
			this.lblCatB = new System.Windows.Forms.Label();
			this.lblCatA = new System.Windows.Forms.Label();
			this.lblHip = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.lblc = new System.Windows.Forms.Label();
			this.lblb = new System.Windows.Forms.Label();
			this.lbla = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.picTriangulo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLadoA
			// 
			this.lblLadoA.AutoSize = true;
			this.lblLadoA.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLadoA.Location = new System.Drawing.Point(185, 420);
			this.lblLadoA.Name = "lblLadoA";
			this.lblLadoA.Size = new System.Drawing.Size(28, 32);
			this.lblLadoA.TabIndex = 33;
			this.lblLadoA.Text = "a";
			// 
			// lblLadoB
			// 
			this.lblLadoB.AutoSize = true;
			this.lblLadoB.BackColor = System.Drawing.SystemColors.Info;
			this.lblLadoB.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLadoB.Location = new System.Drawing.Point(100, 366);
			this.lblLadoB.Name = "lblLadoB";
			this.lblLadoB.Size = new System.Drawing.Size(25, 32);
			this.lblLadoB.TabIndex = 32;
			this.lblLadoB.Text = "b";
			// 
			// lblLadoC
			// 
			this.lblLadoC.AutoSize = true;
			this.lblLadoC.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblLadoC.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLadoC.Location = new System.Drawing.Point(235, 287);
			this.lblLadoC.Name = "lblLadoC";
			this.lblLadoC.Size = new System.Drawing.Size(24, 32);
			this.lblLadoC.TabIndex = 31;
			this.lblLadoC.Text = "c";
			// 
			// lblFormula
			// 
			this.lblFormula.AutoSize = true;
			this.lblFormula.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFormula.Location = new System.Drawing.Point(542, 80);
			this.lblFormula.Name = "lblFormula";
			this.lblFormula.Size = new System.Drawing.Size(211, 25);
			this.lblFormula.TabIndex = 30;
			this.lblFormula.Text = "c = √ ( ( a ^ 2 ) + ( b ^ 2 ) )";
			// 
			// lblCatB
			// 
			this.lblCatB.AutoSize = true;
			this.lblCatB.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCatB.Location = new System.Drawing.Point(385, 298);
			this.lblCatB.Name = "lblCatB";
			this.lblCatB.Size = new System.Drawing.Size(48, 34);
			this.lblCatB.TabIndex = 29;
			this.lblCatB.Text = "b =";
			// 
			// lblCatA
			// 
			this.lblCatA.AutoSize = true;
			this.lblCatA.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCatA.Location = new System.Drawing.Point(385, 234);
			this.lblCatA.Name = "lblCatA";
			this.lblCatA.Size = new System.Drawing.Size(48, 34);
			this.lblCatA.TabIndex = 28;
			this.lblCatA.Text = "a =";
			// 
			// lblHip
			// 
			this.lblHip.AutoSize = true;
			this.lblHip.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHip.Location = new System.Drawing.Point(385, 354);
			this.lblHip.Name = "lblHip";
			this.lblHip.Size = new System.Drawing.Size(47, 34);
			this.lblHip.TabIndex = 27;
			this.lblHip.Text = "c =";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(131, 116);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(0, 13);
			this.Label1.TabIndex = 26;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(393, 148);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(88, 44);
			this.btnCalcular.TabIndex = 25;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(342, 122);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(194, 20);
			this.txtC.TabIndex = 24;
			this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(342, 85);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(194, 20);
			this.txtB.TabIndex = 23;
			this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(342, 47);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(194, 20);
			this.txtA.TabIndex = 22;
			this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
			// 
			// lblc
			// 
			this.lblc.AutoSize = true;
			this.lblc.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblc.Location = new System.Drawing.Point(316, 116);
			this.lblc.Name = "lblc";
			this.lblc.Size = new System.Drawing.Size(30, 32);
			this.lblc.TabIndex = 21;
			this.lblc.Text = "c:";
			// 
			// lblb
			// 
			this.lblb.AutoSize = true;
			this.lblb.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblb.Location = new System.Drawing.Point(316, 80);
			this.lblb.Name = "lblb";
			this.lblb.Size = new System.Drawing.Size(31, 32);
			this.lblb.TabIndex = 20;
			this.lblb.Text = "b:";
			// 
			// lbla
			// 
			this.lbla.AutoSize = true;
			this.lbla.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbla.Location = new System.Drawing.Point(316, 41);
			this.lbla.Name = "lbla";
			this.lbla.Size = new System.Drawing.Size(34, 32);
			this.lbla.TabIndex = 19;
			this.lbla.Text = "a:";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(235, -2);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(388, 32);
			this.lbl1.TabIndex = 18;
			this.lbl1.Text = "Ingresa dos lados para calcular el tercero";
			// 
			// picTriangulo
			// 
			this.picTriangulo.Image = global::PitagorasCS.Properties.Resources.WhatsApp_Image_2020_01_22_at_11_29_56_PM;
			this.picTriangulo.Location = new System.Drawing.Point(47, 208);
			this.picTriangulo.Name = "picTriangulo";
			this.picTriangulo.Size = new System.Drawing.Size(249, 209);
			this.picTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picTriangulo.TabIndex = 17;
			this.picTriangulo.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblLadoA);
			this.Controls.Add(this.lblLadoB);
			this.Controls.Add(this.lblLadoC);
			this.Controls.Add(this.lblFormula);
			this.Controls.Add(this.lblCatB);
			this.Controls.Add(this.lblCatA);
			this.Controls.Add(this.lblHip);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblc);
			this.Controls.Add(this.lblb);
			this.Controls.Add(this.lbla);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.picTriangulo);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblLadoA;
		internal System.Windows.Forms.Label lblLadoB;
		internal System.Windows.Forms.Label lblLadoC;
		internal System.Windows.Forms.Label lblFormula;
		internal System.Windows.Forms.Label lblCatB;
		internal System.Windows.Forms.Label lblCatA;
		internal System.Windows.Forms.Label lblHip;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnCalcular;
		internal System.Windows.Forms.TextBox txtC;
		internal System.Windows.Forms.TextBox txtB;
		internal System.Windows.Forms.TextBox txtA;
		internal System.Windows.Forms.Label lblc;
		internal System.Windows.Forms.Label lblb;
		internal System.Windows.Forms.Label lbla;
		internal System.Windows.Forms.Label lbl1;
		internal System.Windows.Forms.PictureBox picTriangulo;
	}
}

