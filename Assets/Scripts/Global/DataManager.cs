
using System.Text.RegularExpressions;
using UnityEngine;

public enum Character
{
    HeroKnight,
    LightBandit,
}

public class DataManager : Singleton<DataManager>
{
    public string[] NPC = { "한효승", "문영오", "이한솔" };

    public Character curCharacter;
    public string myName;
    Regex regex = new Regex(@"^[가-힣A-Za-z0-9]{2,10}$");

    protected override void Awake()
    {
        base.Awake();
        //    curCharacter = Character.HeroKnight;
    }


    public bool CheckVaildName(string input)
    {
        Debug.Log(input);
        return regex.IsMatch(input);
    }


}
