// GUI Class #5

// Responsible for the Display of the Game state and user Descisions.

using System;
using System.Collections.Generic;
using System.Text;

namespace RpgGame
{
    class Gui
    {
        // private string header;

        // public string Header
        // {
        //     get { return this.header; }
        //     set { this.header = value; }
        // }

        public Gui()
        {

            // this.header = "Welcome to the game" + "\n" + "================" + "\n";

        }

        public static String Title(String str)
        {
            str = String.Format("====== {0} ====== \n\n", str);
            return str;
        }

        public static String MenuTitle(String str)
        {
            str = String.Format(" == ({0}) \n", str);

            return str;
        }

        public static String MenuOption(int index, String str)
        {
            str = String.Format(" - ({0}) {1} :\n", index, str);
            return str;
        }


        public void render()
        {
            // Console.WriteLine(this.header);
        }


    }
}