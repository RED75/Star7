<Query Kind="Program" />

void Main()
{
	System.IO.Ports.SerialPort p=new System.IO.Ports.SerialPort("Com2");
	p.ReadTimeout=500;
	p.ReadBufferSize=10;
	p.Open();
	while(true)
	{
		Thread.Sleep(500);
	//p.ReadExisting();
		p.DiscardInBuffer();
		while(p.BytesToRead==0)
		{}
		try
		{
			Console.Write(p.ReadLine());
		}
	  	catch (TimeoutException){ }
	}

	
}

// Define other methods and classes here
