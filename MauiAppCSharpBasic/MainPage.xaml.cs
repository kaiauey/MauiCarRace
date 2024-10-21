using System.Data;
using System.Security.Principal;
using MauiAppCSharpBasic.Classes;
using Microsoft.VisualBasic;


namespace MauiAppCSharpBasic;

public partial class MainPage : ContentPage
{
	Car audi;
	Car nissan;

	bool isFinish = false;

	public MainPage()
	{
		InitializeComponent();

		audi = new Car("A1", 220, 10);
		audi.UseFuelRate = 10;
		nissan = new Car("S1", 180, 3);
		nissan.UseFuelRate = 8;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (!this.isFinish)
		{
			var screenWidth = Application.Current.MainPage.Width;
			this.AudiRun(screenWidth);
			this.NissanRun(screenWidth);
			this.myLabel.Text = audi.ShowInfo() + "\n" + nissan.ShowInfo();
			this.isFinish = true;
		}
		else
		{
			ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);
			ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
			this.isFinish = false;
		}
		//audi = new Car("A1", 220, 50);
		//nissan = new Car("S1", 180, 60);
		//audi.Run(10);
		//nissan.Run(5);

		//myLabel.Text = audi.ShowInfo() +"\n"+nissan.ShowInfo();
	}

	private void AudiRun (double distance)
	{
		var timeuse = audi.TimeUseForRun(distance);
		ImageCar1.TranslateTo(distance - 100, 0, timeuse*1000, Easing.Linear);
	}
	
	private void NissanRun(double distance)
	{
		var timeuse = nissan.TimeUseForRun(distance);
		ImageCar2.TranslateTo(distance - 100, 0, timeuse*1000, Easing.Linear);
	}


	/*
	//int score1 = 80;
	//int score2 = 90;
	//string name1 = "a";
	//string name2 = "b";
	int[] score = {80, 90, 71, 55, 67};
	string[] name = {"a", "b", "c", "d", "e"};
	double[]  gpa = {3.75, 2.5, 3.44, 2.87, 2.10};

	string text = "";
	foreach(var s in score)
	{
		text += $"score { s }, " ;
	}
	myLabel.Text = text;
	*/
	/*
	string text = "";
	for (int i=0 ; i < score.Length ; i++)
	{
		text = text + score[i] + " ";
	}

	myLabel.Text = text;
	*/
	/*
	string star = "" ;
	// i++	 i = i+1

	*
	**
	***
	****
	*****

	int i = 0;
	while( i < 10 )
	{
		for(int j=0 ; j<=i ; j++)
		{
			star = star + "*";
		}
		//star = star + "\n"
		star += "\n";
		i++;
	}

	myLabel.Text = star;
	*/
	/*
	int age = 25;
	string name = "Pemika";
	float gpa = 3.75f;
	bool isGraduated = false;
	double pi = 3.14104198532;
	int score = 60;

	if (gpa >= 3.75)
	{
		myLabel.Text = "เกียรตินิยม";
	}
	else
	{
		myLabel.Text = "Good";
	}

	if(score > 80)
	{
		myLabel.Text = "A";
	}
	else if(score > 70)
	{
		myLabel.Text = "B";
	}
	else if(score > 60)
	{
		myLabel.Text = "C";
	}
	else if(score > 50)
	{
		myLabel.Text = "D";
	}
	else
	{
		myLabel.Text = "F";
	}
	*/
	/*
	//myLabel.Text = GetGreetingMessage("Auey",80);
	//UpdataLabelText("Auey",80);
	UpdataLabelText();
}

private string GetGreetingMessage()
{
	return $"Hello unknown";
}

private string GetGreetingMessage(string name)
{
	return $"Hello {name}";
}

private string GetGreetingMessage(string name, int score)
{
	return $"Hello {name} your score is {score}";
}

private void UpdataLabelText(string name, int score)
{
	myLabel.Text = $"Hello {name} your score is {score}";
}

	private void UpdataLabelText()
{
	string[] name = {"a", "b", "c"};
	int[] score = {5, 10, 15};
	string text="";
	for(int i=0 ; i<3 ; i++)
	{
		text += $"Hello {name[i]} your score is {score[i]} \n";
	}
	myLabel.Text = text;
	*/

}

