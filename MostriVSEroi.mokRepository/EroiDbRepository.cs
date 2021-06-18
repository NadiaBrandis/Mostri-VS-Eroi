using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MostriVSEroi.mokRepository
{
    public  class EroiDbRepository
    {
        const string connectionString = @"Data Source= (localdb)\MSSQLLocalDB;" +
                                        "Initial Catalog = MostriVSEroi1;" + "integrated Security=true;";
        public static List<Eroe> GetEroi()
        {

            List<Eroe> eroi = new List<Eroe>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand
            {

                Connection = connection,

                CommandType = System.Data.CommandType.Text,
               
                CommandText = " select * from dbo.VistaEroiArmi"
            };



                    
                
                SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                var nome = reader[0];
                var categoria = reader[1];
                var arma = reader[2];
                var puntiDanno =Int32.Parse((string)reader[3]);
                int idEroe = (int)reader[4];
                int livello = (int)reader[5];
                int puntiVita = (int)reader[6];
                
               

                ArmaEroe armaE = new ArmaEroe(arma.ToString(),(int)puntiDanno);

                Eroe eroe = new Eroe((int)idEroe,(string)nome, (string)categoria, armaE,livello,puntiVita);
                eroi.Add(eroe);
            }
            connection.Close();
            return eroi;
            
        }

        public static void EliminaEroe(int idEroe)
        {
           
        }

        public static void CreaEroe(string nomeEroe,string categoria,string armaEroe,int livello,int punti)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into dbo.Eroi values (@NomeEroe,@Categoria,@NomeArma,@LivelloEroe,@PuntiVita) ";
                command.Parameters.AddWithValue("@NomeEroe", nomeEroe);
                command.Parameters.AddWithValue("@Categoria",categoria);
                command.Parameters.AddWithValue("@NomeArma", armaEroe);
                command.Parameters.AddWithValue("@LivelloEroe", livello);
                command.Parameters.AddWithValue("@PuntiVita", punti);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static List<ArmaEroe> GetArma()
        {
            List<ArmaEroe> armiEroi = new List<ArmaEroe>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand
            {

                Connection = connection,

                CommandType = System.Data.CommandType.Text,

                CommandText = " select * from dbo.ArmiEroi"
            };





            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                
                var arma = reader[0];
                var puntiDanno = Int32.Parse((string)reader[1]);
               


                ArmaEroe armaE = new ArmaEroe(arma.ToString(), (int)puntiDanno);

               
                armiEroi.Add(armaE);
            }
            connection.Close();
            return armiEroi;
        }
    }
}
