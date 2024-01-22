using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum NPCType
{
    Hanhyoseung,
    Moonyungho,
    Leehansol,
}

public class NPCStats : MonoBehaviour
{
    [SerializeField] public NPCType type;

}
