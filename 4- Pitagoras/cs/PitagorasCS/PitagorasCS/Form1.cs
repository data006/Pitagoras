using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PitagorasCS
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		Double a, b, c;
		Boolean puntoA, puntoB, puntoC;

		private void txtC_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((this.txtC.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".") & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (!this.txtC.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".");
			}
			else if (!this.txtC.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (this.txtC.Text.Contains(".") & this.txtC.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}
		}

		private void txtB_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((this.txtB.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".") & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (!this.txtB.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".");
			}
			else if (!this.txtB.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (this.txtB.Text.Contains(".") & this.txtB.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}
		}

		Boolean tresLados = true;


		private void txtA_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((this.txtA.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".") & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (!this.txtA.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".");
			}
			else if (!this.txtA.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (this.txtA.Text.Contains(".") & this.txtA.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}
		}


		private void btnCalcular_Click(object sender, EventArgs e)
		{

			//Cuando no introduce ningun lado

		if ((txtA.Text == "" || txtA.Text == ".") && (txtB.Text == "" || txtB.Text == ".") && (txtC.Text == "" || txtC.Text == "."))
			{
				MessageBox.Show("Se requieren dos lados para calcular el tercero");
				tresLados = false;
			}
			
			//Cuando solo introduce un lado

		else if((txtA.Text != "" || txtA.Text != ".") && (txtB.Text == "" || txtB.Text == ".") && (txtC.Text == "" || txtC.Text == "."))
			{
				MessageBox.Show("Se requieren dos lados para calcular el tercero");
				tresLados = false;
			}
		else if((txtA.Text == "" || txtA.Text == ".") &&(txtB.Text != "" || txtB.Text != ".") &&(txtC.Text == "" || txtC.Text == "."))
			{
				MessageBox.Show("Se requieren dos lados para calcular el tercero");
				tresLados = false;
			}
		else if((txtA.Text == "" || txtA.Text == ".") &&(txtB.Text == "" || txtB.Text == ".") &&(txtC.Text != "" || txtC.Text != "."))
			{
				MessageBox.Show("Se requieren dos lados para calcular el tercero");
				tresLados = false;
			}
			//Cuando introduces dos lados
		else
			{

				//Cuando metes a y b
				if((txtA.Text != "" || txtA.Text != ".") &&(txtB.Text != "" || txtB.Text != ".") &&(txtC.Text == "" || txtC.Text == "."))
				{
					a = Convert.ToDouble(txtA.Text);
					b = Convert.ToDouble(txtB.Text);

					//Cuando algun lado vale 0
					if((a <= 0) ||(b <= 0))
					{
						MessageBox.Show("Ningun lado puede valer cero");
						tresLados = false;
					}
					else
					{
						c = Math.Sqrt((Math.Pow(a , 2) + (Math.Pow(b , 2))));

						lblHip.Text = "c = " + c;
						lblCatA.Text = "a = " + a;
						lblCatB.Text = "b = " + b;

						lblFormula.Text = "c = √ ( ( " + a + " ^ 2 ) + ( " + b + " ^ 2 ) ) = " + c;

						puntoA = false;
						puntoB = false;
						puntoC = false;

						tresLados = false;
					}
				}

				//Cuando metes a y c
				if((txtA.Text != "" || txtA.Text != ".") &&(txtB.Text == "" || txtB.Text == ".") &&(txtC.Text != "" || txtC.Text != "."))
				{
					a = Convert.ToDouble(txtA.Text);
					c = Convert.ToDouble(txtC.Text);

					//Cuando algun lado vale 0
					if((a <= 0) ||(c <= 0))
					{
						MessageBox.Show("Ningun lado puede valer cero");
						tresLados = false;
					}
					else if (a >= c)
					{
						MessageBox.Show("Ningun cateto puede valer mas o igual a la hipotenusa");
						tresLados = false;
					}
					else
					{
						b = Math.Sqrt((Math.Pow(c, 2) - (Math.Pow(a, 2))));

						lblHip.Text = "c = " + c;
						lblCatA.Text = "a = " + a;
						lblCatB.Text = "b = " + b;

						lblFormula.Text = "b = √ ( ( " + c + " ^ 2 ) + ( " + a + " ^ 2 ) ) = " + b;

						puntoA = false;
						puntoB = false;
						puntoC = false;

						tresLados = false;
					}
				}


				//Cuando metes b y c
				if((txtA.Text == "" || txtA.Text == ".") &&(txtB.Text != "" || txtB.Text != ".") &&(txtC.Text != "" || txtC.Text != "."))
				{
					b = Convert.ToDouble(txtB.Text);
					c = Convert.ToDouble(txtC.Text);

					//Cuando algun lado vale 0
					if((b <= 0) ||(c <= 0))
					{
						MessageBox.Show("Ningun lado puede valer cero");
						tresLados = false;
					}
					else if(b >= c)
					{
						MessageBox.Show("Ningun cateto puede valer mas o igual a la hipotenusa");
						tresLados = false;
					}
					else
					{
						a = Math.Sqrt((Math.Pow(c, 2) - (Math.Pow(b, 2))));

						lblHip.Text = "c = " + c;
						lblCatA.Text = "a = " + a;
						lblCatB.Text = "b = " + b;

						lblFormula.Text = "a = √ ( ( " + c + " ^ 2 ) + ( " + b + " ^ 2 ) ) = " + a;

						puntoA = false;
						puntoB = false;
						puntoC = false;

						tresLados = false;
					}
				}

			}

			txtA.Text = "";

			txtB.Text = "";

			txtC.Text = "";


			puntoA = false;

			puntoB = false;

			puntoC = false;


			tresLados = false;




		}
	}
}
