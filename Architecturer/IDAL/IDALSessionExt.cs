 
using Model;
namespace IDAL
{  

	public partial interface IDBSession    
    {	 
            IActive_RecordDal IActive_RecordDal{get;set;}
        	 
            IActive_Record_ItemsDal IActive_Record_ItemsDal{get;set;}
        	 
            IActive_RuleDal IActive_RuleDal{get;set;}
        	 
            IActive_TypeDal IActive_TypeDal{get;set;}
        	 
            ILibrary_BookDal ILibrary_BookDal{get;set;}
        	 
            ILibrary_BookImgaeDal ILibrary_BookImgaeDal{get;set;}
        	 
            ILogin_LogDal ILogin_LogDal{get;set;}
        	 
            ILogin_UserDal ILogin_UserDal{get;set;}
        	 
            IparameterDal IparameterDal{get;set;}
        	
    }

}