using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class bingoBall
    {
        public int[] BingoBall()
        {
            Random Random = new Random();
            int[] Ball = new int[75];

            //ビンゴボールに数字代入
            int[] bingoBall = new int[75];
            for (int i = 0; i < bingoBall.Length; i++)
            {
                bingoBall[i] = i + 1;
            }
            //フィッシャーイェーツのシャッフルアルゴリズム
            //①iに配列の長さ-1を入力し、ループスタート
            for (int i = bingoBall.Length - 1; i > 0; i--)
            {
                //②変数jに最大値がi+1のランダムな数字を代入
                int j = Random.Next(i + 1);

                //③tmpにbingoBall[i]を代入
                int tmp = bingoBall[i];

                //④bingoBall[i]にbingoBall[j](1から75のﾗﾝﾀﾞﾑな数字)を代入
                bingoBall[i] = bingoBall[j];

                //⑥bingoBall[j]に重複させないために④でtmpに保存した
                //  ③までbingoBall[i]に入っていた値を代入
                bingoBall[j] = tmp;
            }
            return bingoBall;
        }
    }
}
