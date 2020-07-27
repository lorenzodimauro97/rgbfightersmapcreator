using UnityEngine;

public class NetworkEntity : MonoBehaviour
{
    public enum Entity{ Ammo, Gun, Movable }

    public Entity entityType;
    public string gunId;
    public string entityId;
}
