using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsPlayer", menuName = "Settings/GameSettingsPlayer")]
public class GameSettingsPlayerSO : ScriptableObject
{
    [SerializeField] private float startPositionx = 0f;
    [SerializeField] private float startPositiony = 0f;
    [SerializeField] private KeyCode moveUp = KeyCode.Space;
    [SerializeField] public Vector2 startPosition;
    [SerializeField] public float speed=10f;
    private void OnEnable()
    {
        startPosition = new Vector2(startPositionx, startPositiony);
    }  

}
    