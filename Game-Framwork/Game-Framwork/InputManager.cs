using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;

namespace GameFramework
{
    public class InputManager
    {
        //Key input
        private static List<Key> currentKeys = new List<Key>();
        private static List<Key> downKeys = new List<Key>();
        private static List<Key> upKeys = new List<Key>();

        //Mouse input
        private static List<MouseButton> currentMousebuttons = new List<MouseButton>();
        private static List<MouseButton> downMousebuttons = new List<MouseButton>();
        private static List<MouseButton> upMousebuttons = new List<MouseButton>();

        public static bool Focused { get; set; }

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

            upMousebuttons.Clear();


            //mouse buttons
            for (int i = 0; i < Enum.GetNames(typeof(MouseButton)).Length; i++)
            {
                if (GetMouseButton((MouseButton)i) && !currentMousebuttons.Contains((MouseButton)i))
                {
                    upMousebuttons.Add((MouseButton)i);
                }
            }

            for (int i = 0; i < Enum.GetNames(typeof(Key)).Length; i++)
            {
                if(!GetMouseButton((MouseButton)i) && currentMousebuttons.Contains((MouseButton)i))
                {
                    upMousebuttons.Add((MouseButton)i);
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
            if (!Focused)
            {
                return false;
            }

            return Keyboard.GetState().IsKeyDown((short)keyCode);
        }

        public static bool GetKeyDown(Key key)
        {
            if (!Focused)
            {
                return false;
            }
            return downKeys.Contains(key);
        }

        public static bool GetKeyUp(Key key)
        {
            if (!Focused)
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
            if (!Focused)
            {
                return false;
            }

            return Mouse.GetState().IsButtonDown(mouseButton);
        }
        /// <summary>
        /// Checks if the mouse button has been pressed
        /// </summary>
        /// <param name="mouseButton"></param>
        /// <returns></returns>
        public static bool GetMouseButtonDown(MouseButton mouseButton)
        {
            if (!Focused)
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
            if (!Focused)
            {
                return false;
            }
            return upMousebuttons.Contains(mouseButton);
        }



    }
}
