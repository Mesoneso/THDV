using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rigidBody;
    public PlayerDataSO playerData;
    public event System.Action Jumped;

    [SerializeField, Tooltip("Prevents jumping when the transform is in mid-air.")]
    GroundCheck groundCheck;


    void Reset()
    {
        // Try to get groundCheck.
        groundCheck = GetComponentInChildren<GroundCheck>();
    }

    void Awake()
    {
        // Get rigidbody.
        rigidBody = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        // Jump when the Jump button is pressed and we are on the ground.
        if (Input.GetButtonDown("Jump") && (!groundCheck || groundCheck.isGrounded))
        {
            rigidBody.AddForce(Vector3.up * 100 * playerData.jumpStrength);
            Jumped?.Invoke();
        }
    }
}
