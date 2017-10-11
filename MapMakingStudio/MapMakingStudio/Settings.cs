using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MapMakingStudio
{
    [Serializable]
    public class Settings
    {

        public string fileExplorerPath { get; set; }

        /// <summary>
        /// Speichert die Einstellungen an den angegebenen Pfad.
        /// </summary>
        /// <param name="path">Pfad um Settings zu speichern.</param>
        public void Save(string path)
        {
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();
        }

        /// <summary>
        /// Lädt die Einstellungen von dem angegebenen Pfad.
        /// </summary>
        /// <param name="path">Pfad zu Settings-Datei.</param>
        public Settings Load(string path)
        {
            Settings newSettings = new Settings();
            
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            newSettings = (Settings)BF.Deserialize(FS);

            FS.Dispose();

            return newSettings;
         
        }

        /// <summary>
        /// Setztz die Einstellungen auf die Standartwerte.
        /// </summary>
        public void setStandartSettings()
        {

            fileExplorerPath = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\saves";

        }
    }
}
