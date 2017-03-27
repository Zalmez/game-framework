using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameFramework
{
    public class TestGame : Game
    {
        public TestGame(int width, int height, string title) : base(width, height, title) { }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void Update()
        {

            if (InputV2.KeyPress(OpenTK.Input.Key.A))
            {
                Console.WriteLine("The A key has been pressed");
            }

            

            //if (InputManager.GetMouseButtonUp(OpenTK.Input.MouseButton.Middle) == false)
            //{
            //    Console.WriteLine("Middle Mouse Button has been released");
            //}
        }

        protected override void Render()
        {
            base.Render();
        }

        protected override void Shutdown()
        {
            base.Shutdown();
        }

    }
}
