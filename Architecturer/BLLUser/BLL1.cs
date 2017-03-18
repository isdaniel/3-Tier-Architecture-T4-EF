

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
       private IDBSession Active_RecordDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Active_RecordDAL.IActive_RecordDal;
       }
	}

	public partial class Active_Record_ItemsBLL : BaseBLL<Active_Record_Items>, IActive_Record_ItemsBLL
	{
       private IDBSession Active_Record_ItemsDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Active_Record_ItemsDAL.IActive_Record_ItemsDal;
       }
	}

	public partial class Active_RuleBLL : BaseBLL<Active_Rule>, IActive_RuleBLL
	{
       private IDBSession Active_RuleDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Active_RuleDAL.IActive_RuleDal;
       }
	}

	public partial class Active_TypeBLL : BaseBLL<Active_Type>, IActive_TypeBLL
	{
       private IDBSession Active_TypeDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Active_TypeDAL.IActive_TypeDal;
       }
	}

	public partial class Library_BookBLL : BaseBLL<Library_Book>, ILibrary_BookBLL
	{
       private IDBSession Library_BookDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Library_BookDAL.ILibrary_BookDal;
       }
	}

	public partial class Library_BookImgaeBLL : BaseBLL<Library_BookImgae>, ILibrary_BookImgaeBLL
	{
       private IDBSession Library_BookImgaeDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Library_BookImgaeDAL.ILibrary_BookImgaeDal;
       }
	}

	public partial class Login_LogBLL : BaseBLL<Login_Log>, ILogin_LogBLL
	{
       private IDBSession Login_LogDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Login_LogDAL.ILogin_LogDal;
       }
	}

	public partial class Login_UserBLL : BaseBLL<Login_User>, ILogin_UserBLL
	{
       private IDBSession Login_UserDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Login_UserDAL.ILogin_UserDal;
       }
	}

	public partial class parameterBLL : BaseBLL<parameter>, IparameterBLL
	{
       private IDBSession parameterDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =parameterDAL.IparameterDal;
       }
	}
}
