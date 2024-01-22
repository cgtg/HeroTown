using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChoose : MonoBehaviour
{
    [SerializeField] private Character _character;

    public void OnChoose()
    {
        Debug.Log(_character);
        DataManager.Instance.curCharacter = _character;
    }
}
