# game_killer
基于C#的一个窗体应用程序，可以定时关闭正在运行中的特定进程，并且通过多线程将窗体隐藏

修改form1.cs，在46行后添加额外的判断来增加进入判定的程序
在每天的0点30到六点之间，如果被判定的程序运行了，那么会直接kill掉这个进程

打包之后安装在电脑的startup文件夹就可以开机自启了。润物细无声。
