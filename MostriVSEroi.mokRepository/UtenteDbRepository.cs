using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MostriVSEroi.mokRepository
{
    public class UtenteDbRepository : IUtenteRepository
    {
        
        const string connectionString = @"Data Source= (localdb)\MSSQLLocalDB;" +
                                        "Initial Catalog = MostriVSEroi1;" + "integrated Security=true;";

        public static List<Utente> GetUtenti()
        {

            List<Utente> utenti = new List<Utente>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand
            {

                Connection = connection,

                CommandType = System.Data.CommandType.Text,
                
                CommandText = "select * from dbo.VistaUtentiCompleta"
            };
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = (int)reader[0];
                var username = reader[1];
                var password = reader[2];
                var livello = (int)reader[3];
                var punti = (int)reader[4];


                Utente utente = new Utente(id,(string)username, (string)password,livello,punti);
                
                utenti.Add(utente);

            }
            connection.Close();
            return utenti;
        }
        public static void InserisciUtente(string username, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into dbo.Utenti values (@Username,@Password) ";
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //public static int AssociaLivelloAUtente(string username,string password)
        //{
        //    int id;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand();

        //        command.Connection = connection;

        //        command.CommandType = System.Data.CommandType.Text;
        //        command.CommandText = "select IdUtente from dbo.Utenti where Username=@Username and Password=@Password) ";
        //        command.Parameters.AddWithValue("@Username", username);
        //        command.Parameters.AddWithValue("@Password", password);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int id = (int)reader[0];
        //        }
                
        //            command.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    return id;
        //}

    } 

    }

