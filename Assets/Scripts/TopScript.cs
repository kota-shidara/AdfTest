using AFolder;
using BFolder;
using CFolder;
using UnityEngine;
using VContainer.Unity;

namespace Top
{
    public class TopScript : IStartable
    {
        private AbScript _ab;
        private BaScript _ba;
        private CaScript _ca;
        
        public TopScript(AbScript ab, BaScript ba, CaScript ca)
        {
            _ab = ab;
            _ba = ba;
            _ca = ca;
        }
        
        public void SelfIntroduce()
        {
            Debug.Log("= I am Top =");
        }
        
        public void CallAllDependencies()
        {
            Debug.Log("==== TopScript ====");
            this.SelfIntroduce();
            _ab.SelfIntroduce();
            _ba.SelfIntroduce();
            _ca.SelfIntroduce();
        }
        
        void IStartable.Start()
        {
            this.CallAllDependencies();
        }
    }   
}
