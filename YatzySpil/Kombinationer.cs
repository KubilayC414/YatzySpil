using System;
namespace YatzySpil
{
    public class Kombinationer
    {
        public Terning Terning1 = new Terning(); //Instans af Terning oprettes
        public Terning Terning2 = new Terning();
        public Terning Terning3 = new Terning();
        public Terning Terning4 = new Terning();
        public Terning Terning5 = new Terning();

        public void RystBæger() //Funktion RystBæger oprettes
        {
            Terning1.KastTerning(); //Når den calles, kaster den terninger
            Terning2.KastTerning();
            Terning3.KastTerning();
            Terning4.KastTerning();
            Terning5.KastTerning();
        } 
       
        private int HvorMangeAfEnSlags(int Slags) // Kigger efter antal af Slags
        {
            int Antal = 0; //Antal oprettes og sættes til 0 

            if (Terning1.Øjne == Slags) //Hvis Øjne på Terning1 = Slags...
            {
                Antal = Antal + 1;  // ...Plusser vi Antal med 1
            }
            if (Terning2.Øjne == Slags) //Hvis Øjne på Terning2 = Slags...
            {
                Antal = Antal + 1; // ...Plusser vi Antal med 1, så Antal = 2
            }
            if (Terning3.Øjne == Slags) // Osv... 
            {
                Antal = Antal + 1;
            }
            if (Terning4.Øjne == Slags)
            {
                Antal = Antal + 1;
            }
            if (Terning5.Øjne == Slags)
            {
                Antal = Antal + 1;
            }
            return Antal;
        }

        public int PointEnere()
        {
            return HvorMangeAfEnSlags(1); //hvor mange 1'ere + 1 point for hver
        }

        public int PointToere()
        {
            return HvorMangeAfEnSlags(2) * 2; //Man ganger med 2 for hver 2'er
        }

        public int PointTreere()
        {
            return HvorMangeAfEnSlags(3) * 3;
        }

        public int PointFirere()
        {
            return HvorMangeAfEnSlags(4) * 4;
        }

        public int PointFemere()
        {
            return HvorMangeAfEnSlags(5) * 5;
        }

        public int PointSeksere()
        {
            return HvorMangeAfEnSlags(6) * 6;
        }

        public int PointEtPar()
        {
            for (int i = 6; i >= 1; --i) // Laver et for loop - tjekker antal
            {
                if (HvorMangeAfEnSlags(i) > 1) // Hvis Slags er over 1
                { return i * 2; } // Så ganger den med 2
            }
            return 0;
        }

        public int PointToPar()
        {
            int FørstePar = 0; // FørstePar sættes til 0 - én enkelt gang

            for (int i = 6; i >= 1; --i) // Laver et for loop - tjekker antal
            {
                if (HvorMangeAfEnSlags(i) > 1) // Er Slags over 1?
                {
                    if (FørstePar != 0) //Hvis første par er fundet
                    {
                        return FørstePar + (i * 2); //Så plusser den med 2. par
                    }
                    else // Hvis slags er over 1, men FørstePar ikke er fundet
                        FørstePar = i * 2;
                }
            }
            return 0;
        }

        public int PointTreEns()
        {
            for (int i = 6; i >= 1; --i)
            {
                if (HvorMangeAfEnSlags(i) > 2) //Er der flere end 2 af slags
                {
                    return i * 3;
                }
            }
            return 0;
        }

        public int PointFireEns()
        {
            for (int i = 6; i >= 1; --i)
            {
                if (HvorMangeAfEnSlags(i) > 3) //Er der flere end 3 af slags
                {
                    return i * 4;
                }
            }
            return 0;
        }

        public int LilleStraight()
        {
            bool ettere = false;
            bool toere = false;
            bool treere = false;
            bool firere = false;
            bool femere = false;

                if (HvorMangeAfEnSlags(5) == 1) //Er der én 5er?
                {
                    femere = true; // Hvis ja,så er femere true
                }
                if (HvorMangeAfEnSlags(4) == 1)
                {
                    firere = true;
                }
                if (HvorMangeAfEnSlags(3) == 1)
                {
                    treere = true;
                }
                if (HvorMangeAfEnSlags(2) == 1)
                {
                    toere = true;
                }
                if (HvorMangeAfEnSlags(1) == 1)
                {
                    ettere = true;
                }

            if (ettere && toere && treere && firere && femere)
            {
                return 1 + 2 + 3 + 4 + 5; // Hvis alle er true, så plusses de
            }
            return 0;
        }

        public int StorStraight()
        {
            bool toere = false;
            bool treere = false;
            bool firere = false;
            bool femere = false;
            bool seksere = false;

                if (HvorMangeAfEnSlags(6) == 1) //Er der én 6er?
            {
                    seksere = true; // Hvis ja,så er seksere true
            }
                if (HvorMangeAfEnSlags(5) == 1)
                {
                    femere = true;
                }
                if (HvorMangeAfEnSlags(4) == 1)
                {
                    firere = true;
                }
                if (HvorMangeAfEnSlags(3) == 1)
                {
                    treere = true;
                }
                if (HvorMangeAfEnSlags(2) == 1)
                {
                    toere = true;
                }

            if (toere && treere && firere && femere && seksere)
            {
                return 2 + 3 + 4 + 5 + 6; // Hvis alle er true, så plusses de
            }
            return 0;
        }

        public int PointFuldtHus()
        {
            int TreEns = 0;
            int ToEns = 0;

            for (int i = 6; i >= 1; --i)
            {
                if (HvorMangeAfEnSlags(i) == 3) //Hvis der er 3 af én Slags
                {
                    TreEns = i * 3; // Så ganges værdien med 3
                    break; // Hopper ud af for loopet
                }
            }

            if (TreEns > 0) // Hopper ind her
            {
                for (int i = 6; i >= 1; --i)
                {
                    if (HvorMangeAfEnSlags(i) == 2) //Hvis der er 2 af én Slags
                    {
                        ToEns = i * 2; // Så ganges værdien med 2
                        break; // Hopper ud af 2. for loop 
                    }
                }
            }
            if (ToEns > 0 && TreEns > 0)
            {
                return TreEns + ToEns;
            }
            else return 0;
        }


        public int PointChancen()
        {
            return Terning1.Øjne + Terning2.Øjne + Terning3.Øjne + Terning4.Øjne + Terning5.Øjne;
        }

        public int PointYatzy()
        {
            for (int i = 6; i >= 1; --i)
            {
                if (HvorMangeAfEnSlags(i) == 5)
                {
                    return i * 5 + 50;
                }
            }
            return 0;
        }
    }
}