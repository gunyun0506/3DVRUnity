using UnityEngine;

public class ExitScene : MonoBehaviour
{
        public void Exit()
    {
        Debug.Log("Exit button clicked");
        Application.Quit();

#if UNITY_EDITOR
        // 에디터에서 실행 중일 경우, 플레이 모드를 종료
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
