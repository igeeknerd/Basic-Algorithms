/** 
 *Copyright(C) 201x by #John.W# 
 *All rights reserved. 
 *FileName:     Assets/Scripts/com.igeeknerd.al/EvenOddSearch.cs 
 *Author:       igeeknerd 
 *Version:      0.9 
 *UnityVersion：2017-1 
 *Date:         2018-01-11 22:54:36
 *Description:  A Simple Unity Muti-Game FrameWork  
 *History: 
*/  

namespace com.igeeknerd.al.search
{
    using System;
    /// <summary>
    /// 一个数组中奇数和偶数置换
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EvenOddSearch<T> where T : IComparable
    {
        #region 置换两个数
        public static void swap(int[] p_array, int p_start, int p_end)
        {
            int temp = p_array[p_start];
            p_array[p_start] = p_array[p_end];
            p_array[p_end] = temp;

        }
        #endregion

        #region 置换一个数组中的奇数和偶数
        public static int[] SeparateEvenAndOdd(int[] p_array)
        {
            int start = 0;
            int end = p_array.Length - 1;
            //偶数
            while (end > start)
            {
                if (p_array[start] % 2 == 0)
                {
                    start++;
                }
                else if (p_array[end] % 2 != 0)
                {
                    end--;
                }
                else
                {
                    swap(p_array, start, end);
                }
            }
            return p_array;
        }

        #endregion

    }

}
