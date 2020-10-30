using System;
using System.Collections.Generic;
using SQLite;

namespace ToDo.Core.Services.Interfaces
{
    public interface ITaskListTableManager
    {
        String DbFileName { get; }
        SQLiteConnection DbConnection { get; }

        void Update(IToDoTask tast);


        void Delete(IToDoTask tast);


        IEnumerable<IToDoTask> Load();


        void Save(IToDoTask tast);


        void RemoveTable();
    }
}
