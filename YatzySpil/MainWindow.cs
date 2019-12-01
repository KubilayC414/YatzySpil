using System;
using Gtk;
using YatzySpil;


public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

  
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    public Kombinationer nyKombi = new Kombinationer(); // Newer vores kombi op

    protected void OnCheckbutton1Toggled(object sender, EventArgs e)
    {
        if (checkbutton1.Active) // Hvis "Hold" er trykket/aktiveret
        {
            nyKombi.Terning1.HoldTerning(); // Så holder vi terning
        }
        else nyKombi.Terning1.TagTerningMed(); // Hvis ikke slåes den igen
    }

    protected void OnCheckbutton2Toggled(object sender, EventArgs e)
    {
        if (checkbutton2.Active)
        {
            nyKombi.Terning2.HoldTerning();
        }
        else nyKombi.Terning2.TagTerningMed();
    }

    protected void OnCheckbutton3Toggled(object sender, EventArgs e)
    {
        if (checkbutton3.Active)
        {
            nyKombi.Terning3.HoldTerning();
        }
        else nyKombi.Terning3.TagTerningMed();
    }

    protected void OnCheckbutton4Toggled(object sender, EventArgs e)
    {
        if (checkbutton4.Active)
        {
            nyKombi.Terning4.HoldTerning();
        }
        else nyKombi.Terning4.TagTerningMed();
    }

    protected void OnCheckbutton5Toggled(object sender, EventArgs e)
    {
        if (checkbutton5.Active)
        {
            nyKombi.Terning5.HoldTerning();
        }
        else nyKombi.Terning5.TagTerningMed();
    }


    protected void OnBtnKastTerningClicked(object sender, EventArgs e)
    {
        SlagTilbage--; // Trækkes der 1 fra SlagTilbage
        LabelSlagTilbage.Text = SlagTilbage.ToString(); // Indsættes i GUI

        if (SlagTilbage == 0)
            BtnKastTerning.Sensitive = false; // Så slukker Kast Terning knap

        nyKombi.RystBæger(); // Ryster bæger
        entryTerning1.Text = nyKombi.Terning1.Øjne.ToString(); // Skriver i felt
        entryTerning2.Text = nyKombi.Terning2.Øjne.ToString();
        entryTerning3.Text = nyKombi.Terning3.Øjne.ToString();
        entryTerning4.Text = nyKombi.Terning4.Øjne.ToString();
        entryTerning5.Text = nyKombi.Terning5.Øjne.ToString();

        if (nyKombi.PointEnere() > 0) // Hvis Kombinationen PointEnere er over 0
        {
            if (SpillerNr == 1) //Hvis det er Spiller 1's tur
            {
                if (Spl1_Entry1ere.Text == "") // Hvis entrien er tom
                {
                    ButtonVælg1ere.Sensitive = true; //Vælg knap aktiveres
                }
                else
                {
                    ButtonVælg1ere.Sensitive = false; // Hvis ikke, deaktiveret
                    ButtonStreg1ere.Sensitive = false; 
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry1ere.Text == "")
                {
                    ButtonVælg1ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg1ere.Sensitive = false;
                    ButtonStreg1ere.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry1ere.Text == "")
                {
                    ButtonVælg1ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg1ere.Sensitive = false;
                    ButtonStreg1ere.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry1ere.Text == "")
                {
                    ButtonVælg1ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg1ere.Sensitive = false;
                    ButtonStreg1ere.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg1ere.Sensitive = false;
        }

        if (nyKombi.PointToere() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry2ere.Text == "")
                {
                    ButtonVælg2ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg2ere.Sensitive = false;
                    ButtonStreg2ere.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry2ere.Text == "")
                {
                    ButtonVælg2ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg2ere.Sensitive = false;
                    ButtonStreg2ere.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry2ere.Text == "")
                {
                    ButtonVælg2ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg2ere.Sensitive = false;
                    ButtonStreg2ere.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry2ere.Text == "")
                {
                    ButtonVælg2ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg2ere.Sensitive = false;
                    ButtonStreg2ere.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg2ere.Sensitive = false;
        }

        if (nyKombi.PointTreere() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry3ere.Text == "")
                {
                    ButtonVælg3ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ere.Sensitive = false;
                    ButtonStreg3ere.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry3ere.Text == "")
                {
                    ButtonVælg3ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ere.Sensitive = false;
                    ButtonStreg3ere.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry3ere.Text == "")
                {
                    ButtonVælg3ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ere.Sensitive = false;
                    ButtonStreg3ere.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry3ere.Text == "")
                {
                    ButtonVælg3ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ere.Sensitive = false;
                    ButtonStreg3ere.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg3ere.Sensitive = false;
        }

        if (nyKombi.PointFirere() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry4ere.Text == "")
                {
                    ButtonVælg4ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ere.Sensitive = false;
                    ButtonStreg4ere.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry4ere.Text == "")
                {
                    ButtonVælg4ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ere.Sensitive = false;
                    ButtonStreg4ere.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry4ere.Text == "")
                {
                    ButtonVælg4ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ere.Sensitive = false;
                    ButtonStreg4ere.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry4ere.Text == "")
                {
                    ButtonVælg4ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ere.Sensitive = false;
                    ButtonStreg4ere.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg4ere.Sensitive = false;
        }

        if (nyKombi.PointFemere() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry5ere.Text == "")
                {
                    ButtonVælg5ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg5ere.Sensitive = false;
                    ButtonStreg5ere.Sensitive = false;
                    }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry5ere.Text == "")
                {
                    ButtonVælg5ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg5ere.Sensitive = false;
                    ButtonStreg5ere.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry5ere.Text == "")
                {
                    ButtonVælg5ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg5ere.Sensitive = false;
                    ButtonStreg5ere.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry5ere.Text == "")
                {
                    ButtonVælg5ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg5ere.Sensitive = false;
                    ButtonStreg5ere.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg5ere.Sensitive = false;
        }

        if (nyKombi.PointSeksere() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry6ere.Text == "")
                {
                    ButtonVælg6ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg6ere.Sensitive = false;
                    ButtonStreg6ere.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry6ere.Text == "")
                {
                    ButtonVælg6ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg6ere.Sensitive = false;
                    ButtonStreg6ere.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry6ere.Text == "")
                {
                    ButtonVælg6ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg6ere.Sensitive = false;
                    ButtonStreg6ere.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry6ere.Text == "")
                {
                    ButtonVælg6ere.Sensitive = true;
                }
                else
                {
                    ButtonVælg6ere.Sensitive = false;
                    ButtonStreg6ere.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg6ere.Sensitive = false;
        }

        if (nyKombi.PointEtPar() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry1par.Text == "")
                {
                    ButtonVælg1par.Sensitive = true;
                }
                else
                {
                    ButtonVælg1par.Sensitive = false;
                    ButtonStreg1par.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry1par.Text == "")
                {
                    ButtonVælg1par.Sensitive = true;
                }
                else
                {
                    ButtonVælg1par.Sensitive = false;
                    ButtonStreg1par.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry1par.Text == "")
                {
                    ButtonVælg1par.Sensitive = true;
                }
                else
                {
                    ButtonVælg1par.Sensitive = false;
                    ButtonStreg1par.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry1par.Text == "")
                {
                    ButtonVælg1par.Sensitive = true;
                }
                else
                {
                    ButtonVælg1par.Sensitive = false;
                    ButtonStreg1par.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg1par.Sensitive = false;
        }

        if (nyKombi.PointToPar() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry2par.Text == "")
                {
                    ButtonVælg2par.Sensitive = true;
                }
                else
                {
                    ButtonVælg2par.Sensitive = false;
                    ButtonStreg2par.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry2par.Text == "")
                {
                    ButtonVælg2par.Sensitive = true;
                }
                else
                {
                    ButtonVælg2par.Sensitive = false;
                    ButtonStreg2par.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry2par.Text == "")
                {
                    ButtonVælg2par.Sensitive = true;
                }
                else
                {
                    ButtonVælg2par.Sensitive = false;
                    ButtonStreg2par.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry2par.Text == "")
                {
                    ButtonVælg2par.Sensitive = true;
                }
                else
                {
                    ButtonVælg2par.Sensitive = false;
                    ButtonStreg2par.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg2par.Sensitive = false;
        }

        if (nyKombi.PointTreEns() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry3ens.Text == "")
                {
                    ButtonVælg3ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ens.Sensitive = false;
                    ButtonStreg3ens.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry3ens.Text == "")
                {
                    ButtonVælg3ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ens.Sensitive = false;
                    ButtonStreg3ens.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry3ens.Text == "")
                {
                    ButtonVælg3ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ens.Sensitive = false;
                    ButtonStreg3ens.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry3ens.Text == "")
                {
                    ButtonVælg3ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg3ens.Sensitive = false;
                    ButtonStreg3ens.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg3ens.Sensitive = false;
        }

        if (nyKombi.PointFireEns() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_Entry4ens.Text == "")
                {
                    ButtonVælg4ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ens.Sensitive = false;
                    ButtonStreg4ens.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_Entry4ens.Text == "")
                {
                    ButtonVælg4ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ens.Sensitive = false;
                    ButtonStreg4ens.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_Entry4ens.Text == "")
                {
                    ButtonVælg4ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ens.Sensitive = false;
                    ButtonStreg4ens.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_Entry4ens.Text == "")
                {
                    ButtonVælg4ens.Sensitive = true;
                }
                else
                {
                    ButtonVælg4ens.Sensitive = false;
                    ButtonStreg4ens.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælg4ens.Sensitive = false;
        }

        if (nyKombi.LilleStraight() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_EntryLilleStraight.Text == "")
                {
                    ButtonVælgLilleStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgLilleStraight.Sensitive = false;
                    ButtonStregLilleStraight.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_EntryLilleStraight.Text == "")
                {
                    ButtonVælgLilleStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgLilleStraight.Sensitive = false;
                    ButtonStregLilleStraight.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_EntryLilleStraight.Text == "")
                {
                    ButtonVælgLilleStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgLilleStraight.Sensitive = false;
                    ButtonStregLilleStraight.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_EntryLilleStraight.Text == "")
                {
                    ButtonVælgLilleStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgLilleStraight.Sensitive = false;
                    ButtonStregLilleStraight.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælgLilleStraight.Sensitive = false;
        }

        if (nyKombi.StorStraight() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_EntryStorStraight.Text == "")
                {
                    ButtonVælgStorStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgStorStraight.Sensitive = false;
                    ButtonStregStorStraight.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_EntryStorStraight.Text == "")
                {
                    ButtonVælgStorStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgStorStraight.Sensitive = false;
                    ButtonStregStorStraight.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_EntryStorStraight.Text == "")
                {
                    ButtonVælgStorStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgStorStraight.Sensitive = false;
                    ButtonStregStorStraight.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_EntryStorStraight.Text == "")
                {
                    ButtonVælgStorStraight.Sensitive = true;
                }
                else
                {
                    ButtonVælgStorStraight.Sensitive = false;
                    ButtonStregStorStraight.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælgStorStraight.Sensitive = false;
        }

        if (nyKombi.PointFuldtHus() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_EntryFuldtHus.Text == "")
                {
                    ButtonVælgFuldtHus.Sensitive = true;
                }
                else
                {
                    ButtonVælgFuldtHus.Sensitive = false;
                    ButtonStregFuldtHus.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_EntryFuldtHus.Text == "")
                {
                    ButtonVælgFuldtHus.Sensitive = true;
                }
                else
                {
                    ButtonVælgFuldtHus.Sensitive = false;
                    ButtonStregFuldtHus.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_EntryFuldtHus.Text == "")
                {
                    ButtonVælgFuldtHus.Sensitive = true;
                }
                else
                {
                    ButtonVælgFuldtHus.Sensitive = false;
                    ButtonStregFuldtHus.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_EntryFuldtHus.Text == "")
                {
                    ButtonVælgFuldtHus.Sensitive = true;
                }
                else
                {
                    ButtonVælgFuldtHus.Sensitive = false;
                    ButtonStregFuldtHus.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælgFuldtHus.Sensitive = false;
        }

        if (nyKombi.PointChancen() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_EntryChancen.Text == "")
                {
                    ButtonVælgChancen.Sensitive = true;
                }
                else
                {
                    ButtonVælgChancen.Sensitive = false;
                    ButtonStregChancen.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_EntryChancen.Text == "")
                {
                    ButtonVælgChancen.Sensitive = true;
                }
                else
                {
                    ButtonVælgChancen.Sensitive = false;
                    ButtonStregChancen.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_EntryChancen.Text == "")
                {
                    ButtonVælgChancen.Sensitive = true;
                }
                else
                {
                    ButtonVælgChancen.Sensitive = false;
                    ButtonStregChancen.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_EntryChancen.Text == "")
                {
                    ButtonVælgChancen.Sensitive = true;
                }
                else
                {
                    ButtonVælgChancen.Sensitive = false;
                    ButtonStregChancen.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælgChancen.Sensitive = false;
        }

        if (nyKombi.PointYatzy() > 0)
        {
            if (SpillerNr == 1)
            {
                if (Spl1_EntryYatzy.Text == "")
                {
                    ButtonVælgYatzy.Sensitive = true;
                }
                else
                {
                    ButtonVælgYatzy.Sensitive = false;
                    ButtonStregYatzy.Sensitive = false;
                }
            }

            if (SpillerNr == 2)
            {
                if (Spl2_EntryYatzy.Text == "")
                {
                    ButtonVælgYatzy.Sensitive = true;
                }
                else
                {
                    ButtonVælgYatzy.Sensitive = false;
                    ButtonStregYatzy.Sensitive = false;
                }
            }

            if (SpillerNr == 3)
            {
                if (Spl3_EntryYatzy.Text == "")
                {
                    ButtonVælgYatzy.Sensitive = true;
                }
                else
                {
                    ButtonVælgYatzy.Sensitive = false;
                    ButtonStregYatzy.Sensitive = false;
                }
            }

            if (SpillerNr == 4)
            {
                if (Spl4_EntryYatzy.Text == "")
                {
                    ButtonVælgYatzy.Sensitive = true;
                }
                else
                {
                    ButtonVælgYatzy.Sensitive = false;
                    ButtonStregYatzy.Sensitive = false;
                }
            }
        }
        else
        {
            ButtonVælgYatzy.Sensitive = false;
        }
    }

    int SpillerNr = 1; //Starter med Spiller 1

    int SlagTilbage = 3; //Starter med 3 Slag

    private void SkiftSpiller() // Hver gang SkiftSpiller kaldes
    {
            ButtonStreg1ere.Sensitive = true; // Aktiverer streg knapper igen
            ButtonStreg2ere.Sensitive = true;
            ButtonStreg3ere.Sensitive = true;
            ButtonStreg4ere.Sensitive = true;
            ButtonStreg5ere.Sensitive = true;
            ButtonStreg6ere.Sensitive = true;
            ButtonStreg1par.Sensitive = true;
            ButtonStreg2par.Sensitive = true;
            ButtonStreg3ens.Sensitive = true;
            ButtonStreg4ens.Sensitive = true;
            ButtonStregLilleStraight.Sensitive = true;
            ButtonStregStorStraight.Sensitive = true;
            ButtonStregFuldtHus.Sensitive = true;
            ButtonStregChancen.Sensitive = true;
            ButtonStregYatzy.Sensitive = true;
            
            SlagTilbage = 3; // Har ny spiller 3 slag
            LabelSlagTilbage.Text = SlagTilbage.ToString(); //Output i GUI
            BtnKastTerning.Sensitive = true;
            checkbutton1.Active = false;
            checkbutton2.Active = false;
            checkbutton3.Active = false;
            checkbutton4.Active = false;
            checkbutton5.Active = false;
            entryTerning1.Text = "";
            entryTerning2.Text = "";
            entryTerning3.Text = "";
            entryTerning4.Text = "";
            entryTerning5.Text = "";

            if (SpillerNr == 4) //Hvis SkiftSpiller er kaldet imens Spiller 4
            {
                SpillerNr = 1; // Så bliver det Spiller 1's tur
            }
            else { SpillerNr = SpillerNr + 1; } // Hvis ikke, plusses Nr med 1

        if (SpillerNr == 1)
        {
            LabelHvisTur.Text = Spiller1Navn.Text + "'s tur"; // Tager evt. navn
            if (Spiller1Navn.Text == "") // Hvis tomt, så skriv generisk Nr
            {
                LabelHvisTur.Text = "Spiller " + SpillerNr.ToString() + "'s tur";
            }
        }

        else if (SpillerNr == 2)
        {
            LabelHvisTur.Text = Spiller2Navn.Text + "'s tur";
            if (Spiller2Navn.Text == "")
            {
                LabelHvisTur.Text = "Spiller " + SpillerNr.ToString() + "'s tur";
            }
        }

        else if (SpillerNr == 3)
        {
            LabelHvisTur.Text = Spiller3Navn.Text + "'s tur";
            if (Spiller3Navn.Text == "")
            {
                LabelHvisTur.Text = "Spiller " + SpillerNr.ToString() + "'s tur";
            }
        }

        else if (SpillerNr == 4)
        {
            LabelHvisTur.Text = Spiller4Navn.Text + "'s tur";
            if (Spiller4Navn.Text == "")
            {
                LabelHvisTur.Text = "Spiller " + SpillerNr.ToString() + "'s tur";
            }
        }

        SumSpiller(); //SumSpiller kaldes hver gang spiller skiftes
        BonusSpiller(); //BonusSpiller kaldes hver gang spiller skiftes
    }

    protected void OnBtnNewGameClicked(object sender, EventArgs e)
    {
        BtnKastTerning.Sensitive = true; //Kast terning knap aktiveres
        SpillerNr = 1;
        SlagTilbage = 3;
        LabelSlagTilbage.Text = SlagTilbage.ToString(); // SlagTilbage i GUI
        LabelHvisTur.Text = Spiller1Navn.Text + "'s tur"; // Hvis tur i GUI
        if (Spiller1Navn.Text == "") // Hvis tom, så generisk spillernummer
        {
            LabelHvisTur.Text = "Spiller " + SpillerNr.ToString() + "'s tur";
        }
        ResetGUI();
    }

    private void ResetGUI()
    {
        entryTerning1.Text = "";
        entryTerning2.Text = "";
        entryTerning3.Text = "";
        entryTerning4.Text = "";
        entryTerning5.Text = "";
        checkbutton1.Active = false;
        checkbutton2.Active = false;
        checkbutton3.Active = false;
        checkbutton4.Active = false;
        checkbutton5.Active = false;

        Spl1_Entry1ere.Text = "";
        Spl1_Entry2ere.Text = "";
        Spl1_Entry3ere.Text = "";
        Spl1_Entry4ere.Text = "";
        Spl1_Entry5ere.Text = "";
        Spl1_Entry6ere.Text = "";
        Spl1_EntrySum.Text = "";
        Spl1_EntryBonus.Text = "";
        Spl1_Entry1par.Text = "";
        Spl1_Entry2par.Text = "";
        Spl1_Entry3ens.Text = "";
        Spl1_Entry4ens.Text = "";
        Spl1_EntryLilleStraight.Text = "";
        Spl1_EntryStorStraight.Text = "";
        Spl1_EntryFuldtHus.Text = "";
        Spl1_EntryChancen.Text = "";
        Spl1_EntryYatzy.Text = "";
        Spl1_EntrySumIAlt.Text = "";

        Spl2_Entry1ere.Text = "";
        Spl2_Entry2ere.Text = "";
        Spl2_Entry3ere.Text = "";
        Spl2_Entry4ere.Text = "";
        Spl2_Entry5ere.Text = "";
        Spl2_Entry6ere.Text = "";
        Spl2_EntrySum.Text = "";
        Spl2_EntryBonus.Text = "";
        Spl2_Entry1par.Text = "";
        Spl2_Entry2par.Text = "";
        Spl2_Entry3ens.Text = "";
        Spl2_Entry4ens.Text = "";
        Spl2_EntryLilleStraight.Text = "";
        Spl2_EntryStorStraight.Text = "";
        Spl2_EntryFuldtHus.Text = "";
        Spl2_EntryChancen.Text = "";
        Spl2_EntryYatzy.Text = "";
        Spl2_EntrySumIAlt.Text = "";

        Spl3_Entry1ere.Text = "";
        Spl3_Entry2ere.Text = "";
        Spl3_Entry3ere.Text = "";
        Spl3_Entry4ere.Text = "";
        Spl3_Entry5ere.Text = "";
        Spl3_Entry6ere.Text = "";
        Spl3_EntrySum.Text = "";
        Spl3_EntryBonus.Text = "";
        Spl3_Entry1par.Text = "";
        Spl3_Entry2par.Text = "";
        Spl3_Entry3ens.Text = "";
        Spl3_Entry4ens.Text = "";
        Spl3_EntryLilleStraight.Text = "";
        Spl3_EntryStorStraight.Text = "";
        Spl3_EntryFuldtHus.Text = "";
        Spl3_EntryChancen.Text = "";
        Spl3_EntryYatzy.Text = "";
        Spl3_EntrySumIAlt.Text = "";

        Spl4_Entry1ere.Text = "";
        Spl4_Entry2ere.Text = "";
        Spl4_Entry3ere.Text = "";
        Spl4_Entry4ere.Text = "";
        Spl4_Entry5ere.Text = "";
        Spl4_Entry6ere.Text = "";
        Spl4_EntrySum.Text = "";
        Spl4_EntryBonus.Text = "";
        Spl4_Entry1par.Text = "";
        Spl4_Entry2par.Text = "";
        Spl4_Entry3ens.Text = "";
        Spl4_Entry4ens.Text = "";
        Spl4_EntryLilleStraight.Text = "";
        Spl4_EntryStorStraight.Text = "";
        Spl4_EntryFuldtHus.Text = "";
        Spl4_EntryChancen.Text = "";
        Spl4_EntryYatzy.Text = "";
        Spl4_EntrySumIAlt.Text = "";
    }

    protected void OnButtonVælg1ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry1ere.Text = nyKombi.PointEnere().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry1ere.Text = nyKombi.PointEnere().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry1ere.Text = nyKombi.PointEnere().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry1ere.Text = nyKombi.PointEnere().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg1ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry1ere.Text == "")
            {
                Spl1_Entry1ere.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry1ere.Text == "")
            {
                Spl2_Entry1ere.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry1ere.Text == "")
            {
                Spl3_Entry1ere.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry1ere.Text == "")
            {
                Spl4_Entry1ere.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg2ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry2ere.Text = nyKombi.PointToere().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry2ere.Text = nyKombi.PointToere().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry2ere.Text = nyKombi.PointToere().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry2ere.Text = nyKombi.PointToere().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg2ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry2ere.Text == "")
            {
                Spl1_Entry2ere.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry2ere.Text == "")
            {
                Spl2_Entry2ere.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry2ere.Text == "")
            {
                Spl3_Entry2ere.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry2ere.Text == "")
            {
                Spl4_Entry2ere.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg3ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry3ere.Text = nyKombi.PointTreere().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry3ere.Text = nyKombi.PointTreere().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry3ere.Text = nyKombi.PointTreere().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry3ere.Text = nyKombi.PointTreere().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg3ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry3ere.Text == "")
            {
                Spl1_Entry3ere.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry3ere.Text == "")
            {
                Spl2_Entry3ere.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry3ere.Text == "")
            {
                Spl3_Entry3ere.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry3ere.Text == "")
            {
                Spl4_Entry3ere.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg4ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry4ere.Text = nyKombi.PointFirere().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry4ere.Text = nyKombi.PointFirere().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry4ere.Text = nyKombi.PointFirere().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry4ere.Text = nyKombi.PointFirere().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg4ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry4ere.Text == "")
            {
                Spl1_Entry4ere.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry4ere.Text == "")
            {
                Spl2_Entry4ere.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry4ere.Text == "")
            {
                Spl3_Entry4ere.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry4ere.Text == "")
            {
                Spl4_Entry4ere.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg5ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry5ere.Text = nyKombi.PointFemere().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry5ere.Text = nyKombi.PointFemere().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry5ere.Text = nyKombi.PointFemere().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry5ere.Text = nyKombi.PointFemere().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg5ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry5ere.Text == "")
            {
                Spl1_Entry5ere.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry5ere.Text == "")
            {
                Spl2_Entry5ere.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry5ere.Text == "")
            {
                Spl3_Entry5ere.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry5ere.Text == "")
            {
                Spl4_Entry5ere.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg6ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry6ere.Text = nyKombi.PointSeksere().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry6ere.Text = nyKombi.PointSeksere().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry6ere.Text = nyKombi.PointSeksere().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry6ere.Text = nyKombi.PointSeksere().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg6ereClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry6ere.Text == "")
            {
                Spl1_Entry6ere.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry6ere.Text == "")
            {
                Spl2_Entry6ere.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry6ere.Text == "")
            {
                Spl3_Entry6ere.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry6ere.Text == "")
            {
                Spl4_Entry6ere.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg1parClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry1par.Text = nyKombi.PointEtPar().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry1par.Text = nyKombi.PointEtPar().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry1par.Text = nyKombi.PointEtPar().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry1par.Text = nyKombi.PointEtPar().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg1parClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry1par.Text == "")
            {
                Spl1_Entry1par.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry1par.Text == "")
            {
                Spl2_Entry1par.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry1par.Text == "")
            {
                Spl3_Entry1par.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry1par.Text == "")
            {
                Spl4_Entry1par.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg2parClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry2par.Text = nyKombi.PointToPar().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry2par.Text = nyKombi.PointToPar().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry2par.Text = nyKombi.PointToPar().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry2par.Text = nyKombi.PointToPar().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg2parClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry2par.Text == "")
            {
                Spl1_Entry2par.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry2par.Text == "")
            {
                Spl2_Entry2par.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry2par.Text == "")
            {
                Spl3_Entry2par.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry2par.Text == "")
            {
                Spl4_Entry2par.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg3ensClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry3ens.Text = nyKombi.PointTreEns().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry3ens.Text = nyKombi.PointTreEns().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry3ens.Text = nyKombi.PointTreEns().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry3ens.Text = nyKombi.PointTreEns().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg3ensClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry3ens.Text == "")
            {
                Spl1_Entry3ens.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry3ens.Text == "")
            {
                Spl2_Entry3ens.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry3ens.Text == "")
            {
                Spl3_Entry3ens.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry3ens.Text == "")
            {
                Spl4_Entry3ens.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælg4ensClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_Entry4ens.Text = nyKombi.PointFireEns().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_Entry4ens.Text = nyKombi.PointFireEns().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_Entry4ens.Text = nyKombi.PointFireEns().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_Entry4ens.Text = nyKombi.PointFireEns().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStreg4ensClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_Entry4ens.Text == "")
            {
                Spl1_Entry4ens.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_Entry4ens.Text == "")
            {
                Spl2_Entry4ens.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_Entry4ens.Text == "")
            {
                Spl3_Entry4ens.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_Entry4ens.Text == "")
            {
                Spl4_Entry4ens.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælgLilleStraightClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_EntryLilleStraight.Text = nyKombi.LilleStraight().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_EntryLilleStraight.Text = nyKombi.LilleStraight().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_EntryLilleStraight.Text = nyKombi.LilleStraight().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_EntryLilleStraight.Text = nyKombi.LilleStraight().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStregLilleStraightClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_EntryLilleStraight.Text == "")
            {
                Spl1_EntryLilleStraight.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_EntryLilleStraight.Text == "")
            {
                Spl2_EntryLilleStraight.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_EntryLilleStraight.Text == "")
            {
                Spl3_EntryLilleStraight.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_EntryLilleStraight.Text == "")
            {
                Spl4_EntryLilleStraight.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælgStorStraightClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_EntryStorStraight.Text = nyKombi.StorStraight().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_EntryStorStraight.Text = nyKombi.StorStraight().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_EntryStorStraight.Text = nyKombi.StorStraight().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_EntryStorStraight.Text = nyKombi.StorStraight().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStregStorStraightClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_EntryStorStraight.Text == "")
            {
                Spl1_EntryStorStraight.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_EntryStorStraight.Text == "")
            {
                Spl2_EntryStorStraight.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_EntryStorStraight.Text == "")
            {
                Spl3_EntryStorStraight.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_EntryStorStraight.Text == "")
            {
                Spl4_EntryStorStraight.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælgFuldtHusClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_EntryFuldtHus.Text = nyKombi.PointFuldtHus().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_EntryFuldtHus.Text = nyKombi.PointFuldtHus().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_EntryFuldtHus.Text = nyKombi.PointFuldtHus().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_EntryFuldtHus.Text = nyKombi.PointFuldtHus().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStregFuldtHusClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_EntryFuldtHus.Text == "")
            {
                Spl1_EntryFuldtHus.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_EntryFuldtHus.Text == "")
            {
                Spl2_EntryFuldtHus.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_EntryFuldtHus.Text == "")
            {
                Spl3_EntryFuldtHus.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_EntryFuldtHus.Text == "")
            {
                Spl4_EntryFuldtHus.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælgChancenClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_EntryChancen.Text = nyKombi.PointChancen().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_EntryChancen.Text = nyKombi.PointChancen().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_EntryChancen.Text = nyKombi.PointChancen().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_EntryChancen.Text = nyKombi.PointChancen().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStregChancenClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_EntryChancen.Text == "")
            {
                Spl1_EntryChancen.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_EntryChancen.Text == "")
            {
                Spl2_EntryChancen.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_EntryChancen.Text == "")
            {
                Spl3_EntryChancen.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_EntryChancen.Text == "")
            {
                Spl4_EntryChancen.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonVælgYatzyClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            Spl1_EntryYatzy.Text = nyKombi.PointYatzy().ToString();
        }
        else if (SpillerNr == 2)
        {
            Spl2_EntryYatzy.Text = nyKombi.PointYatzy().ToString();
        }
        else if (SpillerNr == 3)
        {
            Spl3_EntryYatzy.Text = nyKombi.PointYatzy().ToString();
        }
        else if (SpillerNr == 4)
        {
            Spl4_EntryYatzy.Text = nyKombi.PointYatzy().ToString();
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    protected void OnButtonStregYatzyClicked(object sender, EventArgs e)
    {
        if (SpillerNr == 1)
        {
            if (Spl1_EntryYatzy.Text == "")
            {
                Spl1_EntryYatzy.Text = "---";
            }
        }
        else if (SpillerNr == 2)
        {
            if (Spl2_EntryYatzy.Text == "")
            {
                Spl2_EntryYatzy.Text = "---";
            }
        }
        else if (SpillerNr == 3)
        {
            if (Spl3_EntryYatzy.Text == "")
            {
                Spl3_EntryYatzy.Text = "---";
            }
        }
        else if (SpillerNr == 4)
        {
            if (Spl4_EntryYatzy.Text == "")
            {
                Spl4_EntryYatzy.Text = "---";
            }
        }
        SlagTilbage = 0;
        SkiftSpiller();
    }

    public void SumSpiller()
    {
        int.TryParse(Spl1_Entry1ere.Text, out int spl1_ettere);
        int.TryParse(Spl1_Entry2ere.Text, out int spl1_toere);
        int.TryParse(Spl1_Entry3ere.Text, out int spl1_treere);
        int.TryParse(Spl1_Entry4ere.Text, out int spl1_firere);
        int.TryParse(Spl1_Entry5ere.Text, out int spl1_femmere);
        int.TryParse(Spl1_Entry6ere.Text, out int spl1_seksere);
        int SumResultatSpl1 = spl1_ettere + spl1_toere + spl1_treere + spl1_firere + spl1_femmere + spl1_seksere;
        Spl1_EntrySum.Text = SumResultatSpl1.ToString();

        int.TryParse(Spl2_Entry1ere.Text, out int spl2_ettere);
        int.TryParse(Spl2_Entry2ere.Text, out int spl2_toere);
        int.TryParse(Spl2_Entry3ere.Text, out int spl2_treere);
        int.TryParse(Spl2_Entry4ere.Text, out int spl2_firere);
        int.TryParse(Spl2_Entry5ere.Text, out int spl2_femmere);
        int.TryParse(Spl2_Entry6ere.Text, out int spl2_seksere);
        int SumResultatSpl2 = spl2_ettere + spl2_toere + spl2_treere + spl2_firere + spl2_femmere + spl2_seksere;
        Spl2_EntrySum.Text = SumResultatSpl2.ToString();

        int.TryParse(Spl3_Entry1ere.Text, out int spl3_ettere);
        int.TryParse(Spl3_Entry2ere.Text, out int spl3_toere);
        int.TryParse(Spl3_Entry3ere.Text, out int spl3_treere);
        int.TryParse(Spl3_Entry4ere.Text, out int spl3_firere);
        int.TryParse(Spl3_Entry5ere.Text, out int spl3_femmere);
        int.TryParse(Spl3_Entry6ere.Text, out int spl3_seksere);
        int SumResultatSpl3 = spl3_ettere + spl3_toere + spl3_treere + spl3_firere + spl3_femmere + spl3_seksere;
        Spl3_EntrySum.Text = SumResultatSpl3.ToString();

        int.TryParse(Spl4_Entry1ere.Text, out int spl4_ettere);
        int.TryParse(Spl4_Entry2ere.Text, out int spl4_toere);
        int.TryParse(Spl4_Entry3ere.Text, out int spl4_treere);
        int.TryParse(Spl4_Entry4ere.Text, out int spl4_firere);
        int.TryParse(Spl4_Entry5ere.Text, out int spl4_femmere);
        int.TryParse(Spl4_Entry6ere.Text, out int spl4_seksere);
        int SumResultatSpl4 = spl4_ettere + spl4_toere + spl4_treere + spl4_firere + spl4_femmere + spl4_seksere;
        Spl4_EntrySum.Text = SumResultatSpl4.ToString();
    }

    public void BonusSpiller()
    {
        int.TryParse(Spl1_EntrySum.Text, out int SumSpiller1);
        if (SumSpiller1 >= 63)
        {
            Spl1_EntryBonus.Text ="50";
        }

        int.TryParse(Spl2_EntrySum.Text, out int SumSpiller2);
        if (SumSpiller2 >= 63)
        {
            Spl2_EntryBonus.Text = "50";
        }

        int.TryParse(Spl3_EntrySum.Text, out int SumSpiller3);
        if (SumSpiller3 >= 63)
        {
            Spl3_EntryBonus.Text = "50";
        }

        int.TryParse(Spl4_EntrySum.Text, out int SumSpiller4);
        if (SumSpiller4 >= 63)
        {
            Spl4_EntryBonus.Text = "50";
        }
    }

    protected void OnButtonFindVinderClicked(object sender, EventArgs e)
    {
        int.TryParse(Spl1_EntrySum.Text, out int spl1_sum);
        int.TryParse(Spl1_EntryBonus.Text, out int spl1_bonus);
        int.TryParse(Spl1_Entry1par.Text, out int spl1_etpar);
        int.TryParse(Spl1_Entry2par.Text, out int spl1_topar);
        int.TryParse(Spl1_Entry3ens.Text, out int spl1_treens);
        int.TryParse(Spl1_Entry4ens.Text, out int spl1_fireens);
        int.TryParse(Spl1_EntryLilleStraight.Text, out int spl1_lillestraight);
        int.TryParse(Spl1_EntryStorStraight.Text, out int spl1_storstraight);
        int.TryParse(Spl1_EntryFuldtHus.Text, out int spl1_fuldthus);
        int.TryParse(Spl1_EntryChancen.Text, out int spl1_chancen);
        int.TryParse(Spl1_EntryYatzy.Text, out int spl1_yatzy);
        int SumTotalSpl1 = spl1_sum + spl1_bonus + spl1_etpar + spl1_topar + spl1_treens + spl1_fireens + spl1_lillestraight + spl1_storstraight + spl1_fuldthus + spl1_chancen + spl1_yatzy;
        Spl1_EntrySumIAlt.Text = SumTotalSpl1.ToString();

        int.TryParse(Spl2_EntrySum.Text, out int spl2_sum);
        int.TryParse(Spl2_EntryBonus.Text, out int spl2_bonus);
        int.TryParse(Spl2_Entry1par.Text, out int spl2_etpar);
        int.TryParse(Spl2_Entry2par.Text, out int spl2_topar);
        int.TryParse(Spl2_Entry3ens.Text, out int spl2_treens);
        int.TryParse(Spl2_Entry4ens.Text, out int spl2_fireens);
        int.TryParse(Spl2_EntryLilleStraight.Text, out int spl2_lillestraight);
        int.TryParse(Spl2_EntryStorStraight.Text, out int spl2_storstraight);
        int.TryParse(Spl2_EntryFuldtHus.Text, out int spl2_fuldthus);
        int.TryParse(Spl2_EntryChancen.Text, out int spl2_chancen);
        int.TryParse(Spl2_EntryYatzy.Text, out int spl2_yatzy);
        int SumTotalSpl2 = spl2_sum + spl2_bonus + spl2_etpar + spl2_topar + spl2_treens + spl2_fireens + spl2_lillestraight + spl2_storstraight + spl2_fuldthus + spl2_chancen + spl2_yatzy;
        Spl2_EntrySumIAlt.Text = SumTotalSpl2.ToString();

        int.TryParse(Spl3_EntrySum.Text, out int spl3_sum);
        int.TryParse(Spl3_EntryBonus.Text, out int spl3_bonus);
        int.TryParse(Spl3_Entry1par.Text, out int spl3_etpar);
        int.TryParse(Spl3_Entry2par.Text, out int spl3_topar);
        int.TryParse(Spl3_Entry3ens.Text, out int spl3_treens);
        int.TryParse(Spl3_Entry4ens.Text, out int spl3_fireens);
        int.TryParse(Spl3_EntryLilleStraight.Text, out int spl3_lillestraight);
        int.TryParse(Spl3_EntryStorStraight.Text, out int spl3_storstraight);
        int.TryParse(Spl3_EntryFuldtHus.Text, out int spl3_fuldthus);
        int.TryParse(Spl3_EntryChancen.Text, out int spl3_chancen);
        int.TryParse(Spl3_EntryYatzy.Text, out int spl3_yatzy);
        int SumTotalSpl3 = spl3_sum + spl3_bonus + spl3_etpar + spl3_topar + spl3_treens + spl3_fireens + spl3_lillestraight + spl3_storstraight + spl3_fuldthus + spl3_chancen + spl3_yatzy;
        Spl3_EntrySumIAlt.Text = SumTotalSpl3.ToString();

        int.TryParse(Spl4_EntrySum.Text, out int spl4_sum);
        int.TryParse(Spl4_EntryBonus.Text, out int spl4_bonus);
        int.TryParse(Spl4_Entry1par.Text, out int spl4_etpar);
        int.TryParse(Spl4_Entry2par.Text, out int spl4_topar);
        int.TryParse(Spl4_Entry3ens.Text, out int spl4_treens);
        int.TryParse(Spl4_Entry4ens.Text, out int spl4_fireens);
        int.TryParse(Spl4_EntryLilleStraight.Text, out int spl4_lillestraight);
        int.TryParse(Spl4_EntryStorStraight.Text, out int spl4_storstraight);
        int.TryParse(Spl4_EntryFuldtHus.Text, out int spl4_fuldthus);
        int.TryParse(Spl4_EntryChancen.Text, out int spl4_chancen);
        int.TryParse(Spl4_EntryYatzy.Text, out int spl4_yatzy);
        int SumTotalSpl4 = spl4_sum + spl4_bonus + spl4_etpar + spl4_topar + spl4_treens + spl4_fireens + spl4_lillestraight + spl4_storstraight + spl4_fuldthus + spl4_chancen + spl4_yatzy;
        Spl4_EntrySumIAlt.Text = SumTotalSpl4.ToString();
    }
}