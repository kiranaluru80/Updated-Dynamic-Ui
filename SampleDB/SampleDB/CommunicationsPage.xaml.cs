using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace SampleDB
{
    public partial class CommunicationsPage : ContentPage
    {
        public List<JSSEMasterBehavior> listOfObjects;
        public CommunicationsPage()
        {
            InitializeComponent();
            Debug.WriteLine(listOfObjects);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listOfObjects = await App.Database.GetJsseBehaviors(0,1);


        }
    }
}
