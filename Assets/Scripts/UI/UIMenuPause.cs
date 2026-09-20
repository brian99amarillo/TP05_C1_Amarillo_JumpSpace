using UnityEngine;
using UnityEngine.UI;

public class UIMenuPause : MonoBehaviour
{

    [Header("Menu Pause Buttons")]
    [SerializeField] private Button btnContinue;      
    [SerializeField] private Button btnSettings;    
    [SerializeField] private Button btnCreditts;    
    [SerializeField] private Button btnExit;       

    [Header("Panels & Scenes")]
    [SerializeField] private GameObject Pause;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject CredittsPanel;
    [SerializeField] private GameObject Game;
    private bool isPause = false;

    private void Awake()
    { 
        // Botones del menu principal
        btnContinue.onClick.AddListener(OnContinueButtonClicked);
        btnSettings.onClick.AddListener(OnSettingsButtonClicked);
        btnCreditts.onClick.AddListener(OnCredittsButtonClicked);
        btnExit.onClick.AddListener(OnExitButtonClicked);
    }

    private void Start()
    {
        Pause.SetActive(false);
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Escape)) || Input.GetKeyDown(KeyCode.P))  // Pausa el juego al presionar la tecla Escape o P, y abre el menu de pausa
        {
            if (isPause){Reanudar();} else { Pausar();}
        }
    }
    private void Pausar()
    {   isPause = true;
        Game.SetActive(false);
        Pause.SetActive(true);
        Time.timeScale = 0f; // Detiene el tiempo
    }

    private void Reanudar()
    {   isPause = false;
        Pause.SetActive(false);
        Game.SetActive(true);
        Time.timeScale = 1f; // Reanuda el tiempo
    }

    private void OnDestroy()  
    {
        // Botones del menu de pausa
        btnContinue.onClick.RemoveListener(OnContinueButtonClicked);
        btnSettings.onClick.RemoveListener(OnSettingsButtonClicked);
        btnCreditts.onClick.RemoveListener(OnCredittsButtonClicked);
        btnExit.onClick.RemoveListener(OnExitButtonClicked);
    }

    //Botones del Menu Pausa
    private void OnContinueButtonClicked() 
    { Reanudar();}   
    private void OnSettingsButtonClicked() 
    {
        Pause.SetActive(false);
        SettingsPanel.SetActive(true);
    }
    private void OnCredittsButtonClicked()
    {
        Pause.SetActive(false);
        CredittsPanel.SetActive(true);
    }
    private void OnExitButtonClicked() 
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}