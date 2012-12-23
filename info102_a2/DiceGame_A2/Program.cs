/*Minh HA
 * 300113109
 * INFO102 - Assignment1*/
/*Extra feature:
 * User has an option to add 10 extra points each time TopUp Button is clicked
 * After 5 top ups, user cannot add any more, message box appear saying time to work
 * User can keep playing with the remaining points
 * To reset top up count, new game must be used, which reset everything
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _300113109_DiceGame_A2
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
            Application.Run(new DiceGameMainForm());
        }
    }
}
