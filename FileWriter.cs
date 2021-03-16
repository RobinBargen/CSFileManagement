namespace FileWriter {
	public class FileWriter
	{
		private readonly string filepath;
		public FileWriter(string filepath)
		{
			this.filepath = filepath;
		}

		public void WriteToFile(string textToWrite)
		{
			try
			{
				System.IO.FileStream fileStream = new System.IO.FileStream(this.filepath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
				var bytes = System.Text.Encoding.UTF8.GetBytes(textToWrite);
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Flush();
				fileStream.Close();
			}
			catch
			{
				throw;
			}

		}

		public void WriteToFile(string[] textArray)
		{
			try
			{
				System.IO.FileStream fileStream = new System.IO.FileStream(this.filepath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
				foreach (var textLine in textArray)
				{
					var bytes = System.Text.Encoding.UTF8.GetBytes(textLine);
					fileStream.Write(bytes, 0, bytes.Length);
				}
				fileStream.Flush();
				fileStream.Close();
			}
			catch
			{
				throw;
			}
		}

		public void WriteToFile(System.Collections.Generic.List<string> textList)
		{
			try
			{
				System.IO.FileStream fileStream = new System.IO.FileStream(this.filepath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
				foreach (var textLine in textList)
				{
					var bytes = System.Text.Encoding.UTF8.GetBytes(textLine);
					fileStream.Write(bytes, 0, bytes.Length);
				}
				fileStream.Flush();
				fileStream.Close();
			}
			catch
			{
				throw;
			}
		}

		public void AppendToFile(string textToWrite)
		{
			try
			{
				System.IO.FileStream fileStream = new System.IO.FileStream(this.filepath, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
				var bytes = System.Text.Encoding.UTF8.GetBytes(textToWrite);
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Flush();
				fileStream.Close();
			}
			catch
			{
				throw;
			}

		}

		public void AppendToFile(string[] textArray)
		{
			try
			{
				System.IO.FileStream fileStream = new System.IO.FileStream(this.filepath, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
				foreach (var textLine in textArray)
				{
					var bytes = System.Text.Encoding.UTF8.GetBytes(textLine);
					fileStream.Write(bytes, 0, bytes.Length);
				}
				fileStream.Flush();
				fileStream.Close();
			}
			catch
			{
				throw;
			}
		}

		public void AppendToFile(System.Collections.Generic.List<string> textList)
		{
			try
			{
				System.IO.FileStream fileStream = new System.IO.FileStream(this.filepath, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
				foreach (var textLine in textList)
				{
					var bytes = System.Text.Encoding.UTF8.GetBytes(textLine);
					fileStream.Write(bytes, 0, bytes.Length);
				}
				fileStream.Flush();
				fileStream.Close();
			}
			catch
			{
				throw;
			}
		}
	}
}
