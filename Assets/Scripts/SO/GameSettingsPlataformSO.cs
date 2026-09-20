using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsPlataform", menuName = "Settings/GameSettingsPlataform")]
public class GameSettingsPlataformSO : ScriptableObject
{
    [SerializeField] public float starPosicionX = 11f;
    [SerializeField] public float starPosicionY = 0f;
    [SerializeField] public Vector2 startPosition;
    [SerializeField] public float speed = 5f;
    
    private void OnEnable()
    {
        startPosition = new Vector2(-starPosicionX, starPosicionY);
    }

}