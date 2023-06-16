using UnityEngine;

public abstract class MinableResource : MonoBehaviour, IDestroyable, IMineable
{
    private int amount;

    private int hardness;  

    public abstract void Destroy();
    public abstract void Mine(int efficiency);
}

