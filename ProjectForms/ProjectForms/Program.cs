using FinalProject;
using FinalProject.Entities;
using FinalProject.Repositories;
using FinalProject.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;

namespace ProjectForms {
	internal class FormProgram {

		public static IAuthService authservice;
		public static IPurchaseService purchaseservice;

		[STAThread]
		static void Main(string[] args) {

			ApplicationConfiguration.Initialize();

			Application.Run(new MainForm(false, false));
		}
	}
}