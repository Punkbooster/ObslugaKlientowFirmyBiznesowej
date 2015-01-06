using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class au_RejestracjaPracownikow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // sprawdzenie tożsamości
        if (User.Identity.IsAuthenticated == false)
            Server.Transfer("Login.aspx");
        // sprawdazanie przy urzyciu metody is InRole
        if (!User.IsInRole("administrator"))
            Server.Transfer("BezUprawnien.aspx");

        }
    protected void  MultiView1_ActiveViewChanged(object sender, EventArgs e)
{

}

    protected void btnAnuluj_Click(object sender, EventArgs e)
    {
        Response.Redirect("StronaFrontowaSerwisu.aspx"); // przekierowanie na strone frontowa
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }
    protected void CreateUserWizard1_CreateUser(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1; // ustawienie nowej perspektywy
  //      System.Web.Security.Roles.AddUserToRole(CreateUserWizard1.UserName,rdbRole.SelectedItem.ToString());
    }
    protected void btnZapiszdaneKontaktowe_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        au_DostępDoDanychPracowników ObiektDDD = new au_DostępDoDanychPracowników();
        try 
        {
        ObiektDDD.ZapiszDaneKontaktowe(UserIdentity.Name, txtImię.text, txtNazwisko.text, ddlDyspozycyjność.SelectedItem.text, 
            txtUlica.text, txtNrDomuMoieszkania.text, txtKodPocztowy.text, txtMiejscowość.text, txtEmail.text, txtTelefon.text, 
            "brak uwag");
            // wizualizacja widoku
            MultiView1.ActiveViewIndex = 2;
            // wizualizacja komunikatu o udanej rejetracji
            lblUdanaRejestracja.text = "Rejestracja została pomyślnie zakonczona!";
        }
        catch (Exception ee)
        {
        // wizualizacja widoku kontenera View 3
            MultiView1.ActiveViewIndex = 2;
        // wizualizacja komunikatu o nie udanej rejestracji
            lblUdanaRejestracja.Text = "Rejestracja nie powiodłą się. Sprobuj jeszcze raz!";
        }
    }
}