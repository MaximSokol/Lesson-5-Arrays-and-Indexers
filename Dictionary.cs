using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] ru = new string[5];
        private string[] ua = new string[5];

        public Dictionary()
        {
            key[0] = "a can"; ru[0] = "банка"; ua[0] = "бляшанка";
            key[1] = "fly"; ru[1] = "летать"; ua[1] = "літати";
            key[2] = "perhaps"; ru[2] = "возможно"; ua[2] = "можливо";
            key[3] = "maybe"; ru[3] = "может быть"; ua[3] = "може бути";
            key[4] = "nice"; ru[4] = "приятно"; ua[4] = "приємно";
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= key.Length)
                {
                    return key[index] + " - " + ru[index] + " - " + ua[index];
                }
                return "This translate is absent!";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return ($"{key[i]}\t + \t{ru[i]}\t + \t{ua[i]}");
                    if (ru[i] == index)
                        return ($"{ru[i]}\t + \t{key[i]}\t + \t{ua[i]}");
                    if (ua[i] == index)
                        return ($"{ua[i]}\t + \t{key[i]}\t + \t{ru[i]}");
                }
                return "This word is absent!";
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
