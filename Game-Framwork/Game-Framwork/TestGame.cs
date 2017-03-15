using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (InputManager.GetKeyDown(OpenTK.Input.Key.A))
            {
                Console.WriteLine("The 'a' key has been pressed! ");
            }

            if (InputManager.GetKeyUp(OpenTK.Input.Key.A))
            {
                Console.WriteLine("The 'a' key has been released");
            }

            if (InputManager.GetKey(OpenTK.Input.Key.A))
            {
                Console.WriteLine("The 'a' key has been pressed");
            }

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
