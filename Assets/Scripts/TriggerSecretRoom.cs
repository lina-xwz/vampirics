using UnityEngine;

public class TriggerSecretRoom : MonoBehaviour
{
    GameObject Fence;

    void Start()
    {
        Fence = GameObject.FindGameObjectWithTag("Fence");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Fence.SetActive(false);
        }
    }
}
