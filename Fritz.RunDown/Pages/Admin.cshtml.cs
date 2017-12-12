﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fritz.RunDown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fritz.RunDown.Pages
{
	public class AdminModel : PageModel
	{

		public AdminModel(Models.RundownRepository repo)
		{
			this.Repository = repo;
		}

		public RundownRepository Repository { get; private set; }

		public void OnGet()
		{

		}
	}
}