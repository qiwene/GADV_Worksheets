using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectNamespace1
{
    public class DataTypesDemo : MonoBehaviour
    {
        private void Start()
        {
            int num;
            string aText = "126";
            num = int.Parse(aText);

            Debug.Log("The number is \"" + num + "\"");
        }

    }
}