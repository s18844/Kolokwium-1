using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.DTOs.Requests;
using Kolokwium.DTOs.Responses;
using Kolokwium.Models;

namespace Kolokwium.Services
{
    public class SqlServerStudentDbService : IStudentDbService
    {

        private const string StringConstruct = "Data Source=db-mssql;Initial Catalog=s18844;Integrated Security=True";

        public EnrollZadanie2Response EnrollZad1(int request)
        {

            EnrollZadanie2Response respond = null;
            int IdPrescription = 0;
            DateTime Date = DateTime.Today;
            DateTime DueDate = DateTime.Today;
            int IdPatient = 0;
            int IdDoctor = 0;

            using (var con = new SqlConnection(StringConstruct))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                con.Open();

                try
                {
                    //1. Czy recepta istnieja? Jak tak to pobranie danych
                    com.CommandText = "SELECT IdPrescription FROM Prescription where IdPrescription=@name";
                    com.Parameters.AddWithValue("name", request);
        
                    var dr = com.ExecuteReader();
                    if (!dr.Read())
                    {
                        return respond;
                    }
                    IdPrescription = (int)dr["IdPrescription"];
                   Date = (DateTime)dr["Date"]; 
                    DueDate = (DateTime)dr["DueDate"];
                    IdPatient = (int)dr["IdPatient"];
                    IdDoctor = (int)dr["IdDoctor"];

                    dr.Close();

                    


                }
                catch (SqlException exc)
                {
                    return respond;
                }
            }

            respond = new EnrollZadanie2Response();
            
            respond.IdPrescription = IdPrescription;
            respond.Date = Date;
            respond.DueDate = DueDate;
            respond.IdPatient = IdPatient;
            respond.IdDoctor = 1;
            return respond;
        }

     

      
    }
}
