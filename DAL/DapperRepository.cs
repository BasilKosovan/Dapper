using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Model;

namespace DAL {
	public class DapperRepository : IRepository {
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		public Entity GetEntity(int id) {
			Entity result = null;

			using (IDbConnection db = new SqlConnection(connectionString)) {
				result = db.Query<Entity>("SELECT top 1 * FROM dbo.Entity").Single();
			}
			return result;
		}
	}
}
