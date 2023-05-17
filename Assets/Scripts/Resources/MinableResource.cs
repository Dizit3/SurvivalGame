using UnityEngine;

public abstract class MinableResource : MonoBehaviour, IDestroyable, IMineable
{
    public abstract void Destroy();
    public abstract void Mine(int efficiency);
}

