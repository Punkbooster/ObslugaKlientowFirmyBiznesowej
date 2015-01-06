using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for au_DostępDoDanychPracowników
/// </summary>
public class au_DostępDoDanychPracowników
{
	public au_DostępDoDanychPracowników()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void ZapiszDaneKontaktowe(string IdAspNetDB, string Imię,
        string Nazwisko, string Dyspozycyjność, string Ulica, string NrDomuMieszkania, string KodPocztowy,
        string Miejscowość, string Email, string NrTelefonu, string UwagiDodatkowe);
{
    au_ListaPracownikówTableAdapters.PracownicyFirmyTabeAdapter
        AdapterPracownikówFirmy = new au_ListaPracownikówTableAdapters.PracownicyFirmyTableAdapter();
        AdapterPracownikówFirmy.Insert(IdAspNetDB, Imię, Nazwisko, Dyspozycyjność, Ulica, NrDomuMieszkania, KodPocztowy, Miejscowość,
    Email, NrTelefonu, UwagiDodatkowe);
}
}
