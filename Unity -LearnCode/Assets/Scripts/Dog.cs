using UnityEngine;

public class Dog
{
    #region 欄位 //region是程式碼
    public string name;
    public float weight;
    public string type;
    public string sex;
    public string color;
    public int age;
    #endregion //有開頭就有結束

    #region 方法
    public void Bark()
    {
        Debug.Log(name + :"汪汪!!!");
    }
    #endregion

}