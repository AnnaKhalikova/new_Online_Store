using System.Collections.Generic;

namespace New_Online_Store.Interface
{
    public interface IRepository<Tentity>
    {
        public List<Tentity> GetAllItems();
        Tentity GetItemById(int id);
    }
}
