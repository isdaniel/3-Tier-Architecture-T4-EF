 
using Service_A;
using IBLL;
namespace ServiceRepository
{  
    /*
        資料倉儲要類別實體由這邊拿
    */    
	public partial class BLLService_A : IBLLSession
    {
        	
        private IActive_RecordBLL iActive_RecordBLL=null;
        public IActive_RecordBLL IActive_RecordBLL{
           get{
                if(iActive_RecordBLL==null)
                    iActive_RecordBLL=new Active_RecordBLL();
                return iActive_RecordBLL;
              }
           set{
                iActive_RecordBLL=value;
              }
        }
        	
        private IActive_Record_ItemsBLL iActive_Record_ItemsBLL=null;
        public IActive_Record_ItemsBLL IActive_Record_ItemsBLL{
           get{
                if(iActive_Record_ItemsBLL==null)
                    iActive_Record_ItemsBLL=new Active_Record_ItemsBLL();
                return iActive_Record_ItemsBLL;
              }
           set{
                iActive_Record_ItemsBLL=value;
              }
        }
        	
        private IActive_RuleBLL iActive_RuleBLL=null;
        public IActive_RuleBLL IActive_RuleBLL{
           get{
                if(iActive_RuleBLL==null)
                    iActive_RuleBLL=new Active_RuleBLL();
                return iActive_RuleBLL;
              }
           set{
                iActive_RuleBLL=value;
              }
        }
        	
        private IActive_TypeBLL iActive_TypeBLL=null;
        public IActive_TypeBLL IActive_TypeBLL{
           get{
                if(iActive_TypeBLL==null)
                    iActive_TypeBLL=new Active_TypeBLL();
                return iActive_TypeBLL;
              }
           set{
                iActive_TypeBLL=value;
              }
        }
        	
        private ILibrary_BookBLL iLibrary_BookBLL=null;
        public ILibrary_BookBLL ILibrary_BookBLL{
           get{
                if(iLibrary_BookBLL==null)
                    iLibrary_BookBLL=new Library_BookBLL();
                return iLibrary_BookBLL;
              }
           set{
                iLibrary_BookBLL=value;
              }
        }
        	
        private ILibrary_BookImgaeBLL iLibrary_BookImgaeBLL=null;
        public ILibrary_BookImgaeBLL ILibrary_BookImgaeBLL{
           get{
                if(iLibrary_BookImgaeBLL==null)
                    iLibrary_BookImgaeBLL=new Library_BookImgaeBLL();
                return iLibrary_BookImgaeBLL;
              }
           set{
                iLibrary_BookImgaeBLL=value;
              }
        }
        	
        private ILogin_LogBLL iLogin_LogBLL=null;
        public ILogin_LogBLL ILogin_LogBLL{
           get{
                if(iLogin_LogBLL==null)
                    iLogin_LogBLL=new Login_LogBLL();
                return iLogin_LogBLL;
              }
           set{
                iLogin_LogBLL=value;
              }
        }
        	
        private ILogin_UserBLL iLogin_UserBLL=null;
        public ILogin_UserBLL ILogin_UserBLL{
           get{
                if(iLogin_UserBLL==null)
                    iLogin_UserBLL=new Login_UserBLL();
                return iLogin_UserBLL;
              }
           set{
                iLogin_UserBLL=value;
              }
        }
        	
        private IparameterBLL iparameterBLL=null;
        public IparameterBLL IparameterBLL{
           get{
                if(iparameterBLL==null)
                    iparameterBLL=new parameterBLL();
                return iparameterBLL;
              }
           set{
                iparameterBLL=value;
              }
        }
        	
    }

}