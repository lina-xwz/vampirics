using UnityEngine;

public class MoneyTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MoneyAccount.Money += 1;
            Destroy(gameObject);
            Debug.Log(MoneyAccount.Money);
        }
    }
}
