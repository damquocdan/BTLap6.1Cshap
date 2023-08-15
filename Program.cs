using System.Collections.Generic;
using System.Diagnostics;

namespace BTLap6._1Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>() {
            new Book { Id = "s1", Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2004,
                Price = 1000 },
            new Book
            {
                Id = "s2",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2003,
                Price = 50000
            },
            new Book
            {
                Id = "s3",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2014,
                Price = 80000
            },
            new Book
            {
                Id = "s4",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2014,
                Price = 90000
            },
            new Book
            {
                Id = "s5",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2016,
                Price = 6000
            },
            new Book
            {
                Id = "s6",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2016,
                Price = 4000
            },
            new Book
            {
                Id = "s7",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2012,
                Price = 2000
            },
            new Book
            {
                Id = "s8",
                Title = "Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2013,
                Price = 9000
            },
            new Book
            {
                Id = "s9",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = " Simon and Schuster",
                Year = 2007,
                Price = 120000
            },
            new Book
            {
                Id = "s10",
                Title = "Đắc  Nhân Tâm",
                Author = "Dale Carnegie",
                Publisher = "Nhi Dong",
                Year = 2014,
                Price = 105000
            },
            };
            // in danh sách những quyển sách
            Console.WriteLine("danh sach cac quyen sach");
            foreach (var list in books)
            {
                Console.WriteLine(list);
            }
            // liet ke danh sách book theo gia
            var sortedBook = books.OrderBy(x => x.Price).ToList();
            Console.WriteLine("danh sach sách theo giá tăng dần");
            foreach (var item in sortedBook) {
                Console.WriteLine("ID:"+ item.Id+"title:"+ item.Title+"Author:"+ item.Author+
                    "Pulisher:"+ item.Publisher+ "year:"+ item.Year+ "Price:"+ item.Price);
            }
            Console.WriteLine("Nhap title can tim");
            string findTitle = Convert.ToString(Console.ReadLine());
            Book found = null;
            foreach (var book in books)
            {
                if (book.Title==findTitle)
                {
                    found = book;
                    break;

                }
            }
            if (found!=null)
            {
                Console.WriteLine("ID:" + found.Id + "title:" + found.Title + "Author:" + found.Author +
                    "Pulisher:" + found.Publisher + "year:" + found.Year + "Price:" + found.Price);
            }
            else
            {
                Console.WriteLine("Không tìm thấy giá trị");
            }
            




            Console.ReadLine();


        }
    }
}