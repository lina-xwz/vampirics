using UnityEngine;

public class TriggerNote : MonoBehaviour
{

    [SerializeField] private GameObject Note;
    public static int WasNote;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            WasNote += 1;
            Destroy(gameObject);
            if (Note != null)
            {
                Note.SetActive(true);
            }
        }
    }
}
