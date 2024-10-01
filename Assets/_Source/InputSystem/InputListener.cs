using UnityEngine;

public class InputListener : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Player player;
    [SerializeField] private PlayerAttack _playerAttack;
    [SerializeField] private EndGameSystem _endGameSystem;

    private PlayerInvoker _playerInvoker;

    private void Awake()
    {
        _playerInvoker = new(player, _playerAttack);
    }
    private void Update()
    {
        ReadMoveInput();
        ReadMouseClickInput();
        ReadGameRetryInput();
    }
    private void ReadMoveInput()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _playerInvoker.InvokeMoveLeft();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _playerInvoker.InvokeMoveRight();
        }
    }
    private void ReadMouseClickInput()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            _playerInvoker.InvokeAttack();
        }
    }
    private void ReadGameRetryInput()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            _endGameSystem.RetryLevel();
        }
    }
}
