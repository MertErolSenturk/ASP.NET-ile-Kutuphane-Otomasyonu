﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ara : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		if (RadioButtonList1.SelectedIndex==0)
		{
			GridView1.DataSourceID = "AccessDataSource1";
		}
		else if (RadioButtonList1.SelectedIndex==1)
		{
			GridView1.DataSourceID = "AccessDataSource2";
		}
		else if (RadioButtonList1.SelectedIndex == 2)
		{
			GridView1.DataSourceID = "AccessDataSource3";
		}
		
	}
}