using VacationDestinationManager.Domain;

namespace VacationDestinationManager.ServiceLayer
{
    internal static class ServiceUtility
    {
        /// <summary> Searches for the first free id, given a service of entities with int keys. </summary>
        public static int GetFreeId<TEntity>(this EntityService<TEntity, int> service) where TEntity : IEntity<int>
        {
            int id = 1;
            while (service.FindByKey(id) is not null)
                id++;
            return id;
        }
    }
}
