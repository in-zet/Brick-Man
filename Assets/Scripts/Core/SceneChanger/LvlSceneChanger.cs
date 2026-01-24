using System;
using UnityEngine;

public class LvlSceneChanger : BaseSceneChanger
{
    //0: 다음 레벨
    //1: 레벨 선택 화면

    //레벨 나가기
    public void OnClickedQuit()
    {
        //정지 풀기가 ChangeScene 안에 있음
        ChangeScene(nextScenes[1], 0.5f);
    }
}
