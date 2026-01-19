using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

//<summary>
//scene들을 바꾸는 메소드와 scene들을 바꿀 때 나올 효과를 위한 기본 클래스
//<summary>
public class BaseSceneChanger : MonoBehaviour
{
    //public scene 바꾸기
    //private 씬 로드

    //이동할 씬들 목록
    public string[] nextScenes;

    //씬 바꾸기
    protected void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    //LoadSceneAsync 위한 코루틴
    /*
    private IEnumerator SceneLoading()
    {
        
    }
    */
}
