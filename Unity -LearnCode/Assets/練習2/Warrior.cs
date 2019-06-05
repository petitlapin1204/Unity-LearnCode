[System.Serializable]
public class Warrior
{
    public int exp;
    public int lv;

    /// <summary>
    /// 取得設定戰士的經驗值
    /// </summary>
    public int Exp
    {
        get //取得存取值
        {
            return lv * 10;
        }
        set 
        {
            exp = value;
        }
    }
}