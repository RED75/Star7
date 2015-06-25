using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star7ClassLibrary.Measurement
{
    internal class DigitalResistorController
    {
        
    };
    
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

public class DigitalResistorDS3902:IDigitalResistor
{
    public int PositionsCount { get; set; }
    public double MaxResistance { get; set; }
    public DigitalResistorDS3902()
    {
        PositionsCount = 256;
        MaxResistance = 50000;
    }
    public byte getNearestCode(double resistence)
    {
        var position = Math.Round(resistence*MaxResistance/PositionsCount);
        if ((position>=0)&&(position<=255))
        {
            return (byte)position;
        }
        else 
        {
            throw new Exception(" Превышение максимального положения DS3902" + this.ToString());
        }
    }
    public double getResistence(byte code)
    {
        return MaxResistance/PositionsCount*code;
    }
    
	
}




// Define other methods and classes here

   


}
