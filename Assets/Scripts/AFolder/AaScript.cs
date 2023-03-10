using BFolder;
using CFolder;
using UnityEngine;
using VContainer.Unity;

namespace AFolder
{
    public class AaScript : IStartable
    {
        private BaScript _ba;
        private CaScript _ca;
        
        public AaScript(AbScript ab, BaScript ba, CaScript ca)
        {
            _ba = ba;
            _ca = ca;
        }

        public void SelfIntroduce()
        {
            Debug.Log("= I am Aa =");
        }
        
        public void CallAllDependencies()
        {
            Debug.Log("==== AaScript ====");
            this.SelfIntroduce();
            _ba.SelfIntroduce();
            _ca.SelfIntroduce();
        }
        
        void IStartable.Start()
        {
            this.CallAllDependencies();
        }
    }
}