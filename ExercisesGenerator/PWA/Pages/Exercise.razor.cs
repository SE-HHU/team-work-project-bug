using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tools;
using PWA.Shared.Models;

namespace PWA.Pages
{
    public partial class Exercise
    {
        public class InputModel
        {
            public int Integer { get; set; } = 0;
            public int Numerator { get; set; } = 0;
            public int Denomination { get; set; } = 0;
        }
        private InputModel inputModel = new() { };

        private Tools.Settings settings = SettingModel.model.settings;

        List<Unit> Problem;

        Unit Answer;

        string CheckStyle = @"oi oi-question-mark";

        bool IsFraction = false;
        bool IsInteger = false;

        private static System.Timers.Timer timer;
        private int counter = 0;
        public void Dispose()
        {
            timer?.Dispose();
        }

        int ExerciseCount = 0;

        string NewProblemTitle = "开始";

        public async void NewProblem()
        {
            if (ExerciseCount == settings.ProblemsNumber)
            {
                counter = 0;
                timer?.Dispose();
                await _message.Success("恭喜你又完成了一组练习");
                ExerciseCount = 0;
                NewProblemTitle = "开始";
                CheckStyle = @"oi oi-question-mark";
                Problem = new List<Unit>();
                IsFraction = false;
                IsInteger = false;
                StateHasChanged();
                return;
            }
            counter = settings.ThinkTime;
            timer?.Dispose();
            NewProblemTitle = "下一题";
            CheckStyle = @"oi oi-question-mark";
            while (true)
            {
                try
                {
                    Problem = Expression.GetRandomExpression();
                    Answer = Expression.CalculatePostfix(Expression.InfixToPostfix(Problem));
                    if (Answer.InRange(settings.Operands.Last()))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            Answer.ChangeType();
            if (Answer.UnitType == UnitType.Integer)
            {
                IsInteger = true;
                IsFraction = false;
            }
            else
            {
                IsInteger = false;
                IsFraction = true;
            }
            ExerciseCount++;
            StartTimer();
        }

        public async void SkipProblem()
        {
            await DataBaseTools.AddErrorProblem(Problem, false);
            NewProblem();
        }

        protected override async Task OnInitializedAsync()
        {
            DataBaseTools.DbFactory = DbFactory;
            SettingModel.JS = JS;
            await SettingModel.Init();
        }

        public async void Check()
        {
            Unit unit = new Unit();
            if (IsInteger)
            {
                unit = new Unit(UnitType.Integer,
                    new Fraction(inputModel.Integer, 1),
                    null);
            }
            if (IsFraction)
            {
                unit = new Unit(UnitType.Fraction,
                    new Fraction(inputModel.Numerator, inputModel.Denomination),
                    null);
            }
            if (Answer.CompareTo(unit) == 0)
            {
                CheckStyle = @"oi oi-check";
                await DataBaseTools.AddErrorProblem(Problem, true);
                await Task.Delay(1000);
                NewProblem();
            }
            else
            {
                CheckStyle = @"oi oi-x";
                if (counter == 0)
                {
                    await DataBaseTools.AddErrorProblem(Problem, false);
                }
            }
            StateHasChanged();
        }

        public void StartTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += CountDownTimer;
            timer.Enabled = true;
        }

        public void CountDownTimer(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (counter > 0)
            {
                counter -= 1;
            }
            else
            {
                timer.Enabled = false;
                Check();
            }
            StateHasChanged();
        }
    }
}
