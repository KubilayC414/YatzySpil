using System;
namespace YatzySpil
{
    public class Terning // Her oprettes class'en Terning
    {
        private int antalØjne; // Vi giver den properties
        private static Random r = new Random(); // Vælger random nummer
        private bool HoldMig = false;
        public int Øjne
        {
            get { return antalØjne; }
        }

        public void KastTerning()
        {
            if (HoldMig == false)
            { antalØjne = r.Next(1, 7); }
        }

        public void HoldTerning()
        {
            HoldMig = true;
        }

        public void TagTerningMed()
        {
            HoldMig = false;
        }
    }
}