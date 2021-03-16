namespace FileReader {
	public class FileReader
	{
		private readonly string filepath;

		public FileReader(string filepath)
		{
			this.filepath = filepath;
		}

		public string ReadFile()
		{
			try
			{
				System.IO.StreamReader streamReader = new System.IO.StreamReader(this.filepath);
				string fileContent = streamReader.ReadToEnd();
				streamReader.Close();
				return fileContent;
			}
			catch
			{
				throw;
			}
		}
	}
}
