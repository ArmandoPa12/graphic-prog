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
    public class Cubo
    {
        private double rotacion;
        private double alt;
        private double larg;
        private double groz;
        private Color4 color;
        private Punto ini;
        public Cubo(Punto centro, double altura, double ancho, double grosor, Color4 color, double rot)
        {
            this.ini = centro;
            this.alt = altura * 0.5;
            this.larg = ancho * 0.5;
            this.groz = grosor * 0.5;
            this.color = color;
            this.rotacion = rot;
        }

        public void draw()
        {
            GL.LoadIdentity();

            GL.Color4(color);
            GL.LineWidth(3.0f);
            GL.Rotate(rotacion, 0.0, 1.0, 0.2);
            PrimitiveType primitiveType = PrimitiveType.LineLoop;

            this.atras(primitiveType);
            this.adelante(primitiveType);
            this.izquierda(primitiveType);
            this.derecha(primitiveType);
            this.arriba(primitiveType);
            this.abajo(primitiveType);
        }

        private void adelante(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - larg, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x + larg, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x + larg, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x - larg, ini.y - alt, groz + ini.z);
            GL.End();
        }
        
        private void atras(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - larg, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x + larg, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x + larg, ini.y - alt, ini.z - groz);
            GL.Vertex3(ini.x - larg, ini.y - alt, ini.z - groz);
            GL.End();
        }
        private void izquierda(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - larg, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x - larg, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x - larg, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x - larg, ini.y - alt, ini.z - groz);
            GL.End();
        }
        private void derecha(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x + larg, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x + larg, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x + larg, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x + larg, ini.y - alt, ini.z - groz);
            GL.End();
        }
        private void arriba(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - larg, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x + larg, ini.y + alt, ini.z - groz);
            GL.Vertex3(ini.x + larg, ini.y + alt, groz + ini.z);
            GL.Vertex3(ini.x - larg, ini.y + alt, groz + ini.z);
            GL.End();
        }

        private void abajo(PrimitiveType tipo)
        {
            GL.Color4(color);
            GL.Begin(tipo);
            GL.Vertex3(ini.x - larg, ini.y - alt, ini.z - groz);
            GL.Vertex3(ini.x + larg, ini.y - alt, ini.z - groz);
            GL.Vertex3(ini.x + larg, ini.y - alt, groz + ini.z);
            GL.Vertex3(ini.x - larg, ini.y - alt, groz + ini.z);
            GL.End();
        }

    }
}
