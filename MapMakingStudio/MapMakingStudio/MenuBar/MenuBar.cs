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
        public bool dateiMenuIsOpen { get; private set; }

        /// <summary>
        /// Gibt an ob bearbeitenMenu geöffnet ist.
        /// </summary>

        public bool bearbeitenMenuIsOpen { get; private set; }

        /// <summary>
        /// Gibt an ob SnippetsMenu geöffnet ist.
        /// </summary>

        public bool snippetsMenuIsOpen { get; private set; }

        #endregion



        public MenuBar(MapMakingStudio frm)
        {
            this.frm = frm;

            dateiMenuIsOpen = false;
            bearbeitenMenuIsOpen = false;
        }

        public void toggle(Menus menu, MenuStatus menustatus)
        {


            closeAllSubMenus();

            switch (menu)
            {
                case Menus.Datei: DateiMenu(menustatus); break;
                case Menus.Bearbeiten: BearbeitenMenu(menustatus); break;
                case Menus.Snippets: SnippetMenu(); break;
                case Menus.Suche: openSucheMenu(); break;
                case Menus.Einstellungen: openEinstellungenMenu(); break;
            }

        }

        #region Methoden für einzelne Menus


        /// <summary>
        /// Öffnet das DateiMenu
        /// </summary>
        void DateiMenu(MenuStatus dateiMenuStatus)
        {

            MenuBarSubMenus.DateiSubMenu submenu = new MenuBarSubMenus.DateiSubMenu();

            #region Creating Menu Form

            submenu.TopLevel = false;
            submenu.AutoScroll = true;

            frm.panelDatei.Controls.Add(submenu);

            submenu.Location = new Point(frm.panelDatei.Location.X, frm.panelDatei.Location.Y + frm.bDatei.Height);

            submenu.Show();

            #endregion

            if (dateiMenuStatus == MenuStatus.Open)
            {
                frm.panelDatei.Size = new Size(frm.panelDatei.Width, submenu.Height);
                dateiMenuIsOpen = true;


            }
            else

            {
                frm.panelDatei.Size = new Size(frm.panelDatei.Width, frm.bDatei.Height - 1);
                dateiMenuIsOpen = false;


            }



        }


        /// <summary>
        /// Öffnet das BearbeitenMenu
        /// </summary>
        void BearbeitenMenu(MenuStatus bearbeitenMenuStatus)
        {

            BearbeitenSubMenu submenu = new BearbeitenSubMenu();

            #region Creating Menu Form

            submenu.TopLevel = false;
            submenu.AutoScroll = true;

            frm.panelBearbeiten.Controls.Add(submenu);

            submenu.Location = new Point(frm.panelBearbeiten.Location.X, frm.panelBearbeiten.Location.Y);

            submenu.Show();

            #endregion

            if (bearbeitenMenuStatus == MenuStatus.Open)
            {
                frm.panelBearbeiten.Size = new Size(frm.panelBearbeiten.Width, submenu.Height);
                bearbeitenMenuIsOpen = true;


            }
            else

            {
                frm.panelBearbeiten.Size = new Size(frm.panelBearbeiten.Width, frm.bBearbeiten.Height - 1);
                bearbeitenMenuIsOpen = false;


            }

        }

        /// <summary>
        /// Öffnet das SnippetsMenu
        /// </summary>
        void SnippetMenu()
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


        private void closeAllSubMenus()
        {
            if (dateiMenuIsOpen)             
                DateiMenu(MenuStatus.Close);


            if (bearbeitenMenuIsOpen)               
                BearbeitenMenu(MenuStatus.Close);


        }
    }
}
