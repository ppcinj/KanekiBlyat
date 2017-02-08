using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace TestEmployee.Database
{
    public static class NHConfig
    {
        private static ISession _session;

        public static ISession Session
        {
            get
            {
                if (_session == null)
                {
                    ConfigureSession();
                }
                return _session;
            }
        }

        private static void ConfigureSession()
        {
            var connString = "Server=home.salivonserver.com,5000;Database=TestDB;User Id=external;Password = qwerty123;";
            var sessionFactory =
                Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connString).ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Employee>())
                    .BuildSessionFactory();

            _session = sessionFactory.OpenSession();
        }
    }
}
