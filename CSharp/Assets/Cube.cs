using UnityEngine;

/// <summary>
/// 立方體 繼承 形狀類別
/// </summary>
public class Cube : shape
{
    private void Start()
    {
        print(gameObject + "體積 : " + GetVolume());
    }
}
