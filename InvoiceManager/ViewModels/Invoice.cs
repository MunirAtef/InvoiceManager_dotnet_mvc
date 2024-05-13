using System;
using System.Collections.Generic;

namespace InvoiceManager.ViewModels
{
    public class InvoiceViewModel : Invoice
    {
        //public int id;
        //public int clientId;
        //public DateTime invoiceDate;
        public List<ItemViewModel> items = new List<ItemViewModel>();

        public InvoiceViewModel(int clientId, DateTime invoiceDate)
        {
            this.clientId = clientId;
            this.invoiceDate = invoiceDate;
        }

        public InvoiceViewModel(int id, int clientId, DateTime invoiceDate)
        {
            this.id = id;
            this.clientId = clientId;
            this.invoiceDate = invoiceDate;
        }
    }

}