using CrossplatformTestToolKit.Modules;

// DllFileOperator Example
//DllFileOperator testOperator = new DllFileOperator();
//string pathA = @"C:\Users\clu\Desktop\Debug";
//string pathB = @"C:\Users\clu\Desktop\Release";
//testOperator.DllExistInFolderAButNotInFolderB(pathA, pathB);

ResxInfo test = new ResxInfo();
int result = test.GetDataCount("C:\\Project\\clu_CLU-LT_PCS.Modules_Dev_NewRelease\\PCS.Modules\\ShareLinkFamily\\Source\\EAF.Modules.ShareLinkFamily\\Properties\\Resources.zh-Hans.resx");
Console.WriteLine(result);