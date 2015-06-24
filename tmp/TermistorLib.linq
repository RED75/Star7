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
		RefValue=150000;
		RefTempreture=25;
	}
	public double Betta{get;set;}
	public double RefValue{get;set;}
	public double RefTempreture{get;set;}
	public double getResistence(double tempreture)
	{
		return RefValue*Math.Exp(Betta*(1/(tempreture+273.15)-1/(RefTempreture+273.15)));
	}
	public double getTempreture(double resistence)
	{
		var temp = Math.Log(resistence/RefValue)/Betta+1/(RefTempreture+273.15);
		return 1/temp-273.15; 
	}
};

void Main()
{
MurataNCP termistor=new MurataNCP();
termistor.getResistence(60).Dump();
termistor.getTempreture(termistor.getResistence(100)).Dump();
	
}



// Define other methods and classes here
