using System;
using System.Collections.Generic;
using NHibernate;
using TestEmployee.Database.Map;

namespace TestEmployee.Database.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IList<EmployeeBE> _cachedList;
        private bool _isDirty = true;
        private readonly ISession _session;

        public EmployeeRepository(ISession session)
        {
            _session = session;
            _cachedList = new List<EmployeeBE>();
        }

        public IList<EmployeeBE> GetAllEmployees()
        {
            if (_isDirty)
            {
                _cachedList = _session.QueryOver<EmployeeBE>().List();
                _isDirty = false;
            }
            return _cachedList;
        }

        public EmployeeBE GetEmployeeById(Guid id)
        {
            return _session.Get<EmployeeBE>(id);
        }

        public void Remove(EmployeeBE e)
        {
            _session.Delete(e);
            _isDirty = true;
            _session.Flush();
        }

        public void SaveOrUpdate(EmployeeBE e)
        {
            _session.SaveOrUpdate(e);
            _isDirty = true;
            _session.Flush();
        }
    }
}
