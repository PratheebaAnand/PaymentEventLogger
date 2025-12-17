using Dapper;
using PaymentEventLogger.Core;
using System.Data;
using System.Data.SqlClient;

namespace PaymentEventLogger.SqlServer.Repositories
{
    public class SqlPaymentEventLogger : IPaymentEventLogger
        {
            private readonly string _connectionString;

            public SqlPaymentEventLogger(string connectionString)
            {
                _connectionString = connectionString;
            }

            public async Task LogAsync(PaymentEvent paymentEvent)
            {
                using (IDbConnection conn = new SqlConnection(_connectionString))
                {
                    const string sql = @"
                    INSERT INTO PaymentEvents 
                    (Id, Provider, EventType, Status, ReferenceId, Payload, ErrorMessage, CreatedAt) 
                    VALUES 
                    (@Id, @Provider, @EventType, @Status, @ReferenceId, @Payload, @ErrorMessage, @CreatedAt)";

                    // Insert the payment event into the database
                    await conn.ExecuteAsync(sql, paymentEvent);
                }
            }
        }
    }

