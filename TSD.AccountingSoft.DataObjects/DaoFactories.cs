
namespace TSD.AccountingSoft.DataAccess
{
    /// <summary>
    ///  class DaoFactories
    /// </summary>
    public class DaoFactories
    {
        /// <summary>
        /// Gets the factory.
        /// </summary>
        /// <param name="dataProvider">The data provider.</param>
        /// <returns></returns>
        public static IDaoFactory GetFactory(string dataProvider)
        {
            switch (dataProvider)
            {
                case "ADO.NET.SqlServer": return new SqlServer.SqlServerDaoFactory();
                default: return new SqlServer.SqlServerDaoFactory();
            }
        }
    }
}