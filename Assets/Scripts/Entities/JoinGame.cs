using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinGame : MonoBehaviour
{
    [SerializeField] private TMP_InputField _TextMeshProUGUI;
    [SerializeField] private GameObject _alertText;


    public void StartGame()
    {
        Debug.Log(DataManager.Instance.CheckVaildName(_TextMeshProUGUI.text));
        if (DataManager.Instance.CheckVaildName(_TextMeshProUGUI.text))
        {
            DataManager.Instance.myName = _TextMeshProUGUI.text;
            _alertText.SetActive(false);
            // 게임 시작
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            // 닉 설정 다시
            _alertText.SetActive(true);
        }
    }


}
