﻿using RestAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Repositories.Interfaces
{
    public partial interface IItemRepository
    {
        bool Create(ItemModel model);
        ItemModel GetDatabyID(string id);
        List<ItemModel> GetDataAll();
        List<ItemModel> Search(int pageIndex, int pageSize, out long total, string item_group_id);
    }
}
