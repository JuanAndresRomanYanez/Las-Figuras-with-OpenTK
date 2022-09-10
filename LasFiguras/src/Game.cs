using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;//handle keyboard

namespace LasFiguras
{
    public class Game : GameWindow
    {
        Figura a, b, c;
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }

            base.OnUpdateFrame(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            //GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);///background color gray
            GL.ClearColor(1.0f, 0.5f, 0.0f, 0.0f);//orange

            a = new Figura(new Punto(-0.5f, 0.25f, 0f));
            b = new Figura(new Punto(0.0f, 0.0f, 0f));
            c = new Figura(new Punto(0.5f, -0.25f, 0f));

            base.OnLoad(e);
        }

        protected override void OnUnload(EventArgs e)
        {

            a.delete();
            b.delete();
            c.delete();
            base.OnUnload(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            a.dibujar();
            b.dibujar();
            c.dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
    }
}
