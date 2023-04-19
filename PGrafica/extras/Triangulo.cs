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
    public class Triangulo
    {
        private double rotacion;
        private double alt;
        private double anch;
        private double groz;
        private Color4 color;
        private Punto ini;
        public Triangulo(Punto centro, double altura, double ancho, double grosor, Color4 color, double rot)
        {
            this.ini = centro;
            this.alt = altura * 0.5;
            this.anch = ancho * 0.5;
            this.groz = grosor * 0.5;
            this.color = color;
            this.rotacion = rot;
        }

        public void draw()
        {
            GL.LoadIdentity();
            GL.Rotate(rotacion, 0.0, 1.0, 0.2);

            ////operacion con los puntos
            //double[] pt1A = { ini[0] - anch, ini[1] - alt, groz + ini[2] };           //punt4 A                    
            //double[] pt1B = { ini[0], ini[1] + alt, groz + ini[2] };           //punt3 A
            //double[] pt1C = { ini[0] + anch, ini[1] - alt,  groz + ini[2] };           //punt3 D

            //double[] pt2A = { ini[0] - anch, ini[1] - alt,  ini[2] - groz };             //punt4 D
            //double[] pt2B = { ini[0], ini[1] + alt,  ini[2] - groz };             //punt4 B
            //double[] pt2C = { ini[0] + anch, ini[1] - alt,  ini[2] - groz };             //punt3 B

            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            GL.LineWidth(3.0f);
            this.atras(primitiveType);
            this.adelante(primitiveType);
            this.derecha(primitiveType);
            this.izquierda(primitiveType);
            this.abajo(primitiveType);


        }

        public void atras(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - anch, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x + anch, ini.y - alt, groz + ini.z);
            GL.End();
        }
        public void adelante(PrimitiveType tipo)
        {   
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - anch, ini.y - alt, ini.z - groz);
            GL.Vertex3(ini.x, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x + anch, ini.y - alt, ini.z - groz);
            GL.End();
        }
        public void izquierda(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x + anch, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x + anch, ini.y - alt, ini.z - groz);
            GL.End();
        }
        public void derecha(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - anch, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x - anch, ini.y - alt, ini.z - groz);
            GL.End();

        }
        public void abajo(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - anch, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x + anch, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x + anch, ini.y - alt, ini.z - groz);
            GL.Vertex3(ini.x - anch, ini.y - alt, ini.z - groz);
            GL.End();
        }


    }
}










