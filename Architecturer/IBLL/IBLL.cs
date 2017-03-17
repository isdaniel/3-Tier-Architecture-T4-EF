 
using Model;
    /*
        因為是partial類 可以在外面擴展另外的介面行為
    */
namespace IBLL
{

	
	public partial interface IActive_RecordBLL :IBaseBLL<Active_Record>
    {
      
    }
	
	public partial interface IActive_Record_ItemsBLL :IBaseBLL<Active_Record_Items>
    {
      
    }
	
	public partial interface IActive_RuleBLL :IBaseBLL<Active_Rule>
    {
      
    }
	
	public partial interface IActive_TypeBLL :IBaseBLL<Active_Type>
    {
      
    }
	
	public partial interface ILibrary_BookBLL :IBaseBLL<Library_Book>
    {
      
    }
	
	public partial interface ILibrary_BookImgaeBLL :IBaseBLL<Library_BookImgae>
    {
      
    }
	
	public partial interface ILogin_LogBLL :IBaseBLL<Login_Log>
    {
      
    }
	
	public partial interface ILogin_UserBLL :IBaseBLL<Login_User>
    {
      
    }
	
	public partial interface IparameterBLL :IBaseBLL<parameter>
    {
      
    }
	
}