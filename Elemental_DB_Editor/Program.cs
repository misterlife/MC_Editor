using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elemental_DB_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ER_Form erForm = new ER_Form();
        public static Form_AddMod modForm = new Form_AddMod();
        public static Form_CVersion VersionForm = new Form_CVersion();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(erForm);
        }
    }
}
