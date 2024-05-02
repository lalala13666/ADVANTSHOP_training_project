using System;
using System.Data.Entity;

namespace WebApplication2.Models;

public class CategoryBdInitializer : DropCreateDatabaseAlways<InfoContext>
{
    protected override void Seed(InfoContext db)
    {
        db.Categories.Add(new Category
        { ID = "FD93DC11-DBC8-43CF-BE10-EC09E7E29C0E", Name = "Одежда", Sort = 1, Parent = "0", dateCreate = DateTime.Today,
            dateChange = DateTime.Today, LinkToImage = null }
        );
 
        base.Seed(db);
    }
}