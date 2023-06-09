using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public void OnGet(
            int skip = 0,
            int take = 25)
        {
            var temp = new List<Category>();
             //Task.Delay(5000);
            for (int i = 0; i <= 1787; i++)
            {
                temp.Add(
                    new Category(i,
                    $"Categoria {i}",
                    i * 18.95M));
            }

            //Skip não pule registros
            //Take pegue 25 registros
            //Tolist() converta para lista

            Categories = temp 
                .Skip(skip)
                .Take(take)
                .ToList();
        }
    }

 
}

public record Category(
    int Id,
    string Title,
    decimal Price);
