using EFCore07.Data;
using EFCore07.Entities;
using Microsoft.VisualBasic;

namespace EFCore07
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            using(var context =new AppDbContext()) { 
            
                //Database will be Created if it does not exist 
                await context.Database.EnsureCreatedAsync();

                await Task.Delay(30000);

                //Database will be deleted if it does exist
                await context.Database.EnsureDeletedAsync();

            }
            Console.ReadKey();
        }
    }
}
