using UnityEngine;

public class UILife : MonoBehaviour
{
    public static UILife Instance;

    [SerializeField] private GameObject Life1;
    [SerializeField] private GameObject Life2;
    [SerializeField] private GameObject Life3;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateHearts(int counter)
    {
        Life1.SetActive(counter >= 1);
        Life2.SetActive(counter >= 2);
        Life3.SetActive(counter >= 3);
    }
}
