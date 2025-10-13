using UnityEngine;

public class TriggerForExit : MonoBehaviour
{
    [SerializeField] private GameObject internalMenu;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (internalMenu != null)
            {
                internalMenu.SetActive(true);
                Pause();
            }
            else
            {
                internalMenu.SetActive(false);
                Play();
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
    }
}