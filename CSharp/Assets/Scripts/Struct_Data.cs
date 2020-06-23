using UnityEngine;

[System.Serializable] // 序列化 : 讓類別顯示在屬性面板
public struct Struct_Data
{
    public string name;
    public int coin;
    public float hp;

    // 結構內不能有無參數的建構子
    /*
    public Struct_Data()
    {
        Debug.Log("空白的建構值～");
    }
    */

    /// <summary>
    /// 設定所有資料：名稱、金幣與血量
    /// </summary>
    /// <param name="n"></param>
    /// <param name="c"></param>
    /// <param name="h"></param>
    public Struct_Data(string n, int c, float h)
    {
        name = n;
        coin = c;
        hp = h;
    }
}
