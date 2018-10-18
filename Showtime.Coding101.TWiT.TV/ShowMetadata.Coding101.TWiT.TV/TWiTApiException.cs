namespace StudioMetadata.Coding101.TWiT.TV
{
	using System;
	public class TWiTApiException : Exception
	{
		public TWiTApiException()
		{
		}

		public TWiTApiException(string message) : base(message)
		{
		}

		public TWiTApiException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}