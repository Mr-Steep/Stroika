using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Stroika.Menu;


namespace Stroika
{
    class Program
    {
        private static void Main(string[] args)
        {

            //var mainMenu = new MenuItem("Main Menu");            
            //var rabotniki = new MenuItem("Работники");

            var menuFile =
                ConfigurationManager.AppSettings["MenuFiles"]; 
            var connectionString =
                ConfigurationManager.ConnectionStrings["MenuFiles"];


            using (var context
                = new BuildingContext(connectionString)
                { }
            //rabotniki.Add(
            //    new MenuItem("Принять"),
            //    new MenuItem("Уволить"),
            //    new MenuItem("Информация")
            //);

            //mainMenu.Add(rabotniki,
            //    new MenuItem("Отчеты")
            //);

            //var menu = new Menu.Menu(mainMenu);

            //надо меню сохранить в файл
            //потом прочитать из файла            
            //menu.OnExit += Exit;

            //while (true)
            //{
            //    Console.Clear();
            //    Console.Write(menu);
            //    var key = WaitForUserInput();
            //    menu.ChangeState(key);
            //}
        }
        
        private static string WaitForUserInput()
        {
            return Console.ReadLine();
        }
        private static void Exit(object sender, EventArgs args)
        {
            Environment.Exit(0);
        }                
    }
}