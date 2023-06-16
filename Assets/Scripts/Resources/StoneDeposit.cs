using UnityEngine;

public class StoneDeposit : MinableResource
{
    private int amount = 50;

    private int hardness = 1;

    [SerializeField]private GameObject parts;

    public override void Destroy()
    {
        gameObject.SetActive(false);
        if (parts != null)
        {
            parts.transform.position = gameObject.transform.position;
            parts.SetActive(true);
        }
        
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