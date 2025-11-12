using UnityEngine;

public class DebugMoneyTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DebugMoneyAccount.DebugMoney += 10;
            Debug.Log(DebugMoneyAccount.DebugMoney);
        }
    }
}
