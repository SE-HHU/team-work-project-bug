﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tools;

namespace PWA.Shared.Models
{
    public class SettingModel
    {
        public class Model
        {
            public string value = "113";

            public Settings settings = JsonSerializer.Deserialize<Settings>
                                        (DefaultSettings.Default["113"]);
        }

        public static Model model = new Model();

        public static IJSRuntime JS;

        public static async Task Init()
        {
            string json = await JS.InvokeAsync<string>(
                "BlazorGetLocalStorage", "Settings");
            string value = await JS.InvokeAsync<string>(
                "BlazorGetLocalStorage", "SettingsNumber");
            Console.WriteLine(value);
            if (value != null && DefaultSettings.Default.ContainsKey(value))
            {
                model.value = value;
                try
                {
                    model.settings = JsonSerializer.Deserialize<Settings>(json);
                }
                catch (Exception)
                {
                    Console.WriteLine(DefaultSettings.Default[value]);
                    model.settings = JsonSerializer.Deserialize<Settings>
                        (DefaultSettings.Default[value]);
                    Console.WriteLine(JsonSerializer.Serialize<Settings>(model.settings));
                    await SaveSetting();
                }
            }
            else
            {
                model.value = "0";
                try
                {
                    model.settings = JsonSerializer.Deserialize<Settings>(json);
                }
                catch (Exception)
                {
                    model.value = "113";
                    model.settings = JsonSerializer.Deserialize<Settings>
                        (DefaultSettings.Default[model.value]);

                }
                await SaveSetting();
            }
            Expression.Settings = model.settings;
            Fraction.Settings = model.settings;
            Unit.Settings = model.settings;
        }
        public static async Task SaveSetting()
        {
            await JS.InvokeVoidAsync("BlazorSetLocalStorage", "SettingsNumber",
                model.value);
            await JS.InvokeVoidAsync("BlazorSetLocalStorage", "Settings",
                JsonSerializer.Serialize<Settings>(model.settings));
            Expression.Settings = model.settings;
            Fraction.Settings = model.settings;
            Unit.Settings = model.settings;
        }
    }
}
