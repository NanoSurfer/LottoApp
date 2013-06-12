/*
 * Programmer: Shawn Brewis
 * Date: 12/06/2012
 * Purpose: The purpose of this application is to display a random set of lotto numbers for a user to use to play a lotto
 *          game as well as the option for the user to select their own numbers.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlayLotto
{
    static class PlayLottoApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
