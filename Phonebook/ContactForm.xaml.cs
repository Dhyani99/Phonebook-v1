using Phonebook.Models;

namespace Phonebook;

public partial class ContactForm : ContentPage
{
	public ContactForm()
	{
		InitializeComponent();
	}

	public void OnAddButtonClicked(object sender, EventArgs args)
	{
		PersonContact contact = new PersonContact();
		contact.FirstName = fn.Text;
		contact.LastName = ln.Text;
		contact.Email = email.Text;
		contact.PhoneNumber = phoneNumber.Text;
		contact.Company = companyName.Text;
		App.ContactRepo.AddNewContact(contact);
	}

	public async void OnCancelButtonClicked(object sender, EventArgs args)
	{
		await Shell.Current.GoToAsync("..");
	}






}