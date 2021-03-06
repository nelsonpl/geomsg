﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Npx.Geomsg.Core.Models
{
	public class User
	{
		public int ID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public DateTime DateCreate { get; set; }

		internal List<Message> Messages { get ; set; }
		internal List<UserSession> UserSessions { get ; set; }
	}
}