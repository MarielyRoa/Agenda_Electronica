using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE.Domain
{
    public interface IContactRepository
    {
        int Insert(Contact contact);
        bool Update(Contact contact);
        bool Delete(int id);

        Contact GetById(int id);
        List<Contact> GetAll();

        List<Contact> Search(int? id, string lastName);
    }
}
