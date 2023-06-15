using gestion_medical.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class DatabaseConnectionTester
{
    private readonly IConfiguration _configuration;

    public DatabaseConnectionTester(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public bool TestConnection()
    {
        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        using (var dbContext = new AppDbContext(optionsBuilder.Options))
        {
            try
            {
                dbContext.Database.OpenConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Échec de la connexion à la base de données : " + ex.Message);
                return false;
            }
            finally
            {
                dbContext.Database.CloseConnection();
            }
        }
    }

}
