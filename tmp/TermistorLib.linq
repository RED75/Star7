<Query Kind="Program" />

interface ITermistor
{
	//double Betta{get;set;}
	double getResistence(double tempreture);
	double getTempreture(double resistence);
};

interface IDigitalResistor
{
	byte getNearestCode(double resistence);
	double getResistence(byte code);
};
public class MurataNCP:ITermistor
{
	public MurataNCP()
	{
		Betta=4785;
	}
	public double Betta{get;set;}
	public double getResistence(double tempreture)
	{
		return 150000*Math.Exp(Betta*(1/(tempreture+273.15)-1/(25+273.15)));
	}
	public double getTempreture(double resistence)
	{
		return resistence;
	}
};

void Main()
{
MurataNCP termistor=new MurataNCP();
termistor.getResistence(85).Dump();
	
}



// Define other methods and classes here
