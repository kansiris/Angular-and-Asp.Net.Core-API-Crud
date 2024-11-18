using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer
{
    public class ContactDataAccessLayer 
    {
        ContactDbContext db = new ContactDbContext();

        public IEnumerable<TblContact> GetContacts()
        {
            try {
                return db.TblContact.ToList();
            }
            catch { throw; }

        }

        public int AddContacts(TblContact tblContact)
        {
            try
            {
                db.TblContact.Add(tblContact);
                db.SaveChanges();
                return 1;   
            }
            catch { throw; }

        }

        public int UpdateContacts(TblContact tblContact)
        {
            try
            {
                db.Entry(tblContact).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch { throw; }

        }

        public TblContact GetContactId(int id)
        {
            try
            {
                TblContact tblContact = db.TblContact.Find(id);
                return tblContact;
            }
            catch { throw; }


        }


        public int DeleteContacts(int id) {
            try
            {
                TblContact tblContact = db.TblContact.Find(id); 
                db.TblContact.Remove(tblContact);
                db.SaveChanges();
                return 1;
            }
            catch { throw; }

        }


    }
}
