using AntDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tools;
using PWA.Shared.Models;

namespace PWA.Pages
{
    public partial class Wrongs
    {
        List<WrongProblem> wrongs = DataBaseTools.Wrongs;

        protected override async Task OnInitializedAsync()
        {
            SettingModel.JS = JS;
            await SettingModel.Init();
            DataBaseTools.DbFactory = DbFactory;
            await DataBaseTools.Refresh();
            wrongs = DataBaseTools.Wrongs;
            CloneList();
            Shuffle(redoWrongs);
            await base.OnInitializedAsync();
        }
        public async void Delete(long Id)
        {
            await DataBaseTools.RemoveErrorProblem(Id);
            wrongs = DataBaseTools.Wrongs;
            CloneList();
            Shuffle(redoWrongs);
            StateHasChanged();
        }

        private int total => wrongs.Count();
        private int pageSize { get; set; } = 10;
        private int pageIndex { get; set; } = 1;
        private void HandlePageChange(PaginationEventArgs args)
        {
            if (pageIndex != args.Page)
            {
                pageIndex = args.Page;
            }

            if (pageSize != args.PageSize)
            {
                pageSize = args.PageSize;
            }
        }

        bool RedoMode = false;

        public class InputModel
        {
            public int Integer { get; set; } = 0;
            public int Numerator { get; set; } = 0;
            public int Denomination { get; set; } = 0;
        }
        private InputModel inputModel = new() { };

        private Tools.Settings settings = SettingModel.model.settings;

        List<WrongProblem> redoWrongs;

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

        int RedoCount = 0;

        string NextProblemTitle = "开始";
        public async void NextProblem()
        {
            if (RedoCount == redoWrongs.Count)
            {
                timer?.Dispose();
                await _message.Success("恭喜你又重做了一遍错题");
                RedoCount = 0;
                wrongs = DataBaseTools.Wrongs;
                CloneList();
                Shuffle(redoWrongs);
                NextProblemTitle = "开始";
                CheckStyle = @"oi oi-question-mark";
                Problem = new List<Unit>();
                IsFraction = false;
                IsInteger = false;
                StateHasChanged();
                return;
            }
            NextProblemTitle = "下一题";
            counter = settings.ThinkTime;
            timer?.Dispose();
            CheckStyle = @"oi oi-question-mark";
            Problem = Expression.StringToExpression(redoWrongs[RedoCount].Problem);
            Answer = Expression.CalculatePostfix(Expression.InfixToPostfix(Problem));
            RedoCount++;
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
            StartTimer();
        }

        public async void SkipProblem()
        {
            await DataBaseTools.AddErrorProblem(Problem, false);
            await DataBaseTools.AddRedoStatist(false);
            NextProblem();
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
                await DataBaseTools.AddRedoStatist(true);
                await Task.Delay(1000);
                NextProblem();
            }
            else
            {
                CheckStyle = @"oi oi-x";
                if (counter == 0)
                {
                    await DataBaseTools.AddErrorProblem(Problem, false);
                    await DataBaseTools.AddRedoStatist(false);
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

        private static Random rng = new Random();
        public static void Shuffle(List<WrongProblem> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                WrongProblem value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void CloneList()
        {
            redoWrongs = new List<WrongProblem>(wrongs.Count);
            for (int i = 0; i < wrongs.Count; i++)
            {
                redoWrongs.Add(wrongs[i]);
            }
        }
    }
}
