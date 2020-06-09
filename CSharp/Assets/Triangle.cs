﻿using UnityEngine;

/// <summary>
/// 三角形 繼承 形狀
/// 三角形體積需要覆寫
/// </summary>
public class Triangle : shape
{
    /// <summary>
    /// override 覆寫 : 覆寫父類別
    /// </summary>
    /// <returns></returns>
    public override float GetVolume()
    {
        volume = length * width * height/2 ;      // 三角形體積
        return base.GetVolume();
    }

    private void Start()
    {
        print(gameObject + "體積 : " + GetVolume());
    }
}
