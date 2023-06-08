using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gruppe9.Models;
using Microsoft.EntityFrameworkCore;

namespace Gruppe9.Pages
{
    public partial class Bibliotek : ComponentBase
    {
        public List<Bok> Books { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // Retrieve the list of books from the database
            Books = await FetchAllBooks();
        }

        private async Task<List<Bok>> FetchAllBooks()
        {
            List<Bok> books;

            using (var context = new BokContext())
            {
                books = await context.Bok.ToListAsync();
            }

            return books;
        }

        private List<Bok> ShowAllBooks()
        {
            return Books;
        }
    }
}
