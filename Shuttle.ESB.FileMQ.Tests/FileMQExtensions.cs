﻿using System;
using System.IO;

namespace Shuttle.ESB.FileMQ.Tests
{
	public static class FileMQExtensions
	{
		public static string FileUri()
		{
			return string.Format(@"filemq://{0}\test-queues\{{0}}", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..")));
		}
	}
}