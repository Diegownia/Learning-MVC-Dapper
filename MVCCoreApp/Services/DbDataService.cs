using MVCCoreApp.Interfaces;
using MVCCoreApp.Models;
using System.Data;

namespace MVCCoreApp.Services
{
    public class DbDataService
    {
        private readonly IModelService _modelService;

        public DbDataService(IModelService modelService)
        {
            _modelService = modelService;
        }

        public T Create<T>() where T : BaseModel, new()
        {
            return new T();
        }

        public int Store<T>(T model) where T : BaseModel
        {
            int id = 0;
            var sql = $"SELECT ID FROM {typeof(T).Name}s ORDER BY ID DESC LIMIT 1";
            //TODO Store method?
        }
    }
}
