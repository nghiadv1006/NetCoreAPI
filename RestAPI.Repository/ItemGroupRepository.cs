﻿using RestAPI.Model;
using RestAPI.Repositories.Helper;
using RestAPI.Repositories.Helper.interfaces;
using RestAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestAPI.Repositories
{
    public partial class ItemGroupRepository : IItemGroupRepository
    {
        private IDatabaseHelper _dbHelper;
        public ItemGroupRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<ItemGroupModel> GetData()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_item_group_get_data");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ItemGroupModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
