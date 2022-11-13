public abstract class Component
{
	public abstract void Operation();
}


public class ConcreteComponent : Component
{
	public override void Operation()
	{
		Console.WriteLine("ConcreteComponent.Operation()");
	}
}


public abstract class Decorator : Component
{
	protected Component? component;
	
	public void SetComponent(Component component)
	{
		this.component = component;
	}
	
	public override void Operation()
	{
		if (component != null)
			component.Operation();
	}
}


public class ConcreteDecoratorA : Decorator
{
	public override void Operation()
	{
		base.Operation();
		Console.WriteLine("ConcreteDecoratorA.Operation()");
	}
}


public class ConcreteDecoratorB : Decorator
{
	public override void Operation()
	{
		base.Operation();
		AddedBehavior();
		Console.WriteLine("ConcreteDecoratorB.Operation()");
	}
	void AddedBehavior()
	{

	}
}

/*public class Program
{
	public static void Main()
	{
		// Create ConcreteComponent and two Decorators
		ConcreteComponent c = new ConcreteComponent();
		ConcreteDecoratorA d1 = new ConcreteDecoratorA();
		ConcreteDecoratorB d2 = new ConcreteDecoratorB();

		// Link decorators
		d1.SetComponent(c);
		d2.SetComponent(d1);
		d2.Operation();
	}
}*/




/*public abstract class LibraryItem
{
	private int numCopies;
	public int NumCopies
	{
		get { return numCopies; }
		set { numCopies = value; }
	}

	public abstract void Display();
}


public class Book : LibraryItem
{
	private string author;
	private string title;

	public Book(string author, string title, int numCopies)
	{
		this.author = author;
		this.title = title;
		this.NumCopies = numCopies;
	}

	public override void Display()
	{
		Console.WriteLine("\nBook ------ ");
		Console.WriteLine(" Author: {0}", author);
		Console.WriteLine(" Title: {0}", title);
		Console.WriteLine(" # Copies: {0}", NumCopies);
	}
}


public class Video : LibraryItem
{
	private string director;
	private string title;
	private int playTime;

	public Video(string director, string title, int numCopies, int playTime)
	{
		this.director = director;
		this.title = title;
		this.NumCopies = numCopies;
		this.playTime = playTime;
	}

	public override void Display()
	{
		Console.WriteLine("\nVideo ----- ");
		Console.WriteLine(" Director: {0}", director);
		Console.WriteLine(" Title: {0}", title);
		Console.WriteLine(" # Copies: {0}", NumCopies);
		Console.WriteLine(" Playtime: {0}\n", playTime);
	}
}


public abstract class Decorator : LibraryItem
{
	protected LibraryItem libraryItem;
	
	public Decorator(LibraryItem libraryItem)
	{
		this.libraryItem = libraryItem;
	}
	
	public override void Display()
	{
		libraryItem.Display();
	}
}


public class Borrowable : Decorator
{
	protected readonly List<string> borrowers = new List<string>();

	public Borrowable(LibraryItem libraryItem)
		: base(libraryItem) { }

	public void BorrowItem(string name)
	{
		borrowers.Add(name);
		libraryItem.NumCopies--;
	}
	
	public void ReturnItem(string name)
	{
		borrowers.Remove(name);
		libraryItem.NumCopies++;
	}
	
	public override void Display()
	{
		base.Display();

		foreach (string borrower in borrowers)
			Console.WriteLine(" borrower: " + borrower);
	}
}


class Program
{
	static void Main()
	{
		// Create book
		Book book = new Book("Worley", "Inside ASP.NET", 10);
		book.Display();

		// Create video
		Video video = new Video("Spielberg", "Jaws", 23, 92);
		video.Display();

		// Make video borrowable, then borrow and display
		Console.WriteLine("\nMaking video borrowable:");
		Borrowable borrowvideo = new Borrowable(video);
		borrowvideo.BorrowItem("Customer #1");
		borrowvideo.BorrowItem("Customer #2");
		borrowvideo.Display();
	}
}*/