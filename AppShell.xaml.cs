namespace Alexandra_Iacomi_Lab7;
using System;
using Alexandra_Iacomi_Lab7.Data;
using System.IO;
public partial class AppShell : Shell
{
    static ShoppingListDatabase database;
    public static ShoppingListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }
    public AppShell()
	{
		InitializeComponent();
	}
}
