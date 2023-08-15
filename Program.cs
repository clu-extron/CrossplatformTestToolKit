using CrossplatformTestToolKit.Modules;

DllFileOperator testOperator = new DllFileOperator();
string pathA = @"C:\Users\clu\Desktop\Extron Room Agent - Beta";
string pathB = @"C:\Users\clu\Desktop\Extron Room Agent";
testOperator.DllExistInFolderAButNotInFolderB(pathA, pathB);
