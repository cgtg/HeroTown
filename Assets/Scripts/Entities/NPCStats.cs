using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum NPCType
{
    Hanhyoseung,
    Moonyungoh,
    Leehansol,
}

// TODO : 스크립터블 오브젝트로 변경?
public class NPCStats : MonoBehaviour
{
    [SerializeField] public NPCType type;

}
