//CODIGO
namespace BlazorAppNr1.Pages;
using System;
using Microsoft.AspNetCore.Components.Web;

public  partial class Tastatur
{

    private string taste = string.Empty;
    private string wert = string.Empty;
    private void VerarbeiteTaste (KeyboardEventArgs e){

        taste = e.Key;

    }
}
