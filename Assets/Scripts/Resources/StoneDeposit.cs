public class StoneDeposit : MinableResource
{
    private int amount = 50;

    private int hardness = 1;

    public override void Destroy()
    {
        Destroy(gameObject);
        
    }

    public override void Mine(int efficiency)
    {
        int miningSpeed = efficiency / hardness;

        amount -= miningSpeed;

        if (amount <= 0)
        {
            Destroy();
        }
    }
}