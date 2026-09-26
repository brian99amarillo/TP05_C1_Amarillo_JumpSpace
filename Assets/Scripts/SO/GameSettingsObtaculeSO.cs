using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsObtacule", menuName = "Settings/GameSettingsObtacule")]
public class GameSettingsObtaculeSO: ScriptableObject
{
    [SerializeField] public float minY = -1.2f;
    [SerializeField] public float maxY = 2f;
     

    public float RandomY()          // Posicion en el eje Y del obtaculo al instanciarce
    {
        return Random.Range(minY, maxY);
    }
}
    