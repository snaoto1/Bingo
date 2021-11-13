using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class bingoCard
    {
        public int[,] BINGOCard()
        {
            Random Random = new Random();
            int[] RandomNumber = new int[5];
            int[,] Bcard = new int[5, 5];
            var list = new List<int>();

            //1から15の重複のない数字を代入
            for(int i=0; i < 5; i++)
            {
                RandomNumber[i] = Random.Next(1, 15);
                if (!list.Contains(RandomNumber[i]))
                {
                    list.Add(RandomNumber[i]);
                    //ビンゴカードに数字を格納
                    Bcard[i,0]=RandomNumber[i];
                }
                else
                {
                    i--;
                }
            }
            //16から30の重複のない数字を代入
            for (int i = 0; i < 5; i++)
            {
                RandomNumber[i] = Random.Next(16, 30);
                if (!list.Contains(RandomNumber[i]))
                {
                    list.Add(RandomNumber[i]);
                    //ビンゴカードに数字を格納
                    Bcard[i, 1] = RandomNumber[i];
                }
                else
                {
                    i--;
                }
            }
            //31から45の重複のない数字を代入
            for (int i = 0; i < 5; i++)
            {
                RandomNumber[i] = Random.Next(31, 45);
                if (!list.Contains(RandomNumber[i]))
                {
                    list.Add(RandomNumber[i]);
                    //ビンゴカードに数字を格納
                    Bcard[i, 2] = RandomNumber[i];
                }
                else
                {
                    i--;
                }
            }
            //46から60の重複のない数字を代入
            for (int i = 0; i < 5; i++)
            {
                RandomNumber[i] = Random.Next(46, 60);
                if (!list.Contains(RandomNumber[i]))
                {
                    list.Add(RandomNumber[i]);
                    //ビンゴカードに数字を格納
                    Bcard[i, 3] = RandomNumber[i];
                }
                else
                {
                    i--;
                }
            }
            //61から75の重複のない数字を代入
            for (int i = 0; i < 5; i++)
            {
                RandomNumber[i] = Random.Next(61, 75);
                if (!list.Contains(RandomNumber[i]))
                {
                    list.Add(RandomNumber[i]);
                    //ビンゴカードに数字を格納
                    Bcard[i, 4] = RandomNumber[i];
                }
                else
                {
                    i--;
                }
            }
            return Bcard;
        }
    }
}