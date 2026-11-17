using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace JatekProjekt
{

    public class AdatbazisKezelo
    {
        private readonly string connectionString;


        public AdatbazisKezelo()
        {

            this.connectionString = "server=localhost;database=jatekDb;user=root;password='";
            // Irjuk meg a connectionstringet a megfelelő adatbázisra hivatkozva
        }

   
        /// Beolvassa az összes karaktert az adatbázisból egy List<Karakter>-be.
        public List<Karakter>Feltolt(){
            List<Karakter> karakterek = new List<Karakter>();


            try{

				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();
					Console.WriteLine("Adatbázis kapcsolat megtörtént");
					string query = "SELECT * FROM karakterek";
					MySqlCommand command = new MySqlCommand(query, connection);
					MySqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						Karakter karakter = new Karakter
						{
							Nev = reader["nev"].ToString(),
							Szint = Convert.ToInt32(reader["eletpontok"]),
							Arany = Convert.ToInt32(reader["tamadoero"]),
							Osztaly = reader["osztaly"].ToString(),
							Szerver = reader["szerver"].ToString(),
						};
						karakterek.Add(karakter);
					}
				}


			}
			catch (Exception ex)
			{
				Console.WriteLine("Hiba az adatbázis lekérdezés során: " + ex.Message);

				return karakterek;
        }
       
        public List<Karakter> AdatokBetoltese()
        {
            var karakterek = new List<Karakter>();
            Dictionary<int, Kar>

			return karakterek;
        }
    }
}
