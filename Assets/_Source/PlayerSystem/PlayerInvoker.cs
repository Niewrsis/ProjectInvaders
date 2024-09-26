public class PlayerInvoker
{
    private PlayerMovement _playerMovement;
    private PlayerAttack _playerAttack;
    private Player _player;

    public PlayerInvoker(Player player, PlayerAttack playerAttack)
    {
        _playerMovement = new();
        _playerAttack = playerAttack;
        _player = player;
    }
    public void InvokeMoveLeft()
    {
        _playerMovement.MoveLeft(_player.Transform, _player.MovementSpeed);
    }
    public void InvokeMoveRight()
    {
        _playerMovement.MoveRight(_player.Transform, _player.MovementSpeed);
    }
    public void InvokeAttack()
    {
        _playerAttack.Shoot(_player.transform, _player.AttackSpeed);
    }
}
