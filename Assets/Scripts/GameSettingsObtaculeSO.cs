using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsObtacule", menuName = "Settings/GameSettingsObtacule")]
public class GameSettingsObtaculeSO: ScriptableObject
{
    private float RandomX;
    private float RandomY;
    [SerializeField] public Vector2 startPosition;
   
    
    private void OnEnable()     // Inicializo los obstaculos por fuera de la escena del game en un rango random
    {
        RandomX = Random.Range(10f, 10.5f);
        RandomY = Random.Range(-1.2f, 2f);
        startPosition = new Vector2(RandomX, RandomY);
    }
}
    