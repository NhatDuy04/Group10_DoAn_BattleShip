using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battleship
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameMenu());
        }
    }
    static class AudioContext
    {
        static public readonly SoundPlayer hitSound = new SoundPlayer(Properties.Resources.hit);
        static public readonly SoundPlayer missSound = new SoundPlayer(Properties.Resources.miss);
    }
}
