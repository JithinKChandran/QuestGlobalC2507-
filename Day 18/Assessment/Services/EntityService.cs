using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public abstract class EntityService
    {
        protected string _connectionString;

        protected EntityService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract void Add();
        public abstract void Update();
        public abstract void Delete(int id);
        public abstract void GetAll();
    }
}
