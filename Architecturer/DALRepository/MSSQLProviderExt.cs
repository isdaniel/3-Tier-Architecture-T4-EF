 
using DALMSSQL;
using IDAL;
namespace DALRepository
{  
    /*
        資料倉儲要類別實體由這邊拿
    */
	public partial class MSSQLProvider : IDBProvider
    {
        	
            private IActive_RecordDal iActive_Recorddal=null;
            public IActive_RecordDal IActive_RecordDal{
                get
                   {
                        if(iActive_Recorddal==null)
                            iActive_Recorddal=new Active_RecordDal();
                        return iActive_Recorddal;
                   }
            }
        	
            private IActive_Record_ItemsDal iActive_Record_Itemsdal=null;
            public IActive_Record_ItemsDal IActive_Record_ItemsDal{
                get
                   {
                        if(iActive_Record_Itemsdal==null)
                            iActive_Record_Itemsdal=new Active_Record_ItemsDal();
                        return iActive_Record_Itemsdal;
                   }
            }
        	
            private IActive_RuleDal iActive_Ruledal=null;
            public IActive_RuleDal IActive_RuleDal{
                get
                   {
                        if(iActive_Ruledal==null)
                            iActive_Ruledal=new Active_RuleDal();
                        return iActive_Ruledal;
                   }
            }
        	
            private IActive_TypeDal iActive_Typedal=null;
            public IActive_TypeDal IActive_TypeDal{
                get
                   {
                        if(iActive_Typedal==null)
                            iActive_Typedal=new Active_TypeDal();
                        return iActive_Typedal;
                   }
            }
        	
            private ILibrary_BookDal iLibrary_Bookdal=null;
            public ILibrary_BookDal ILibrary_BookDal{
                get
                   {
                        if(iLibrary_Bookdal==null)
                            iLibrary_Bookdal=new Library_BookDal();
                        return iLibrary_Bookdal;
                   }
            }
        	
            private ILibrary_BookImgaeDal iLibrary_BookImgaedal=null;
            public ILibrary_BookImgaeDal ILibrary_BookImgaeDal{
                get
                   {
                        if(iLibrary_BookImgaedal==null)
                            iLibrary_BookImgaedal=new Library_BookImgaeDal();
                        return iLibrary_BookImgaedal;
                   }
            }
        	
            private ILogin_LogDal iLogin_Logdal=null;
            public ILogin_LogDal ILogin_LogDal{
                get
                   {
                        if(iLogin_Logdal==null)
                            iLogin_Logdal=new Login_LogDal();
                        return iLogin_Logdal;
                   }
            }
        	
            private ILogin_UserDal iLogin_Userdal=null;
            public ILogin_UserDal ILogin_UserDal{
                get
                   {
                        if(iLogin_Userdal==null)
                            iLogin_Userdal=new Login_UserDal();
                        return iLogin_Userdal;
                   }
            }
        	
            private IparameterDal iparameterdal=null;
            public IparameterDal IparameterDal{
                get
                   {
                        if(iparameterdal==null)
                            iparameterdal=new parameterDal();
                        return iparameterdal;
                   }
            }
        	
    }

}