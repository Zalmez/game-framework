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
            
            if (Input.GetMouseButtonDown(OpenTK.Input.MouseButton.Middle) == true)
            {
                Console.WriteLine("Middle Mouse Button Has Been pressed");
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
