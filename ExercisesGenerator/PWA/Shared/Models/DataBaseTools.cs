﻿using IndexedDB.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools;

namespace PWA.Shared.Models
{
    public class DataBaseTools
    {
        public static IIndexedDbFactory DbFactory { get; set; }

        public static List<WrongProblem> Wrongs = new List<WrongProblem>();

        public static List<Statist> Statists = new List<Statist>();

        public static async Task Refresh()
        {
            Console.WriteLine(DbFactory == null);
            using var db = await DbFactory.Create<MyDataBase>();
            Wrongs = db.WrongProblems.ToList();
            Statists = db.Statists.ToList();
        }

        public static async Task AddStatist(bool IsRight)
        {
            using var db = await DbFactory.Create<MyDataBase>();
            try
            {
                var TodayStatist = db.Statists.Single(x => x.Date == DateTime.Today);
                TodayStatist.TotalTimes++;
                if (!IsRight)
                {
                    TodayStatist.WrongTimes++;
                }
            }
            catch (Exception)
            {
                long Id;
                if (Statists == null || Statists.Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    Id = Statists.Last().Id + 1;
                }
                db.Statists.Add(new Statist
                {
                    Id = Id,
                    Date = DateTime.Today,
                    WrongTimes = IsRight ? 0 : 1,
                    TotalTimes = 1,
                });
            }
            await db.SaveChanges();
            await Refresh();
        }
        public static async Task AddRedoStatist(bool IsRight)
        {
            using var db = await DbFactory.Create<MyDataBase>();
            try
            {
                var TodayStatist = db.Statists.Single(x => x.Date == DateTime.Today);
                TodayStatist.RedoTotalTimes++;
                if (!IsRight)
                {
                    TodayStatist.RedoWrongTimes++;
                }
            }
            catch (Exception)
            {
                long Id;
                if (Statists == null || Statists.Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    Id = Statists.Last().Id + 1;
                }
                db.Statists.Add(new Statist
                {
                    Id = Id,
                    Date = DateTime.Today,
                    RedoWrongTimes = IsRight ? 0 : 1,
                    RedoTotalTimes = 1,
                });
            }
            await db.SaveChanges();
            await Refresh();
        }
        public static async Task AddErrorProblem(List<Unit> Problem, bool IsRight)
        {
            if (Problem == null)
            {
                return;
            }
            string ProblemHash = Expression.PostfixToTree(
                    Expression.InfixToPostfix(Problem)).ToString();
            using var db = await DbFactory.Create<MyDataBase>();

            try
            {
                var ProblemWithHash = db.WrongProblems.Single(x => x.ProblemHash == ProblemHash);
                ProblemWithHash.WrongTimes += (IsRight ? 0 : 1);
                ProblemWithHash.TotalTimes++;
            }
            catch (Exception)
            {
                if (!IsRight)
                {
                    long Id;
                    if (Wrongs == null || Wrongs.Count == 0)
                    {
                        Id = 1;
                    }
                    else
                    {
                        Id = Wrongs.Last().Id + 1;
                    }
                    db.WrongProblems.Add(new WrongProblem
                    {
                        Id = Id,
                        FirstDate = DateTime.Today,
                        Problem = Expression.ExpressionToString(Problem),
                        ProblemHTML = Expression.ExpressionToHTML(Problem),
                        ProblemHash = ProblemHash,
                        WrongTimes = 1,
                        TotalTimes = 1,
                    });
                }
            }
            await db.SaveChanges();
            await AddStatist(IsRight);
            await Refresh();
        }
        public static async Task RemoveErrorProblem(long Id)
        {
            using var db = await DbFactory.Create<MyDataBase>();
            try
            {
                var problem = db.WrongProblems.Single(x => x.Id == Id);
                db.WrongProblems.Remove(problem);
            }
            catch { }
            await db.SaveChanges();
            await Refresh();
        }
    }
}
