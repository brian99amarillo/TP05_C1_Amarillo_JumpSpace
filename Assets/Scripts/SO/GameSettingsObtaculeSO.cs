using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsObtacule", menuName = "Settings/GameSettingsObtacule")]
public class GameSettingsObtaculeSO: ScriptableObject
{
    [SerializeField] public float minY = -1.2f;
    [SerializeField] public float maxY = 0.5f;
     

    public float RandomY()          // Inicializo los obstaculos por fuera de la escena del game en un rango random en el eje Y
    {
        return Random.Range(minY, maxY);
    }
}
    