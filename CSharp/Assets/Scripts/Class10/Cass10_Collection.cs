using UnityEngine;
using System.Collections;               // ArrayList
using System.Collections.Generic;       // List          -泛型

namespace Wei.Class10
{
    public class Cass10_Collection : MonoBehaviour
    {
        // 陣列 : 一旦固定長度就不能改變
        public int[] scores = { 100, 90, 80, 70, 60 };

        // 集合 : 彈性
        // 清單
        public List<float> hp = new List<float> { 99.9f, 88.8f, 77.7f };

        public List<float> hpResult = new List<float>();

        public ArrayList numbers = new ArrayList();

        // 排序
        public List<int> count = new List<int> { 9, 100, 15, 77, 30, 999, 123 };

        private void Start()
        {
            // 1. 集合可以改變長度
            hp.Add(66.6f);              // 清單.增加(T)
            hp.Remove(88.8f);              // 清單.刪除(T)

            print("是否包含 66.6 : " + hp.Contains(66.6f));     // 是否包含(T)

            hpResult = hp.FindAll((x) => x >= 70f);              // 搜尋所有(大於等於 70 )資料

            // ArrayList 與 List 差異
            // ArrayList 為 object 型別 : 可存放所有類型
            // List 為泛型 : 一旦指定類型就只能存放一種類型 List<int> - int
            // ArrayList 不會顯示在屬性面板
            numbers.Add(100);
            numbers.Add(77.7f);
            numbers.Add("123");
            numbers.Add(true);

            count.Sort();           // 由小到大
            count.Reverse();           // 反轉
        }
    }
}
