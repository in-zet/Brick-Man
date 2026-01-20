using UnityEngine;

//<summary>
//MainMenu의 Scenechanger
//<summary>
public class MainMenuSceneChange : BaseSceneChanger
{
    //게임 시작 버튼
    public void OnClickedStart()
    {
        ChangeScene(nextScenes[0]);
    }

    //게임 종료 버튼
    public void OnClickedExit()
    {
        GameManager.Instance.QuitGame();
    }
}
