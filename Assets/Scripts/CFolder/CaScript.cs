using UnityEngine;
// using BFolder;

namespace CFolder
{
    public class CaScript
    {
        // private BbScript _bb_inverse;
        
        // public CaScript(BbScript bb)
        // {
        //     _bb_inverse = bb;
        //     CallAllDependencies();
        // }
        
        public CaScript()
        {
            CallAllDependencies();
        }
        public void SelfIntroduce()
        {
            Debug.Log("= I am Ca =");
        }
        
        public void CallAllDependencies()
        {
            Debug.Log("==== CaScript ====");
            this.SelfIntroduce();
            // _bb_inverse.SelfIntroduce();
        }
    }
}