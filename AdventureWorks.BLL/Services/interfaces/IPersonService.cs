using AdventureWorks.BLL.DTOs;
using System.Linq;

namespace AdventureWorks.BLL.Services.interfaces
{
    public interface IPersonService
    {
        PersonDTO GetByID(int id);
        IQueryable<PersonDTO> GetAll();

    }
}
