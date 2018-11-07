using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo
{
    class Tri
    {
        string nature;
        Epreuve natation;
        Epreuve velo;
        Epreuve course;
        List<Participant> lesParticipants;

        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("natation", distanceNatation);
            this.velo = new Epreuve("velo", distanceVelo);
            this.course = new Epreuve("course", distanceCourse);
            this.lesParticipants = new List<Participant>();
        }

        public string GetNature()
        {
            return this.nature;
        }

        public void AddParticipant(Participant unParticipant)
        {
            this.lesParticipants.Add(unParticipant);
        }

        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return this.natation;
                case "velo":
                    return this.velo;
                default:
                    return this.course;
                    
            }
        }

        public Participant GetParticipantById(int id)
        {
            foreach(Participant p in lesParticipants){
                if (p.GetId() == id)
                {
                    return p;
                }
            }
            return null;
        }

        public int GetDistanceTotale()
        {
            int DistanceTot;
            DistanceTot = this.natation.GetDistance() + this.velo.GetDistance() + this.course.GetDistance();
            return DistanceTot;

        }

        public List<Participant> GetLesTemps()
        {
            List<Participant> enCours = new List<Participant>();
            foreach(Participant unParticipant in lesParticipants)
            {
                if(unParticipant HorsDelai== false)
                {
                    enCours.Add(unParticipant);
                }
            }
            return enCours;
        }
    }
}
