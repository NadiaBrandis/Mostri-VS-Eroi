using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MostriVSEroi.mokRepository
{
    public class MostriDbRepository
    {
        const string connectionString = @"Data Source= (localdb)\MSSQLLocalDB;" +
                                        "Initial Catalog = MostriVSEroi1;" + "integrated Security=true;";
        public static List<Mostro> GetMostri()
        {

            List<Mostro> mostri = new List<Mostro>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand
            {

                Connection = connection,

                CommandType = System.Data.CommandType.Text,

                CommandText = " select * from dbo.VistaMostriArmi"
            };





            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                var nome = reader[0];
                var categoria = reader[1];
                var arma = reader[2];
                int puntiDanno =(int)reader[4];
                
                var puntiVita = (int)reader["PuntiVita"];
                
                


                ArmaMostro armaM = new ArmaMostro(arma.ToString(), (int)puntiDanno);

                Mostro mostro = new Mostro((string)nome, (string)categoria, armaM,puntiVita);
                mostri.Add(mostro);
            }
            connection.Close();
            return mostri;

        }
    }
}
