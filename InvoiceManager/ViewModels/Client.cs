using System;

namespace InvoiceManager.ViewModels
{
    public class ClientViewModel
    {
        public string fullName;
        public string imageUrl;
        public string address;

        public ClientViewModel(string fullName, string imageUrl, string address)
        {
            this.fullName = fullName;
            this.imageUrl = imageUrl;
            this.address = address;
        }
    }
}


