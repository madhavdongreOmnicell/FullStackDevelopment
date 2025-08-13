using Dapper;
using Microsoft.Data.SqlClient;
using Omnicell.CommonInfrastructure.DataAccess;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class MedPointInventoryServiceUsingDapper : IMedPointInventoryService
    {
        private readonly string connString;
        public MedPointInventoryServiceUsingDapper(IConfiguration configuration)
        {

            connString = configuration.GetConnectionString("DefaultConnection")?? throw new ArgumentNullException("Connection string is null");
        }
        public bool CreateMedCase(MedCase medCase)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMedCase(Guid medCaseKey)
        {
            throw new NotImplementedException();
        }

        public List<MedCase> GetData()
        {
            List<MedCase> medCases = new List<MedCase>();
            using (var connection = new SqlConnection(connString))
            {
                medCases = connection.Query<MedCase>("SELECT * FROM MedCase", commandType: System.Data.CommandType.Text).ToList();
            }
            return medCases.ToList();
        }

        public bool UpdateMedCase(MedCase medCase)
        {
            throw new NotImplementedException();
        }
    }
}
