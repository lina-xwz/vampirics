using UnityEngine;

public class JewelTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MoneyAccount.Money += 100;
            Destroy(gameObject);
            Debug.Log(MoneyAccount.Money);
        }
    }
}

