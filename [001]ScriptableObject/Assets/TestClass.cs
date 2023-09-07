using System;
using UnityEngine;

namespace Practice.ScriptableObject001
{
    [Serializable]//클래스를 직렬화하여 데이터를 저장할 수 있도록 만든다.
    public class TestClass
    {
        public int Id;
        public int Value;
        public float Ratio;
        public bool Boolean;
        public GameObject Prefab;//게임 오브젝트 혹은
        public Sprite Image;//이미지 등의 데이터 또한 저장 가능하다.
    }
}
