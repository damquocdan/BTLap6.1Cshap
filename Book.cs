using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLap6._1Cshap
{
    public class Book
    {
        // khai báo trường
        public string Id;
        public string Title;
        public string Author;
        public string Publisher;
        public int Year;
        public double Price;
        // constructor
        public Book() { }
        public override string ToString()
        {
            return "Id:"+ Id+" Title:"+Title+ "Author:"+Author+ "Pulisher:"+Publisher+ "Year:"+ Year+ "Price:"+ Price;
        }
    }
}
