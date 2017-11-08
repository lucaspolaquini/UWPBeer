using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UWP.Beer.Abstracts;
using UWP.Beer.Interfaces;

namespace UWP.Beer.Repositories.Base
{
    public abstract class Repository<T> : NotifyableClass, IRepository<T> where T : class
    {
        private ObservableCollection<T> _items = new ObservableCollection<T>();
        public ObservableCollection<T> Items
        {
            protected set { Set(ref _items, value); }
            get { return _items; }
        }

        public abstract Task LoadAll();
        public abstract Task Create(T entity);
        public abstract Task Update(T entity);
        public abstract Task Delete(T entity);
    }
}
