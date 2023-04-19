using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGrafica
{
    public class Escenario
    {
        IDictionary<string, Objeto> data;

        public Escenario(IDictionary<string, Objeto> objetos)
        {
            this.data = objetos;
        }

        public void draw()
        {
            foreach (var drawObjeto in data)
            {
                drawObjeto.Value.draw();
            }
        }
    }
}
