﻿using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace LoginPage
{
	public partial class CustomerDetailPage : ContentPage
	{

		private PrescriberViewModel ViewModel { get { return BindingContext as PrescriberViewModel; } }
		public CustomerDetailPage()
		{
			InitializeComponent();
		}

		public CustomerDetailPage(Prescriber contact)
		{
			InitializeComponent();
			this.fullname.Text = contact.fullname;
			this.phonenumber.Text = contact.telephone1;
			this.description.Text = contact.description;
			this.designation.Text = contact.vcm_prescriberspeciality;
			this.firstName.Text = contact.firstname;
			this.middleName.Text = contact.middlename;
			this.lastName.Text = contact.lastname;
			this.speciality.Text = contact.vcm_prescriberspeciality;
			this.email.Text = contact.emailaddress1;
			this.phone1.Text = contact.telephone1;
			this.phone2.Text = contact.mobilephone;
			this.address.Text = contact.address1_line1 + " " + contact.address1_line2 + " " + contact.address1_line3;
			this.city.Text = contact.address1_city;
			this.stateCode.Text = contact.statecode.ToString();

		}

		public CustomerDetailPage(Account contact)
		{
			InitializeComponent();
			this.fullname.Text = contact.fullname;
			this.phonenumber.Text = contact.telephone1;
			this.description.Text = contact.description;
			this.designation.Text = contact.vcm_prescriberspeciality;
			this.firstName.Text = contact.fullname;
			//this.middleName.Text = contact.middlename;
			//this.lastName.Text = contact.lastname;
			this.speciality.Text = contact.vcm_prescriberspeciality;
			this.email.Text = contact.emailaddress1;
			this.phone1.Text = contact.telephone1;
			this.phone2.Text = contact.mobilephone;
			this.address.Text = contact.address1_line1 + " " + contact.address1_line2 + " " + contact.address1_line3;
			this.city.Text = contact.address1_composite;
			this.stateCode.Text = contact.statecode.ToString();

		}

		async void Handle_LogCall_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushPopupAsync(new LogCallView());

		}

	}
}
