
using UnityEngine;

 public abstract class Tool : MonoBehaviour, IUsable, IEquipable
{
    public abstract GameObject Equip();
    public abstract void Use();
   
}

