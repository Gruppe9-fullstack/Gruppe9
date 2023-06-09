using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gruppe9.Models;
using Microsoft.EntityFrameworkCore;
using Gruppe9.Data;

namespace Gruppe9.Pages
{
    public partial class Bibliotek : ComponentBase
    {
        public List<Bok> Books { get; set; }
        public string[] input { get; set; } = new string[6];

        protected override async Task OnInitializedAsync()
        {
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

        public async Task Add(string[]input)
        {
            var newBook = new Bok();
            {

                newBook.ISBN = input[0];
                newBook.Tittel = input[1];
                newBook.Forfatter = input[2];
                newBook.Forlag = input[3];
                int utgitt = Int32.Parse(input[4]);
                newBook.UtgittÅr = utgitt;
                int antall = Int32.Parse(input[5]);
                newBook.AntallSider = antall;

            };

            using (var dbContext = new BokContext())
            {
                dbContext.Bok.Add(newBook);
                await dbContext.SaveChangesAsync();
            }

            RefreshPage();
        }

        private void RefreshPage()
        {
            NavigationManager.NavigateTo("/bibliotek", forceLoad: true);
        }

    }
}
