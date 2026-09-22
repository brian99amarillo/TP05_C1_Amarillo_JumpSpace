using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsPlataform", menuName = "Settings/GameSettingsPlataform")]
public class GameSettingsPlataformSO : ScriptableObject
{
    [SerializeField] private float starPosicionX = 0f;
    [SerializeField] private float starPosicionY = -1.5f;
     public Vector2 startPosition;
    
   public void PositionPlataform()
    {
        startPosition = new Vector2(-starPosicionX, starPosicionY);
    }

}