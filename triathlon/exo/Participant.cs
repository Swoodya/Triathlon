using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo
{
    class Participant
    {
        int id;
        string nom;
        DateTime dateInscription;
        List<Resultat> lesResultats;

        Participant(string nom, DateTime dateInscription)
        {
            this.nom = nom;
            this.dateInscription = dateInscription;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public DateTime GetDateInscription()
        {
            return this.dateInscription;
        }

        private bool resultatPresent(Epreuve unEpreuve)
        {
            for(int i = 0; i < lesResultats.Count; i++)
            {
                if (lesResultats[i].GetEpreuve().GetNom() == unEpreuve.GetNom())
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(Epreuve uneEpreuve, int tempsRealise)
        {

        }

        public int GetTempsTotal()
        {

        }

        public bool HorsDelai()
        {

        }
    }
}
