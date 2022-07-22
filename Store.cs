
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_
{
    class Store
    {
        Article[] arr;
        //---------------

        public Store(int size)
        {
            arr = new Article[Math.Abs(size)];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index].Info();
                return "Index Out Of Range Exception!";
            }
        }

        public void AddArticle(Article article, int index)
        {
            if (index >= 0 && index < arr.Length)
                arr[index] = article;
            else
            {
                Console.WriteLine("Index Out Of Range Exception!");
            }
        }

        public string this[string index]
        {
            get
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Name == index)
                        return arr[i].Info();
                }
                return $"The product is absent!\t{index}";
            }
        }

        public void Show()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].Info()}");
            }
        }

        public void Sort()
        {
            for(int i = 0; i < arr.Length -1; i++)
            {
                for(int g = 0; g < arr.Length -1; g++)
                {
                    if(arr[i].Cost <= arr[g].Cost)
                    {
                        Article art = arr[i];
                        arr[i] = arr[g];
                        arr[g] = art;
                    }
                }
            }
        }
    }
}
