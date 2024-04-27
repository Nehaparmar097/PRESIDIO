namespace ShoppingDALLibrary
{
    public abstract class AbstractRepository<K, T> : IRepository<K, T>
    {
        protected IList<T> items = new List<T>();
        public Task<T> Add(T item)
        {
            items.Add(item);
            return Task.FromResult(item);
        }
        public async Task<ICollection<T>> GetAll()
        {  
            return items.ToList();
        }

        public abstract  Task<T> Delete(K key);



        public abstract   Task<T> GetByKey(K key);
        

      
        public abstract  Task<T> Update(T item);

       
    }
}
