//===============================================
//Copyrigth(c) Coalitionof Good-Hearted Engineers
//Free To Use Comfort And Peace
//===============================================

using System;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class HomeController : RESTFulController
	{
		[HttpGet]
		public ActionResult<string> Get() => Ok("hello mario");
	}
}

