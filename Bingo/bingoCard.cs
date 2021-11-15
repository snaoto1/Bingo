using System;
using System.Collections.Generic;

namespace Bingo
{
    internal class bingoCard
    {
        public int[,] BINGOCard()
        {
            Random Random = new Random();
            int[] RandomNumber = new int[15];
            int[,] Bcard = new int[5, 5];
            var list = new List<int>();

            //Bcardに数字を入れるループ
            for(int i=0; i < 5; i++)
            {
                //指定された範囲の数字を順番にRandomNumber[]に格納
                for (int c = 0; c < 15; c++)
                {
                    RandomNumber[c] = i * 15 + c+1;
                }
                //RandomNumber配列の中身をシャッフル
                for(int c = 0; c < 15; c++)
                {
                    int j = Random.Next(0, 14);
                    int tmp = RandomNumber[c];
                    RandomNumber[c] = RandomNumber[j];
                    RandomNumber[j] = tmp;
                }
                //Bcardに格納
                for (int n = 0; n < 5; n++)
                {
                    Bcard[n, i] = RandomNumber[n];
                }
                
            }

            return Bcard;
        }
    }
}