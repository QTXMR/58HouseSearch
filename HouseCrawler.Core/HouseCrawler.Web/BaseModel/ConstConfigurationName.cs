﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseCrawler.Web
{
    public static class ConstConfigurationName
    {
        public static string Douban = "douban";

        public static string PinPaiGongYu = "pinpaigongyu";

        public static string HuZhuZuFang = "huzhuzufang";

        public static string CityHouseInfo = "cityhouse";

        public static string CCBHouse = "ccbhouse";

        public static string Zuber = "zuber";

        public static string MoguHouse = "mogu";
        public static string HKSpacious = "hkspacious";

        public static string BaiXing = "baixing";

        public static string HouseMap = "housemap";

        public static string ConvertToDisPlayName(string configurationName)
        {
            var dicNameToDisplayName = new Dictionary<string, string>()
            {
                { Douban,"豆瓣小組"},
                { PinPaiGongYu,"品牌公寓"},
                { HuZhuZuFang,"互助租房"},
                { Zuber,"Zuber"},
                { MoguHouse,"蘑菇租房"},
                { CCBHouse,"CCB建融"},
                { BaiXing,"百姓租房"},
                { CityHouseInfo,"城市租房信息"},
            };
            if (string.IsNullOrEmpty(configurationName))
            {
                return "";
            }
            return (dicNameToDisplayName.ContainsKey(configurationName)) ? dicNameToDisplayName[configurationName] : "";
        }


        public static Dictionary<String, String> HouseTableNameDic = new Dictionary<string, string>() {
            { ConstConfigurationName.Douban, "DoubanHouseInfos"},
            { ConstConfigurationName.HuZhuZuFang, "MutualHouseInfos"},
            { ConstConfigurationName.PinPaiGongYu, "ApartmentHouseInfos"},
            { ConstConfigurationName.CCBHouse, "CCBHouseInfos"},
            { ConstConfigurationName.Zuber, "ZuberHouseInfos"},
            { ConstConfigurationName.MoguHouse, "MoguHouseInfos"},
            { ConstConfigurationName.HKSpacious, "HKHouseInfos"},
            { ConstConfigurationName.BaiXing, "BaiXingHouseInfos"},
            { ConstConfigurationName.HouseMap,"UserHouses"}
        };



        public static string GetTableName(string source)
        {
            if (ConstConfigurationName.HouseTableNameDic.ContainsKey(source))
            {
                return ConstConfigurationName.HouseTableNameDic[source];
            }

            return "HouseInfos";
        }


    }





}