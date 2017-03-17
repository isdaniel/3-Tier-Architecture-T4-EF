 
using Model;
using IDAL;
namespace DALMSSQL
{  
	
	public partial class Active_RecordDal :BaseDAL<Active_Record>,IActive_RecordDal
    {
      
    }
	
	public partial class Active_Record_ItemsDal :BaseDAL<Active_Record_Items>,IActive_Record_ItemsDal
    {
      
    }
	
	public partial class Active_RuleDal :BaseDAL<Active_Rule>,IActive_RuleDal
    {
      
    }
	
	public partial class Active_TypeDal :BaseDAL<Active_Type>,IActive_TypeDal
    {
      
    }
	
	public partial class Library_BookDal :BaseDAL<Library_Book>,ILibrary_BookDal
    {
      
    }
	
	public partial class Library_BookImgaeDal :BaseDAL<Library_BookImgae>,ILibrary_BookImgaeDal
    {
      
    }
	
	public partial class Login_LogDal :BaseDAL<Login_Log>,ILogin_LogDal
    {
      
    }
	
	public partial class Login_UserDal :BaseDAL<Login_User>,ILogin_UserDal
    {
      
    }
	
	public partial class parameterDal :BaseDAL<parameter>,IparameterDal
    {
      
    }
	
}