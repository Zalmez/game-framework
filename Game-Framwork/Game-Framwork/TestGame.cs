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
            if (InputManager.GetMouseButtonDown(OpenTK.Input.MouseButton.Right))
            {
                Console.WriteLine("'MB1' has been pressed");
            }

            if (InputManager.GetMouseButtonUp(OpenTK.Input.MouseButton.Right))
            {
                Console.WriteLine("'MB1' has been released");
            }

            if (InputManager.GetMouseButton(OpenTK.Input.MouseButton.Right))
            {
                return;
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
