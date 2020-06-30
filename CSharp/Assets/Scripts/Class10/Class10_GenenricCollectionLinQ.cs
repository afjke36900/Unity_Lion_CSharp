using UnityEngine;

namespace Wei.Class10
{
    public class Class10_GenenricCollectionLinQ : MonoBehaviour
    {
        public CharacterFloat cF = new CharacterFloat(100.5f, 50.5f, 10.3f);   // 角色浮點數
        public CharacterInt cI = new CharacterInt(100, 50, 15);                // 角色整數   

        public Character<float> c1 = new Character<float>(99.9f, 99.9f, 9.9f);      // 使用泛型 : 給予浮點數
        public Character<int> c2 = new Character<int>(99, 99, 9);                   // 使用泛型 : 給予整數
        public Character<long> c3 = new Character<long>(10000, 10000, 5000);        // 使用泛型 : 給予整數
    }

    // 不使用泛型
    // 假設系統需要角色類別
    // 1. 浮點數欄位 - 血量、魔力、經驗值、攻擊力
    // 2. 整數欄位 - 血量、魔力、經驗值、攻擊力
    public class CharacterFloat
    {
        public float hp;
        public float mp;
        public float exp;
        public float atk;

        // 建構子 : 跟類別名稱相同並且無傳回的方法 - 在新增物件時執行
        public CharacterFloat(float h,float m,float a)
        {
            hp = h;mp = m;atk = a;
        }
    }    
    
    public class CharacterInt
    {
        // 多個游標 : Alt + Shift + >
        public int hp;
        public int mp;
        public int exp;
        public int atk;

        // 建構子 : 跟類別名稱相同並且無傳回的方法 - 在新增物件時執行
        public CharacterInt(int h, int m, int a)
        {
            hp = h; mp = m; atk = a;
        }
    }

    // 我想多一個長整數 long

    // 使用泛型 T 泛型
    public class Character<T>
    {
        public T hp;            // 欄未的類型為泛型
        public T mp;
        public T exp;
        public T atk;

        public Character(T h,T m,T a)
        {
            hp = h; mp = m; atk = a;
        }
    }
}

