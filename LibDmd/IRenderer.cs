﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDmd
{
	public interface IRenderer : IDisposable
	{
		/// <summary>
		/// Subscribes to the source and hence starts receiving and processing data
		/// as soon as the source produces them.
		/// </summary>
		/// <param name="onCompleted">When the source stopped producing frames.</param>
		/// <param name="onError">When a known error occurs.</param>
		/// <returns>An IDisposable that stops rendering when disposed.</returns>
		IDisposable StartRendering(Action onCompleted, Action<Exception> onError = null);
	}
}
