using Microsoft.JSInterop;
using Newtonsoft.Json;
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

        protected async override Task<Task> OnInitializedAsync()
        {
            bool result = await LoadLocalSettings();
            if (result)
            {
                ChangeGeneratorDisplay();
            }//有本地配置
            else
            {
                ShowMessage("未检测到本地设置, 已为您加载并保存默认配置");
                ChangeSettingDisplay();
                SaveLocalSettings();
            }//没有本地配置

            return Task.CompletedTask;
        }

        /// <summary>
        /// 弹窗显示消息
        /// </summary>
        /// <param name="text">需要显示的消息</param>
        private async void ShowMessage(String text)
        {
            await JS.InvokeVoidAsync("ShowMessage", text);
        }

        /// <summary>
        /// 加载 Local Storage
        /// </summary>
        /// <returns></returns>
        private async Task<bool> LoadLocalSettings()
        {
            String json = await JS.InvokeAsync<String>("BlazorGetLocalStorage", "LocalSettings");
            WebSettings newSettings;
            try
            {
                newSettings = JsonConvert.DeserializeObject<WebSettings>(json);
                if (newSettings != null)
                {
                    return true;
                }
            }//应对首次使用时不存在 Local Storage 的情况
            catch
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// 保存设置到 Local Storage
        /// </summary>
        private async void SaveLocalSettings()
        {
            await JS.InvokeVoidAsync("BlazorSetLocalStorage", "LocalSettings",
                JsonConvert.SerializeObject(setting));
            setting.SetSettings();
        }
    }
}
