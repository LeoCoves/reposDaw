

public class avion             
{
    private float altura;
    private float velocidad; // Velocidad del avion
    private float combustible; 
	private int orientacion;


    public avion (float altura, float velocidad,  float combustible, int orientacion)	
	{
	this.altura = altura;
	this.velocidad = velocidad;
	this.combustible = combustible;
	this.orientacion = orientacion;	
	}
	
	public float Altura 	
	{		
		get { return altura;}
	}
	
	public int Orientacion
	{					
		get { return orientacion;}
	}

	public void Girar(int grados)
	{
		orientacion = (orientacion + grados) % 360;
        ConsumirCombustible(grados * 0.1);
	}

	public float Combustible
	{
		get {return combustible;}
	}

	//Metodos que sirve para ascender los metros indicados
	public void a(float M) //M son los metros
	{
		altura += M;
        ConsumirCombustible(M * 0.3);		
	}

	//Metodos que sirve para descender los metros indicados
	public void m(float metros)
	{
		altura -= metros;

		if (altura < 0)
		{
            altura = 0;
        }		
	}	

	public void ConsumirCombustible(float litros)
	{		
		combustible -= litros;

		if (combustible < 0)
		{
            combustible = 0;
        }		
	}
	
}
