 
using Model;
namespace IBLL{
    public partial interface IBLLSession{

    	
	     IActive_RecordBLL IActive_RecordBLL{get;set;}
    	
	     IActive_Record_ItemsBLL IActive_Record_ItemsBLL{get;set;}
    	
	     IActive_RuleBLL IActive_RuleBLL{get;set;}
    	
	     IActive_TypeBLL IActive_TypeBLL{get;set;}
    	
	     ILibrary_BookBLL ILibrary_BookBLL{get;set;}
    	
	     ILibrary_BookImgaeBLL ILibrary_BookImgaeBLL{get;set;}
    	
	     ILogin_LogBLL ILogin_LogBLL{get;set;}
    	
	     ILogin_UserBLL ILogin_UserBLL{get;set;}
    	
	     IparameterBLL IparameterBLL{get;set;}
        }
	
}