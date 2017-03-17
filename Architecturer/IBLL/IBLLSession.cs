using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{  
    /*
        提供外部BLLRepositroy介面讓UI層決定要用哪個BLL
        可搭配IOC,DI來降低耦合
        例如目前有Service_A和Service_B，
        外部可以用IBLLDBSession來決定要實現哪個Service       
    */
    public partial interface IBLLSession
    {
        
    }
}
