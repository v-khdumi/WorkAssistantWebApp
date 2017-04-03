﻿using System.Collections.Generic;

namespace WorkLibrary
{
    public interface IWorkRepository
    {
        void AddDay(WorkDay newDay);
        void AddProduct(Product newProduct);
        void DeleteWorkDay(int id);
        void EditWorkDay(WorkDay dayEdit);
        Product GetProductById(int id);
        Product GetProductByName(string productName);
        List<Product> GetProductAll();
        WorkDay GetWorkDay(int id);
        List<WorkDay> GetWorkHistory();
        StockItem GetStockItem(int id);
        void CreateStockItem(StockItem newItem);

    }
}