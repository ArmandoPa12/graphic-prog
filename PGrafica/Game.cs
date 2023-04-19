using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK;
using PGrafica.extras;
using PGrafica.objeto;

namespace PGrafica
{
    internal class Game: GameWindow
    {
        double _time;
        double valor;


        Escenario escena1;

        

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //valor = _time += 14.0 * e.Time;
            valor = 0;
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            GL.Rotate(1, 0.0, 1.0, 0.2);


            escena1.draw();

            
            Context.SwapBuffers();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            valor = 0;

            Punto centro = new Punto();

            Punto pa1 = new Punto(0.0, 0.3, 0.0);
            Punto pa2 = new Punto(0.4, 0.3, 0.0);
            Punto pa3 = new Punto(0.4, 0.0, 0.0);
            Punto pa4 = new Punto(0.0, 0.0, 0.0);
             
            Punto pb1 = new Punto(0.0, 0.3, 0.2);
            Punto pb2 = new Punto(0.4, 0.3, 0.2);
            Punto pb3 = new Punto(0.4, 0.0, 0.2);
            Punto pb4 = new Punto(0.0, 0.0, 0.2);

            IDictionary<string, Punto> back = new Dictionary<string, Punto>();
            back.Add("0", pa1);
            back.Add("1", pa2);
            back.Add("2", pa3);
            back.Add("3", pa4);
            IDictionary<string, Punto> front = new Dictionary<string, Punto>();
            front.Add("0", pb1);
            front.Add("1", pb2);
            front.Add("2", pb3);
            front.Add("3", pb4);
            IDictionary<string, Punto> left = new Dictionary<string, Punto>();
            left.Add("0", pa1);
            left.Add("1", pb1);
            left.Add("2", pb4);
            left.Add("3", pa4);
            IDictionary<string, Punto> right = new Dictionary<string, Punto>();
            right.Add("0", pb2);
            right.Add("1", pa2);
            right.Add("2", pa3);
            right.Add("3", pb3);
            IDictionary<string, Punto> up = new Dictionary<string, Punto>();
            up.Add("0", pa1);
            up.Add("1", pa2);
            up.Add("2", pb2);
            up.Add("3", pb1);
            IDictionary<string, Punto> down = new Dictionary<string, Punto>();
            down.Add("0", pa4);
            down.Add("1", pa3);
            down.Add("2", pb3);
            down.Add("3", pb4);

            Figura backcubo = new Figura(centro, back, Color4.Blue);
            Figura frontcubo = new Figura(centro, front, Color4.Aqua);
            Figura leftcubo = new Figura(centro, left, Color4.Azure);
            Figura rightcubo = new Figura(centro, right, Color4.Yellow);
            Figura upcubo = new Figura(centro, up, Color4.Red);
            Figura downcubo = new Figura(centro, down, Color4.Salmon);

            IDictionary<string, Figura> ObjetoCubo = new Dictionary<string, Figura>();
            ObjetoCubo.Add("cuboBack", backcubo);
            ObjetoCubo.Add("cuboFront", frontcubo);
            ObjetoCubo.Add("cuboLeft", leftcubo);
            ObjetoCubo.Add("cuboRight", rightcubo);
            ObjetoCubo.Add("cuboUp", upcubo);
            ObjetoCubo.Add("cuboDown", downcubo);


            IDictionary<string, Punto> fi1 = new Dictionary<string, Punto>();
            fi1.Add("p1", new Punto(-0.2, 0.0, 0.0));
            fi1.Add("p2", new Punto(0.0, 0.2, 0.0));
            fi1.Add("p3", new Punto(0.2, 0.0, 0.0));
            IDictionary<string, Punto> fi2 = new Dictionary<string, Punto>();
            fi2.Add("p4", new Punto(-0.2, 0.0, 0.2));
            fi2.Add("p5", new Punto(0.0, 0.2, 0.2));
            fi2.Add("p6", new Punto(0.2, 0.0, 0.2));

            IDictionary<string, Figura> ObjetoTriangle = new Dictionary<string, Figura>();
            ObjetoTriangle.Add("triangleFront", new Figura(centro,fi1,Color4.AntiqueWhite));
            ObjetoTriangle.Add("triangleBack", new Figura(centro, fi2, Color4.AntiqueWhite));


            Objeto triangle3D = new Objeto(new Punto(-0.3,0.2,0.0), ObjetoTriangle);
            Objeto cubo3D = new Objeto(centro, ObjetoCubo);

            IDictionary<string, Objeto> escena = new Dictionary<string, Objeto>();
            escena.Add("triangulo", triangle3D);
            escena.Add("cubo", cubo3D);

            escena1 = new Escenario(escena);



        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            KeyboardState input = Keyboard.GetState();
            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
            if (input.IsKeyDown(Key.W))
            {
                valor = valor + 0.01;
            }
            if (input.IsKeyDown(Key.S))
            {
                valor = valor - 0.01;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);

        }
    }
}





//cubo = new Cubo(new Punto(), 0.3, 0.5, 0.6, Color4.White, valor);
//plano = new PlanoCartesiano(valor);
//triangulo = new Triangulo(new Punto(), 0.3, 0.5, 0.6, Color4.White, valor);
//circulo = new Circulo(new Punto(), 0.05, 0.3, Color4.Red, valor);
//semi = new SemiCirc(new Punto(), 0.05, 0.3, Color4.Red, valor);