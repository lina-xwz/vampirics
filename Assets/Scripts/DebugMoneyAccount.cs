using UnityEngine;

public class DebugMoneyAccount : MonoBehaviour
{
    public static int DebugMoney;

    public void Nullification()
    {
        DebugMoney = 0;
    }

    public void Updating()
    {
        MoneyAccount.Money -= DebugMoney;
        DebugMoney = 0;
    }

}
