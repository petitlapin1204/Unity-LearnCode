using UnityEngine;

public class Dogmanger : MonoBehaviour
{
    # regio 欄位
    public Dog DogA = new Dog();
    public Dog DogB = new Dog();
    #endregion

    #region 事件
    private void Start()
    {
        DogA.name = "鬼娃";
        DogA.weight = 30.5f;
        DogA.type = "貴賓";
        DogA.sex = "公";
        DogA.color = "咖啡";
        DogA.age = 7;

        DogB.name = "恰吉";
        DogB.weight = 25.5f;
        DogB.type = "貴賓";
        DogB.sex = "母";
        DogB.color = "白色";
        DogB.age = 5;
    }
    #endregion


}