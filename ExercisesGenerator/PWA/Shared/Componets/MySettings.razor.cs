using PWA.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Shared.Componets
{
    public partial class MySettings
    {
        [Parameter]
        public WebSettings LocalSettings { get; set; }

        protected async override Task<Task> OnInitializedAsync()
        {
            JavaScriptInvoke.JS = JS;
            await LoadLocalSettings();
            LocalSettings.SetSettings();
            return Task.CompletedTask;
        }

        public async Task HandleValidSubmit()
        {
            await JavaScriptInvoke.SaveLocalSettings(
                JsonConvert.SerializeObject(LocalSettings));
            LocalSettings.SetSettings();
        }

        /// <summary>
        /// 重置为默认设置
        /// </summary>
        private void SetDefault()
        {
            LocalSettings.SetDefault();
            SaveLocalSettings();
        }

        /// <summary>
        /// 加载 Local Storage
        /// </summary>
        /// <returns></returns>
        private async Task LoadLocalSettings()
        {
            string json = await JavaScriptInvoke.GetLocalSettings();
            WebSettings newSettings;
            try
            {
                newSettings = JsonConvert.DeserializeObject<WebSettings>(json);
                if (newSettings != null)
                {
                    LocalSettings.CopyFrom(newSettings);
                }
            }//应对首次使用时不存在 Local Storage 的情况
            catch
            {
                JavaScriptInvoke.ShowMessage("本地设置出错, 请检查设置");
            }
        }

        /// <summary>
        /// 保存设置到 Local Storage
        /// </summary>
        private async void SaveLocalSettings()
        {
            await JavaScriptInvoke.SaveLocalSettings(
                JsonConvert.SerializeObject(LocalSettings));
            LocalSettings.SetSettings();
        }
    }
}
