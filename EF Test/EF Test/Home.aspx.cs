using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Entities db = new Entities();
        K_U_Show show = new K_U_Show() { ID = "10025", NodeCode= "101035002001",SiteID=1 };
        db.K_U_Show.Add(show);
        db.SaveChanges();
    }

    protected void BtnDel_Click(object sender, EventArgs e)
    {
        Entities db = new Entities();
        var model=db.K_U_Show.Where(c => c.ID == "100000000135647").FirstOrDefault();
        db.K_U_Show.Remove(model);
        db.SaveChanges();
    }

    protected void BtnDel2_Click(object sender, EventArgs e)
    {
        Entities db = new Entities();
        K_U_Show model = new K_U_Show() { ID= "100000000819644" };
        db.K_U_Show.Attach(model);
        db.K_U_Show.Remove(model);
        db.SaveChanges();
    }

    protected void BtnDel3_Click(object sender, EventArgs e)
    {
        Entities db = new Entities();
        K_U_Show model = new K_U_Show() { ID = "10025" };
        var entry=db.Entry(model);
        entry.State = System.Data.Entity.EntityState.Deleted;
        db.SaveChanges();
    }

    protected void Btnedit1_Click(object sender, EventArgs e)
    {
        Entities db = new Entities();
        var  model=db.K_U_Jobs.Where(c => c.WorkAddr == "广州").FirstOrDefault();
        model.Title = "EF修改Demo";
        model.Salary = "12500";
        model.WorkAddr = "America";
        db.SaveChanges();
    }
    protected void Btnedit2_Click(object sender, EventArgs e)
    {
        Entities db = new Entities();
        K_U_Jobs model = new K_U_Jobs();
        model.ID = "100000000811598";
        model.WorkAddr = "深圳";
        model.Title = "ADO.NET";
        model.Salary = "12589.02";
       var entry= db.Entry(model);
        entry.State = System.Data.Entity.EntityState.Unchanged;
        entry.Property(c => c.Title).IsModified = true;
        entry.Property("Salary").IsModified = true;
        entry.Property(c => c.ID).IsModified = true;

        db.Configuration.ValidateOnSaveEnabled = false;
        db.SaveChanges();
        
    }
}