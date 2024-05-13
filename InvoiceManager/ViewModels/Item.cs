using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceManager.ViewModels
{
    public class ItemViewModel
    {
        public int id;
        public int invoiceId;
        public string item;
        public double unitPrice;
        public int quantity;

        public ItemViewModel(int id, int invoiceId, string item, double unitPrice, int quantity)
        {
            this.id = id;
            this.invoiceId = invoiceId;
            this.item = item;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        public ItemViewModel(int invoiceId, string item, double unitPrice, int quantity)
        {
            this.invoiceId = invoiceId;
            this.item = item;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }
    }
}

