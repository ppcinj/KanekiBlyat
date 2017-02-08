﻿using System;
using System.Collections.Generic;
using NHibernate;
using TestEmployee.Database.Map;

namespace TestEmployee.Database.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ISession _session;

        public EmployeeRepository()
        {
            _session = NHConfig.Session;
        }

        public IList<EmployeeBE> GetAllEmployees()
        {
            return _session.QueryOver<EmployeeBE>().List();
        }

        public EmployeeBE GetEmployeeById(Guid id)
        {
            return _session.Get<EmployeeBE>(id);
        }

        public void Remove(EmployeeBE e)
        {
            _session.Delete(e);
        }

        public void SaveOrUpdate(EmployeeBE e)
        {
            _session.SaveOrUpdate(e);
            _session.Flush();
        }
    }
}