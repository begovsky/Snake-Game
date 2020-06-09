using System.Collections;
using System.Windows.Forms;

namespace Project.ClassSnake
{
    class Input
    {
        //Load list of available keyboard buttons
        public static Hashtable keyTable = new Hashtable();

        //Perform a check to see if a particual button is pressed
        public static bool keyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Detect if a keyboard button is pressed
        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

    }
}
