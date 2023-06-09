namespace VacationDestinationManager.Domain
{
    internal interface IEntity<TKey> where TKey : notnull
    {
        public TKey GetKey();
    }
}
