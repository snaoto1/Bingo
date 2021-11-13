using System;

namespace Bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ビンゴカードクラスをCard・ビンゴボールクラスをBall
            bingoCard Card = new bingoCard();
            bingoBall Ball = new bingoBall();
            int[,] bingoCard = Card.BINGOCard();
            int[] bingoBall = Ball.BingoBall();
            //ビンゴカード穴空き判定
            int[,] bingoCardFlag = new int[5, 5];
            //リーチ　ビンゴ判定
            int reach = 0;
            int bingo = 0;
            int FlagX = 0;
            int FlagY = 0;
            int FlagNaname1 = 0;
            int FlagNaname2 = 0;
            //ビンゴカード出力
            int ballCount = 1;
            for (int i = 0; i < bingoBall.Length; i++)
            {
                Console.Out.WriteLine("ball[" + ballCount + "]:" + bingoBall[i]);
                ballCount++;
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        //ﾋﾞﾝｺﾞﾎﾞｰﾙの数字がビンゴカードと一致していた場合、一致する場所のFlagを1にする
                        if (bingoBall[i] == bingoCard[x, y])
                        {
                            bingoCardFlag[x, y] = 1;
                        }
                        //Flagが1かつ、FREEの位置でないことを確認し、()有り数字を出力
                        if (bingoCardFlag[x, y] == 1 && bingoCard[x, y] != bingoCard[2, 2])
                        {
                            Console.Out.Write("(" + bingoCard[x, y].ToString("00") + ")");
                        }
                        //Flagが0で、FREEの位置でないことを確認し、()無しの数字を出力
                        else if (bingoCard[x, y] != bingoCard[2, 2])
                        {
                            Console.Out.Write(" " + bingoCard[x, y].ToString("00") + " ");
                        }
                        //FREEの位置にFREEの文字を出力
                        if (bingoCard[x, y] == bingoCard[2, 1])
                        {
                            Console.Out.Write("FREE");
                        }
                    }
                    Console.Out.WriteLine();
                }
                //リーチビンゴチェック 
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        //横軸
                        if (bingoCardFlag[y, x] == 1)
                        {
                            FlagX++;
                            if (FlagX == 4)
                            {
                                reach++;
                            }
                            else if (FlagX == 5)
                            {
                                bingo++;
                            }
                        }
                        //縦軸
                        if (bingoCardFlag[x, y] == 1)
                        {
                            FlagY++;
                            if (FlagY == 4)
                            {
                                reach++;
                            }
                            else if (FlagY == 5)
                            {
                                bingo++;
                            }
                        }
                    }
                    //左上から右下の斜め
                    if (bingoCardFlag[y, y] == 1)
                    {
                        FlagNaname1++;
                        if (FlagNaname1 == 4)
                        {
                            reach++;
                        }
                        else if (FlagNaname1 == 5)
                        {
                            bingo++;
                        }
                    }
                    //右上から左下の斜め
                    if (bingoCardFlag[y, 4 - y] == 1)
                    {
                        FlagNaname2++;
                        if (FlagNaname2 == 4)
                        {
                            reach++;
                        }
                        else if (FlagNaname2 == 5)
                        {
                            bingo++;
                        }
                    }
                    //横軸と縦軸のフラグ数を0
                    FlagX = 0;
                    FlagY = 0;

                }
                //斜めのﾌﾗｸﾞ数を0
                FlagNaname1 = 0;
                FlagNaname2 = 0;
                //リーチとビンゴの数を画面に表示
                reach = reach - bingo;
                Console.Out.WriteLine("");
                Console.Out.WriteLine("REACH: " + reach);
                Console.Out.WriteLine("BINGO: " + bingo);
                reach = 0;
                bingo = 0;
                Console.Out.WriteLine("--------------------");

            }
        }
    }
}