// 请按格式修改,修改错误将无法正常下载
// 如果您在本文件中添加了新的下载工具或者修正了错误，可以把新的副本通过邮件(AKenSoft-Service@Yahoo.com.cn)发送给我

function GetIncludeFilters(){
	return "*.m3u8;*.flv;decode.php;proxy.php";
}

function GetExcludeFilters(){
	return "";
}

function GetDownloadNames(){
	// 在下行修改下载工具名称
	return "用迅雷下载所选|用网际快车下载所选|用影音传送带下载所选|用网络蚂蚁下载所选";
}

function DownFile(DownloadName,Url,Info,Location,strCookie){
	//Url=下载地址	Info=信息		Location=引用地址			strCookie=Cookie
	var rMsg="";
	try{
		// 在下面可以添加修改下载工具
		if(DownloadName=="用迅雷下载所选"){//迅雷测试过，一切正常，并且支持COOKIE
			rMsg="迅雷";
			var AgentObj=new ActiveXObject('ThunderAgent.Agent');
			AgentObj.AddTask5(Url, '', '', Info, Location, -1, 0, -1, strCookie, '', '', 1, '', -1);
			AgentObj.CommitTasks2(1);
		}else if(DownloadName=="用网际快车下载所选"){//网际快车没有测试过，由于不支持COOKIE
			rMsg="网际快车";
			var AgentObj=new ActiveXObject('JetCar.Netscape');
			AgentObj.AddUrl(Url, Info, Location);
		}else if(DownloadName=="用影音传送带下载所选"){//影音传送带没有测试过，由于不支持COOKIE
			rMsg="影音传送带";
			var AgentObj=new ActiveXObject('NTIEHelper.NTIEAddUrl');
			AgentObj.AddUrl(Location, Url, Info);
		}else if(DownloadName=="用网络蚂蚁下载所选"){//网络蚂蚁没有测试过，由于不支持COOKIE
			rMsg="网络蚂蚁";
			var AgentObj=new ActiveXObject('NetAnts.API');
			AgentObj.AddUrl(Url, Info, Location);
		}else{
			return "没有找到下载工具!";
		}
	}catch(e){return "您还没有安装"+rMsg+"!";}
}

/*
	ThunderAgent.Agent			迅雷
	JetCar.Netscape			网际快车
	NTIEHelper.NTIEAddUrl		影音传送带
	NetAnts.API				网络蚂蚁
*/
