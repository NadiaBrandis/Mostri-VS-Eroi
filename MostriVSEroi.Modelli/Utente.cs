using System;

namespace MostriVSEroi.Modelli
{
    public class Utente
    {
        public int IdUtente { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Livello { get; set; }
        public int PuntiVita { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAdmin { get; set; }
       
        public Utente(int id,string username,string password,int livello,int punti)
        {
            Livello = livello;
            PuntiVita = punti;
            IdUtente=id;
            Username = username;
            Password = password;
            IsAuthenticated = false;
            IsAdmin = false;
        }
        public Utente(string username,string password)
        {
            Username = username;
            Password = password;
        }
    }
}
