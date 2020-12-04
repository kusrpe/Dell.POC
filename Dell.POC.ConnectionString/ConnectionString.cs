using System;

namespace Dell.POC.ConfigurationSettings
{
    public static class ConnectionString
    {
        /// <summary>
        /// Gets the database connection string.
        /// </summary>
        /// <value>
        /// The database connection string.
        /// </value>
        public static string DBConnectionString { get; private set; }

        /// <summary>
        /// To set the connection string's.
        /// </summary>
        /// <param name="dbConnectionString">database connection string.</param>
        public static void ConfigureServices(string dbConnectionString)
        {
            DBConnectionString = dbConnectionString;
        }
    }
}
