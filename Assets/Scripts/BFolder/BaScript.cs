// using AFolder;
using CFolder;
using UnityEngine;

namespace BFolder
{
    public class BaScript
    {
        private CaScript _ca;
        // private AbScript _ab_inverse;
        
        // public BaScript(CaScript ca, AbScript ab)
        // {
        //     _ca = ca;
        //     _ab_inverse = ab;
        //     CallAllDependencies();
        // }
        
        public BaScript(CaScript ca)
        {
            _ca = ca;
            CallAllDependencies();
        }
        
        public void SelfIntroduce()
        {
            Debug.Log("= I am Ba =");
        }
        
        public void CallAllDependencies()
        {
            Debug.Log("==== BaScript ====");
            this.SelfIntroduce();
            _ca.SelfIntroduce();
            // _ab_inverse.SelfIntroduce();
        }
    }
}