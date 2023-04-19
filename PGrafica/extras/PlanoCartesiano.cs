using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace PGrafica.extras
{
    internal class PlanoCartesiano
    {
        private double rotacion;

        public PlanoCartesiano(double rotation)
        {
            this.rotacion = rotation;
        }
        public void draw()
        {
            GL.LoadIdentity();
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            GL.Rotate(rotacion, 0.0, 1.0, 0.2);
            //GL.Rotate(140, 0.1, rotacion * 0.01, 0.2);
            //GL.Translate(0.0, 0.0, -0.010);

            GL.Begin(primitiveType);
            GL.Color3(1.0f, 0.0f, 0.0f); // rojo    X
            GL.Vertex3(-1.0f, 0.0f, 0.0f);
            GL.Vertex3(1.0f, 0.0f, 0.0f);
            GL.End();
            GL.Begin(primitiveType);
            GL.Color3(0.0f, 1.0f, 0.0f); // verde   Y
            GL.Vertex3(0.0f, -1.0f, 0.0f);
            GL.Vertex3(0.0f, 1.0f, 0.0f);
            GL.End();
            GL.Begin(primitiveType);
            GL.Color3(0.0f, 0.0f, 1.0f); // azul    Z
            GL.Vertex3(0.0f, 0.0f, -1.0f);
            GL.Vertex3(0.0f, 0.0f, 1.0f);
            GL.End();
        }

    }
}
