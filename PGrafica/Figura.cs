using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PGrafica.extras;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK;
using System.Drawing;

namespace PGrafica
{
    public  class Figura
    {
        public Punto ini { get; set; }
        public IDictionary<string, Punto> ListaPuntos;
        public Color4 color;

        public Figura(Punto centro, IDictionary<string,Punto> puntos, Color4 color)
        {
            this.ini = centro;
            this.ListaPuntos = puntos;
            this.color = color;
        }

        public void draw()
        {
            GL.Color4(color);
            GL.Begin(PrimitiveType.LineLoop);
            foreach (KeyValuePair<string, Punto> kvp in ListaPuntos)
            {
                GL.Vertex3(kvp.Value.x+ini.x, kvp.Value.y + ini.y, kvp.Value.z + ini.z);
            }
            GL.End();
            GL.Flush();
        }
    }
}
