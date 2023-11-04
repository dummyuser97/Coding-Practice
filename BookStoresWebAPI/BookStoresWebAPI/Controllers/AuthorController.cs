using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        public IEnumerable<Author> Get()
        {
            using (var context = new BookStoresDbContext()) {
                //get all authors
                //return context.Authors.ToList();

                // get author by Id
                //return context.Authors.Where(auth => auth.AuthorId == 1).ToList();

                //add author 

                //Author author = new Author();
                //author.FirstName = "Satish";
                //author.LastName = "Matsagar";

                //context.Authors.Add(author);
                //context.SaveChanges();

                //update 
                //Author author = context.Authors.Where(auth => auth.FirstName == "Satish").FirstOrDefault();
                //author.Phone = "7777 7777 77";

                //delte
                Author author = context.Authors.Where(auth => auth.FirstName == "Satish").FirstOrDefault();
                context.Authors.Remove(author);

                context.SaveChanges();

                return context.Authors.Where(auth => auth.FirstName =="Satish").ToList();

            }

           
        }
    }
}