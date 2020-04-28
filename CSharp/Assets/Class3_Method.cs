using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    public Person person1,person2;

    private void Start()
    {
        // 呼叫 person1 用法 Talk
        person1.Talk();
        person2.Talk();
        print("屁孩 BMI :" + person1.BMI());
        print("警察 BMI :" + person2.BMI());
        // 使用有參數的方法必須填入對應的引數
        // 指定選填式參數 [選填式參數名稱: 值]
        person1.walk(66, sound: "咖咖咖");
        person2.walk(88, "右邊");

        person1.Attack();
        person2.Attack("沙漠之鷹");
    }
}