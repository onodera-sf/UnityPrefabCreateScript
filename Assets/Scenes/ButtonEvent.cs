using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  [SerializeField] private GameObject SpritePrefab;

  public void OnClick()
  {
    // Instantiate �Ƀv���n�u��n���Ƃ�������ƂɐV�����I�u�W�F�N�g�𐶐�����
    var obj = Instantiate(SpritePrefab);

    // �z�u�ʒu�̓����_����
    obj.transform.localPosition = new Vector3(Random.value * 6 - 3, Random.value * 6 - 3);
  }
}
