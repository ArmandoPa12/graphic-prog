using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK;

namespace PGrafica
{
    public class Face
    {
        Punto ini;
        IDictionary<string, Punto> puntos;

        public Face(Punto centro, IDictionary<string, Punto> paso ) 
        {
            this.ini = centro;
            this.puntos = paso;
        }

        public void draw()
        {
            PrimitiveType type = PrimitiveType.LineLoop;

            GL.LoadIdentity();

            GL.Color4(Color.White);
            GL.LineWidth(3.0f);
            GL.Begin(type);
            foreach (KeyValuePair<string, Punto> kvp in this.puntos)
            {
                Punto valor = kvp.Value;
                GL.Vertex3(valor.x, valor.y, valor.z);
                Console.WriteLine(valor.ToString());
            }
            GL.End();
        }
    }
}








