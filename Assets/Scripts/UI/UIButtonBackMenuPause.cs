using UnityEngine;
using UnityEngine.UI;

public class UIButtonBackMenuPause : MonoBehaviour
{
    [Header("Back Buttons")]
    [SerializeField] private Button btnBackSettings; 
    [SerializeField] private Button btnBackCreditts; 

    [Header("Panels")]
    [SerializeField] private GameObject MenuPause;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject CredittsPanel;

    private void Awake()
    {
        // Botones de volver
        btnBackSettings.onClick.AddListener(OnBackButtonSettingsClicked); 
        btnBackCreditts.onClick.AddListener(OnBackButtonCredittsClicked);
    }

    private void OnDestroy()
    {
        btnBackSettings.onClick.RemoveListener(OnBackButtonSettingsClicked);
        btnBackCreditts.onClick.RemoveListener(OnBackButtonCredittsClicked);
    }

    private void OnBackButtonSettingsClicked()
    {
        MenuPause.SetActive(true);
        SettingsPanel.SetActive(false);
    }

    private void OnBackButtonCredittsClicked()
    {
        MenuPause.SetActive(true);
        CredittsPanel.SetActive(false);
    }
}
