
using UnityEngine;

class IronOreChunk : Item
{
    public override GameObject Pick()
    {
        gameObject.SetActive(false);
        return gameObject;

    }
}

