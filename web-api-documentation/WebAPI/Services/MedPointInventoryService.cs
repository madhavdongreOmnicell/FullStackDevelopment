using System.Reflection.PortableExecutable;
using Microsoft.Data.SqlClient;
using WebAPI.Models;
namespace WebAPI.Services
{
    public class MedPointInventoryService :IMedPointInventoryService
    {
        private readonly string connString;
        public MedPointInventoryService(IConfiguration configuration) { 
        
            connString = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentNullException("Connection string is null");
        }

        public List<MedCase> GetData()
        {
            var sql = "SELECT * FROM MedCase";
            var medCases = new List<MedCase>();
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            // Assuming the MedCaseKey is a string, MacAddress is an int, CaseType and Status are nullable strings
                            // Adjust the types as per your actual database schema
                            var medCase = new MedCase
                            {
                                MedCaseKey = reader.GetFieldValue<Guid>(reader.GetOrdinal("MedCaseKey")),
                                MacAddress = reader.GetFieldValue<int>(reader.GetOrdinal("MacAddress")),
                                CaseType = reader.IsDBNull(reader.GetOrdinal("CaseType")) ? null : reader.GetFieldValue<string>(reader.GetOrdinal("CaseType")),
                                Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? null : reader.GetFieldValue<string>(reader.GetOrdinal("Status")),
                            };
                            medCases.Add(medCase);
                        }
                    }
                }
            }
            return medCases;
        }

        public bool CreateMedCase(MedCase medCase)
        {
            var sql = @"INSERT INTO MedCase 
    (TenantId, MedCaseKey, MacAddress, CaseType, Status, LastOmni, PatientId, MedPointDockKey, LastChanged)
    VALUES 
    (@TenantId, @MedCaseKey, @MacAddress, @CaseType, @Status, @LastOmni, @PatientId, @MedPointDockKey, @LastChanged)";
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenantId", medCase.TenantId);
                    command.Parameters.AddWithValue("@MedCaseKey", medCase.MedCaseKey);
                    command.Parameters.AddWithValue("@MacAddress", medCase.MacAddress);
                    command.Parameters.AddWithValue("@CaseType", (object?)medCase.CaseType ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Status", (object?)medCase.Status ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastOmni", (object?)medCase.LastOmni ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PatientId", (object?)medCase.PatientId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MedPointDockKey", (object?)medCase.MedPointDockKey ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastChanged", medCase.LastChanged);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateMedCase(MedCase medCase)
        {
            var sql = @"UPDATE MedCase
                SET TenantId = @TenantId,
                    MacAddress = @MacAddress,
                    CaseType = @CaseType,
                    Status = @Status
                WHERE MedCaseKey = @MedCaseKey";
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenantId", medCase.TenantId);
                    command.Parameters.AddWithValue("@MedCaseKey", medCase.MedCaseKey);
                    command.Parameters.AddWithValue("@MacAddress", medCase.MacAddress);
                    command.Parameters.AddWithValue("@CaseType", (object?)medCase.CaseType ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Status", (object?)medCase.Status ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastOmni", (object?)medCase.LastOmni ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PatientId", (object?)medCase.PatientId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MedPointDockKey", (object?)medCase.MedPointDockKey ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastChanged", medCase.LastChanged);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteMedCase(Guid medCaseKey)
        {
            var sql = @"DELETE FROM MedCase WHERE MedCaseKey = @MedCaseKey";
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MedCaseKey", medCaseKey);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
