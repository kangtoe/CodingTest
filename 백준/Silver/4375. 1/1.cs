using System;
class HelloWorld {
	static void Main() {

		while(true)
		{
			string str = Console.ReadLine();
			if(str == null) return;
			int n = int.Parse(str);

			long l = 1;
			int count = 1;
			while(true)
			{
				if(l % n == 0)
				{
					Console.WriteLine(count);
					break;
				}

				l = (l % n) * 10 + 1;
				count++;
			}
		}
	}
}