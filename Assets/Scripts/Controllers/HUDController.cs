using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    [SerializeField] private GameObject _asidePanel;
    [SerializeField] private GameObject _bottomPanel;

    [SerializeField] private GameObject _nameChange;
    [SerializeField] private TMP_InputField _TextMeshProUGUI;
    [SerializeField] private GameObject _alertText;

    [SerializeField] private GameObject _characterChange;

    public void ShowChangeName()
    {
        GameManager.Instance.IsPlaying = false;
        _nameChange.SetActive(true);
    }

    public void ApplyChangeName()
    {
        if (DataManager.Instance.CheckVaildName(_TextMeshProUGUI.text))
        {
            _alertText.SetActive(false);
            // 게임 시작
            DataManager.Instance.myName = _TextMeshProUGUI.text;
            _nameChange.SetActive(false);
            GameManager.Instance.SetCharacter();
        }
        else
        {
            // 닉 설정 다시
            _alertText.SetActive(true);
        }
    }

    public void ShowChangeCharacter()
    {
        GameManager.Instance.IsPlaying = false;
        _characterChange.SetActive(true);
    }

    public void ApplyChangeCharacter(int character)
    {
        DataManager.Instance.curCharacter = (Character)character;
        _characterChange.SetActive(false);
        GameManager.Instance.SetCharacter();
    }

    public void ShowUserList()
    {
        _asidePanel.SetActive(true);
    }

    //public void ApplyChangeCharacter(int character)
    //{
    //    DataManager.Instance.curCharacter = (Character)character;
    //    _characterChange.SetActive(false);
    //    GameManager.Instance.SetCharacter();
    //}
}
