

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
        int IBaseBLL<Active_Record>.Create(Active_Record model)
        {
             return -1;
        }

        int IBaseBLL<Active_Record>.Delete(Active_Record Id)
        {
            return -1;
        }

        int IBaseBLL<Active_Record>.UpdateById(Active_Record Id)
        {
             return -1;
        }
	}

	public partial class Active_Record_ItemsBLL : BaseBLL<Active_Record_Items>, IActive_Record_ItemsBLL
	{
       private IDBSession Active_Record_ItemsDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Active_Record_ItemsDAL.IActive_Record_ItemsDal;
       }
        int IBaseBLL<Active_Record_Items>.Create(Active_Record_Items model)
        {
             return -1;
        }

        int IBaseBLL<Active_Record_Items>.Delete(Active_Record_Items Id)
        {
            return -1;
        }

        int IBaseBLL<Active_Record_Items>.UpdateById(Active_Record_Items Id)
        {
             return -1;
        }
	}

	public partial class Active_RuleBLL : BaseBLL<Active_Rule>, IActive_RuleBLL
	{
       private IDBSession Active_RuleDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Active_RuleDAL.IActive_RuleDal;
       }
        int IBaseBLL<Active_Rule>.Create(Active_Rule model)
        {
             return -1;
        }

        int IBaseBLL<Active_Rule>.Delete(Active_Rule Id)
        {
            return -1;
        }

        int IBaseBLL<Active_Rule>.UpdateById(Active_Rule Id)
        {
             return -1;
        }
	}

	public partial class Active_TypeBLL : BaseBLL<Active_Type>, IActive_TypeBLL
	{
       private IDBSession Active_TypeDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Active_TypeDAL.IActive_TypeDal;
       }
        int IBaseBLL<Active_Type>.Create(Active_Type model)
        {
             return -1;
        }

        int IBaseBLL<Active_Type>.Delete(Active_Type Id)
        {
            return -1;
        }

        int IBaseBLL<Active_Type>.UpdateById(Active_Type Id)
        {
             return -1;
        }
	}

	public partial class Library_BookBLL : BaseBLL<Library_Book>, ILibrary_BookBLL
	{
       private IDBSession Library_BookDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Library_BookDAL.ILibrary_BookDal;
       }
        int IBaseBLL<Library_Book>.Create(Library_Book model)
        {
             return -1;
        }

        int IBaseBLL<Library_Book>.Delete(Library_Book Id)
        {
            return -1;
        }

        int IBaseBLL<Library_Book>.UpdateById(Library_Book Id)
        {
             return -1;
        }
	}

	public partial class Library_BookImgaeBLL : BaseBLL<Library_BookImgae>, ILibrary_BookImgaeBLL
	{
       private IDBSession Library_BookImgaeDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Library_BookImgaeDAL.ILibrary_BookImgaeDal;
       }
        int IBaseBLL<Library_BookImgae>.Create(Library_BookImgae model)
        {
             return -1;
        }

        int IBaseBLL<Library_BookImgae>.Delete(Library_BookImgae Id)
        {
            return -1;
        }

        int IBaseBLL<Library_BookImgae>.UpdateById(Library_BookImgae Id)
        {
             return -1;
        }
	}

	public partial class Login_LogBLL : BaseBLL<Login_Log>, ILogin_LogBLL
	{
       private IDBSession Login_LogDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Login_LogDAL.ILogin_LogDal;
       }
        int IBaseBLL<Login_Log>.Create(Login_Log model)
        {
             return -1;
        }

        int IBaseBLL<Login_Log>.Delete(Login_Log Id)
        {
            return -1;
        }

        int IBaseBLL<Login_Log>.UpdateById(Login_Log Id)
        {
             return -1;
        }
	}

	public partial class Login_UserBLL : BaseBLL<Login_User>, ILogin_UserBLL
	{
       private IDBSession Login_UserDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =Login_UserDAL.ILogin_UserDal;
       }
        int IBaseBLL<Login_User>.Create(Login_User model)
        {
             return -1;
        }

        int IBaseBLL<Login_User>.Delete(Login_User Id)
        {
            return -1;
        }

        int IBaseBLL<Login_User>.UpdateById(Login_User Id)
        {
             return -1;
        }
	}

	public partial class parameterBLL : BaseBLL<parameter>, IparameterBLL
	{
       private IDBSession parameterDAL = new DBSessionMSSQL();
       public override void SetDAL(){
           dal =parameterDAL.IparameterDal;
       }
        int IBaseBLL<parameter>.Create(parameter model)
        {
             return -1;
        }

        int IBaseBLL<parameter>.Delete(parameter Id)
        {
            return -1;
        }

        int IBaseBLL<parameter>.UpdateById(parameter Id)
        {
             return -1;
        }
	}
}
