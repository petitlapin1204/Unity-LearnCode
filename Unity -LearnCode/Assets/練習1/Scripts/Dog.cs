using UnityEngine;

[System.Serializable]
public class Dog
{
    #region 欄位 //region是程式碼
    public string name;
    public float weight;
    public string type; 
    public string color;

    private string sex;
    private int age;
    #endregion //有開頭就有結束

    #region 建構函式
    //建構函式可以多載
    public Dog()
    {

    }

    public Dog(string sex,int age)
    {
        this.sex = sex;
        this.age = age;
    }
    #endregion

    #region 方法
    /// <summary>
    /// 狗狗叫聲的方法
    /// </summary>
    public void Bark()//叫聲
    {
        Debug.Log(name + ":汪汪!!!");
    }
    
    /// <summary>
    /// 轉換狗狗年齡的方法
    /// </summary>
    /// <returns>狗狗年齡*7</returns>
    public int ConvertAge() 
    {
        return age * 7;
    }
    
    /// <summary>
    /// 狗狗吃東西的方法.速度
    /// </summary>
    /// <param name="food"></param>
    /// <param name="speed"></param>
    public void Eat(string food,string speed = "慢")
    {
        Debug.Log(name + ":" + food + "，速度:" + speed); 
    }

    /// <summary>
    /// 狗狗吃東西的方法.份量
    /// </summary>
    /// <param name="food"></param>
    /// <param name="count"></param>
    public void Eat(string food,int count)
    {
        Debug.Log(name + ":" + food + "，份量:" + count);
    }
    #endregion
}