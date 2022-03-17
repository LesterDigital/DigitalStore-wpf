﻿using StockManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Services
{
    public interface IStockManager
    {
        public string? Filepath { get; init; }

        public void Add(Product product);
        public Product[]? Get();
    }
}
