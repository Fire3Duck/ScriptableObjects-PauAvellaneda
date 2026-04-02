using UnityEngine;
using UnityEngine.UI;
    public class LenguageManager : MonoBehaviour
{
    public ScriptableLanguage language;
    public GameObject inspectWindow;

    public Text inspectionName;
    public Text inspectionDescription;
    
    public Button thisSlotButton;
    public Button closeButton;
    void Start()
    {
        thisSlotButton = GetComponentInChildren<Button>();
        thisSlotButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        inspectWindow.SetActive(true);
    }

    void CloseWindow()
    {
        inspectWindow.SetActive(false);

        closeButton.onClick.RemoveListener(CloseWindow);
    }
}