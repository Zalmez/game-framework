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
        private static List<Key> currentKeys = new List<Key>();
        private static List<Key> downKeys = new List<Key>();
        private static List<Key> upKeys = new List<Key>();

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
         }

        public static void GetKey(Key key)
        {
            if (!Focused)
            {
                return false;
            }

            return Keyboard.GetState().IsKeyDown((short)key);
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


     }
}
