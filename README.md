# DumpHash-Helper
使用Csharp实现自动修改注册表键并强制锁屏，使目标机器可被抓取明文密码。

编译环境：
- MacOS 10.14 
- Rider 2020
- .Net Framework 4.8
- SDK 5.0.100

测试环境：
- Windows 7 Pro x64

**需要本地管理员权限**

练习作品，代码略丑。

# 演示
目标机不可抓取明文：
![20201203224538ggK8Ob](https://adan0s-1256533472.cos.ap-nanjing.myqcloud.com/uPic/20201203224538ggK8Ob.png)

注册表项：
![20201203224623yaKYBZ](https://adan0s-1256533472.cos.ap-nanjing.myqcloud.com/uPic/20201203224623yaKYBZ.png)

管理员权限运行软件，自动锁定屏幕：
![20201203224743hw4pDM](https://adan0s-1256533472.cos.ap-nanjing.myqcloud.com/uPic/20201203224743hw4pDM.png)

可以抓取明文，注册表键值已改变：
![20201203224925c4UWpr](https://adan0s-1256533472.cos.ap-nanjing.myqcloud.com/uPic/20201203224925c4UWpr.png)