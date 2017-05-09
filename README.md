這是一個三層式架構+EF+T4模板
可以依照需求來做彈性化的變化

說明:

	UI層:此層可以是Console or .Net webForm or .Net Mvc...	
	BLL層:
		IBLL:宣告BLL層有哪些方法可以實現,給UI來呼叫
			(1)IBaseBLL:簡單CURD方法給子類來實現
			(2)IBLLFactory:一個介面給Repository來實現工廠，降低耦合
			(3)IBLLSession:宣告屬性讓BLL子類實現，可用partial來獨立宣告行為
		BLL:實現IBLL執行業務邏輯，可以有多個BLL
			(1)BaseBLL:繼承IBaseBLL並實現CURD方法,並提供SetDal給繼承他的子類實現要用的Dal
			(2)BLL:用t4模板繼承相對應名稱的介面並重載BaseBLL.SetDal方法，可用partial讓類別易擴充		
		BLLRepository:創建BLL給外部來使用(類似實體工廠)
			(1)BLLFactory:繼承IBLLFactory並實現裡面GetBLLSession方法,用抽象工廠方便日後更換邏輯模塊
			(2)BLLService_A:繼承IBLLSession在此創建BLL類別
			
	DAL層:
		IDAL:宣告DAL層有哪些方法可以實現,給BLL來呼叫
			(1)IBaseIDAL:簡單CURD方法給子類來實現
			(2)IFactoryDal:一個介面給Repository來實現工廠，降低耦合
			(3)IDALProvider:宣告屬性讓DAL子類實現，可用partial來獨立宣告行為
		DAL:實現IDAL執行業務邏輯，可以有多個DAL
			(1)BaseDAL:繼承IBaseIDAL並實現CURD方法
			(2)DAL:用t4模板繼承相對應名稱的介面
		DALRepository:創建DAL給外部來使用(類似實體工廠)
			(1)FactoryDal:繼承IFactoryDal並實現裡面GetDbSession方法,用抽象工廠方便日後更換讀取資料模塊
			
	Infrastructure:
		Model:裡面放置模組
		DI:製作容器
		Common:在裡面宣告公用方法
    Test:
    	可在裡面寫單元測試或整合性測試
        
------
注意:

1. 要執行哪個DAL或BLL可以直接改WebConfig的AppSetting
  ```xml
   <appSettings>
    <add key="DalFactory" value="FakeDataProvider"/> <!--執行DAL.FakeDataProvider-->
    <add key="DalAssemblyName" value="DALRepository"/>
    <add key="BllFactory" value="BLLService_A"/>     <!--執行BLL.BLLService_A-->
    <add key="BllAssemblyName" value="ServiceRepository"/>
  </appSettings>
  ```
2.使用前EF連接字串記得修改 connectionStrings

------
架構如圖:
			
![image](https://github.com/isdaniel/3-Tier-Architecture-T4-EF/blob/master/ArchitecturePic.png?raw=true)