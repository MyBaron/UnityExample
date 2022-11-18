using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example5
{
    public class Fade : MonoBehaviour
    {

        public GameObject shadow;
        private Example5.Player _player;
        private float _coolTime;
    
        // Start is called before the first frame update
        void Start()
        {
            _player = GetComponentInParent<Example5.Player>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_player.isMove)
            {
                if (_coolTime <= 0)
                {
                    GameObject instance = Instantiate(shadow, transform.position, Quaternion.identity);
                    instance.transform.localScale = new Vector3 (transform.localScale.x, 1, 1);
                    Destroy(instance, 0.4f);
                    _coolTime = 0.02f;
                }
                else
                {
                    _coolTime -= Time.deltaTime;
                }

            }
        }
    }

}
