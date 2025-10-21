using UnityEngine;

public class AchReward : MonoBehaviour
{

    public void Reward()
    {
        MoneyAccount.Money += 100;
        Debug.Log(MoneyAccount.Money);
        Destroy(gameObject);
    }
}
