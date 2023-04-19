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
    public class Casa
    {
        double altura;
        double ancho;
        double grosor;
        Punto inicio;
        Color4 color;
        double rotation;

        public Casa(Punto centro,double alt,double anch,double gros,Color4 color, double valor)
        {
            this.inicio = centro;
            this.altura = alt;
            this.ancho = anch;
            this.grosor = gros;
            this.color = color;
            this.rotation = valor;
        }

        public void draw()
        {
            //double altura = 0.2;
            //double ancho = 0.3;
            //double grosor = 0.6;
            //Punto inicio = new Punto(0.3, 0.2, 0.1);


            Cubo _base = new Cubo(inicio, this.altura, this.ancho, this.grosor, Color4.AntiqueWhite, rotation);
            Triangulo techo = new Triangulo(new Punto(inicio.x, inicio.y + altura, inicio.z), altura, ancho, grosor, Color4.Aqua, rotation);

            techo.draw();
            _base.draw();
        }

    }
}
