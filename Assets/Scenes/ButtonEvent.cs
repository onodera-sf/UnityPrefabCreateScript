using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  [SerializeField] private GameObject SpritePrefab;

  public void OnClick()
  {
    // Instantiate にプレハブを渡すとそれをもとに新しいオブジェクトを生成する
    var obj = Instantiate(SpritePrefab);

    // 配置位置はランダムに
    obj.transform.localPosition = new Vector3(Random.value * 6 - 3, Random.value * 6 - 3);
  }
}
