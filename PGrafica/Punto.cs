using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGrafica
{
    public class Punto
    {
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }

        public double x { get { return X; } set { X = value; } }
        public double y { get { return Y; } set { Y = value; } }
        public double z { get { return Z; } set { Z = value; } }
        public Punto(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Punto()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public Punto(double valor)
        {
            this.X = valor;
            this.Y = valor;
            this.Z = valor;
        }

        public override string ToString()
        {
            return $"[{X} | {Y} | {Z}]";
        }

    }
}











