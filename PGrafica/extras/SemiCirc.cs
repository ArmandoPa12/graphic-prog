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

namespace PGrafica
{
    public class SemiCirc
    {
        private double rotacion;
        private double size;
        private Punto ini;
        private double grozor;
        private Color4 color;
        private int numSegments = 20;

        public SemiCirc(Punto inicio, double tamano, double grosor, Color4 color, double rot)
        {
            this.size = tamano;
            this.grozor = grosor;
            this.ini = inicio;
            this.color = color;
            this.rotacion = rot;
        }

        public void draw()
        {
            GL.LoadIdentity();
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            

            GL.Rotate(rotacion, 0.0, 1.0, 0.2);

            this.atras(primitiveType);
            this.adelante(primitiveType);
            
        }

        private void atras(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x, ini.y, ini.z); // Centro del semicírculo
            for (int i = 0; i <= numSegments / 2; i++)
            {
                double angle = i / (double)numSegments * Math.PI;
                double x = size * Math.Cos(angle);
                double y = size * Math.Sin(angle);
                GL.Vertex3(x + ini.x, y + ini.y, ini.z);
            }
            GL.End();
        }
        private void adelante(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x, ini.y, grozor + ini.z); // Centro del semicírculo
            for (int i = 0; i <= numSegments / 2; i++)
            {
                double angle = i / (double)numSegments * Math.PI;
                double x = size * Math.Cos(angle);
                double y = size * Math.Sin(angle);
                GL.Vertex3(x + ini.x, y + ini.y, grozor + ini.z);
            }
            GL.End();
        }
    }
}
