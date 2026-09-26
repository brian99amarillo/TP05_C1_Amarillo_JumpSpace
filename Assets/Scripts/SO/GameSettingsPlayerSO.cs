using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsPlayer", menuName = "Settings/GameSettingsPlayer")]
public class GameSettingsPlayerSO : ScriptableObject
{
    [SerializeField] private float startPositionx = 0f;
    [SerializeField] private float startPositiony = 0f;
    //[SerializeField] private KeyCode Space = KeyCode.Space;
    [SerializeField] private Vector2 startPosition;
    [SerializeField] private float speed=10f;

    public Vector2 StartPosition => startPosition;
    public float Speed => speed;

    private void OnEnable()
    {
        startPosition = new Vector2(startPositionx, startPositiony);
    }  
}
    