using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsPlayer", menuName = "Settings/GameSettingsPlayer")]
public class GameSettingsPlayerSO : ScriptableObject
{
    [SerializeField] public float startPositionx = -6f;
    [SerializeField] public float startPositiony = -1.2f;
    [SerializeField] public KeyCode moveUp = KeyCode.Space;
    [SerializeField] public Vector2 startPosition;
    private void OnEnable()
    {
        startPosition = new Vector2(startPositionx, startPositiony);
    }  

}
    