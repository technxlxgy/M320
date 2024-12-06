using Vererbungsaufgabe04_Hund;

Jagdhund jagdhund1 = new Jagdhund(100, 70);
EntfesselterJagdhund entfesselterJagdhund1 = new EntfesselterJagdhund("Grosse Blutdurst", 47, 88);

jagdhund1.Bellen();
jagdhund1.Fass("ein Kaninchen");
jagdhund1.GetGeschwindigkeit();
jagdhund1.GetGroesse();
entfesselterJagdhund1.Bellen();
entfesselterJagdhund1.Fass("ein Schaf");
entfesselterJagdhund1.Zerfetzen(15);
entfesselterJagdhund1.GetGeschwindigkeit();
entfesselterJagdhund1.GetGroesse();