using System;
using System.Collections.Generic;
using OpenTK.Input;
using OpenTK;

namespace GameFramework
{
    public class Input
    {
        //Key input
        private static List<Key> currentKeys = new List<Key>();
        private static List<Key> downKeys = new List<Key>();
        private static List<Key> upKeys = new List<Key>();

        //Mouse input
        private static List<MouseButton> currentMousebuttons = new List<MouseButton>();
        private static List<MouseButton> downMousebuttons = new List<MouseButton>();
        private static List<MouseButton> upMousebuttons = new List<MouseButton>();
        
        //Not needed anymore
        //public static bool Focused { get; set; }

        internal static void Update()
        {
            downKeys.Clear();

            for (int i = 0; i < Enum.GetNames(typeof(Key)).Length; i++)
            {
                if (GetKey((Key)i) && !currentKeys.Contains((Key)i))
                {
                    upKeys.Add((Key)i);
                }
            }

            for (int i = 0; i < Enum.GetNames(typeof(Key)).Length; i++)
            {
                if(!GetKey((Key)i) && currentKeys.Contains((Key)i))
                {
                    upKeys.Add((Key)i);
                }
            }

            currentKeys.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(Key)).Length; i++)
            {
                currentKeys.Add((Key)i);
            }

            //mouse buttons
            upMousebuttons.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(MouseButton)).Length; i++)
            {
                if (!GetMouseButton((MouseButton)i) && currentMousebuttons.Contains((MouseButton)i))
                {
                    upMousebuttons.Add((MouseButton)i);
                }
            }
            downMousebuttons.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(MouseButton)).Length; i++)
            {
                if(GetMouseButton((MouseButton)i) && !currentMousebuttons.Contains((MouseButton)i))
                {
                    //Console.WriteLine(i);
                    downMousebuttons.Add((MouseButton)i);
                }
            }

            currentMousebuttons.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(MouseButton)).Length; i++)
            {
                currentMousebuttons.Add((MouseButton)i);
            }

         }


        public static bool GetKey(Key keyCode)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }

            return Keyboard.GetState().IsKeyDown((short)keyCode);
        }

        public static bool GetKeyDown(Key key)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }
            return downKeys.Contains(key);
        }

        public static bool GetKeyUp(Key key)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }
            return upKeys.Contains(key);
        }

        //Mouse Buttons check

        /// <summary>
        /// Picks up the mouse button  that are being pressed
        /// </summary>
        /// <param name="mouseButton"></param>
        /// <returns></returns>
        public static bool GetMouseButton(MouseButton mouseButton)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }
            //return true;
            return Mouse.GetState().IsButtonDown(mouseButton);
        }
        /// <summary>
        /// Checks if the mouse button has been pressed
        /// </summary>
        /// <param name="mouseButton"></param>
        /// <returns></returns>
        public static bool GetMouseButtonDown(MouseButton mouseButton)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }
            return downMousebuttons.Contains(mouseButton);
        }
        /// <summary>
        /// Checks if the mouse button is released
        /// </summary>
        /// <param name="mouseButton"></param>
        /// <returns></returns>
        public static bool GetMouseButtonUp(MouseButton mouseButton)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }
            return upMousebuttons.Contains(mouseButton);
        }

        public static Vector2 GetMousePostition()
        {
            //Return our mouse position in the from of a vector 2
            return new Vector2(Mouse.GetState().X, Mouse.GetState().Y);

        }

        public static void SetMousePosition(Vector2 position)
        {
            Mouse.SetPosition(position.X, position.Y);
        }

        public static void SetMousePosition(float x, float y)
        {
            Mouse.SetPosition(x, y);
        }

        public static void ShowCursor(bool visibility)
        {
            Game.Instance.CursorVisible = visibility;
        }

    }
}
