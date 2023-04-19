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
using PGrafica.extras;

namespace PGrafica.objeto
{
    public class Auto
    {
        double escal;
        Punto ini;
        Color4 color;
        double rotacion;

        public Auto(Punto centro, double escala, Color4 color, double rotation)
        {
            this.ini = centro;
            this.escal = escala;
            this.color = color;
            this.rotacion = rotation;
        }

        public void draw()
        {
            

            double alto = (0.1 * escal) * 10;
            double largo = (0.3 * escal) * 10;
            double grosor = (0.1 * escal) * 10;

            Punto p = new Punto(ini.x, ini.y, ini.z);
            Punto p2 = new Punto(p.x, p.y + alto, p.z);
            Punto p3 = new Punto(p.x - alto, p.y + (-(alto * 0.5)), p.z + (-(grosor * 0.5)));
            Punto p4 = new Punto(p.x + alto, p.y + (-(alto * 0.5)), p.z + (-(grosor * 0.5)));
            Punto p5 = new Punto(p.x + (alto * 0.5), p.y + (alto * 0.5), p.z + (-(grosor * 0.5)));

            Cubo c1 = new Cubo(p, alto, largo, grosor, Color4.Yellow, rotacion);
            Cubo c2 = new Cubo(p2, alto, largo * 0.3, grosor, Color4.Red, rotacion);
            Circulo r1 = new Circulo(p3, alto * 0.4, grosor, Color4.Aqua, rotacion);
            Circulo r2 = new Circulo(p4, alto * 0.4, grosor, Color4.BlueViolet, rotacion);
            SemiCirc v = new SemiCirc(p5, alto, grosor, Color4.Coral, rotacion);

            c1.draw();
            c2.draw();
            r1.draw();
            r2.draw();
            v.draw();
        }
        
    }
}
