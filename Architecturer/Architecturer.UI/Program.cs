using System;
using ServiceRepository;
using Model;
using IBLL;
namespace Architecturer.UI
{    
    class Program
    {
        static void Main(string[] args)
        {
            //在ui表現可以呼叫IBLL的Interface來呼叫 要執行哪一段BLL邏輯
            IActive_RecordBLL container = new BLLService_A().IActive_RecordBLL;
            foreach (var item in container.GetList())
            {
                Console.WriteLine(item.Record_Date);
            }
            Console.ReadKey();
        }
    }
}
