namespace PizzaStoreDallLibrary
{
    public interface IRepository<K, T>  ///(data type and class name)
    {
        List<T> GetAll();
        T GetById(K key);
        T Add(T item);
        T Update(T item);
        T Delete(K key);

    }

}
