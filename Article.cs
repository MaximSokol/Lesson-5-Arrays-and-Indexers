using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_
{
    class Article
    {
        public string Name { get; set; }
        public string Store { get; set; }
        public double Cost { get; set; }

        public Article(string name, string store, double cost)
        {
            this.Name = name;
            this.Store = store;
            this.Cost = cost;
        }
        //-----------------------------------------------------------

        public string Info()
        {
            return $"Name\t{Name}\n" +
                $"Store\t{Store}\n" +
                $"Cost\t{Cost}\n";
        }
        //-----------------------------------------------------------
    }
}
