using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class5_IfSwitchLoop : MonoBehaviour
{
    [Header("是否要開門")]
    public bool openDoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量")]
    public int hp = 100;
    [Header("道具")]
    public string prop = "紅水";

    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    public string test;

    private void Start()
    {
        // if 判斷式
        // if (布林值) { 布林值 = true 時執行 }
        if (true)
        {
            print("HI，我是if判斷式");
        }
    }

    // 更新事件 : 一秒執行約 60 次 (60FPS)
    private void Update()
    {
        // 當道具數量 >= 5 任務完成 true
        // 三元運算子語法 - 布林運算式 ? 運算式A : 運算式B
        // 指派、呼叫 = ()
        complete = (count >= 5) ? true : false;

        test = score >= 60 ? "及格" : score >= 40 ? "補考" : "被當";

        switch (prop)
        {
            case "紅水":
                print("補HP");
                break;           
            case "藍水":
                print("補MP");
                break;          
            case "藥水":
                print("補EXP");
                break;
            default:
                print("你吃錯道具了");
                break;
        }

        switch (season)
        {
            case Season.Spring:
                print("春");
                break;           
            case Season.Summer:
                print("夏");
                break;           
            case Season.Fall:
                print("秋");
                break;           
            case Season.Winter:
                print("冬");
                break;
        }

        // 當 openDoor 為 true 執行 (開門)
        // 當 openDoor 為 false 執行 (關門)
        // if (openDoor == true)
        if (openDoor)
        {
            print("開門~");
        }
        else
        {
            print("關門~");
        }

        // 比較運算子、邏輯運算子結果為布林值
        // 大於等於60及格
        // 小於60被當
        // 一組判斷式只會有一個結果
        if (score >= 60)
        {
            print("及格~");
        }
        else if(score >= 40)
        {
            print("補考~");
        }
        else if(score >= 20)
        {
            print("付錢補考~");
        }
        else
        {
            print("被當~");
        }

        if (hp >= 70)
        {
            print("安全");
        }       
        else if (hp >= 20)
        {
            print("警告");
        }        
        else
        {
            print("危險 !");
        }
    }
}
