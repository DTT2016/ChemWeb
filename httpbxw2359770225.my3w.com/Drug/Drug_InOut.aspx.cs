﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Drug_Drug_InOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["MyCoo"] != null)
        {
          
          
        }

    }
    public string GetSession(string Session_Name)
    {
        if (Session[Session_Name] != null)
        {
            return Session.Contents[Session_Name].ToString();
        }
        else
            return "";
    }
}