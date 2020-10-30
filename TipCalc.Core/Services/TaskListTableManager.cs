using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using ToDo.Core.Model;
using ToDo.Core.Services.Interfaces;


namespace ToDo.Core.Services
{
    public class TaskListTableManager : ITaskListTableManager
    {

        private String _dbFileName;
        private SQLiteConnection _dbConnection;


        public TaskListTableManager()
        {
            _dbFileName = "tasks.sqlite";
            _dbConnection = new SQLiteConnection(
                Path.Combine(System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal), _dbFileName));
            _dbConnection.CreateTable<ToDoTaskModel>();

        }


        public String DbFileName { get; }


        public SQLiteConnection DbConnection { get; }


        public void Update(IToDoTask task)
        {
            _dbConnection.Update(task);
        }


        public void Delete(IToDoTask task)
        {
            _dbConnection.Delete(task);
        }


        public IEnumerable<IToDoTask> Load()
        {
            return _dbConnection.Table<ToDoTaskModel>().ToList();
        }


        public void Save(IToDoTask task)
        {
            _dbConnection.Insert(task);
        }


        public void RemoveTable()
        {
            _dbConnection.DeleteAll<ToDoTaskModel>();
        }
    }
}
