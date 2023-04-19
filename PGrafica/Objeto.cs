using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace PGrafica
{
    public class Objeto
    {
        public Punto ini;
        public IDictionary<string, Figura> ListaFiguras;

        public Objeto(Punto centro, IDictionary<string, Figura> lista) 
        {
            this.ini = centro;
            this.ListaFiguras = lista;
            this.setCentro(centro);
        }

        public void setCentro(Punto centro)
        {
            foreach (var punto in ListaFiguras)
            {
                punto.Value.ini  = centro;
            }
        }
        public Punto getCentro()
        {
            return this.ini;
        }

        public void setFigure(string key, Figura value)
        {
            this.ListaFiguras.Add(key, value);
        }

        public Figura getFigura(string key)
        {
            return this.ListaFiguras[key];
        }

        public IDictionary<string,Figura> getFiguras()
        {
            return this.ListaFiguras;
        }
        public void draw()
        {
            
            foreach (KeyValuePair<string, Figura> kvp in ListaFiguras)
            {
                kvp.Value.draw();
            }
            
        }
    }
}
