namespace MVCCoreApp.Interfaces
{
    public interface IModelService
    {
        Task<T> Create<T>() where T : IBaseModel, new();
        Task Delete<T>(T model) where T : class, IBaseModel;
        Task<IEnumerable<T>> Index<T>() where T : class, IBaseModel;
        Task<T> Show<T>(int? id) where T : class, IBaseModel;
        Task Update<T>(T model) where T : class, IBaseModel;
        Task<T> Store<T>(T model) where T : class, IBaseModel;
        Task<T> Edit<T>(int? id) where T : class, IBaseModel;
    }
}
