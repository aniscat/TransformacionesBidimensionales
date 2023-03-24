using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformacionesBidimensionales.Class
{
    public class GraficarPuntos
    {
        private Pen lapiz;
        private Graphics vector;
        private TextBox TxtBxY, TxtBxX;
        private PictureBox pictureBoxGrafica;
        private Color color;
        private int x1, y1;
        private int xcentro, ycentro;
        private int[] x;
        private int[] y;

        private int ESCALA =10;
        public GraficarPuntos(PictureBox pictureBoxGrafica, Color color)
        {
            //    this.TxtBxX = TxtBxX;
            //    this.TxtBxY = TxtBxY;
            this.pictureBoxGrafica = pictureBoxGrafica;
            //this.color = color; 
            //x = new int[nPuntos];
            //y = new int[nPuntos];
        }
        public void dibujar(Color color, double x1, double y1, int xcentro, int ycentro)
        {
            if (color.IsEmpty) {

                lapiz = new Pen(Color.Black);
            }
            else
            {
                lapiz = new Pen(color);

            }

            //using (Font myFont = new Font("Arial", 14))
            //{
            //    vector.DrawString("Hello .NET Guide!", myFont, Brushes.Green, new Point((ESCALA * Convert.ToInt32(x1), ESCALA * -Convert.ToInt32(y1)));
            //}

            //Console.WriteLine(x1);
            vector = pictureBoxGrafica.CreateGraphics();
            vector.TranslateTransform(xcentro, ycentro);

            RectangleF rect = new RectangleF(ESCALA*Convert.ToInt32(x1),ESCALA*-Convert.ToInt32(y1), 3F, 3F);
            //RectangleF rect = new RectangleF(10, 10, 10F, 100F);
            vector.DrawEllipse(lapiz, rect);
            //pictureBoxGrafica.On
            //pictureBoxGrafica.Refresh();
            lapiz.Dispose();
            vector.Dispose();
        }
    }
    public class Transformaciones
    {
        //int [][]puntosRotados;
        public double[] X1, Y1;
        public double[] Xr, Yr;
        public Color [] Colores;
        public List<NodoPunto> lista;

        public Transformaciones(List<NodoPunto> lista)
        {

            this.lista = new List<NodoPunto> { };
            this.lista = lista;

            this.X1 = new double[lista.Count];
            this.Y1 = new double[lista.Count];
            this.Xr = new double[lista.Count];
            this.Yr = new double[lista.Count];
            this.Colores = new Color[lista.Count];

            for (int i = 0; i < this.lista.Count; i++)
            {
                X1[i] = this.lista[i].GetX();
                Y1[i] = this.lista[i].GetY();
                Colores[i] =this.lista[i].GetColor();
                //puntosRotados[0][i] = item.GetX();
                //puntosRotados[1][i] = item.GetY();
                //puntosRotados[2][i] = 1;

            }
            //}
            //foreach (var item in this.lista)
            //{
            //   if(item.GetX() != null)
            //    {
            //    this.X[i] = item.GetX();
            //    this.Y[i] = item.GetY();
            //    this.Colores[i] = item.GetColor();
            //    //puntosRotados[0][i] = item.GetX();
            //    //puntosRotados[1][i] = item.GetY();
            //    //puntosRotados[2][i] = 1;

            //    }
            //    i++;
            //}

        }
        public double[][] Rotar(double ang)
        {


            //double n = Math.Cos(ang);
            //double [,,]MatrizRotacion = new double[3][3] {{ n, -Math.Sin(ang),0 }, { Math.Sin(ang), Math.Cos(ang), 0 }, { 0, 0, 0 } };
            //double[] XMatrizRotaciob = { Math.Cos(ang), -Math.Sin(ang), 0, };
            for (int i = 0; i < X1.Length; i++)
            {
                double a = Math.Cos(ang);
                this.Xr[i] = (this.X1[i] * Math.Cos((Math.PI / 180) * ang) - (this.Y1[i] * Math.Sin((Math.PI / 180) * ang)));
                this.Yr[i] = (this.X1[i] * Math.Sin((Math.PI / 180) * ang) + (this.Y1[i] * Math.Cos((Math.PI / 180) * ang)));
            }
            double[][] MRot = new double[2][];

            MRot[0] = this.Xr;
            MRot[1] = this.Yr;
            return MRot;
        }


    }
    public class NodoPunto {
        private double X, Y;
        private String Nombre;
        private Color Color;
        public NodoPunto(string nombre, double x, double y,  Color color)
        {
            this.X = x;
            this.Y = y;
            this.Nombre = nombre;
            this.Color = color;
        }
        public void SetX(double x) => this.X = x;
        public void SetY(double y) => this.Y = y;
        public void SetNombre(String nombre) => this.Nombre = nombre;
        public void SetColor(Color Color) => this.Color = Color;
        public double GetX()
        {
            return this.X;
        }
        public double GetY() {
            return this.Y;
         }
        public String GetNombre()
        {
            return this.Nombre;
        }
        public Color GetColor()
        {
            return this.Color;
        }

    }
}
