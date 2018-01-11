/** 
 *Copyright(C) 201x by #John.W# 
 *All rights reserved. 
 *FileName:     Assets/Scripts/com.igeeknerd.al/BinarySearch.cs 
 *Author:       igeeknerd 
 *Version:      0.9 
 *UnityVersion：2017-1 
 *Date:         2017-12-29 01:49:30
 *Description:  A Simple Unity Muti-Game FrameWork  
 *History: 
*/
namespace com.igeeknerd.al.search
{
    using System;

    /// <summary>
    /// 线性搜索
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinearSearch<T> where T : IComparable
    {
        #region 未排序的线性搜索
        /// <summary>
        /// 未排序的线性搜索
        /// </summary>
        /// <param name="p_array">输入数组</param>
        /// <param name="p_value">查询数值</param>
        /// <returns></returns>
        public static int UnSortedLinearSearch(T[] p_array, T p_value)
        {
            T[] tmpArray = p_array;
            for (int i = 0; i < tmpArray.Length; i++)
            {
                if (p_value.Equals(tmpArray[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion

        #region 排序的线性搜索
        /// <summary>
        /// 升序排列的线性搜索
        /// </summary>
        /// <param name="p_array">输入数组</param>
        /// <param name="p_value">查询数值</param>
        /// <returns></returns>
        public static int SortedLinearSearch(T[] p_array, T p_value)
        {
            T[] tmpArray = p_array;
            for (int i = 0; i < tmpArray.Length; i++)
            {
                if (p_value.Equals(tmpArray[i]))
                {
                    return i;
                }
                //当数组内搜索的数值比自身数值大时，不可能出现需要结果，直接结束返回-2
                else if (p_value.CompareTo(p_array[i]) < 0)
                {
                    return -2;
                }
            }

            return -1;

        }

        #endregion
    }

}
