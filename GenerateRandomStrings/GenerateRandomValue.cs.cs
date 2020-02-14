using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenerateRandomStrings
{
    class GenerateRandomValue
    {
        static readonly Random Random = new Random(~unchecked((int)DateTime.Now.Ticks));
        static readonly char[] NumberList = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static readonly char[] LowCharList = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static readonly char[] UpCharList = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static readonly char[] symbolList = { '`', '-', '=', '[', ']', '\\', ';', '\'', ',', '.', '/', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '{', '}', '|', ':', '"', '<', '>', '?' };

        #region 生成随机数字
        /// <summary>
        /// 生成随机数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumber(int Length)
        {
            return Create(Length, false, NumberList);
        }

        /// <summary>
        /// 生成随机数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumber(int Length, bool Sleep)
        {
            return Create(Length, Sleep, NumberList);
        }
        #endregion

        #region 生成随机小写字母
        /// <summary>
        /// 生成随机小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomLowerCaseLetters(int Length)
        {
            return Create(Length, false, LowCharList);
        }

        /// <summary>
        /// 生成随机小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, LowCharList);
        }
        #endregion

        #region 生成随机大写字母
        /// <summary>
        /// 生成随机大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomUpperCaseLetters(int Length)
        {
            return Create(Length, false, UpCharList);
        }

        /// <summary>
        /// 生成随机大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomUpperCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, UpCharList);
        }
        #endregion

        #region 生成随机大小写字母
        /// <summary>
        /// 生成随机大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomUppercaseAndLowerCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(LowCharList, UpCharList));
        }

        /// <summary>
        /// 生成随机大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomUppercaseAndLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(LowCharList, UpCharList));
        }
        #endregion

        #region 生成随机数字+小写字母
        /// <summary>
        /// 生成随机数字+小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumberAndLowerCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(NumberList, LowCharList));
        }

        /// <summary>
        /// 生成随机数字+小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumberAndLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(NumberList, LowCharList));
        }
        #endregion

        #region 生成随机数字+大写字母
        /// <summary>
        /// 生成随机数字+大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumberAndUpperCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(NumberList, UpCharList));
        }

        /// <summary>
        /// 生成随机数字+大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumberAndUpperCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(NumberList, UpCharList));
        }
        #endregion

        #region 生成随机数字+大小写字母
        /// <summary>
        /// 生成随机数字+大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumberAndUppercaseAndLowerCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(NumberList, LowCharList, UpCharList));
        }

        /// <summary>
        /// 生成随机数字+大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumberAndUppercaseAndLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(NumberList, LowCharList, UpCharList));
        }
        #endregion

        #region 生成随机符号
        /// <summary>
        /// 生成随机符号
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomSymbol(int Length)
        {
            return Create(Length, false, symbolList);
        }

        /// <summary>
        /// 生成随机符号
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomSymbol(int Length, bool Sleep)
        {
            return Create(Length, Sleep, symbolList);
        }
        #endregion




        #region 合并数组
        /// <summary>
        /// 合并两个数组
        /// </summary>
        /// <param name="List1">数组1</param>
        /// <param name="List2">数组2</param>
        /// <returns>合并后的数组</returns>
        private static char[] MergeArray(char[] List1, char[] List2)
        {
            char[] Merge = null;
            List<char> list = new List<char>();
            list.AddRange(List1);
            list.AddRange(List2);
            Merge = list.ToArray();
            return Merge;
        }

        /// <summary>
        /// 合并三个数组
        /// </summary>
        /// <param name="List1">数组1</param>
        /// <param name="List2">数组2</param>
        /// <returns>合并后的数组</returns>
        private static char[] MergeArray(char[] List1, char[] List2, char[] List3)
        {
            char[] Merge = null;
            List<char> list = new List<char>();
            list.AddRange(List1);
            list.AddRange(List2);
            list.AddRange(List3);
            Merge = list.ToArray();
            return Merge;
        }

        /// <summary>
        /// 合并五个数组
        /// </summary>
        /// <param name="List1">数组1</param>
        /// <param name="List2">数组2</param>
        /// <returns>合并后的数组</returns>
        private static char[] MergeArray(char[] List1, char[] List2, char[] List3, char[] List4, char[] List5)
        {
            char[] Merge = null;
            List<char> list = new List<char>();
            list.AddRange(List1);
            list.AddRange(List2);
            list.AddRange(List3);
            list.AddRange(List4);
            list.AddRange(List5);
            Merge = list.ToArray();
            return Merge;
        }
        #endregion

        #region 生成随机值
        /// <summary>
        /// 生成随机值
        /// </summary>
        /// <returns>随机值</returns>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        /// <param name="List">字典</param>
        private static string Create(int Length, bool Sleep, char[] List)
        {
            if (Sleep) Thread.Sleep(3);
            char[] Pattern = List;
            string result = string.Empty;
            int n = Pattern.Length;

            for (int i = 0; i < Length; i++)
            {
                int rnd = Random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;
        }
        #endregion
    }
}