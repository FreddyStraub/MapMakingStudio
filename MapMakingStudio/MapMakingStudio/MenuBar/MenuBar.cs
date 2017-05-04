using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MapMakingStudio.MapMakingStudio;

namespace MapMakingStudio.MenuBar
{
    public class MenuBar
    {
        MapMakingStudio frm;


        #region MenuSelected Bools

        /// <summary>
        /// Gibt an ob dateiMenu geöffnet ist.
        /// </summary>
        private bool dateiMenuSelected = false;

        /// <summary>
        /// Gibt an ob bearbeitenMenu geöffnet ist.
        /// </summary>

        private bool bearbeitenMenuSelected = false;

        /// <summary>
        /// Gibt an ob SnippetsMenu geöffnet ist.
        /// </summary>

        private bool snippetsMenuSelected = false;

        #endregion


        public MenuBar(MapMakingStudio frm)
        {
            this.frm = frm;
        }

        public void toggle(Menus menu, MenuStatus menustatus)
        {
            switch (menu)
            {
                case Menus.Datei: DateiMenu(); break;
                case Menus.Bearbeiten: openBearbeitenMenu(); break;
                case Menus.Snippets: openSnippetsMenu(); break;
                case Menus.Suche: openSucheMenu(); break;
                case Menus.Einstellungen: openEinstellungenMenu(); break;
            }



            #region Methoden für einzelne Menus


            /// <summary>
            /// Öffnet das DateiMenu
            /// </summary>
            void DateiMenu()
            {

                MenuBarSubMenus.DateiSubMenu submenu = new MenuBarSubMenus.DateiSubMenu();

                #region Creating Menu Form

                submenu.TopLevel = false;
                submenu.AutoScroll = true;

                frm.panelDatei.Controls.Add(submenu);

                submenu.Location = new Point(frm.panelDatei.Location.X, frm.panelDatei.Location.Y + frm.bDatei.Height);

                submenu.Show();

                #endregion

                if (menustatus == MenuStatus.Open)
                {
                    frm.panelDatei.Size = new Size(frm.panelDatei.Width, submenu.Height);
                    dateiMenuSelected = true;

                }
                else

                {
                    frm.panelDatei.Size = new Size(frm.panelDatei.Width, frm.bDatei.Height - 1);
                    dateiMenuSelected = false;


                }



            }


            /// <summary>
            /// Öffnet das BearbeitenMenu
            /// </summary>
            void openBearbeitenMenu()
            {

                MenuBarSubMenus.DateiSubMenu submenu = new MenuBarSubMenus.DateiSubMenu();

                #region Creating Menu Form

                submenu.TopLevel = false;
                submenu.AutoScroll = true;

                frm.panelBearbeiten.Controls.Add(submenu);

                submenu.Location = new Point(frm.panelBearbeiten.Location.X, frm.panelBearbeiten.Location.Y + frm.bBearbeiten.Height);

                submenu.Show();

                #endregion

                if (dateiMenuSelected)
                {
                    frm.panelBearbeiten.Size = new Size(frm.panelBearbeiten.Width, frm.bBearbeiten.Height - 1);
                    bearbeitenMenuSelected = false;
                }
                else
                {
                    frm.panelBearbeiten.Size = new Size(frm.panelBearbeiten.Width, submenu.Height);
                    bearbeitenMenuSelected = true;

                }

            }

            /// <summary>
            /// Öffnet das SnippetsMenu
            /// </summary>
            void openSnippetsMenu()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Öffnet das SucheMenu
            /// </summary>
            void openSucheMenu()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Öffnet die Einstellungen
            /// </summary>
            void openEinstellungenMenu()
            {
                throw new NotImplementedException();
            }

#endregion

        }
    }
}
