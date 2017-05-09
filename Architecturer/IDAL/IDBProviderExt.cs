 
using Model;
namespace IDAL
{  

	public partial interface IDBProvider    
    {	 
            IActive_RecordDal IActive_RecordDal{get;}
        	 
            IActive_Record_ItemsDal IActive_Record_ItemsDal{get;}
        	 
            IActive_RuleDal IActive_RuleDal{get;}
        	 
            IActive_TypeDal IActive_TypeDal{get;}
        	 
            ILibrary_BookDal ILibrary_BookDal{get;}
        	 
            ILibrary_BookImgaeDal ILibrary_BookImgaeDal{get;}
        	 
            ILogin_LogDal ILogin_LogDal{get;}
        	 
            ILogin_UserDal ILogin_UserDal{get;}
        	 
            IparameterDal IparameterDal{get;}
        	
    }

}