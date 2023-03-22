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
using TransformacionesBidimensionales.Class;

namespace TransformacionesBidimensionales
{
    public partial class Graficadora : Form
    {
        private GraficarPuntos p;
        private NodoPunto punto;
        private List<NodoPunto> puntosRotados;
        private List<NodoPunto> puntosOriginales;
        public Graficadora()
        {
            InitializeComponent();
            //this.color = colorDialog1.Color;
            p = new GraficarPuntos(pictureBoxGrafica, colorDialog1.Color);
            this.puntosOriginales = new List<NodoPunto> { };
            //Para activar el tooltip
            this.toolTipEscribe.SetToolTip(this.TxtBxX, "Escribe la coodenada en x");
            this.toolTipEscribe.SetToolTip(this.TxtBxY, "Escribe la coodenada en y");
            //this.toolTipEscribeX.SetToolTip(this.TxtBxX, "Escribe la coodenada en x");
        }

        public int escala = 10;
        private void pictureBoxGrafica_Paint(object sender, PaintEventArgs e)
        {
            //Definiendo el nuevo centro del pictureBox
            this.xcentro = pictureBoxGrafica.Width / 2;
            this.ycentro = pictureBoxGrafica.Height / 2;
            Pen lapiz = new Pen(Color.Black, 2);

            e.Graphics.TranslateTransform(this.xcentro, this.ycentro);
            //e.Graphics.
            //
            //e.Graphics.ScaleTransform(1, -1);

            //Dibujando ejes
            e.Graphics.DrawLine(lapiz, -this.xcentro, 0, this.xcentro * 2, 0);
            e.Graphics.DrawLine(lapiz, 0, -this.ycentro, 0, this.xcentro * 2);

            //Dibujando regla Regla
            lapiz.Width = 1;
            for (int i = 0; i < this.xcentro; i += escala)
            {
                e.Graphics.DrawLine(lapiz, i, 3, i, -3);
                e.Graphics.DrawLine(lapiz, -i, 3, -i, -3);
            }
            for (int i = 0; i < this.ycentro; i += escala)
            {
                e.Graphics.DrawLine(lapiz, 3, i, -3, i);
                e.Graphics.DrawLine(lapiz, 3, -i, -3, -i);
            }


            this.puntosOriginales = new List<NodoPunto> { };
            this.puntosRotados = new List<NodoPunto> { };
            if (this.puntosOriginales.Count != 0)
            {
                BtnGraficar_Click(sender, e);
            }
            if (this.puntosRotados.Count != 0)
            {
                BtnRotar_Click(sender, e);
            }



        }
        //Esta funcion no me funciona ;(
        private void Graficadora_SizeChanged(object sender, EventArgs e)
        {
            //Redibujando lo que haya en el picturebox}
            this.puntosOriginales = new List<NodoPunto> { };
            this.puntosRotados = new List<NodoPunto> { };
            if (this.puntosOriginales.Count != 0)
            {
                BtnGraficar_Click(sender, e);
            }
            if (this.puntosRotados.Count != 0)
            {
                BtnRotar_Click(sender, e);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.color = colorDialog1.Color;
            BtnColor.BackColor = this.color;
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            //Pasar como parametro el color :)

            try
            {
                double x1 = Convert.ToDouble(TxtBxX.Text.ToString());
                double y1 = Convert.ToDouble(TxtBxY.Text.ToString());
                for (int i = 0; i < puntosOriginales.Count; i++)
                {
                    p.dibujar(puntosOriginales[i].GetColor(), puntosOriginales[i].GetX(), puntosOriginales[i].GetY(), this.xcentro, this.ycentro);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se introdujo un tipo de dato correcto: " + ex.Message, "Una acción erronea ha ocurrido");
            }

        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = TxtBxNombre.Text.ToString();
                if (nombre.Length == 0)
                    MessageBox.Show("Introduce un nombre al punto", "Una acción erronea ha ocurrido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    this.punto = new NodoPunto(nombre, Convert.ToInt32(this.TxtBxX.Text), Convert.ToInt32(this.TxtBxY.Text), this.color);
                    this.puntosOriginales.Add(this.punto);


                    //this.dataGridView1.Rows.Add(this.puntosRotados);
                    object[] point = { this.punto.GetNombre(), this.punto.GetX(), this.punto.GetY() };
                    //object []point = { this.punto.GetNombre() , this.punto.GetY() , this.punto.GetY() , this.punto.GetColor().ToKnownColor() };

                    ///Hacer condicion si agrega un nuevo punto con las mismas coordenadas
                    ///
                    //this.DataGridViewPuntos.Rows.
                    //Añadiendo valores del punto a una nueva fila y cambiando de color a la celda de color

                    this.DataGridViewPuntos.Rows.Add(point);
                    int TamR = this.DataGridViewPuntos.Rows.Count;
                    int TamC = this.DataGridViewPuntos.Rows[TamR - 1].Cells.Count;
                    this.DataGridViewPuntos.DefaultCellStyle.ForeColor = Color.Black;
                    this.DataGridViewPuntos.Rows[TamR - 2].Cells[TamC - 1].Style.BackColor = this.color;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se introdujo un tipo de dato correcto: " + ex.Message, "Una acción erronea ha ocurrido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void BtnRotar_Click(object sender, EventArgs e)
        {
            //Llamada a la función rotar
            //double ang = Convert.ToDouble(TxtBxGrados.Text);
            double ang = 90;
            Transformaciones t = new Transformaciones(this.puntosOriginales);
            double[][] m = t.Rotar(ang);
            this.puntosRotados = new List<NodoPunto> { };
            for (int i = 0; i < m[0].Length; i++)
            {
                //Creando los nodos con los valores del punto

                punto = new NodoPunto(this.puntosOriginales[i].GetNombre(), m[0][i], m[1][i], t.Colores[i]);
                //Agregarndo a la lista de puntos 
                this.puntosRotados.Add(this.punto);
                //Haciendo un objeto para pasarlo a las Rows
                object[] point = { this.punto.GetNombre(), ang,this.punto.GetX(), this.punto.GetY() };
                this.dataGridViewRotaciones.Rows.Add(point);
            }



            //this.dataGridView1.Rows.Add(this.puntosRotados);
            //object []point = { this.punto.GetNombre() , this.punto.GetY() , this.punto.GetY() , this.punto.GetColor().ToKnownColor() };


            ///Hacer condicion si agrega un nuevo punto con las mismas coordenadas
            ///


            //this.DataGridViewPuntos.Rows.
            //Añadiendo valores del punto a una nueva fila y cambiando de color a la celda de color

            int TamR = this.dataGridViewRotaciones.Rows.Count;
            int TamC = this.dataGridViewRotaciones.Rows[TamR - 1].Cells.Count;
            this.dataGridViewRotaciones.DefaultCellStyle.ForeColor = Color.Black;
            //Colocando los colores de los puntos en la celda y dibujando los nuevos puntos
            for(int i=0; i<t.Colores.Length; i++)
            {
            this.dataGridViewRotaciones.Rows[TamR - 2].Cells[TamC - 1].Style.BackColor = t.Colores[i];
            p.dibujar(t.Colores[i], m[0][i], m[1][i], this.xcentro, this.ycentro);
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
