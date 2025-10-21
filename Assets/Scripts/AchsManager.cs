using UnityEngine;
using UnityEngine.UI;

public class AchsManager : MonoBehaviour
{
    [SerializeField] bool[] AchsWas;
    [SerializeField] Image[] AchsWins;
    [SerializeField] Button[] AchsButtons;
    [SerializeField] GameObject Notification;

    void Update()
    {
        if (!AchsWas[0] && MoneyAccount.Money > 9)
        {
            AchsWas[0] = true;
            AchsWins[0].color = new Color(0.54f, 0.93f, 0.65f);
            AchsButtons[0].gameObject.SetActive(true);
            Notification.SetActive(true);
        }

        if (!AchsWas[1] && TriggerNote.WasNote > 0)
        {
            AchsWas[1] = true;
            AchsWins[1].color = new Color(0.54f, 0.93f, 0.65f);
            AchsButtons[1].gameObject.SetActive(true);
            Notification.SetActive(true);
        }
    }

    public void Decontamination()
    {
        if (Notification.activeSelf)
        {
            Notification.SetActive(false);
        }
    }
}
