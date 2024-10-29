using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerDataSO")] 
public class PlayerDataSO : ScriptableObject
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;

    public float jumpStrength = 2;

    public float sensitivity = 2;
    public float smoothing = 1.5f;

    public float InteractRange = 3;

    public int healthRegenTime = 3;
    public int healthRegenValue = 1;
    public int maxHealth = 1000;
}
