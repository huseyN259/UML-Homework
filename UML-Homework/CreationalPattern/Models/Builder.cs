// 'Product' class
class Laptop
{
	public string? ModelNumber { get; set; }
	public string? Display { get; set; }
	public string? RAM { get; set; }
	public string? GraphicsCard { get; set; }
	public string? TouchScreen { get; set; }
				 
	public void PrintDetails()
	{
		Console.WriteLine("----------- Laptop Details ----------------");
		Console.WriteLine("Model Number: {0}", ModelNumber);
		Console.WriteLine("Display: {0}", Display);
		Console.WriteLine("RAM: {0}", RAM);
		Console.WriteLine("Graphics Card: {0}", GraphicsCard);
		Console.WriteLine("Touch Screen: {0}", TouchScreen);
	}
}


// 'Builder' interface
interface ILaptopBuilder
{
	void addModelNumber();
	void addDisplay();
	void addRAM();
	void addGraphicsCard();
	void addTouchScreen();
	Laptop getLaptop();
}


// 'ConcreteBuilder' class - implements 'Builder' interface
class GamingLaptopBuilder : ILaptopBuilder
{
	Laptop laptop = new Laptop();

	public void addModelNumber()
	{
		laptop.ModelNumber = "Gaming1001";
	}

	public void addDisplay()
	{
		laptop.Display = "Full HD display";
	}

	public void addRAM()
	{
		laptop.RAM = "16 GB";
	}

	public void addGraphicsCard()
	{
		laptop.GraphicsCard = "Nvidia GeForce";
	}

	public void addTouchScreen()
	{
		laptop.TouchScreen = "Yes";
	}

	public Laptop getLaptop()
	{
		return laptop;
	}
}


// 'ConcreteBuilder' class - implements 'Builder' interface
class NormalLaptopBuilder : ILaptopBuilder
{
	Laptop laptop = new Laptop();

	public void addModelNumber()
	{
		laptop.ModelNumber = "Normal1001";
	}

	public void addDisplay()
	{
		laptop.Display = "SD Display";
	}

	public void addRAM()
	{
		laptop.RAM = "2GB";
	}

	public void addGraphicsCard()
	{
		laptop.GraphicsCard = "No graphics card";
	}

	public void addTouchScreen()
	{
		laptop.TouchScreen = "NO";
	}

	public Laptop getLaptop()
	{
		return laptop;
	}
}


// 'Director' class
class LaptopManufacturer
{
	public void BuildLaptop(ILaptopBuilder laptopBuilder)
	{
		laptopBuilder.addModelNumber();
		laptopBuilder.addDisplay();
		laptopBuilder.addRAM();
		laptopBuilder.addGraphicsCard();
		laptopBuilder.addTouchScreen();
	}
}


/*class Program
{
	static void Main()
	{
		// create object of manufacturer
		LaptopManufacturer laptopManufacturer = new LaptopManufacturer();

		// build Gaming Laptop
		ILaptopBuilder gamingLaptopBuilder = new GamingLaptopBuilder();
		laptopManufacturer.BuildLaptop(gamingLaptopBuilder);
		Laptop GamingLaptop = gamingLaptopBuilder.getLaptop();
		// print details
		Console.WriteLine("Gaming Laptop Object:");
		GamingLaptop.PrintDetails();

		// build normal laptop
		ILaptopBuilder normalLaptopBuilder = new NormalLaptopBuilder();
		laptopManufacturer.BuildLaptop(normalLaptopBuilder);
		Laptop NormalLaptop = normalLaptopBuilder.getLaptop();
		// print details
		Console.WriteLine("\n\nNormal Laptop Object:");
		NormalLaptop.PrintDetails();

		Console.ReadLine();
	}
}*/