using PWA.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools;

namespace PWA.Pages
{
    public partial class Use
    {
        private static WebSettings setting = new WebSettings();

        public static TableData tableData = new TableData();

        CheckerData Exercises = new CheckerData();

        string SettingTitle = "<span class=\"oi oi-chevron-right\"></span> 设置";

        string GeneratorTitle  = "<span class=\"oi oi-chevron-right\"></span> 生成";

        string CheckerTitle = "<span class=\"oi oi-chevron-right\"></span> 批改";

        bool ShowSetting = false;
        bool ShowGenerator = false;
        bool ShowChecker = false;

        public void ChangeSettingDisplay()
        {
            SettingTitle = (ShowSetting ? "<span class=\"oi oi-chevron-right\"></span> 设置"
                : "<span class=\"oi oi-chevron-bottom\"></span> 设置");
            ShowSetting = !ShowSetting;
        }
        public void ChangeGeneratorDisplay()
        {
            GeneratorTitle = (ShowGenerator ? "<span class=\"oi oi-chevron-right\"></span> 生成"
                : "<span class=\"oi oi-chevron-bottom\"></span> 生成");
            ShowGenerator = !ShowGenerator;
        }
        public void ChangeCheckerDisplay()
        {
            CheckerTitle = (ShowChecker ? "<span class=\"oi oi-chevron-right\"></span> 批改"
                : "<span class=\"oi oi-chevron-bottom\"></span> 批改");
            ShowChecker = !ShowChecker;
        }
    }
}
