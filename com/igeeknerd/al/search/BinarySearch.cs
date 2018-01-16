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
    /// 二分搜
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearch<T> where T : IComparable
    {
        #region 普通二分查找
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="p_array"></param>
        /// <param name="p_value"></param>
        /// <returns></returns>
        public static int NormalSearch(T[] p_array, T p_value)
        {
            T[] tmpArray = p_array;
            int low = 0;
            int high = p_array.Length - 1;
            int mid = (high - low) / 2;

            int counter = 0;
            while (high >= low)
            {
                counter++;
                if (counter > 20) return -100;
                //如果查找结果在前半段mid = (high - low) / 2;没有问题，但是如果在后半段这样算数值index会算到前半部分找不到答案，所以需要加上前半部分的数值。
                mid = low + (high - low) / 2;
                //查询的数值比中间的大，取后半段
                if (p_value.CompareTo(tmpArray[mid]) > 0)
                {
                    low = mid + 1;
                    //Debug.Log("没有找到了 " + mid + "下一次寻找后半段的是low " + low + "high " + high);
                }
                //查询的比中间的小，在前半段
                else if (p_value.CompareTo(tmpArray[mid]) < 0)
                {
                    high = mid - 1;
                    //Debug.Log("没有找到了 " + mid + "下一次寻找前半段的是low " + low + "high " + high);
                }
                else if (p_value.Equals(tmpArray[mid]))
                {
                    //Debug.Log("找到了hight " + high);
                    return mid;
                }
            }
            return -1;
        }
        #endregion
        #region
        /// <summary>
        /// 递归二分搜索
        /// </summary>
        /// <param name="p_array"></param>
        /// <param name="p_low"></param>
        /// <param name="p_high"></param>
        /// <param name="p_value"></param>
        /// <returns></returns>
        public static int RecursiveSearch(T[] p_array, int p_low, int p_high, T p_value)
        {
            if (p_high < p_low)
            {
                //Debug.Log("没有找到结果");
                return -1;
            }
            int mid = p_low + (p_high - p_low) / 2;

            //查询数值在后半部
            if (p_value.CompareTo(p_array[mid]) > 0)
            {
                p_low = p_low + 1;
                return RecursiveSearch(p_array, p_low, p_high, p_value);
            }
            //查询数值在前半部
            else if (p_value.CompareTo(p_array[mid]) < 0)
            {
                p_high = p_high - 1;
                return RecursiveSearch(p_array, p_low, p_high, p_value);
            }
            else//(p_value.Equals(p_array[mid]))
            {
                return mid;
            }
        }
        #endregion
    }
}
