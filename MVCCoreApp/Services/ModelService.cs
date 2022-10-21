using MVCCoreApp.Interfaces;
using System.Data;

namespace MVCCoreApp.Services
{
    public class ModelService : IModelService
    {
        private readonly IDbConnection _connection;

        public ModelService(IDbConnection connection)
        {
            _connection = connection;
        }
    }
}
