using SmartSaver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;

/// <summary>
/// WORK IN PROGRESS
/// </summary>

public class Account : INotifyPropertyChanged
{
	//Nick of the account
	public string Nickname { get; set; }
	//Name of the person
	private string name;
	public string Name
	{ 
		get { return name; }
        set
        {
			if (value == name) return;
			name = value;
			OnPropertyChanged("Name");
        }
	}
	//(Temporary) Users Password *Untill we do hashing*
	public string Password { get; set; }

	public int UserId { get; set; }


	//Users goal
	public int Limit { get; set; }

	public Gender gender { get; set; }

	public Account(string newNickname, string newName, int newUserId, Gender newGender, int newLimit)
	{
		Nickname = newNickname;
		Name = newName;
		UserId = newUserId;
		gender = newGender;
		Limit = newLimit;
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

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
    {
		if (PropertyChanged != null)
        {
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
