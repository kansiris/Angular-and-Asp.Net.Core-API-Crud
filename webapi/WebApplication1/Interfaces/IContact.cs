using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IContact
    {
        IEnumerable<TblContact> GetContacts();
        int AddContacts(TblContact contact);
        int UpdateContacts(TblContact contact);
        int DeleteContacts(int id);
        TblContact GetContactId(int id);

    }
}
