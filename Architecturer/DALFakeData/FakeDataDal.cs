 
using Model;
using IDAL;
namespace DALFakeData
{  
	
	public partial class Active_RecordDal :FakeBaseDAL<Active_Record>,IActive_RecordDal
    {
      
    }
	
	public partial class Active_Record_ItemsDal :FakeBaseDAL<Active_Record_Items>,IActive_Record_ItemsDal
    {
      
    }
	
	public partial class Active_RuleDal :FakeBaseDAL<Active_Rule>,IActive_RuleDal
    {
      
    }
	
	public partial class Active_TypeDal :FakeBaseDAL<Active_Type>,IActive_TypeDal
    {
      
    }
	
	public partial class Library_BookDal :FakeBaseDAL<Library_Book>,ILibrary_BookDal
    {
      
    }
	
	public partial class Library_BookImgaeDal :FakeBaseDAL<Library_BookImgae>,ILibrary_BookImgaeDal
    {
      
    }
	
	public partial class Login_LogDal :FakeBaseDAL<Login_Log>,ILogin_LogDal
    {
      
    }
	
	public partial class Login_UserDal :FakeBaseDAL<Login_User>,ILogin_UserDal
    {
      
    }
	
	public partial class parameterDal :FakeBaseDAL<parameter>,IparameterDal
    {
      
    }
	
}