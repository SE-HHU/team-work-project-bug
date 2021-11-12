﻿using PWA.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools;
using System.Text;
using Newtonsoft.Json;
using static Tools.TableData;

namespace PWA.Shared.Componets
{
    public partial class MyGenerator
    {
        [Parameter]
        public TableData Exercises { get; set; }
        
        [Parameter]
        public WebSettings LocalSettings { get; set; }

        public static bool ShowAnswer = true;

        public String DisplayStatue = "隐藏答案";

        public String ProgressStyle = "width:0%";

        protected async override Task<Task> OnInitializedAsync()
        {
            JavaScriptInvoke.JS = JS;
            await LoadLocalSettings();
            //加载设置, 防止在未设置的情况下生成习题出错
            LocalSettings.SetSettings();

            return Task.CompletedTask;
        }

        /// <summary>
        /// 生成题目及答案
        /// </summary>
        private void Generate()
        {
            List<Exercise> exercises = new List<Exercise>();
            //习题
            HashSet<String> expressions = new HashSet<string>();
            //用于去重的HashSet

            Expression.FillCanUseOperators();

            for (int i = 1; i <= Settings.ProblemsNumber; i++)
            {
                List<Unit> infix = Expression.GetRandomExpression();
                List<Unit> postfix = Expression.InfixToPostfix(infix);

                Unit answer;
                try
                {
                    answer = Expression.CalculatePostfix(postfix);
                }
                catch
                {
                    i--;
                    continue;
                }

                Node root = Expression.PostfixToTree(postfix);
                String tree = root.ToString();
                if (expressions.Add(tree))
                {
                    exercises.Add(new TableData.Exercise(i, infix, answer));
                }//没有重复
                else
                {
                    i--;
                }//存在重复
            }
            Exercises.Exercises = exercises;
            Exercises.Expressions = expressions;
        }

        /// <summary>
        /// 打印习题
        /// </summary>
        private async void Print()
        {
            await JavaScriptInvoke.Print("showdiv");
        }

        /// <summary>
        /// 隐藏或显示答案
        /// </summary>
        private async void ChangeAnswersDisplay()
        {
            ShowAnswer = !ShowAnswer;
            DisplayStatue = (ShowAnswer ? "隐藏答案" : "显示答案");
            await JavaScriptInvoke.ChangeAnswersDisplay(ShowAnswer);
        }

        /// <summary>
        /// 保存习题和答案到文件
        /// </summary>
        private async void SaveFiles()
        {
            StringBuilder Problems = new StringBuilder();
            StringBuilder Answers = new StringBuilder();
            foreach (Exercise exercise in Exercises.Exercises)
            {
                Problems.Append(exercise.Number);
                Problems.Append(". ");
                Problems.Append(Tools.Expression.ExpressionToString(exercise.Problem));
                Problems.Append('\n');
                Answers.Append(exercise.Number);
                Answers.Append(". ");
                Answers.Append(exercise.Answer.ToString());
                Answers.Append('\n');
            }
            await JavaScriptInvoke.SaveToFile(Problems.ToString(), "Exercises.txt");
            await JavaScriptInvoke.SaveToFile(Answers.ToString(), "Answers.txt");
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
    }
}
