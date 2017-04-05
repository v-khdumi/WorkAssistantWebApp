﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLibrary
{
    public class WorkRepoDb : IWorkRepository
    {
        public WorkRepoDb()
        {

        }
        public void AddDay(WorkDay newDay)
        {
            using (var db = new WorkDbContext())
            {
                db.WorkDayTable.Add(newDay);
                db.SaveChanges();
            }
        }

        public void AddProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public void DeleteWorkDay(int id)
        {
            throw new NotImplementedException();
        }

        public void EditWorkDay(WorkDay dayEdit)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductAll()
        {
            using (var db = new WorkDbContext())
            {
                var products = from product in db.ProductTabel
                               select product;

                return products.ToList();
            }
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string productName)
        {
            throw new NotImplementedException();
        }

        public WorkDay GetWorkDay(int id)
        {
            using (var db = new WorkDbContext())
            {
                var workday = db.WorkDayTable.Find(id);
                db.Entry(workday).Collection(day => day.WorkLoad).Load();
                return workday;
            }
        }

        public List<WorkDay> GetWorkHistory()
        {
            using (var db = new WorkDbContext())
            {
                var days = from day in db.WorkDayTable
                           select day;

                return days.ToList();
            }
        }

        public StockTask GetStockTask(int id)
        {
            using (var db = new WorkDbContext())
            {
                return db.StockItemTable.Find(id);
            }
        }

        public void CreateStockTask(StockTask newItem)
        {
            using (var db = new WorkDbContext())
            {
                db.StockItemTable.Add(newItem);
                db.SaveChanges();
            }
        }

        public void UpdateStockTask(StockTask updatedTask)
        {
            using(var db = new WorkDbContext())
            {
                db.StockItemTable.Attach(updatedTask);
                var entry = db.Entry(updatedTask);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteStockTask(int id)
        {
            using(var db = new WorkDbContext())
            {
                var task = db.StockItemTable.Find(id);
                db.StockItemTable.Remove(task);
                db.SaveChanges();
            }
        }
    }
}
