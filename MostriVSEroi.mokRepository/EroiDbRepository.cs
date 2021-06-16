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
                
               

                ArmaEroe armaE = new ArmaEroe(arma.ToString(),(int)puntiDanno);

                Eroe eroe = new Eroe((int)idEroe,(string)nome, (string)categoria, armaE);
                eroi.Add(eroe);
            }
            connection.Close();
            return eroi;
            
        }
    }
}
