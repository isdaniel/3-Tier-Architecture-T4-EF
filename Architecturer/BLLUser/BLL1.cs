

using IDAL;
using DALRepository;
using Model;
using IBLL;

/*
    因為是partial類 可以在外面實現此類的Interface
    並用partial類別來實現動作
*/
namespace Service_A
{

	public partial class Active_RecordBLL : BaseBLL<Active_Record>, IActive_RecordBLL
	{
       public override void SetDAL(){
           dal =DBProvider.IActive_RecordDal;
       }
	}

	public partial class Active_Record_ItemsBLL : BaseBLL<Active_Record_Items>, IActive_Record_ItemsBLL
	{
       public override void SetDAL(){
           dal =DBProvider.IActive_Record_ItemsDal;
       }
	}

	public partial class Active_RuleBLL : BaseBLL<Active_Rule>, IActive_RuleBLL
	{
       public override void SetDAL(){
           dal =DBProvider.IActive_RuleDal;
       }
	}

	public partial class Active_TypeBLL : BaseBLL<Active_Type>, IActive_TypeBLL
	{
       public override void SetDAL(){
           dal =DBProvider.IActive_TypeDal;
       }
	}

	public partial class Library_BookBLL : BaseBLL<Library_Book>, ILibrary_BookBLL
	{
       public override void SetDAL(){
           dal =DBProvider.ILibrary_BookDal;
       }
	}

	public partial class Library_BookImgaeBLL : BaseBLL<Library_BookImgae>, ILibrary_BookImgaeBLL
	{
       public override void SetDAL(){
           dal =DBProvider.ILibrary_BookImgaeDal;
       }
	}

	public partial class Login_LogBLL : BaseBLL<Login_Log>, ILogin_LogBLL
	{
       public override void SetDAL(){
           dal =DBProvider.ILogin_LogDal;
       }
	}

	public partial class Login_UserBLL : BaseBLL<Login_User>, ILogin_UserBLL
	{
       public override void SetDAL(){
           dal =DBProvider.ILogin_UserDal;
       }
	}

	public partial class parameterBLL : BaseBLL<parameter>, IparameterBLL
	{
       public override void SetDAL(){
           dal =DBProvider.IparameterDal;
       }
	}
}
