using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheOnlineBookStore.Data.Base;
using TheOnlineBookStore.Models;

namespace TheOnlineBookStore.Data.Services
{
    public interface IBooksService : IEntityBaseRepository<Book>
    {
        Task<Book> GetBookByIdAsync(int id);
        Task<NewBookDropdownsVM> GetNewBookDropdownsValues();
        Task AddNewBookAsync(NewBookVM data);
        Task UpdateBookAsync(NewBookVM data);
        Task GeBookByIdAsync(int id);
    }
}
