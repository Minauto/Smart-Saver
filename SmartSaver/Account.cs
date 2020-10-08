using SmartSaver;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

/// <summary>
/// WORK IN PROGRESS
/// </summary>

public class Account
{
	//Nick of the account
	public string Nickname { get; set; }
	//Name of the person
	public string Name { get; set; }
	//Surname of the person
	public string Surname { get; set; }
	//(Optional) Users Age
	public int Age { get; set; }
	//(Temporary) Users Password *Untill we do hashing*
	public string Password { get; set; }

	/// Functional info
	//Users Balance
	public float Balance { get; set; }


	private List<Deposit> deposits;

	//Users goal
	public float Goal { get; set; }

	public Account(string newNickname, string newName, string newSurname, string newPassword)
	{
		//Tweak, when creating log in.
		Nickname = newNickname;
		Name = newName;
		Surname = newSurname;
		//Prehash
		Password = newPassword;

		///Preset, maybe some could be writen in
		Balance = 0f;
		deposits = new List<Deposit>();
		Goal = 0f;
	}

	//Setting new goal
	public void setGoal(float GoalAmmount)
    {
		Goal = GoalAmmount;
    }

	//Function to set a new Password
	public void changePassword(string FirstNewPassword, string SecondNewPassword)
    {
		if(FirstNewPassword == SecondNewPassword)
        {
			Password = FirstNewPassword;

			//Might work? -> throw new System.Exception("Password successfully changed");
		}
        else
        {
			//Call Exception (could be broken idk, cant rly test rn)
			throw new System.Exception("Passwords don't match");
		}
    }

	public void changeNickname(string WantedNickname)
    {
		//if(WantedNickname != test_for_duplicate_nicknames)
		//{
		Nickname = WantedNickname;
        //}
    }

	public void addDeposit(int amount)
    {
		deposits.Add(new Deposit(amount));
    }

	public List<Deposit> GetDeposits()
    {
		return deposits;
    }

	public void setDeposits(List<Deposit> deposits)
    {
		this.deposits = deposits;
    }
}
