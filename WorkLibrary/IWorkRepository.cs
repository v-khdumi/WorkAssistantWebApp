﻿using System.Collections.Generic;

namespace WorkLibrary
{
    public interface IWorkRepository
    {
        void AddDay(WorkDay newDay);
        void AddProduct(Product newProduct);
        void DeleteWorkDay(int id);
        void EditWordDay(WorkDay dayEdit);
        Product GetProductById(int id);
        Product GetProductByName(string productName);
        List<string> GetProductAll();
        WorkDay GetWorkDay(int id);
        List<WorkDay> GetWorkHistory();
    }
}