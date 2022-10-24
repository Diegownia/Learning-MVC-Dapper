using Dapper;
using Dapper.Contrib.Extensions;
using MVCCoreApp.Interfaces;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MVCCoreApp.Services
{
    public class ModelService : IModelService
    {
        private readonly IDbConnection _connection;

        public ModelService(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<T> Create<T>() where T : IBaseModel, new()
        {
            await Task.CompletedTask;

            return new T();
        }

        public async Task<IEnumerable<T>> Index<T>() where T : class, IBaseModel
        {
            IEnumerable<T> data = new List<T>();
            _connection.Open();

            try
            {
                //data = await _connection.QueryAsync<T>($"SELECT * FROM {typeof(T).Name};");
                data = await _connection.GetAllAsync<T>();
            }
            finally
            {
                _connection.Close();
            }

            return data;
        }

        public async Task<T> Show<T>(int id) where T : IBaseModel
        {
            T? model = default;
            _connection.Open();

            try
            {
                model = await _connection.QuerySingleOrDefaultAsync<T>(
                    $"SELECT * FROM {typeof(T).Name} WHERE {nameof(IBaseModel.Id)} = {id};");
            }
            finally
            {
                _connection.Close();
            }
            return model;
        }

        public async Task<T> Edit<T>(int id) where T : IBaseModel
        {
            return await Show<T>(id);
        }

        public async Task Update<T>(T model) where T : class, IBaseModel
        {
            await _connection.UpdateAsync(model);
        }
    }
}
