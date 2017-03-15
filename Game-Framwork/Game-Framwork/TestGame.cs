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
            base.Update();
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
