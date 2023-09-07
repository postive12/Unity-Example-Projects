using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace Json
{
    public class JsonTest : MonoBehaviour
    {
        public JsonTestClass[] TestVariable;
        public TextAsset JsonFile;//Variable that contains json data
        private void Start()
        {
            Print();
        }
        //Json data load func
        public void Read()
        {
            var result = JsonConvert.SerializeObject(TestVariable);//Convert to json
            Debug.Log(result);
        }
        //Json export func
        public void Print()
        {
            
            var result = JsonConvert.DeserializeObject<JsonTestClass[]>(JsonFile.text);//convert to usable data
            foreach (var i in result)
            {
                Debug.Log($"Id : {i.Id}, Value : {i.Value}, Bool : {i.Boolean}");//Print data;
            }
            
        }
    }
}
