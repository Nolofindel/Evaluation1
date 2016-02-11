using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChasseurDeTetes.Vues
{
    /// <summary>
    /// Méthodes générique gérant les affichages.
    /// </summary>
    public class Affichage
    {
        /// <summary>
        /// Méthode rendant inactif ou non l'ensemble des contrôles d'un contrôle.
        /// </summary>
        /// <param name="enable">Booléen. Si vrai le contrôle est rendu iniactif,sinon le contrôle est rétabli.</param>
        /// <param name="ctr">Contrôle</param>
        public static void EtablirChamp(bool enable,Control ctr)
        {
            foreach(Control ct in ctr.Controls)
            {
                ct.Enabled = enable;
            }
        }
    }
}
