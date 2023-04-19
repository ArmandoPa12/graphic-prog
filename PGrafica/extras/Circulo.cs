using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK;
using System.Drawing;

namespace PGrafica.extras
{
    public class Circulo
    {
        private double rotacion;
        private double size;
        private Punto ini;
        private double grozor;
        private Color4 color;
        private int numSegments = 32;

        public Circulo(Punto centro, double tamano, double grosor, Color4 color, double rot)
        {
            this.size = tamano;
            this.grozor = grosor;
            this.ini = centro;
            this.color = color;
            this.rotacion = rot;
        }

        public void draw()
        {

            GL.LoadIdentity();
            GL.Rotate(rotacion, 0.0, 1.0, 0.2);
            PrimitiveType tipo = PrimitiveType.Polygon;
            //PrimitiveType tipo = PrimitiveType.LineLoop;
            this.atras(tipo);
            this.adelante(tipo);
                       
        }

        private void atras(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x, ini.y, ini.z);
            for (int i = 0; i <= this.numSegments; i++)
            {
                double theta = i / (double)this.numSegments * 2.0 * Math.PI;
                double x = this.size * Math.Cos(theta);
                double y = size * Math.Sin(theta);
                GL.Vertex3(x + ini.x, y + ini.y, ini.z);
            }
            GL.End();
        }
        private void adelante(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x, ini.y, grozor + ini.z);
            for (int i = 0; i <= numSegments; i++)
            {
                double theta = i / (double)numSegments * 2.0 * Math.PI;
                double x = this.size * Math.Cos(theta);
                double y = this.size * Math.Sin(theta);
                GL.Vertex3(x + ini.x, y + ini.y, grozor + ini.z);
            }
            GL.End();
        }

    }

}










