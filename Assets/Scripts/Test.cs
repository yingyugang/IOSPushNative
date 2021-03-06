using UnityEngine.UI;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Button enrollButton;
    public Text tokenTxt;
    public Text notificationTxt;

    private void Awake()
    {
        notificationTxt.text = NotificationIOS.GetLastNotification();
        enrollButton.onClick.AddListener(() =>
        {
            NotificationIOS.Register((token) =>
            {
                tokenTxt.text = token;
            }, (notification) =>
            {
                notificationTxt.text = notification;
            });
        });
    }
}
