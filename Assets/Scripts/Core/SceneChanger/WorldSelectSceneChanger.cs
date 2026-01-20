using UnityEngine;

//<summary>
//WorldSelection의 Scenechanger
//<summary>
public class WorldSelectSceneChange : BaseSceneChanger
{
    //MainMenu로 돌아가기(0번)
    public void OnClickedExit()
    {
        ChangeScene(nextScenes[0]);
    }

    //worldNum에 해당하는 World로 씬 바꾸기(1번부터 시작)
    public void OnClickedWorld(int worldNum)
    {
        ChangeScene(nextScenes[worldNum]);
    }
}
